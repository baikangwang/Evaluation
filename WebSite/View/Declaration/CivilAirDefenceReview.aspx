﻿<%@ Page Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="CivilAirDefenceReview.aspx.cs" Inherits="Evaluation.View.Declaration.CivilAirDefenceReview" validateRequest="false" %>

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
        #edui1_iframeholder{
            height:300px!important;
        }
        #btn_018Prev{
            margin-left: 43%;
            margin-top:40px; 
        }
        #AcceptanceDepartment{
            float:none!important;
        }

        #AcceptanceDepartment{
            margin-left:4px;
        }

        #content #test{
            height:2500px!important;
        }
        #btab3 table{
            margin-top:-20px;
        }
        #ProjectOverviewTextBox,#TechnologyFeatureTextBox,#EffectTextBox,#BenefitTextBox,#Indicators_ConstructTextBox,#Indicators_StructureTextBox,#Indicators_HVACTextBox,#Indicators_SupplyAndDrainageTextBox,#Indicators_ElectricTextBox,#Indicators_AntichemicalTextBox{
            text-align:left;width:90%;
        }
         #AppendixTable  td a,#AtlasTable  td a{
            margin:0 0.5em
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
    <div style="display:none"><asp:Label  ID="txtSituation" runat="server" ClientIDMode="Static"></asp:Label></div>
    <div style="display:none"><asp:Label  ID="txtUser" runat="server" ClientIDMode="Static"></asp:Label></div>
    <div style="display:none"><asp:TextBox  ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:Label  ID="txtTemplate" runat="server" ClientIDMode="Static"></asp:Label></div>
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a><a href="../Declaration/Declare.aspx?SepcCode=100000" id="nav02" runat="server" clientidmode="Static"></a><a href="#" id="nav03"></a>
        </li>
    </ul>     
    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、申报内容</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、附件目录</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、法人声明</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、合作声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab" class="ExpertReviewList2" style="display: none;">7、评审意见</a></li>
        </ul>

        <div class="tab-content"  id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel runat="server" ID="panelPart_1001"  ClientIDMode="Static" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 130px;">项目报优名称
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server"  ID="DeclarationName"  ClientIDMode="Static" Width="95.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>立项名称
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server"  ID="ApprovalName"  ClientIDMode="Static" Width="95.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">申报单位<br />
                                （主申报）
                            </td>
                            <td style="width: 120px;">申报单位
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server"  ID="DeclarationUnit"  ClientIDMode="Static" Width="94.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>通讯地址
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server"  ID="PostalAddress"  ClientIDMode="Static" Width="94.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>联 系 人
                            </td>
                            <td style="width: 30%">
                                <asp:Label runat="server"  ID="Linkman"  ClientIDMode="Static" Width="87%"></asp:Label>
                            </td>
                            <td>手    机
                            </td>
                            <td>
                                <asp:Label runat="server"  ID="MobileNumber"  ClientIDMode="Static" Width="87%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>电    话
                            </td>
                            <td>
                                <asp:Label runat="server"  ID="TelephoneNumber"  ClientIDMode="Static" Width="87%"></asp:Label>
                            </td>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:Label runat="server"  ID="Postcode"  ClientIDMode="Static" Width="87%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>传    真
                            </td>
                            <td>
                                <asp:Label runat="server"  ID="FaxNumber"  ClientIDMode="Static" Width="87%"></asp:Label>
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:Label runat="server"  ID="EmailAddress"  ClientIDMode="Static" Width="87%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>境内、外合作设计单位</td>
                            <td style="padding: 0;" colspan="4">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 30.4%; border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server"   ID="DomesticOrAbord1" ClientIDMode="Static"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server"  ID="txtDomesticOrAbord1"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="width: 23.8%; border-right: none; text-align: center;">
                                            <asp:Label runat="server"  ID="CooperativeUnit1"  ClientIDMode="Static" Style="width: 88%;" ></asp:Label>
                                        </td>
                                        <td style="border-right: none; width: 35%;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList1">
                                                <asp:Label runat="server"   ID="CollaborativePhase1" ClientIDMode="Static" Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label runat="server"  ID="TextBox1"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server"  ID="txtCollaborativePhase1"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server"   ID="DomesticOrAbord2" ClientIDMode="Static"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server"  ID="txtDomesticOrAbord2"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td2">
                                            <asp:Label runat="server"  ID="CooperativeUnit2"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList2">
                                                <asp:Label runat="server"   ID="CollaborativePhase2" ClientIDMode="Static" Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label runat="server"  ID="TextBox2"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server"  ID="txtCollaborativePhase2"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server"   ID="DomesticOrAbord3" ClientIDMode="Static"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server"  ID="txtDomesticOrAbord3"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td3">
                                            <asp:Label runat="server"  ID="CooperativeUnit3"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList3">
                                                <asp:Label runat="server"   ID="CollaborativePhase3" ClientIDMode="Static" Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label runat="server"  ID="TextBox3"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server"  ID="txtCollaborativePhase3"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server"   ID="DomesticOrAbord4" ClientIDMode="Static"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server"  ID="txtDomesticOrAbord4"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td4">
                                            <asp:Label runat="server"  ID="CooperativeUnit4"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList4">
                                                <asp:Label runat="server"   ID="CollaborativePhase4" ClientIDMode="Static" Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label runat="server"  ID="TextBox4"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server"  ID="txtCollaborativePhase4"  ClientIDMode="Static" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>建设单位
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server"  ID="DevelopmentOrganization"  ClientIDMode="Static" Width="95.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>施工单位
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server"  ID="ConstructionOrganization"  ClientIDMode="Static" Width="95.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>使用单位
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server"  ID="UseUnit"  ClientIDMode="Static" Width="95.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server"  ID="ConstructionLocation"  ClientIDMode="Static" Width="95.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>设计类别
                            </td>
                            <td colspan="2">
                                <div class="DeclarationList">
                                    <asp:Label runat="server"  ID="DesignCategory" ClientIDMode="Static"></asp:Label>
                                </div>
                                <div class="ExpertReviewList" style="display:none">
                                    <asp:Label runat="server"  ID="txtDesignCategory"  Width="90%" ClientIDMode="Static"></asp:Label>
                                </div>
                            </td>
                            <td>设计起止时间
                            </td>
                            <td style="margin-left:2.5%;">
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DesignStartDate" ></asp:Label><span style="padding:0 0.5em">至</span>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DesignEndDate" ></asp:Label>

                                </div>                              
                               
                            </td>
                        </tr>
                        <tr>
                            <td>开工时间
                            </td>
                            <td colspan="2">
                                <div >
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionStartDate" ></asp:Label>
                                </div>
                            </td>
                            <td>竣工时间
                            </td>
                            <td>
                                <div >
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionEndDate" ></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>竣工验收时间
                            </td>
                            <td colspan="2">
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="AcceptanceDate"></asp:Label>
                                </div>
                            </td>
                            <td>竣工验收部门
                            </td>
                            <td>
                                <asp:Label runat="server"  ID="AcceptanceDepartment"  ClientIDMode="Static" Width="68%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>消防备案时间
                            </td>
                            <td colspan="2">
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="FireControlRecordDate"></asp:Label>
                                </div>
                            </td>
                            <td>交付使用时间
                            </td>
                            <td>
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DeliveryDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>投资来源
                            </td>
                            <td colspan="4">
                                <div class="DeclarationList">
                                    <asp:Label runat="server"  ID="InvestSource" ClientIDMode="Static"></asp:Label>
                                </div>
                                <div class="ExpertReviewList" style="display:none">
                                    <asp:Label runat="server"  ID="txtInvestSource"  Width="90%" ClientIDMode="Static"></asp:Label>
                                </div>

                            </td>
                            <%--<td>申报等级
                            </td>--%>
                            <%--<td>
                                <asp:RadioButtonList  ID="DeclarationLevel" ClientIDMode="Static" RepeatDirection="Horizontal"></asp:RadioButtonList>
                            </td>--%>
                        </tr>
                        <tr>
                            <td>专业类别</td>
                            <td colspan="4">
                                <div class="DeclarationList">
                                    <asp:Label runat="server" ID="ProfessionalCategories" ClientIDMode="Static"></asp:Label>
                                </div>
                               
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane " id="btab2">
                <uc:Participant  ID="ParticipantReview" runat="server"></uc:Participant>
            </div>
            <div class="tab-pane " id="btab3">
                <asp:Panel runat="server" ID="panelPart_1002"  ClientIDMode="Static" GroupingText="技术申报内容">
                    <table>
                       <tr style="height: 200px;">
                            <td>项目概况
                            </td>
                            <td>
                                <asp:TextBox ID="ProjectOverview" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;" ClientIDMode="Static"></asp:TextBox>
                                <script id="ProjectOverviewTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td>技术特色
                            </td>
                            <td>
                                <asp:TextBox ID="TechnologyFeature" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;" ClientIDMode="Static"></asp:TextBox>
                                <script id="TechnologyFeatureTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td >技术成效 与深度                               
                            </td>
                            <td>
                                <asp:TextBox ID="Effect" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;" ClientIDMode="Static"></asp:TextBox>
                                <script id="EffectTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td>综合效益
                            </td>
                            <td>
                                <asp:TextBox ID="Benefit" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;" ClientIDMode="Static"></asp:TextBox>                                
                                <script id="BenefitTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="border: 0;">
                                <h3>技术指标及先进性</h3>
                            </td>
                        </tr>
                         <tr style="height: 200px;">
                            <td>建筑专业
                            </td>
                            <td>
                                <asp:TextBox ID="Indicators_Construct" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;" ClientIDMode="Static"></asp:TextBox>
                                <script id="Indicators_ConstructTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td >结构专业
                            </td>
                            <td>
                                <asp:TextBox ID="Indicators_Structure" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;" ClientIDMode="Static"></asp:TextBox>
                                <script id="Indicators_StructureTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td>暖通空调专业
                            </td>
                            <td>
                                <asp:TextBox ID="Indicators_HVAC" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;" ClientIDMode="Static"></asp:TextBox>
                                <script id="Indicators_HVACTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td>给排水专业
                            </td>
                            <td>
                                <asp:TextBox ID="Indicators_SupplyAndDrainage" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;" ClientIDMode="Static"></asp:TextBox>                                
                                <script id="Indicators_SupplyAndDrainageTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td>电气专业
                            </td>
                            <td>
                                <asp:TextBox ID="Indicators_Electric" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;" ClientIDMode="Static"></asp:TextBox>
                                <script id="Indicators_ElectricTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td>防护和防化专业
                            </td>
                            <td>
                                <asp:TextBox ID="Indicators_Antichemical" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;" ClientIDMode="Static"></asp:TextBox>                                
                                <script id="Indicators_AntichemicalTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane " id="btab4">
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
                     setPart8Data(data);
                 }
             });

             InitUEditor('ProjectOverviewTextBox',3000);              // 项目概况
             InitUEditor('TechnologyFeatureTextBox',3000);            // 技术特色
             InitUEditor('EffectTextBox',3000);                       // 技术成效与深度
             InitUEditor('BenefitTextBox',3000);                      // 综合效益
             InitUEditor('Indicators_ConstructTextBox', 3000);         // 建筑专业
             InitUEditor('Indicators_StructureTextBox', 3000);         // 结构专业
             InitUEditor('Indicators_HVACTextBox', 3000);              // 暖通空调专业
             InitUEditor('Indicators_SupplyAndDrainageTextBox', 3000); // 给排水专业
             InitUEditor('Indicators_ElectricTextBox',3000);          // 电气专业
             InitUEditor('Indicators_AntichemicalTextBox',3000);      // 防护和防化专业
           
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