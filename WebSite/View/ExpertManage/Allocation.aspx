<%@ Page Title="专家分配项目" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="Allocation.aspx.cs" Inherits="Evaluation.View.ExpertManage.Allocation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
   <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css" />
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>
    <style>
        #content{
            padding-bottom:200px!important;
        }
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
            margin-left: 5px !important;
            margin-right: 12px !important;
        }

        #txtDeclarationBeginDate, #txtDeclarationEndDate, #txtEditBeginDate, #txtEditEndDate {
            margin-left: 0px !important;line-height:26px;
        }

        .btnt {
            width: 78px;
            margin: 0 auto;
            height: 26px;
            line-height: 26px;
            padding: 0px;
        }

        .inquire {
            width: 184px;
            margin: 0 auto;
            display: block;
            margin-top: 20px;
        }

        .input-group table {
            display: inline;
            float:right;
        }

        .datepicker input {
            height: 26px!important;
            line-height: 12px;
        }

        .DeclarationList {
            border: 1px solid #E1E1E1;
            border-radius: 5px;
            padding: 10px;
        }

        .input-group-addon {
            padding: 0 6px;
        }

        #txtDeclarationName {
            height: 26px;
        }
        .file-caption-main {
            width: 430px !important;
            position: absolute;
            top:10px;
            left:88px;
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
         .ListMessage{
           font-weight:600;
        }
        .ListMessage{
            margin:40px 0 1px 0;
        }
       #tbExpertImport,#tbList{
       white-space: nowrap;
       }
       .ms-parent {
           margin-bottom:2px;
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
          <a href="../ExpertManage/AllocationList.aspx">项目分配</a>
        </li>        
    </ul>
     <div class="DeclarationList" style="height:48px;position:relative; margin-bottom:5px">
            <span>选择专业：&nbsp;
               <asp:DropDownList runat="server" ID="ddlSpecialty" ClientIDMode="Static" Style="width: 166px; height: 25px;" OnSelectedIndexChanged="ddlSpecialty_SelectedIndexChanged"></asp:DropDownList>
            </span>
            <asp:Button ID="btnDownload" runat="server" class="btnt" OnClick="btnDownload_Click" Text="下载模板" style="margin-left:10px;"/>


        </div> 
    <div class="DeclarationList" style="height:48px;position:relative;">
       <div class="condition">
            
            <span class="control-label">选择文件：</span>
            <input id="FileUpExcel" name="FileUpExcel" type="file" class="file" onclick="return IsCheckedSpecialty()" />
            <span style="position: absolute; top: 11px; left:550px; color: red">(支持xls、xlsx格式)</span>           
        </div>
    </div> 
       
     <div style="width:180px;margin:30px auto;">
     <input type="button" name="name" value="返   回" class="btnt" id="back" onclick="return history.go(-1);"/>
     </div>
   
     <div>
         <div class="Message"></div> 
         <div class="ImportMessage"></div>            
         <table id="tbExpertImport" data-reorderable-columns="true"></table>
         <div class="ListMessage"></div> 
         <table id="tbList" data-reorderable-columns="true"></table>     
    </div>
    <script>
        $("#ddlSpecialty").multipleSelect({
            single: true
        });
        $(function () {
            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
            }
        })
        function IsCheckedSpecialty() {
            var obj = document.getElementById("ddlSpecialty");
            var index = obj.selectedIndex;
            var value = obj.options[index].value;
            if (value == null || value == 0 || value == -1) {
                ShowMessag("请选择专业再上传！");
                return false;
            } else {
                return true;
            }
        }
        $("#FileUpExcel").fileinput({
            showPreview: false,
            language: "zh",
            theme: "fa",
            uploadUrl: "../Mutual/ExpertManage.ashx?Action=ImportExpertGroup",
            uploadAsync: true,
            uploadExtraData: function () { return { SpecialtyID: $("#ddlSpecialty").val() }; },
            allowedFileExtensions: ["xls", "xlsx"],
        })

        $('#FileUpExcel').on('fileuploaded', function (event, data) {
            if (data != "") {
                data = data.response;
                var Ecount = data[0] - data[1];
                $('.ImportMessage').empty();
                if (data[0] == "-1") {
                    $('.ImportMessage').append('<div> ' + data[1] + '</div>');
                }
                else {
                    $('.ImportMessage').append('<div>共上传' + data[0] + ' 条数据，上传成功' + data[1] + '条，上传失败' + Ecount + '条.</div><div style="margin:10px 0 1px 0; font-weight:600;">成功列表：</div>');
                }
                $("#tbList,#tbExpertImport").bootstrapTable('destroy');

                //成功列表
                var option = {
                    toolbar: '#toolbar',                //工具按钮用哪个容器
                    striped: true,                      //是否显示行间隔色
                    editable: false,
                    clickToSelect: true,
                    showColumns: false,                  //是否显示所有的列
                    showRefresh: false,                  //是否显示刷新按钮
                    minimumCountColumns: 1,             //最少允许的列数
                    sidePagination: "client",
                    columns: [
                       [
                       { title: '项目信息', colspan: 4, align: 'center', valign: 'middle' },
                       { title: '项目评审小组', colspan: 5, align: 'center', valign: 'middle' },
                       { title: '上级专家组1', colspan: 3, align: 'center', valign: 'middle' },
                       { title: '上级专家组2', colspan: 3, align: 'center', valign: 'middle' },
                       { title: '上级专家组3', colspan: 4, align: 'center', valign: 'middle' },
                       ],
                       [
                       { field: '项目信息', title: '序号' },
                       { field: 'Column1', title: '项目编码' },
                       { field: 'Column2', title: '项目名称' },
                       { field: 'Column3', title: '申报奖项' },
                       { field: '项目评审小组', title: '组名' },
                       { field: 'Column4', title: '审批意见填写人' },
                       { field: 'Column5', title: '组长/主审' },
                       { field: 'Column6', title: '副组长/副审' },
                       { field: 'Column7', title: '组员' },
                       { field: '上级专家组1', title: '组名' },
                       { field: 'Column8', title: '组长' },
                       { field: 'Column9', title: '副组长' },
                       { field: '上级专家组2', title: '组名' },
                       { field: 'Column10', title: '组长' },
                       { field: 'Column11', title: '副组长' },
                       { field: '上级专家组3', title: '组名' },
                       { field: 'Column12', title: '组长' },
                       { field: 'Column13', title: '副组长' },
                       { field: 'ErrorMessage', title: '失败原因' },
                       ]
                    ]
                };
                option.data = data[2];
                $('#tbExpertImport').bootstrapTable(option);
                //失败列表
                $('.ListMessage').empty();
                $('.ListMessage').append('<div>失败列表：</div>');
                var option = {
                    toolbar: '#toolbar',                //工具按钮用哪个容器
                    striped: true,                      //是否显示行间隔色
                    editable: false,
                    clickToSelect: true,
                    showColumns: false,                  //是否显示所有的列
                    showRefresh: false,                  //是否显示刷新按钮
                    minimumCountColumns: 1,             //最少允许的列数
                    sidePagination: "client",
                    columns: [
                        [
                        { title: '项目信息', colspan: 4, align: 'center', valign: 'middle' },
                        { title: '项目评审小组', colspan: 5, align: 'center', valign: 'middle' },
                        { title: '上级专家组1', colspan: 3, align: 'center', valign: 'middle' },
                        { title: '上级专家组2', colspan: 3, align: 'center', valign: 'middle' },
                        { title: '上级专家组3', colspan: 4, align: 'center', valign: 'middle' },
                        ],
                        [
                        { field: '项目信息', title: '序号' },
                        { field: 'Column1', title: '项目编码' },
                        { field: 'Column2', title: '项目名称' },
                        { field: 'Column3', title: '申报奖项' },
                        { field: '项目评审小组', title: '组名' },
                        { field: 'Column4', title: '审批意见填写人' },
                        { field: 'Column5', title: '组长/主审' },
                        { field: 'Column6', title: '副组长/副审' },
                        { field: 'Column7', title: '组员' },
                        { field: '上级专家组1', title: '组名' },
                        { field: 'Column8', title: '组长' },
                        { field: 'Column9', title: '副组长' },
                        { field: '上级专家组2', title: '组名' },
                        { field: 'Column10', title: '组长' },
                        { field: 'Column11', title: '副组长' },
                        { field: '上级专家组3', title: '组名' },
                        { field: 'Column12', title: '组长' },
                        { field: 'Column13', title: '副组长' },
                        { field: 'ErrorMessage', title: '失败原因' },
                        ]
                    ]
                };
                option.data = data[3];
                $('#tbList').bootstrapTable(option);
            } else {
                $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbList'));
                $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbExpertImport'));
            }
        });
    </script>

</asp:Content>

