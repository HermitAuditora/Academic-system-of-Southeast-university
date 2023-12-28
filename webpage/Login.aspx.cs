using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using AcademicSystem.App_Code;

namespace AcademicSystem.Account
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = Login1.UserName;
            string pwd = Login1.Password;
            if (StudentService.validaccount(username, pwd))
            {
                e.Authenticated = true;
                string mainboardurl = "~/webpage/mainpage.aspx?username=" + username;
                Response.Redirect(mainboardurl);
                Console.WriteLine("登录成功");
            }
            else
            {
                //e.Authenticated = false;
                string script = "alert('账号或密码错误，请重新输入');";
                ClientScript.RegisterStartupScript(this.GetType(), "loginFailedScript", script, true);
            }
        }
    }
}