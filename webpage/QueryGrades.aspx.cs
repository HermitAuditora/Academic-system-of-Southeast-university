using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademicSystem.App_Code;
using System.Data;

namespace AcademicSystem.webpage
{
    public partial class QueryGrades : System.Web.UI.Page
    {
        private string username;

        private void BindGridViewData()
        {
            //添加数据
            List<List<string>> lists = Querygrade.querygradeinfo(username);
            DataTable dt = new DataTable();
            foreach (DataControlField column in GridView1.Columns)
            {
                BoundField boundField = column as BoundField;
                if (boundField != null)
                {
                    dt.Columns.Add(boundField.DataField);
                }
            }
            foreach (List<string> list in lists)
            {
                dt.Rows.Add(list.ToArray());
            }
            GridView1.AutoGenerateColumns = false;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            username = Request.QueryString["username"];
            avgGPA.Text = StudentService.findnamebyid(username) + "同学，您的课程修读情况（供参考）：(统计时间"+DateTime.Now+"之前有效) 当前所有课程平均学分绩点（GPA）： "+Querygrade.avggpa(username);
            BindGridViewData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                List<List<string>> lists = Querygrade.querygradeinfo(username);
                DataTable dt = new DataTable();
                foreach (DataControlField column in GridView1.Columns)
                {
                    BoundField boundField = column as BoundField;
                    if (boundField != null)
                    {
                        dt.Columns.Add(boundField.DataField);
                    }
                }
                foreach (List<string> list in lists)
                {
                    if(Year.SelectedValue.Equals("ALL") && Term.SelectedValue.Equals("ALL"))
                        dt.Rows.Add(list.ToArray());
                    else if (Year.SelectedValue.Equals(list[0]) && Term.SelectedValue.Equals(list[1]))
                        dt.Rows.Add(list.ToArray());
                    else if (Year.SelectedValue.Equals(list[0]) && Term.SelectedValue.Equals("ALL"))
                        dt.Rows.Add(list.ToArray());
                    else if(Year.SelectedValue.Equals("ALL") && Term.SelectedValue.Equals(list[1]))
                        dt.Rows.Add(list.ToArray());
                }
                GridView1.AutoGenerateColumns = false;
                GridView1.DataSource = dt;

            }
        }
               
    }
}