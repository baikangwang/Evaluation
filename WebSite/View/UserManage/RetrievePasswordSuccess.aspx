<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RetrievePasswordSuccess.aspx.cs" Inherits="Evaluation.View.UserManage.RetrievePasswordSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <script type="text/javascript" src="../../Content/assets/js/libs/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="../../Content/plugins/cookie/jquery.cookie.min.js"></script>
    <style>
         *{
                margin:0;padding:0;font-family:"微软雅黑";font-size:15px;
            }
            table{margin:auto;}
            table tr td{padding:10px;}
            #Btn_success{
                width:100px;height:28px;margin-left:98px;
                background: -webkit-gradient(linear, 0% 0%, 0% 100%,from(#5aafe9), to(#0F7AD2));
                border:none;
                border-radius:6px;
                color:#fff;
                margin-top:24px;
                outline:none;
            }
         
               .crumbs{
                width:56%;
                height:36px;
             
               margin:20px auto;
            
                overflow:hidden;
            }
             .crumbs1 span{
                 color:#ffffff;
                 padding-left:27%;
                 display:block;
                 padding-top:8px;
             }
              .crumbs2 span{
                 color:#ffffff;
                 padding-left:33%;
                  display:block;
                 padding-top:8px;
             }
              .crumbs3 span{
                 color:#ffffff;
                 padding-left:41%;
                 display:block;
                 padding-top:8px;
             }


            .crumbs1{
                float:left;
                width:33%;
                height:100%;
             
                 background-image:url(../../Content/Images/tab1a.png) ;
                background-size: 100% 116%;
                background-repeat: no-repeat;
                background-position: 0 -1px;
               
            }
               .crumbs2{
                float:left;
                width:35%;
                height:100%;
                 margin-left:-19px;
               background-image:url(../../Content/Images/tab2.png) ;
                background-size: 100% 123%;
                background-repeat: no-repeat;
                background-position: 0 -3px;
               
            }
                  .crumbs3{
                float:left;
                width:34%;
                height:100%;
                margin-left:-19px;
                background-image:url(../../Content/Images/tab2a.png) ;
                background-size: 100% 120%;
                background-repeat: no-repeat;
                background-position: 0 -2px;
               
            }
                  #time{
                      color:red;padding-left:58px;
                  }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <%--<div>
            <img src="/Content/Images/login.jpg" style="width: 100%; height: 100%;" />
        </div>--%>
        <div class="img">
            <img  src="#" style="width: 100%; height: 100%;" />
        </div> 
         <div class="crumbs">
            <div class="crumbs1">
                <span>1.进行安全验证</span>
            </div>
            <div class="crumbs2">
                  <span>2.设置新密码</span>
            </div>
            <div class="crumbs3">
                  <span>3.成功</span>
            </div>
        </div>
    <div class="da-box" style="padding-top:44px;margin:0 auto;width:260px;">
        <span >恭喜您 ! 密码已经重置成功,请重新登录</span>
        <br/>
         <br/>
         
	    <span id="time">5</span>
	    <span>s秒后返回登录页面</span>
	
     </div>

    </form>
</body>
</html>
<script>
    window.onload = function () {
        var time=document.getElementById('time')
        setInterval(t, 1000)                  
        var num = 5;
        function t() {
            num--;
            if (num<= 0) {
                window.location="../Mutual/UserEntry.aspx"
            }
            time.innerHTML = num;            
        }

    }
    $(function () {
        var logoSrc = $.cookie('logoSrc');
        $('.img img').attr("src", logoSrc);
    })
</script>
