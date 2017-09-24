<%@ WebHandler Language="C#" Class="showDetail" %>

using System;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public class showDetail : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        int id;
        //返回一个布尔值，如果装换成功，就将其赋给 out id
        if (int.TryParse(context.Request.QueryString["id"], out id))
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlDataAdapter adp = new SqlDataAdapter("select * from UserInfo where id=@id", connStr))
                {
                    SqlParameter par = new SqlParameter("@id", SqlDbType.Int);
                    par.Value = id;
                    adp.SelectCommand.Parameters.Add(par);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        string filePath = context.Request.MapPath("showDetail.html");
                        string content = File.ReadAllText(filePath);
                        content = content.Replace("$name", dt.Rows[0]["UserName"].ToString()).Replace("$pwd", dt.Rows[0]["UserPass"].ToString());
                        context.Response.Write(content);
                    }
                    else
                    {
                        context.Response.Write("sorry ,查询不到！");
                    }
                }
            }

        }
        else
        {
            context.Response.Write("参数有误");
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