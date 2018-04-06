<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AppendixReview.ascx.cs" Inherits="Evaluation.View.Declaration.AppendixReview" %>
    <script src="../../Content/plugins/zoom/js/viewer-jquery.min.js"></script>  
    <link href="../../Content/plugins/zoom/css/viewer.min.css" rel="stylesheet" />
    <script src="../../Content/plugins/video5.18.4.js/js/videojs-ie8.min.js"></script>
    <script src="../../Content/plugins/video5.18.4.js/js/video.min.js"></script>
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/video5.18.4.js/css/video-js.css"/>	
<style>
    .closes {
        width: 40px;
        height: 40px;
        background: #000;
        border-radius: 50%;
        background-size: 100%;
        position: absolute;
        top: 20px;
        right: 20px;
        cursor: pointer;
        color: #fff;
        text-align: center;
        font-size:30px;
        z-index: 20000;
        line-height:35px;
    }

    #pageContent {
        width: 1200px;
        height: 600px;
        overflow: hidden;
        position: absolute;
        top: 0;
        bottom: 0;
        left: 0;
        right: 0;
        opacity: 0;
        margin: auto;
        z-index:-1;
    }

    #imgContainer {
        width: 1200px;
        height: 600px;
    }
 
    .zoomableContainer {
        background: rgba(0,0,0,0.5);
        border-radius: 4px;
    }

    .show {
        opacity: 1 !important;
    }
    #imageFullScreen{
       min-height:400px;
    }
     .modal-dialog{
        width:500px;
    }
    #my-video{
        width:320px;
        height:240px;
        margin:0 auto;
    }
     .fa{
        padding:0 0.5em;

    }
   
</style>    
<asp:Panel ID="panelAppendix" runat="server" ClientIDMode="Static" >
    <h2 style="text-align:center">附件目录</h2>
    <h3>1.附件集</h3>
    <div style="margin:0px auto" id="AppendixTable" >
        <table id="Appendix">
            <tr>
                <td style="width:5%">顺序</td>
                <td  style="width:25%">附件名称</td>
                <td  style="width:70%">附件</td>
            </tr>
            <tbody id="oEnclosurelist">
            </tbody>
        </table>
    </div>
    <h3>2.图集</h3>
    <div style="margin:0px auto" id="AtlasTable">
        <table id="Atlas">
            <tr>
                <td style="width:5%">顺序</td>
                <td  style="width:25%">图集名称</td>
                <td  style="width:70%">图片</td>
            </tr>
            <tbody id="atlasList">

            </tbody>
        </table>

    </div>
    <h3>3.视频</h3>
    <div style="margin:0px auto" id="MediaTable"  >
         <table style="text-align:center;display:none" id="Media">
            <tr>
                <td style="width:5%">顺序</td>
                <td style="width:25%">视频集名称</td>
                <td style="width:70%">视频</td>
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
    <div id="pageContent">	       
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
    <script>
        
        //附件目录
        function setPart8Data(data) {
            var EnclosureData = JSON.parse(data)[3];
            var ImageData = JSON.parse(data)[4];
            var MediaData = JSON.parse(data)[6];
            console.log(JSON.parse(data))
            //附件
            if (EnclosureData.length > 0) {
                $("#oEnclosurelist").empty()
                for (var i = 0; i < EnclosureData.length; i++) {
                    var index = i + 1;
                    var CorrelationName = EnclosureData[i].CorrelationName?EnclosureData[i].CorrelationName:"---"
                    if (EnclosureData[i].FileName) {
                        var FileName = "<a id=LoadFile" + i + " href='../../" + EnclosureData[i].URL.replace(/\\/g, "/")
                            + "' download=" + EnclosureData[i].FileName + " >" + EnclosureData[i].FileName + "</a>"
                            + "<p><a class='DownloadAppendix'  href='../../" + EnclosureData[i].URL.replace(/\\/g, "/")
                            + "' download=" + EnclosureData[i].FileName + "><i class='fa fa-download'></i></a>"
                            + "</p>";
                    } else {
                        var FileName = "未上传文件!";
                    }
                    var Enclosureitem = "<tr>"
                        + "<td>" + index + "</td>"
                        + "<td>" + CorrelationName + "</td>"
                        + "<td id='UploadFile" + i + "'>" + FileName + "</td>"
                        + "</tr>";
                    $("#oEnclosurelist").append(Enclosureitem);
                }
            } else {
                $("#Appendix").hide();
                $("#AppendixTable").append("<div style='border:1px solid #777; text-align:center;width:90%;padding:5px;margin:0 auto;'>该专业下暂无附件集目录！</div>");
            }

            //图集
            if (ImageData.length > 0) {
                $("#Atlas").show()
                var item = ImageData
                var AtlasID = "";
                var AtlasName = "";
                var tableList = "";
                var index = 0;
                var oElememt;
                var oImg;
                var Mimi = "";
                $("#atlasList").empty();
                for (var i = 0; i < item.length; i++) {
                    if (item[i].AtlasID != AtlasID) {
                        index += 1;
                        AtlasID = item[i].AtlasID;
                        AtlasName = item[i].CorrelationName;
                        tableList = "<tr>"
                            + "<td>" + index + "</td>"
                            + "<td>" + item[i].CorrelationName + "</td>"
                            + "<td id='UploadImg" + index + "' name=" + AtlasName + AtlasID + " class='oPic'></td>"
                            + "</tr>";
                        $("#atlasList").append(tableList);
                        oElememt = $("#UploadImg" + index);
                    }
                    if (item[i].FileName) {
                        Mimi = "(mini)" + item[i].FileName;
                        var oImg = "<br /><a id='Atlas" + i + "' class='dowebok'\>"
                            + "<img data-original='../../" + item[i].URL + "' src='../../" + item[i].URL.replace(item[i].FileName, Mimi) + "' width='150px' height='150px' title='查看大图'/><br />"
                            + item[i].FileName
                            + "<br />"                           
                            + "<a id=\"DownloadImg" + i + "\" href='../../" + item[i].URL.replace(/\\/g, "/") + "' download=" + item[i].FileName + ");return false;\" title=\"下载\" href=\"\">"
                            + "<i class='fa fa-download'></i></a>";
                    } else {
                        oImg = "未上传文件!";
                    }
                    oElememt.append(oImg);
                    $('#Atlas' + i).viewer({
                        url:'data-original',
                    });
                }               
            } else {
                $("#Atlas").hide();
                $("#AtlasTable").append("<div style='border:1px solid #777; text-align:center;width:90%;padding:5px;margin:0 auto;'>该专业下暂无图集目录！</div>");
            }

            //视频
            if (MediaData.length > 0) {
                $("#Media").show();
                var MediaData = JSON.parse(data)[6];
                for (var i = 0; i < MediaData.length; i++) {
                    var name = MediaData[i].FileName ? MediaData[i].FileName : "---";
                    var CorrelationName = MediaData[i].CorrelationName ? MediaData[i].CorrelationName : "---";
                    if (MediaData[i].URL) {
                        var mediafile = "<a id='LoadFile" + i + "' > " + name + "</a><p><a class='DownloadAppendix' onclick=\"DownloadMedia("
                            + MediaData[i].UploadFileID + ");return false;\" title='下载' href=''><i class='fa fa-download'></i></a>"
                            + "<a class='mediaplay' onclick=\"initplayer('"
                            + MediaData[i].URL.replace(/\\/g, "/") + "','" + name + "')\"><i class='fa fa-play-circle' aria-hidden='true'></i></a>"
                            + "</p>";
                    } else {
                        var mediafile = "未上传文件！"
                    }
                    var index = i + 1;
                    var Mediaitem = "<tr><td>" + index + "</td>"
                        + "<td>" + CorrelationName + "</td>"
                        + "<td id='UploadMedia" + i + "'>" + mediafile + "</td>"
                        + "</tr>";
                    $("#mediaList").append(Mediaitem);
                }
            } else {
                $("#Media").hide();
                $("#MediaTable").append("<div style='border:1px solid #777; text-align:center;width:90%;padding:5px;margin:0 auto;'>该专业下暂无视频集目录！</div>");
            }
        }

        //下载视频
        function DownloadMedia(UploadFileID) {
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
            });
        }

        //初始化player
        function initplayer(url, name) {
            initmodal();
            // console.log("url==" + url + "name==" + name)
            //模态框标题
            $("#myModalLabel").text(name)
            var oSrc = "../../" + url;
            var myPlayer = videojs('my-video');
            videojs("my-video").ready(function () {
                var myPlayer = this;
                myPlayer.src(oSrc);
                myPlayer.load(oSrc);
                myPlayer.play();
            });
        }
    </script>
</asp:Panel>
