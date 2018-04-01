using demo1.model;
using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.Ajax
{
    /// <summary>
    /// EditUserInfoAjax 的摘要说明
    /// </summary>
    public class EditUserInfoAjax : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            UserInfo userInfo = new UserInfo();
            userInfo.UserName = context.Request["txtEditUserName"];
            userInfo.UserPass = context.Request["txtEditUserPwd"];
            userInfo.Id =Convert.ToInt32(context.Request["txtEditUserId"]);
            userInfo.RegTime = Convert.ToDateTime(context.Request["txtEditRegTime"]);
            UserInfoService userInfoService = new UserInfoService();
            if (userInfoService.EditUserInfo(userInfo) > 0)
            {
                context.Response.Write("yes");
            }
            else
            {
                context.Response.Write("error");
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