<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Course.aspx.cs" Inherits="AcademicSystem.webpage.Course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="icon" href="../mainboardimg/favicon.ico" type="image/x-icon" />
<link rel="shortcut icon" href="../mainboardimg/favicon1.ico" type="image/x-icon" />
<link rel="stylesheet" type="text/css" href="../maincss/bootstrap.min.css" />
<link rel="stylesheet" type="text/css" href="../maincss/error.css" />
<link rel="stylesheet" type="text/css" href="../maincss/zftal-ui.css" />
<link rel="stylesheet" type="text/css" href="../maincss/maincss.css" />


<title>学生课表查询</title>
</head>
<body>
    <form id="form1" runat="server">
	<!--最上方logo -->
	<header class="navbar-inverse top2" id="show-head">
		<div class="container" id="navbar_container">
					<div class="container">
			<div class="navbar-header">
				<button class="navbar-toggle" type="button" data-toggle="collapse" data-target=".bs-navbar-collapse">
					<span class="sr-only"> 学生课表查询</span> 
					<span class="icon-bar"></span> 
					<span class="icon-bar"></span> 
					<span class="icon-bar"></span>
				</button>
				<asp:Label runat="server" CssClass="navbar-brand">学生课表查询</asp:Label>
			</div>
		</div>
		</div>
	</header>


	<div style="width: 100%; padding: 0px; margin: 0px;" id="bodyContainer">
		<div class="container container-func sl_all_bg" id="yhgnPage">
			<div id="innerContainer">
	<!--学年 学期-->
	<div class="row">
	<div class="col-md-4 col-sm-5">
		<div class="form-group">
			<label for="" class="col-sm-2 control-label" id="xn"><span style="color:red;">*</span>学年</label>
			<div class="col-sm-8">
				<asp:DropDownList ID="Year" runat="server" CssClass="form-control">
					    <asp:ListItem Text="2023-2024" Value="2023-2024"></asp:ListItem>
						<asp:ListItem Text="2022-2023" Value="2022-2023" Selected="True"></asp:ListItem>
						<asp:ListItem Text="2021-2022" Value="2021-2022"></asp:ListItem>
						<asp:ListItem Text="2020-2021" Value="2020-2021"></asp:ListItem>
				</asp:DropDownList>
			</div>
		</div>
	</div>
	<div class="col-md-4 col-sm-5">
		<div class="form-group">
			<label for="" class="col-sm-2 control-label" id="xq"><span style="color:red;">*</span>学期</label>
			<div class="col-sm-8">
				<asp:DropDownList ID="Term" runat="server" CssClass="form-control chosen-select">
						<asp:ListItem Text="1" Value="1"></asp:ListItem>
						<asp:ListItem Text="2" Value="2" Selected="True"></asp:ListItem>
				</asp:DropDownList>
			</div>
		</div>
	</div>
<div class="col-md-12 col-sm-12"><div class="form-group"><div class="col-sm-12">
		<asp:Button ID="Query" runat="server" CssClass="btn btn-primary btn-sm pull-right bigger-120 glyphicon glyphicon-search" Text="查询" OnClick="Query_Click" />
	</div></div></div>
			</div>




		</div>
		</div>
		</div>
	<div style="width: 100%; padding: 0px; margin: 0px;" id="bodyContainer">
		<div class="container container-func sl_all_bg" id="yhgnPage">
			<div id="innerContainer">
				<!--课表-->
			<asp:GridView ID="GridView1" runat="server"   CssClass="gridview-style" Height="171px" OnRowDataBound="GridView1_RowDataBound">

            <Columns>
                <asp:BoundField HeaderText="时间段" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="节次" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="星期一" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="星期二" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="星期三" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="星期四" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="星期五" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="星期六" HeaderStyle-CssClass="gridview-header"/>
                <asp:BoundField HeaderText="星期日" HeaderStyle-CssClass="gridview-header"/>
            </Columns>
        </asp:GridView>
				</div>
			</div>
		</div>

    </form>
</body>
</html>
