
using demo1.model;
using Demo1.DAL;
using Demo1.bll;
using Demo1.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb
{
    /// <summary>
    /// AddUser 的摘要说明
    /// </summary>
    public class AddUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string userName = context.Request.Form["txtName"];
            string txtPwd = context.Request.Form["txtPwd"];
            UserInfo userInfo = new UserInfo();
            userInfo.UserName = userName;
            userInfo.UserPass = txtPwd;
            userInfo.RegTime = DateTime.Now;
            //把对象传到也
            UserInfoService userInfoService = new UserInfoService();
            if (userInfoService.AddUserInfo(userInfo))
            {
                context.Response.Redirect("UserInfoList.ashx");
            }else
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