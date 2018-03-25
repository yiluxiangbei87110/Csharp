<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="myWeb.Asp.adminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script>
        window.onload = function () {
            var validateImg = document.getElementById('validateImg');
            var nextImg = document.getElementById('nextImg');
            nextImg.onclick = function () {
                validateImg.src = "validateImgCode.ashx?id=" + new Date().getMilliseconds();
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名:<input type="text" name="txtName" /><br />
            密&nbsp;&nbsp;码 :<input type="password" name="txtPwd" /><br />
            验证码:<input type="text" name="txtCode"/>
            <img src="validateImgCode.ashx"  id="validateImg" />
            <a href="javascript:void(0)"  id="nextImg">看不清</a><br />
            <p><input type="checkbox" name="autoLogin" value="auto"/>记住用户名</p>
            <input type="submit" value="登录" /><br />
            <span style="color:red;font-size:30px"><%=Msg %></span>
        </div>
    </form>
</body>
</html>
