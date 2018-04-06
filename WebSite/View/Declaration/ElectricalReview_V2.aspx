<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="ElectricalReview_V2.aspx.cs" Inherits="Evaluation.View.Declaration.ElectricalReview_V2" validateRequest="false" %>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/ParticipantReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/AppendixReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStatesReview_V2.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/CertificateReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/Css/Declaration.css" rel="stylesheet" />

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

        /*#edui1_toolbarbox {
            position: initial;
            z-index: 0;
        }

        #edui1 {
            z-index: 0;
        }*/
        /*#ueditor,#ueditor2,#ueditor7,#ueditor8{
            text-align:left;
        }
        #edui1_iframeholder{
            height:300px;
        }*/
        
        #btn_018Prev{
            margin-left: 43%;
            margin-top:40px; 
        }

        #AcceptanceDepartment{
            float:none!important; margin-left:4px;
        }

        /*#TechnologyFeatureTextBox{
            width:89%;
        }
        #content #test{
            height:2500px!important;
        }*/
        /*#ProjectOverviewTextBox,#ComprehensiveBenefitTextBox{
            text-align:left;width:99%;
        }*/

        .review.Award{
              text-align:left;width:99%;
        }
         #AppendixTable  td a,#AtlasTable  td a{
            margin:0 0.5em
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
         /*#ProjectOverviewTextBox,#TechnologyFeatureTextBox,#ComprehensiveBenefitTextBox{
            text-align:left;width:90%;margin-left:10px;
        }*/
         .review.Award{
             text-align:left;width:90%;margin-left:10px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">   
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01">评优管理</a><a href="../Declaration/Declare.aspx?SepcCode=070000" id="nav02">项目审核</a><a href="#" id="nav03"></a>
        </li>
    </ul>
     <div style="display: none">
        <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox></div>  
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
                <asp:Panel runat="server"  ClientIDMode="Static" ID="panelPart_0701"   GroupingText="项目基本情况">
                    <table>
                       <tr>
                            <td style="width: 130px;">项目名称
                            </td>
                            <td colspan="4">
                                <asp:Label ID="DeclarationName" runat="server" ClientIDMode="Static" Width="95.3%"></asp:Label>                              
                        </tr>
                        <tr>
                            <td>申报单位
                            </td>
                            <td colspan="4">
                                <asp:Label ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="95.3%"></asp:Label>                                
                            </td>
                        </tr>
                       <tr>
                            <td>境内、外合作设计单位</td>
                            <td style="padding: 0;" colspan="4">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 30.4%; border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server"  ClientIDMode="Static"  ID="DomesticOrAbord1" ></asp:Label>
                                            </div>
                                        </td>
                                        <td style="width: 23.8%; border-right: none; text-align: center;">
                                            <asp:Label runat="server"  ClientIDMode="Static" ID="CooperativeUnit1"   Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none; width: 35%;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList1">
                                                <asp:Label runat="server"  ClientIDMode="Static"  ID="CollaborativePhase1"  Width="200px"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server"  ClientIDMode="Static"  ID="DomesticOrAbord2" ></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td2">
                                            <asp:Label runat="server"  ClientIDMode="Static" ID="CooperativeUnit2"   Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList2">
                                                <asp:Label runat="server"  ClientIDMode="Static"  ID="CollaborativePhase2"  Width="200px"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server"  ClientIDMode="Static"  ID="DomesticOrAbord3" ></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td3">
                                            <asp:Label runat="server"  ClientIDMode="Static" ID="CooperativeUnit3"   Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList3">
                                                <asp:Label runat="server"  ClientIDMode="Static"  ID="CollaborativePhase3"  Width="200px"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server"  ClientIDMode="Static"  ID="DomesticOrAbord4" ></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td4">
                                            <asp:Label runat="server"  ClientIDMode="Static" ID="CooperativeUnit4"   Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList4">
                                                <asp:Label runat="server"  ClientIDMode="Static"  ID="CollaborativePhase4"  Width="200px"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                设计单位
                            </td>
                            <td>
                                <asp:Label ID="DevelopmentOrganization" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>
                            </td>
                            <td>
                                施工单位
                            </td>
                            <td>
                                <asp:Label ID="ConstructionOrganization" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>
                            </td>

                        </tr>                                                    
                        <tr>
                            <td>工程起止时间
                            </td>
                            <td style="margin-left:2.5%;">
                                <div>
                                    <asp:Label ID="DesignStartDate" runat="server" ClientIDMode="Static" ></asp:Label><span style="padding:0 5px;"> 至 </span>
                                    <asp:Label ID="DesignEndDate"  runat="server" ClientIDMode="Static"></asp:Label>
                                </div>                               
                            </td>
                            <td>竣工验收时间
                            </td>
                            <td colspan="2">
                                <div>
                                    <asp:Label ID="AcceptanceDate" runat="server" ClientIDMode="Static" ></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                验收部门
                            </td> 
                            <td colspan="4">
                                <asp:Label ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>
                            </td> 
                        </tr> 
                        <tr>
                            <td>申报单位<br />通讯地址
                            </td>
                            <td colspan="4">
                                <asp:Label ID="PostalAddress" runat="server" ClientIDMode="Static" Width="94.5%"></asp:Label>                         
                            </td>
                        </tr>
                        <tr>
                            <td>
                                单位资质
                            </td>
                            <td>
                                <asp:Label ID="Qualification" runat="server" ClientIDMode="Static" Width="94.5%"></asp:Label>
                            </td>
                            <td>
                                证书编号
                            </td>
                            <td>
                                <asp:Label ID="CertificateNumber" runat="server" ClientIDMode="Static" Width="94.5%"></asp:Label>
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
                                <asp:Label ID="MobileNumber" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>                             
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
                                <asp:Label ID="Postcode" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>                           
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
                                <asp:Label ID="EmailAddress" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>                             
                            </td>
                        </tr>                   
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant  runat="server" id="ParticipantReview"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel runat="server"  ClientIDMode="Static" ID="panelPart_0702"   GroupingText="技术申报内容">
                    <table>
                       <tr style="height: 200px;">
                            <td colspan="1">项目概况</td>
                            <td colspan="4">
                                <p style="padding-left:10px;">（项目总体介绍、项目规模、复杂程度及影响程度等，限500字）</p>
                                <asp:TextBox ID="ProjectOverview" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 200px;"></asp:TextBox>
                                <script id="ProjectOverviewTextBox" class="review" type="text/plain" style="height: 300px;"></script>                                
                            </td>
                        </tr>
                       <tr>
                            <td  style="padding:10px;">技术特点</td>
                            <td  style="height: 300px;">
                                <p style="padding-left:10px;">（技术特点、先进性与创新性，主要的技术指标，采用节能技术与效果，限1500字)</p>
                                <asp:TextBox ID="TechnologyFeature" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="TechnologyFeatureTextBox" class="review"  type="text/plain" style="height: 300px;"></script>                               
                            </td>
                        </tr>
                      <%--  <tr>
                            <td style="padding:7px;">系统类别
                            </td>
                            <td colspan="2">规模
                            </td>
                            <td>特点（安全性、可靠性、灵活性）
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="3" style="width: 120px;">供配电系统
                            </td>
                            <td style="width: 120px;">电力总用<br />
                                电负荷
                            </td>
                            <td>
                                <asp:Label runat="server"  ClientIDMode="Static" ID="TotalElectricityload"   Width="78%"></asp:Label>
                                kW

                            </td>
                            <td rowspan="3">
                                <asp:Label runat="server"  ClientIDMode="Static" ID="PowerSupplySystemTrait"   Style="width: 97%; height: 300px;display:block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>变压器装<br />
                                机密度
                            </td>
                            <td>
                                <asp:Label runat="server"  ClientIDMode="Static" ID="TransformerDensity"   Width="70%"></asp:Label>
                                kVA/㎡
                            </td>
                        </tr>
                        <tr>
                            <td>备用电源<br />
                                装机密度
                            </td>
                           <td>
                                <asp:Label runat="server"  ClientIDMode="Static" ID="StandbyElectricityDensity"   Style="width: 25%"></asp:Label>
                                KVA/㎡或<asp:Label runat="server"  ClientIDMode="Static" ID="StandbyElectricityDensityKW"   Style="width: 25%"></asp:Label>KW/㎡
                            </td>
                        </tr>
                        <tr>
                            <td>配变电所
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server"  ClientIDMode="Static" ID="Substation_Scale"   Width="95%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server"  ClientIDMode="Static" ID="Substation_Trait"   Width="90%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>自备应急电源供配电系统特点</td>                            
                            <td colspan="2">
                                <asp:Label runat="server"  ClientIDMode="Static" ID="EmergencyPowerSupply_Scale"   Width="95%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server"  ClientIDMode="Static" ID="EmergencyPowerSupply_Trait"   Width="90%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>低压配电系统</td>
                            <td colspan="2">
                                <asp:Label runat="server"  ClientIDMode="Static" ID="LowVoltageDistributionSystem_Scale"   Width="95%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server"  ClientIDMode="Static" ID="LowVoltageDistributionSystem_Trait"   Width="90%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>配电线路布线<br />系统</td>
                            <td colspan="2">
                                <asp:Label runat="server"  ClientIDMode="Static" ID="WiringSystem_Scale"   Width="95%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server"  ClientIDMode="Static" ID="WiringSystem_Trait"   Width="90%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>电气照明系统</td>
                            <td colspan="2">
                                <asp:Label runat="server"  ClientIDMode="Static" ID="Lighting_Scale"   Width="95%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server"  ClientIDMode="Static" ID="Lighting_Trait"   Width="90%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>建筑物防雷及<br />接地系统</td>
                            <td colspan="2">
                                <asp:Label runat="server"  ClientIDMode="Static" ID="Grounding_Scale"   Width="95%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server"  ClientIDMode="Static" ID="Grounding_Trait"   Width="90%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>电气消防系统</td>
                            <td colspan="2">
                                <asp:Label runat="server"  ClientIDMode="Static" ID="FireFightingSystem_Scale"   Width="95%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server"  ClientIDMode="Static" ID="FireFightingSystem_Trait"   Width="90%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>其他相关电气<br />系统</td>
                            <td colspan="2">
                                <asp:Label runat="server"  ClientIDMode="Static" ID="OtherElectricalSystems_Scale"   Width="95%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server"  ClientIDMode="Static" ID="OtherElectricalSystems_Trait"   Width="90%"></asp:Label>
                            </td>
                        </tr>--%>
                        <tr style="height: 300px;">
                            <td >综合效益
                            </td>
                            <td >
                                <p style="padding-left:10px;">（项目产生的经济、社会、环境效益，限500字）</p>
                                <asp:TextBox ID="ComprehensiveBenefit" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="ComprehensiveBenefitTextBox" class="review"  type="text/plain" style="height: 300px;"></script>                              
                            </td>
                        </tr>
                    </table>
                       <br />
                    <h3 style="text-align:center;">建筑电气项目建设内容</h3> 
                    <table>
                         <tr>
                            <td>系统类别
                            </td>
                            <td>建设内容及规模
                            </td>
                            <td>特点
                            </td>
                        </tr>
                        <tr>
                            <td style="width:33%;">供配电系统
                            </td>
                            <td style="width:33%;">
                                <asp:Label ID="PowerSupplySystemTrait_Scale" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="PowerSupplySystemTrait" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td>配变电所
                            </td>
                            <td>
                                <asp:Label ID="Substation_Scale" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="Substation_Trait" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td>自备应急电源
                            </td>
                            <td>
                                <asp:Label ID="EmergencyPowerSupply_Scale" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="EmergencyPowerSupply_Trait" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td>低压配电系统
                            </td>
                            <td>
                                <asp:Label ID="LowVoltageDistributionSystem_Scale" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="LowVoltageDistributionSystem_Trait" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td>配电线路布线系统
                            </td>
                            <td>
                                <asp:Label ID="WiringSystem_Scale" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="WiringSystem_Trait" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td>电气照明系统
                            </td>
                            <td>
                                <asp:Label ID="Lighting_Scale" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="Lighting_Trait" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td>民用建筑物防雷及接地系统
                            </td>
                            <td>
                                <asp:Label ID="Grounding_Scale" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="Grounding_Trait" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td>火灾自动报警系统 <br />（强条规定内容）
                            </td>
                            <td>
                                <asp:Label ID="FireFightingSystem_Scale" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="FireFightingSystem_Trait" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td>其他相关电气系统
                            </td>
                            <td>
                                <asp:Label ID="OtherElectricalSystems_Scale" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="OtherElectricalSystems_Trait" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%;height: 150px;"></asp:Label>                                
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
              <uc:LegalStates runat="server" id="LegalStatesReview"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab6">
              <uc:Certificate runat="server" id="CertificateReview"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab7">
              <uc:Comments runat="server" id="ucComments"></uc:Comments>
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

             InitUEditor('ProjectOverviewTextBox', 500);              // 项目概况
             InitUEditor('TechnologyFeatureTextBox', 1500);           // 技术特点
             InitUEditor('ComprehensiveBenefitTextBox', 500);         // 综合效益
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
