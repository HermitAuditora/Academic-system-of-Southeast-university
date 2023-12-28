<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainpage.aspx.cs" Inherits="AcademicSystem.webpage.mainpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>教学管理信息服务平台</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="Copyright" content="zfsoft" />	
    <link rel="icon" href="../mainboardimg/favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../mainboardimg/favicon1.ico?" type="image/x-icon" />
	<link rel="stylesheet" type="text/css" href="../maincss/mynavbar.css" />
    <link rel="stylesheet" type="text/css" href="../maincss/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="../maincss/error.css" />
    <link rel="stylesheet" type="text/css" href="../maincss/zftal-ui.css" />
	<link rel="stylesheet" type="text/css" href="../maincss/maincss.css" />

    <style type="text/css">	
	.active{font-weight: bolder;}
	#navbar-tabs li{ margin-top: 2px;}
	#navbar-tabs li a{ border-top: 2px solid transparent;}
	#navbar-tabs li.active a{border-top: 2px solid #0770cd;}
    </style>
</head>
<body class="body-container">
	<form id="form1" runat="server">
		

		
    <div class="navbar navbar-default navbar-static-top top1">
	<div class="container">
		<div class="navbar-header">
			<a class="navbar-brand logo_2" href="#">

				<img src="../mainboardimg/logo_jw_w.png" style="margin-top:-3px;height: 60px" />
			<span id="xtmc">教学管理信息服务平台</span>
			</a>
			<button type="button" id="exit_btn" style = "width:44px;height:34px;"  class="navbar-toggle collapsed" data-toggle="collapse" data-target=".bs-navbar-collapse-js" aria-expanded="false">
			退出
			</button>
			<button type="button" id="js_btn" style = "width:44px;height:34px;"  class="navbar-toggle collapsed" data-toggle="collapse" data-target=".bs-navbar-collapse-js" aria-expanded="false">
				<img  style="margin-top: 3.5px;margin-left: 2.5px;position:relative;top:-9px;position:relative;left:-10px;" src="../mainboardimg/user_logo.jpg" width="42" height="32"/>
			</button>
			
			
		</div>
		<ul class="nav navbar-nav navbar-right  hidden-xs">
				<li>
					</li>
							
			<li>
				<a href="#" class="dropdown-toggle grxx" data-toggle="dropdown"><img src="../mainboardimg/user_logo.jpg" width="28" height="28"/></a>
				<ul class="dropdown-menu" >
				
					<li class="divider"></li>
					<li><a href="javascript:void(0);" id="exit"><i class="top_png tc"></i>退出</a></li>
				</ul>
			</li>
		</ul>
				  	
		  		
		  		
	</div>
</div>


<!-- 菜单  -->
<div class="navbar_index">
	<div class="container" id = "myDiv1">
			<ul class="navbar">
  <li><a href="#">报名申请<b class="caret"></b></a>
	  <ul class="dropdown">
      <li><a id="RebuildLink" runat="server" href="#" target="_blank">重修报名</a></li>
      <li><a id="DelayedexamLink" runat="server" href="#" target="_blank">缓考申请</a></li>
    </ul>
  </li>
  <li><a href="#">信息维护<b class="caret"></b></a></li>
  <li><a href="#">选课<b class="caret"></b></a>
    <ul class="dropdown">
      <li><a id="CourseLink" runat="server" href="#" target="_blank">学生课表查询</a></li>
      <li><a id="SelectLink" runat="server" href="#" target="_blank">自主选课</a></li>
    </ul>
  </li>
  <li><a href="#">信息查询<b class="caret"></b></a>
    <ul class="dropdown">
      <li><a id="GradeLink" runat="server" href="#" target="_blank">学生成绩查询</a></li>
    </ul>
  </li>
  <li><a href="#">教学评价<b class="caret"></b></a></li>
  <li><a hraf="#">毕业设计(论文)<b class="caret"></b></a></li>
</ul>
			

	</div>
</div>


<!-- 主体 -->
<div class="container padding-150">
	<div class="row" style="height: 81vh">
		<div class="col-md-3 col-sm-4" style="height: 100%;">
			
				<div class="index_wdyy" style="height: 99.4%;max-height: none;">
					
					
						<h3><span>我的应用</span><a href="#" class="sz" id="wdyy_szbtn"></a></h3>
						<ul class="list-unstyled"  id="index_wdyy" style="height: 350px;"></ul>					
				</div>			
		</div>
		<div class="col-md-9 col-sm-8">
			<div class="row">
				<div class="col-md-12">
					<div class="index_grxx">
						<div class="row">


							<!-- 个人信息 -->
							<div class="col-md-5" id="yhxxIndex" style="border-right: 1px solid #eeeeee;">
								<div class="round_image">
								<asp:Image ID="Photo" runat="server" Width="100"/>
								</div>
								<div>
									<asp:Label ID="Sname" runat="server" Font-Bold="true" CssClass="sname_place"></asp:Label>
								</div>
								<div class="label_place">
									<asp:Label ID="Institute" runat="server" style="color:gray;"></asp:Label>
									<asp:Label ID="Class" runat="server" style="color:gray;"></asp:Label>
								</div>


							</div>
							
								<div class="col-md-7" id="newsnotice"  style="height: 150px;">
									<asp:Label runat="server" Font-Bold="true" Font-Size="14">通知</asp:Label>

								</div>
							
								
						</div>
					</div>
				</div>
				<!-- 课表 -->
				<div class="col-md-5">
					<div class="index_rctx" id="area_one">
						<asp:Label runat="server" Font-Bold="true" Font-Size="14">课表</asp:Label>
						<div><asp:Label ID="Course1" runat="server"></asp:Label></div>
						<div><asp:HyperLink ID="Hyperlink1" runat="server"  Text="...更多" CssClass="more_label" Target="_blank"></asp:HyperLink></div>
					</div>
				</div>
				<div class="col-md-7">
					
						
							<div class="index_rctx" id="area_five">
								<asp:Label runat="server" Font-Bold="true" Font-Size="14">日历</asp:Label>
								<asp:Calendar ID="Calendar1" runat="server" CssClass="my_calendar"  BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="600px">
                                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" HorizontalAlign="Center"/>
                                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                                    <OtherMonthDayStyle ForeColor="#999999" />
                                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                    <TodayDayStyle BackColor="#CCCCCC" />
                                </asp:Calendar>

							</div>
						
						 
					
					 
				</div>
				<div class="col-md-5">
					<div class="index_rctx" id="area_three">
						<asp:Label runat="server" Font-Bold="true" Font-Size="14">消息</asp:Label>

					</div>
				</div>
				<div class="col-md-7">
					<div class="index_rctx" id="area_four">
						<asp:Label runat="server" Font-Bold="true" Font-Size="14">考试</asp:Label>
						<div><asp:Label ID="exam1" runat="server"></asp:Label></div>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
<!-- footer --> 

<!-- footer --> 

<div id="footerID" class="footer"  style="background-color: " >
	
	<p>欢迎来到西南大学教务管理系统</p>
</div>
	 	</form>
</body>
</html>
