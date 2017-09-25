<%@ WebHandler Language="C#" Class="Add" %>

using System;
using System.Web;
using System.IO;
public class Add : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        int num = int.Parse(context.Request.QueryString["num"]);
        context.Response.ContentType = "text/html";
        string filePath = context.Request.MapPath("Add.html");
        num++;
        string fileContent = File.ReadAllText(filePath).Replace("$count",num.ToString());
        context.Response.Write(fileContent);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}