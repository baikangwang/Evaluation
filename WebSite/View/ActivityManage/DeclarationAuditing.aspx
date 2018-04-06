<%@ Page Title="项目审核" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="DeclarationAuditing.aspx.cs" Inherits="Evaluation.View.ActivityManage.DeclarationAuditing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Content/plugins/ueditor/ueditor.config.js"></script>
    <script src="../../Content/plugins/ueditor/ueditor.all.js"></script>
    <script src="../../Content/plugins/ueditor/lang/zh-cn/zh-cn.js"></script>
    <style>
        .table-bordered > thead > tr > th, .table-bordered > thead > tr > td {
            border-bottom: solid 3px #FFF;
        }

        .bottom > tbody > tr > td {
            border-left: dashed 1px #EFEFEF;
        }

        .table-bordered {
            border-bottom: solid 3px #CFCFCF;
            border-top: solid 3px #CFCFCF;
        }
         
        .professional {
            height: 30px;
        }

        .select input[type="text"] {
            padding: 5px 6px !important;
            border: none;
            border: 1px solid #ccc;
            margin-left: 20px;
        }

        #txtDeclarationBeginDate, #txtDeclarationEndDate, #txtEditBeginDate, #txtEditEndDate {
            margin-left: 0px !important;
        }

        .select input[type="text"] {
            margin-left: 0px !important;
        }

        .progress {
            height: 6px;
            border-radius: 30px;
            overflow: initial;
        }

        .schedule {
            padding-right: 45px;
        }

        .progress .progress-bar {
            position: relative;
            border-radius: 30px;
        }

        .tbprogress {
            border: 0;
            background-color: rgba(0,0,0,0);
        }

            .tbprogress tbody tr {
                border: 0;
                background-color: rgba(0,0,0,0);
            }

                .tbprogress tbody tr td {
                    border: 0;
                    background-color: transparent;
                }

        .input-group-addon {
            height: 26px;
            padding: 0;
        }

        .inquire {         
            width:80px;
            margin:20px auto 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" id="main" style="float: left; padding-right: 5px;">
            <a id="column1" href="#">评优管理</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1"  style="float: left; padding-right: 5px;">
            <a id="column2" href="../ActivityManage/DeclarationAuditing.aspx">项目审核</a>
        </li>
    </ul>
    <div class="DeclarationList" style="border: 1px solid #e1e1e1; border-radius: 5px; position: relative; padding: 10px;">
        <div class="select" style="margin: 0 20px 0 0">          
            <span>项目名称：  <asp:TextBox ID="txtDeclarationName" ClientIDMode="Static" runat="server" Width="168px" Height="26px" placeholder="项目名称"></asp:TextBox>
            </span>  　
             <span >申报单位：
                 <asp:TextBox runat="server" ID="txtDeclarationUnit" ClientIDMode="Static" Style="width: 168px; height: 26px; margin-left: -12px; margin-right: 15px;"></asp:TextBox>
            </span>   
			 <span style="margin-left: 15px;margin-right:15px;">
                 申报奖项：
                 <asp:DropDownList ID="ddlPrizeName" runat="server" ClientIDMode="Static" Style="width: 168px; height: 26px; margin-left: -13px; margin-right: 15px;"></asp:DropDownList>
            </span>         
             <span>申报状态： <asp:DropDownList ID="ddlDeclarationStatus" runat="server" ClientIDMode="Static" Style="width: 168px; margin-left: 28px; height: 26px; margin-left: 0px;"></asp:DropDownList>
            </span>
        </div>
        <div style="margin:15px 0 0 0px;">
            <div class="input-group">
                <span style="float: left; padding-top: 6px;">填报日期：</span>
                <table style="float: left;">
                    <tr>
                        <td>
                            <div class="datepicker input-group date">
                                <asp:TextBox ID="txtDeclarationBeginDate" Height="26px" ClientIDMode="Static" runat="server" class="form-control" placeholder="请选择开始日期"></asp:TextBox>
                                <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                            </div>
                        </td>
                        <td>
                            <span>&nbsp;至&nbsp;</span>
                        </td>
                        <td>
                            <div class="datepicker input-group date">
                                <asp:TextBox ID="txtDeclarationEndDate" Height="26px" ClientIDMode="Static" runat="server" class="form-control" placeholder="请选择结束日期"></asp:TextBox>
                                <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="inquire">
        <input type="button" value="查 &nbsp; 询" class="btnt" onclick="onSearch();" />
    </div>
    <br />
    <div style="display: none;">
        <input type="text" value="" id="Hide" />
        <input type="text" value="" id="HidePostDeclarationID" />
        <input type="text" value="" id="UnHidePostDeclarationID" />
        <input type="text" value="" id="CommentDeclarationID" />
    </div>
    <div id="toolbar" class="btn-group">
        <button id="btn_check" type="button" class="btn btn-default" title="收件封存（批量）" onclick="Appear('Check');return false;">
            <span class="fa fa-archive" aria-hidden="true"></span>&nbsp;收件封存（批量）
        </button>
        <button id="btn_return" type="button" class="btn btn-default" title="驳回修改（批量）" onclick="Appear('Return');return false;">
            <span class="fa fa-mail-reply-all" aria-hidden="true"></span>&nbsp;驳回修改（批量）
        </button>
<%--        <button id="btn_ThoroughDelete" type="button" class="btn btn-default" title="管理员删除（批量）" onclick="Appear('ThoroughDelete');return false;">
            <span class="fa fa-trash-o" aria-hidden="true"></span>&nbsp;管理员删除（批量）
        </button>--%>
    </div>
    <div id="Mail" style="width: 70%; height: 480px; border: 1px solid black; background: white; margin: auto; z-index: 3; left: 20%; bottom: 15%; position: fixed; display: none; z-index: 99; top: 70px;">
        <h3 style="margin: 15px auto 0 auto; width: 200px;">请填写评价内容</h3>
        <div style="position: absolute; right: 10px; top: 3px;">
            <a style="color: red; font-size: 24px; cursor: pointer" onclick="Cancel();return false;">×</a> 
        </div>
        <table style="width: 80%; margin: auto; border-spacing: 7px; border-collapse: separate;">
            <tr style="display:none;">
                <td>收件人：</td>
            </tr>
            <tr style="display:none;">
                <td>
                    <div id="Recipients" style="width: 96%; height: 40px; border: 1px solid #ccc; margin-left: 4%; margin-top: -8px; line-height: 38px; padding-left: 10px; overflow: auto;"></div>
                </td>
            </tr>
            <tr>
                <td>评价内容：</td>
            </tr>
            <tr>
                <td>
                    <script id="MailContent" type="text/plain" style="height: 200px; margin-left: 30px; margin-top: -7px;"></script>
                </td>
            </tr>
        </table>
        <div style="width: 200px; margin: 30px auto;">
            <input type="button" value="确认" class="btnt" id="Idbtnt" style="margin-right: 10px;" onclick="Ensure(); return false;" />
            <input type="button" value="取消" class="btnt" style="width: 78px;" onclick="Cancel(); return false;" />
        </div>
    </div>

    <%--项目评价相关--%>
    <div id="Evaluate" style="width: 70%; height: 480px; border: 1px solid black; background: white; margin: auto; z-index: 3; left: 20%; bottom: 15%; position: fixed; display: none; z-index: 99; top: 70px;">
        <h3 style="margin: 15px auto 0 auto; width: 150px;">项目评价</h3>
        <div style="position: absolute; right: 10px; top: 3px;"><a style="color: red; font-size: 24px; cursor: pointer" onclick="CancelEvaluate();return false;">×</a> </div>
        <table style="width: 80%; margin: auto; border-spacing: 7px; border-collapse: separate;">
            <tr>
                <td>
                    <asp:TextBox ID="DeclarationComment" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 80%; height: 300px;margin-left: 60px; margin-top: 30px;"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div style="width: 240px; margin: 30px auto;">
            <input type="button" value="提 &nbsp; 交" class="btnt" style="width:78px; margin-right: 10px;" onclick="Comment(); return false;" />
            <input type="button" value="取 &nbsp; 消" class="btnt" style="width: 78px;" onclick="CancelEvaluate(); return false;" />
        </div>
    </div>

    <%--显示列表--%>
    <table id="tbList"></table>
    <div id="divPagination" style="overflow: hidden; margin-top: 10px; padding-bottom: 65px;"></div>
    <script>
        var userType = '<%=(Session["UserInfo"] == null ? "" :((Dal.Models.UserInfo)Session["UserInfo"]).UserType.ToString()) %>';

        // 提交项目评价
        function Comment() {
            var DeclarationID = $("#CommentDeclarationID").val();
            var DeclarationComment = $("#DeclarationComment").val();
            SubmitComment(DeclarationID, DeclarationComment);
        }

        function SubmitComment(DeclarationID, DeclarationComment) {
            var PerPage = $('#per_page_select').val();
            $.ajax({
                url: '../Mutual/Declaration.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "SubmitComment",
                    "DeclarationID": DeclarationID,
                    "DeclarationComment": DeclarationComment
                },
                success: function (data) {
                    data = JSON.parse(data);
                    ShowMessag(data);
                    CancelEvaluate();
                    InitTable(PerPage, 1);
                }
            });
        }
       
        var texts;
        // 初始化富文本框
        function InitUEditor(container, max) {
            var ue = UE.getEditor(container, {
                autoHeightEnabled: false,
                allowDivTransToP: false,
                maximumWords: max,
                toolbars: [[
                        'source', '|',
                        'undo', 'redo', '|',
                        'bold', 'italic', 'underline', 'strikethrough', 'removeformat', '|',
                        'forecolor', 'backcolor', '|',
                        'cleardoc', '|',
                        'paragraph', 'fontfamily', 'fontsize', '|',
                        'indent', '|',
                        'justifyleft', 'justifycenter', 'justifyright', 'justifyjustify', '|'                        
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
                ue.setContent('<p>　　您好：</p><p>　　　　您申报的项目已被' + texts + '请知悉。</p><p>　　此致！</p><p>敬礼！</p><p>　　　　　　　　　　　　　　　　　　　　　　　　' + s + '</p>');
            });
        }

        InitUEditor('MailContent', 500);

        function Appear(state) {
            var DeclarationID = getIdSelections();
            var a = getIdSelections3();
            var b = getIdSelections4();
            var c = getIdSelections5();
            var d = getIdSelections6();
            if (state == "Check") {
                var ArrayStatusC = getIdSelections3().indexOf('True');
                var PostDeclarationID = "";
                var UnPostDeclarationID = "";
                var DeclarationName = "";
                for (i = 0; i < DeclarationID.length; i++) {
                    PostDeclarationID = PostDeclarationID + d[i]["DeclarationID"] + ",";
                    DeclarationName = DeclarationName + d[i]["DeclarationName"] + ",";
                }
                PostDeclarationID = PostDeclarationID.substring(0, PostDeclarationID.length - 1);
                DeclarationName = DeclarationName.substring(0, DeclarationName.length - 1);

                ShowMessags('是否收件封存此申报？');
                $('.layui-layer-btn0').on('click', function () {
                    texts = "收件封存";
                    $('#Idbtnt').val('收件封存');
                    InitUEditor('MailContent', 500);
                    $("#Mail").css("display", "block");
                    $("#Hide").val("Check");
                    $("#HidePostDeclarationID").val(PostDeclarationID);
                    //$("#Recipients").html(getRecipientsName());
                    //$("#Subject").html(DeclarationName);
                });
            }
            else if (state == "Return") {
                var ArrayStatusC = getIdSelections4().indexOf('True');
                var PostDeclarationID = "";
                var UnPostDeclarationID = "";
                var DeclarationName = "";
                for (i = 0; i < DeclarationID.length; i++) {
                    PostDeclarationID = PostDeclarationID + d[i]["DeclarationID"] + ",";
                    DeclarationName = DeclarationName + d[i]["DeclarationName"] + ",";
                }

                PostDeclarationID = PostDeclarationID.substring(0, PostDeclarationID.length - 1);
                DeclarationName = DeclarationName.substring(0, DeclarationName.length - 1);

                ShowMessags('是否驳回修改此申报？');
                $('.layui-layer-btn0').on('click', function () {
                    texts = "驳回修改";
                    $('#Idbtnt').val('驳回修改')
                    InitUEditor('MailContent', 500);
                    $("#Mail").css("display", "block");
                    $("#Hide").val(state);
                    $("#HidePostDeclarationID").val(PostDeclarationID);
                    //$("#Recipients").html(getRecipientsName());
                    //$("#Subject").html(DeclarationName);
                });
            }
        }

        function Cancel() {
            $("#Mail").css("display", "none");
        }

        function CancelEvaluate() {
            $("#Evaluate").css("display", "none");
        }

        function Ensure() {
            var MailContent = UE.getEditor('MailContent').getContent();
            //var Subject = $("#Subject").val();
            var state = $("#Hide").val();
            var result = UE.getEditor('MailContent').getContent().replace(/</g, '&lt;');
            result = result.replace(/>/g, '&gt;');
            result = result.replace(/"/g, '&quot;');
            result = result.replace(/'/g, '&rsquo;');
            result = result.replace(/ /g, '&nbsp;');
            result = result.replace(/\//g, "&frasl;");
            //ShowMessag(result);
            //DelPlural(state, Subject, result);
            DelPlural(state, result);
        }

        function DelPlural(action, MailContent) {
            var DeclarationID = $("#HidePostDeclarationID").val();
            var PerPage = $('#per_page_select').val();

            var ss;
            if (DeclarationID != "") {
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    async: true,
                    data: {
                        "Action": action,
                        "DeclarationID": DeclarationID,
                        "MailContent": MailContent
                    },
                    success: function (data) {
                        $("#Mail").css("display", "none");
                        ShowMessag(JSON.parse(data));
                        InitTable(PerPage, 1);
                    }
                });
            }

            //var UnPostDeclarationID = $("#UnHidePostDeclarationID").val();
            //if (UnPostDeclarationID != "") {
            //    $.ajax({
            //        url: '../Mutual/Declaration.ashx',
            //        type: "post",
            //        async: false,
            //        data: {
            //            "Action": action,
            //            "DeclarationID": UnPostDeclarationID,
            //            "Act": action,
            //            "MailContent": MailContent
            //        },
            //        success: function (data) {
            //            ShowMessag(JSON.parse(data));
            //            InitTable(50, 1);
            //        }
            //    });
            //}
        }

        function onSearch(PerPage, CuttentPage) {
            var DeclarationName = $('#txtDeclarationName').val();
            var DeclarationUnit = $('#txtDeclarationUnit').val();
            var PrizeName = $('#ddlPrizeName').multipleSelect("getSelects").toString();
            var DeclarationBeginDate = $('#txtDeclarationBeginDate').val();
            var DeclarationEndDate = $('#txtDeclarationEndDate').val();
            var EditBeginDate = $('#txtEditBeginDate').val();
            var EditEndDate = $('#txtEditEndDate').val();
            var DeclarationStatus = $('#ddlDeclarationStatus').multipleSelect("getSelects").toString();

            if (PerPage == null || PerPage == "") {
                PerPage = $('#per_page_select').val();
            }

            if (CuttentPage == null || CuttentPage == "") {
                CuttentPage = 1;
            }

            InitTable(PerPage, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, DeclarationBeginDate, DeclarationEndDate, EditBeginDate, EditEndDate, DeclarationStatus);
        }

        function getIdSelections() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.DeclarationID
            });
        }

        function getIdSelections2() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.DeclarationStatusText
            });
        }

        // 获取该行是否发送封存邮件
        function getIdSelections3() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.IsSendReceivePost
            });
        }

        // 获取该行是否发送驳回邮件
        function getIdSelections4() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.IsSendUpdatePost
            });
        }

        // 获取该行是否发送删除邮件
        function getIdSelections5() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.IsSendDeletePost
            });
        }

        function getIdSelections6() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (data) {
                return data;
            });
        }

        function getDeclarationName() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return "[" + row.DeclarationName + "]-[" + row.PrizeName + "]-申报结果<br/>"
            });
        }

        function getRecipientsName() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.EmailAddress + '<br/>'
            });
        }

        function operateFormatter(value, row, index) {
            var Check;
            var View;
            var Return;

            View = [
                '<a class="edit" href="javascript:void(0)" title="浏览">',
                '<i class="fa fa-search"></i>',
                '</a>  '
            ];

            Return = [
                '<a class="return" href="javascript:void(0)" title="驳回修改">',
                '<i class="fa fa-mail-reply-all"></i>',
                '</a> '
            ];

            if (row.DeclarationStatus == "1802") {
                Check = [
                    '<a class="check" href="javascript:void(0)" title="收件封存">',
                    '<i class="fa fa-archive"></i>',
                    '</a>  '
                ];
            }
            else {
                Check = [
                    '<a href="javascript:void(0)" title="收件封存">',
                    '<i class="fa fa-archive" style="color:rgba(0,0,0,0.2)"></i>',
                    '</a>  '
                ];
            }

            if (userType == "0809" || userType == "0808") {
                return View.concat(Return).join('');
            }
            else {
                return View.concat(Check, Return).join('');
            }
        }

        function getNav() {
            //缓存当前页面所属栏目
            var ocolumn2Link = $("#column2").attr("href");
            var currerntNav = {column1:$("#column1").text(),column2Link:ocolumn2Link,column2:$("#column2").text()}
            $.cookie('currentPage', JSON.stringify(currerntNav), { path: '/' });
        }

        function InitTable(PageSize, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, DeclarationBeginDate, DeclarationEndDate, EditBeginDate, EditEndDate, DeclarationStatus) {
            $('#tbList').bootstrapTable('destroy');

            window.operateEvents = {
                'click .edit': function (e, value, row, index) {
                    location.href = "../Declaration/Declaration.aspx?DeclarationID=" + row.DeclarationID + "&Situation='Auditing'";
                    getNav();
                },
                'click .evaluate': function (e, value, row, index) {
                    $.ajax({
                        url: '../Mutual/Declaration.ashx',
                        type: "post",
                        data: { "Action": "GetComment", "DeclarationID": row.DeclarationID },
                        success: function (data) {
                            data = JSON.parse(data);
                            $("#DeclarationComment").val(data);
                        }
                    });
                    $("#Evaluate").css("display", "block");
                    $("#CommentDeclarationID").val(row.DeclarationID);
                },
                'click .check': function (e, value, row, index) {
                    texts = "收件封存";
                    $('#Idbtnt').val('收件封存');
                    InitUEditor('MailContent', 500);
                    $("#Mail").css("display", "block");
                    $("#Hide").val("Check");
                    $("#HidePostDeclarationID").val(row.DeclarationID);

                    //$("#Recipients").text(row.EmailAddress);
                    //$("#Subject").text("[" + row.DeclarationName + "]-[" + row.PrizeName + "]-申报结果");
                    //$('#edui2').css({ "height": "24px" });
                    //$('#edui2>div').css({ "display": "none", "height": "0px" });
                    //$('#edui8').css({ "display": "block", "height": "22px", "margin-left": "-82px" });
                    //$('#edui9').css({ "display": "block", "height": "22px" });
                    //$('#edui10').css({ "display": "block", "height": "22px" });

                },
                'click .return': function (e, value, row, index) {
                    texts = "驳回修改";
                    $('#Idbtnt').val('驳回修改');
                    InitUEditor('MailContent', 500);
                    $("#Mail").css("display", "block");
                    $("#Hide").val("Return");
                    $("#HidePostDeclarationID").val(row.DeclarationID);

                    //$("#Subject").text("[" + row.DeclarationName + "]-[" + row.PrizeName + "]-申报结果");
                    //$("#Recipients").text(row.EmailAddress);
                    //$('#edui2').css({ "height": "24px" });
                    //$('#edui2>div').css({ "display": "none", "height": "0px" });
                    //$('#edui8').css({ "display": "block", "height": "22px", "margin-left": "-82px" });
                    //$('#edui9').css({ "display": "block", "height": "22px" });
                    //$('#edui10').css({ "display": "block", "height": "22px" });
                }
            };

            $.ajax({
                url: '../Mutual/Declaration.ashx',
                type: "post",
                data: {
                    "Action": "GetDeclarationList",
                    "PageSize": PageSize,
                    "CuttentPage": CuttentPage,
                    "DeclarationName": DeclarationName,
                    "DeclarationUnit": DeclarationUnit,
                    "PrizeName": PrizeName,
                    "DeclarationBeginDate": DeclarationBeginDate,
                    "DeclarationEndDate": DeclarationEndDate,
                    "EditBeginDate": EditBeginDate,
                    "EditEndDate": EditEndDate,
                    "DeclarationStatus": DeclarationStatus,
                    "DeclarationAuditing": "DeclarationAuditing"
                },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbar',                //工具按钮用哪个容器
                            striped: true,                      //是否显示行间隔色
                            editable: true,
                            clickToSelect: true,
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            uniqueId: "DeclarationID",            //每一行的唯一标识，一般为主键列
                            columns: [
                                { checkbox: true },
                                //{
                                //    field: 'AssociationOrdinal', title: '协会推荐序号', align: 'center', valign: 'middle', editable: {
                                //        type: 'text',
                                //        title: '协会推荐序号',
                                //        validate: function (v) {
                                //            if (!v) {
                                //                return '协会推荐序号不能为空！';
                                //            } else if (isNaN(v)) {
                                //                return '协会推荐序号只能是数字！';
                                //            }
                                //        }
                                //    }
                                //},
                                { field: 'DeclarationName', title: '项目名称', align: 'center', valign: 'middle' },
                                { field: 'PrizeName', title: '申报奖项', align: 'center', valign: 'middle' },
                                { field: 'DeclarationStatusText', title: '申报状态', align: 'center', valign: 'middle' },
                                { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                { field: 'DeclareDate', title: '开始填报日期', align: 'center', valign: 'middle' },
                                { field: 'operate', title: '操作', align: 'center', events: operateEvents, formatter: operateFormatter },
                            ],
                            onEditableSave: function (field, row, oldValue, $el) {
                                var PerPage = $('#per_page_select').val();

                                $.ajax({
                                    type: "post",
                                    url: '../Mutual/Declaration.ashx',
                                    data: {
                                        "Action": "UpdateAssociationOrdinal",
                                        "DeclarationID": row.DeclarationID,
                                        "newValue": row.AssociationOrdinal
                                    },
                                    success: function (data) {
                                        InitTable(PerPage, 1);
                                    }
                                });
                            }
                        };
                        option.data = Row.Table;
                        $('#tbList').bootstrapTable(option);

                        $("#divPagination").empty();
                        $("#divPagination").append(recordsCount(Row.RecordNumber, Row.CuttentPage, Row.PerPage));
                        $("#divPagination").append(myPaginationLinks(Row.RecordNumber, Row.CuttentPage, Row.PagesCount, "page_link", "active", "disabled"));
                        $("#divPagination").append(selectPerPage());
                        $("#per_page_select").val(Row.PerPage);
                        $('#tbList th[data-field="operate"]').css('width', '70px');
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbList'));
                    }
                }
            });

            $('#btn_ThoroughDelete').prop('disabled', "true");
            $('#btn_check').prop('disabled', "true");
            $('#btn_return').prop('disabled', "true");

            $('#tbList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                var ArrayStatus = getIdSelections2().indexOf("收件封存");
                var ArrayStatus2 = getIdSelections2().indexOf("驳回修改");
                if (ArrayStatus >= 0) {
                    $('#btn_check').prop('disabled', "true");
                }
                else {
                    $('#btn_check').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
                }
                if (ArrayStatus2 >= 0) {
                    $('#btn_return').prop('disabled', "true");
                }
                else {
                    $('#btn_return').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
                }
                $('#btn_ThoroughDelete').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
            });
        }
       
        $(function () {
            if (userType == "") {
                window.location = "../Mutual/UserEntry.aspx";
            }

            if (userType == "0809" || userType == "0808") {
                $("#btn_check").hide();
            }

            $("#ddlPrizeName,#ddlDeclarationStatus").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });

            $('select').multipleSelect('checkAll');

            //日期控件
            $(".datepicker").datepicker({
                language: "zh-CN",
                autoclose: true,
                todayHighlight: true,
                format: "yyyy-mm-dd"
            });

            var PerPage = '<%=ViewState["PerPage"] ?? 10000 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';

            onSearch(PerPage, CuttentPage);
        });
     
        $(".form-control").each(function () {
            $(this).css("margin-left", "25px")
        });

        $(".input-group-addon i").each(function () {
            $(this).css("margin-left", "5px")
            $(this).css("margin-right", "5px")
        });

    </script>

</asp:Content>
