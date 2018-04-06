<%@ Page Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="BIMReview.aspx.cs" Inherits="Evaluation.View.Declaration.BIMReview" validateRequest="false" %>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/ParticipantReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/AppendixReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStatesReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/CertificateReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/Css/Declaration.css" rel="stylesheet" />
     
    <!--tabdrop-->
   <script type="text/javascript" charset="utf-8" src="../../Content/Javascript/DeclarationReview.js"></script>

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
        input{
            text-align:center;
        }
        .ui-choose{
            margin-left:15px;
        }
        tbody > tr > td:nth-child(2) > div {
            left: -13px !important;
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
            height:300px;
        }
        
        #btn_018Prev{
            margin-left: 43%;
            margin-top:40px; 
        }
  
        #content #test{
            height:2500px!important;
        }
        #BIM_TechnologyTextBox,#InnovationHighlightsTextBox,#BIM_Technology_ValueTextBox,#ExperienceSummaryTextBox{
            text-align:left;width:85%;
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
     <ul class="navs">
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#" id="nav01"></a><a id="nav02" ></a><a href="#" id="nav03"></a>
         </li>        
    </ul>
     <div style="display: none">
        <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox></div>    
    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、建筑专业</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、附件目录</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、法人声明</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、合作声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab" class="ExpertReviewList2" style="display: none;">7、评审意见</a></li>
        </ul>

        <div class="tab-content"  id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0501">
                    <table>
                        <tr>
                            <td style="width: 100px;">项目名称</td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationName"   Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">申报单位</td>
                            <td style="width: 100px;">申报单位</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationUnit"   Width="96.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>通讯地址</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="PostalAddress"   Width="96.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>联系人</td>
                            <td style="width: 30%">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Linkman"   Width="91.5%"></asp:Label>
                            </td>
                            <td>手机</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MobileNumber"    Width="93.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>电话</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TelephoneNumber"   Width="91.5%"></asp:Label>
                            </td>
                            <td>邮政编码</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Postcode"   Width="93.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>传真</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FaxNumber"   Width="91.5%"></asp:Label>
                            </td>
                            <td>电子邮箱</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="EmailAddress"   Width="93.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>境内、外合作设计单位</td>
                            <td style="padding: 0;" colspan="4">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 30.4%; border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static"  ID="DomesticOrAbord1" ></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord1"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="width: 23.8%; border-right: none; text-align: center;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit1"   Style="width: 88%;" onblur="Sensitize('CooperativeUnit1','CollaborativePhase01')"></asp:Label>
                                        </td>
                                        <td style="border-right: none; width: 35%;" class="Selects">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static"  ID="CollaborativePhase1"  Width="200px"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static"  ID="DomesticOrAbord2" ></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord2"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td2">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit2"   Style="width: 88%;" onblur="Sensitize('CooperativeUnit2','CollaborativePhase02')"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static"  ID="CollaborativePhase2"  Width="200px"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static"  ID="DomesticOrAbord3" ></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord3"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td3">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit3"   Style="width: 88%;" onblur="Sensitize('CooperativeUnit3','CollaborativePhase03')"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static"  ID="CollaborativePhase3"  Width="200px"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static"  ID="DomesticOrAbord4" ></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord4"   Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td4">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit4"   Style="width: 88%;" onblur="Sensitize('CooperativeUnit4','CollaborativePhase04')"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static"  ID="CollaborativePhase4"  Width="200px"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>建设单位</td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DevelopmentOrganization"   Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>施工单位</td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionOrganization"   Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点</td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionLocation"   Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>设计类别</td>
                            <td colspan="2">
                                <div class="DeclarationList">
                                    <asp:Label runat="server" ClientIDMode="Static"  ID="DesignCategory" ></asp:Label>
                                </div>
                            </td>
                            <td style="width: 100px;">设计起止时间</td>
                            <td style="margin-left:2.5%;">
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DesignStartDate"></asp:Label><span style="padding:0 0.5em">至</span>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DesignEndDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>建设时间</td>
                            <td colspan="2">
                                <div style="margin:0px auto">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionStartDate"></asp:Label>
                                </div>
                            </td>
                            <td>交付使用时间</td>
                            <td>
                                <div style="margin:0px auto">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DeliveryDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>竣工时间</td>
                            <td colspan="2">
                                <div style="margin:0px auto">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionEndDate"></asp:Label>
                                </div>
                            </td>
                            <td>验收时间</td>
                            <td>
                                <div style="margin:0px auto">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="AcceptanceDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>验收部门</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AcceptanceDepartment"   Width="94%"></asp:Label>
                            </td>
                            <td>建筑规模</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BuildingScale"   Width="93%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>建筑用途<br />
                                （性质）</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UseProperty"   Width="94%"></asp:Label>
                            </td>
                            <td>建筑高度</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BuildingHeight"   Width="93%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>地上层数</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Layer_Ground"   Width="94%"></asp:Label>
                            </td>
                            <td>地下层数</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Layer_Underground"   Width="93%"></asp:Label>
                            </td>
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
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" id="ucParticipantReview"></uc:Participant>
            </div> 
            <div class="tab-pane" id="btab3">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0502"   GroupingText="技术申报内容（建筑专业）">
                    <table>
                        <tr>
                            <td style="padding:10px;width:150px;">BIM软件名称
                            </td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="BIMName"   Width="97.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>专业</td>
                            <td>规划方案</td>
                            <td>初步设计</td>
                            <td>施工图</td>
                            <td>施工</td>
                            <td>运营维护</td>
                        </tr>
                        <tr>
                            <td>建筑
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Building_PlanningScheme"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Building_PreliminaryDesign"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Building_Construction_Plans"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Building_Construction"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Building_Operation"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>结构
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Architecture_PlanningScheme"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Architecture_PreliminaryDesign"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Architecture_Construction_Plans"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Architecture_Construction"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Architecture_Operation"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>水
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Water_PlanningScheme"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Water_PreliminaryDesign"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Water_Construction_Plans"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Water_Construction"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Water_Operation"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>电气
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Electric_PlanningScheme"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Electric_PreliminaryDesign"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Electric_Construction_Plans"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Electric_Construction"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Electric_Operation"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>暖通
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HVAC_PlanningScheme"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HVAC_PreliminaryDesign"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HVAC_Construction_Plans"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HVAC_Construction"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HVAC_Operation"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>总图
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="GeneralPlan_PlanningScheme"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="GeneralPlan_PreliminaryDesign"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="GeneralPlan_Construction_Plans"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="GeneralPlan_Construction"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="GeneralPlan_Operation"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>经济
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Economics_PlanningScheme"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Economics_PreliminaryDesign"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Economics_Construction_Plans"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Economics_Construction"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Economics_Operation"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>规划
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Planning_PlanningScheme"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Planning_PreliminaryDesign"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Planning_Construction_Plans"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Planning_Construction"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Planning_Operation"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>景观
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Scenery_PlanningScheme"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Scenery_PreliminaryDesign"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Scenery_Construction_Plans"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Scenery_Construction"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Scenery_Operation"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>市内
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Inside_PlanningScheme"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Inside_PreliminaryDesign"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Inside_Construction_Plans"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Inside_Construction"   Width="86.5%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Inside_Operation"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: center;padding-left:10px;">
                                <p>请在相应的BIM应用阶段与应用专业的节点处选出应用的领域，可多选（数目不限）；</p>

                                <p>例如在施工图阶段，电气专业应用了BIM模型维护及场地分析，在相应空格处填写A、B。</p>

                                <p>A. BIM模型维护</p>

                                <p>B. 场地分析</p>

                                <p>C. 建筑策划</p>

                                <p>D. 方案论证</p>

                                <p>E. 可视化设计</p>

                                <p>F. 协同设计</p>

                                <p>G. 性能化分析</p>

                                <p>H. 工程量统计</p>

                                <p>I. 管线综合</p>

                                <p>J. 施工进度模拟</p>

                                <p>K. 施工组织模拟</p>

                                <p>L. 数字化建造</p>

                                <p>M. 物料跟踪</p>

                                <p>N. 施工现场配合</p>

                                <p>O. 竣工模型交付</p>

                                <p>P. 维护计划</p>

                                <p>Q. 资产管理</p>

                                <p>R. 空间管理</p>

                                <p>S. 建筑系统分析</p>

                                <p>T. 灾害应急模拟</p>
                            </td>
                        </tr>
                        <tr>
                            <td>项目设计中BIM
                                技术的应用
                            </td>
                            <td colspan="5">
                                <asp:TextBox runat="server" ClientIDMode="Static" ID="BIM_Technology"   TextMode="MultiLine" style="width:98%;min-height:300px;display:block">
                                </asp:TextBox>                          
                                <script id="BIM_TechnologyTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>项目设计及软
                                件应用中的
                                创新亮点
                            </td>
                            <td colspan="5">
                                <asp:TextBox runat="server" ClientIDMode="Static" ID="InnovationHighlights"   TextMode="MultiLine" style="width:98%;min-height:300px;display:block">
                                </asp:TextBox>                          
                                <script id="InnovationHighlightsTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>应用BIM技术的
                                价值
                            </td>
                            <td colspan="5">
                                <asp:TextBox runat="server" ClientIDMode="Static" ID="BIM_Technology_Value"   TextMode="MultiLine" style="width:98%;min-height:300px;display:block">
                                </asp:TextBox>                          
                                <script id="BIM_Technology_ValueTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>应用心得总结
                            </td>
                            <td colspan="5">
                                <asp:TextBox runat="server" ClientIDMode="Static" ID="ExperienceSummary"   TextMode="MultiLine" style="width:98%;min-height:300px;display:block">
                                </asp:TextBox>                          
                                <script id="ExperienceSummaryTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab4">
                <uc:Appendix runat="server" ClientIDMode="Static" id="AppendixReview"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab5">
              <uc:LegalStates runat="server" ClientIDMode="Static" id="LegalStatesReview"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab6">
              <uc:Certificate runat="server" ClientIDMode="Static" id="CertificateReview"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab7">
              <uc:Comments runat="server" ClientIDMode="Static" id="ucComments"></uc:Comments>
            </div> 
        </div>
    </div>
     <script type="text/javascript">
         function setData(data) {
             data = JSON.parse(data)[1];          
             for (var i = 0; i < data.length; i++) {
                 var oval;
                 if (data[i].RecordType == "select") {
                     oval = data[i].ConstantValue?data[i].ConstantValue:"---";
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
             console.log( JSON.parse(data))
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

             InitUEditor('BIM_TechnologyTextBox', 2000);                 // 项目设计中BIM技术的应用
             InitUEditor('InnovationHighlightsTextBox', 2000);           // 项目设计及软件应用中的创新亮点
             InitUEditor('BIM_Technology_ValueTextBox', 2000);           // 应用BIM技术的价值
             InitUEditor('ExperienceSummaryTextBox', 2000);              // 应用心得总结
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