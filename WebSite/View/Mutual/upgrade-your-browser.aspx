<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upgrade-your-browser.aspx.cs" Inherits="Evaluation.View.Mutual.upgrade_your_browser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="../../Scripts/jquery-1.10.2.min.js"></script>
    <title>请升级你的浏览器</title>
    <style>
        * {
            font-family: "微软雅黑";
            margin: 0;
            padding: 0;
            font-size: 14px;
            line-height: 24px;
            color: #454545;
        }
        a {
            text-decoration: none;
            color: #0072c6;
            padding-left:10px;
        }  

         .box{
             width:960px;margin:0 auto;padding-top:50px;height:280px;
         }
        h2 {
            font-size: 20px;
            line-height: 25px;
            font-weight: 100;
            margin: 10px 0;           
        }
        p{
            margin-bottom:10px;
        }
        .browser li {
            width: 200px;
            height: 38px;
            line-height: 22px;
            float: left;
            list-style: none;        
            padding-left: 40px;
            background:url(../../Content/Images/下载.png)no-repeat;
            background-size:38px;
        }
        span {
            display: block;
            font-size: 12px;
            line-height: 12px;
            color: #0072c6;
            padding-left:10px;
        }
        
        .browser .browser-firefox {
            background-position: 0 -38px;
        }

        .browser .browser-ie {
            background-position: 0 -75px;
        }

        .browser .browser-360 {
            background-position: 0 -190px;
        }
        hr {
            margin: 20px 0;
            border: 0;
            border-top: 1px solid #dadada;
        }
         #log-body-bottom {
            padding: 20px;
            color: #218ACF;
            background-image: url(../../Content/Images/bottom.png);
            background-size: cover;
            filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(src='../../Content/Images/bottom.png', sizingMethod='scale');
        }
         #log-body-bottom p {
                text-align: center;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server"> 
         <div style="display:none;"> 
            <asp:TextBox runat="server" ID="txtEntryImage" ClientIDMode="Static" ></asp:TextBox>           
            <asp:TextBox runat="server" ID="txtEntryFooterInformation1" ClientIDMode="Static" ></asp:TextBox>
            <asp:TextBox runat="server" ID="txtEntryFooterInformation2" ClientIDMode="Static" ></asp:TextBox>
            <asp:TextBox runat="server" ID="txtEntryFooterInformation3" ClientIDMode="Static" ></asp:TextBox>
             <asp:DropDownList runat="server" ID="ddlActivityType" ClientIDMode="Static" class="form-control"></asp:DropDownList>
        </div>  
         <img src="#" style="width: 100%;" />
    <div class="box"> 
        <h2>为什么会出现这个页面？</h2>
        <p style="color:red;font-size:15px;">您正在使用的浏览器版本过低，评优系统支持ie10，谷歌...请升级您的IE浏览器或者下载谷歌、火狐...然后再访问评优系统。</p>
        <hr />
        <h2>更先进的浏览器</h2>
        <p style="margin-bottom:50px;">如果你的电脑已有以下浏览器的最新版本则直接使用该浏览器访问即可。</p>
        <ul class="browser">
            <li class="browser-chrome"><a href="http://www.google.cn/intl/zh-CN/chrome/browser/desktop/index.html">谷歌浏览器<span>Google Chrome</span></a></li>
            <li class="browser-firefox"><a href="http://www.firefox.com.cn">火狐浏览器<span>Mozilla Firefox</span></a></li>
            <li class="browser-ie"><a href="https://support.microsoft.com/zh-cn/help/17621/internet-explorer-downloads">IE浏览器<span>Internet Explorer</span></a></li>
            <li class="browser-360"><a href="http://se.360.cn/">360安全浏览器 <span>小白用户选择</span></a></li>
            
        </ul>
    </div>
         <hr style="border: solid 2px; color: #218ACF; margin-top: 5%; margin-bottom: 0px;" />
            <div id="log-body-bottom">
                <p id="txtEntryFooter1"></p>
                <p id="txtEntryFooter2"></p>
                <p id="txtEntryFooter3"></p>
            </div>
    </form>
</body>
</html>
<script>
    $(function () {
        $('img').attr("src", $('#txtEntryImage').val());
        $('#txtEntryFooter1').html($('#txtEntryFooterInformation1').val());
        $('#txtEntryFooter2').html($('#txtEntryFooterInformation2').val());
        $('#txtEntryFooter3').html($('#txtEntryFooterInformation3').val());
    })

</script>

