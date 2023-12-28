using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using AcademicSystem.App_Code;

namespace AcademicSystem.webpage
{
    public partial class mainpage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string username = Request.QueryString["username"].ToString();
            List<string> student = StudentService.findviewbyid(username);
            List<List<String>> takeclasslist = Takeclass.takeclassinfo(username);
            List<string> classlist = Takeclass.processclassinfo(takeclasslist);
            Sname.Text = student[1]+"\t学生";
            Institute.Text = student[4];
            Class.Text = student[6];
            Photo.ImageUrl = "../" + student[7];
            //课表
            for(int i = 0; i < classlist.Count; i++)
                Course1.Text += classlist[i]+"</br>";
            //考试信息
            List<string> examinfo = Exam.getexaminfo(username);
            for (int i = 0; i < examinfo.Count; i++)
                exam1.Text += examinfo[i] + "</br>";

            //跳转课表url
            Hyperlink1.NavigateUrl = "~/webpage/Course.aspx?username=" + username;
            //定义导航栏超链接
            HtmlAnchor CourseLink = (HtmlAnchor)FindControl("CourseLink");
            HtmlAnchor SelectLink = (HtmlAnchor)FindControl("SelectLink");
            HtmlAnchor GradeLink = (HtmlAnchor)FindControl("GradeLink");
            HtmlAnchor RebuildLink = (HtmlAnchor)FindControl("RebuildLink");
            HtmlAnchor DelayedexamLink = (HtmlAnchor)(FindControl("DelayedexamLink"));
            CourseLink.HRef = "~/webpage/Course.aspx?username=" + username;
            SelectLink.HRef = "~/webpage/SelectCourse.aspx?username=" + username;
            GradeLink.HRef = "~/webpage/QueryGrades.aspx?username=" + username;
            RebuildLink.HRef = "~/webpage/RebuildCourse.aspx?username=" + username;
            DelayedexamLink.HRef = "~/webpage/DelayedExam.aspx?username=" + username;
        }

        protected void selectddl(object sender, EventArgs e)
        {
            
        }

    }
}