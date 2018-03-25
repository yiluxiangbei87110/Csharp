using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.otherTest
{
    /// <summary>
    /// testAjaxPost1 的摘要说明
    /// </summary>
    public class testAjaxPost1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(context.Request.Form["id"]);
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