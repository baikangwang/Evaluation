<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="GroupList.aspx.cs" Inherits="Evaluation.View.ExpertManage.GroupList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>

        body {
            font-size: 14px;
            font-family: "微软雅黑";
        }
        .btnt{
            width:100px;
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
        .div {
            margin-top: 18px;
        }
       .hidden-xs {
       display: inline!important;
    }
 
    input[type="file"] {
    margin-top: 0; 
   }
    .btn:hover{
        color:inherit;
        background:#fcfcfc;
    }
    .btn-file:hover{
        background:#62C1C9;
        color:#fff;
    }
    .file-caption-main{
        width:430px!important;
        position:relative;
        top:-26px;
        left:320px;
    }
    .condition {
            width:100%;
            border:1px solid #e1e1e1;
            border-radius:4px;
            padding:13px;
            margin-bottom:15px;
            height:54px;
        }
    .btnt, #lbkSearch {
            width:78px;
            padding:0;
            height:25px;
            line-height:25px;
            display:inline-block;
            text-align:center
                
        }
    .select{width:190px; margin:0 auto}

    .control-label{margin-left:20px;}
    .select span a:hover{background:#62C1C9}
    .edit{
        padding:0 5px 0 6px;
    }
   #tbExpertGroup a i{
       font-size:16px!important;
   }
   .progress{
            display:none;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/bootstrap-fileinput/css/fileinput.css" />
    <script src="../../Content/plugins/bootstrap-fileinput/js/fileinput.js"></script>
    <script src="../../Content/plugins/bootstrap-fileinput/themes/fa/theme.js"></script>
    <script src="../../Content/plugins/bootstrap-fileinput/js/locales/zh.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">评优管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ExpertManage/GroupList.aspx">专家组管理</a>
        </li>        
    </ul>
    <div style="border:1px solid #e1e1e1;border-radius:5px;padding:11px;margin-bottom:25px;">
       选择专业 ： <asp:DropDownList runat="server" ID="ddlSpecialty" ClientIDMode="Static" Style="width: 60%;"></asp:DropDownList>    
    </div>
    <div class="ExpertGroupList">
        <div class="select">          
            <input type="button" name="" id="" value="查  &nbsp;询" class="btnt" onclick="onSearch();" style="margin:0 7px;" />
        </div>
        <div id="toolbar" class="btn-group">
            <button id="btn_add" type="button" class="btn btn-default" onclick="window.location = '../ExpertManage/GroupSet.aspx'" >
                <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;添加专家组
            </button>
            <button id="btn_delete" type="button" class="btn btn-default" onclick="onDelete()">
                <span class="fa fa-trash" aria-hidden="true"></span>&nbsp;删除（批量）
            </button>
        </div>
        <table id="tbExpertGroup" style="table-layout:fixed"></table>
        <div id="divPagination" style="overflow: hidden; margin-top: 10px;"></div>
    </div>
    <script>
        $(function () {
            $("#ddlSpecialty").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });
            $('select').multipleSelect('checkAll');
            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
            }

        })
        //留着，可能会用到
        //var fileUpload = $("#FileUpExcel").get(0);
        //var files = fileUpload.files;
        //var data = new FormData();
        //for (var i = 0; i < files.length; i++) {
        //    data.append(files[i].name, files[i]);
        //}

        $("#FileUpExcel").fileinput({
            showPreview: false,
            language: "zh",
            theme: "fa",
            uploadUrl: "../Mutual/ExpertManage.ashx?Action=ImportExpertGroup",
            uploadAsync: true,
            //uploadExtraData: data,   //可能会用到
            allowedFileExtensions: ["xls", "xlsx"],
        })

        $('#FileUpExcel').on('fileuploaded', function (event, data) {
            ShowMessag(data.response)
        });

        function operateFormatter(value, row, index) {
            return [
                '<a class="add" href="javascript:void(0)" title="添加组员">',
                '<i class="fa fa-user-plus"></i>',
                '</a>',
                '<a class="edit" href="javascript:void(0)" title="修改">',
                '<i class="fa fa-edit"></i>',
                '</a>',
                '<a class="delete" href="javascript:void(0)" title="删除">',
                '<i class="fa fa-trash-o"></i>',
                '</a>',
            ].join('');
        }

        $(function () {
            var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
            var Specialtys = "";
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                data: { "Action": "SpecialtyValuesByUserID" },
                success: function (data) {
                    Specialtys = data;
                    InitTable(PerPage, CuttentPage, Specialtys);
                }
            });

        });

        function InitTable(PageSize, CuttentPage, Specialtys) {
            $("#tbExpertGroup").bootstrapTable('destroy');
            window.operateEvents = {
                'click .add': function (e, value, row, index) {
                    window.location = "GroupMember.aspx?id=" + row.GroupID + "&SpecialtyID=" + row.SpecialtyID;
                },
                'click .edit': function (e, value, row, index) {
                    window.location = "GroupSet.aspx?GroupID=" + row.GroupID + "";
                },
                'click .delete': function (e, value, row, index) {
                    ShowMessags('确认要删除吗？');
                    $('.layui-layer-btn0').on('click', function () {
                        $.ajax({
                            url: '../Mutual/ExpertManage.ashx',
                            type: "post",
                            data: { "Action": "Delete", "GroupID": row.GroupID },
                            success: function (data) {
                                $("body").attr("class", "breakpoint-1200");
                                $(".modal-backdrop").remove();
                                if (data == "") {
                                    $('#tbExpertGroup').bootstrapTable('remove', {
                                        field: 'GroupID',
                                        values: [row.GroupID]
                                    });
                                } else {
                                    ShowMessag(data);
                                }
                                var PerPage = $("#per_page_select").val();
                                var CuttentPage = $("#pagination_links li a.active")[0].text;
                                InitTable(PerPage, CuttentPage);
                            }
                        });
                    })
                }
            };
            $.ajax({
                url: '../Mutual/ExpertManage.ashx',
                type: "post",
                data: { "Action": "GetExpertGroupList", "Specialtys": Specialtys, "PageSize": PageSize, "CuttentPage": CuttentPage },
                success: function (data) {
                    if (data != "") {
                        var data = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbar',                //工具按钮用哪个容器
                            striped: true,                      //是否显示行间隔色
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            clickToSelect: true,
                            uniqueId: "GroupID",            //每一行的唯一标识，一般为主键列
                            queryParams: "",//传递参数（*）
                            columns: [{ checkbox: true },
                                { field: 'GroupName', title: '专家组名', align: 'center', valign: 'middle' },
                                { field: 'LeaderName', title: '组长/主审', align: 'center', valign: 'middle' },
                                { field: 'DeputyNames', title: '副组长/副审', align: 'center', valign: 'middle' },
                                { field: 'MemberNames', title: '组员', align: 'center', valign: 'middle', cellStyle: formatTableUnit },
                                //{ field: 'OpinionWriterName', title: '意见填写人', align: 'center', valign: 'middle' },
                                { field: 'ParentName', title: '上级专家组', align: 'center', valign: 'middle' },
                                { field: 'SpecialtyName', title: '专业', align: 'center', valign: 'middle' },
                                {
                                    title: '操作', align: 'center', valign: 'middle',
                                    events: operateEvents,
                                    formatter: operateFormatter
                                }]
                        }
                        function formatTableUnit(row, index) {
                            return {
                                css: {
                                    "white-space": "nowrap",
                                    "text-overflow": "ellipsis",
                                    "overflow": "hidden"
                                }
                            }
                        }
                        option.data = data.Table;
                        $('#tbExpertGroup').bootstrapTable(option)

                        $("#divPagination").empty();
                        $("#divPagination").append(recordsCount(data.RecordNumber, data.CuttentPage, data.PerPage));
                        $("#divPagination").append(myPaginationLinks(data.RecordNumber, data.CuttentPage, data.PagesCount, "page_link", "active", "disabled"));
                        $("#divPagination").append(selectPerPage());
                        $("#per_page_select").val(data.PerPage);
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbExpertGroup'));
                    }
                }
            })
            $('#btn_delete').prop('disabled', "true");
            $('#tbExpertGroup').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_delete').prop('disabled', !$('#tbExpertGroup').bootstrapTable('getSelections').length);
            });
        }

        function onSearch(PerPage, CuttentPage) {
            //var ddl = document.getElementById("ddlSpecialty")
            //var index = ddl.selectedIndex;
            //var Specialtys = ddl.options[index].value;
            var Specialtys = $("#ddlSpecialty").multipleSelect("getSelects");

            if (PerPage == null || PerPage == "") {
                PerPage = $('#per_page_select').val();
            }

            if (CuttentPage == null || CuttentPage == "") {
                CuttentPage = 1;
            }

            InitTable(PerPage, CuttentPage, Specialtys.toString());
        }

        function getIdSelections() {
            return $.map($('#tbExpertGroup').bootstrapTable('getSelections'), function (row) {
                return row.GroupID
            });
        }

        function getSelectedSpecialtyID() {
            return $.map($('#tbExpertGroup').bootstrapTable('getSelections'), function (row) {
                return row.SpecialtyID
            });
        }

        //function onAdd() {
        //    window.location = "GroupSet.aspx";
        //}
        function onDelete() {
            var GroupID = getIdSelections();
            GroupID = GroupID.join(",");
            ShowMessags('确认要删除吗？');
            $('.layui-layer-btn0').on('click', function () {
                $.ajax({
                    url: '../Mutual/ExpertManage.ashx',
                    type: "post",
                    data: { "Action": "Delete", "GroupID": GroupID },
                    success: function (data) {  
                        
                               $("body").attr("class", "breakpoint-1200");
                               $(".modal-backdrop").remove();
                                 if (data == "") {
                                    $('#tbExpertGroup').bootstrapTable('remove', {
                                    field: 'GroupID',
                                    values: [row.GroupID]
                                });
                               } else {
                                   ShowMessag(data);
                               }
                          
                        var PerPage = $("#per_page_select").val();
                        var CuttentPage = $("#pagination_links li a.active")[0].text;
                        InitTable(PerPage, CuttentPage);
                    }
                })
            })
        }
    </script>
</asp:Content>

