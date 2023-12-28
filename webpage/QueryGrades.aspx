<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryGrades.aspx.cs" Inherits="AcademicSystem.webpage.QueryGrades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="icon" href="../mainboardimg/favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../mainboardimg/favicon1.ico?" type="image/x-icon" />
    <link rel="stylesheet" type="text/css" href="../maincss/maincss.css" />
    <link rel="stylesheet" type="text/css" href="../maincss/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="../maincss/error.css" />
    <link rel="stylesheet" type="text/css" href="../maincss/zftal-ui.css" />
    <title>学生成绩查询</title>
</head>
<body>
    <form id="form1" runat="server">
       <header class="navbar-inverse top2" id="show-head">
		<div class="container" id="navbar_container">
			<!-- 判断是否可切换角色 -->		
			<div class="navbar-header">
				<a class="navbar-brand">
					学生成绩查询
				</a>
			</div>
		</div>
	</header>


<div class="container container-func sl_all_bg" id="yhgnPage">
    <div class="panel panel-info">
        <div class="panel-heading">&nbsp;</div>
	        <div class="panel-body" style="text-align:center">
		        <div class="row">		
                    <div class="col-md-4 col-sm-6">
                        <div class="form-group">
      <label for="" class="col-sm-2 control-label">学年<!-- 学年 --></label>
      <div class="col-sm-8">
          <asp:DropDownList ID="Year" runat="server" CssClass="form-control chosen-select">
                        <asp:ListItem Text="全部" Value="ALL" Selected="True"></asp:ListItem>
					    <asp:ListItem Text="2023-2024" Value="2023-2024"></asp:ListItem>
						<asp:ListItem Text="2022-2023" Value="2022-2023" ></asp:ListItem>
						<asp:ListItem Text="2021-2022" Value="2021-2022"></asp:ListItem>
						<asp:ListItem Text="2020-2021" Value="2020-2021"></asp:ListItem>
		</asp:DropDownList>

      </div>
    </div>
  </div>
  <div class="col-md-4 col-sm-6">
    <div class="form-group">
      <label for="" class="col-sm-2 control-label">学期<!-- 学期 --></label>
      <div class="col-sm-8">
          <asp:DropDownList ID="Term" runat="server" CssClass="form-control chosen-select">
                        <asp:ListItem Text="全部" Value="ALL"  Selected="True"></asp:ListItem>
						<asp:ListItem Text="1" Value="1"></asp:ListItem>
						<asp:ListItem Text="2" Value="2"></asp:ListItem>
		  </asp:DropDownList>

                        </div>
                    </div>
                </div>
            <div class="col-md-4 col-sm-5">
             <asp:Button ID="Button1" runat="server" Text="查询" CssClass="btn btn-primary btn-sm" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </div>
                <div class="panel panel-info">
	        <div class="panel-body" style="text-align:center">
                <asp:Label ID="avgGPA" runat="server"></asp:Label>
                </div>
                </div>
    <div class="panel panel-info">
	        <div class="panel-body" style="text-align:center">
        <asp:GridView ID="GridView1" runat="server"  CssClass="selectcourse_view gridview-column-spacing" OnRowDataBound="GridView1_RowDataBound">
            <Columns>
                <asp:BoundField DataField="学年" HeaderText="学年" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="学期" HeaderText="学期" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="课程号" HeaderText="课程号" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="课程名" HeaderText="课程名" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="课程类型" HeaderText="课程类型" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="学分" HeaderText="学分" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="成绩" HeaderText="成绩" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="绩点" HeaderText="绩点" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="教学班名称" HeaderText="教学班名称" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="教师名称" HeaderText="教师名称" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="学号" HeaderText="学号" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="学生姓名" HeaderText="学生姓名" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField DataField="学分绩点" HeaderText="学分绩点" HeaderStyle-CssClass="gridview-header" />
            </Columns>
        </asp:GridView>
    </div>
        </div>
</div>
    </form>
</body>
</html>
