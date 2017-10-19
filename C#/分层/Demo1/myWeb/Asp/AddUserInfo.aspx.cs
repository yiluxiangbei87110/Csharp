using demo1.model;
using Demo1.bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myWeb.Asp
{
	public partial class AddUserInfo : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            //如果隐藏域的值不为空的话，则是post请求，此时可以处理。
            if (!string.IsNullOrEmpty(Request.Form["flag"]))
            {
                AddUsers();
            }
        }
        protected void AddUsers()
        {

            UserInfo userInfo = new UserInfo();
            userInfo.UserName = Request.Form["txtName"];
            userInfo.UserPass = Request.Form["txtPwd"];
            userInfo.RegTime = DateTime.Now;
            UserInfoService userInfoService = new UserInfoService();
            if (userInfoService.AddUserInfo(userInfo))
            {
                Response.Redirect("UserInfoAsp.aspx");
            }
            else
            {
                Response.Redirect("error.html");
            }
        }
    }
}