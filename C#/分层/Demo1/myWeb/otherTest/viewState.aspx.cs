using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myWeb.otherTest
{
    public partial class viewState : System.Web.UI.Page
    {
        public int result { set; get; }

        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (ViewState["count"] != null)
            {
                count = Convert.ToInt32(ViewState["count"]);
                count++;
            }
            ViewState["count"] = count;
            result = count;
        }
    }
}