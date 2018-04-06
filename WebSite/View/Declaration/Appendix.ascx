<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Appendix.ascx.cs" Inherits="Evaluation.View.Declaration.Appendix" %>

<!--bootstrap-fileinput-->
    <link href="../../Content/plugins/bootstrap-fileinput/css/fileinput.css" rel="stylesheet" />
    <script src="../../Content/plugins/bootstrap-fileinput/js/fileinput.js"></script>
    <script src="../../Content/plugins/bootstrap-fileinput/themes/fa/theme.js"></script>
    <script src="../../Content/plugins/bootstrap-fileinput/js/locales/zh.js"></script>
   <%-- <script src="../../Content/plugins/zoom/e-smart-zoom-jquery.min.js"></script>--%>
    <script src="../../Content/plugins/zoom/js/viewer-jquery.min.js"></script>  
    <link href="../../Content/plugins/zoom/css/viewer.min.css" rel="stylesheet" />
    <script src="../../Content/plugins/video5.18.4.js/js/videojs-ie8.min.js"></script>
    <script src="../../Content/plugins/video5.18.4.js/js/video.min.js"></script>
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/video5.18.4.js/css/video-js.css"/>	
<style>
  #dowebok { width: 700px; margin: 0 auto; font-size: 0;}
  #dowebok li img { width: 100%;}
    .fa{padding:0 0.5em}
    #Enclosurelist a{
        color:#30b9cb;
        border-radius:3px;
    }
    #Enclosurelist a:hover{
        color:#fff
    }
    .modal-dialog{
        width:500px;
    }
    #my-video{
        width:320px;
        height:240px;
        margin:0 auto;
    }
    #AtlasTable a.dowebok:hover{
        background:inherit;cursor:pointer;            
    }
    #AtlasTable a:hover{
        background:#eee;color:#30b9cb;   
    }
    .dowebok{
        display:block;position:relative;
    }
</style>  
<asp:Panel ID="panelAppendix" runat="server" GroupingText="附件目录">
   
    <div style="display:none"><asp:TextBox runat="server" ID="txtSituation" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox runat="server" ID="txtAppendixFile" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox runat="server" ID="txtAtlasFile" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox runat="server" ID="txtDeclarationID" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox runat="server" ID="txtDeclarationIDBackups" ClientIDMode="Static"></asp:TextBox></div>
    <h3>1.附件集</h3>
    <div style="margin:0px auto" id="AppendixTable" runat="server" clientidmode="Static" >
        <table id="Enclosure" style="text-align:center; display:none">
            <tr>
                <td style="width:5%">顺序</td>
                <td style="width:20%">附件名称</td>
                <td style="width:35%">附件</td>
                <td style="width:40%">操作</td>
            </tr>
            <tbody id="Enclosurelist"></tbody>

        </table>
    </div>
    <h3>2.图集</h3>
    <div style="margin:0px auto" id="AtlasTable" runat="server" clientidmode="Static" >
        <table style="text-align:center;display:none" id="Atlas">
            <tr>
                <td style="width:5%">顺序</td>
                <td style="width:20%">图集名称</td>
                <td style="width:35%">图片</td>
                <td style="width:40%">操作</td>
            </tr>
            <tbody id="atlasList">
                
            </tbody>
        </table>
    </div>
    <h3>3.视频</h3>
    <div style="margin:0px auto" id="MediaTable" runat="server" clientidmode="Static" >
         <table style="text-align:center;display:none" id="Media">
            <tr>
                <td style="width:5%">顺序</td>
                <td style="width:20%">视频集名称</td>
                <td style="width:35%">视频</td>
                <td style="width:40%">操作</td>
            </tr>
            <tbody id="mediaList">
                
            </tbody>
        </table>
    </div>
    <br />        
    <div style="text-align: center; margin-top: 80px;">
        <a  id="AppendixPrev" class="btnt up" href="#top">上 一 步</a>
        <a  id="AppendixNext" class="btnt up" style="margin:0 20px;" href="#top">下 一 步</a>     
    </div>   
    <div class="pageContent">
              
    </div>
    <!-- Modal -->
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
            <h4 class="modal-title" id="myModalLabel">Modal title</h4>
          </div>
          <div class="modal-body">
              <!--播放器-->
              <video id="my-video" class="video-js" controls preload="auto" width="640" height="264">
			    <source id="mediaSource" type="video/mp4">			    
			    <p class="vjs-no-js">
			      To view this video please enable JavaScript, and consider upgrading to a web browser that
			      <a href="http://videojs.com/html5-video-support/" target="_blank">supports HTML5 video</a>
			    </p>
		      </video>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-default" data-dismiss="modal">关闭</button>
          </div>
        </div>
      </div>
    </div>   
</asp:Panel>
<script>
    $.ajax({
        type: "post",
        url: "../Mutual/Declaration.ashx",
        data: {
            "Action": "GetData",
            "DeclarationID": $("#txtDeclarationID").val(),
        },
        success: function (data, status) {
            var IsAllowSubmit=JSON.parse(data)[0].IsAllowSubmit
            $.cookie('IsAllowSubmit',IsAllowSubmit , { path: '/' });
            var Enclosuredatalength = JSON.parse(data)[3].length;
            var Atlasdatalength = JSON.parse(data)[4].length;
            var Mediadatalength = JSON.parse(data)[6].length;
            var pageData = JSON.parse(data)[1];
            var vParticipantLimit=JSON.parse(data)[0].ParticipantLimit
            $.cookie('ParticipantLimitnumber', vParticipantLimit, { path: '/' });
            for(var i=0;i<pageData.length;i++){
                var oElement="#"+pageData[i].RecordNameEn;
                $(oElement).attr("RecordLen", pageData[i].RecordLen);
            }
            //附件集
            if (Enclosuredatalength > 0) {
                setEnclosureTable(data);
            } else {
                $("#AppendixTable").append(
                    "<div style='border:1px solid #777;margin:0 auto; text-align:center;width:90%;padding:5px;'>"
                    + "该专业下暂无附件集目录！"
                    + "</div>");
            }

            //图片集
            if (Atlasdatalength > 0) {
                setAtlasTable(data);             
            } else {
                $("#AtlasTable").append("<div style='border:1px solid #777;margin:0 auto; text-align:center;width:90%;padding:5px;'>"
                    + "该专业下暂无图集目录！"
                    + "</div>");
            }
          
            //视频集
            if (Mediadatalength > 0) {
                InitMedia(data);
            } else {
                $("#MediaTable").append("<div style='border:1px solid #777; margin:0 auto; text-align:center;width:90%;padding:5px;'>"
                    + "该专业下暂无视频集目录！"
                    + "</div>");
            }
        }
    });

    function DownloadFile(UploadFileID){
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

    function DeleteFile(UploadFileID, ID, Msg) {
        ShowMessags(Msg);
        $('.layui-layer-btn0').on('click', function () {
            $.ajax({
                url: '../Mutual/Declaration.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "DeleteUploadFile",
                    "UploadFileID": UploadFileID
                },
                success: function (data) {
                    data = JSON.parse(data);
                    $("#" + ID).html(data);
                }
            });
        });
    }

    //附件集table
    function setEnclosureTable(data) {
        $("#Enclosure").show();
        var Enclosuredata = JSON.parse(data)[3];

        $("#Enclosurelist").empty();
        for (var i = 0; i < Enclosuredata.length; i++) {
            var index = i + 1;
            if (Enclosuredata[i].FileName) {
                var FileName = "<a id=LoadFile" + i + " >" + Enclosuredata[i].FileName + "</a>"
                    + "<p><a class='DeleteAppendix' onclick='DeleteAppendix("
                    + Enclosuredata[i].UploadFileID + ","
                    + Enclosuredata[i].OwnerID + ","
                    + Enclosuredata[i].CorrelationID + ","
                    + i + ");return false;'  title='删除' href=''><i class='fa fa-trash-o'></i></a>"
                    + "<a class='DownloadAppendix' onclick=\"DownloadAppendix("
                    + Enclosuredata[i].UploadFileID
                    + ");return false;\" title='下载' href=''><i class='fa fa-download'></i></a>"
                    + "</p>";
            } else {
                var FileName = "未上传文件!";
            }
            var tableList = "<tr>";
            tableList += "<td>" + index + "</td>";
            tableList += "<td>" + Enclosuredata[i].CorrelationName + "<br/>文件最大" + Enclosuredata[i].SizeLimit + "M</td>";
            tableList += "<td id='UploadFile" + i + "'>" + FileName + "</td>";
            tableList += "<td>";
            tableList += "<label class='control-label'>请选择文件</label>";
            tableList += "<input  name='FileUpExcel' type='file' class='FileUpAppendix" + i + "' />";
            if (Enclosuredata[i].IsRequired == true) {
                tableList += "<b style='color:#FC7464;position:relative;bottom:25px;right:20px;float:right;'>*</b>"
             }
             tableList += "</td></tr>";
            $("#Enclosurelist").append(tableList);
        }
        FileUpaction(data);
    }

    //附件集相关操作
    function FileUpaction(Data) {
        var Data = JSON.parse(Data);
        var AppendixFileCount = Data[3].length;
        for (i = 0; i < AppendixFileCount; i++) {
            $(".FileUpAppendix" + i).fileinput({
                showPreview: false,
                language: "zh",
                theme: "fa",
                maxFileSize: Data[3][i].SizeLimit * 1024,
                uploadUrl: "../Mutual/Declaration.ashx?Action=ImportAppendix",
                uploadAsync: true,
                //allowedFileExtensions: ["xls", "xlsx", "rar", "zip", "doc", "docx", "jpg"],
                uploadExtraData: {
                    "AppendixName": Data[3][i].CorrelationName,
                    "DeclarationCode": Data[0].DeclarationCode,
                    "DeclarationID": Data[0].DeclarationID,
                    "AppendixID": Data[3][i].AppendixID,
                    "ID": i
                },
            });
        }
        for (i = 0; i < AppendixFileCount; i++) {
            $('.FileUpAppendix' + i).on('fileuploaded', function (event, data) {
                console.log(data)
                if (data.response == "1") {
                    ShowMessag("上传文件大小超过设置范围内!");
                }
                else {
                    ShowMessag("上传成功！");
                    var FileData = (data.response).split(",");
                    var OwnerID = FileData[0];
                    var UploadFileID = FileData[1];
                    var CorrelationID = FileData[2];

                    $.ajax({
                        url: '../Mutual/Declaration.ashx',
                        type: "post",
                        async: false,
                        data: {
                            "Action": "GetAppendix",
                            "OwnerID": OwnerID,
                            "CorrelationID": CorrelationID,
                            "ID": UploadFileID
                        },
                        success: function (data) {
                            data = JSON.parse(data);
                            $("#UploadFile" + UploadFileID).html(data);
                        }
                    });
                }
            });
        }
    }

    //下载附件
    function DownloadAppendix(UploadFileID) {
        DownloadFile(UploadFileID);
    }

    //删除附件
    function DeleteAppendix(UploadFileID, OwnerID, CorrelationID, ID) {
        DeleteFile(UploadFileID, "UploadFile" + ID, "是否删除此附件？");
    }

    //图集table
    function setAtlasTable(data) {     
        $("#Atlas").show()
        var item = JSON.parse(data)[4];
        var AtlasID = "";
        var AtlasName = "";
        var tableList = "";
        var index = 0;
        var oElememt;
        var oImg;
        var Mimi = "";
        var AmountLimit;
        var SizeLimit;
        $("#atlasList").empty();
        for (var i = 0; i < item.length; i++) {
            if (item[i].AtlasID != AtlasID) {
                index += 1;
                AtlasID = item[i].AtlasID;
                AtlasName = item[i].CorrelationName;
                AmountLimit = item[i].AmountLimit ? item[i].AmountLimit : "---"
                SizeLimit = item[i].SizeLimit?item[i].SizeLimit:"---"
                tableList = "<tr>"
                tableList += "<td>" + index + "</td>"
                tableList += "<td>" + item[i].CorrelationName + "<br/>本图集最多上传" + AmountLimit + "张<br/>最大" + SizeLimit + "M/张</td>"
                tableList += "<td id='UploadImg" + index + "' name=" + AtlasName + AtlasID + "></td>"
                tableList += "<td><label class='control-label'>请选择文件</label><input name='FileUpExcel' type='file' multiple='multiple' class='ImgUpAppendix" + index + "' />";
                if (item[i].IsRequired == true) {
                    tableList += "<b style='color:#FC7464;position:relative;bottom:25px;right:20px;float:right;'>*</b>";                   
                }
                tableList += "</td></tr>";
                $("#atlasList").append(tableList);
                oElememt = $("#UploadImg" + index);
            }

            if (item[i].FileName) {
                Mimi = "(mini)" + item[i].FileName;
                var oImg = "<br /><a id='Atlas" + i + "' class='dowebok'\>"
                    + "<img data-original='../../" + item[i].URL + "' src='../../" + item[i].URL.replace(item[i].FileName, Mimi) + "' width='150px' height='150px' title='查看大图'/></a><br />"
                    + item[i].FileName
                    + "<br />"
                    + "<a onclick=\"DeleteImg('" + item[i].UploadFileID + "','" + item[i].OwnerID + "','" + item[i].CorrelationID + "','" + index + "');return false;\" title=\"删除\" href=\"\">"
                    + "<i class='fa fa-trash-o'></i></a>"
                    + "</a>"
                    + "<a id=\"DownloadImg" + i + "\" onclick=\"DownloadImg('" + item[i].UploadFileID + "');return false;\" title=\"下载\" href=\"\">"
                    + "<i class='fa fa-download'></i></a>";
            } else {
                oImg = "未上传文件!";
            }
            oElememt.append(oImg);
            $('#Atlas' + i).viewer({
                url: 'data-original',
            });
        }      
        AtlasFileUpaction(data);   
    }

    //function previewImg(data){
    //    var Date=JSON.parse(data)[4];
    //    for(var i=0;i<Date.length;i++){   
    //        var index=i           
    //        $("#oimglink" + i).click(function (a) {
    //            var index = $(this).attr("link-index");
    //            var ourl = "../../" + Date[index].URL;
    //            onImg(ourl);
    //        });
    //    }     
    //};

    //图集相关操作
    function AtlasFileUpaction(data) {
     
        var Data = JSON.parse(data);
        var AtlasData = JSON.parse(data)[4];
        var AtlasFileCount = JSON.parse(data)[4].length;
        var AtlasID = "";
        var AtlasName = "";
        var index = 0;
        for (j = 0; j < AtlasFileCount; j++) {
            if (AtlasData[j].AtlasID != AtlasID) {
                index += 1;
                AtlasID = AtlasData[j].AtlasID;
                AtlasName = AtlasData[j].CorrelationName;

                $(".ImgUpAppendix" + index).fileinput({
                    showPreview: true,
                    showClose: false,
                    language: "zh",
                    theme: "fa",
                    uploadUrl: "../Mutual/Declaration.ashx?Action=ImportAtlas",
                    maxFileCount: AtlasData[j].AmountLimit,
                    maxFileSize: AtlasData[j].SizeLimit ? AtlasData[j].SizeLimit * 1024 : 1024,
                    uploadAsync: true,
                    allowedFileExtensions: ["png", "gif", "jpg"],
                    uploadExtraData: {
                        "AtlasName": AtlasName,
                        "DeclarationCode": Data[0].DeclarationCode,
                        "DeclarationID": Data[0].DeclarationID,
                        "AtlasID": AtlasID,
                        "ID": index
                    }
                });

                $('.ImgUpAppendix' + index).on('fileuploaded', function (event, data) {
                    if (data.response == 1) {
                        console.log(data)
                        ShowMessag('超过图集设置数量,不可继续上传');
                    }
                    else {
                        var FileData = (data.response).split(",");
                        var OwnerID = FileData[0];
                        var CorrelationID = FileData[1];
                        var UploadFileID = FileData[2];
                        $.ajax({
                            url: '../Mutual/Declaration.ashx',
                            type: "post",
                            async: false,
                            data: {
                                "Action": "GetAtlas",
                                "OwnerID": OwnerID,
                                "CorrelationID": CorrelationID,
                                "ID": UploadFileID
                            },
                            success: function (data) {
                                data = JSON.parse(data);
                                $("#UploadImg" + UploadFileID).html(data);
                                $('.dowebok').viewer({
                                    url: 'data-original',
                                });
                            }
                        });
                    }
                });
            }
        }      
    } 

    //下载图片
    function DownloadImg(UploadFileID) {
        DownloadFile(UploadFileID);
        //var form = $("<form>");   //定义一个form表单
        //form.attr('style', 'display:none');   //在form表单中添加查询参数
        //form.attr('target', '');
        //form.attr('method', 'post');
        //form.attr('action', "../Declaration/DeclarationList.aspx?UploadFileID=" + UploadFileID);
        //var input1 = $('<input>');
        //input1.attr('type', 'hidden');
        //$('body').append(form);  //将表单放置在web中
        //form.append(input1);   //将查询参数控件提交到表单上
        //form.submit();
    }

    //删除图片
    function DeleteImg(UploadFileID, OwnerID, CorrelationID, ID) {
        ShowMessags('是否删除此图片？')
        $('.layui-layer-btn0').on('click', function () {
            $.ajax({
                url: '../Mutual/Declaration.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "DeleteUploadFile",
                    "UploadFileID": UploadFileID,
                    "OwnerID": OwnerID
                },
                success: function (data) {
                    $.ajax({
                        url: '../Mutual/Declaration.ashx',
                        type: "post",
                        async: false,
                        data: {
                            "Action": "GetAtlas",
                            "OwnerID": OwnerID,
                            "CorrelationID": CorrelationID,
                            "ID": ID
                        },
                        success: function (data) {
                            data = JSON.parse(data);
                            if (data == "") {
                                $("#UploadImg" + ID).html("未上传文件");
                            }
                            else {
                                $("#UploadImg" + ID).html(data);
                            }
                            
                        }
                    });
                }
            });

        });
    }

    function PrepLoadFile(UploadFileID) {
        $.ajax({
            url: '../Mutual/Common.ashx',
            type: "post",
            async: false,
            data: { "Action": "PrepLoadFile", "UploadFileID": UploadFileID },
        });
    }

    //视频集table
    function InitMedia(data) {
        $("#Media").show()
        var MediaData = JSON.parse(data)[6];
        for (var i = 0; i < MediaData.length; i++) {
            var name = MediaData[i].FileName ? MediaData[i].FileName : "---"
            if (MediaData[i].SizeLimit) {
                var SizeLimitText = MediaData[i].SizeLimit * 1 >= 1024 ? "文件最大"
                    + Math.floor((MediaData[i].SizeLimit / 1024) * 100) / 100 + "G" : "文件最大" + MediaData[i].SizeLimit + "M"
            } else {
                var SizeLimitText = "";
            }           

            var CorrelationName = MediaData[i].CorrelationName ? MediaData[i].CorrelationName : "---"
            if (MediaData[i].URL) {
                var mediafile = "<a id='LoadFile" + i + "' > " + name + "</a><p><a class='DeleteAppendix' onclick='DeleteMedia("
                    + MediaData[i].UploadFileID + ","
                    + i + ");return false;' title='删除' href=''>"
                    + "<i class='fa fa-trash-o'></i></a><a class='DownloadAppendix' onclick=\"DownloadMedia("
                    + MediaData[i].UploadFileID + ");return false;\" title='下载' href=''><i class='fa fa-download'></i></a>"
                    + "<a class='mediaplay' onclick=\"initplayer('"
                    + MediaData[i].URL.replace(/\\/g, "/") + "','" + name + "')\"><i class='fa fa-play-circle' aria-hidden='true'></i></a>"
                    + "</p>";
            } else {
                var mediafile = "未上传文件！"
            }

            var index = i + 1;
            var item = "<tr>";
            item += "<td>" + index + "</td>";
            item += "<td>" + CorrelationName + "<br/>" + SizeLimitText + "</td>";
            item += "<td id='UploadMedia" + i + "'>" + mediafile + "</td>";
            item += "<td><label class='control-label'>请选择文件</label><input  name='FileUpExcel' type='file' class='MediaUpAppendix" + i + "' />";
            if (MediaData[i].IsRequired == true) {
                item += "<b style='color:#FC7464;position:relative;bottom:25px;right:20px;float:right;'>*</b>";
            }
            item += "</td><tr/>"
            $("#Media").append(item);
        }
        mediaUpAction(data);
    }

    //视频集相关操作
    function mediaUpAction(data) {
        var Data = JSON.parse(data);
        var MediaData = JSON.parse(data)[6];       
        var MediaFileCount = MediaData.length;
        for (j = 0; j < MediaFileCount; j++) {
            $(".MediaUpAppendix" + j).fileinput({
                showPreview: false,
                language: "zh",
                theme: "fa",
                maxFileSize: MediaData[j].SizeLimit * 1024,
                uploadUrl: "../Mutual/Declaration.ashx?Action=ImportMedia",
                allowedFileExtensions: ["MP4", "AVI", "wma"],
                uploadAsync: true,
                uploadExtraData: {
                    "MediaName": MediaData[j].CorrelationName,
                    "DeclarationCode": Data[0].DeclarationCode,
                    "DeclarationID": Data[0].DeclarationID,
                    "MediaID": MediaData[j].MediaID,
                    "ID": j
                },
            });
           
        }

        for (j = 0; j < MediaFileCount; j++) {
            $('.MediaUpAppendix' + j).on('fileerror', function (event, data, msg) {
                alert(msg);
            });
            $('.MediaUpAppendix' + j).on('fileuploaded', function (event, data) {
                if (data.response == 1) {
                    ShowMessag('上传文件大小超过设置范围内!');
                }
                else {
                    var FileData = (data.response).split(",");
                    var OwnerID = FileData[0];
                    var CorrelationID = FileData[1];
                    var UploadFileID = FileData[2];
                   
                    $.ajax({
                        url: '../Mutual/Declaration.ashx',
                        type: "post",
                        async: false,
                        data: {
                            "Action": "GetMedia",
                            "OwnerID": OwnerID,
                            "CorrelationID": CorrelationID,
                            "ID": UploadFileID
                        },
                        success: function (data) {
                            data = JSON.parse(data);
                             console.log(data)
                            $("#UploadMedia" + UploadFileID).html(data);
                        }
                    });
                }
            });
        }
    }

    //删除视频集
    function DeleteMedia(UploadFileID, ID) {
        DeleteFile(UploadFileID, "UploadMedia" + ID, "是否删除此视频？");

        //ShowMessags('是否删除此视频？')
        //$('.layui-layer-btn0').on('click', function () {
        //    $.ajax({
        //        url: '../Mutual/Declaration.ashx',
        //        type: "post",
        //        async: false,
        //        data: {
        //            "Action": "DeleteUploadFile",
        //            "UploadFileID": UploadFileID
        //        },
        //        success: function (data) {
        //            data = JSON.parse(data);
        //            $("#UploadMedia" + ID).html(data);
        //        }
        //    });
        //});
    }

    //下载视频
    function DownloadMedia(UploadFileID) {
        DownloadFile(UploadFileID);

        //var form = $("<form>");   //定义一个form表单
        //form.attr('style', 'display:none');   //在form表单中添加查询参数
        //form.attr('target', '');
        //form.attr('method', 'post');
        //form.attr('action', "../Declaration/DeclarationList.aspx?UploadFileID=" + UploadFileID);
        //var input1 = $('<input>');
        //input1.attr('type', 'hidden');
        //$('body').append(form);  //将表单放置在web中
        //form.append(input1);   //将查询参数控件提交到表单上
        //form.submit();
    }

    //初始化模态框
    function initmodal() {
        //显示模态框
        $('#myModal').modal('show');

        //监听模态框关闭事件
        $('#myModal').on('hidden.bs.modal', function (e) {            
            var myPlayer = videojs('my-video');
            videojs("my-video").ready(function () {
                var myPlayer = this;
               //模态框关闭停止播放
                myPlayer.pause();
            });

        })
    }

    // 初始化player
    function initplayer(url,name) {
        initmodal();
         console.log("url==" + url + "name==" + name)
        //模态框标题
        $("#myModalLabel").text(name)
        var oSrc ="../../" + url
        console.log("oSrc==" + oSrc)
		var myPlayer = videojs('my-video');
        videojs("my-video").ready(function(){
            var myPlayer = this;
            myPlayer.src(oSrc);
            myPlayer.load(oSrc);
            myPlayer.play();           
        });
    }

    $(function () {
        //$('#pageContent').on('click', '.closes', function (e) {
            //e.stopPropagation();//阻止冒泡 
            //$('#pageContent').removeClass('show').css({ 'z-index': '-1' });
       // });
    
        $('#AppendixTable').find('br').remove();
        $('#AppendixTable').find('hr').remove();

        if ($("#txtSituation").val() == "ExpertReview") {
            $(".DeleteAppendix").css("display", "none");
            $(".DeleteImg").css("display", "none");
            $(".DownloadAppendix").css("margin-left", "-120px");
            $(".DownloadImg").css("margin-left", "-120px");
        }  
    });

</script>