<%@ WebHandler Language="C#" Class="showInfo" %>

using System;
using System.Web;
using System.IO;
public class showInfo : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        //读取模板文件.
        string filePath = context.Request.MapPath("index.html");
        string fileContent=File.ReadAllText(filePath);
        context.Response.Write(fileContent);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}


