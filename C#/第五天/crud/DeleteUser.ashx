<%@ WebHandler Language="C#" Class="DeleteUser" %>

using System;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public class DeleteUser : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        int id = int.Parse(context.Request["id"]);
        string conStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        using (SqlConnection con=new SqlConnection(conStr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandText = "delete  from UserInfo where id=@id";
                SqlParameter para = new SqlParameter("@id",SqlDbType.Int);
                para.Value = id;
                cmd.Parameters.Add(para);
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