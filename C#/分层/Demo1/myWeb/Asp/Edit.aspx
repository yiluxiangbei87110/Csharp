<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="myWeb.Asp.Edit" %>
<%@ Import Namespace="demo1.model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名:<input type="text" name="txtName" value="<%=EditUserInfo.UserName %>" /><br />
            密码:<input type="text" name="txtPwd" value="<%=EditUserInfo.UserPass %>" /><br />
            <input type="hidden" name="txtId" value="<%=EditUserInfo.Id %>" />
            <input type="submit" value="提交" />
        </div>
    </form>
</body>
</html>
