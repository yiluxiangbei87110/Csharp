using demo1.model;
using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
namespace myWeb
{
    /// <summary>
    /// showDetail 的摘要说明
    /// </summary>
    public class showDetail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //不判断了，反正id是有的。
            int id = int.Parse(context.Request.QueryString["id"]);
            UserInfoService userInfoService = new UserInfoService();
            UserInfo userInfo = userInfoService.GetUserInfo(id);
            if (userInfo != null)
            {
                string filePath = context.Request.MapPath("showDetail.html");
                string content = File.ReadAllText(filePath);
                content = content.Replace("$name",userInfo.UserName).Replace("$pwd", userInfo.UserPass);
                context.Response.Write(content);
            }
            else
            {
                context.Response.Redirect("http://www.baidu.com");
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