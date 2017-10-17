using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.Asp
{
    /// <summary>
    /// Delete 的摘要说明
    /// </summary>
    public class Delete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id;
            if (int.TryParse(context.Request.QueryString["id"],out id))
            {
                UserInfoService userInfoService = new UserInfoService();
                if (userInfoService.DeleteUser(id))
                {
                    context.Response.Redirect("UserInfoAsp.aspx");
                }else
                {
                    context.Response.Write("删除失败");
                }
            }else
            {
                context.Response.Write("参数获取失败");
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