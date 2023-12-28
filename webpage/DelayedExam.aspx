<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DelayedExam.aspx.cs" Inherits="AcademicSystem.webpage.DelayedExam" %>

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


    <title>缓考报名</title>
</head>
<body>
    <form id="form1" runat="server">
       <header class="navbar-inverse top2" id="show-head">
		<div class="container" id="navbar_container">
			<!-- 判断是否可切换角色 -->		
			<div class="navbar-header">
				<a class="navbar-brand">
					缓考报名
				</a>
			</div>
		</div>
	</header>
            <div class="container container-func sl_all_bg" id="yhgnPage">
		<div class="panel panel-info">
            <div class="panel-heading">&nbsp;</div>
	        <div class="panel-body" >
                <asp:GridView ID="GridView1" runat="server"  CssClass="selectcourse_view gridview-column-spacing" OnRowCommand="GridView1_RowCommand" EnableViewState="true">
                 <Columns>
				<asp:BoundField HeaderText="课程号" DataField="课程号" HeaderStyle-CssClass="gridview-header" />
				<asp:BoundField HeaderText="课程名" DataField="课程名" HeaderStyle-CssClass="gridview-header" />
                <asp:BoundField HeaderText="课程性质" DataField="课程性质" HeaderStyle-CssClass="gridview-header" />
				<asp:BoundField HeaderText="教学班名称" DataField="教学班名称" HeaderStyle-CssClass="gridview-header" />
				<asp:BoundField HeaderText="任课教师" DataField="任课教师" HeaderStyle-CssClass="gridview-header" />                     
                <asp:TemplateField HeaderText="操作" HeaderStyle-CssClass="gridview-header">
            <ItemTemplate >
                <asp:Button ID="Button1"  runat="server" Text="申请缓考" CssClass="btn_blue" CommandName = "ButtonCommand" CommandArgument = '<%# Container.DataItemIndex %>' />
            </ItemTemplate>
        </asp:TemplateField>
				<asp:BoundField HeaderText="状态" DataField="状态" HeaderStyle-CssClass="gridview-header"/>
            </Columns>
    </asp:GridView>    

                </div>
            </div>
                </div>



    </form>
</body>
</html>
