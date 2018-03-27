using demo1.model;
using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWeb.Ajax
{
    /// <summary>
    /// UserInfoListAjax 的摘要说明
    /// </summary>
    public class UserInfoListAjax : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            UserInfoService userInfoService = new UserInfoService();
            //为什么这里哟啊这样引用
            List<UserInfo> list = userInfoService.GetList2();

            //将数据序列化为json字符串
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string result = js.Serialize(list);
            context.Response.Write(result);
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