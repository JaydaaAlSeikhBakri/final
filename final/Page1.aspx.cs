using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tecno_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("thing");
            hiddenTime.Value = DateTime.Now.ToString();
            Response.Write("number of application : " + Application["TotalApplication"]);
            Response.Write("<br>");
            Response.Write("number of ueser online : " + Application["TotalUserSession"]);
        }

        protected void btnSubmit_Click_Click(object sender, EventArgs e)
        {
            ViewState["name"] = txtname.Text;
            ViewState["age"] = txtage.Text;
            txtname.Text = txtage.Text = "";
        }

        protected void btnview_click_Click(object sender, EventArgs e)
        {
            Response.Write("Name : " + ViewState["name"] + "     Age : " + ViewState["age"]);
        }

        protected void btndone_Click_Click(object sender, EventArgs e)
        {
            Response.Redirect("Page2.aspx?name = " + txtname.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = txtname.Text;
            Session["age"] = txtage.Text;
            //Session.Add("name", txtname.Text);
            Response.Redirect("Page2.aspx?");
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Cookie");
            cookie["Name"] = txtname.Text;
            cookie["Age"] = txtage.Text;
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Page2.aspx?");
            
        }

      

       

      

      

       
    }
}