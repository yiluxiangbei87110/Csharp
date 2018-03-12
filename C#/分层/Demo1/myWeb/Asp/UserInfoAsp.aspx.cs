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
        public int currentPageIndex { set; get; }
        public int totalPageCount { set; get; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //显示所有的数据
            //UserInfoService userInfoService = new UserInfoService();
            //List<UserInfo> list = userInfoService.GetList2();
            //userList = list;

            //分页显示数据
            int pageSize = 10;
            int pageIndex;
            if(!int.TryParse(Request.QueryString["pageIndex"], out pageIndex))
            {
                pageIndex = 1;
            }
            //获取总的页数
            UserInfoService userInfoService = new UserInfoService();
            int pageCount= userInfoService.GetPageCount(pageSize);
            
            //判断页数范围
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            currentPageIndex = pageIndex;
            totalPageCount = pageCount;
            List<UserInfo> list = userInfoService.GetPageList(pageIndex, pageSize);
            userList = list;
        }
    }
}