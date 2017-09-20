<%@ WebHandler Language="C#" Class="index" %>

using System;
using System.Web;


public class index : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write("到达了请求页面");
        string flag = context.Request.QueryString["flag"] ?? context.Request.Form["flag"];
        string userName = "";
        string userPwd = "";
        if (flag == "1")
        {
            userName = context.Request.QueryString["uid"];//接收的是表单元素name属性的值
            userPwd = context.Request.QueryString["pwd"];
        }else
        {
            userName = context.Request.Form["uid"];//接收的是表单元素name属性的值
            userPwd = context.Request.Form["pwd"];
        }

        context.Response.Write("用户名是:"+userName+",密码是:"+userPwd);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}

