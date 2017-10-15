using Demo1.common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace myWeb.thumnailFile
{
    public class thumnail : IHttpHandler
    {
        bool IHttpHandler.IsReusable
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string filePath = context.Request.MapPath("/uploadImgs/_watermark_9aac0e48-7ec9-4746-9df9-40a0472975fa.jpg");
        //创建缩略图，定义一个小的画布，然后将图片画到画布上，最后保存。
        //using (Bitmap map = new Bitmap(50, 50))
        //{
        //    using (Image img = Image.FromFile(filePath))
        //    using (Graphics g = Graphics.FromImage(map))
        //    {
        //        g.DrawImage(img, 0, 0, map.Width, map.Height);
        //        string fileName = Guid.NewGuid().ToString();
        //        map.Save(context.Request.MapPath("/uploadImgs/" + fileName + ".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);

        //    }
        //}
            string fileName = Guid.NewGuid().ToString();
            ImageClass.MakeThumbnail(filePath, context.Request.MapPath("/thumnailFile/thumnailImg/" + fileName + ".jpg"),50,50,"W");
            context.Response.Write("缩略图生成成功，请到/thumnailFile/thumnailImg/查看！");
        }

    }
}