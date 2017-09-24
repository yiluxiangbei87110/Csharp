<%@ WebHandler Language="C#" Class="updateEdit" %>

using System;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public class updateEdit : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string uid = context.Request.Form["txtName"];
        string pwd = context.Request.Form["txtPwd"];
        string flagId=context.Request.Form["txtId"];
        string connstr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        using (SqlConnection con=new SqlConnection(connstr))
        {
            using (SqlCommand cmd =new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandText = "update UserInfo set UserName=@UserName,UserPass=@UserPass where id=@id";
                SqlParameter[] paras =
                {
                    new SqlParameter("@UserName",SqlDbType.NChar,32),
                    new SqlParameter("@UserPass",SqlDbType.NChar,32),
                    new SqlParameter("@id",SqlDbType.Int)
                };
                paras[0].Value = uid;
                paras[1].Value = pwd;
                paras[2].Value = flagId;
                cmd.Parameters.AddRange(paras);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    context.Response.Redirect("UserInfoList.ashx");
                }else
                {
                        context.Response.Redirect("http://www.baidu.com");
                }
            }
        }

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}