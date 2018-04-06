<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="PublicBuildingReview_V2.aspx.cs" Inherits="Evaluation.View.Declaration.PublicBuildingReview_V2" validateRequest="false"%>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/ParticipantReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/AppendixReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStatesReview_V2.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/Certificatereview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/Css/Declaration.css" rel="stylesheet" />

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
                    padding: 10px 0px 5px 0px;
                    line-height: 25px;
                    height: 25px;
                    text-align:center;
                    
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
        a.btnt:hover{
            cursor:pointer;
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
            width: 84%;
        }

        #btab2 table select {
            margin-left: 10px;
            margin-right: 10px;
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

        #edui1_toolbarbox {
            position: initial;
            z-index: 0;
        }

        #edui1 {
            z-index: 0;
        }

        #ueditor, #ueditor2, #ueditor7, #ueditor8 {
            text-align: left;
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

        #content #test {
            height: 2500px !important;
        }

        .file-caption-main {
            width: 80% !important;
        }

        .form-control {
            border-top-left-radius: 4px;
            border-bottom-left-radius: 4px;
        }

        .file-caption-name {
            height: 16px !important;
        }

        .hidden-xs {
            display: inline !important;
        }

        .btn.btn-primary.btn-file {
            border-top-right-radius: 4px;
            border-bottom-right-radius: 4px;
        }

        .cart {
            transition: all 0.8s ease;
            opacity: 0;
            z-index: 20000;
            position: fixed;
            top: 0;
            right: 0;
            bottom: 0;
            left: 0;
            margin: auto;
            background: rgba(0,0,0,0.8);
            height: 0;
            width: 100%;
            overflow: hidden;
        }

        .rongqi {
            height: 100%;
        }

        .closes {
            width: 30px;
            height: 30px;
            position: absolute;
            top: 50px;
            background-image: url(../../Content/Images/close.png);
            filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(src='../../Content/Images/close.png', sizingMethod='scale');
            background-size: contain;
            right: 200px;
            cursor: pointer;
        }

        .cart.shows {
            height: 100%;
            opacity: 1;
        }

        .rongqi img {
            width: auto;
            height: auto;
            max-width: 100%;
            max-height: 80%;
            border: 5px solid #fff;
            position: absolute;
            top: 0;
            left: 0;
            bottom: 0;
            right: 0;
            margin: auto;
        }

        #tbAtlas a, #tbAppendix a {
            color: #30b9cb;
        }

            #tbAtlas a:hover, #tbAppendix a:hover {
                background: #eeeeee;
            }

        #tbAtlas i, #tbAppendix i {
            font-size: 16px;
        }
         #AppendixTable  td a,#AtlasTable  td a{
            margin:0 0.5em
        }
          /*#ProjectOverviewTextBox,#TechnicalFeaturesTextBox,#TechnicalDepthTextBox,#ComprehensiveBenefitTextBox{
            margin-left:10px;width:97%;
        }*/

          .review{
              margin-left:10px;width:97%;
          }

        /*#StructuralFeaturesTextBox,#ElectricityFeatures_ElectricalTextBox,#ElectricityFeatures_IntelligenceTextBox，#ElectricityFeatures_GreenTextBox,#ElectricityFeatures_IntelligenceTextBox,#ElectricityFeatures_GreenTextBox{
            width:98%;margin-left:10px;
        }
        #Features_HVACTextBox,#Features_PowerTextBox,#Features_WaterSupplyAndDrainageTextBox,#Features_FireFacilitiesTextBox,#EconomicsFeaturesTextBox{
            width:98%;margin-left:5px;
        }*/

        .review{
            width:98%;margin-left:5px;
        }

         .review .edui-editor.edui-default{
            z-index:1!important; border:none!important;background-color:#eee!important;
        }

        .review .edui-editor-toolbarboxouter.edui-default{
            height:0px;
        }

        .review .edui-default .edui-editor-bottomContainer td{
            border-top:none!important;border-right:none;
        }

        .review .edui-default .edui-editor-toolbarboxouter{
            border-bottom:none!important;
        }
         /*#ProjectOverviewTextBox,#TechnicalFeaturesTextBox,#TechnicalDepthTextBox,#ComprehensiveBenefitTextBox,#AwardsTextBox,#UnitOpinionTextBox,#RecommendOpinionTextBox{
            margin-left: 10px;
            width: 85%;*/
        }

         .review .Award{
              margin-left: 10px;
              width: 85%;
         }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a id="top"></a>
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a><a href="../Declaration/Declare.aspx?SepcCode=010000" id="nav02" ></a><a href="#" id="nav03"></a>
        </li>
    </ul>
      <div style="display: none">
        <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox>
      </div>
    <div class="tabbable" id="tabbable">
         <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、项目特点</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、建筑专业</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、结构专业</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、设备专业</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab">7、电气专业</a></li>
            <li><a id="tab_08" href="#btab8" data-toggle="tab">8、经济指标</a></li>
            <li><a id="tab_09" href="#btab9" data-toggle="tab">9、附件目录</a></li>
            <li><a id="tab_10" href="#btab10" data-toggle="tab">10、法人声明</a></li>
            <li><a id="tab_11" href="#btab11" data-toggle="tab">11、合作声明</a></li>
            <li><a id="tab_12" href="#btab12" data-toggle="tab" class="ExpertReviewList2" style="display: none;">12、评审意见</a></li>
        </ul>

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_0101" class="tab_div" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 15%;">项目名称</td>
                            <td colspan="4">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="DeclarationName"  Width="97%"></asp:Label>
                            </td>
                        </tr>
                       <tr>
                            <td>主要设计单位
                            </td>
                            <td colspan="4">
                                <asp:Label ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="95.3%"></asp:Label>                               
                            </td>
                        </tr>
                       <%-- <tr>
                            <td rowspan="5">申报单位<br />
                                (主申报)</td>
                            <td>申报单位</td>
                            <td colspan="3">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="DeclarationUnit"  Width="95.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>通讯地址</td>
                            <td colspan="3">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="PostalAddress"  Width="95.5%"></asp:Label>

                            </td>
                        </tr>
                        <tr>
                            <td>联系人</td>
                            <td>
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Linkman" href="javascript:void(0)" Width="88.5%"></asp:Label>
                            </td>

                            <td style="width: 120px;">手机</td>
                            <td>
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="MobileNumber"  Width="88%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>电话</td>
                            <td>
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="TelephoneNumber"  Width="88.5%"></asp:Label>
                            </td>

                            <td>邮政编码</td>
                            <td>
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Postcode"  Width="88%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>传真</td>
                            <td>
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="FaxNumber"  Width="88.5%"></asp:Label>
                            </td>

                            <td>电子邮箱</td>
                            <td>
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="EmailAddress"  Width="88%"></asp:Label>
                            </td>
                        </tr>--%>
                        <tr>
                            <td>境内、外合作设计单位</td>
                            <td style="padding: 0;" colspan="4">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 30.4%; border-right: none;">
                                            <div class="DeclarationList" id="DomesticOrAbord1">
                                                
                                            </div>
                                           
                                        </td>
                                        <td style="width: 24.1%; border-right: none; text-align: center;">
                                           <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit1"  Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none; width: 37.4%;">
                                            <div class="DeclarationList" id="CollaborativePhase1">
                                               
                                            </div>
                                           
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList" id="DomesticOrAbord2">                                               
                                            </div>
                                           
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td2">
                                           <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit2"  Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="CollaborativePhase2">
                                            </div>                                            
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList" id="DomesticOrAbord3">
                                            </div>                                            
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td3">
                                           <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit3"  Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="CollaborativePhase3">
                                            </div>                                           
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList" id="DomesticOrAbord4">
                                            </div>
                                           
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td4">
                                           <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit4"  Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="CollaborativePhase4">
                                            </div>
                                           
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>工程设计起止时间
                            </td>
                            <td style="margin-left: 2.5%;">
                                <div>
                                    <asp:Label ID="DesignStartDate" runat="server" ClientIDMode="Static"></asp:Label><span>至</span>
                                     <asp:Label ID="DesignEndDate"  runat="server" ClientIDMode="Static"></asp:Label>                                   
                                </div>                               
                            </td>
                            <td>竣工验收时间
                            </td>
                            <td colspan="2">
                                <div>
                                    <asp:Label ID="AcceptanceDate"  runat="server" ClientIDMode="Static" ></asp:Label>
                                    
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td>验收部门
                            </td>
                            <td colspan="4">
                                <asp:Label ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                通讯地址
                            </td>
                            <td colspan="4">
                                <asp:Label ID="PostalAddress" runat="server" ClientIDMode="Static" Width="97%"></asp:Label>                               
                            </td>
                        </tr>
                        <tr>
                            <td>单位资质
                            </td>
                            <td>
                                <asp:Label ID="Qualification" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>
                            </td>
                            <td>证书编号
                            </td>
                            <td>
                                <asp:Label ID="CertificateNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位联系人
                            </td>
                            <td style="width: 30%">
                                <asp:Label ID="Linkman" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>                               
                            </td>
                            <td>手    机
                            </td>
                            <td>
                                <asp:Label ID="MobileNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:Label>                              
                            </td>
                        </tr>
                        <tr>
                            <td>电    话
                            </td>
                            <td>
                                <asp:Label ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>                               
                            </td>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:Label ID="Postcode" runat="server" ClientIDMode="Static" Width="93%"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td>传    真
                            </td>
                            <td>
                                <asp:Label ID="FaxNumber" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>                              
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:Label ID="EmailAddress" runat="server" ClientIDMode="Static" Width="93%"></asp:Label>                               
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="text-align:left; padding-left:20px;">
                                申报材料目录（不限于此）：<br />
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="FileCatalog"  Width="96%"></asp:Label>
                           </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin: 0 20px;">下 一 步</a>                       
                    </div>

                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" ID="ParticipantReview"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panel1" runat="server" GroupingText="工程勘察设计项目特点">
                    <table>
                        <tr>
                            <td style="width:130px;">项目概况
                            </td>
                            <td>
                                <p>（项目总体介绍、项目规模、复杂程度及影响程度等，限500字）</p>
                                <asp:TextBox ID="ProjectOverview" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="ProjectOverviewTextBox" class="review" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>技术特色
                            </td>
                            <td>
                                <p>（项目特色及主要的技术成果指标，限1500字）</p>
                                <asp:TextBox ID="TechnicalFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="TechnicalFeaturesTextBox" class="review"  type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>技术成效<br />
                                与深度
                            </td>
                            <td>
                                <p>（解决的技术难题、工程问题的成效与深度，限1500字）</p>
                                <asp:TextBox ID="TechnicalDepth" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="TechnicalDepthTextBox" class="review"  type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>综合效益
                            </td>
                            <td>
                                <p>（项目产生的经济、社会、环境效益，限500字）</p>
                                <asp:TextBox ID="ComprehensiveBenefit" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="ComprehensiveBenefitTextBox" class="review"  type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin: 0 20px;">下 一 步</a>
                    </div>

                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab4">
                <asp:Panel ID="panel2" runat="server" GroupingText="专业技术指标（建筑专业）">
                    <table>
                        <tr>
                            <td style="width: 155px">建筑用途（性质）
                            </td>
                            <td>
                                <asp:Label ID="UseProperty" runat="server" ClientIDMode="Static" Width="85%"></asp:Label>                              
                            </td>
                            <td>建筑规模
                            </td>
                            <td>
                                <asp:Label ID="BuildingScale" runat="server" ClientIDMode="Static" Width="86.5%"></asp:Label>                            
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">总用地面积
                            </td>
                            <td rowspan="2">
                                <asp:Label ID="TotalLandArea" runat="server" ClientIDMode="Static" Width="85%"></asp:Label>
                                ㎡
                               
                            </td>
                            <td rowspan="2">其  中
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">代征地面积:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="ExpropriationArea" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>
                                            ha
                               
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">建设用地面积:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="ConstructionArea" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>
                                            ha
                                    
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">总建筑面积
                            </td>
                            <td rowspan="2">
                                <asp:Label ID="OverallFloorage" runat="server" ClientIDMode="Static" Width="85%"></asp:Label>
                                ㎡
                               
                            </td>
                            <td rowspan="2">其  中
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地上:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="OvergroundArea" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>
                                            ㎡
                                
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地下:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="UndergroundArea" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>
                                            ㎡
                                   
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>建筑基底面积
                            </td>
                            <td>
                                <asp:Label ID="BuildingArea" runat="server" ClientIDMode="Static" Width="85%"></asp:Label>
                                ㎡
                            </td>
                            <td>容 积 率
                            </td>
                            <td>
                                <asp:Label ID="PlotRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>绿 地 面 积
                            </td>
                            <td>
                                <asp:Label ID="GreenArea" runat="server" ClientIDMode="Static" Width="85%"></asp:Label>
                                ㎡                  

                            </td>
                            <td>绿 化 率
                            </td>
                            <td>
                                <asp:Label ID="GreeningRate" runat="server" ClientIDMode="Static" Width="86.5%"></asp:Label>
                                %                     
                            </td>
                        </tr>
                        <tr>
                            <td>建筑高度 
                            </td>
                            <td>
                                <asp:Label ID="BuildingHeight" runat="server" ClientIDMode="Static" Width="85%"></asp:Label>                              
                              m  
                            </td>
                            <td>建筑分类<br />
                                （高层建筑）<br />
                                (一类/二类)
                            </td>
                            <td>
                                <asp:Label ID="BuildingClassification" runat="server" ClientIDMode="Static" Width="86.5%"></asp:Label>                            
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">层数
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地上:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="OvergroundLayerCount" runat="server" ClientIDMode="Static" Width="77%"></asp:Label>
                                            层                                    
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">耐火等级<br />
                                （一级/二级）
                            </td>
                            <td rowspan="2">
                                <asp:Label ID="FireResistanceRating" runat="server" ClientIDMode="Static" Width="86.5%"></asp:Label>                           
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地下:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="UndergroundLayerCount" runat="server" ClientIDMode="Static" Width="77%"></asp:Label>
                                            层                                 
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">主要层高
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地上:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="LayerHeight_Overground" runat="server" ClientIDMode="Static" Width="77%"></asp:Label>
                                            m                                 
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">主楼/裙房电<br />
                                梯数
                            </td>
                            <td style="padding: 0">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">主楼:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="ElevatorNumber_MainBuilding" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>
                                            台                                    
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地下:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="LayerHeight_Underground" runat="server" ClientIDMode="Static" Width="77%"></asp:Label>
                                            m                                   
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="padding: 0">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">裙房:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="ElevatorNumber_PodiumBuilding" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>
                                            台                               
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">机动车停放数量
                            </td>
                            <td rowspan="2" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 100px">总计 :             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="AutoParkingCount" runat="server" ClientIDMode="Static" Width="77%"></asp:Label>
                                            辆                                         
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>地上
                            </td>
                            <td>
                                <asp:Label ID="OvergroundAutoParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:Label>
                                辆                             
                            </td>
                        </tr>
                        <tr>
                            <td>地下
                            </td>
                            <td>
                                <asp:Label ID="UndergroundAutoParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:Label>
                                辆                              
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">自行车停放数量
                            </td>
                            <td rowspan="2" style="padding: 0">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 100px;">总计 :             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label ID="BicycleParkingCount" runat="server" ClientIDMode="Static" Width="77%"></asp:Label>
                                            辆                                          
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>地上
                            </td>
                            <td>
                                <asp:Label ID="OvergroundBicycleParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:Label>
                                辆                            
                            </td>
                        </tr>
                        <tr>
                            <td>地下
                            </td>
                            <td>
                                <asp:Label ID="UndergroundBicycleParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:Label>
                                辆                             
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 154px">周围道路宽度及性质：            
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="RoadWidth" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                            <script id="RoadWidthTextBox" class="review" type="text/plain" style="height: 300px;"></script>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('04')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('04')" class="btnt up" style="margin: 0 20px;">下 一 步</a>
                    </div>

                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab5">
                <asp:Panel ID="panelPart_0103" runat="server" ClientIDMode="Static" GroupingText="技术申报内容(结构专业)">
                      <table>
                         <tr>
                            <td colspan="3">结构体系</td>
                            <td colspan="3" style="width: 300px;">
                                <asp:Label ID="StructuralSystem" runat="server"  ClientIDMode="Static" Width="90%"></asp:Label>                                
                            </td>
                            <td style="width: 135px;">抗震设防烈度</td>
                            <td colspan="4">
                                <asp:Label ID="SeismicFortificationIntensity" runat="server"  ClientIDMode="Static" Width="80%"></asp:Label>
                                度                     
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">抗震设防类别</td>
                            <td colspan="3">
                                <asp:Label ID="SeismicFortificationCategory" runat="server"  ClientIDMode="Static" Width="80%"></asp:Label>
                                类                   
                            </td>
                            <td>设计基本地震加速度值</td>
                            <td colspan="4">
                                <asp:Label ID="BasicSeismicAcceleration" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>
                                g                       
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">设计地震分组</td>
                            <td colspan="3">
                                <asp:Label ID="EarthquakeGrouping" runat="server"  ClientIDMode="Static" Width="80%"></asp:Label>
                                组                    
                            </td>
                            <td>场 地 类 别</td>
                            <td colspan="4">
                                <asp:Label ID="ConstructionSiteSoilType" runat="server"  ClientIDMode="Static" Width="80%"></asp:Label>
                                类                     
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">基础类型</td>
                            <td colspan="8">
                                <asp:Label ID="BaseType" runat="server" Width="90%"  ClientIDMode="Static"></asp:Label>                              
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">混凝土总用量</td>
                            <td colspan="3">
                                <asp:Label ID="ConcreteAmount" runat="server"  ClientIDMode="Static" Width="80%"></asp:Label>
                                m³                     
                            </td>
                            <td>每平方米混凝土折算厚度</td>
                            <td colspan="4">
                                <asp:Label ID="PerSqM_ConcreteReducedThickness" runat="server"  ClientIDMode="Static" Width="80%"></asp:Label>  cm/㎡                                            

                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" colspan="3">钢材总用量</td>
                            <td style="width: 80px;">钢筋
                            </td>
                            <td colspan="2">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="SteelAmount_rebar" Width="80%"></asp:Label>
                                t
                            </td>
                            <td rowspan="2">每平方米钢材用量</td>
                            <td style="width: 80px;">钢筋
                            </td>
                            <td colspan="4">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="PerSqM_SteelAmount_rebar" ></asp:Label>
                                kg/㎡
                            </td>
                        </tr>
                        <tr>
                            <td>型钢
                            </td>
                            <td colspan="2">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="SteelAmount_SectionSteel" Width="80%"></asp:Label>
                                t
                            </td>
                            <td >型钢
                            </td>
                            <td colspan="4">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="PerSqM_SteelAmount_SectionSteel"></asp:Label>
                                kg/㎡
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="13">抗<br />
                                震<br />
                                分<br />
                                析
                            </td>
                            <td colspan="3">程序名称</td>
                            <td colspan="7">
                                <asp:Label ID="SeismicAnalysisProgramName" runat="server"  ClientIDMode="Static" Style="width: 97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="3">
                                不<br />
                                考<br />
                                虑<br />
                                扭<br />
                                转<br />
                                耦<br />
                                联
                            </td>
                            <td colspan="2">方向
                            </td>
                            <td colspan="2">T1(s)
                            </td>
                            <td>F<sub>EK</sub> (kN)
                            </td>
                            <td colspan="2">F<sub>EK</sub>/Geq
                            </td>
                            <td>△Uu (mm)
                            </td>
                            <td>△Uu/h
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">横向
                            </td>
                            <td colspan="2">
                                <asp:Label ID="NoCoupling_H_T1" runat="server"  ClientIDMode="Static" Style="width: 89%"></asp:Label>                              
                            </td>
                            <td>
                                <asp:Label ID="NoCoupling_H_Fek_kN" runat="server"  ClientIDMode="Static" Style="width: 75%"></asp:Label>                               
                            </td>
                            <td colspan="2">
                                <asp:Label ID="NoCoupling_H_Fek_Geq" runat="server"  ClientIDMode="Static" Style="width: 83%"></asp:Label>  %                          
                            </td>
                            <td>
                                <asp:Label ID="NoCoupling_H_Uu_mm" runat="server"  ClientIDMode="Static" Style="width: 75%"></asp:Label>                               
                            </td>
                            <td>
                                <asp:Label ID="NoCoupling_H_Uu_h" runat="server"  ClientIDMode="Static" Style="width: 75%"></asp:Label>                             
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">纵向
                            </td>
                            <td colspan="2">
                                <asp:Label ID="NoCoupling_V_T1" runat="server"  ClientIDMode="Static" Style="width: 89%"></asp:Label>                             
                            </td>
                            <td>
                                <asp:Label ID="NoCoupling_V_Fek_kN" runat="server"  ClientIDMode="Static" Style="width: 75%"></asp:Label>                           
                            </td>
                            <td colspan="2">
                                <asp:Label ID="NoCoupling_V_Fek_Geq" runat="server"  ClientIDMode="Static" Style="width: 83%"></asp:Label> %                                                  
                            </td>
                            <td>
                                <asp:Label ID="NoCoupling_V_Uu_mm" runat="server"  ClientIDMode="Static" Style="width: 75%"></asp:Label>                         
                            </td>
                            <td>
                                <asp:Label ID="NoCoupling_V_Uu_h" runat="server"  ClientIDMode="Static"></asp:Label>                          
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="4">
                                考<br />
                                虑<br />
                                扭<br />
                                转<br />
                                耦<br />
                                联
                            </td>
                            <td>振型<br />
                                号
                            </td>
                            <td>T(s)
                            </td>
                            <td>转角
                            </td>
                            <td>扭转系数
                            </td>
                            <td>方向
                            </td>
                            <td>F<sub>EK</sub> (kN)
                            </td>
                            <td>F<sub>EK</sub>/Geq
                            </td>
                            <td>△Ue (mm)
                            </td>
                            <td>△Ue/h
                            </td>
                        </tr>
                        <tr>
                            <td>1
                            </td>
                            <td>
                                <asp:Label ID="Coupling_T1" runat="server"  ClientIDMode="Static"></asp:Label>                           
                            </td>
                            <td>
                                <asp:Label ID="Coupling_Corner1" runat="server"  ClientIDMode="Static"></asp:Label>                              
                            </td>
                            <td>
                                <asp:Label ID="Coupling_TorsionCoefficient1" runat="server"  ClientIDMode="Static"></asp:Label>                            
                            </td>
                            <td>横向
                            </td>
                            <td>
                                <asp:Label ID="Coupling_H_Fek_kN" runat="server"  ClientIDMode="Static"></asp:Label>                           
                            </td>
                            <td>
                                <asp:Label ID="Coupling_H_Fek_Geq" runat="server"  ClientIDMode="Static"></asp:Label>                             
                            </td>
                            <td>
                                <asp:Label ID="Coupling_H_Ue_mm" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                              
                            </td>
                            <td>
                                <asp:Label ID="Coupling_H_Ue_h" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                            
                            </td>
                        </tr>
                        <tr>
                            <td>2
                            </td>
                            <td>
                                <asp:Label ID="Coupling_T2" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                               
                            </td>
                            <td>
                                <asp:Label ID="Coupling_Corner2" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                             
                            </td>
                            <td>
                                <asp:Label ID="Coupling_TorsionCoefficient2" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                             
                            </td>
                            <td>纵向
                            </td>
                            <td>
                                <asp:Label ID="Coupling_V_Fek_kN" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                              
                            </td>
                            <td>
                                <asp:Label ID="Coupling_V_Fek_Geq" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                            
                            </td>
                            <td>
                                <asp:Label ID="Coupling_V_Ue_mm" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="Coupling_V_Ue_h" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                              
                            </td>
                        </tr>
                        <tr>
                            <td>3
                            </td>
                            <td>
                                <asp:Label ID="Coupling_T3" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                              
                            </td>
                            <td>
                                <asp:Label ID="Coupling_Corner3" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                              
                            </td>
                            <td>
                                <asp:Label ID="Coupling_TorsionCoefficient3" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                             
                            </td>

                            <td>地震作用最大方向
                            </td>
                            <td colspan="4">
                                <asp:Label ID="MaxActionDirection" runat="server" Style="width: 93.5%"  ClientIDMode="Static"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">时程分析程序名称</td>
                            <td colspan="7">
                                <asp:Label ID="TimeHistoryAnalysisProgramName" runat="server" Style="width: 96.6%"  ClientIDMode="Static"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">波     名
                            </td>
                            <td colspan="2">F<sub>EK</sub> (kN)
                            </td>
                            <td colspan="2">F<sub>EK</sub>/Geq
                            </td>
                            <td>△U/h
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:Label ID="TimeHistory_WaveName1" runat="server" Style="width: 92.5%"  ClientIDMode="Static"></asp:Label>                           
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_kN1" runat="server" Style="width: 89%"  ClientIDMode="Static"></asp:Label>                            
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_Geq1" runat="server" Style="width: 78%"  ClientIDMode="Static"></asp:Label>  %                              
                      
                            </td>
                            <td>
                                <asp:Label ID="TimeHistory_U_h1" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                            
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:Label ID="TimeHistory_WaveName2" runat="server" Style="width: 92.5%"  ClientIDMode="Static"></asp:Label>                            
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_kN2" runat="server" Style="width: 89%"  ClientIDMode="Static"></asp:Label>                               
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_Geq2" runat="server" Style="width: 78%"  ClientIDMode="Static"></asp:Label>
                                %                    
                            </td>
                            <td>
                                <asp:Label ID="TimeHistory_U_h2" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>             
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:Label ID="TimeHistory_WaveName3" runat="server" Style="width: 92.5%"  ClientIDMode="Static"></asp:Label>                               
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_kN3" runat="server" Style="width: 89%"  ClientIDMode="Static"></asp:Label>                              
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_Geq3" runat="server" Style="width: 78%"  ClientIDMode="Static"></asp:Label>  %                                                 

                            </td>
                            <td>
                                <asp:Label ID="TimeHistory_U_h3" runat="server" Style="width: 75%"  ClientIDMode="Static"></asp:Label>                              
                            </td>
                        </tr>
                        <tr>
                            <td colspan="11" style="text-align: center; padding-left: 10px;">结构专业设计主要特点：（不少于600字）</td>
                        </tr>
                        <tr>
                            <td colspan="11">
                                <asp:TextBox ID="StructureMainFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="StructureMainFeaturesTextBox" class="review" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('05')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('05')" class="btnt up" style="margin: 0 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab6">
               <asp:Panel ID="panel3" runat="server" GroupingText="专业技术指标（设备专业）">
                    <table>
                        <tr>
                            <td style="width:200px;">采  暖  方  式
                            </td>
                            <td colspan="3">
                                <asp:Label ID="HeatingMode" runat="server" ClientIDMode="Static"></asp:Label>                            
                            </td>
                        </tr>
                        <tr>
                            <td>采暖/空调总热负荷
                            </td>
                            <td>
                                <asp:Label ID="SpaceHeatingLoad" runat="server" ClientIDMode="Static"></asp:Label>
                                kW
                      
                            </td>
                            <td>空调总冷负荷
                            </td>
                            <td>
                                <asp:Label ID="AirConCoolingLoad" runat="server" ClientIDMode="Static"></asp:Label>
                                kW
                  
                            </td>
                        </tr>
                        <tr>
                            <td>空调通风方式
                            </td>
                            <td colspan="3">
                                <asp:Label ID="AirConVentilationMode" runat="server" ClientIDMode="Static"></asp:Label>                          
                            </td>
                        </tr>
                        <tr>
                            <td>空调水系统方式
                            </td>
                            <td colspan="3">
                                <asp:Label ID="AirConWaterSystemMode" runat="server" ClientIDMode="Static"></asp:Label>                         
                            </td>
                        </tr>
                        <tr>
                            <td>给水系统方式
                            </td>
                            <td colspan="3">
                                <asp:Label ID="WaterSupplySystemMode" runat="server" ClientIDMode="Static"></asp:Label>                       
                            </td>
                        </tr>
                        <tr>
                            <td>中水回收使用方式
                            </td>
                            <td colspan="3">
                                <asp:Label ID="ReclaimedWaterRecycling" runat="server" ClientIDMode="Static"></asp:Label>                           
                            </td>
                        </tr>
                        <tr>
                            <td>雨、污水排放方式
                            </td>
                            <td colspan="3">
                                <asp:Label ID="SewageDischargeMode" runat="server" ClientIDMode="Static" Style="width: 97%"></asp:Label>                             
                            </td>
                        </tr>
                        <tr>
                            <td>消防给水方式
                            </td>
                            <td colspan="3">
                                <asp:Label ID="FireWaterSupplyMode" runat="server" ClientIDMode="Static" Style="width: 97%"></asp:Label>                               
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="text-align: center; padding-left: 10px;">设备专业设计主要特点：</td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <p>暖  通：（不少于300字）动  力：（不少于200字）给 排 水：（不少于200字）消防给水：（不少于200字）</p>
                                <asp:TextBox ID="MechanicalMainFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="MechanicalMainFeaturesTextBox" class="review" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>                 
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('06')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('06')" class="btnt up" style="margin:0 20px;">下 一 步</a>                       
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab7">
                 <asp:Panel ID="panel4" runat="server" GroupingText="专业技术指标（电气专业）">
                    <table>
                        <tr>
                            <td style="width:200px;">动力总电负荷
                            </td>
                            <td colspan="2">
                                <asp:Label ID="PowerTotalElectricLoad" runat="server" ClientIDMode="Static"></asp:Label>
                                kW                    
                            </td>
                            <td style="width:200px;">照明总电负荷
                            </td>
                            <td>
                                <asp:Label ID="LightingTotalElectricLoad" runat="server" ClientIDMode="Static"></asp:Label>
                                kW                       
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">供电电源设计情况
                            </td>
                            <td rowspan="2" colspan="2">
                                <asp:Label ID="DesignOfPowerSupply" runat="server" ClientIDMode="Static"></asp:Label>                              
                            </td>
                            <td>变压器装机台数
                            </td>
                            <td>
                                <asp:Label ID="TransformerInstalledNumber" runat="server" ClientIDMode="Static"></asp:Label>
                                台                      
                            </td>
                        </tr>
                        <tr>
                            <td>变压器装机容量
                            </td>
                            <td>
                                <asp:Label ID="TransformerInstalledCapacity" runat="server" ClientIDMode="Static"></asp:Label>
                                kVA                      
                            </td>
                        </tr>
                        <tr>
                            <td>防雷设防类别及方式
                            </td>
                            <td colspan="4">
                                <asp:Label ID="LightningProtectionClass" runat="server" ClientIDMode="Static"></asp:Label>                               
                            </td>
                        </tr>
                        <tr>
                            <td>动 力 内 容
                            </td>
                            <td colspan="4">
                                <asp:Label ID="DynamicContent" runat="server" ClientIDMode="Static"></asp:Label>                          
                            </td>
                        </tr>
                        <tr>
                            <td>弱电设计内容
                            </td>
                            <td colspan="4">
                                <asp:Label ID="WeakDesignContent" runat="server" ClientIDMode="Static"></asp:Label>                             
                        </tr>
                        <tr>
                            <td>照明方式节能措施
                            </td>
                            <td colspan="4">
                                <asp:Label ID="EnergySavingMeasures" runat="server" ClientIDMode="Static"></asp:Label>                         
                            </td>
                        </tr>
                        <tr>
                            <td>用电负荷等级确定情况
                            </td>
                            <td colspan="4">
                                <asp:Label ID="PowerLoadLevel" runat="server" ClientIDMode="Static"></asp:Label>                              
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5" style="text-align: center; padding-left: 10px;">电气专业设计主要特点：</td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <p>强  电：（不少于150字）弱  电：（不少于200字）</p>
                                <asp:TextBox ID="ElectricalMainFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>                       
                                <script id="ElectricalMainFeaturesTextBox" class="review" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('07')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('07')" class="btnt up" style="margin:0 20px;">下 一 步</a>                        
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab8">
                <asp:Panel ID="panelPart_0106" runat="server" ClientIDMode="Static" GroupingText="专业技术指标（技术经济指标）">
                    <table>
                        <tr>
                            <td style="width: 150px;">单位规模建筑面积指标</td>
                            <td colspan="2" style="border-right: none">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitAreaIndicators"  Width="93%"></asp:Label>
                            </td>
                            <td style="border-left: none; width: 100px;">㎡<%--/                            
                           <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitAreaIndicatorsUnit"  Width="30%"></asp:Label>--%>
                            </td>
                            <td style="width:150px;">使用面积系数</td>
                            <td colspan="2" style="border-right: none">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="UseAreaCoefficient"  Width="100%"></asp:Label>

                            </td>
                            <td style="border-left: none; text-align: left;">%
                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积耗热量指标</td>
                            <td colspan="2" style="border-right: none">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitAreaHotConsumption"  Width="105%"></asp:Label>

                            </td>
                            <td style="border-left: none; text-align: left;">W/㎡
                            </td>
                            <td>单位建筑面积耗冷量指标</td>
                            <td colspan="2" style="border-right: none">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitAreaColdConsumption"  Width="100%"></asp:Label>

                            </td>
                            <td style="border-left: none; text-align: left;">W/㎡
                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积变压器装机容量</td>
                            <td colspan="2" style="border-right: none">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitAreaTransformerCapacity"  Width="105%"></asp:Label>

                            </td>
                            <td style="border-left: none; text-align: left;">VA/㎡
                            </td>
                            <td>日供水量</td>
                            <td colspan="2" style="border-right: none">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="DailyWaterSupply"  Width="100%"></asp:Label>

                            </td>
                            <td style="border-left: none; text-align: left;">m<sup>3</sup> /日
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">概算</td>
                            <td colspan="4">竣工决算</td>
                        </tr>
                        <tr>
                            <td rowspan="2">总造价</td>
                            <td style="width: 80px;">人民币</td>
                            <td style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_RMB"  Width="106%"></asp:Label>
                            </td>
                            <td style="width: 50px; border-left: none; text-align: left;">万元
                            </td>
                            <td rowspan="2">总造价</td>
                            <td style="width: 80px;">人民币</td>
                            <td style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_RMB"  Width="102%"></asp:Label>
                            </td>
                            <td style="width: 50px; border-left: none; text-align: left;">万元
                            </td>
                        </tr>
                        <tr>
                            <td>外币</td>
                            <td style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_ForeignCurrency"  Width="106%"></asp:Label>
                            </td>
                            <td style="width: 50px; border-left: none; text-align: left;">万美元
                            </td>
                            <td>外币</td>
                            <td style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_ForeignCurrency"  Width="102%"></asp:Label>
                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">万美元
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">土建与安装工程的比例</td>
                            <td>土建</td>
                            <td style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_CivilEngineering"  Width="106%"></asp:Label>
                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">%
                            </td>
                            <td rowspan="2">土建与安装工程的比例</td>
                            <td>土建</td>
                            <td style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_CivilEngineering"  Width="102%"></asp:Label>

                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">%
                            </td>
                        </tr>
                        <tr>
                            <td>安装</td>
                            <td style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_Install"  Width="106%"></asp:Label>
                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">%
                            </td>
                            <td>安装</td>
                            <td style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_Install"  Width="102%"></asp:Label>

                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">%
                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积造价</td>
                            <td colspan="2" style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_PerUnitAreaRMB"  Width="103%"></asp:Label>
                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">元/㎡
                            </td>
                            <td>单位建筑面积造价</td>
                            <td colspan="2" style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_OneUnitAreaRMB"  Width="102%"></asp:Label>

                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">元/㎡
                            </td>
                        </tr>
                        <tr>
                            <td>单位规模造价</td>
                            <td colspan="2" style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_PerUnitScaleRMB"  Width="93%"></asp:Label>
                            </td>
                            <td style="width: 60px; border-left: none; text-align: left; padding: 10px 0 0 0;">
                                <p style="float: left;">元/㎡</p>
                               <%--<asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_PerUnitScaleRMBUnit"  Style="width: 30px;"></asp:Label>--%>
                            </td>
                            <td>单位规模造价</td>
                            <td colspan="2" style="border-right: none;">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_OneUnitScaleRMB"  Width="93%"></asp:Label>
                            </td>
                            <td style="width: 80px; border-left: none; text-align: left; padding: 10px 0 0 0;">
                                <p style="float: left;">元/㎡</p>
                               <%--<asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_OneUnitScaleRMBUnit"  Style="width: 30px;"></asp:Label>--%>
                            </td>
                        </tr>
                        <tr>
                            <td>结算与概算出入<br />的主要原因</td>
                            <td colspan="7">
                               <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_Settlement_Difference"  Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8" style="text-align: center; padding-left: 10px;">经济专业主要特点：（限制在200字）</td>
                        </tr>
                        <tr>
                            <td colspan="8" style="text-align: left; padding-left: 10px;">
                               <asp:TextBox  runat="server"  ClientIDMode="Static" ID="EconomicsFeatures"  TextMode="MultiLine" Style="width: 99%; height: 300px;"></asp:TextBox>
                                <script id="EconomicsFeaturesTextBox" class="review" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                     <table>
                        <tr>
                            <td colspan="11" style="border: none;">
                                <h3>审核意见</h3>
                            </td>
                        </tr>
                        <tr>
                            <td>曾获奖项
                            </td>
                            <td>
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="AwardsTextBox" class="review Award" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                意   见
                            </td>
                            <td>
                                <asp:TextBox ID="UnitOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="UnitOpinionTextBox" class="review Award" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>地方、部门勘察设计同业协会推荐意见
                            </td>
                            <td>
                                <asp:TextBox ID="RecommendOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="RecommendOpinionTextBox" class="review Award" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('08')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('08')" class="btnt up" style="margin:0 20px;">下 一 步</a>                                            
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab9">
                <uc:Appendix runat="server" ID="AppendixReview"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab10">
                <uc:LegalStates runat="server" ID="LegalStatesReview"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab11">
                <uc:Certificate runat="server" ID="CertificateReview"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab12">
                <uc:Comments runat="server" ID="ucCommentsReview"></uc:Comments>
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
                $(element).html(oval.replace(new RegExp("\n", "gm"), "<br />"));
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
            $("#uPrize6").text(data1.PrizeName);
            $("#Divisiontable").empty()          
            // console.log(data2)
            for (var i = 0; i < data2.length; i++) {
                var item1 = "勘察设计单位";
                var item2 = "概念性方案设计";
                var item3 = "方案设计（建筑）";
                var item4 = "方案设计（结构）";
                var item5 = "初步设计（建筑）";
                var item6 = "初步设计（结构）";
                var item7 = "初步设计（设备）";
                var item8 = "初步设计（电气）";
                var item9 = "施工图设计（建筑）";
                var item10 = "施工图设计（结构）";
                var item11 = "施工图设计（设备）";
                var item12 = "施工图设计（电气）"
                var index = i + 1;
                var item = "<tr>" +
                       "<td>" + index + "</td>" +
                       "<td>" + data2[i][item1] + "</td>" +
                       "<td>" + data2[i][item2] + "</td>" +
                       "<td>" + data2[i][item3] + "</td>" +
                       "<td>" + data2[i][item4] + "</td>" +
                       "<td>" + data2[i][item5] + "</td>" +
                       "<td>" + data2[i][item6] + "</td>" +
                       "<td>" + data2[i][item7] + "</td>" +
                       "<td>" + data2[i][item8] + "</td>" +
                       "<td>" + data2[i][item9] + "</td>" +
                       "<td>" + data2[i][item10] + "</td>" +
                       "<td>" + data2[i][item11] + "</td>" +
                       "<td>" + data2[i][item12] + "</td>" +
                       "<tr>"
                $("#Divisiontable").append(item);
            }
        }       
 
        $(function () {
            $("#tbAppendix>tr>td:last").hide();
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

            //重置页面顺序
            $("#AppendixPrev").click(function () {
                onPrev("09");
            });
            $("#AppendixNext").click(function () {
                onNext("09");
            });
            $("#LegalStatesPrev").click(function () {
                onPrev("10");
            });
            $("#LegalStatesNext").click(function () {
                onNext("10");
            });
            $("#CertificatePrev").click(function () {
                onPrev("11");
            });
            $("#CertificateNext").click(function () {
                onNext("11");
            });
            $("#CommentsPrev").click(function () {
                onPrev("12");
            });          

            // 富文本框
            InitUEditor('ProjectOverviewTextBox', 500);              // 项目概况
            InitUEditor('TechnicalFeaturesTextBox', 1500);              // 技术特色
            InitUEditor('TechnicalDepthTextBox', 1500);              // 技术成效
            InitUEditor('ComprehensiveBenefitTextBox', 500);              // 综合效益
            InitUEditor('RoadWidthTextBox', 500);
            InitUEditor('StructureMainFeaturesTextBox', 600);
            InitUEditor('MechanicalMainFeaturesTextBox', 1000);
            InitUEditor('ElectricalMainFeaturesTextBox', 400);
            InitUEditor('EconomicsFeaturesTextBox', 1000);
            InitUEditor('AwardsTextBox', 2000);
            InitUEditor('UnitOpinionTextBox', 2000);
            InitUEditor('RecommendOpinionTextBox', 2000);

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
