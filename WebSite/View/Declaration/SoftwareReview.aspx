<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="SoftwareReview.aspx.cs" Inherits="Evaluation.View.Declaration.SoftwareReview"  validateRequest="false"%>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/ParticipantReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/AppendixReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStatesReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/CertificateReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" charset="utf-8" src="../../Content/Javascript/DeclarationReview.js"></script>

    <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css" />
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>

    <%--UEditor--%>
    <script src="../../Content/plugins/ueditor/ueditor.config.js"></script>
    <script src="../../Content/plugins/ueditor/ueditor.all.js"></script>
    <script src="../../Content/plugins/ueditor/lang/zh-cn/zh-cn.js"></script>

    <style>
        table{border:none; border-collapse: collapse;width:90%;margin:0px auto}
        table tr{border:none;}
        table tr td{border:1px solid;padding:10px 2px 5px 5px;text-align:center;line-height:25px;height:25px;}
        table tr td table{border:none;}
        table tr td table tr{border:none;}
        table tr td table td{border-left:none;border-top:none;text-align:center;border-bottom:none;} 
        #divfather{
            margin-top:20px;
        }
        .shejidanwei {width:100%; }
        .shejidanwei tr td{border-top:1px solid; } 
        input{border-style: solid ;
              border-color: rgba(128, 128, 128,0.5);
              border-width: 1px;
            
           
              height:25px;
        }
        input[type="text"]{
            padding: 0px 0px !important;
        }
        #teshutable{width:50%;}
       .nav-tabs>li.active>a, .nav-tabs>li.active>a:hover, .nav-tabs>li.active>a:focus{
            color: #FFF;
            background-color: #30b9cb;
            border: 1px solid #30b9cb;
            border-bottom-color: transparent
       }
       .nav-tabs {
            border-bottom: 2px solid #30b9cb;
        }
        .nav-tabs > li > a:hover {
            border-color: #30b9cb;
            color: #FFF;
            background:#30b9cb;
        }
        .nav > li > a:hover, .nav > li > a:focus {
            text-decoration: none;
        }
        a:hover {
            color: #fff;
            text-decoration: none;
            background-color: #30b9cb;
        }
        #ContentPlaceHolder1_divfather{
            margin-top:20px;
        }
        legend{
            border-bottom:0px;
            text-align: center;
        }
        #ContentPlaceHolder1_divfather table{
            margin:0px auto;
        }   
        #panelPart_0101 fieldset table ul.ui-choose>li.selected {
            border-color: #30b9cb;
            background-color: #30b9cb;
            color: #fff;
        }
        #panelPart_0101 fieldset table ul.ui-choose>li:hover {
            border-color: #30b9cb;
        }
        input{
            text-align:center;
        }
        .ui-choose{
            margin-left:15px;
        }
       
        #btab2 table input{
            width:82%;
        }
        #btab2 table select{
            margin-left:5px;
        }
        #ContentPlaceHolder1_Appendix_panelAppendix textarea{
            margin:0px auto;
        }
        #ContentPlaceHolder1_LegalStates_TextBox273{
            margin-left: 28px;
            width: 56%;
            
        }
        #GroundLayer_Less6,#UndergroundLayer_Less6,#Height_Less6,#Count_Less6{
            float:none;
        }
        #edui1_toolbarbox {
            position: initial;
            z-index: 0;
        }

        #edui1 {
            z-index: 0;
        }
        #ueditor,#ueditor2,#ueditor7,#ueditor8{
            text-align:left;
        }
        #edui1_iframeholder{
            height:300px;
        }
        
        #btn_018Prev{
            margin-left: 43%;
            margin-top:40px; 
        }

        #content #test{
            height:2500px!important;
        }
        .textmargin{
            margin-left: 5px;
            float: none!important;
        }
         #AppendixTable  td a,#AtlasTable  td a{
            margin:0 0.5em
        }
           #AwardsTextBox,#OpinionTextBox{
            width:93%;
        }
        #PurposeTextBox{
            width:70%;
        }
         #MainFunctionsTextBox,#ComparisonTextBox,#BenefitsTextBox{
             width:99%;
         }
         .edui-editor.edui-default{
            z-index:1!important; border:none!important;background-color:#eee!important;
        }
        .edui-editor-toolbarboxouter.edui-default{
            height:0px;
        }
        .edui-default .edui-editor-bottomContainer td{
            border-top:none!important;border-right:none;
        }
        .edui-default .edui-editor-toolbarboxouter{
            border-bottom:none!important;
        }     
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a><a href="../Declaration/Declare.aspx?SepcCode=160000" id="nav02" runat="server" clientidmode="Static"></a><a href="#" id="nav03"></a>
        </li>
    </ul>
    <div style="display: none">
        <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox>
      </div>
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
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_1601"   GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 150px;">项目名称
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DeclarationName"   Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>主要设计<br />
                                单位
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DeclarationUnit"   Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">合作单位</td>
                            <td>单位名称</td>
                            <td colspan="2">承担工作</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit1"   Width="92%" onblur="Sensitize('CooperativeUnit1','UndertakeWork1')"></asp:Label>
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit1','UndertakeWork1')">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndertakeWork1"   Width="95%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit2"   Width="92%" onblur="Sensitize('CooperativeUnit2','UndertakeWork2')"></asp:Label>
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit2','UndertakeWork2')">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndertakeWork2"   Width="95%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit3"   Width="92%" onblur="Sensitize('CooperativeUnit3','UndertakeWork3')"></asp:Label>
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit3','UndertakeWork3')">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndertakeWork3"   Width="95%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit4"   Width="92%" onblur="Sensitize('CooperativeUnit4','UndertakeWork4')"></asp:Label>
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit4','UndertakeWork4')">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndertakeWork4"   Width="95%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                通讯地址
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PostalAddress"   Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>单位资质
                            </td>
                            <td style="width: 35%">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Qualification"   Width="92%"></asp:Label>
                            </td>
                            <td style="width: 150px;">证书编号
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CertificateNumber"   Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                联系人
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Linkman"   Width="92%"></asp:Label>
                            </td>
                            <td>电话
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TelephoneNumber"   Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Postcode"   Width="92%"></asp:Label>
                            </td>
                            <td>手机
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="MobileNumber"   Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="EmailAddress"   Width="92%"></asp:Label>
                            </td>
                            <td>传真
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="FaxNumber"   Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>软件开发模式
                            </td>
                            <td colspan="3">
                                <div class="DeclarationList">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="DevelopmentModel"   Width="97%"></asp:Label>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtDevelopmentModel"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>软件类别
                            </td>
                            <td colspan="3">
                                <div class="DeclarationList">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="SoftwareCategory"   Width="97%"></asp:Label>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtSoftwareCategory"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>软件符合哪类现行<br />
                                国家规范
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ConformityNationalNorms"   Width="93%" class="textmargin"></asp:Label>
                            </td>
                            <td>任务来源
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ProjectSource"   Width="93%" class="textmargin"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>开发起止年月
                            </td>
                            <td>
                                <div>
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="StartDate"></asp:Label><span style="padding:0 0.5em">至</span>
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="EndDate" ></asp:Label>

                                </div>
                                
                            </td>
                            <td>试用年月
                            </td>
                            <td>
                                <div>
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="TrialDate" ></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>鉴定部门
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IdentificationDepartment"   Width="93%" class="textmargin"></asp:Label>
                            </td>
                            <td>鉴定时间
                            </td>
                            <td>
                                <div>
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="IdentificationDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>验收部门
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="AcceptanceDepartment"   Width="92%" class="textmargin"></asp:Label>
                            </td>
                            <td>验收时间
                            </td>
                            <td>
                                <div>
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="AcceptanceDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>评测公司
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="EvaluationCompany"   Width="93%" class="textmargin"></asp:Label>
                            </td>
                            <td>评测时间
                            </td>
                            <td>
                                <div>
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="EvaluationDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>软件著作权登记号
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CopyrightRegistrationNumber"   Width="93%" class="textmargin"></asp:Label>
                            </td>
                            <td>著作权人
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CopyrightOwner"   Width="92%" class="textmargin"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>保密级别：
                            </td>
                            <td colspan="3">
                                <div class="DeclarationList">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="SecurityLevel"   Width="97%"></asp:Label>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtSecurityLevel"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">返　回</a>
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant  ID="ParticipantReview" runat="server"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_1602"   GroupingText="工程勘察设计计算机软件项目特点">
                    <table>
                        <tr>
                            <td rowspan="3" style="padding: 10px; width: 10%;">软件环境
                            </td>
                            <td style="padding: 10px; width: 15%;">运行操作系统名称及版本号
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="OsVersion"   Width="96%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>支撑环境名称
                                及 版 本 号
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="SupportEnvironment"   Width="96%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>编程语言名称
                                及 版 本 号
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ProgrammingLanguage"   Width="96%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">适用范围
                            </td>
                            <td>主要适用行业
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ApplicableIndustry"   Width="96%"></asp:Label>
                            </td>
                        </tr>
 <tr>
                            <td>主要用途
                            </td>
                            <td>
                                <asp:TextBox ID="Purpose" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 96%; height: 300px;"></asp:TextBox>
                                <script id="PurposeTextBox" type="text/plain" style="height: 300px;"></script>                                
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: center; padding-left: 10px;">软件主要功能、技术架构及创新概述(限500字)</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:TextBox ID="MainFunctions" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="MainFunctionsTextBox" type="text/plain" style="height: 300px;"></script>                                
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: center; padding-left: 10px;">该软件与当前国内外同类软件的综合比较（包括存在问题及改进措施,限1500字）</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:TextBox ID="Comparison" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="ComparisonTextBox" type="text/plain" style="height: 300px;"></script>                                
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: center; padding-left: 10px;">该软件的经济与社会效益(限500字)</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:TextBox ID="Benefits" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="BenefitsTextBox" type="text/plain" style="height: 300px;"></script>                                
                            </td>
                        </tr>
                    </table>
                    <h3 style="text-align: center;">审批意见</h3>
                    <table>
                        <tr>
                            <td rowspan="1">曾获奖项
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="AwardsTextBox" type="text/plain" style="height: 300px;"></script>                                
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">申报单位<br />
                                意   见
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="Opinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                               <script id="OpinionTextBox" type="text/plain" style="height: 300px;"></script>
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
                <uc:LegalStates runat="server" ID="LegalStatesReview"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab6">
                <uc:Certificate runat="server" ID="CertificateReview"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab7">
                <uc:Comments runat="server" ID="ucComments"></uc:Comments>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        function setData(data) {
            console.log(JSON.parse(data))
            data = JSON.parse(data)[1];        
            for (var i = 0; i < data.length; i++) {
                var oval;
                if (data[i].RecordType == "select") {
                    oval = data[i].ConstantValue;
                } else {
                    oval = data[i].Data;
                }
                var element = "#" + data[i].RecordNameEn;
                $(element).text(oval);
            }
        }

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

            InitUEditor('PurposeTextBox', 500);                            // 主要用途
            InitUEditor('MainFunctionsTextBox', 500);                      // 软件主要功能、技术架构及创新概述
            InitUEditor('ComparisonTextBox', 1500);                        // 该软件与当前国内外同类软件的综合比较
            InitUEditor('BenefitsTextBox', 500);                           // 该软件的经济与社会效益
            InitUEditor('AwardsTextBox', 1500);                            // 曾获奖项
            InitUEditor('OpinionTextBox', 1500);                           // 申报单位意见
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
