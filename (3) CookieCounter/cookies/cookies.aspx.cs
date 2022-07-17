using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies
{
    public partial class cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["cooks"] != null)
            {
                int fetchctr = int.Parse(Request.Cookies["cooks"].Value);
                fetchctr++;
                lblvisit.Text = "This is your Visit no:-" + fetchctr;
                HttpCookie c1 = new HttpCookie("cooks", fetchctr.ToString());
                Response.Cookies.Add(c1);
            }
            else
            {
                int ctr = 1;
                HttpCookie c1 = new HttpCookie("cooks", ctr.ToString());
                lblvisit.Text = "This is your first cookie";
                Response.Cookies.Add(c1);
            }

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
    
        }
    }
}