using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademicSystem.App_Code;
using System.Data;
using System.Data.SqlClient;

namespace AcademicSystem.webpage
{
    public partial class Course : System.Web.UI.Page
    {
        private string username;

        protected void Page_Load(object sender, EventArgs e)
        {
            username = Request.QueryString["username"];
            if (!IsPostBack)
            {

                DataTable table = new DataTable();
                for (int i = 0; i < 14; i++)
                {
                    DataRow row = table.NewRow();
                    table.Rows.Add(row);
                }

                GridView1.AutoGenerateColumns = false;
                GridView1.DataSource = table;
                GridView1.DataBind();
            }


        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //第一列合并(1-4、5-6、7-11、12-14)
                if (e.Row.RowIndex < 4)
                {
                    if (e.Row.RowIndex == 0)
                    {
                        e.Row.Cells[0].RowSpan = 4; // 合并4行
                        e.Row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
                        e.Row.Cells[0].Text = "上午";

                    }

                    else
                        e.Row.Cells[0].Visible = false; // 隐藏其他行的第一列
                }
                else if (e.Row.RowIndex >= 4 && e.Row.RowIndex < 6)
                {
                    if (e.Row.RowIndex == 4)
                    {
                        e.Row.Cells[0].RowSpan = 2;
                        e.Row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
                        e.Row.Cells[0].Text = "中午";
                    }

                    else
                        e.Row.Cells[0].Visible = false; // 隐藏其他行的第一列
                }
                else if (e.Row.RowIndex >= 6 && e.Row.RowIndex < 11)
                {
                    if (e.Row.RowIndex == 6)
                    {
                        e.Row.Cells[0].RowSpan = 5;
                        e.Row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
                        e.Row.Cells[0].Text = "下午";
                    }
                    else
                        e.Row.Cells[0].Visible = false;
                }
                else if (e.Row.RowIndex >= 11 && e.Row.RowIndex < 14)
                {
                    if (e.Row.RowIndex == 11)
                    {
                        e.Row.Cells[0].RowSpan = 3;
                        e.Row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
                        e.Row.Cells[0].Text = "晚上";
                    }

                    else
                        e.Row.Cells[0].Visible = false;
                }

                //填写第二列数据(1-14)
                e.Row.Cells[1].HorizontalAlign = HorizontalAlign.Center;
                e.Row.Cells[1].Text = (e.Row.RowIndex + 1).ToString();

                //填写课表数据
                List<List<string>> results = Takeclass.takecourseinfo(username);
                List<string> result = Takeclass.processcourse(results);
                GridView1.Caption = StudentService.findnamebyid(username) + "的课表";

                foreach (List<string> list in results)
                {
                    //定位在哪一节课
                    int row1 = Convert.ToInt32(list[4]) - 1;
                    int row2 = Convert.ToInt32(list[5]) - 1;
                    int column = Convert.ToInt32(list[6]) + 1;
                    if (list[16].Equals(Year.SelectedValue)&&list[17].Equals(Term.SelectedValue))
                    if (e.Row.RowIndex >= row1 && e.Row.RowIndex <= row2)
                    {
                        if (e.Row.RowIndex == row1)
                        {
                            e.Row.Cells[column].RowSpan = row2 - row1 + 1;
                            e.Row.Cells[column].Text += result[Convert.ToInt32(list[list.Count-1])];
                            e.Row.Cells[column].CssClass = "course_style";
                        }
                        else
                            e.Row.Cells[column].Visible = false;
                    }

                }
            }

        }

        protected void Query_Click(object sender, EventArgs e)
        {
            //点击按钮根据学期学年更新课表
            DataTable table = new DataTable();
            for (int i = 0; i < 14; i++)
            {
                DataRow row = table.NewRow();
                table.Rows.Add(row);
            }

            GridView1.AutoGenerateColumns = false;
            GridView1.DataSource = table;
            DataBind();
        }
    }
}