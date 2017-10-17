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
    public partial class UserInfoAsp : System.Web.UI.Page
    {
        public List<UserInfo> userList
        {
            set;
            get;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfoService userInfoService = new UserInfoService();
            List<UserInfo> list = userInfoService.GetList2();
            userList = list;

        }
    }
}