<%@ WebHandler Language="C#" Class="Edit" %>

using System;
using System.Web;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using System.Data;


public class Edit : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        int id = Convert.ToInt32(context.Request.QueryString["id"]);
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        using(SqlConnection con=new SqlConnection(connStr))
        {
            using (SqlDataAdapter adp = new SqlDataAdapter("select * from UserInfo where id=@id", con))
            {
                SqlParameter para = new SqlParameter("@id",SqlDbType.Int);
                para.Value = id;
                adp.SelectCommand.Parameters.Add(para);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string filePath = context.Request.MapPath("Edit.html");
                    string content = File.ReadAllText(filePath);
                    content = content.Replace("$uid",dt.Rows[0]["UserName"].ToString()).Replace("$pwd",dt.Rows[0]["UserPass"].ToString()).Replace("$ID",dt.Rows[0]["id"].ToString());
                    context.Response.Write(content);
                }else
                {
                    context.Response.Write("参数错误");
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