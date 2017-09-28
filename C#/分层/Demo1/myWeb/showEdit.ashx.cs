
using demo1.model;
using Demo1.bll;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace myWeb
{
    /// <summary>
    /// showEdit 的摘要说明
    /// </summary>
    public class showEdit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            int id = int.Parse(context.Request.QueryString["id"]);
            UserInfoService userInfoService = new UserInfoService();
            UserInfo userInfo =userInfoService.GetUserInfo(id);
            //获取到了userInfo，我们就可以获取到属性，然后调用方法。
            if (userInfo != null)
            {
                string filePath = context.Request.MapPath("showEdit.html");
                string fileContent = File.ReadAllText(filePath);
                fileContent = fileContent.Replace("$uid", userInfo.UserName).Replace("$pwd", userInfo.UserPass).Replace("$ID", userInfo.Id.ToString());
                context.Response.Write(fileContent);
            }else
            {
                context.Response.Write("查无此人");
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