<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SpotifyAPIApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--stylesheet--%>
    <link rel="stylesheet" type="text/css" href="~/Style/Default.css" />
</head>
<body>
    <form runat="server">
        <div class="container">
            <label for="uname"><b>Username</b></label>
            <asp:TextBox placeholder="Enter Username" ID="txtUser" runat="server" required="true" />
            <label for="psw"><b>Password</b></label>
            <asp:TextBox runat="server" placeholder="Enter Password" ID="txtPw" required="true" />
            <asp:Button Text="Login" runat="server" ID="btnLogin" OnClick="btnLogin_Click"/>
            <label>
                <asp:CheckBox Checked="true" ID="chkbxRemember" runat="server" />
                Remember me
            </label>
            <asp:Label runat="server" ID="lblOutput"></asp:Label>
        </div>
    </form>
</body>
</html>
