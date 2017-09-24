<%@ WebHandler Language="C#" Class="AddUser" %>

using System;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
public class AddUser : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        //1: 接收表单数据。
        string userName = context.Request.Form["txtName"];
        string userPwd = context.Request.Form["txtPwd"];
        //2:链接数据库，构建相应的SQL语句，最后执行SQL语句。
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "insert into UserInfo(UserName,UserPass,RegTime)values(@UserName,@UserPass,@RegTime)";
                SqlParameter[] pars = {
                     new SqlParameter("@UserName",SqlDbType.NVarChar,32),
                     new SqlParameter("@UserPass",SqlDbType.NVarChar,32),
                     new SqlParameter("@RegTime",SqlDbType.DateTime)
                                      };
                pars[0].Value = userName;
                pars[1].Value = userPwd;
                pars[2].Value = DateTime.Now;
                cmd.Parameters.AddRange(pars);
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    context.Response.Redirect("UserInfoList.ashx");//实现页面跳转，也是是向UserInfoList页面发送了一个GET请求。
                }
                else
                {
                    context.Response.Redirect("http://www.baidu.com");
                }

            }
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}