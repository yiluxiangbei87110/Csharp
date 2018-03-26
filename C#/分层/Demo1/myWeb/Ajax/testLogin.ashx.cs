using demo1.model;
using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.Ajax
{
    /// <summary>
    /// testLogin 的摘要说明
    /// </summary>
    public class testLogin : IHttpHandler,System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string username = context.Request.Form["userName"];
            string userpass = context.Request.Form["userPwd"];
            //检查用户名和密码是否有效
            UserInfoService userInfoService = new UserInfoService();
            UserInfo userInfo = null;
            string msg = string.Empty;
            bool isValid=userInfoService.ValidateUseInfo(username, userpass, out msg, out userInfo);
            if (isValid)
            {
                context.Session["userInfo"] = userInfo;
                context.Response.Write("ok:" + msg);
            }else
            {
                context.Response.Write("no:" + msg);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}