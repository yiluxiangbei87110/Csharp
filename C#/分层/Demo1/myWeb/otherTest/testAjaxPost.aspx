<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testAjaxPost.aspx.cs" Inherits="myWeb.otherTest.testAjaxPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
        window.onload = function () {
            document.querySelector('#btn').onclick = function () {
                var xhr;
                if (XMLHttpRequest) {
                    xhr = new XMLHttpRequest();
                } else {
                    xhr = new ActiveXObject("Microst.XMLHTTP");
                }
                xhr.open("post", "testAjaxPost.ashx", true);
                xhr.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
                xhr.send("name=Felix&id=123");
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
        <input type="button" value="This is test post method" id="btn" />
    </div>
    </form>
</body>
</html>
