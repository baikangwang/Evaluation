<%@ Page Title="会员用户" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="LeaguerUserList.aspx.cs" Inherits="Evaluation.View.UserManage.LeaguerUserList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" type="text/css" href="../../Content/plugins/bootstrap-fileinput/css/fileinput.css" />
    <script src="../../Content/plugins/bootstrap-fileinput/js/fileinput.js"></script>
    <script src="../../Content/plugins/bootstrap-fileinput/themes/fa/theme.js"></script>
    <script src="../../Content/plugins/bootstrap-fileinput/js/locales/zh.js"></script>
    <style>
    
        .table{
            width:100%;white-space:nowrap;   
        }
        .buttonarea{
            width:355px;
            margin:0 auto
        }
        tr:hover > th {
            background-color: inherit;
        }
        .table>tbody>tr>th.warning{
            background-color: #DBF1EF;
            border-color: #DBF1EF;
        }
        
        .container {
          max-width: none!important;
          padding:0; 
        }
       .row {
        margin: 0;
       
      }
        .col-sm-12,.col-xs-12,.col-sm-8{
            position:relative;
           padding:0;
        }
        .col-sm-12.col-xs-12.lg input{
            position:absolute;right:0;
        }
        .col-sm-2{
            position: relative;
            padding-left:70px;
         }
      .fixed-table-toolbar .bs-bars, .fixed-table-toolbar .search, .fixed-table-toolbar .columns {
         position: relative;
         margin-bottom: 0px;
         margin-top:0px;
       }
      #ContentPlaceHolder1_btnExportLeaguerUser{
       margin-left:6px;
        margin-right:6px;
      }
        .btnt {
           width: 78px;
           border-radius: 6px;
           background: #33B0BA;
           color: #fff;
           border: none;
           height:25px;
           line-height:25px;
           font-size: 13px;
           padding:0
      }
        a:hover{
            color:#fff;text-decoration:none;
        }
        input[type="text"]{
            vertical-align:middle;
            margin-right:35px;
            border:0;
            border:1px solid #AAAAAA;
           
        }    
        input[type="text"]:focus{
         border:1px solid #AAAAAA;
        
        }
        input[type="file"] {
         margin-top: 15px;
 
      } 
        .col-sm-10.yellow{
          margin-top: 12px;
        }      
         .table thead > tr > th {
            border-bottom: 0;
        }

        .bootstrap-table .table > thead > tr > th {
            border-bottom: 0;
        }
        .table tbody>tr>td{
        border-top:0;
        }
        .fixed-table-container thead th {
            border-left: 0;
        }
        .ms-choice{height:25px;}
        #lbkSearch {
            width:78px;
            padding:0;
            display:inline-block;
            text-align:center
        }
        .condition {
            width:100%;
            border:1px solid #e1e1e1;
            border-radius:5px;
            padding:10px;
            margin-bottom:15px;
        }

        #ContentPlaceHolder1_btnExpertExcelAll{
            margin:0px 10px;
        }
        #ContentPlaceHolder1_btnDownload{
            margin-right:10px;
        }
        #ContentPlaceHolder1_Button1{
            color:#333;
        }
        .input-group-btn i{
            float:left;line-height:17px;
        }
          .input-group-btn span{
            float:right;
        }
          .btn.btn-primary.btn-file{
              width:88px;
          }
          /*#btnImportLeaguerUser{
              margin-top:0px!important;
          }*/
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
     <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">用户管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../UserManage/LeaguerUserList.aspx">会员用户</a>
        </li>        
    </ul>
    <div class="container" id="div">
        <input id="checkedUserID" runat="server" type="text" value="" hidden="hidden" />
        <div class="row">
            <div class="col-sm-12 col-xs-12">
                <asp:TextBox ID="txtUserType" ClientIDMode="Static" runat="server"></asp:TextBox>
                <div id="leaguer">
                    <div class="condition">
                         <span>用户名：</span>
                         <asp:TextBox runat="server" ID="tbxUserName" Width="250px" Height="25px" ClientIDMode="Static"></asp:TextBox>                      
                    </div>
                    <div class="buttonarea">
                        <input type="button" value="查&nbsp;&nbsp;&nbsp;&nbsp;询" class="btnt" onclick="onSearch();"/>
                        <asp:Button ID="btnExpertExcelAll" class="btnt" runat="server" OnClick="btnExpertExcelAll_Click" Text="导出全部" />                        
                        <%--<asp:Button ID="btnDownload" runat="server" class="btnt" OnClick="btnDownload_Click" Text="下载模板" />--%>
                      <%--  <button type="button" id="btnImporLeaguerUser" class="btnt" data-toggle="modal" data-target="#importUser">
                            导入用户
                        </button>--%>
                          <button type="button" id="btnImporLeaguerUser" class="btnt" onclick="ImportUsers()">
                            导入用户
                        </button>
                    </div>
                    
                </div>
                <br />
            </div>
            <div class="col-sm-12">
                <div id="toolbar" class="btn-group">
                  <button id="btn_add" type="button" class="btn btn-default" onclick="onAdd();">
                        <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增</button>
                   <button id="btn_delete" type="button" class="btn btn-default" onclick="onDelete();">
                        <span class="fa fa-trash" aria-hidden="true"></span>&nbsp;删除（批量）
                    </button>
                    <asp:Button ID="Button1" class="btn btn-default" runat="server" OnClientClick="return checkedID();" OnClick="btnExpertExcel_Click" Text="导出（批量）" />
                </div>
                <table id="tbUserList"></table>
                <div id="divPagination" style="overflow: hidden;margin-top:10px;padding-bottom:130px; "></div>
            </div>
        </div>
    </div>
            <!--模态框 -->
    <%--<div class="modal fade" id="importUser" tabindex="-1" role="dialog" aria-labelledby="importUserLabel" aria-hidden="true">
        <div class="modal-dialog" style="width:600px;">
            <div class="modal-content" >
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                    <h4 class="modal-title" id="importUserLabel">导入用户</h4>
                </div>
                <div class="modal-body" style="padding: 20px;">
                    <div>
                        <label class="control-label">请选择文件 :</label>
                        <input id="btnImportLeaguerUser" name="btnImportLeaguerUser" type="file" class="file" />
                        <span>支持xls、xlsx格式</span>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" id="modalClose" class="btnt btn-primary">返 回</button>
                </div>
            </div>
        </div>
    </div>--%>
    <script>
        $(function () {
            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
            }
        })
        function ImportUsers() {
            window.location = "LeaguerUserImport.aspx"
        }
        $("#txtUserType").hide();
        <%--$("#btnImportLeaguerUser").fileinput({
            showPreview: false,
            language: "zh",
            theme: "fa",
            uploadUrl: "../Mutual/UserManage.ashx?Action=ImportLeaguerUser",
            uploadAsync: true,
            //uploadExtraData: data,   //可能会用到
            allowedFileExtensions: ["xls", "xlsx"],
        }).on('fileuploaded', function (event, data) {
            ShowMessag(data.response);
            $(".layui-layer-btn0").click(function () {
                var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
                var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
                InitTable(PerPage, CuttentPage);
            });
        });--%>

        //模态框开始
        $('#importUser').modal({
            backdrop: 'static',
            keyboard: false,
            show: false
        });
        $("#modalClose").click(function () {
            $(".close").click();
        })
        //$("#ddlSpecialtyID").multipleSelect();

        function SpecialtyIconFormatter(value, row, index) {
            return ['<i class="fa ' + row.SpecialtyIcon + '"></i>'].join('');
        }
        $(function () {
            var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
            InitTable(PerPage, CuttentPage);
          
        });

        function onSearch(PerPage, CuttentPage) {
            var userName = $("#tbxUserName").val().trim();

            if (PerPage == null || PerPage == "") {
                PerPage = $('#per_page_select').val();
            }

            if (CuttentPage == null || CuttentPage == "") {
                CuttentPage = 1;
            }

            InitTable(PerPage, CuttentPage, userName);
        }

        function operateFormatter(value, row, index) {
            if ($('#tyUserType').val() == '会员用户') {
                return [
                '<a class="edit" href="javascript:void(0)" title="编辑">',
                '<i class="fa fa-edit"></i>',
                '</a>  ',
                ].join('')
            }
            if (row.UserStatusText == "已激活") {//激活状态
                return [
                        '<a class="edit" href="javascript:void(0)" title="编辑">',
                  '<i class="fa fa-edit"></i>',
                  '</a>  ',
                  '<a class="forbidden" href="javascript:void(0)" title="禁用">',
                  '<i class="fa fa-stop" style="font-size:15px;"></i>',
                  '</a>  ',
                  '<a class="remove" href="javascript:void(0)" title="删除">',
                  '<i class="fa fa-trash"></i>',
                  '</a>',
                ].join('');
            } else if (row.UserStatusText == "已禁用") {//禁用状态
                return [
                        '<a class="edit" href="javascript:void(0)" title="编辑">',
                  '<i class="fa fa-edit"></i>',
                  '</a>  ',
                  '<a class="reactivate" href="javascript:void(0)" title="激活">',
                  '<i class="fa fa-play" style="font-size:16px;"></i>',
                  '</a>  ',
                  '<a class="remove" href="javascript:void(0)" title="删除">',
                  '<i class="fa fa-trash"></i>',
                  '</a>',
                       
                ].join('');
            
        }            
        };

        function passwordFormatter(value, row, index) {          
                return [
                    '<a class="reset" href="javascript:void(0)" title="重置密码">',
                    '<button type="button" class="btnt">重置密码</button>',
                    '</a>  ',
                ].join('');         
        }
        function InitTable(PageSize, CuttentPage,UserName) {
            $('#tbUserList').bootstrapTable('destroy');
            window.operateEvents = {
                'click .forbidden': function (e, value, row, index) {
                    $.ajax({
                        url: "../Mutual/UserManage.ashx",
                        type: "post",
                        data: { "Action": "ForbiddenUser", "UserID": row.UserID },
                        success: function (data) {
                            ShowMessag(data);
                            $(".layui-layer-btn0").click(function () {
                                var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
                                var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
                                InitTable(PerPage, CuttentPage);
                            });
                        }
                    })
                },
                'click .reactivate': function (e, value, row, index) {
                    $.ajax({
                        url: "../Mutual/UserManage.ashx",
                        type: "post",
                        data: { "Action": "EnableUser", "UserID": row.UserID },
                        success: function (data) {
                            ShowMessag(data);
                            $(".layui-layer-btn0").click(function () {
                                var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
                                var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
                                InitTable(PerPage, CuttentPage);
                            });
                        }
                    })
                },
                'click .reset': function (e, value, row, index) {
                    $.ajax({
                        url: "../Mutual/UserManage.ashx",
                        type: "post",
                        data: { "Action": "ResetPassword", "UserID": row.UserID },
                        success: function (data) {
                            ShowMessag(data);
                        }
                    })
                },
                'click .edit': function (e, value, row, index) {
                    switch (row.UserType) {
                        case "0806":
                            window.location = "../UserManage/LeaguerUser.aspx?xid=" + row.UserID + "";
                            break;
                        case "0807":
                            window.location = "../UserManage/LeaguerChildUser.aspx?xid=" + row.UserID + "";
                            break;
                    }
                },
                'click .remove': function (e, value, row, index) {
                     ShowMessags('确定要删除吗?')
                    $(".layui-layer-btn0").click(function () {
                        $.ajax({
                            url: "../Mutual/UserManage.ashx",
                            type: "post",
                            data: { "Action": "DelUser", "UserID": row.UserID },
                            success: function (data) {
                                if (data == "删除成功！") {
                                    ShowMessag(data);
                                    $("body").attr("class", "breakpoint-1200");
                                    $(".modal-backdrop").remove();
                                    $('#tbUserList').bootstrapTable('remove', {
                                        field: 'UserID',
                                        values: [row.UserID]
                                    });
                                }
                                else {
                                    ShowMessag(data);
                                }
                            }
                        });
                    });
                }
            };
            if ($('#tyUserType').val() != '会员用户') { 
            $.ajax({
                url: "../Mutual/UserManage.ashx",
                type: "post",
                data: { "Action": "GetLeaguerUserList", "UserName": UserName, "PageSize": PageSize, "CuttentPage": CuttentPage, "UserType": $("#txtUserType").val() },             
                success: function (data) {
                    if (data != "") {
                        var JSONdata = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbar',                //工具按钮用哪个容器
                            striped: true,                      //是否显示行间隔色
                            editable: false,
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            clickToSelect: true,
                            uniqueId: "UserID",            //每一行的唯一标识，一般为主键列
                            queryParams: "",//传递参数（*）
                            columns: [{ checkbox: true },
                                { field: 'UserName', title: '用户名', align: 'center', valign: 'middle' },
                                { field: 'UserTypeName', title: '用户类型', align: 'center', valign: 'middle' },
                                { field: 'UserStatusText', title: '用户状态', align: 'center', valign: 'middle' },
                                { field: 'EmailAddress', title: '单位邮箱', align: 'center', valign: 'middle' },
                                { field: 'OrganizationName', title: '单位名称', align: 'center', valign: 'middle' },
                                { field: 'OrganizationAddress', title: '地址', align: 'center', valign: 'middle' },
                                { field: 'LegalPersonName', title: '法人姓名', align: 'center', valign: 'middle' },
                                { field: 'LegalPersonIDNo', title: '身份证号', align: 'center', valign: 'middle' },
                                { field: 'Linkman', title: '联系人', align: 'center', valign: 'middle' },
                                { field: 'TelephoneNumber', title: '电话', align: 'center', valign: 'middle' },
                                { field: 'operate', title: '操作', align: 'center', events: operateEvents, formatter: operateFormatter },                             
                                { field: 'resetPassword', title: '重置密码', align: 'center', events: operateEvents, formatter: passwordFormatter, }
                            ]
                        };
                        option.data = JSONdata.Table;
                        if ($('#tyUserType').val() == '会员用户') {
                           
                        }
                        $('#tbUserList').bootstrapTable(option)
                        $("#divPagination").empty();
                        $("#divPagination").append(recordsCount(JSONdata.RecordNumber, JSONdata.CuttentPage, JSONdata.PerPage));
                        $("#divPagination").append(myPaginationLinks(JSONdata.RecordNumber, JSONdata.CuttentPage, JSONdata.PagesCount, "page_link", "active", "disabled"));
                        $("#divPagination").append(selectPerPage());
                        $("#per_page_select").val(JSONdata.PerPage);
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbUserList'));
                    }
                }
            });
            } else {
                $.ajax({
                    url: "../Mutual/UserManage.ashx",
                    type: "post",
                    data: { "Action": "GetLeaguerUserList", "UserName": UserName, "PageSize": PageSize, "CuttentPage": CuttentPage, "UserType": $("#txtUserType").val() },
                    success: function (data) {
                        if (data != "") {
                            var JSONdata = JSON.parse(data)
                            var option = {
                                toolbar: '#toolbar',                //工具按钮用哪个容器
                                striped: true,                      //是否显示行间隔色
                                editable: false,
                                showColumns: true,                  //是否显示所有的列
                                showRefresh: false,                  //是否显示刷新按钮
                                minimumCountColumns: 1,             //最少允许的列数
                                sidePagination: "client",
                                clickToSelect: true,
                                uniqueId: "UserID",            //每一行的唯一标识，一般为主键列
                                queryParams: "",//传递参数（*）
                                columns: [{ checkbox: true },
                                    { field: 'UserName', title: '用户名', align: 'center', valign: 'middle' },
                                    { field: 'UserTypeName', title: '用户类型', align: 'center', valign: 'middle' },
                                    { field: 'UserStatusText', title: '用户状态', align: 'center', valign: 'middle' },
                                    { field: 'EmailAddress', title: '单位邮箱', align: 'center', valign: 'middle' },
                                    { field: 'OrganizationName', title: '单位名称', align: 'center', valign: 'middle' },
                                    { field: 'OrganizationAddress', title: '地址', align: 'center', valign: 'middle' },
                                    { field: 'LegalPersonName', title: '法人姓名', align: 'center', valign: 'middle' },
                                    { field: 'LegalPersonIDNo', title: '身份证号', align: 'center', valign: 'middle' },
                                    { field: 'Linkman', title: '联系人', align: 'center', valign: 'middle' },
                                    { field: 'TelephoneNumber', title: '电话', align: 'center', valign: 'middle' },
                                    { field: 'operate', title: '操作', align: 'center', events: operateEvents, formatter: operateFormatter },                                  
                                ]
                            };
                            option.data = JSONdata.Table;
                            if ($('#tyUserType').val() == '会员用户') {

                            }
                            $('#tbUserList').bootstrapTable(option)
                            $("#divPagination").empty();
                            $("#divPagination").append(recordsCount(JSONdata.RecordNumber, JSONdata.CuttentPage, JSONdata.PerPage));
                            $("#divPagination").append(myPaginationLinks(JSONdata.RecordNumber, JSONdata.CuttentPage, JSONdata.PagesCount, "page_link", "active", "disabled"));
                            $("#divPagination").append(selectPerPage());
                            $("#per_page_select").val(JSONdata.PerPage);
                        } else {
                            $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbUserList'));
                        }
                    }
                });
            }
            $("#btn_delete").prop('disabled', 'true');
            $("#ContentPlaceHolder1_Button1").prop('disabled', 'true');
            $("#tbUserList").on("check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table", function () {
                $("#btn_delete,#ContentPlaceHolder1_Button1").prop('disabled', !$("#tbUserList").bootstrapTable('getSelections').length);
            })
        }
        function getIdSelections() {
            return $.map($('#tbUserList').bootstrapTable('getSelections'), function (row) {
                return row.UserID;
            });
        }
        function onAdd() {
            window.location = "../UserManage/LeaguerUser.aspx";
        }
        function onDelete() {
            var UserID = getIdSelections();
            UserID = UserID.join(",");
            ShowMessags("确认要删除吗？");
            $('.layui-layer-btn0').on('click', function () {
                $.ajax({
                    url: "../Mutual/UserManage.ashx",
                    type: "post",
                    data: { "Action": "MultiselectDelUserList", "UserID": UserID },
                    success: function (data) {
                        if (data == "删除成功！") {
                            var PerPage = $("#per_page_select").val();
                            var CuttentPage = $("#pagination_links li a.active")[0].text;
                            InitTable(PerPage, CuttentPage);
                            ShowMessag(data);
                        }
                        else {
                            ShowMessag(data);
                        }
                    }
                })
            })
        }
        function checkedID() {
            var ids = getIdSelections();
            var temp = "";
            for (var i = 0; i < ids.length; i++) {
                temp += ids[i].toString() + ",";
            }
            $("#<%=checkedUserID.ClientID%>").val(temp);
            if (temp.length > 0) {
                return true;
            }
            else {
                ShowMessag("请选择要导出的单位！");
                return false;
            }
        }
    </script>
</asp:Content>

