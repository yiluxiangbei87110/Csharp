using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;

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
                    //创建水印
                    //using(Image img=Image.FromStream(file.InputStream))如果值保存水印的建议这么写
                    //我们希望保存两种图片，一种水印的，一种不加水印的
                    using(Image img = Image.FromFile(context.Request.MapPath(fullFilePath)))
                    {
                        using(Bitmap map=new Bitmap(img.Width,img.Height))
                        {
                            using(Graphics g = Graphics.FromImage(map))
                            {
                                //从画布最左上角开始画
                                g.DrawImage(img,0,0,img.Width,img.Height);
                                g.DrawString("By Filex", new Font("黑体", 20.0f, FontStyle.Italic), Brushes.Red, new PointF(map.Width - 180, map.Height - 50));
                                string watermarkImgName = "_watermark_" + Guid.NewGuid().ToString();
                                map.Save(context.Request.MapPath("/uploadImgs/" + watermarkImgName + ".jpg"),System.Drawing.Imaging.ImageFormat.Jpeg);
                                context.Response.Write("<html><body><img src='/uploadImgs/"+ watermarkImgName + ".jpg'/></body></html>");
                            }
                        }
                    }

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