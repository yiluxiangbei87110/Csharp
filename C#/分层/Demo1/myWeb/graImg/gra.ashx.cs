using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace myWeb.graImg
{
    /// <summary>
    /// gra 的摘要说明
    /// </summary>
    public class gra : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            using (Bitmap map = new Bitmap(300, 400))
            {
                using (Graphics g = Graphics.FromImage(map))
                {
                    g.Clear(Color.LightGreen);
                    g.DrawString("Felix", new Font("黑体", 14.0f, FontStyle.Bold), Brushes.Red, new Point(150, 200));
                    string fileName = Guid.NewGuid().ToString();
                    map.Save(context.Request.MapPath("/uploadImgs/" + fileName + ".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                    context.Response.Write("<html><body><img src='/uploadImgs/" + fileName + ".jpg'/></body></html>");
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
}