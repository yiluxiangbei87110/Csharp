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
        用户名:<input type="text" name="txtName" /><br />
        密码:<input type="password" name="txtPwd" /><br />
       <%-- 因为asp程序是先加载对应的cs格式文件的内容，当点击新增超链接时候这时候是get请求，当点击submit时候，这是post请求。
        点击超链接的时候，跳到这个页面，但不应该处理。我们有两种方式解决这个问题，一是隐藏域，二是自带--%>
        <input type="hidden" name="flag" value="isFlag" />
        <input type="submit" value="添加用户" />

    </div>
    </form>
</body>
</html>
