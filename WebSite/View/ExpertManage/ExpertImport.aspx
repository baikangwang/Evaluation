<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="ExpertImport.aspx.cs" Inherits="Evaluation.View.ExpertManage.ExpertImport" %>
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

        #divPagination {
            overflow: hidden;
        }

        .PerPageSelect {
            margin-right: 28%;
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



        tbody > tr > td:nth-child(2) > .popover.top .arrow {
            margin-left: 2px;
        }

        .select {
            width: 100%;
            border: 1px solid #e1e1e1;
            border-radius: 5px;
            padding: 15px;
            margin-bottom: 15px;
            position:relative;
            height:55px;
        }

        a.btnt, #lbkSearch {
            width: 78px;
            padding: 0;
            height: 25px;
            line-height: 23px;
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
        #lbkSearch {
            margin-left: 10px;
        }

        .select input {
            height: 26px;
        }

        .file-caption-main {
            width: 430px !important;
            position: relative;
            top: -21px;
            left: 80px;
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
        .fixed-table-toolbar{
            display:none;
        }
      .ListMessage{
           font-weight:600;
        }
        .ListMessage{
            margin:40px 0 1px 0;
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
          <a href="../ExpertManage/ExpertList.aspx">专家管理</a>
        </li>        
    </ul>
    <div style="padding-bottom:200px;">
    <div class="select"> 
        <%--<span>选择专业：</span>
        <asp:DropDownList runat="server" ID="ddlSpecialty" ClientIDMode="Static"></asp:DropDownList>--%>
        <div style="display:none;">
            <input id="txtUploadFile" style="border: 1px solid #C0C0C0;width:300px;border-bottom-left-radius: 4px;border-top-left-radius: 4px;padding-left:10px;" />
            <input type="button" value="选 择..." onclick="FileUploadClick();" style="width: 70px; height: 26px;background:#33B0BA;border:none;color:#fff;position:relative;left:-12px;border-bottom-right-radius: 4px;border-top-right-radius: 4px; " />
            <asp:FileUpload ID="fuExpert" Font-Names="fuExpert" runat="server" style="display:none;" ClientIDMode="Static" onchange="UploadOnpropertyChange();"  />       
            <input id="fpurl" type="hidden" value="<%=fuExpert.ClientID %>" />
        </div>  
        <span class="control-label">选择文件：</span>
        <input id="FileUpExcel" name="FileUpExcel" type="file" class="file"  />
        <span style="position: absolute; top: 15px; left: 545px; color: red">(支持xls、xlsx格式)</span>
    </div>
    <div style="width:200px; margin:25px auto;">
        <asp:Button ID="btnDownload" runat="server" class="btnt" OnClick="btnDownload_Click" Text="下载模板" style="margin:0 10px 0 10px"/>
        <asp:Button ID="btnCancel" runat="server"  class="btnt" OnClick="btnCancel_Click" Text="返  回" />
    </div>
         <div class="Message"></div> 
         <div class="ImportMessage"></div>            
         <table id="tbExpertImport" data-reorderable-columns="true"></table>
         <div class="ListMessage"></div> 
         <table id="tbExpertList" data-reorderable-columns="true"></table>     
    </div> 
<script>

    function UploadOnpropertyChange() {
        var varUploadFile = document.getElementById(document.getElementById("fpurl").value).value;
        var varArray = varUploadFile.split('\\');
        document.getElementById("txtUploadFile").value = varArray[varArray.length - 1];
    };

    $("#FileUpExcel").fileinput({
        showPreview: false,
        language: "zh",
        theme: "fa",
        uploadUrl: "../Mutual/ExpertManage.ashx?Action=ImportExpert",
        uploadAsync: true,
        uploadExtraData: function () { return {}; },//SpecialtyID: $("#ddlSpecialty").val()
        allowedFileExtensions: ["xls", "xlsx"],
    });

    $(function () {
        var msg = $("#hdMsg").val();
        if (msg != "") {
            ShowMessag(msg);
            if (msg == "导入成功!") {
                $(".layui-layer-btn0").click(function () {
                    window.location = "../../View/ExpertManage/ExpertList.aspx";
                });
            }
        }

        //$("#ddlSpecialty").multipleSelect({
        //    single: true,
        //    noMatchesFound: '暂无专业',
        //});

        $('#FileUpExcel').on('fileuploaded', function (event, data) {
            if (data != "") {
                data = data.response;
                var Ecount = data[0] - data[1];
                console.log(data)
                $('.ImportMessage').empty();
                if (data[0] == "-1") {
                    $('.ImportMessage').append('<div> ' + data[1] + '</div>');
                }
                else {
                    $('.ImportMessage').append('<div>共上传' + data[0] + ' 条数据，上传成功' + data[1] + '条，上传失败' + Ecount + '条.</div><div style="margin:10px 0 1px 0; font-weight:600;">成功列表：</div>');
                }

                $("#tbExpertList,#tbExpertImport").bootstrapTable('destroy');

                //成功列表
                var option = {
                    toolbar: '#toolbar',                //工具按钮用哪个容器
                    striped: true,                      //是否显示行间隔色
                    editable: false,
                    clickToSelect: true,
                    showColumns: true,                  //是否显示所有的列
                    showRefresh: false,                  //是否显示刷新按钮
                    minimumCountColumns: 1,             //最少允许的列数
                    sidePagination: "client",
                    columns: [
                        { field: 'ExpertName', title: '专家姓名' },
                        { field: 'Gender', title: '性别' },
                        { field: 'IDTypeText', title: '证件类别' },
                        { field: 'IDNumber', title: '证件号码' },
                        { field: 'Email', title: '电子邮箱' },
                        { field: 'AcademicTitle', title: '职称' },
                        { field: 'Profession', title: '研究方向' },
                        { field: 'Workplace', title: '工作单位' },
                        { field: 'SpecialtyNames', title: '评优专业' }
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
                    showColumns: true,                  //是否显示所有的列
                    showRefresh: false,                  //是否显示刷新按钮
                    minimumCountColumns: 1,             //最少允许的列数
                    sidePagination: "client",
                    columns: [
                        { field: 'Value.ExpertName', title: '专家姓名' },
                        { field: 'Value.Gender', title: '性别' },
                        { field: 'Value.IDTypeText', title: '证件类别' },
                        { field: 'Value.IDNumber', title: '证件号码' },
                        { field: 'Value.Email', title: '电子邮箱' },
                        { field: 'Value.AcademicTitle', title: '职称' },
                        { field: 'Value.Profession', title: '研究方向' },
                        { field: 'Value.Workplace', title: '工作单位' },
                        { field: 'Value.SpecialtyNames', title: '评优专业' },
                        { field: 'Key', title: '失败原因' }
                    ]
                };
                option.data = data[3];
                $('#tbExpertList').bootstrapTable(option);
            } else {
                $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbExpertImport'));
                $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbExpertList'));
            }
        });
    });

</script>
</asp:Content>
