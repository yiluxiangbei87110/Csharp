using demo1.common;
using demo1.model;
using Demo1.bll;
using System;
using System.Web;


namespace myWeb.Asp
{
    public partial class adminLogin : System.Web.UI.Page
    {
        public string Msg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (checkValidCode())
                {
                    checkUseInfo();
                }
                else
                {
                    Msg = "验证码输入错误";
                }
            }
            else
            {
                Response.Write("zouddaoc");
                checkCookieInfo();
                //登录成功返回页面的时候不能在给其看到登陆页面
                if (Session["userInfo"] != null)
                {
                    Response.Redirect("UserInfoAsp.aspx");
                }
            }
        }

        protected void checkUseInfo()
        {
            string username = Request.Form["txtName"];
            string password = Request.Form["txtPwd"];
            //校验用户名和密码
            string msg = String.Empty;
            UserInfo userInfo = null;
            UserInfoService userInfoService = new UserInfoService();
            if (userInfoService.ValidateUseInfo(username, password, out msg, out userInfo))
            {
                //判断用户是否勾选自动登录（如果有的话需要记录cookie）
                if (!string.IsNullOrEmpty(Request.Form["autoLogin"]))
                {
                    HttpCookie cookie1 = new HttpCookie("username", username);
                    HttpCookie cookie2 = new HttpCookie("password", Md5Common.GetMd5String(Md5Common.GetMd5String(password)));
                    cookie1.Expires = DateTime.Now.AddDays(30);
                    cookie2.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(cookie1);
                    Response.Cookies.Add(cookie2);
                }

                //保存用户信息
                Session["userInfo"] = userInfo;
                Response.Redirect("UserInfoAsp.aspx");
            }
            else
            {
                Msg = msg;
            }

        }
        protected void checkCookieInfo()
        {
            if (Request.Cookies["username"] != null && Request.Cookies["password"] != null)
            {
                string username = Request.Cookies["username"].Value;
                string password = Request.Cookies["password"].Value;

                //查询是否有用户名，然后是否有密码
                UserInfoService userInfoService = new UserInfoService();
                UserInfo userInfo = userInfoService.GetUserInfo(username);
                if (userInfo != null)
                {
                    string doubleMd5Pwd = Md5Common.GetMd5String(Md5Common.GetMd5String(userInfo.UserPass));
                    if (doubleMd5Pwd == password)
                    {
                        Session["userInfo"] = userInfo;
                        Response.Redirect("UserInfoAsp.aspx");
                    }
                    Response.Cookies["cookie1"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["cookie2"].Expires = DateTime.Now.AddDays(-1);
                }

            }
        }
        //判断验证码
        protected bool checkValidCode()
        {
            if (Session["validateCode"] != null)
            {
                string code = Request.Form["txtCode"];
                string sessionCode = Session["validateCode"].ToString();
                if (code.Equals(sessionCode, StringComparison.InvariantCultureIgnoreCase))
                {

                    // 防止暴力登录，验证码保存在session里面可以有20分钟的有效时间
                    Session["validateCode"] = null;
                    return true;
                }
            }
            return false;
        }
    }
}