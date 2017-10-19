<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfoAsp.aspx.cs" Inherits="myWeb.Asp.UserInfoAsp" %>
<%@ Import Namespace="demo1.model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../css/common.css" rel="stylesheet" />
    <script>
        window.onload = function () {
            var deletes_arr = document.getElementsByClassName("deletes");
            for (var i = 0; i < deletes_arr.length; i++) {
                deletes_arr[i].onclick = function () {
                    if (!confirm("你确定要删除这个数据吗")) {
                        return false;
                    }
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p><a href="AddUserInfo.aspx">添加用户</a></p>
      <table id="table">
        <tr>
            <th>id</th>
            <th>用户名</th>
            <th>密码</th>
            <th>更新时间</th>
            <th>详细内容</th>
            <th>删除</th>
            <th>编辑</th>
        </tr>
        <%--上面要导入model--%>
        <% foreach (UserInfo userInfo in userList) {%>
            <tr>
                <td><%=userInfo.Id %></td>
                <td><%=userInfo.UserName %></td>
                <td><%=userInfo.UserPass %></td>
                <td><%=userInfo.RegTime.ToShortDateString() %></td>
                <td>详细内容</td>
                <td><a href="Delete.ashx?id=<%=userInfo.Id %>" class="deletes">删除</a></td>
                <td><a href="Edit.aspx?id=<%=userInfo.Id %>">编辑</a></td>
            </tr>
        <%} %>
    </table>
    </div>
    </form>
</body>
</html>
