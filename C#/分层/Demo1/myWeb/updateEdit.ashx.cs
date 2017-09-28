using demo1.model;
using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb
{
    /// <summary>
    /// updateEdit 的摘要说明
    /// </summary>
    public class updateEdit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            UserInfo userInfo = new UserInfo();
            userInfo.UserName = context.Request.Form["txtName"];
            userInfo.UserPass = context.Request.Form["txtPwd"];
            userInfo.Id = int.Parse(context.Request.Form["txtId"]);
            UserInfoService userInfoService = new UserInfoService();
            //为了考虑时间问题，我们可以先查一次.
            //UserInfo userInfo=userInfoService.GetUserInfo();
            //userInfo.Id=id;
            //------
            if (userInfoService.EditUserInfo(userInfo)>0)
            {
                context.Response.Redirect("UserInfoList.ashx");
            }else
            {
                context.Response.Write("修改失败");
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