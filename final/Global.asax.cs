using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Tecno_2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
           // Application["AppstartMessage"] = "Welcome to CSharp Corner Developer Communtiy";
            Application["TotalApplication"] = 0;
            Application["TotalUserSession"] = 0;
            Application["TotalUserSession"] = (int)Application["TotalUserSession"] + 1;    
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //Session["master"] = "~/Master.master"; 
            Application["TotalUserSession"] = (int)Application["TotalUserSession"] + 1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // Write an unhandled error code exception 
            //لمعالجة الأخطاء والصفحات الغير الموجودة
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Response.Write("Session_End");
            Application["TotalUserSession"] = (int)Application["TotalUserSession"] - 1;
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Application["AppEndMessage"] = "Application Closed";  
        }
    }
}