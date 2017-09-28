using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo1.bll;
using demo1.model;
using System.Text;
using System.IO;

namespace myWeb
{
    /// <summary>
    /// UserInfoList 的摘要说明
    /// </summary>
    public class UserInfoList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            UserInfoService userInfoService = new UserInfoService();
            List<UserInfo> list = userInfoService.GetList2();
            StringBuilder sb = new StringBuilder();
            foreach (UserInfo userInfo in list)
            {
                sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td><a href='showDetail.ashx?id={0}'>详细内容</a></td><td class='deletes'><a href='DeleteUser.ashx?id={0}'>删除</a></td><td><a href='showEdit.ashx?id={0}'>编辑</a></td></tr>", userInfo.Id, userInfo.UserName, userInfo.UserPass,  userInfo.RegTime);
            }
            //读取模板文件
            string filePath = context.Request.MapPath("UserInfoList.html");
            string fileCotent = File.ReadAllText(filePath);
            fileCotent = fileCotent.Replace("@tbody", sb.ToString());
            context.Response.Write(fileCotent);
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