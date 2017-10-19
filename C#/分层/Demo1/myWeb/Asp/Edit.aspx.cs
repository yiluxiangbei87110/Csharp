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
    public partial class Edit : System.Web.UI.Page
    {
        public UserInfo EditUserInfo
        {
            get;
            set;
        }
        UserInfoService userInfoService = new UserInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowEditUserInfo();
            }
            else
            {
                EditUser();
            }
            
        }
        protected void ShowEditUserInfo()
        {
            int id;
            if(int.TryParse(Request.QueryString["id"],out id))
            {
                //UserInfoService userInfoService = new UserInfoService();
                UserInfo userInfo=userInfoService.GetUserInfo(id);
                if (userInfo != null)
                {
                    EditUserInfo = userInfo;

                }else
                {
                    Response.Write("http://www.baidu.com");
                }
                
            }else
            {
                Response.Write("http://www.baidu.com");
            }
        }
        protected void EditUser()
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Id = int.Parse(Request.Form["txtId"]);
            userInfo.UserName = Request.Form["txtName"];
            userInfo.UserPass = Request.Form["txtPwd"];
            //UserInfoService userInfoService = new UserInfoService();
            if (userInfoService.EditUserInfo(userInfo)>0)
            {
                Response.Redirect("UserInfoAsp.aspx");
            }else
            {
                Response.Redirect("htttp://www.baidu.com");
            }


        }
    }
}