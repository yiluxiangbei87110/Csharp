using demo1.model;
using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.Ajax
{
    /// <summary>
    /// AddUserInfo 的摘要说明
    /// </summary>
    public class AddUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            UserInfo userInfo = new UserInfo();
            userInfo.UserName = context.Request["txtUserName"];
            userInfo.UserPass = context.Request["txtUserPwd"];
            userInfo.RegTime = DateTime.Now;
            UserInfoService UserInfoService = new UserInfoService();
            if (UserInfoService.AddUserInfo(userInfo))
            {
                context.Response.Write("ok");
            }
            else
            {
                context.Response.Write("no");
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