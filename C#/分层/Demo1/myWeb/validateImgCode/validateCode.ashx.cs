﻿using demo1.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.validateImgCode
{
    /// <summary>
    /// validateCode 的摘要说明
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