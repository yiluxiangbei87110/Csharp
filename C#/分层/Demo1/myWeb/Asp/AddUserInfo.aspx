<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUserInfo.aspx.cs" Inherits="myWeb.Asp.AddUserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <form method="post" action="AddUser.ashx">
        用户名:<input type="text" name="txtName" /><br />
        密码:<input type="password" name="txtPwd" /><br />
        <input type="submit" value="添加用户" />
    </form>
    </div>
    </form>
</body>
</html>
