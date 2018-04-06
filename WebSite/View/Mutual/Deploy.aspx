<%@ Page Title="系统部署" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="Deploy.aspx.cs" Inherits="Evaluation.View.Mutual.Deploy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--bootstrap-fileinput-->
    <link href="../../Content/plugins/bootstrap-fileinput/css/fileinput.css" rel="stylesheet" />
    <script src="../../Content/plugins/bootstrap-fileinput/js/fileinput.js"></script>
    <script src="../../Content/plugins/bootstrap-fileinput/themes/fa/theme.js"></script>
    <script src="../../Content/plugins/bootstrap-fileinput/js/locales/zh.js"></script>  

    <style>
 
        #content {
            padding-bottom: 240px !important;
        }

        #dt {
            border: 1px solid #dddddd;
            width: 100%;
        }

            #dt td {
                height: 30px;
            }

            #dt tbody > tr:nth-child(odd) > td {
                background: #fff;
            }

            #dt tbody > tr:nth-child(odd) > td {
                background: #EDEDED;
            }

        #DeclarationName {
            font-weight: 600;
            margin-bottom: 8px;
            display: inline-block;
        }
        .hidden-xs {
            display: inline !important;
        }
         .form-control{       
          padding:0!important;
          height:25px!important;
        }
            .input-group-btn .btn{
            padding:2px 13px!important;
        }
        .input-group input[type="file"] {
            margin-top:0!important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="column1">系统部署</a>
        </li>
    </ul>

    <table id="dt" class="table" runat="server" clientidmode="Static">
        <tr>
            <td>类别
            </td>
            <td>文件
            </td>
            <td>操作
            </td>
        </tr>
        <tr>
            <td>更新内容
            </td>
            <td id="UpdateContent" runat="server" ClientIDMode="Static" >

            </td>
            <td style="width: 30%; text-align: center;">
                <input name='FileUpExcel' type='file' class='UpdateContent' />
            </td>
        </tr>
        <tr>
            <td>更新Sql文
            </td>
            <td id="UpdateSqlText" runat="server" ClientIDMode="Static">

            </td>
            <td style="width: 30%; text-align: center;">
                <input name='FileUpExcel' type='file' class='UpdateSqlText' />
            </td>
        </tr>
        <tr>
            <td>最新发布包
            </td>
            <td id="UpdatePackage" runat="server" ClientIDMode="Static">

            </td>
            <td style="width: 30%; text-align: center;">
                <input name='FileUpExcel' type='file' class='UpdatePackage' />
            </td>
        </tr>
        <tr>
            <td>最新源码
            </td>
            <td  id="UpdateSourceCode" runat="server" ClientIDMode="Static">

            </td>
            <td style="width: 30%; text-align: center;">
                <input name='FileUpExcel' type='file' class='UpdateSourceCode' />
            </td>
        </tr>

    </table>
    <div style="width: 80px; margin: 40px auto;">
        <input type="button" name="name" class="btnt" value="返  回" onclick="Back()" />
    </div>

    <div>
        <input type="button" name="name" class="btnt" value="下载所有奖项文件" onclick="PackageAll()" />
        <table id="tbPrizeList"></table>
    </div>

    <script>
        // 更新内容
        $(".UpdateContent").fileinput({
            showPreview: false,
            language: "zh",
            theme: "fa",
            uploadUrl: "../Mutual/Common.ashx?Action=UploadFile",
            uploadAsync: true,
            //allowedFileExtensions: ["xls", "xlsx", "rar", "zip", "doc", "docx", "jpg"],
            uploadExtraData: { "FileType": "UpdateContent"},
        });

        $('.UpdateContent').on('fileuploaded', function (event, data) {
            ShowMessag("上传成功！");
            $.ajax({
                url: '../Mutual/Common.ashx',
                type: "post",
                async: false,
                data: { "Action": "GetUpdateContent", "FileType": "UpdateContent"},
                success: function (data) {
                    data = JSON.parse(data);
                    $("#UpdateContent").html(data);
                }
            });
            $('.layui-layer-btn0').click(function () {
                $('.fileinput-remove').click();
            });
        });

        // 更新Sql文
        $(".UpdateSqlText").fileinput({
            showPreview: false,
            language: "zh",
            theme: "fa",
            uploadUrl: "../Mutual/Common.ashx?Action=UploadFile",
            uploadAsync: true,
            //allowedFileExtensions: ["xls", "xlsx", "rar", "zip", "doc", "docx", "jpg"],
            uploadExtraData: { "FileType": "UpdateSqlText" },
        });
        $('.UpdateSqlText').on('fileuploaded', function (event, data) {
            ShowMessag("上传成功！");
            $.ajax({
                url: '../Mutual/Common.ashx',
                type: "post",
                async: false,
                data: { "Action": "GetUpdateSqlText", "FileType": "UpdateSqlText" },
                success: function (data) {
                    data = JSON.parse(data);
                    $("#UpdateSqlText").html(data);
                }
            });     
             $('.layui-layer-btn0').click(function(){
              $('.fileinput-remove').click();
            })
        });

        // 最新发布包 
        $(".UpdatePackage").fileinput({
            showPreview: false,
            language: "zh",
            theme: "fa",
            uploadUrl: "../Mutual/Common.ashx?Action=UploadFile",
            uploadAsync: true,
            //allowedFileExtensions: ["xls", "xlsx", "rar", "zip", "doc", "docx", "jpg"],
            uploadExtraData: { "FileType": "UpdatePackage" },
        });
        $('.UpdatePackage').on('fileuploaded', function (event, data) {
            ShowMessag("上传成功！");
            $.ajax({
                url: '../Mutual/Common.ashx',
                type: "post",
                async: false,
                data: { "Action": "GetUpdatePackage", "FileType": "UpdatePackage" },
                success: function (data) {
                    data = JSON.parse(data);
                    $("#UpdatePackage").html(data);
                }
            });
             $('.layui-layer-btn0').click(function(){
              $('.fileinput-remove').click();
            })
        });

        // 最新源代码
        $(".UpdateSourceCode").fileinput({
            showPreview: false,
            language: "zh",
            theme: "fa",
            uploadUrl: "../Mutual/Common.ashx?Action=UploadFile",
            uploadAsync: true,
            //allowedFileExtensions: ["xls", "xlsx", "rar", "zip", "doc", "docx", "jpg"],
            uploadExtraData: { "FileType": "UpdateSourceCode" },
        });
        $('.UpdateSourceCode').on('fileuploaded', function (event, data) {
            ShowMessag("上传成功！");
            $.ajax({
                url: '../Mutual/Common.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "GetUpdateSourceCode",
                    "FileType": "UpdateSourceCode"
                },
                success: function (data) {
                    data = JSON.parse(data);
                    $("#UpdateSourceCode").html(data);
                }
            });
            $('.layui-layer-btn0').click(function () {
                $('.fileinput-remove').click();
            });
        });

        // 下载文件
        function DownloadAppendix(UploadFileID) {
            PrepLoadFile(UploadFileID);
            var form = $("<form>");   //定义一个form表单
            form.attr('style', 'display:none');   //在form表单中添加查询参数
            form.attr('target', '');
            form.attr('method', 'post');
            form.attr('action', "../Declaration/DeclarationList.aspx?UploadFileID=" + UploadFileID);

            var input1 = $('<input>');
            input1.attr('type', 'hidden');
            $('body').append(form);  //将表单放置在web中
            form.append(input1);   //将查询参数控件提交到表单上
            form.submit();
        }

        function PrepLoadFile(UploadFileID) {
            $.ajax({
                url: '../Mutual/Common.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "PrepLoadFile",
                    "UploadFileID": UploadFileID
                },
            });
        }

        // 删除文件
        function DeleteAppendix(UploadFileID, OwnerID, CorrelationID) {
            ShowMessags('是否删除此附件？')
            $('.layui-layer-btn0').on('click', function () {
                $.ajax({
                    url: '../Mutual/Common.ashx',
                    type: "post",
                    async: false,
                    data: {
                        "Action": "DeleteDeployFile",
                        "UploadFileID": UploadFileID,
                        "OwnerID": OwnerID,
                        "CorrelationID": CorrelationID
                    },
                    success: function (data) {
                        data = JSON.parse(data);
                        $("#" + data).html("暂未上传文件");
                    }
                });
            })
        }

        function PackageAll() {
            $.ajax({
                url: "../Mutual/Declaration.ashx",
                type: "post",
                data: {
                    "Action": "PackageAll",
                },
                success: function (data) {
                    ShowMessag(data);
                }
            });
        }

        function InitTable() {
            $("#tbPrizeList").bootstrapTable('destroy');
            window.operateEvents = {
                'click .pack': function (e, value, row, index) {
                    $.ajax({
                        url: "../Mutual/Declaration.ashx",
                        type: "post",
                        data: {
                            "Action": "PackageEvaluation",
                            "PrizeID": row.PrizeID
                        },
                        success: function (data) {
                            ShowMessag(data);
                        }
                    });
                }
            }

            $.ajax({
                url: "../Mutual/ActivityManage.ashx",
                type: "post",
                data: { "Action": "GetPrizeList" },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data)
                        var option = {
                            toolbar: "#toolbar",
                            striped: true,                      //是否显示行间隔色
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                 //是否显示刷新按钮
                            clickToSelect: true,
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            uniqueId: "PrizeID",
                            checkbox: "true",
                            queryParams: "",//传递参数（*）
                            columns: [
                                { field: 'Ordinal', title: '序号', align: 'center', Valign: 'middle', visible: false },
                                { field: 'PrizeName', title: '奖项名称', align: 'center', Valign: 'middle' },
                                { field: 'SpecialtyName', title: '专业', align: 'center', Valign: 'middle' },
                                { field: 'PrizeType', title: '奖项类别', align: 'center', Valign: 'middle' },
                                { field: 'VoteTypeText', title: '投票方式', align: 'center', Valign: 'middle' },
                                { field: 'DeclarationCheckCount', title: '收件封存的申报数量', align: 'center', Valign: 'middle' },
                                {
                                    title: '操作', align: 'center', Valign: 'middle',
                                    events: operateEvents,
                                    formatter: function (value, row, index) {
                                        return [
                                            '<a class="pack" href="javascript:void(0)" title="文件夹规整">',
                                            '<i class="fa fa-cloud-download"></i>',
                                            '</a>'
                                        ].join('');
                                    }
                                }
                            ]
                        };
                        option.data = Row.Table;
                        $("#tbPrizeList").bootstrapTable(option);
                        $('#tbPrizeList th[data-field="11"]').css('width', '55px');
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbPrizeList'));
                    }
                }
            });
            $('#btn_delete').prop('disabled', "true");

            $('#tbPrizeList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_delete').prop('disabled', !$('#tbPrizeList').bootstrapTable('getSelections').length);
            });
        }


        $(document).ready(function () {            
            $('#dt tbody tr:nth-child(1)> td').css({ 'background': '#85E1E1', 'font-weight': '600' });

            InitTable();
        });
        function Back() {
            window.location.href = "../Mutual/HomePage.aspx";
        };
    </script>
</asp:Content>
