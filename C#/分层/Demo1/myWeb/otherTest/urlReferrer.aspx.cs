using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myWeb.otherTest
{
    public partial class urlReferrer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request.Url.ToString());
            //http://localhost:63639/otherTest/urlReferrer.aspx
            Response.Write("<hr/>");
            Response.Write(Request.UrlReferrer.ToString());
            //真实的地址，对防盗链有帮助
            //http://localhost:63639/otherTest/showUrl.html
        }
    }
}