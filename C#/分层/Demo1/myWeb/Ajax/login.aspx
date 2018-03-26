<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="myWeb.Ajax.login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <script src="http://libs.baidu.com/jquery/2.0.0/jquery.min.js"></script>
    <script>
        //通过ajax判断登录
        $(document).ready(function () {
            $("#loginBtn").click(function () {
                var username = $("#txtName").val();
                var password = $("#txtPwd").val();
                if (username!='' && password!='') {
                    checkLoginInfo(username, password);
                } else {
                    $("#msg").text('用户名和密码不能为空');
                }
            });

            function checkLoginInfo(username, password) {
                $.post("testLogin.ashx", { "userName": username, "userPwd": password }, function (data) {
                    console.log(12)
                    if (data.split(":")[0] == "ok") {
                        window.location.href = "./../Asp/UserInfoAsp.aspx";
                        }else{
                        $("#msg").text(data.split(":")[1]);
                    }
                });
            }

        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名:<input type="text" name="txtName" id="txtName" /><br />
            密&nbsp;&nbsp;码 :<input type="password" name="txtPwd" id="txtPwd"/><br />
            <span id="msg" style="color:red;font-size:20px;"></span>
            <input type="button" value="登录" id="loginBtn" />
        </div>
    </form>
</body>
</html>
