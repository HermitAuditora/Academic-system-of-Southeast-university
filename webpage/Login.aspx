<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AcademicSystem.Account.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>西南大学</title>
    <link rel="icon" href="../img/favicon.ico" type="image/x-icon"/>
    <link href="../bootstrap.min.css" type="text/css" rel="stylesheet"/>
    <link rel="stylesheet" type="text/css" href="../css/reset.css"/>
    <link rel="stylesheet" type="text/css" href="../css/pcstyle.css"/>
    <link rel="stylesheet" type="text/css" href="../css/aaa.css"/>
    <style>
        .innerboxdiv {
            background: rgba(58, 109, 196, .8) !important;
            padding-bottom: 10px !important;
        }

        .blue:hover, .blue:focus, .blue:active:focus, .blue {
            background-color: #00a133;
        }

        .orange, .orange:hover, .orange:focus {
            background-color: #ff6600;
            color: white;
            font-size: 16px;
            width: 100% !important;
            border-color: transparent;
        }

        .verifyimggg {
            margin-right: 6px;
        }

        .innerinputvessel {
            width: 82%;
            margin: auto;
        }

        .h3title {
            padding: 25px 0;
        }

        .psdiv {
            padding-bottom: 25px;
        }

        .innerboxdiv {
            background: rgba(75, 75, 75, 0.71) !important;
        }

        .addlabel {
            width: 26%;
            font-size: 16px;
            color: #fff;
            vertical-align: middle;
            float: left;
            padding-top: 6px;
        }
        .rounded-button {
            border-radius: 20px;
        }

         .rounded-input {
            border-radius: 10px;
         }

    </style>

</head>
<body>
    
    <form id="form1" runat="server">
    
    <div class="logoheader" style="padding: 20px 0 !important;">
    <span> <img src="../img/logo.png" class="logoimgg" style="width: 180px!important; "/> <span
            class="actdissplite"></span> <span
            class="lefspantxt">一站式网上办事大厅</span> </span>
    <img src="../img/motto.png" class="mottoimg"/>
    </div>

    
        <div class="carouselandlogin">
        <!-- Wrapper for slides -->
            <div class="item active">
                <img src="../img/banner1.png" />
                &nbsp;</div>
        </div>
        <div class="loginbox">
                    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
                        <LabelStyle Font-Size="16px" />
                </asp:Login>
        </div>




    <div style="width:100%;text-align:center">
        <div style="float: left;width:  100%;margin-top: 20px;  margin-bottom: 20px;">

            西南大学版权所有 （渝ICP 06005063号-4）&nbsp;&nbsp;&nbsp;&nbsp; 学校地址：重庆市北碚区天生路2号 &nbsp;&nbsp;
            邮编：400715

        </div>

    </div>
        

    </form>
        

</body>

</html>
