using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.Ajax
{
    /// <summary>
    /// testLoginName 的摘要说明
    /// </summary>
    public class testLoginName : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string username = context.Request["name"];
            UserInfoService userInfoService = new UserInfoService();
            if (userInfoService.GetUserInfo(username)!=null)
            {
                context.Response.Write("用户名已经存在");
            }else
            {
                context.Response.Write("用户名可用");
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