using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.otherTest
{
    /// <summary>
    /// testGetAjax 的摘要说明
    /// </summary>
    public class testGetAjax : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(context.Request.QueryString["name"]+DateTime.Now.ToString());
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