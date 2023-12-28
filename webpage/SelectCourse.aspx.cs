using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AcademicSystem.App_Code;

namespace AcademicSystem.webpage
{

    public partial class SelectCourse : System.Web.UI.Page
    {
        private string username;
        private void BindGridViewData()
        {
            //添加数据
            List<List<string>> lists = Selectcourse.QueryCourseView();
            lists = Selectcourse.QueryCourse(lists);
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
            username = Request.QueryString["username"].ToString();
            if (!IsPostBack)
            {
                BindGridViewData();
                intialButton();
            }




        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ButtonCommand")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                // 处理按钮点击事件
                GridViewRow row = GridView1.Rows[rowIndex];
                Button btnSelect = (Button)row.FindControl("Button1");
                string tclassname = row.Cells[3].Text;
                List<string> cnotclassid = Selectcourse.findcno_tclassid(tclassname);
                if (btnSelect.Text == "选课" && !Selectcourse.iftakeclass(username, cnotclassid[0]))
                {
                    bool result = Selectcourse.stuselectcourse(username, cnotclassid[0], cnotclassid[1]);
                    try
                    {
                        if (!result)
                            throw new Exception("插入失败");

                    }
                    catch(Exception ex)
                    {
                        string script = "<script>alert('选课时间冲突，请检查您的课表');</script>";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, false);
                        Console.WriteLine("捕获到异常：" + ex.Message);
                    }

                    btnSelect.Text = "退选";
                    btnSelect.CssClass = "btn_green";

                }
                else if(btnSelect.Text == "退选" && Selectcourse.iftakeclass(username, cnotclassid[0]))
                {
                    bool result = Selectcourse.studropcourse(username, cnotclassid[0], cnotclassid[1]);
                    try
                    {
                        if (result)
                            throw new Exception("删除失败");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("捕获到异常：" + ex.Message);
                    }
                    btnSelect.Text = "选课";
                    btnSelect.CssClass = "btn_blue";
                }
                BindGridViewData();
                intialButton();

            }
        }




        protected void intialButton()
        {
           
            foreach(GridViewRow row in GridView1.Rows)
            {
                string tclassname = row.Cells[3].Text;
                List<string> cnotclass = Selectcourse.findcno_tclassid(tclassname);
                Button btn = (Button)row.FindControl("Button1");
                btn.CssClass = String.Empty;
                btn.Text = String.Empty;
                if (Selectcourse.iftaketeachclass(username, cnotclass[0], cnotclass[1]))
                {
                    btn.Text = "退选";
                    btn.CssClass = "btn_green";
                }
                else
                {
                    btn.Text = "选课";
                    btn.CssClass = "btn_blue";
                }
            }
        }
    }
}