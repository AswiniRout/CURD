<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Encryption_Insert.aspx.cs" Inherits="CURD.Encryption_Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <table border="0">
    <tr>
        <td>
            User Id:
        </td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server" Text="" />
        </td>
    </tr>
    <tr>
        <td>
            Password:
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
           <br /> <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" Text="Submit" runat="server" />
        </td>
    </tr>
</table>
        <br /><br />
<asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="#666666"
    HeaderStyle-ForeColor="White" RowStyle-BackColor="#cccccc" OnRowDataBound = "gvUsers_RowDataBound">
    <Columns>
        <asp:BoundField DataField="UserId" HeaderText="User Id" />
        <asp:BoundField DataField="Password" HeaderText="Encryption" />
        <asp:BoundField DataField="Password" HeaderText="Desryption" />
    </Columns>
</asp:GridView>
    </form>
</body>
</html>
