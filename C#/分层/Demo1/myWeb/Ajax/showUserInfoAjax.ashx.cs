using demo1.model;
using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.Ajax
{
    /// <summary>
    /// showUserInfoDetail 的摘要说明
    /// </summary>
    public class showUserInfoDetail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = Convert.ToInt32(context.Request.Form["id"]);
            UserInfoService userInfoService = new UserInfoService();
            UserInfo userInfo=userInfoService.GetUserInfo(id);
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            context.Response.Write(js.Serialize(userInfo));
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