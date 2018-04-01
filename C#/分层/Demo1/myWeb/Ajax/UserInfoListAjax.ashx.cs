using demo1.common;
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
            int pageIndex;
            int pageSize = 5;
            if(!int.TryParse(context.Request["pageIndex"],out pageIndex))
            {
                pageIndex = 1;
            }
            
            UserInfoService userInfoService = new UserInfoService();
            int pageCount = userInfoService.GetPageCount(pageSize);
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;
            pageIndex = pageIndex < 1 ? 1 : pageIndex;

            // List<UserInfo> list = userInfoService.GetList2();
            //获取分页数据
            List<UserInfo> list=userInfoService.GetPageList(pageIndex,pageSize);

            //获取页码条
            string pageBar=PageBar.GetpageBar(pageIndex,pageCount);

            //将数据序列化为json字符串
            //注意匿名类的使用
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            //string result = js.Serialize(list);
            string result = js.Serialize(new {UList=list,PageBar= pageBar });
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