<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CURD.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset style="width:150px; margin-left:550px; margin-top:200px">
                <legend>Login</legend>
                <asp:TextBox ID="txtUserid" runat="server"></asp:TextBox><br /><br />
                <asp:TextBox ID="txtUserPass" runat="server" TextMode="Password"></asp:TextBox><br /><br />
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </fieldset>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
