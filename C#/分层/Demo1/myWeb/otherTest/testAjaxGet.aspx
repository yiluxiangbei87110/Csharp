<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testAjaxGet.aspx.cs" Inherits="myWeb.otherTest.testAjaxGet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
        window.onload = function () {
            var btn = document.getElementById('btn');
            btn.onclick = function () {
                var xhr;
                if (XMLHttpRequest) {
                    xhr = new XMLHttpRequest();
                } else {
                    xhr = new ActiveXObject("Microsoft.XMLHTTP");
                }
                xhr.open("get", "testGetAjax.ashx?name=Felix", true);
                xhr.send();
                xhr.onreadystatechange = function () {
                    if (xhr.readyState == 4) {
                        if (xhr.status == 200) {
                            alert(xhr.responseText);
                        }
                    }
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="button" value="获取服务器端时间" id="btn" />
    </div>
    </form>
</body>
</html>
