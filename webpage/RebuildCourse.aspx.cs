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
    public partial class RebuildCourse : System.Web.UI.Page
    {

        private string username;

        private void BindGridViewData()
        {
            //添加数据
            List<List<string>> lists = Rebuildclass.getrebuildinfo(username);
            lists = Rebuildclass.processinfo(lists);
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
                initialButton();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ButtonCommand")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                // 处理按钮点击事件
                GridViewRow row = GridView1.Rows[rowIndex];
                Button btnSelect = (Button)row.FindControl("Button1");
                List<List<string>> lists = Rebuildclass.getrebuildinfo(username);
                if (btnSelect.Text == "申请重修" && lists[rowIndex][5] == "已修")
                {
                    bool result = Rebuildclass.updatestate(username, row.Cells[0].Text, "待审核");
                    try
                    {
                        if (!result)
                            throw new Exception("重修失败");

                    }
                    catch (Exception ex)
                    {
                        string script = "<script>alert('出现未知错误');</script>";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, false);
                        Console.WriteLine("捕获到异常：" + ex.Message);
                    }

                    btnSelect.Text = "已申请";
                    btnSelect.CssClass = "btn_green";
                    btnSelect.Enabled = false;

                }
                BindGridViewData();
                initialButton();

            }
        }




        protected void initialButton()
        {

            foreach (GridViewRow row in GridView1.Rows)
            {

                Button btn = (Button)row.FindControl("Button1");
                btn.CssClass = String.Empty;
                btn.Text = String.Empty;
                if (row.Cells[5].Text.Equals("待审批"))
                {
                    btn.Text = "已申请";
                    btn.CssClass = "btn_green";
                }
                else
                {
                    btn.Text = "申请重修";
                    btn.CssClass = "btn_blue";
                }
            }
        }
    }
}