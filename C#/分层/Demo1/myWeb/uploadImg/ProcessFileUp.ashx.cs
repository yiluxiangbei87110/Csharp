using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
namespace myWeb.uploadImg
{
    /// <summary>
    /// ProcessFileUp 的摘要说明
    /// </summary>
    public class ProcessFileUp : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //文件为空的情况系下，会抛异常
            if (context.Request.Files?[0]?.ContentLength > 0)
            {
                HttpPostedFile file = context.Request.Files?[0];
                //对上传的文件进行检验
                string fileName = Path.GetFileName(file.FileName);
                string fileExt = Path.GetExtension(file.FileName);
                if (fileExt != ".jpg")
                {
                    context.Response.Write("只能上传jpg格式的文件");
                }
                else
                {
                    //给上传的文件给唯一名字，防止后面上传的文件对其覆盖
                    string newFileName = Guid.NewGuid().ToString();
                    //放在不同的文件夹下，以时间为文件夹，方便后面进行查找。
                    string dir = "/uploadImgs/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
                    if (!Directory.Exists(context.Request.MapPath(dir)))
                    {
                        Directory.CreateDirectory(context.Request.MapPath(dir));
                    }
                    string fullFilePath = dir + newFileName + fileExt;
                    file.SaveAs(context.Request.MapPath(fullFilePath));
                    context.Response.Write("<br/>上传成功！");
                    context.Response.Write("<html><body><p><img src='" + fullFilePath + "'/></p><p><a href='http://localhost:63639/uploadImg/uploadImg.html'>返回上一页</a></p></body></html>");
                }
            }
            else
            {
                context.Response.Write("请选择文件后进行上传");
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
}