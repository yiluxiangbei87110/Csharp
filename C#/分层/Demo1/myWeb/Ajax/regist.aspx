<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regist.aspx.cs" Inherits="myWeb.Ajax.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="http://libs.baidu.com/jquery/2.0.0/jquery.min.js"></script>
    <script>
        //通过ajax判断注册的用户名是否存在
        $(document).ready(function () {
            $("#txtName").blur(function () {
                var username = $(this).val();
                console.log(username);
                if (username != '') {
                    $.post("testRegName.ashx", { "name": username }, function (data) {
                        $("#msg").text(data);
                    });
                } else {
                    alert("empty");
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名:<input type="text" name="txtName" id="txtName" /><span id="msg" style="color:red;font-size:20px;"></span><br />
            密&nbsp;&nbsp;码 :<input type="password" name="txtPwd" id="txtPwd"/><br />
            <input type="button" value="注册" id="loginBtn" />
        </div>
    </form>
</body>
</html>
