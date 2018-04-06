<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true"  CodeBehind="SurveyReview.aspx.cs" Inherits="Evaluation.View.Declaration.SurveyReview" validateRequest="false"%>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/ParticipantReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/AppendixReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStatesReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/CertificateReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript" charset="utf-8" src="../../Content/Javascript/DeclarationReview.js"></script>
    <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css"/>
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>
  
    <%--UEditor--%>
    <script src="../../Content/plugins/ueditor/ueditor.config.js"></script>
    <script src="../../Content/plugins/ueditor/ueditor.all.js"></script>
    <script src="../../Content/plugins/ueditor/lang/zh-cn/zh-cn.js"></script>
    <style>
        table{border:none; border-collapse: collapse;width:90%;margin:0px auto}
        table tr{border:none;}
        table tr td{border:1px solid;padding:10px 5px 5px 5px;text-align:center;line-height:25px;height:25px;}
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
        a.btnt:hover{
            cursor:pointer;
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
        #AcceptanceDepartment{
            float:none!important;
        }

        #AcceptanceDepartment{
            margin-left:6px;
        }

        #content #test{
            height:2500px!important;
        }
        #ProjectOverviewTextBox,#TechnicalFeatureTextBox,#BenefitsTextBox,#AwardTextBox,#UnitOpinionTextBox,#RecommendOpinionTextBox{
            text-align:left;width:85%;
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
       <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#" id="nav01"></a><a href="../Declaration/Declare.aspx?SepcCode=140000" id="nav02" runat="server" ClientIDMode="Static"></a><a href="#" id="nav03"></a>
       </li>        
    </ul>
    <div style="display:none"><asp:Label  ID="txtSituation" runat="server" ClientIDMode="Static"></asp:Label></div>
    <div style="display:none"><asp:Label  ID="txtUser" runat="server" ClientIDMode="Static"></asp:Label></div>
    <div style="display:none"><asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:Label   ID="txtTemplate" runat="server" ClientIDMode="Static"></asp:Label></div>
    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、申报内容</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、审核意见</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、附件目录</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、法人声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab">7、合作声明</a></li>
            <li><a id="tab_08" href="#btab8" data-toggle="tab" class="ExpertReviewList2" style="display: none;">8、评审意见</a></li>
        </ul>

        <div class="tab-content"  id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_1401"   GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 150px;">项目名称
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DeclarationName"   Width="95.5%"></asp:Label>
                            </td>
                        </tr>                       
                        <tr>
                            <td>项目主要技术<br />
                                经济指标水平
                            </td>
                            <td colspan="3">
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TechnicalEconomicIndicators"   Width="95.5%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtTechnicalEconomicIndicators"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位 
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DeclarationUnit"   Width="95.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>境内、外合作设计单位</td>
                            <td style="padding: 0;" colspan="4">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 30.4%; border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label  runat="server"  ClientIDMode="Static"  ID="DomesticOrAbord1" ></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="txtDomesticOrAbord1"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="width: 23.8%; border-right: none; text-align: center;">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit1"   Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none; width: 35%;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList1">
                                                <asp:Label  runat="server"  ClientIDMode="Static"  ID="CollaborativePhase1"  Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TextBox1"   Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="txtCollaborativePhase1"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label  runat="server"  ClientIDMode="Static"  ID="DomesticOrAbord2" ></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="txtDomesticOrAbord2"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td2">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit2"   Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList2">
                                                <asp:Label  runat="server"  ClientIDMode="Static"  ID="CollaborativePhase2"  Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TextBox2"   Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="txtCollaborativePhase2"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label  runat="server"  ClientIDMode="Static"  ID="DomesticOrAbord3" ></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="txtDomesticOrAbord3"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td3">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit3"   Style="width: 88%;" ></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList3">
                                                <asp:Label  runat="server"  ClientIDMode="Static"  ID="CollaborativePhase3"  Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TextBox3"   Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="txtCollaborativePhase3"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label  runat="server"  ClientIDMode="Static"  ID="DomesticOrAbord4" ></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="txtDomesticOrAbord4"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td4">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit4"   Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList4">
                                                <asp:Label  runat="server"  ClientIDMode="Static"  ID="CollaborativePhase4"  Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TextBox4"   Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label  runat="server"  ClientIDMode="Static" ID="txtCollaborativePhase4"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>通信地址
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PostalAddress"   Width="95.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>联系人
                            </td>
                            <td style="width: 35%">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Linkman"   Width="89%"></asp:Label>
                            </td>
                            <td style="width: 150px;">传真
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="FaxNumber"   Width="89%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>电话
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TelephoneNumber"   Width="89%"></asp:Label>
                            </td>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Postcode"   Width="89%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>手机
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="MobileNumber"   Width="89%"></asp:Label>
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="EmailAddress"   Width="89%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>项目申报单位资质<br />
                                证书名称/编号
                            </td>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="border-right: none;">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="CertificateName"   Width="90%"></asp:Label>  /
                                        </td>                                 
                                        <td style="border-right: none;">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="CertificateNumber"   Style="width: 91%; margin-left: 0;"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>建设单位
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DevelopmentOrganization"   Width="95.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>项目起止时间
                            </td>
                            <td>
                                <div  style="width: 47%;">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="ProjectStartDate"></asp:Label>
                                </div>
                                
                                <div  style="width: 47%;">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="ProjectEndDate"></asp:Label>
                                </div>
                            </td>
                            <td>项目建成/完成时间
                            </td>
                            <td>
                                <div >
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="ConstructionEndDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>验收部门
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="AcceptanceDepartment"   Width="68%"></asp:Label>
                            </td>
                            <td>验收时间
                            </td>
                            <td>
                                <div>
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="AcceptanceDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                       <%-- <tr>
                            <td style="width:150px; padding:25px;">
                                曾获奖项
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Awards"    Style="width: 95%; height: 200px;display:block"></asp:Label>
                           </td> 
                        </tr>--%>
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
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_1402"   GroupingText="技术申报内容">
                    <table>
                        <tr>
                            <td>项目概况（项目总体介绍、项目规模、复杂程度及影响程度等，限500字。）
                            </td>
                            <td>
                                <asp:TextBox ID="ProjectOverview" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="ProjectOverviewTextBox" type="text/plain" style="height: 300px;"></script>                              
                            </td>
                        </tr>
                        <tr>
                            <td>项目特色（项目特点、主要工程问题、技术难点及技术创新、实施效果与成果指标等，限3000字。）
                            </td>
                            <td>
                                <asp:TextBox ID="TechnicalFeature" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="TechnicalFeatureTextBox" type="text/plain" style="height: 300px;"></script>                                
                            </td>
                        </tr>
                       <%-- <tr>
                            <td>解决技术难题、工程问题的成效与深度
                            </td>
                            <td>
                                <asp:TextBox ID="Effectiveness" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="EffectivenessTextBox" type="text/plain" style="height: 300px;"></script>                                
                            </td>
                        </tr>--%>
                        <tr>
                            <td>整体效益（项目产生的经济、社会、环境、效益等，限500字。）
                            </td>
                            <td>
                                <asp:TextBox ID="Benefits" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="BenefitsTextBox" type="text/plain" style="height: 300px;"></script>                                
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
                <asp:Panel ID="panelPart_1403" runat="server" ClientIDMode="Static" GroupingText="审核意见">
                    <table>
                        <tr>
                            <td>曾获奖项
                            </td>
                            <td>
                                <asp:TextBox ID="Award" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="AwardTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />意   见
                            </td>
                            <td>
                                <asp:TextBox ID="UnitOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="UnitOpinionTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>地方、部门勘察设计同业协会推荐<br />意   见
                            </td>
                            <td>
                                <asp:TextBox ID="RecommendOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="RecommendOpinionTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">                    
                    <a onclick="onPrev('04')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                    <a onclick="onNext('04')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab5">
                <uc:Appendix runat="server" ID="Appendix"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab6">
                <uc:LegalStates runat="server" ID="ucLegalStates"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab7">
                <uc:Certificate runat="server" ID="ucCertificate"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab8">
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
                 $(element).text(oval);                
             }
             for (var j = 1; j < 5; j++) {
                 if ($('#CooperativeUnit' + j).text() == "---") {
                     $('#DomesticOrAbord' + j).text("---");
                 }
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
             //合作勘察设计项目合作声明
             $("#DeclarationName6").text(data1.DeclarationName);
             $("#DeclarationUnit6").text(data1.OrganizationName);
             $("#uPrize6").text(data.PrizeName);
             $("#Divisiontable").empty();

             $("#Divisiontable").prev().find("tr:last").hide();

             var arrCol = new Array();　//创建一个数组
             var item = "<tr>";
             var i = 0;
             for (var key in data2[0]) {
                 if (i == 1) {
                     item += "<td colspan='7'>" + key + "</td>";
                 }
                 else {
                     item += "<td>" + key + "</td>";
                 }
                 i++;
                 arrCol.push(key);
             }
             item += "</tr>";
             $("#Divisiontable").prev().append(item);

             for (i = 0; i < data2.length; i++) {
                 item = "<tr>";
                 for (var j = 0; j < arrCol.length; j++) {
                     if (j == 1) {
                         item += "<td colspan='7'>" + data2[i][arrCol[j]] + "</td>";
                     }
                     else {
                         item += "<td>" + data2[i][arrCol[j]] + "</td>";
                     }
                 }
                 item += "</tr>";
                 $("#Divisiontable").append(item);
             }


         }
 
         // 初始化富文本框
         function InitUEditor(container, max) {
             var text = $("#" + container.replace("TextBox", ""));
             text.hide();
             var ue = UE.getEditor(container, {
                 wordCount: false,
                 autoHeightEnabled: true,
                 readonly: true,
                 autoHeightEnabled: false,
                 toolbars: [[]]
             });
             ue.ready(function () {
                 //设置编辑器的内容
                 ue.setContent(text.val());
             });
         }

         $(function () {
             $("#tbAppendix>tr>td:last").hide();
             //重置页面顺序
             $("#AppendixPrev").click(function () {
                 onPrev("05");
             });
             $("#AppendixNext").click(function () {
                 onNext("05");
             });
             $("#LegalStatesPrev").click(function () {
                 onPrev("06");
             });
             $("#LegalStatesNext").click(function () {
                 onNext("06");
             });
             $("#CertificatePrev").click(function () {
                 onPrev("07");
             });
             $("#CertificateNext").click(function () {
                 onNext("07");
             });
             $("#CommentsPrev").click(function () {
                 onPrev("08");
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

             InitUEditor('ProjectOverviewTextBox', 500);               // 项目概况、规模、影响程度
             InitUEditor('TechnicalFeatureTextBox', 3000);               // 技术特色，主要技术成果指标水平                     
             InitUEditor('BenefitsTextBox', 500);                      // 经济、社会、环境效益
             InitUEditor('AwardTextBox', 1500);
             InitUEditor('RecommendOpinionTextBox', 1500);
             InitUEditor('UnitOpinionTextBox', 1500);
         });

    </script>     
</asp:Content>
