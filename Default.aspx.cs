using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    string[] sl = { "Student number", "Student Name", "Mark", "Password" };
    DatabaseHandler dbh;
    SqlConnection sConn;
    private SqlCommand sCmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        dbh = new DatabaseHandler("StudentList",sl);
        sConn = dbh.getConn();
        LoadData();
    }

    void LoadData()
    {
        GridView1.DataSource = dbh.getTableDataAs(new string[,] { { "Student number", "Student Name", "Mark", "Password" }, { "Student Number", "Student Name", "Student Mark", "Student Password" } });
        GridView1.DataBind();
        ddlStudentNum.Items.Clear();
        List<string> ids = dbh.getTableIDs("StudentList");
        for(int x = 0; x < ids.Count; ++x)
        {
            ddlStudentNum.Items.Add(ids[x]);
        }
    }
    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        string[] temp = { "'"+tbSNumber.Text+"'", "'" + tbSName.Text + "'",  tbSMark.Text , "'" + tbSPassword.Text + "'" };
        sConn.Open();
        SqlCommand dbCMB = sConn.CreateCommand();
        dbCMB = new SqlCommand("INSERT INTO StudentList Values ('" + tbSNumber.Text + "','" +
          tbSName.Text + "'," + tbSMark.Text + ",'" + tbSPassword.Text + "')", sConn);
        dbCMB.ExecuteNonQuery();
        sConn.Close();
        LoadData();
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        sConn.Open();
        SqlCommand dbCMB = sConn.CreateCommand();
        dbCMB = new SqlCommand("DELETE FROM StudentList WHERE [Student number] ='" + ddlStudentNum.Text + "'", sConn);
        dbCMB.ExecuteNonQuery();
        sConn.Close();
        LoadData();
    }

    protected void BtnUpdate_Click(object sender, EventArgs e)
    {
        sConn.Open();
        SqlCommand dbCMB = sConn.CreateCommand();
        dbCMB = new SqlCommand("UPDATE StudentList SET [Student number]='" + ddlStudentNum.Text + "',[Student Name]='" +
            tbSName.Text + "',Mark=" + tbSMark.Text + ", Password = '"+tbSPassword.Text+"' WHERE [Student number]='" + ddlStudentNum.Text + "'", sConn);
        dbCMB.ExecuteNonQuery();
        sConn.Close();
        LoadData();
    }
}