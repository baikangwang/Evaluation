<%@ Page Title="添加公告" Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="Notice.aspx.cs" Inherits="Evaluation.View.ActivityManage.Notice" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Content/plugins/ueditor/ueditor.config.js"></script>
    <script src="../../Content/plugins/ueditor/ueditor.all.js"></script>
    <script src="../../Content/plugins/ueditor/lang/zh-cn/zh-cn.js"></script>
    <!--bootstrap-fileinput-->
    <link href="../../Content/plugins/bootstrap-fileinput/css/fileinput.css" rel="stylesheet" />
    <script src="../../Content/plugins/bootstrap-fileinput/js/fileinput.js"></script>
    <script src="../../Content/plugins/bootstrap-fileinput/themes/fa/theme.js"></script>
    <script src="../../Content/plugins/bootstrap-fileinput/js/locales/zh.js"></script>    
    <style>
        #content {
            background-color: #EEEEEE;
            font-family: "微软雅黑";
            padding-bottom:200px!important;
        }

        body {
            font-size: 14px;
        }

        #container > #content > .container {
            width: 97%;
        }

        #ContentPlaceHolder1_noticeTitle {
            height: 30px;
        }

        p {
            font-size: 18px;
        }

        #lbkConserve {
            width: 78px;
        }

        .btn-primary {
            background-color: #35B4BF;
            border-color: #35B4BF;
        }

            .btn-primary:hover, .btn-primary:focus, .btn-primary:active, .btn-primary.active, .open .dropdown-toggle.btn-primary {
                background-color: #35B4BF;
                border-color: #35B4BF;
            }

        input[type="text"] {
            padding: 0;
            height: 30px;
            border: none;
            border: 1px solid #ccc;
            background: #fff;
            line-height: 9px;
        }
   
        .Ntitle {
            line-height: 30px;  margin-bottom: 14px;
        }

        .btn {
            width: 78px;
            height: 25px;
            line-height: 24px;
            padding: 0px;
            display: inline-block;
            margin: 15px auto;
            margin-right: 10px;
        }
        .input-group-btn .btn{
             height: 26px;
        }
            .btn:focus {
                background-color: #35B4BF !important;
                color: #fff !important;
            }

        .Nbutton {
            margin: 20px auto 0;
        }

        #ContentPlaceHolder1_date {
            margin-left: 197px;
            line-height: 30px;
        }

        textarea[disabled], textarea[readonly] {
            cursor: inherit !important;
            color: #555 !important;
        }

        #txtContent {
            overflow-y: hidden;
            border: none;
            resize: none;
            min-height: 250px;
            background: #fff;
            font-size: 15px !important;
        }

        #txtNoticeContent {
            resize: none;
            border: 1px solid #ccc;
        }

        #ContentPlaceHolder1_panelLook {
            width: 800px;
            margin: 0px auto;
            background: #fff;
            border: 1px solid #C4CDD4;
            padding: 15px 10px 0 15px;
            border-radius: 4px;
            min-height: 500px;
            position: relative;
        }

        #edui1_iframeholder {
            min-height: 300px;
        }

        #edui1_toolbarbox, #edui1 {
            z-index: 0 !important;
        }

        #edui1 {
            width: 615px !important;
        }

        #MailContent {
            margin-left: 75px;
            margin-top: -17px;
        }

        .btn.btn-primary.btn-file {
            margin-left: 5px;
        }

        .hidden-xs {
            display: inline !important;
        }
        #UPTable .btn{
            margin:0;
        }
        #tdUploadFileInfo {
            padding-left:2px;width:400px;
        }

                #tdUploadFileInfo a:hover,#tdLookUploadFileInfo a:hover {
                    background: transparent;
                }

             a.DeleteNoticeAppendix {
                    padding-left: 20px;
                }

                #tdUploadFileInfo a i {
                    font-size: 18px;
                }

     
        #tabLookUploadFileInfo{
        position: absolute; left: 0; right: 0; margin: 15px auto; bottom: -50px;line-height:16px;
        }
         #tabLookUploadFileInfo td{
         font-size:16px;
         }
         #tabLookUploadFileInfo a i{
          font-size: 16px;
         }
            #tabLookUploadFileInfo .DeleteNoticeAppendix {
            display:none;
            }
        .progress {
            margin-bottom: -20px !important;
            position: relative;
            bottom: -1px;
            width: 185px;
            left: 430px;
        }
           
            .form-control{
                height:25px!important;padding:0!important;
            }
            .file-caption-name{
                line-height:24px;
            }
            .div{
                margin-bottom:13px;
            }
            #ContentPlaceHolder1_panelLook strong, #ContentPlaceHolder1_panelLook em span, #ContentPlaceHolder1_panelLook div, #ContentPlaceHolder1_panelLook em{
                font-size:inherit;
            }
            #ContentPlaceHolder1_panelLook span, #ContentPlaceHolder1_panelLook p{
               word-wrap:break-word;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" id="main" style="float: left; padding-right: 5px;">
            <a href="#">评优管理</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="../ActivityManage/NoticeList.aspx">公告管理</a>
        </li>
    </ul>
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <asp:HiddenField runat="server" ID="NoticeID" ClientIDMode="Static" />
    <div class="container div">
        <div class="row">
            <asp:Panel ID="panelOperation" runat="server">
                <div style="border: 1px solid #E1E1E1; width: 729px; padding: 20px 15px 10px 18px; margin: 15px auto; border-radius: 5px;">
                   
                                <div class="Notice Ntitle">
                                    <asp:Label ID="title" runat="server" Text="公告标题 :"></asp:Label>
                                    <asp:TextBox ID="txtTitle" Width="615px" runat="server" ClientIDMode="Static" Style="margin-left: 8px;"></asp:TextBox>
                                    <span id="msTitle" class="Promptmessage" style="color: red;" hidden="hidden">* 公告标题限40个汉字以内</span>
                                </div>
                           
                                <div style="padding: 0 0 10px 24px;">
                                    <asp:Label ID="LOrdinal" runat="server" Text="排 序 :" Style="display: inline-block;padding-top:4px;" onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;"></asp:Label>&nbsp;&nbsp;
                                <asp:TextBox ID="TbxOrdinal" Width="300px" runat="server" ClientIDMode="Static" onkeyup="value=value.replace(/[^\d]/g,'')"></asp:TextBox>
                                    <span id="msOrdinal" class="Promptmessage" style="color: red;" hidden="hidden">&nbsp;  * 请输入序号</span>
                                </div>
                                                                                
                    <%--<div style="overflow:hidden;line-height:36px;padding-bottom:10px;">
                    <asp:Label ID="Label1" runat="server" Text="生效时间 :" Style="float:left;margin-right:8px;"></asp:Label>&nbsp;&nbsp;
                    <div class="datepicker input-group date" style="width:250px;float:left;">
                        <asp:TextBox ID="txtStartDate" ClientIDMode="Static" runat="server" class="form-control"></asp:TextBox>
                        <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                    </div>
                    <span id="msDate" class="Promptmessage" style="color:red;" hidden="hidden">* 请选择生效时间</span>
                </div>--%>
                    <div class="Notice div">
                        <asp:Label ID="content" runat="server" Text="公告内容 :"></asp:Label>
                        &nbsp; 
                        <asp:TextBox ID="txtNoticeContent" runat="server" Width="600px" Height="200px" TextMode="MultiLine" Columns="40" Rows="10" ClientIDMode="Static" Style="display: none;"></asp:TextBox>
                        <script id="MailContent"></script>
                        <span id="msContent" class="Promptmessage" style="color: red;" hidden="hidden">* 请输入公告内容</span>
                    </div>
                      <table id="UPTable" style="display: none">
                            <tr>
                                <td>
                                    <asp:Label ID="labAppendix" runat="server" Text="上传附件 :" Style="display: inline-block; "></asp:Label>&nbsp;&nbsp;
                                </td>
                                <td style="width:400px;padding-left:3px;">
                                    <input type='file' class='FileUpAppendix' name='FileUpExcel' />
                                </td>
                             </tr>
                             <tr style="height:50px;">                              
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="附件 :" Style="display: inline-block; margin-left: 28px;"></asp:Label></td>
                                <td id="tdUploadFileInfo" runat="server" clientidmode="Static" ></td>                               
                            </tr>
                        </table>
                    <br />
                    <div class="Notice Nbutton" style="width: 185px;">
                        <asp:LinkButton runat="server" Text="发&nbsp;&nbsp;&nbsp;&nbsp;布" ID="lbkConserve" ClientIDMode="Static" class="btn btn-primary btn-3d button-primary button-rounded" OnClientClick="return requiredInfo()" OnClick="lbkConserve_Click"></asp:LinkButton>
                        <asp:LinkButton runat="server" ID="lbkUpdate" ClientIDMode="Static" class="btn btn-primary btn-3d button-primary button-rounded" OnClientClick="return requiredInfo()" OnClick="lbkUpdate_Click">
                        保&nbsp;&nbsp;&nbsp;&nbsp;存
                        </asp:LinkButton>
                        <asp:LinkButton runat="server" ID="LbkCancel" ClientIDMode="Static" class="btn btn-primary btn-3d button-primary button-rounded" OnClick="LbkCancel_Click"> <%--OnClientClick="back()"--%>
                        返&nbsp;&nbsp;&nbsp;&nbsp;回
                        </asp:LinkButton>
                    </div>

                </div>
            </asp:Panel>

            <asp:Panel ID="panelLook" runat="server">
                <div style="text-align: center; padding-top: 20px;">
                    <asp:Label ID="lblTitle" runat="server" Style="font-size: 20px; color: #000; font-weight: bold;"></asp:Label>
                </div>
                <br />
                <div style="border-top: 1px solid #D3D3D3; border-bottom: 1px solid #9D9D9D; padding: 5px 10px; text-align: center;">
                    <%-- <i class="fa  fa-clock-o "></i>--%>
                    发布时间：
                <asp:Label ID="lblDate" runat="server"></asp:Label>
                </div>
                <br />
                <div id="nContent" runat="server" width="775px"></div>
                <%--<asp:TextBox ID="txtContent" runat="server"  width="775px" TextMode="MultiLine" Columns="67"  ClientIDMode="Static"  ></asp:TextBox>--%>
                <br />
                <br />
                <table id="tabLookUploadFileInfo" runat="server" clientidmode="Static">
                    <tr>
                        <td> 附 件 ：</td> 
                        <td id="tdLookUploadFileInfo" runat="server" clientidmode="Static" ></td> 
                    </tr> 
                    <tr></tr>
                </table> 
                <br />
                <div style="width: 80px; margin: 0px auto; position: absolute; left: 0; right: 0; margin: 15px auto; bottom: -135px;">
                    <asp:LinkButton runat="server" ID="LbkBack" ClientIDMode="Static" class="btn btn-primary btn-3d button-primary button-rounded" OnClick="LbkBack_Click"> <%--OnClientClick="back()"--%>
                        返&nbsp;&nbsp;&nbsp;&nbsp;回
                    </asp:LinkButton>
                </div>
            </asp:Panel>

        </div>
    </div>
    <script type="text/javascript">        
        // 附件相关
        $(".FileUpAppendix").fileinput({
            showPreview: false,
            language: "zh",
            theme: "fa",
            uploadUrl: "../Mutual/ActivityManage.ashx?Action=ImportNoticeAppendix",
            uploadAsync: true,
            uploadExtraData: { "NoticeID": $('#NoticeID').val() },
        })

        $('.FileUpAppendix').on('fileuploaded', function (event, data) {
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                async: false,
                data: { "Action": "GetNoticeAppendix", "NoticeID": $('#NoticeID').val() },
                success: function (data) {
                    if (data != "") {
                        data = JSON.parse(data);
                    }
                    ShowMessag('上传成功');                 
                    $("#tdUploadFileInfo").html(data);
                    $('.layui-layer-btn0').click(function () {
                        $('.fileinput-remove').click();
                    })                    
                },
                error: function () {
                    ShowMessag('上传失败');
                }
                });
            $('#lbkConserve').click();            
        });
      
        // 下载附件
        function DownloadAppendix(NoticeID) {
            LoadFile(NoticeID);
            var form = $("<form>");   //定义一个form表单
            form.attr('style', 'display:none');   //在form表单中添加查询参数
            form.attr('target', '');
            form.attr('method', 'post');
            form.attr('action', "../Declaration/DeclarationList.aspx?NoticeID=" + NoticeID);

            var input1 = $('<input>');
            input1.attr('type', 'hidden');
            $('body').append(form);  //将表单放置在web中
            form.append(input1);   //将查询参数控件提交到表单上
            form.submit();
        }
        function LoadFile(NoticeID) {
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                async: false,
                data: { "Action": "LoadNoticeFile", "NoticeID": NoticeID },
            })
        }
        // 删除附件
        function DeleteNoticeAppendix(NoticeID) {
            ShowMessags('是否删除此附件？')
            $('.layui-layer-btn0').on('click', function () {
                $.ajax({
                    url: '../Mutual/ActivityManage.ashx',
                    type: "post",
                    async: false,
                    data: { "Action": "DeleteNoticeAppendix", "NoticeID": NoticeID },
                    success: function (data) {
                        if (data !="") {
                            data = JSON.parse(data);
                        }
                            $("#tdUploadFileInfo").text("暂未上传附件！");                                                                    
                    }
                });
            })
        }
        // 初始化富文本框
        function InitUEditor(container) {
            var ue = UE.getEditor(container, {
                autoHeightEnabled: false,
                allowDivTransToP: false,
                toolbars: [[
                        'source', '|',
                        'undo', 'redo', '|',
                        'bold', 'italic', 'underline', 'strikethrough', 'removeformat', '|',
                        'forecolor', 'backcolor', '|',
                        'insertorderedlist', 'insertunorderedlist', 'cleardoc', '|',
                        'paragraph', 'fontfamily', 'fontsize', '|',
                        'indent', '|',
                        'justifyleft', 'justifycenter', 'justifyright', 'justifyjustify', '|',
                        'link', '|',
                        'simpleupload', '|',
                        'inserttable', 'deletetable', 'insertparagraphbeforetable', 'insertrow', 'deleterow', 'insertcol', 'deletecol', 'mergecells', 'mergeright', 'mergedown', 'splittocells', 'splittorows', 'splittocols'
                ]]
            });

            ue.ready(function () {
                //设置编辑器的内容  
                var d = new Date()
                var vYear = d.getFullYear()
                var vMon = d.getMonth() + 1
                var vDay = d.getDate()
                var h = d.getHours();
                var m = d.getMinutes();
                var se = d.getSeconds();
                s = vYear + '.' + (vMon < 10 ? "0" + vMon : vMon) + '.' + (vDay < 10 ? "0" + vDay : vDay);
                ue.setContent($("#txtNoticeContent").val());
            });
        }


        $(function () {
            if ($('#NoticeID').val() != "") {
                $('#UPTable').css("display", "block");
            };
            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
                $('.layui-layer-btn0').on('click', function () {
                });
            }
            var lbkConserve = $("#lbkConserve").css("display")
            var lbkUpdate = $("#lbkUpdate").css("display")
            if (lbkConserve || lbkUpdate) {
                $(".Nbutton").css("width", "185px")
            } else {
                $(".Nbutton").css("width", "78px")
            }

            if ($("#ContentPlaceHolder1_panelLook") && $("#ContentPlaceHolder1_panelLook").length <= 0) {
                InitUEditor('MailContent');
            }
        })
        function requiredInfo() {
            var num = 0;
            var title = $("#txtTitle").val();
            var content = UE.getEditor('MailContent').getContent();
            var ordinal = $("#TbxOrdinal").val();
            if (title == null || title == "" || title.length > 40) {
                $("#msTitle").show();
                $("#msTitle").css({ 'display': 'block', 'margin-left': '70px' })
                num++;
            }
            else {
                $("#msTitle").hide();
            }

            if (content == null || content == "") {
                $("#msContent").show();
                $("#msContent").css({ 'display': 'block', 'margin-left': '70px' })
                num++;
            }
            else {
                $("#msContent").hide();
            }
            if (ordinal == null || ordinal == "") {
                $("#msOrdinal").show();
                num++;
            }
            else {
                $("#msOrdinal").hide();
            }
            if (num > 0) {
                return false;
            }
            else {
                $("#txtNoticeContent").val(UE.getEditor('MailContent').getContent());
                return true;
            }
        }
    </script>
</asp:Content>

