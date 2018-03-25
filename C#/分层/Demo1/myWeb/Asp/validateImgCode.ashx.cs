using demo1.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.Asp
{
    /// <summary>
    /// 一般处理程序使用时session程序的时候，必须要实现 System.Web.SessionState.IRequiresSessionState
    /// validateImgCode 的摘要说明
    /// </summary>
    /// 
    public class validateImgCode : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
            ValidateCode validateCode = new ValidateCode();
            string code=validateCode.CreateValidateCode(4);

            //将验证码写入session
            context.Session["validateCode"] = code;
            validateCode.CreateValidateGraphic(code, context);

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
