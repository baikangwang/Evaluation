<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserEntry.aspx.cs" Inherits="Evaluation.View.Mutual.UserEntry" validateRequest="false" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="renderer" content="webkit" />
    <meta http-equiv = "X-UA-Compatible" content="IE=edge,chrome=1" />   
    <title></title>
     <!--[if lte IE9]><script>window.location.href='upgrade-your-browser.aspx';</script>
        <![endif]-->
    <link rel="stylesheet" type="text/css" href="../../Content/bootstrap/bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/Verification/jquery.idcode.css" />
    <link rel="stylesheet" type="text/css" href="../../Content/assets/css/buttons.css" />
    <link rel="stylesheet" type="text/css" href="../../Content/font-awesome.css" />
    <script type="text/javascript" src="../../Scripts/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="../../Content/bootstrap.min.js"></script>
    <script type="text/javascript" src="../../Content/plugins/cookie/jquery.cookie.min.js"></script>
    <script type="text/javascript" src="../../Content/plugins/layer/layer.js"></script>
    <script src="../../Content/plugins/Verification/jquery.idcode.js"></script>
    <link href="../../Content/plugins/ui-choose/src/ui-choose.css" rel="stylesheet" />
    <script src="../../Content/plugins/ui-choose/src/ui-choose.js"></script>
    <style>
        * {
            font-family: "微软雅黑";
            margin: 0;
            padding: 0;
        }

        a.hover {
            text-decoration: none;
        }

        body {
            margin: 0px;
            padding: 0px;
        }

        #content table {
            margin: 0px auto;
            margin-top: 50px;
        }

        .btn-group-vertical button {
            padding: 25px 0 25px 0;
            border-left: none;
            border-right: none;
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

        .glyphicon-bullhorn {
            color: #218ACF;
        }

        .glyphicon-user {
            color: #218ACF;
        }

        .form-control:focus {
            border-color: #218ACF;
            outline: 0;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075), 0 0 8px rgba(102, 175, 233, .6);
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075), 0 0 8px rgba(102, 175, 233, .6);
        }

        .glyphicon-lock {
            color: #218ACF;
        }

        table {
            margin: 10px;
        }

        label {
            font-weight: normal;
            font-size: 14px;
        }

        table tr td {
            padding: 6px;
        }

        .button {
            background-image: url(../../Content/Images/dl.png);
            background-size: cover;
            width: 100%;
            color: #ffffff;
            border-radius: 6px;
            font-family: "微软雅黑";
            font-weight: 800;
        }

            .button:hover, .button:focus {
                background-color: #79beed;
                text-decoration: none;
                outline: none;
                color: #fff;
            }

        ul.ui-choose {
            font: none;
            font-size: 15px;
            font-family: "微软雅黑";
        }

            ul.ui-choose li {
                height: 29px;
                line-height: 28px;
                padding: 0 25px;
                font-weight: 500;
            }

            ul.ui-choose > li.selected {
                z-index: 3;
                border-color: #5aafe9;
                background-color: #5aafe9;
                color: #fff;
            }

        #chkState {
            margin-right: 5px;
        }
        .layui-layer-btn .layui-layer-btn0, .layui-layer-btn .layui-layer-btn1 {
            border-color: #33B0BA !important;
            background-color: #33B0BA !important;
            width: 78px !important;
            height: 26px !important;
            color: #fff !important;
        }

        .layui-layer.layui-layer-page.layer-anim {
            min-width: 280px !important;
            min-height: 156px !important;
            margin-left: -40px;
        }

        .layui-layer-btn a {
            line-height: 24px !important;
        }

        .layui-layer-setwin a:hover {
            background-color: transparent !important;
        }

        .layui-layer-title {
            background: #85E1E1 !important;
        }

        a.layui-layer-close1:focus {
            border: 1px solid transparent;
            outline: none;
        }

        .reminder {
            width: 322px;
            margin: 20px auto;
            height: auto;
            color: red;
        }

            .reminder .mind {
                padding-bottom: 9px;
                font-size: 16px;
            }
            #divEntryNoticeInformation p{
                font-size:14px!important;
            }
    </style>
</head>
<body>    
    <form id="form1" runat="server" defaultbutton="lkbLogin">
        <div style="display:none;">
            <asp:TextBox runat="server" ID="txtEntryNoticeInformation" ClientIDMode="Static" ></asp:TextBox>
            <asp:TextBox runat="server" ID="txtEntryImage" ClientIDMode="Static" ></asp:TextBox>
            <asp:TextBox runat="server" ID="txtEntryFooterInformation1" ClientIDMode="Static" ></asp:TextBox>
            <asp:TextBox runat="server" ID="txtEntryFooterInformation2" ClientIDMode="Static" ></asp:TextBox>
            <asp:TextBox runat="server" ID="txtEntryFooterInformation3" ClientIDMode="Static" ></asp:TextBox>
        </div>
        <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
        <div id="log-body" style="min-width: 300px">
            <div class="img">
                 <img src="#" style="width: 100%;" />
            </div>
            <div id="content">
                <table>
                    <tr>
                        <td colspan="3">
                            <div class="input-group" style="width: 100%;">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                <asp:TextBox runat="server" ID="txtUserName" ClientIDMode="Static" class="form-control" placeholder="请输入账号"></asp:TextBox>
                            </div>
                            <span id="msUserName" class="Promptmessage" style="color: red;" hidden="hidden">*请输入账号</span>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <div class="input-group" style="width: 100%;">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                                <asp:TextBox runat="server" TextMode="Password" ID="txtPwdword" ClientIDMode="Static" class="form-control" placeholder="请输入密码"></asp:TextBox>
                            </div>
                            <span id="msPassword" class="Promptmessage" style="color: red;" hidden="hidden">*请输入密码</span>
                        </td>
                    </tr>
                    <tr style="display: none;">
                        <td>请选择活动：
                        </td>
                        <td colspan="2">
                            <asp:DropDownList runat="server" ID="ddlActivityType" ClientIDMode="Static" class="form-control"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>输入验证码：
                        </td>
                        <td>
                            <input type="text" id="txtIdcode" class="txtVerification" style="width: 80px; margin-left: -5px;" />
                        </td>
                        <td>
                            <span id="idcode"></span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button runat="server" ID="forgetPassword" Text="找回密码" OnClick="forgetPassword_Click"
                                 Style="color: #218ACF; font-size: 14px; border: none; background: #fff; outline: none;" />
                        </td>
                        <td colspan="3" style="color: red; text-align: right;">*验证码不区分大小写</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:CheckBox ID="chkState" runat="server" ClientIDMode="Static" Text="记住密码" Style="color: #218ACF; font-size: 15px;" Visible="false" />
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:LinkButton runat="server" ID="lkbLogin" ClientIDMode="Static" class="button" Style="width: 100%;" OnClientClick="return checked()" OnClick="lkbLogin_Click">
                                登   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;录
                            </asp:LinkButton>
                            <a onclick="return quickLogin('administrator');" id="lkbLogin_admin" class="button" href="javascript:__doPostBack('lkbLogin','')" style="width: 100%;">
                                administrator
                            </a>
                            <a onclick="return quickLogin('管映冉');" id="lkbLogin_2" class="button" href="javascript:__doPostBack('lkbLogin','')" style="width: 100%;">
                                管映冉
                            </a>
                            <a onclick="return quickLogin('包解淦');" id="lkbLogin_1" class="button" href="javascript:__doPostBack('lkbLogin','')" style="width: 100%;">
                                包解淦
                            </a>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="reminder">               
                <div id="divEntryNoticeInformation"></div>
            </div>
            <hr style="border: solid 2px; color: #218ACF; margin-bottom: 0px;" />
            <div id="log-body-bottom">               
                <p id="txtEntryFooter1"></p>
                <p id="txtEntryFooter2"></p>
                <p id="txtEntryFooter3"></p>
            </div>
        </div>
    </form>
    <script>  
            //弹出框
     function ShowMessag(msg) {
        layer.open({
           type: 1
           , title: '提示'
           , content: '<div style="padding:20px 10px 0 10px;text-align:center;">' + msg + '</div>'
           , btn: '确  认'
           , btnAlign: 'c' //按钮居中
           , shade: 0 //不显示遮罩
           , yes: function () {
           layer.closeAll();
        }
       });
     }
      function ShowMessags(msg) {
        layer.open({
           type: 1
           , title: '提示'
           , content: '<div style="padding: 20px 10px 15px 10px;;text-align:center;">' + msg + '</div>'
           , btn: ['确  定', '取  消']
           , btnAlign: 'c' //按钮居中
           , shade: 0 //不显示遮罩
           , yes: function () {
           layer.closeAll();
          }
       });
      }
      $(function () {
          $.cookie('Code', null, { path: '/' });
          $.cookie('logoSrc', $('#txtEntryImage').val(), { path: '/' });       
          $('#divEntryNoticeInformation').html($('#txtEntryNoticeInformation').val());
          $('.img img').attr("src", $('#txtEntryImage').val());
          $('#txtEntryFooter1').html($('#txtEntryFooterInformation1').val());
          $('#txtEntryFooter2').html($('#txtEntryFooterInformation2').val());
          $('#txtEntryFooter3').html($('#txtEntryFooterInformation3').val());
          $('#divEntryNoticeInformation p:nth-child(1)').css('font-size','16px')
          var msg = $("#hdMsg").val();
          if (msg != "") {
              if (msg == "用户名或者密码错误!" || "请先输入账号！") {
                  ShowMessag(msg);
                  $('.layui-layer-close1').focus();
              }
          } 
          $.idcode.setCode();   //加载生成验证码方法  
      });

      function checked() {
          var sum = 0;
          var name = $("#txtUserName").val();
          var password = $("#Password").val();
          if (name == null || name == "") {
              $("#msUserName").show();
              $("#msUserName").css({ 'display': 'block', 'margin-left': '46px' })
              sum++;
          }
          else {
              $("#msUserName").hide();
          }

          if (sum > 0) {
              return false;
          }
          else {
              if (checkedCode()) {
                  return true;
              }
              else {
                  return false;
              }
          }
      }

      function checkedCode() {
          //调用返回值，返回值结果为true或者false
          if ($.idcode.validateCode()) {
              return true;
          } else {
              ShowMessag("验证码错误，请重新输入！");
              $('.layui-layer-close1').focus();
              return false;
          }
      }

      function quickLogin(userName) {
          $("#txtUserName").val(userName);
          $("#txtPwdword").val('Aa123456');
          return true;
      }
    </script>
</body>
</html>
