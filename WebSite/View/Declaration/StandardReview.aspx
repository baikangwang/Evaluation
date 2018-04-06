<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="StandardReview.aspx.cs" Inherits="Evaluation.View.Declaration.StandardReview"  validateRequest="false"%>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/ParticipantReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/AppendixReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStatesReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/CertificateReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/Css/Declaration.css" rel="stylesheet" />

    <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css" />
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>
    <script type="text/javascript" charset="utf-8" src="../../Content/Javascript/DeclarationReview.js"></script>
   
    <%--UEditor--%>
    <script src="../../Content/plugins/ueditor/ueditor.config.js"></script>
    <script src="../../Content/plugins/ueditor/ueditor.all.js"></script>
    <script src="../../Content/plugins/ueditor/lang/zh-cn/zh-cn.js"></script>

    <style>
        table {
            border: none;
            border-collapse: collapse;
            width: 90%;
            margin: 0px auto;
        }

            table tr {
                border: none;
            }

                table tr td {
                    border: 1px solid;
                    padding: 10px 5px 5px 5px;
                    text-align: center;
                    line-height: 25px;
                    height: 25px;
                }

                    table tr td table {
                        border: none;
                    }

                        table tr td table tr {
                            border: none;
                        }

                        table tr td table td {
                            border-left: none;
                            border-top: none;
                            text-align: center;
                            border-bottom: none;
                        }

        #divfather {
            margin-top: 20px;
        }

        .shejidanwei {
            width: 100%;
        }

            .shejidanwei tr td {
                border-top: 1px solid;
            }

        input {
            border-style: solid;
            border-color: rgba(128, 128, 128,0.5);
            border-width: 1px;
            height: 25px;
        }

            input[type="text"] {
                padding: 0px 0px !important;
            }

        #teshutable {
            width: 50%;
        }

        .nav-tabs > li.active > a, .nav-tabs > li.active > a:hover, .nav-tabs > li.active > a:focus {
            color: #FFF;
            background-color: #30b9cb;
            border: 1px solid #30b9cb;
            border-bottom-color: transparent;
        }

        .nav-tabs {
            border-bottom: 2px solid #30b9cb;
        }

            .nav-tabs > li > a:hover {
                border-color: #30b9cb;
                color: #FFF;
                background: #30b9cb;
            }

        .nav > li > a:hover, .nav > li > a:focus {
            text-decoration: none;
        }

        a:hover {
            color: #fff;
            text-decoration: none;
            background-color: #30b9cb;
        }

        #ContentPlaceHolder1_divfather {
            margin-top: 20px;
        }

        legend {
            border-bottom: 0px;
            text-align: center;
        }

        #ContentPlaceHolder1_divfather table {
            margin: 0px auto;
        }

        #panelPart_0101 fieldset table ul.ui-choose > li.selected {
            border-color: #30b9cb;
            background-color: #30b9cb;
            color: #fff;
        }

        #panelPart_0101 fieldset table ul.ui-choose > li:hover {
            border-color: #30b9cb;
        }

        input {
            text-align: center;
        }

        .ui-choose {
            margin-left: 15px;
        }

        #btab2 table input {
            width: 82%;
        }

        #btab2 table select {
            margin-left: 5px;
        }

        #ContentPlaceHolder1_Appendix_panelAppendix textarea {
            margin: 0px auto;
        }

        #ContentPlaceHolder1_LegalStates_TextBox273 {
            margin-left: 28px;
            width: 56%;
        }

        #GroundLayer_Less6, #UndergroundLayer_Less6, #Height_Less6, #Count_Less6 {
            float: none;
        }

        #edui1_iframeholder {
            height: 300px;
        }

        #btn_018Prev {
            margin-left: 43%;
            margin-top: 40px;
        }

        #AcceptanceDepartment {
            float: none !important;
        }

        #AcceptanceDepartment {
            margin-left: 26px;
        }

        #ContentPlaceHolder1_ddlProjectSource {
            width: 92%;
            margin-left: 10px;
            height: 25px;
            margin-bottom: 7px;
        }

        #content #test {
            height: 2500px !important;
        }

        /*#PrimaryCoverageTextBox, #BenefitsTextBox, #AwardsTextBox, #UnitOpinionTextBox, #RecommendOpinionTextBox {
            text-align: left;
        }*/
         #AppendixTable  td a,#AtlasTable  td a{
            margin:0 0.5em
        }
          /*#AwardsTextBox,#PrimaryCoverageTextBox,#BenefitsTextBox{
            width:85%;
        }*/
        .review {
            text-align: left;width:85%;
        }
        .review.edui-editor.edui-default{
            z-index:1!important; border:none!important;background-color:#eee!important;
        }
        .review.edui-editor-toolbarboxouter.edui-default{
            height:0px;
        }
        .reivew.edui-default .edui-editor-bottomContainer td{
            border-top:none!important;border-right:none;
        }
        .review.edui-default .edui-editor-toolbarboxouter{
            border-bottom:none!important;
        }     
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display: none">
        <asp:Label  runat="server"  ClientIDMode="Static" ID="txtSituation"></asp:Label>
    </div>
    <div style="display: none">
        <asp:Label  runat="server"  ClientIDMode="Static" ID="txtUser"></asp:Label>
    </div>
    <div style="display: none">
          <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox>
    </div>
    <div style="display: none">
        <asp:Label  runat="server"  ClientIDMode="Static" ID="txtTemplate" ></asp:Label>
    </div>
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a><a href="../Declaration/Declare.aspx?SepcCode=170000" id="nav02" runat="server" clientidmode="Static"></a><a href="#" id="nav03"></a>
        </li>
    </ul>

    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、申报表</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、项目特点</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、附件目录</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、法人声明</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、合作声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab" class="ExpertReviewList2" style="display: none;">7、评审意见</a></li>
        </ul>
        <div class="tab-content"  id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_1701"   GroupingText="北京市优秀工程勘察设计地方标准（标准设计）申报表">
                    <table>
                        <tr>
                            <td>标准（标准设计）名称
                            </td>
                            <td style="width:330px;">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="StandardName"   Width="94%"></asp:Label>
                            </td>
                            <td style="width:150px;">标准（标准设计）编号
                            </td>
                            <td >
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="StandardCode"   Width="93%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>主编单位
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ChiefEditorUnit"   Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">参编单位</td>
                            <td>单位名称</td>
                            <td colspan="2">承担工作</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit1"   Width="94%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndertakeWork1"   Width="95%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit2"   Width="94%" ></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndertakeWork2"   Width="95%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td >
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit3"   Width="94%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndertakeWork3"   Width="95%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td onclick="Sensitize2('CooperativeUnit4','UndertakeWork3')">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit4"   Width="94%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndertakeWork4"   Width="95%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>编制起止时间
                            </td>
                            <td>
                                <div>
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="StartDate"></asp:Label><span style="padding:0 0.5em">至</span>
                                      <asp:Label  runat="server"  ClientIDMode="Static" ID="EndDate"></asp:Label>
                                </div>
                               
                            </td>
                            <td>项目来源
                            </td>
                            <td id="tdProjectSource">
                                <div class="DeclarationList" >
                                <asp:Label  runat="server"  ClientIDMode="Static"  ID="ProjectSource" class="ddlProjectSource" >
                                </asp:Label>
                                </div>
                                 <div class="ExpertReviewList" style="display: none">
                                     <asp:Label  runat="server"  ClientIDMode="Static" ID="txtProjectSource"   Style="width: 88%;"></asp:Label>
                                 </div>  
                                <div id="Others" style="display: none;"  >
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="ProjectSourceOther"   Width="88%"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>批准立项文件号
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ApprovalNumber"   Width="94%"></asp:Label>
                            </td>
                            <td>批准实施文件号
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ImplementNumber"   Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位通讯地址
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PostalAddress"   Width="96.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位联系人
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Linkman"   Width="94%"></asp:Label>
                            </td>
                            <td>手机
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="MobileNumber"   Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>电话号码
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TelephoneNumber"   Width="94%"></asp:Label>
                            </td>
                            <td>传真号码
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="FaxNumber"   Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Postcode"   Width="94%"></asp:Label>
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="EmailAddress"   Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px">曾获奖项
                            </td>
                            <td colspan="3">
                               <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                               <script id="AwardsTextBox" class ="review" type="text/plain" style="height: 300px;"></script>                               
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant  ID="ParticipantReview" runat="server"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_1702"   GroupingText="标准（标准设计）项目特点">
                    <table>
                            <tr>
                            <td style="width: 150px;">标准（标准设计）主要内容
                            </td>
                            <td>
                                <asp:TextBox ID="PrimaryCoverage" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="PrimaryCoverageTextBox" class ="review" type="text/plain" style="height: 300px;"></script>                                
                            </td>
                        </tr>
                        <tr>
                            <td>标准（标准设计）主要优缺点和效益
                            </td>
                            <td>
                                <asp:TextBox ID="Benefits" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="BenefitsTextBox" class ="review" type="text/plain" style="height: 300px;"></script>                                
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab4">
                <uc:Appendix runat="server" ID="AppendixReview"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab5">
                <uc:LegalStates runat="server" ID="ucLegalStatesReview"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab6">
                <uc:Certificate runat="server" ID="ucCertificateReview"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab7">
                <uc:Comments runat="server" ID="ucComments"></uc:Comments>
            </div>
        </div>
    </div>
     <script type="text/javascript">
         function setData(data) {
             data = JSON.parse(data)[1];           
             for (var i = 0; i < data.length; i++) {
                 var oval;
                 if (data[i].RecordType == "select") {
                     oval = data[i].ConstantValue ? data[i].ConstantValue : "---";
                 } else {
                     oval = data[i].Data ? data[i].Data : "---";
                 }
                 var element = "#" + data[i].RecordNameEn;
                 $(element).html(oval);
             }
             for (var j = 1; j < 5; j++) {
                 if ($('#CooperativeUnit' + j).text() == "---") {
                     $('#DomesticOrAbord' + j).text("---");
                 }
             }
         }
         //function setPart2Data(data) {
         //    var ParticipantLimit = JSON.parse(data)[0].ParticipantLimit
         //    $("#PeopleNum").text(ParticipantLimit)
         //    data = JSON.parse(data)[2];
         //    console.log(data)
         //    if (data) {
         //        var times = ParticipantLimit ? ParticipantLimit : data.length;
         //        $("#tblist").empty();
         //        for (var i = 0; i < times; i++) {
         //            var index = i + 1;
         //            var ParticipantName = data[i] ? data[i].ParticipantName : "";
         //            var AcademicTitle = data[i] ? data[i].AcademicTitle : "";
         //            var Speciality = data[i] ? data[i].Speciality : "";
         //            var Duties = data[i] ? data[i].Duties : "";
         //            var IDTypeName = data[i] ? data[i].IDTypeName : "";
         //            var IDNumber = data[i] ? data[i].IDNumber : "";
         //            var Workplace = data[i] ? data[i].Workplace : "";
         //            var item = "<tr>" +
         //                "<td>" + index + "</td>" +
         //                "<td>" + ParticipantName + "</td>" +
         //                "<td>" + AcademicTitle + "</td>" +
         //                "<td>" + Speciality + "</td>" +
         //                "<td>" + Duties + "</td>" +
         //                "<td>" + IDTypeName + "</td>" +
         //                "<td>" + IDNumber + "</td>" +
         //                "<td>" + Workplace + "</td>" +
         //                "<tr>"
         //            $("#tblist").append(item);

         //        }
         //    }
         //}
         function setPart5Data(data) {
             data = JSON.parse(data)[0];
             var LegalPeopleName = data.LegalPersonName ? data.LegalPersonName : "";
             var LegalPeopleNumber = data.LegalPersonIDNo ? data.LegalPersonIDNo : "";             
             $("#LegalPeopleName").text(LegalPeopleName);
             $("#LegalPeopleNumber").text(LegalPeopleNumber);
         }
         function setPart6Data(data) {
             var data1 = JSON.parse(data)[0];
             var data2 = JSON.parse(data)[5];
             $("#DivisionTablewarp").hide()
             $("#DivisionTable2warp").show()
             //合作勘察设计项目合作声明
             $("#DeclarationName6").text(data1.DeclarationName);
             $("#DeclarationUnit6").text(data1.OrganizationName);
             $("#uPrize6").text(data1.PrizeName);
             for (var i = 0; i < data2.length; i++) {
                 var index = i + 1
                 var oUnittext = data2[i].勘察设计单位
                 var oWorktext = data2[i].承担工作
                 $("#txtCooperationUnit" + index).text(oUnittext);
                 $("#txtUndertakeWork" + index).text(oWorktext)
             }
         }
         //附件目录
         ////function setPart8Data(data) {
         ////    var EnclosureData = JSON.parse(data)[3];
         ////    console.log(EnclosureData)
         ////    var ImageData = JSON.parse(data)[4];
         ////    console.log(ImageData)
         ////    //附件
         ////    if (EnclosureData.length > 0) {
         ////        $("#Enclosurelist").empty()
         ////        for (var i = 0; i < EnclosureData.length; i++) {
         ////            var index = i + 1;
         ////            if (EnclosureData[i].URL) {
         ////                var oUrl = "../../" + EnclosureData[i].URL.replace(/\\/g, "/")
         ////            } else {
         ////                var oUrl = ""

         ////            }
         ////            if (EnclosureData[i].FileName) {
         ////                var fileName = EnclosureData[i].FileName
         ////                var oIcon = "<i class='fa fa-download'></i>"

         ////            } else {
         ////                var fileName = "---"
         ////                var oIcon = ""
         ////            }
         ////            var item = "<tr>" +
         ////                  "<td>" + index + "</td>" +
         ////                  "<td>" + fileName + "</td>" +
         ////                  "<td>" +
         ////                  "<a href= '" + oUrl + "' download=" + fileName + ">" + fileName + "</a>" +
         ////                  "<a href='" + oUrl + "' download=" + fileName + ">" + oIcon + "</a>" +
         ////                  "</td>" +
         ////                  "<tr>"

         ////            $("#Enclosurelist").append(item);

         ////        }
         ////    } else {
         ////        $("#Appendix").hide();
         ////        $("#AppendixTable").append("<div style='border:1px solid #777; text-align:center;width:90%;padding:5px'>该专业下暂无附件集目录！</div>")
         ////    }

         //    //图集
         //    if (ImageData.length > 0) {
         //        $("#Imagelist").empty()
         //        var orderNum = 0;
         //        for (var i = 0; i < ImageData.length; i++) {

         //            var CorrelationID = ImageData[i].CorrelationID ? "Correlation" + ImageData[i].CorrelationID : "CorrelationID_" + i;
         //            var element = $("#" + CorrelationID)
         //            if (ImageData[i].URL) {
         //                var oUrl = "<br/><img src='../../" + ImageData[i].URL.replace(/\\/g, "/") + "' width='150px'/><br/>" +
         //                "<span>" + ImageData[i].FileName + "</span>" +
         //                "<a href='../../" + ImageData[i].URL.replace(/\\/g, "/") + "' download=" + ImageData[i].FileName + "><i class='fa fa-download'></i></a>"
         //            } else {
         //                var oUrl = "--"

         //            }
         //            if (element && element.length >= 1) {
         //                $("#" + CorrelationID).append(item);
         //            } else {
         //                orderNum = orderNum + 1;
         //                var item = "<tr>" +
         //                    "<td>" + orderNum + "</td>" +
         //                    "<td>" + ImageData[i].CorrelationName + "</td>" +
         //                    "<td id=" + CorrelationID + ">" + oUrl + "</td>" +
         //                "<tr>"
         //                $("#Imagelist").append(item);

         //            }
         //        }
         //    } else {
         //        $("#Atlas").hide();
         //        $("#AtlasTable").append("<div style='border:1px solid #777; text-align:center;width:90%;padding:5px'>该专业下暂无图集目录！</div>")
         //    }

         //}
                
         $(function () {
             $("#tbAppendix>tr>td:last").hide();
             //重置页面顺序
             $("#AppendixPrev").click(function () {
                 onPrev("04");
             });
             $("#AppendixNext").click(function () {
                 onNext("04");
             });
             $("#LegalStatesPrev").click(function () {
                 onPrev("05");
             });
             $("#LegalStatesNext").click(function () {
                 onNext("05");
             });
             $("#CertificatePrev").click(function () {
                 onPrev("06");
             });
             $("#CertificateNext").click(function () {
                 onNext("06");
             });
             $("#CommentsPrev").click(function () {
                 onPrev("07");
             });

             $.ajax({
                 type: "post",
                 url: "../Mutual/Declaration.ashx",
                 async: false,
                 data: {
                     "Action": "GetData",
                     "DeclarationID": $("#txtDeclarationID").val(),
                 },
                 success: function (data, status) {
                     var DeclarationName = JSON.parse(data)[0].DeclarationName ? JSON.parse(data)[0].DeclarationName : "---"
                     var PrizeName = JSON.parse(data)[0].PrizeName ? JSON.parse(data)[0].PrizeName : "---"
                     setNav3(DeclarationName, PrizeName)
                     setData(data);
                     setPart2Data(data);
                     setPart5Data(data);
                     setPart6Data(data);
                     setPart8Data(data)
                 }
             });

             InitUEditor('PrimaryCoverageTextBox', 1000);                               // 标准（标准设计）主要内容
             InitUEditor('BenefitsTextBox', 1000);                                      // 标准（标准设计）主要优缺点和效益
             InitUEditor('AwardsTextBox', 500);                                        // 曾获奖项
         })
         // 初始化富文本框
         function InitUEditor(container, max) {
             var text = $("#" + container.replace("TextBox", ""));
             text.hide();
             var ue = UE.getEditor(container, {
                 wordCount: false,
                 autoHeightEnabled: true,
                 readonly: true,
                 autoHeightEnabled :false,
                 toolbars: [[]]
             });
             ue.ready(function () {
                 //设置编辑器的内容
                 ue.setContent(text.val());
             });
         }
    </script> 
</asp:Content>
