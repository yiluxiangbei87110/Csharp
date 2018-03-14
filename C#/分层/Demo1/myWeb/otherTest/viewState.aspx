<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewState.aspx.cs" Inherits="myWeb.otherTest.viewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <<p>通过viewstate实现自增</p>
    <form id="form1" runat="server">
    <div>
        <span><%=result %></span>
        <input type="submit" value="计算"/>
    </div>
    </form>
</body>
</html>
