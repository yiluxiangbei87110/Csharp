using demo1.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.validateImgCode
{
    /// <summary>
    /// 写出一个验证码图形
    /// 一般处理程序使用时session程序的时候，必须要实现 System.Web.SessionState.IReadOnlySessionState接口
    /// </summary>
    public class validateCode : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            ValidateCode validateCode = new ValidateCode();
            string code= validateCode.CreateValidateCode(4);
            validateCode.CreateValidateGraphic(code,context);
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