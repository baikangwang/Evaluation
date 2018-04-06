<%@ Page  Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="SpecialtyList.aspx.cs" Inherits="Evaluation.View.ActivityManage.SpecialtyList" %>
 <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        #lkbNewSpecialty {
            margin-left: 10px;
          
        }

        .rbtn {
            float: left;
            padding-top: 6px;
            padding-left: 30px;
            height: 32px;
            overflow: hidden;
        }

        a:hover {
            text-decoration: none;
        }

        .ms-parent {
            float: left;
        }

        .SpecialtyList > span {
            float: left;
            margin-bottom: 30px;
        }

        .fixed-table-toolbar div {
            margin-top: 20px;
        }

        .fixed-table-toolbar .bs-bars, .fixed-table-toolbar .search, .fixed-table-toolbar .columns {
            position: relative;
            margin-bottom: 0;
        }

        .ms-drop.bottom li span {
            float: inherit;
        }

        .table-bordered > tbody > tr > th {
            border: 0;
        }

        .fixed-table-container thead th {
            border-left: 0;
        }

        .table tbody > tr > td {
            border: 0;
        }

        .table thead > tr > th {
            border-bottom: 0;
        }

        .bootstrap-table .table > thead > tr > th {
            border-bottom: 0;
        }

        .edit {
            padding-right: 3px;
        }

        .condition {
            width: 100%;
            border: 1px solid #e1e1e1;
            border-radius: 5px;
            padding: 10px;
            margin-bottom: 15px;
            height: 48px;
        }

        .ms-choice, .ms-choice span {
            height: 26px;
            line-height: 26px;
        }

        .rbtn {
            width: 174px;
            padding: 0;
            margin: 0 auto;
            float: none;
        }

        a.btnt, #lbkSearch {
            width: 78px;
            padding: 0;
            height: 25px;
            line-height: 25px;
            display: inline-block;
            text-align: center;
        }
        .condition input {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">评优管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ActivityManage/SpecialtyList.aspx">专业管理</a>
        </li>        
    </ul>
        <div class="SpecialtyList">
            <div class="condition">
            <span style="padding-top:2px;float:left;">选择专业 ： &nbsp; </span>
                 <asp:DropDownList runat="server" ID="ddlSpecialty" ClientIDMode="Static" Style="width: 60%;"></asp:DropDownList>            
            </div>
            <div class="rbtn">             
                    <%--<asp:LinkButton runat="server" ID="lbkSearch" ClientIDMode="Static" class="btnt" OnClientClick="Search()">
                        查&nbsp;&nbsp;&nbsp;&nbsp;询
                    </asp:LinkButton>--%>
                    <input type="button" value="查 &nbsp;&nbsp; 询" class="btnt" onclick="onSearch();" style="line-height:23px;"/>       
            </div>                      
            <div>
                <div id="toolbar" class="btn-group">
                    <button id="btn_add" type="button" class="btn btn-default" onclick="onAdd()">
                        <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增
                    </button>
                    <button id="btn_delete" type="button" class="btn btn-default" onclick="onDelete()">
                        <span class="fa fa-trash" aria-hidden="true"></span>&nbsp;删除（批量）
                    </button>
                </div>
                <table id="tbSpecialtyList" data-reorderable-columns="true"></table>
                <div id="divPagination" style="overflow:hidden;margin-top:10px;"></div>
            </div>          
        </div>
       <script type="text/javascript">      
           function operateFormatter(value, row, index) {
               if (row.SpecialtyLevel == "一级") {
                   return [
                        '<a class="edit" href="javascript:void(0)" title="编辑">',
                       '<i class="fa fa-edit"></i>',
                       '</a>  ',
                       '<a href="javascript:void(0)" title="删除" >',
                       '<i class="fa  fa-trash"  style="color:rgba(0,0,0,0.2)"></i>',
                       '</a>',
                   ].join('');
               }
               else {
                   return [
                       '<a class="edit" href="javascript:void(0)" title="编辑">',
                       '<i class="fa fa-edit"></i>',
                       '</a>  ',
                       '<a class="remove" href="javascript:void(0)" title="删除" >',
                       '<i class="fa  fa-trash"></i>',
                       '</a>',
                   ].join('');
               }
           }
    
           function SpecialtyIconFormatter(value, row, index) {
               return ['<i class="fa ' + row.SpecialtyIcon + '"></i>'].join('');
           }

           function InitTable(PageSize, CuttentPage, Specialtys) {
               $('#tbSpecialtyList').bootstrapTable('destroy');
               window.operateEvents = {
                   'click .edit': function (e, value, row, index) {
                       var type = "all";
                       if (row.ChildCount > 0) {//显示子专业
                           type = "child";
                       }
                       if (row.PrizeCount > 0) {//显示奖项
                           type = "prize";
                       }
                       window.location = "../ActivityManage/SpecialtySet.aspx?sid=" + row.SpecialtyID + "&show=" + type+"&specialtyLevel="+row.SpecialtyLevel;

                       $('tr').find("[data-name]").each(function () {
                           if ($(this).attr("data-name") == "IDType") {
                               $(this).closest("td").append("<select></select>");
                           } else {
                               $(this).closest("td").append("<input type='text'/>");
                           }
                       });

                   },
                   'click .remove': function (e, value, row, index) {
                       if (row.ChildCount > 0) {
                           ShowMessags('所选专业含有子专业，将同时删除子专业及其奖项，确定要删除吗?');
                       }
                       else {
                           ShowMessags('将删除所选专业及其奖项，确定要删除吗?');
                       }

                       $(".layui-layer-btn0").click(function () {
                           var isExsitChild = 0;
                           $.ajax({
                               url: "../Mutual/ActivityManage.ashx",
                               type: "post",
                               data: { "Action": "DelSpecialty", "SpecialtyID": row.SpecialtyID },
                               success: function (data) {
                                   $("body").attr("class", "breakpoint-1200");
                                   $(".modal-backdrop").remove();
                                   if (data == "success") {
                                       //$('#tbSpecialtyList').bootstrapTable('remove', {
                                       //    field: 'ParentName',
                                       //    values: [row.SpecialtyName]
                                       //});
                                       //$('#tbSpecialtyList').bootstrapTable('remove', {
                                       //    field: 'SpecialtyID',
                                       //    values: [row.SpecialtyID]
                                       //});
                                       ShowMessags('删除成功！');
                                       var PerPage = $("#per_page_select").val();
                                       var CuttentPage = $("#pagination_links li a.active")[0].text;
                                       InitTable(PerPage, CuttentPage);
                                   }
                                   else {
                                       ShowMessag(data);
                                   }
                               }
                           });
                       });
                   }
               }
               $.ajax({
                   url: '../Mutual/ActivityManage.ashx',
                   type: "post",
                   data: { "Action": "GetSpecialtyTable", "Specialtys": Specialtys, "PageSize": PageSize, "CuttentPage": CuttentPage },
                   success: function (data) {
                       if (data != "") {
                           var JSONdata = JSON.parse(data)
                           var option = {
                               toolbar: '#toolbar',                //工具按钮用哪个容器
                               striped: true,                      //是否显示行间隔色
                               showColumns: true,                  //是否显示所有的列
                               showRefresh: false,                  //是否显示刷新按钮
                               minimumCountColumns: 1,             //最少允许的列数
                               sidePagination: "client",
                               clickToSelect: true,
                               uniqueId: "SpecialtyID",            //每一行的唯一标识，一般为主键列
                               queryParams: "",//传递参数（*）
                               columns: [{ checkbox: true },
                                   { field: 'TotalOrdinal', title: '排序', align: 'center', valign: 'middle' },
                                   { field: 'SpecialtyName', title: '专业名称', align: 'center', valign: 'middle' },
                                   { field: 'SpecialtyIcon', title: '专业图标', align: 'center', valign: 'middle', formatter: SpecialtyIconFormatter },
                                   { field: 'SpecialtyCode', title: '专业代码', align: 'center', valign: 'middle', visible: false },
                                   { field: 'ParentName', title: '父专业名称', align: 'center', valign: 'middle' },
                                   { field: 'SpecialtyLevel', title: '专业级别', align: 'center', valign: 'middle' },
                                   { field: 'ChildCount', title: '子专业数', align: 'center', valign: 'middle' },
                                   { field: 'PrizeCount', title: '奖项数', align: 'center', valign: 'middle' },
                                   { field: 'AtlasCount', title: '图集数', align: 'center', valign: 'middle' },
                                   { field: 'AppendixCount', title: '附件数', align: 'center', valign: 'middle' },
                                   {
                                       title: '操作', align: 'center', valign: 'middle', events: operateEvents,
                                       formatter: operateFormatter
                                   }]
                           }
                           option.data = JSONdata.Table;
                           $('#tbSpecialtyList').bootstrapTable(option)

                           $("#divPagination").empty();
                           $("#divPagination").append(recordsCount(JSONdata.RecordNumber, JSONdata.CuttentPage, JSONdata.PerPage));
                           $("#divPagination").append(myPaginationLinks(JSONdata.RecordNumber, JSONdata.CuttentPage, JSONdata.PagesCount, "page_link", "active", "disabled"));
                           $("#divPagination").append(selectPerPage());
                           $("#per_page_select").val(JSONdata.PerPage);
                       } else {
                           $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbSpecialtyList'));
                       }
                   }
               });
               $("#btn_delete").prop('disabled', 'true');

               $("#tbSpecialtyList").on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                   $("#btn_delete").prop('disabled', !$('#tbSpecialtyList').bootstrapTable('getSelections').length);
               });
           }

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

               var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
               var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
               InitTable(PerPage, CuttentPage);
           });

           function getIdSelections() {
               return $.map($('#tbSpecialtyList').bootstrapTable('getSelections'), function (row) {
                   return row.SpecialtyID
               });
           }
           //获取当前专业的子专业数
           function getChildCount() {
               return $.map($('#tbSpecialtyList').bootstrapTable('getSelections'), function (row) {
                   return row.ChildCount
               });
           }
           //获取当前专业的奖项数
           function getPrizeCount() {
               return $.map($('#tbSpecialtyList').bootstrapTable('getSelections'), function (row) {
                   return row.PrizeCount
               });
           }
           //获取当前专业的级别
           function getSpecialtyLevel() {
               return $.map($('#tbSpecialtyList').bootstrapTable('getSelections'), function (row) {
                   return row.SpecialtyLevel
               });
           }

            //增
           function onAdd() {
               window.location = "../ActivityManage/SpecialtySet.aspx";
           }
            //改
         
            //删
           function onDelete() {
               ShowMessags('确定删除所选专业及其子专业吗?');
               $(".layui-layer-btn0").click(function () {
                   var SpecialtyID = getIdSelections();
                   SpecialtyID = SpecialtyID.join(',');
                   $.ajax({
                       url: '../Common/ActivityManage.ashx',
                       type: 'post',
                       data: { "Action": "MultiselectDelSpecialtyList", "SpecialtyID": SpecialtyID },
                       success: function (data) {
                           ShowMessag(data);
                           var PerPage = $("#per_page_select").val();
                           var CuttentPage = $("#pagination_links li a.active")[0].text;
                           InitTable(PerPage, CuttentPage);
                       }
                   });
               });
           }
       
           //验证
           $("#lbkSearch").click(function () {
               if ($(".ms-choice").children().text() == "") {
                   //$("#lbkSearch").disable();
                   $(".ms-choice").css({ "border": "1px solid red" });
                   //$(".rbtn").children().children().attr("Enabled","false");
               }
           });

           function Search() {
               var Specialtys = $("#ddlSpecialty").multipleSelect("getSelects").toString();
            <%--   var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';--%>
               var PerPage = $('#per_page_select').val();
               var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
               InitTable(PerPage, CuttentPage, Specialtys);
           }          
   </script>
</asp:Content>
