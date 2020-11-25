<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 style="text-align: center; font-size: 100px;">Student List Viewer</h1>
    </div>

    <div class="row" id="display1">
        <div class="col-md-4" style="text-align: center;">
            <h2>Student Number</h2>
            <p>
                <asp:TextBox ID="tbSNumber" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="col-md-4" style="text-align: center;">
            <h2>Student Name</h2>
            <p>
                <asp:TextBox ID="tbSName" runat="server"></asp:TextBox>
            </p>
            <p>
                &nbsp;</p>
            <h2>Student Password</h2>
                <asp:TextBox ID="tbSPassword" runat="server"></asp:TextBox>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                <asp:DropDownList ID="ddlStudentNum" runat="server">
                </asp:DropDownList>
            </p>
        </div>
        <div class="col-md-4" style="text-align: center;">
            <h2>Student Mark</h2>
            <p>
                <asp:TextBox ID="tbSMark" runat="server"></asp:TextBox>
            </p>
        </div>
    </div>
    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="70px" OnClick="btnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="70px" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="70px" OnClick="btnDelete_Click" />
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center">
        <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center"></asp:GridView>
    </asp:Panel>
    
    </asp:Content>
