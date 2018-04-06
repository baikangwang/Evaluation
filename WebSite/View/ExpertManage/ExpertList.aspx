<%@ Page Title="专家管理" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="ExpertList.aspx.cs" Inherits="Evaluation.View.ExpertManage.ExpertList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #ContentPlaceHolder1_ddlSpecialty {
            height: 28px;
            margin-right: 6px;
            font-family: "微软雅黑";
        }

        .select input[type="text"] {
            padding: 5px 6px !important;
            vertical-align: bottom;
            width: 210px;
            margin-right: 10px;
            border: none;
            border: 1px solid #ccc;
            font-size: 13px;
        }
        .input-group a {
            margin-left: 10px;
        }
         .input-group input {
            margin-left: 10px;line-height:23px;
        }

        #ContentPlaceHolder1_LinkButton1 {
            margin-left: 20px;
        }

        .fixed-table-toolbar .bs-bars, .fixed-table-toolbar .search, .fixed-table-toolbar .columns {
            position: relative;
            margin-top: 10px;
            margin-bottom: 0;
            line-height: 34px;
        }

        a:hover {
            color: #fff;
            text-decoration: none;
            background-color: #62C1C9;
        }

        .table thead > tr > th {
            border-bottom: 0;
        }

        .bootstrap-table .table > thead > tr > th {
            border-bottom: 0;
        }

        .fixed-table-container thead th {
            border-left: 0;
        }

        .table tbody > tr > td {
            border-top: 0;
        }

        #ContentPlaceHolder1_btnCheckedExpert{
            color:#333;
        }

        tbody > tr > td:nth-child(2) > .popover.top .arrow {
            margin-left: 2px;
        }

        .select {
            width: 100%;
            border: 1px solid #e1e1e1;
            border-radius: 5px;
            padding:15px;
            margin-bottom: 15px;
            position:relative;
        }

        a.btnt, #lbkSearch {
            width: 78px;
            padding: 0;
            height: 25px;
            line-height: 25px;
            display: inline-block;
            text-align: center;
        }

        .ms-choice, .ms-choice span {
            height: 25px;
            line-height: 25px;
        }

        #fuExpert {
            margin-top: 10px;
        }

        .input-group {
            width: 300px;
            margin: 0 auto;
            margin-top: 25px;
            margin-bottom: 8px;
        }

        #lbkSearch {
            margin-left: 10px;
        }

        .select input {
            height: 25px;
        }

        .file-caption-main {
            width: 430px !important;
            position: relative;
            top: -51px;
            left: 196px;
        }
          .control-label{
            font-weight:400;
        }
       .input-group-btn .btn{
            padding:2px 13px!important;
        }
        .form-control{
           border-top-left-radius:4px;
           border-bottom-left-radius:4px;
           padding:0;
           height:25px!important;
        }
            .file-caption-name {
            height: 16px!important;
        }
        .btn.btn-primary.btn-file{
          border-top-right-radius:4px;
          border-bottom-right-radius:4px;
        }
        .hidden-xs {
            display: inline !important;
        }
        .progress{
            display:none;
        }
       #ExpertList{
           padding-bottom:100px;
       }
       #btnCheckedExpert{
           color:#333;
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
          <a href="../ExpertManage/ExpertList.aspx">专家管理</a>
        </li>        
    </ul>
    <div class="ExpertList" id="ExpertList">
        <div class="select" id="ExpertSelect">
            <span style="line-height:25px;">
                姓名/身份证号/工作单位 ：                       
            </span>  
            <asp:TextBox id="txtQueryString" runat="server" ClientIDMode="Static" Height="25px"></asp:TextBox>
            <span style="line-height:25px;">用户状态 ：</span>
            <asp:DropDownList runat="server" ID="ddlStatus" ClientIDMode="Static" Style="width: 168px;">
            </asp:DropDownList>
            <%--<select id="ddlStatus" style=" height:25px;" runat="server">              
                <option value="0701">已激活</option>
                <option value="0702">已禁用</option>
            </select>--%>
            <asp:HiddenField ID="hfStatus" runat="server" ClientIDMode="Static" />
        </div>
        <div class="input-group" id="ExpertGroup">         
            <input type="button" value="查 &nbsp;&nbsp; 询" class="btnt" onclick="onSearch();" style="width:78px;" />
            <input id="checkedExpertID" runat="server" type="text" value="" hidden="hidden" />
            <asp:LinkButton runat="server" ID="lkbExport" class="btnt" ToolTip="导出专家（获取导入专家的模版）" OnClick="lkbExport_Click">
                    导 &nbsp;&nbsp; 出
            </asp:LinkButton>
            <asp:Button ID="btnImport" runat="server" class="btnt" Text="导入专家" OnClick="btnImport_Click"/>
        </div>
        
        <div id="ExpertDiv">
            <div id="toolbar" class="btn-group">
                <button id="btn_add" type="button" class="btn btn-default" onclick="onAdd();">
                    <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增</button>
                <button id="btn_delete" type="button" class="btn btn-default" onclick="onDelect();">
                    <span class="fa fa-trash" aria-hidden="true"></span>&nbsp;删除（批量）
                </button>
               <asp:Button ID="btnCheckedExpert"  runat="server" class="btn" Text="导出（批量）" ClientIDMode="Static" OnClientClick="return checkedID();" OnClick="btnCheckedExpert_Click"/>
            </div>
            <table id="tbExpertList" data-reorderable-columns="true"></table>
            <div id="divPagination" style="overflow: hidden; margin-top: 10px;"></div>
        </div>
    </div>
    <script type="text/javascript">    
        function checkedID() {
            var ids = getIdSelections();
            var temp = "";
            for (var i = 0; i < ids.length; i++) {
                temp += ids[i].toString() + ",";
            }
            $("#<%=checkedExpertID.ClientID%>").val(temp);
            if (temp.length > 0) {
                return true;
            }
            else {
                ShowMessag("请选择要导出的专家！");
                return false;
            }
        }

        function onExpertEdit(sender) {
            var tr = sender.closest("tr");
            tr.find(".ShowItem").hide();
            tr.find(".EditItem").show();
        }

        function onCancelEdit(sender) {
            var tr = sender.closest("tr");
            tr.find(".ShowItem").show();
            tr.find(".EditItem").hide();

            tr.find("[data_value]").each(function () {
                if (!$(this).hasClass("SaveEdit")) {
                    $(this).val($(this).attr("data_value"));
                }
            });
        }

        $(function () {
            $("#ddlStatus").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });
            $('select').multipleSelect('checkAll');
            $("#hfStatus").val($("select").first().multipleSelect("getSelects"));

            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
            }

            var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
            InitTable(PerPage, CuttentPage);
        });

        function formatTableUnit(value, row, index) {
            return {
                css: {
                    "white-space": "nowrap"
                }
            }
        };
      
        function operateFormatter(value, row, index) {
            if ($('#tyUserType').val() == '专家用户') {
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
            }
            else if (row.UserStatusText == "已禁用") {//禁用状态
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
        }

        function passwordFormatter(value, row, index) {
            return [
                '<a class="reset" href="javascript:void(0)" title="重置密码">',
                '<button type="button" class="btnt">重置密码</button>',
                '</a>  ',
            ].join('');
        }

        function InitTable(PageSize, CuttentPage, strQuery, strQueryStatus) {
            $("#tbExpertList").bootstrapTable('destroy');
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
                        data: { "Action": "ResetExpertPassword", "ExpertID": row.ExpertID },
                        success: function (data) {
                            ShowMessag(data);
                        }
                    })
                },
                'click .edit': function (e, value, row, index) {
                    window.location = "../UserManage/ExpertUser.aspx?epid=" + row.ExpertID + ""

                    $('tr').find("[data-name]").each(function () {
                        if ($(this).attr("data-name") == "IDType") {
                            $(this).closest("td").append("<select></select>");
                        } else {
                            $(this).closest("td").append("<input type='text'/>");
                        }
                    });

                },
                'click .remove': function (e, value, row, index) {
                      ShowMessags("确认要删除吗?");
                      $(".layui-layer-btn0").click(function () {
                        $.ajax({
                            url: "../Mutual/ExpertManage.ashx",
                            type: "post",
                            data: { "Action": "DelExpert", "ExpertID": row.ExpertID },
                            success: function (data) {
                                $("body").attr("class", "breakpoint-1200");
                                $(".modal-backdrop").remove();                             
                                if (data == "success") {
                                    $('#tbExpertList').bootstrapTable('remove', {
                                        field: 'ExpertID',
                                        values: [row.ExpertID]
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
                url: '../Mutual/ExpertManage.ashx',
                type: "post",
                data: {
                    "Action": "GetExpertList",
                    "strQuery": strQuery,
                    "QueryStatus": strQueryStatus,
                    "PageSize": PageSize,
                    "CuttentPage": CuttentPage
                },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data);
                        if ($('#tyUserType').val() == '专家用户') {
                            var option = {
                                toolbar: '#toolbar',                //工具按钮用哪个容器
                                striped: true,                      //是否显示行间隔色
                                editable: false,
                                clickToSelect: true,
                                showColumns: true,                  //是否显示所有的列
                                showRefresh: false,                  //是否显示刷新按钮
                                minimumCountColumns: 1,             //最少允许的列数
                                sidePagination: "client",
                                uniqueId: "ExpertID",            //每一行的唯一标识，一般为主键列
                                columns: [
                                    { checkbox: true },
                                    { field: 'ExpertName', title: '专家姓名' },
                                    //{ field: 'Gender', title: '性别' },
                                    //{
                                    //    field: 'IDTypeText', title: '证件类别', editable: {
                                    //        type: 'select',
                                    //        title: '证件类别'
                                    //    }
                                    //},
                                    //{
                                    //    field: 'IDNumber', title: '证件号码', editable: {
                                    //        type: 'text',
                                    //        title: '证件号码',
                                    //        validate: function (v) {
                                    //            if (!v) return '不能为空';
                                    //        }
                                    //    }
                                    //},
                                    {
                                        field: 'Email', title: '电子邮箱', editable: {
                                            type: 'text',
                                            title: '电子邮箱'
                                        }
                                    },
                                    { field: 'UserStatusText', title: '状态', cellStyle: formatTableUnit },
                                    {
                                        field: 'AcademicTitle', title: '职称', editable: {
                                            type: 'text',
                                            title: '职称'
                                        }
                                    },
                                    {
                                        field: 'Profession', title: '研究方向', editable: {
                                            type: 'text',
                                            title: '研究方向'
                                        }
                                    },
                                    { field: 'SpecialtyNames', title: '评优专业' },
                                    {
                                        field: 'Workplace', title: '工作单位', editable: {
                                            type: 'text',
                                            title: '工作单位'
                                        }
                                    },
                                    {
                                        title: '操作',
                                        align: 'center',
                                        events: operateEvents,
                                        formatter: operateFormatter,
                                        cellStyle: formatTableUnit

                                    },                                  
                                ],
                                onEditableSave: function (field, row, oldValue, $el) {
                                    $.ajax({
                                        type: "post",
                                        url: "../Mutual/ExpertManage.ashx",
                                        data: {
                                            "Action": "EditExpert",
                                            "ExpertName": row.ExpertName,
                                            "ExpertID": row.ExpertID,
                                            "Workplace": row.Workplace,
                                            "IDType": row.IDType
                                        },
                                        success: function (data, status) {
                                            if (data == "success") {
                                                ShowMessag('修改成功!');
                                            }
                                        },
                                        error: function (data) {
                                            ShowMessag(data);
                                        },
                                    });
                                }
                            };
                        } else {                    
                        var option = {
                            toolbar: '#toolbar',                //工具按钮用哪个容器
                            striped: true,                      //是否显示行间隔色
                            editable: false,
                            clickToSelect: true,
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            uniqueId: "ExpertID",            //每一行的唯一标识，一般为主键列

                            columns: [
                                { checkbox: true },
                                { field: 'ExpertName', title: '专家姓名' },
                                { field: 'Gender', title: '性别' },
                                {
                                    field: 'IDTypeText', title: '证件类别', editable: {
                                        type: 'select',
                                        title: '证件类别'
                                    }
                                },
                                {
                                    field: 'IDNumber', title: '证件号码', editable: {
                                        type: 'text',
                                        title: '证件号码',
                                        validate: function (v) {
                                            if (!v) return '不能为空';
                                        }
                                    }
                                },
                                {
                                    field: 'Email', title: '电子邮箱', editable: {
                                        type: 'text',
                                        title: '电子邮箱'
                                    }
                                },
                                { field: 'UserStatusText', title: '状态', cellStyle: formatTableUnit },
                                {
                                    field: 'AcademicTitle', title: '职称', editable: {
                                        type: 'text',
                                        title: '职称'
                                    }
                                },
                                {
                                    field: 'Profession', title: '研究方向', editable: {
                                        type: 'text',
                                        title: '研究方向'
                                    }
                                },
                                { field: 'SpecialtyNames', title: '评优专业' },
                                {
                                    field: 'Workplace', title: '工作单位', editable: {
                                        type: 'text',
                                        title: '工作单位'
                                    }
                                },
                                {
                                    title: '操作',
                                    align: 'center',
                                    events: operateEvents,
                                    formatter: operateFormatter,
                                    cellStyle: formatTableUnit
                                   
                                },
                                { field: 'resetPassword', title: '重置密码', align: 'center', events: operateEvents, formatter: passwordFormatter }
                            ],
                            onEditableSave: function (field, row, oldValue, $el) {
                                $.ajax({
                                    type: "post",
                                    url: "../Mutual/ExpertManage.ashx",
                                    data: {
                                        "Action": "EditExpert",
                                        "ExpertName": row.ExpertName,
                                        "ExpertID": row.ExpertID,
                                        "Workplace": row.Workplace,
                                        "IDType": row.IDType
                                    },
                                    success: function (data, status) {
                                        if (data == "success") {
                                            ShowMessag('修改成功!');
                                        }
                                    },
                                    error: function (data) {
                                        ShowMessag(data);
                                    },
                                });
                            }
                        };
                        }
                        option.data = Row.Table;
                        $('#tbExpertList').bootstrapTable(option);
                        $("#divPagination").empty();
                        $("#divPagination").append(recordsCount(Row.RecordNumber, Row.CuttentPage, Row.PerPage));
                        $("#divPagination").append(myPaginationLinks(Row.RecordNumber, Row.CuttentPage, Row.PagesCount, "page_link", "active", "disabled"));
                        $("#divPagination").append(selectPerPage());
                        $("#per_page_select").val(Row.PerPage);
                        $('#tbExpertList th[data-field="SpecialtyNames"] .th-inner').css({ 'width': '300px', 'margin': '0 auto' });
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbExpertList'));
                    }

                }
            });
            $('#btn_delete').prop('disabled', "true");
            $('#btnCheckedExpert').prop('disabled', "true");
            $('#tbExpertList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_delete,#btnCheckedExpert').prop('disabled', !$('#tbExpertList').bootstrapTable('getSelections').length);
            });
        };
        function getIdSelections() {
            return $.map($('#tbExpertList').bootstrapTable('getSelections'), function (row) {
                return row.ExpertID
            });
        }

        function onAdd() {
            window.location = "../UserManage/ExpertUser.aspx";
        }

        function onDelect() {
            var ExpertID = getIdSelections();
            ExpertID = ExpertID.join(',');
            ShowMessags("确认要删除吗?");
            $(".layui-layer-btn0").click(function () {
            $.ajax({
                url: "../Mutual/ExpertManage.ashx",
                type: "post",
                data: { "Action": "MultiselectDelExpertList", "ExpertID": ExpertID },
                success: function (data) {
                    if (data == "删除成功!") {
                        var PerPage = $("#per_page_select").val();
                        var CuttentPage = $("#pagination_links li a.active")[0].text;
                        InitTable(PerPage, CuttentPage);
                    }
                    else {
                        ShowMessag(data);
                    }
                }
            })
            })
        }
        function onSearch(PerPage, CuttentPage) {
            var strQuery = $("#txtQueryString").val().trim();
            var strQueryStatus = $("#ddlStatus").val();

            if (PerPage == null || PerPage == "") {
                PerPage = $('#per_page_select').val();
            }

            if (CuttentPage == null || CuttentPage == "") {
                CuttentPage = 1;
            }

            InitTable(PerPage, CuttentPage, strQuery, strQueryStatus);
        }

        $("#ddlStatus").change(function() {
            $("#hfStatus").val($("select").first().multipleSelect("getSelects"));
        });
    </script>

</asp:Content>


