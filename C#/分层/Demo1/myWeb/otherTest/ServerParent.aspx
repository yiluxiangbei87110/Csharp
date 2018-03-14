<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerParent.aspx.cs" Inherits="myWeb.otherTest.ServerParent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<%--        <p>我是父元素内容</p>
       <%Server.Execute("ServerChild.aspx"); %>
       <hr />
        <%Server.Transfer("ServerChild.aspx"); %>

        <p>测试Server.htmlEncode  xss 跨站脚本攻击(Cross Site Scripting)</p>--%>
        <%=Server.HtmlEncode("<script>alert(123)</script>") %>
        <%=Server.HtmlDecode("<font color='red'>123</font>") %>
        <%=Server.HtmlDecode("<script>alert(123)</script>") %>
    </div>
    </form>
</body>
</html>
