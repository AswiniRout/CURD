<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="CURD.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnView" runat="server" Text="View"  OnClick="btnView_Click"/>
            User:<asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
            Password:<asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit"  OnClick="btnSubmit_Click"/>
        </div>
    </form>
</body>
</html>
