<%@ Page Title="管理用户" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="Evaluation.View.UserManage.UserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>    
        .table{
            width:100%;
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
         margin-top:22px;
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
           padding:0;
           font-size: 13px;
           height:25px;
           line-height:25px;
      }
        a:hover{
            color:#fff;text-decoration:none;
        }
        input[type="text"]{
            vertical-align:middle;         
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
        #txtUserType{
            display:none;
        } 
         .ms-choice{height:25px;}
        #lbkSearch {
            width:78px;
            padding:0;
            height:25px;
            display:inline-block;
            text-align:center;
            line-height:25px;
        }      
        .condition {
            width:100%;
            border:1px solid #e1e1e1;
            border-radius:5px;
            padding:10px;
            margin-bottom:15px;
        }
        .buttonarea {
            width:200px;margin:0 auto;
        }

        .buttonarea button,.buttonarea input{
            height:25px;
            padding:0
        }      
         #ContentPlaceHolder1_btnExportAll{
            margin:0 10px;
        }
         #ContentPlaceHolder1_butExportUserExcel{
             color:#333;
         }
         .forbid{
             background:rgba(0, 0, 0, 0.2)!important;
         }
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
          <a href="../UserManage/UserList.aspx">管理用户</a>
        </li>        
    </ul>
    <div class="container div ">
        <div class="row">
            <div class="col-sm-12 col-xs-12">
                <asp:TextBox ID="txtUserType" ClientIDMode="Static" runat="server"></asp:TextBox>
                <div>
                    <div class="condition">
                        <span>用户名：</span>
                        <asp:TextBox runat="server" ID="tbxUserName" Width="250px" Height="25px" ClientIDMode="Static"></asp:TextBox>
                    </div>
                    <div class="buttonarea">
                       <input type="button" value="查&nbsp;&nbsp;&nbsp;&nbsp;询" class="btnt"  onclick="onSearch();"/>
                        <input id="checkedUserID" runat="server" type="text" value="" hidden="hidden" />
                        <asp:Button ID="btnExportAll" class="btnt btn-primary" runat="server" Text="导出全部" OnClick="btnExportAll_Click" />  
                    </div>                  
                </div>
            </div>
            <div class="col-sm-12 btn_add" id="association">
                <div id="toolbar" class="btn-group">
                    <button id="btn_addSysManager" type="button" class="btn btn-default" onclick="onAddSysManager();">
                        <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增系统管理员
                    </button>
                    <button id="btn_addAssociationManager" type="button" class="btn btn-default" onclick="onAddAssociationManager();">
                        <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增协会管理员
                    </button>
                    <button id="btn_addBranchManager" type="button" class="btn btn-default" onclick="onAddBranchManager();">
                        <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增分会管理员
                    </button>
                    <button id="btn_addLocalUsers" type="button" class="btn btn-default" onclick="onAddLocalUser();" >
                        <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增地方协会用户
                    </button>
                    <button id="btn_addCompetitorUser" type="button" class="btn btn-default" onclick="onAddCompetitorUser();" >
                        <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增同业协会用户
                    </button>
                    <button id="btn_delete" type="button" class="btn btn-default" onclick="onDelete();">
                        <span class="fa fa-trash" aria-hidden="true"></span>&nbsp;删除（批量）
                    </button>
                       <asp:Button ID="butExportUserExcel"  runat="server" class="btn" Text="导出（批量）" OnClientClick="return checkedID();" OnClick="btnExportUserExcel_Click" />
                </div>
                <table id="tbUserList"></table>
                <div id="divPagination" style="overflow: hidden;margin-top:10px; "></div>
            </div>
        </div>
    </div>
    <script>
        function formatTableUnit(value, row, index) {
            return {
                css: {
                    "width": "289px"
                }
            }
        };
        function SpecialtyIconFormatter(value, row, index) {
            return ['<i class="fa ' + row.SpecialtyIcon + '"></i>'].join('');
        }

        function operateFormatter(value, row, index) {
            if (row.UserStatus == "0701") {//激活状态
                return [
                        '<a class="edit" href="javascript:void(0)" title="编辑">',
                        '<i class="fa fa-edit"></i>',
                        '</a>  ',
                        '<a class="forbidden" href="javascript:void(0)" title="禁用">',
                        '<i class="fa fa-stop" style="font-size:15px;"></i>',
                        '</a>  ',
                        '<a class="remove" href="javascript:void(0)" title="删除">',
                        '<i class="fa fa-trash"></i>',
                        '</a>'
                ].join('');
            }
            else if (row.UserStatus == "0702") {//禁用状态
                return [
                         '<a class="edit" href="javascript:void(0)" title="编辑">',
                        '<i class="fa fa-edit"></i>',
                        '</a>  ',
                         '<a class="reactivate" href="javascript:void(0)" title="激活">',
                        '<i class="fa fa-play" style="font-size:16px;"></i>',
                        '</a>  ',
                        '<a class="remove" href="javascript:void(0)" title="删除">',
                        '<i class="fa fa-trash"></i>',
                        '</a>'
                ].join('');
            }
        }

        function passwordFormatter(value, row, index) {
            return [
                '<a class="reset" href="javascript:void(0)" title="重置密码">',
                '<button type="button" class="btnt">重置密码</button>',
                '</a>  '
            ].join('');
        }

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

        function Jurisdiction() {
            if ($('#tbUserList tbody tr').length > 0 && $('#tbUserList tbody tr td').text() != "没有找到匹配的记录") {
                for (var i = 0; i < $('#tbUserList tbody tr').length; i++) {
                    var type = getIdUserTypes()[i].UserType;
                    var types = $('#tyUserType').val()
                    if (types == "超级管理员") {
                        if (type == "0801") {
                            $('#tbUserList').find("tr").eq(i + 1).find("a.forbidden,a.reactivate,a.remove").css('color', 'rgba(0,0,0,0.2)').attr('title', '').off("click");
                        };
                    }
                    if (types == "系统管理员") {
                        if (type == "0802") {
                            $('#tbUserList').find("tr").eq(i + 1).find("a.forbidden,a.reactivate,a.remove").css('color', 'rgba(0,0,0,0.2)').attr('title', '').off("click");
                            $('#tbUserList').find("tr").eq(i + 1).find("a.reset").attr('title', '').off("click");
                            $('#tbUserList').find("tr").eq(i + 1).find("a.reset .btnt").addClass('forbid');
                        };
                    }
                    if (types == "协会管理员") {
                        if (type == "0803") {
                            $('#tbUserList').find("tr").eq(i + 1).find("a.forbidden,a.reactivate,a.remove").css('color', 'rgba(0,0,0,0.2)').attr('title', '').off("click");
                            $('#tbUserList').find("tr").eq(i + 1).find("a.reset").attr('title', '').off("click");
                            $('#tbUserList').find("tr").eq(i + 1).find("a.reset .btnt").addClass('forbid');
                        };
                    }
                    if (types == "分会用户") {
                        if (type == "0804") {
                            $('#tbUserList').find("tr").eq(i + 1).find("a.forbidden,a.reactivate,a.remove").css('color', 'rgba(0,0,0,0.2)').attr('title', '').off("click");
                            $('#tbUserList').find("tr").eq(i + 1).find("a.reset").attr('title', '').off("click");
                            $('#tbUserList').find("tr").eq(i + 1).find("a.reset .btnt").addClass('forbid');
                        };
                    }
                }
            }
        }
        function InitTable(PageSize, CuttentPage, UserName) {
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
                                var PerPage = $('#per_page_select').val();
                                var CuttentPage = 1;
                                InitTable(PerPage, CuttentPage);
                            });
                        }
                    });
                },
                'click .reactivate': function (e, value, row, index) {
                    $.ajax({
                        url: "../Mutual/UserManage.ashx",
                        type: "post",
                        data: { "Action": "EnableUser", "UserID": row.UserID },
                        success: function (data) {
                            ShowMessag(data);
                            $(".layui-layer-btn0").click(function () {
                                var PerPage = $('#per_page_select').val();
                                var CuttentPage = 1;
                                InitTable(PerPage, CuttentPage);
                            });
                        }
                    });
                },
                'click .reset': function (e, value, row, index) {
                    $.ajax({
                        url: "../Mutual/UserManage.ashx",
                        type: "post",
                        data: { "Action": "ResetPassword", "UserID": row.UserID },
                        success: function (data) {
                            ShowMessag(data);
                        }
                    });
                },
                'click .edit': function (e, value, row, index) {
                    onRowEdit(row);
                },
                'click .remove': function (e, value, row, index) {
                    ShowMessags("确定要删除吗?")
                    $(".layui-layer-btn0").click(function () {
                        $.ajax({
                            url: "../Mutual/UserManage.ashx",
                            type: "post",
                            data: { "Action": "DelUser", "UserID": row.UserID },
                            success: function (data) {
                                if (data = "删除成功！") {
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
            $.ajax({
                url: "../Mutual/UserManage.ashx",
                type: "post",
                data: {
                    "Action": "GetManagerList",
                    "PageSize": PageSize,
                    "CuttentPage": CuttentPage,
                    "UserType": $("#txtUserType").val(),
                    "UserName": UserName
                },
                success: function (data) {
                    if (data != "" || JSON.parse(data).Table != null) {
                        var JSONdata = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbar',                //工具按钮用哪个容器
                            striped: true,
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
                                { field: 'UserTypeText', title: '用户类型', align: 'center', valign: 'middle' },
                                { field: 'UserStatusText', title: '用户状态', align: 'center', valign: 'middle' },
                                { field: 'Email', title: '邮箱', align: 'center', valign: 'middle' },
                                { field: 'SpecialtyNames', title: '专业', align: 'center', valign: 'middle', cellStyle: formatTableUnit },
                                { field: 'operate', title: '操作', align: 'center',width:'70px', events: operateEvents, formatter: operateFormatter },
                                { field: 'resetPassword', title: '重置密码', align: 'center', events: operateEvents, formatter: passwordFormatter }
                            ]
                        };
                        option.data = JSONdata.Table;
                        $('#tbUserList').bootstrapTable(option)
                        Jurisdiction();
                        $("#divPagination").empty();
                        $("#divPagination").append(recordsCount(JSONdata.RecordNumber, JSONdata.CuttentPage, JSONdata.PerPage));
                        $("#divPagination").append(myPaginationLinks(JSONdata.RecordNumber, JSONdata.CuttentPage, JSONdata.PagesCount, "page_link", "active", "disabled"));
                        $("#divPagination").append(selectPerPage());
                        $("#per_page_select").val(JSONdata.PerPage);
                        $('#tbUserList th[data-field="SpecialtyNames"] .th-inner').css({'width': '285px','margin': '0 auto'});
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbUserList'));
                    }
                }
            });

            $("#btn_delete").prop('disabled', 'true');
            $('#ContentPlaceHolder1_butExportUserExcel').prop('disabled', 'true');
            $("#tbUserList").on("check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table", function () {
                $("#ContentPlaceHolder1_butExportUserExcel").prop('disabled', !$("#tbUserList").bootstrapTable('getSelections').length);
                $("#btn_delete").prop('disabled', function () {
                    if (!$("#tbUserList").bootstrapTable('getSelections').length) {
                        return true;
                    }
                    else {
                        var row = $("#tbUserList").bootstrapTable('getSelections');
                        var currentLoginUser = $('#spUserName').html();
                        for (var i = 0; i < row.length; i++) {
                            if (row[i].UserTypeText == currentLoginUser) {
                                return true;
                            }
                        }
                        return false;
                    }
                });
            });
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
                ShowMessag("请选择要导出的用户！");
                return false;
            }
        }

        function getIdSelections() {
            return $.map($('#tbUserList').bootstrapTable('getSelections'), function (row) {
                return row.UserID;
            });
        }

        function getIdUserTypes() {
            return $.map($('#tbUserList').bootstrapTable('getData'), function (data) {
                return data;
            });
        };

        //function onAdd() {
        //    var types = $('#tyUserType').val();
        //    if (types == "协会管理员") {
        //        window.location = "../UserManage/CreateUserM.aspx";
        //    } else {
        //        window.location = "../UserManage/CreateUser.aspx";
        //    }
        //}

        function onAddSysManager() {
            window.location = "../UserManage/CreateUser.aspx?UserType=0802";          
        }

        function onAddAssociationManager() {
            window.location = "../UserManage/CreateUser.aspx?UserType=0803";           
        }

        function onAddBranchManager() {
            window.location = "../UserManage/CreateUserM.aspx?UserType=0804";           
        }

        function onAddLocalUser() {
            window.location = "../UserManage/LocalUser.aspx?UserType=0808";            
        }

        function   onAddCompetitorUser() {
            window.location = "../UserManage/LocalUser.aspx?UserType=0809";           
        }

        function onRowEdit(row) {
            switch (row.UserType) {
                case "0801":
                case "0802":
                case "0803":
                    window.location = "../UserManage/ManagerUser.aspx?id=" + row.UserID;
                    break;
                case "0804":
                    window.location = "../UserManage/CreateUserM.aspx?id=" + row.UserID + "&operateType=update";
                    break;
                case "0805":
                    window.location = "../UserManage/ExpertUser.aspx?id=" + row.ExpertID;
                    break;
                case "0806":
                    window.location = "../UserManage/LeaguerUser.aspx?id=" + row.UserID;
                    break;
                case "0807":
                    window.location = "../UserManage/LeaguerChildUser.aspx?id=" + row.UserID;
                    break;
                case "0808":
                    window.location = "../UserManage/LocalUser.aspx?id=" + row.UserID;
                    break;
            }
        }

        function onEdit() {
            var arr = $('#tbUserList').bootstrapTable('getSelections');
            onRowEdit(arr[0]);
        }

        function onDelete() {
            var UserID = getIdSelections();
            UserID = UserID.join(",");
            ShowMessags("确认删除吗？");
            $('.layui-layer-btn0').on('click', function () {
                $.ajax({
                    url: "../Mutual/UserManage.ashx",
                    type: "post",
                    data: { "Action": "MultiselectDelUserList", "UserID": UserID },
                    success: function (data) {
                        var PerPage = $("#per_page_select").val();
                        var CuttentPage = $("#pagination_links li a.active")[0].text;
                        InitTable(PerPage, CuttentPage);
                    }
                });
            });
        }

        $(function () {
            var strActivityType = '<%=Session["ActivityType"].ToString() %>';
            if (strActivityType == "0101") {
                $('#btn_addCompetitorUser').hide();
                $('#btn_addLocalUsers').hide();
            };
            var strUserType = '<%=((Dal.Models.UserInfo)Session["UserInfo"]).UserType.ToString() %>';

            switch (strUserType) {
                case "0801":
                    break;
                case "0802":
                    $('#btn_addSysManager').hide();                
                    break;
                case "0803":
                    $('#btn_addSysManager').hide();
                    $('#btn_addAssociationManager').hide();
                    break;
                default:
                    $('#btn_addSysManager').hide();
                    $('#btn_addAssociationManager').hide();
                    $('#btn_addBranchManager').hide();
                    $('#btn_addCompetitorUser').hide();
                    $('#btn_addLocalUsers').hide();
            }

            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
            };
            var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
            InitTable(PerPage, CuttentPage);
        });
 
</script>
</asp:Content>
