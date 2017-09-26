using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb
{
    /// <summary>
    /// DeleteUser 的摘要说明
    /// </summary>
    public class DeleteUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id;
            if (int.TryParse(context.Request.QueryString["id"],out id))
            {
                //删除这个id的消息
                UserInfoService userInfoService = new UserInfoService();
                if (userInfoService.DeleteUser(id))
                {
                    context.Response.Redirect("UserInfoList.ashx");
                }
                else
                {
                    context.Response.Redirect("http://www.baidu.com");
                }
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