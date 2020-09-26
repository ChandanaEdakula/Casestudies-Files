<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WCFWebClient.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Consuming WCF Service in ASP.NET Web Client</strong></div>
        <p>
            <table border="1" style="width: 70%;">
                <tr>
                    <td>Ecode :
            </td>
                    <td>
            <asp:TextBox ID="txtEcode" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFindById" runat="server" Text="Find By Id" OnClick="btnFindById_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Ename :</td>
                    <td><asp:TextBox ID="TxtEname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Salary :</td>
                    <td><asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Deptid :</td>
                    <td><asp:TextBox ID="txtDeptid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
            <asp:Button ID="btnAddEmp" runat="server" Text="Add Emp" OnClick="btnAddEmp_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
        <p>
            <asp:Button ID="btnDivide" runat="server" OnClick="btnDivide_Click" Text="Custom Exception" />
        </p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="147px" Width="367px">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    </form>
</body>
</html>
