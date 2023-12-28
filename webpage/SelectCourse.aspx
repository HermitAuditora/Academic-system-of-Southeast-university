<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectCourse.aspx.cs" Inherits="AcademicSystem.webpage.SelectCourse"  %>

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


    <title>自主选课</title>
</head>
<body>
    <form id="form1" runat="server">
    <header class="navbar-inverse top2" id="show-head">
		<div class="container" id="navbar_container">
			<!-- 判断是否可切换角色 -->
			
					<div class="container">
			<div class="navbar-header">
				<button class="navbar-toggle" type="button" data-toggle="collapse" data-target=".bs-navbar-collapse">
					<span class="sr-only"> 自主选课</span> 
					<span class="icon-bar"></span> 
					<span class="icon-bar"></span> 
					<span class="icon-bar"></span>
				</button>
				<a class="navbar-brand" >
					自主选课
				</a>
			</div>
		</div>
		</div>
	</header>

	<div class="container container-func sl_all_bg" id="yhgnPage">
		<div class="bluewhite_bg">
		<asp:TextBox ID="TextBox1" runat="server" Width="426px" placeholder="可输入课程号/课程名称/教学班名称/教师姓名/教师工号查询!"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="重置" OnClick="Button2_Click" />
		</div>
		<div class="clearfix"></div>
		<div class="panel panel-info">
			<div class="panel-heading">&nbsp;</div>
			<div class="panel-body" style="text-align:center">

				<asp:GridView ID="GridView1" runat="server"  CssClass="selectcourse_view gridview-column-spacing" OnRowCommand="GridView1_RowCommand" EnableViewState="true">
                 <Columns>
				<asp:BoundField HeaderText="课程号" DataField="课程号" HeaderStyle-CssClass="gridview-header" />
				<asp:BoundField HeaderText="课程名" DataField="课程名" HeaderStyle-CssClass="gridview-header" />
				<asp:BoundField HeaderText="学分" DataField="学分" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="教学班" DataField="教学班" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="上课教师" DataField="上课教师" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="上课时间" DataField="上课时间" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="教学地点" DataField="教学地点" HeaderStyle-CssClass="gridview-header"/>
				<asp:BoundField HeaderText="课程归属" DataField="课程归属" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="已选/容量" DataField="已选/容量" HeaderStyle-CssClass="gridview-header"/>
                <asp:TemplateField HeaderText="操作" HeaderStyle-CssClass="gridview-header">
            <ItemTemplate >
                <asp:Button ID="Button1"  runat="server" Text="选课" CssClass="btn_blue" CommandName = "ButtonCommand" CommandArgument = '<%# Container.DataItemIndex %>' />
            </ItemTemplate>
        </asp:TemplateField>
            </Columns>
    </asp:GridView>
			</div>
		</div>

		</div>

		</form>
</body>
</html>
