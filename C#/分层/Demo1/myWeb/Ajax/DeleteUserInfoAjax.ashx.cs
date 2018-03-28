using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.Ajax
{
    /// <summary>
    /// DeleteUserInfoAjax 的摘要说明
    /// </summary>
    public class DeleteUserInfoAjax : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request.Form["id"]);
            UserInfoService userInfoService = new UserInfoService();
            if (userInfoService.DeleteUser(id))
            {
                context.Response.Write("{\"status\":0,\"msg\":\"ok\"}");
            }
            else
            {
                context.Response.Write("{\"status\":1,\"msg\":\"error\"}");
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