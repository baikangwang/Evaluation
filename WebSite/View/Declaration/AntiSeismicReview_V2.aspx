<%@ Page  Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="AntiSeismicReview_V2.aspx.cs" Inherits="Evaluation.View.Declaration.AntiSeismicReview_V2"  validateRequest="false"%>

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
        #edui1_toolbarbox {
            position: initial;
            z-index: 0;
        }

        #edui1 {
            z-index: 0;
        }
        /*#ueditor,#ueditor2,#ueditor7,#ueditor8{
            text-align:left;
        }*/
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
            margin-left:4px;
        }


        #content #test{
            height:2500px!important;
        }
        legend{
            margin-bottom: 0px!important;
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
          /*#AwardsTextBox,#UnitOpinionTextBox,#RecommendOpinionTextBox{
            text-align:left;margin-left:8px;width:85%;
        }*/ 
          .review.Award{
               text-align:left;margin-left:8px;width:85%;
          }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <ul class="navs">
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#" id="nav01"></a><a href="../Declaration/Declare.aspx?SepcCode=110000" id="nav02" runat="server" ClientIDMode="Static"></a><a href="#" id="nav03"></a>
        </li>       
    </ul>
    <div style="display: none">
        <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox></div>    
    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather"> 
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、抗震隔震</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、消能减震</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、经济指标</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、附件目录</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab">7、代表声明</a></li>
            <li><a id="tab_08" href="#btab8" data-toggle="tab">8、合作声明</a></li>
            <li><a id="tab_09" href="#btab9" data-toggle="tab" class="ExpertReviewList2" style="display: none;">9、评审意见</a></li>
        </ul>

        <div class="tab-content"  id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_1101"   GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 130px;">项目名称
                            </td>
                            <td colspan="4">
                                <asp:Label ID="DeclarationName" runat="server" ClientIDMode="Static" Width="95.3%"></asp:Label>                             
                            </td>
                        </tr>
                        <tr>
                            <td>主要设计单位
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
                                                <asp:Label runat="server" ClientIDMode="Static" ID="DomesticOrAbord1"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord1" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="width: 23.8%; border-right: none; text-align: center;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit1" Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none; width: 35%;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList1">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="CollaborativePhase1" Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="TextBox1" Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtCollaborativePhase1" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="DomesticOrAbord2"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord2" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td2">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit2" Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList2">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="CollaborativePhase2" Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="TextBox2" Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtCollaborativePhase2" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="DomesticOrAbord3"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord3" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td3">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit3" Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList3">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="CollaborativePhase3" Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="TextBox3" Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtCollaborativePhase3" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="DomesticOrAbord4"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord4" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td4">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit4" Style="width: 88%;"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList4">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="CollaborativePhase4" Width="200px"></asp:Label>
                                            </div>
                                            <div style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="TextBox4" Style="width: 88%;"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtCollaborativePhase4" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>    
                        <tr>
                            <td>工程设计起止时间
                            </td>
                            <td style="margin-left:2.5%;">
                                <div>
                                    <asp:Label ID="DesignStartDate" runat="server" ClientIDMode="Static" ></asp:Label><span style="padding:0 5px;"> 至 </span>
                                     <asp:Label ID="DesignEndDate"  runat="server" ClientIDMode="Static" ></asp:Label>
                                </div>                              
                            </td>
                            <td>竣工验收时间
                            </td>
                            <td colspan="2">
                                <div>
                                    <asp:Label ID="AcceptanceDate" runat="server" ClientIDMode="Static"></asp:Label>                                    
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
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant  id="ParticipantReview" runat="server"></uc:Participant>
            </div> 
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_1102"   GroupingText="抗震—技术申报内容—隔震">
                    <table>
                        <tr>
                            <td style="border: 0;" colspan="8">
                                <h3>Ⅰ——隔震工程项目情况表</h3>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 0; text-align: left;" colspan="8">
                                <p>1、总体信息编号：</p>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">项目名称
                            </td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockProjectName"   Width="95%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockProjectName"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>用途
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockPurpose"   Width="75%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockPurpose"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockConstructionSite"   Width="94%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockConstructionSite"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>建设时间
                            </td>
                            <td colspan="2">
                                <div >
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ShockConstructionTime"></asp:Label>
                                    <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none"  ID="IsAntiSeismicShockConstructionTime"  ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>总高度<br />
                                (m)
                            </td>
                            <td style="width:10%">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockTotalHeight"   Width="78%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockTotalHeight"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td style="width: 80px;">占地面积<br />
                                (㎡)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockCoveredArea"   Width="78%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockCoveredArea"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td style="width: 120px;">建筑面积<br />
                                (㎡)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockConstructionArea"   Width="78%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockConstructionArea"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td style="width: 120px;">隔震层面积<br />
                                (㎡)
                            </td>
                            <td style="width:10%">
                                <asp:Label runat="server" ClientIDMode="Static" ID="IsolationLayerArea"   Width="78%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicIsolationLayerArea"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>高宽比
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockHighAspectRatio"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockHighAspectRatio"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>层数
                            </td>
                            <td style="padding: 0">
                                <table>
                                    <tr>
                                        <td style="width: 53px;">地上
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="ShockLayer_Ground"   Width="68%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockLayer_Ground"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>地下
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="ShockLayer_Underground"   Width="68%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockLayer_Underground"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>首层层高<br />
                                (m)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockFirstStoreyHeight"   Width="78%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockFirstStoreyHeight"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>标准层高<br />
                                (m)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockStandardHeight"   Width="78%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockStandardHeight"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设单位
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TechnologyDevelopmentOrganization"   Width="93%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTechnologyDevelopmentOrganization"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>施工单位
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TechnologyConstructionOrganization"   Width="93%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTechnologyConstructionOrganization"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计单位
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockDesignOrganization"   Width="93%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="ShockIsAntiSeismicDesignOrganization"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>施工图审查<br />
                                机构
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockConstructionPlansCensorship"   Width="93%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockConstructionPlansCensorship"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>混凝土总用<br />
                                量(m3)
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockConcreteAmount"   Width="93%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockConcreteAmount"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>每平方米混<br />
                                凝土折算厚<br />
                                度(cm/㎡)
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockPerSqM_ConcreteReducedThickness"   Width="93%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockPerSqM_ConcreteReducedThickness"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>钢材总用量<br />
                                (t)
                            </td>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width:30%">钢筋
                                        </td>
                                        <td style="border-right: none;" >
                                            <asp:Label runat="server" ClientIDMode="Static" ID="ShockSteelAmount_rebar"   Width="91%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockSteelAmount_rebar"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td  style="width:30%">型钢
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="ShockSteelAmount_SectionSteel"   Width="91%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockSteelAmount_SectionSteel"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>每平方米钢<br />
                                材用量(kg)
                            </td>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td  style="width:30%">钢筋
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="ShockPerSqM_SteelAmount_Rebar"   Width="91%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockPerSqM_SteelAmount_Rebar"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td  style="width:30%">型钢
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="ShockPerSqM_SteelAmount_SectionSteel"   Width="91%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockPerSqM_SteelAmount_SectionSteel"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <table>
                        <tr>
                            <td style="border: 0; text-align: left; margin-top:10px;" colspan="8">
                                <p>2、隔震设计概要</p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">所在地区设防地震加速度参<br />
                                数(g)
                            </td>
                            <td colspan="7">
                                <div class="DeclarationList">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockSeismicAccelerationParameter"   Width="97%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="txtShockSeismicAccelerationParameter"   Style="width: 88%;"></asp:Label>
                                </div>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockSeismicAccelerationParameter"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">设计基本地震动加速度(g)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockBasicSeismicAcceleration"   Width="77%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockBasicSeismicAcceleration"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">场地类别
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockSiteType"   Width="77%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockSiteType"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">特征周期<br />
                                (s)
                            </td>
                            <td style="width: 100px;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockEigenperiod"   Width="77%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockEigenperiod"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">抗震设防<br />
                                类别
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockFortificationCategory"   Width="77%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockFortificationCategory"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">时程分析用地震波（名称/调幅值(gal)/特征周期（s））
                            </td>
                            <td colspan="7">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockTimeHistoryAnalysis"   Width="97%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockTimeHistoryAnalysis"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">液化、震陷、断裂等不利场<br />
                                地因素措施
                            </td>
                            <td colspan="7">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockAdverseFactorsMmeasures"   Width="97%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockAdverseFactorsMmeasures"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 80px;">基础形式
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockBaseType"   Width="82%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockBaseType"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">上部结构形式
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockUpperStructureForm"   Width="88%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockUpperStructureForm"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">地下室结构形式
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockBasementStructuralForm"   Width="78%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockBasementStructuralForm"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">隔震层位置（标高和层）
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockIsolationLayerLocation"   Width="87%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockIsolationLayerLocation"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">水平向减震系数
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ShockHorizontalDampingCoefficient"   Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicShockHorizontalDampingCoefficient"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">隔震设计基本周期(s)
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="IsolationDesignBasePeriod"   Width="87%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicIsolationDesignBasePeriod"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">上部结构基本周期(s)
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UpperStructureBasePeriod"   Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicUpperStructureBasePeriod"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">隔震支座实际使用平均面压<br />
                                最大最小面压(MPa)
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SurfacePressure"   Width="87%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicSurfacePressure"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">隔震支座设计最大位移(cm)
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxDisplacement"   Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMaxDisplacement"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">隔震层顶板体系
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="RoofSystem"   Width="87%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicRoofSystem"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">隔震层下支墩（柱）主要断面
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MainSection"   Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMainSection"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">总质量（t）
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TotalMass"   Width="87%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTotalMass"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">阻尼比(%)
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DampingRatio"   Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingRatio"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                    </table>
                    <table>
                        <tr>
                            <td style="border: 0; text-align: left; margin-top:10px;" colspan="8">
                                <p>3、抗震分析概要</p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">程序名称
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DampingSeismicAnalysisProgramName"   Width="96%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingSeismicAnalysisProgramName"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="8" style="width: 50px;">抗<br />
                                震<br />
                                分<br />
                                析<br />
                                结<br />
                                果
                            </td>
                            <td rowspan="2" style="width: 200px;">分析结果
                            </td>
                            <td colspan="2">中震
                            </td>
                            <td colspan="2">大震
                            </td>
                        </tr>
                        <tr>
                            <td>横向
                            </td>
                            <td>纵向
                            </td>
                            <td>横向
                            </td>
                            <td>纵向
                            </td>
                        </tr>
                        <tr>
                            <td>隔震器最大变形 (mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Isolation_M_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicSeismicIsolation_M_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Isolation_M_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicIsolation_M_V"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Isolation_L_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicIsolation_L_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Isolation_L_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicIsolation_L_V"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>基底最大剪力(kN）
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_M_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBaseShear_M_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_M_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBaseShear_M_V"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_L_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBaseShear_L_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_L_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBaseShear_L_V"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屋顶最大相对位移 (mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="RoofDrift_M_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicRoofDrift_M_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="RoofDrift_M_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicRoofDrift_M_V"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="RoofDrift_L_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicRoofDrift_L_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="RoofDrift_L_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicRoofDrift_L_V"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>最大层间相对位移 (mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="StoreyDrift_M_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicStoreyDrift_M_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="StoreyDrift_M_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicStoreyDrift_M_V"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="StoreyDrift_L_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicStoreyDrift_L_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="StoreyDrift_L_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicStoreyDrift_L_V"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>最大层间位移角
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="StoryDriftRatio_M_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicStoryDriftRatio_M_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="StoryDriftRatio_M_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicStoryDriftRatio_M_V"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="StoryDriftRatio_L_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicStoryDriftRatio_L_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="StoryDriftRatio_L_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicStoryDriftRatio_L_V"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>最大反应加速度 (g)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Acceleration_M_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicAcceleration_M_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Acceleration_M_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicAcceleration_M_V"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Acceleration_L_H"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicAcceleration_L_H"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Acceleration_L_V"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicAcceleration_L_V"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                    </table>
                    <table>
                        <tr>
                            <td style="border: 0; text-align: left; margin-top:10px;" colspan="8">
                                <p>4、减隔震装置概要</p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">生产企业
                            </td>
                            <td colspan="5" style="padding: 0;">
                                <table>
                                    <tr>
                                        <td>隔震支座：
                                        </td>
                                        <td style="width:26%;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Manufacturer_IsolationBearing"   Width="90%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicManufacturer_IsolationBearing"  Checked="true"  ToolTip="公开" />
                                        </td>
                                        <td>阻尼器：
                                        </td>
                                        <td style="border-right: none;width:24%;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Manufacturer_Damper"   Width="91%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicManufacturer_Damper"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="16" style="width: 30px;">隔<br />
                                震<br />
                                支<br />
                                座
                            </td>
                            <td colspan="2" style="width: 150px;">型号
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_Model1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_Model1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_Model2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_Model2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_Model3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_Model3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_Model4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_Model4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_Model5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_Model5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">个数
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_Number1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_Number1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_Number2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_Number2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_Number3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_Number3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_Number4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_Number4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_Number5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_Number5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">有效直径(mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_EffectiveDiameter1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_EffectiveDiameter1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_EffectiveDiameter2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_EffectiveDiameter2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_EffectiveDiameter3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_EffectiveDiameter3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_EffectiveDiameter4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_EffectiveDiameter4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_EffectiveDiameter5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_EffectiveDiameter5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">铅芯直径(mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_LeadDiameter1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_LeadDiameter1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_LeadDiameter2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_LeadDiameter2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_LeadDiameter3"   Width="88%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_LeadDiameter3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_LeadDiameter4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_LeadDiameter4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_LeadDiameter5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_LeadDiameter5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">产品外径(mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_OutsideDiameter1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_OutsideDiameter1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_OutsideDiameter2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_OutsideDiameter2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_OutsideDiameter3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_OutsideDiameter3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_OutsideDiameter4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_OutsideDiameter4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_OutsideDiameter5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_OutsideDiameter5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">橡胶层总厚度(mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_RubberThickness1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_RubberThickness1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_RubberThickness2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_RubberThickness2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_RubberThickness3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_RubberThickness3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_RubberThickness4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_RubberThickness4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_RubberThickness5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_RubberThickness5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">一次形状系数
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_LinearShapeFactor1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_LinearShapeFactor1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_LinearShapeFactor2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_LinearShapeFactor2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_LinearShapeFactor3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_LinearShapeFactor3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_LinearShapeFactor4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_LinearShapeFactor4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_LinearShapeFactor5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_LinearShapeFactor5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">二次形状系数
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_QuadraticShapeFactor1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_QuadraticShapeFactor1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_QuadraticShapeFactor2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_QuadraticShapeFactor2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_QuadraticShapeFactor3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_QuadraticShapeFactor3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_QuadraticShapeFactor4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_QuadraticShapeFactor4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_QuadraticShapeFactor5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_QuadraticShapeFactor5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">橡胶剪切弹性模量 (N/m㎡)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_ShearModulus1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_ShearModulus1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_ShearModulus2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_ShearModulus2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_ShearModulus3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_ShearModulus3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_ShearModulus4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_ShearModulus4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_ShearModulus5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_ShearModulus5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">竖向刚度 (kN/mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_VerticalStiffness1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_VerticalStiffness1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_VerticalStiffness2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_VerticalStiffness2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_VerticalStiffness3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_VerticalStiffness3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_VerticalStiffness4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_VerticalStiffness4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_VerticalStiffness5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_VerticalStiffness5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" style="width: 50px;">等效水<br />
                                平刚度<br />
                                (kN/mm)
                            </td>
                            <td style="width: 100px;">100%水平性能
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_HorizontalStiffness1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_HorizontalStiffness1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_HorizontalStiffness2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_HorizontalStiffness2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_HorizontalStiffness3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_HorizontalStiffness3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_HorizontalStiffness4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_HorizontalStiffness4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_HorizontalStiffness5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_HorizontalStiffness5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>280%水平性能
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_HorizontalStiffness_Times1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_HorizontalStiffness_Times1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_HorizontalStiffness_Times2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_HorizontalStiffness_Times2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_HorizontalStiffness_Times3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_HorizontalStiffness_Times3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_HorizontalStiffness_Times4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_HorizontalStiffness_Times4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_HorizontalStiffness_Times5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_HorizontalStiffness_Times5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">等效阻尼比<br />
                                (%)
                            </td>
                            <td>100%水平性能
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_DampingRatio1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_DampingRatio1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_DampingRatio2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_DampingRatio2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_DampingRatio3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_DampingRatio3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_DampingRatio4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_DampingRatio4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_DampingRatio5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_DampingRatio5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>280%水平性能
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_DampingRatio_Times1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_DampingRatio_Times1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_DampingRatio_Times2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_DampingRatio_Times2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_DampingRatio_Times3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_DampingRatio_Times3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_DampingRatio_Times4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_DampingRatio_Times4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_DampingRatio_Times5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_DampingRatio_Times5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">屈服后刚度Kd(kN/m)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_YieldStiffness1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_YieldStiffness1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_YieldStiffness2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_YieldStiffness2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_YieldStiffness3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_YieldStiffness3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_YieldStiffness4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_YieldStiffness4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_YieldStiffness5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_YieldStiffness5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">屈服力Qd(kN)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_YieldStress1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_YieldStress1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_YieldStress2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_YieldStress2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_YieldStress3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_YieldStress3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_YieldStress4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_YieldStress4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Bearing_YieldStress5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBearing_YieldStress5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">阻<br />
                                尼<br />
                                器
                            </td>
                            <td colspan="2">型号
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Model1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Model1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Model2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Model2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Model3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Model3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Model4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Model4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Model5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Model5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">个数
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Number1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Number1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Number2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Number2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Number3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Number3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Number4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Number4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Number5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Number5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">最大阻尼出力 (t)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_MaxCapacity1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_MaxCapacity1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_MaxCapacity2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_MaxCapacity2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_MaxCapacity3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_MaxCapacity3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_MaxCapacity4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_MaxCapacity4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_MaxCapacity5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_MaxCapacity5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">阻尼系数C
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Coefficient1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Coefficient1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Coefficient2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Coefficient2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Coefficient3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Coefficient3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Coefficient4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Coefficient4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_Coefficient5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_Coefficient5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">速度指数α
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_VelocityIndex1"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_VelocityIndex1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_VelocityIndex2"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_VelocityIndex2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_VelocityIndex3"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_VelocityIndex3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_VelocityIndex4"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_VelocityIndex4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Damper_VelocityIndex5"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDamper_VelocityIndex5"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                    <a onclick="javascript:onPrev('03')"  class="btnt up" style="margin-left: 20px;">上 一 步</a>
                    <a onclick="javascript:onNext('03')"  class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab4">
                <asp:Panel ID="panelPart_1103"   GroupingText="抗震—技术申报内容—消能减震">
                    <table>
                        <tr>
                            <td style="border: 0;" colspan="8">
                                <h3>Ⅱ——消能减震工程项目情况表</h3>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 0; text-align: left;" colspan="8">
                                <p>1、总体信息编号：</p>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">项目名称
                            </td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ProjectName"   Width="95.8%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicProjectName"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>用途
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Purpose"   Width="82%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicPurpose"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionSite"   Width="95%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicConstructionSit"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>建设时间
                            </td>
                            <td colspan="2">
                                <div >
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionTime"></asp:Label>
                                    <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicConstructionTime"  Checked="true"  ToolTip="公开" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>总高度<br />
                                (m)
                            </td>
                            <td style="width:10%;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TotalHeight"   Width="75%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTotalHeight"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">占地面积<br />
                                (㎡)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="CoveredArea"   Width="83.2%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoveredArea"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">建筑面积<br />
                                (㎡)
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionArea"   Width="93%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicConstructionArea"  Checked="true"  ToolTip="公开" />
                            </td>

                        </tr>
                        <tr>
                            <td>高宽比
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HighAspectRatio"   Width="75%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicHighAspectRatio"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>层数
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 53px;">地上：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Layer_Ground"   Width="70%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicLayer_Ground"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>地下：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Layer_Underground"   Width="70%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicLayer_Underground"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>首层层高<br />
                                (m)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FirstStoreyHeight"   Width="79%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicFirstStoreyHeight"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">标准层高<br />
                                (m)
                            </td>
                            <td style="width:10%;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="StandardHeight"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicStandardHeight"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设单位
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DampingDevelopmentOrganization"   Width="93.2%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingDevelopmentOrganization"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>施工单位
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DampingConstructionOrganization"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingConstructionOrganization"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计单位
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DampingDesignOrganization"   Width="93.2%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingDesignOrganization"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>施工图审查<br />
                                机构
                            </td>
                            <td  colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DampingConstructionPlansCensorship"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingConstructionPlansCensorship"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>混凝土总用<br />
                                量(m3)
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DampingConcreteAmount"   Width="93.2%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingConcreteAmount"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>每平方米混<br />
                                凝土折算厚<br />
                                度(cm/㎡)
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DampingPerSqM_ConcreteReducedThickness"   Width="83%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingPerSqM_ConcreteReducedThickness"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>钢材总用量<br />
                                (t)
                            </td>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width:30%;">钢筋：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="DampingSteelAmount_rebar"   Width="91%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingSteelAmount_rebar"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width:30%;">型钢：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="DampingSteelAmount_SectionSteel"   Width="91%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingSteelAmount_SectionSteel"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>每平方米钢<br />
                                材用量(kg)
                            </td>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 90px;">钢筋：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="DampingPerSqM_SteelAmount_Rebar"   Width="75%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingPerSqM_SteelAmount_Rebar"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>型钢：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="DampingPerSqM_SteelAmount_SectionSteel"   Width="75%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicDampingPerSqM_SteelAmount_SectionSteel"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <table>
                        <tr>
                            <td style="border: 0; text-align: left; margin-top:10px;" colspan="8">
                                <p>2、消能减震设计概要</p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="width: 200px;">所在地区设防地震加速度参<br />
                                数(g)
                            </td>
                            <td colspan="7">
                                <div class="DeclarationList">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SeismicAccelerationParameter"   Width="97%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="txtSeismicAccelerationParameter"   Style="width: 88%;"></asp:Label>
                                </div>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicSeismicAccelerationParameter"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">设计基本地震动加速度(g)
                            </td>
                            <td style="width:15%;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="BasicSeismicAcceleration"   Width="84%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicSeismicBasicSeismicAcceleration"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>场地类别
                            </td>
                            <td style="width:15%;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SiteType"   Width="84%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicSiteType"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>特征周期(s)
                            </td>
                            <td style="width:15%;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Eigenperiod"   Width="84%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicEigenperiod"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>抗震设防类别
                            </td>
                            <td style="width:15%;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="FortificationCategory"   Width="84%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicFortificationCategory"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">时程分析用地震波（名称/调幅值(gal)/特征周期（s））
                            </td>
                            <td colspan="7">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysis"   Width="97%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistoryAnalysis"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">液化、震陷、断裂等不利场地因素措施
                            </td>
                            <td colspan="7">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AdverseFactorsMmeasures"   Width="97%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicAdverseFactorsMmeasures"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 100px;">基础形式
                            </td>
                            <td style="width: 100px;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseType"   Width="75%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBaseType"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">上部结构形式
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UpperStructureForm"   Width="88%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicUpperStructureForm"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">地下室结构形式
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BasementStructuralForm"   Width="84%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBasementStructuralForm"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">隔震层位置（标高和层）
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="IsolationLayerLocation"   Width="88%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBasementIsolationLayerLocation"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">水平向减震系数
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="HorizontalDampingCoefficient"   Width="94%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicHorizontalDampingCoefficient"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">主体结构阻尼比
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MainBodyDampingRatio"   Width="88%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMainBodyDampingRatio"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">结构附加有效阻尼比
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AdditionalEffectiveDampingRatio"   Width="94%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicAdditionalEffectiveDampingRatio"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">结构前6阶周期 (s)
                            </td>
                            <td colspan="7">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Cyc"   Width="97%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCyc"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                    </table>
                    <table>
                        <tr>
                            <td style="border: 0; text-align: left; margin-top:10px;" colspan="8">
                                <p>3、抗震分析概要</p>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="13" style="width: 30px;">抗<br />
                                震<br />
                                分<br />
                                析
                            </td>
                            <td colspan="10" style="padding: 0;">
                                <table>
                                    <tr>
                                        <td>程序名称：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="SeismicAnalysisProgramName"   Width="96%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicSeismicAnalysisProgramName"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="3" style="width: 50px;">不考虑耦扭联转
                            </td>
                            <td style="width: 50px;">方向
                            </td>
                            <td colspan="2">T<sub>1</sub> (s)
                            </td>
                            <td colspan="2">F<sub>EK</sub> (kN)
                            </td>
                            <td colspan="2">F<sub>EK</sub> /G<sub>eq</sub>
                            </td>
                            <td>△Uu(mm)
                            </td>
                            <td>△Uu/h
                            </td>
                        </tr>
                        <tr>
                            <td>横向
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="NoCoupling_H_T1"   Width="88%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicNoCoupling_H_T1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="NoCoupling_H_Fek_kN"   Width="73%"></asp:Label> %
                       <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicNoCoupling_H_Fek_kN"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="NoCoupling_H_Fek_Geq"   Width="88%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicNoCoupling_H_Fek_Geq"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="NoCoupling_H_Uu_mm"   Width="73%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicNoCoupling_H_Uu_mm"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="NoCoupling_H_Uu_h"   Width="73%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicNoCoupling_H_Uu_h"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>纵向
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="NoCoupling_V_T1"   Width="88%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicNoCoupling_V_T1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="NoCoupling_V_Fek_kN"   Width="73%"></asp:Label> %
                       <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicNoCoupling_V_Fek_kN"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="NoCoupling_V_Fek_Geq"   Width="88%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicNoCoupling_V_Fek_Geq"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="NoCoupling_V_Uu_mm"   Width="73%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicNoCoupling_V_Uu_mm"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="NoCoupling_V_Uu_h"   Width="73%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicNoCoupling_V_Uu_h"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="4">考虑耦扭联转
                            </td>
                            <td>振型号
                            </td>
                            <td>T(s)
                            </td>
                            <td>转角
                            </td>
                            <td>扭转系数
                            </td>
                            <td style="width: 50px;">方向
                            </td>
                            <td>F<sub>EK</sub> (kN)
                            </td>
                            <td>F<sub>EK</sub> /G<sub>eq</sub>
                            </td>
                            <td>△Ue(mm)
                            </td>
                            <td>△Ue/h
                            </td>
                        </tr>
                        <tr>
                            <td>1
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_T1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_T1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_Corner1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_Corner1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_TorsionCoefficient1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_TorsionCoefficient1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>横向
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_H_Fek_kN"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_H_Fek_kN"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_H_Fek_Geq"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_H_Fek_Geq"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_H_Ue_mm"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_H_Ue_mm"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_H_Ue_h"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_H_Ue_h"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>2
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_T2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_T2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_Corner2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_Corner2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_TorsionCoefficient2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_TorsionCoefficient2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>纵向
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_V_Fek_kN"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_V_Fek_kN"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_V_Fek_Geq"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_V_Fek_Geq"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_V_Ue_mm"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_V_Ue_mm"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_V_Ue_h"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_V_Ue_h"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>3
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_T3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_T3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_Corner3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_Corner3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Coupling_TorsionCoefficient3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicCoupling_TorsionCoefficient3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">地震作用最大方向：
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxActionDirection"   Width="93.5%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMaxActionDirection"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">时程分析程序名称：
                            </td>
                            <td colspan="7">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisProgramName"   Width="96.9%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistoryAnalysisProgramName"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">波名
                            </td>
                            <td colspan="2">F<sub>EK</sub> (kN)
                            </td>
                            <td colspan="2">F<sub>EK</sub> /G<sub>eq</sub>
                            </td>
                            <td colspan="2">△U/h
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_WaveName1"   Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_WaveName1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_Fek_kN1"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_Fek_kN1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_Fek_Geq1"   Width="80%"></asp:Label> %
                       <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_Fek_Geq1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_U_h1"   Width="91%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_U_h1"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_WaveName2"   Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_WaveName2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_Fek_kN2"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_Fek_kN2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_Fek_Geq2"   Width="80%"></asp:Label> %
                       <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_Fek_Geq2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_U_h2"   Width="91%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_U_h2"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_WaveName3"   Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_WaveName3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_Fek_kN3"   Width="85%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_Fek_kN3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_Fek_Geq3"   Width="80%"></asp:Label> %
                       <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_Fek_Geq3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistory_U_h3"   Width="91%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicTimeHistory_U_h3"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                    </table>
                    <table>
                        <tr>
                            <td style="border: 0; text-align: left; margin-top:10px;" colspan="8">
                                <p>4、消能减震装置概要</p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">生产企业
                            </td>
                            <td colspan="7" style="padding: 0;">
                                <table>
                                    <tr>
                                        <td style="width: 150px;">黏滞阻尼器：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Manufacturer_ViscousDamper"   Width="103.5%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicManufacturer_ViscousDamper"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>金属阻尼器：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Manufacturer_MetallicDamper"   Width="103.5%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicManufacturer_MetallicDamper"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>屈曲约束支撑：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Manufacturer_BrB"   Width="103.5%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicManufacturer_BrB"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>其他：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Manufacturer_Other"   Width="103.5%"></asp:Label>
                                            <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicManufacturer_Other"  Checked="true"  ToolTip="公开" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="6" style="width: 50px;">黏滞阻尼器
                            </td>
                            <td>型号
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Model1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Model1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Model2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Model2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Model3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Model3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Model4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Model4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Model5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Model5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Model6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Model6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Model7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Model7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>个数
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Number1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Number1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Number2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Number2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Number3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Number3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Number4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Number4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Number5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Number5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Number6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Number6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Number7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Number7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>极限位移(mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_LimitDrift1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_LimitDrift1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_LimitDrift2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_LimitDrift2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_LimitDrift3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_LimitDrift3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_LimitDrift4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_LimitDrift4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_LimitDrift5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_LimitDrift5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_LimitDrift6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_LimitDrift6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_LimitDrift7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_LimitDrift7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>最大阻尼出力 (t)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_MaxCapacity1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_MaxCapacity1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_MaxCapacity2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_MaxCapacity2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_MaxCapacity3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_MaxCapacity3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_MaxCapacity4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_MaxCapacity4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_MaxCapacity5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_MaxCapacity5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_MaxCapacity6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_MaxCapacity6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_MaxCapacity7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_MaxCapacity7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>阻尼系数C
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Coefficient1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Coefficient1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Coefficient2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Coefficient2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Coefficient3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Coefficient3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Coefficient4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Coefficient4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Coefficient5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Coefficient5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Coefficient6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Coefficient6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_Coefficient7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_Coefficient7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>速度指数α
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_VelocityIndex1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_VelocityIndex1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_VelocityIndex2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_VelocityIndex2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_VelocityIndex3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_VelocityIndex3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_VelocityIndex4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_VelocityIndex4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_VelocityIndex5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_VelocityIndex5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_VelocityIndex6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_VelocityIndex6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ViscousDamper_VelocityIndex7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicViscousDamper_VelocityIndex7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="7">金属型阻尼器
                            </td>
                            <td>型号
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Model1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Model1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Model2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Model2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Model3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Model3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Model4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Model4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Model5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Model5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Model6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Model6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Model7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Model7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>个数
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Number1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Number1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Number2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Number2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Number3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Number3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Number4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Number4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Number5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Number5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Number6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Number6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_Number7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_Number7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服位移(mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldDrift1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldDrift1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldDrift2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldDrift2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldDrift3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldDrift3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldDrift4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldDrift4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldDrift5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldDrift5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldDrift6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldDrift6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldDrift7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldDrift7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服荷载 (t)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldLoad1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldLoad1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldLoad2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldLoad2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldLoad3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldLoad3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldLoad4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldLoad4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldLoad5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldLoad5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldLoad6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldLoad6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldLoad7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldLoad7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服后刚度 (t/cm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldStiffness1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldStiffness1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldStiffness2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldStiffness2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldStiffness3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldStiffness3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldStiffness4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldStiffness4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldStiffness5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldStiffness5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldStiffness6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldStiffness6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_YieldStiffness7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_YieldStiffness7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>极限荷载 (t)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitLoad1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitLoad1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitLoad2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitLoad2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitLoad3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitLoad3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitLoad4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitLoad4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitLoad5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitLoad5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitLoad6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitLoad6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitLoad7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitLoad7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>极限位移(mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitStiffness1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitStiffness1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitStiffness2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitStiffness2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitStiffness3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitStiffness3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitStiffness4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitStiffness4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitStiffness5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitStiffness5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitStiffness6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitStiffness6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MetallicDamper_LimitStiffness7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicMetallicDamper_LimitStiffness7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="7">屈曲约束支撑
                            </td>
                            <td>型号
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Model1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Model1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Model2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Model2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Model3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Model3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Model4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Model4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Model5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Model5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Model6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Model6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Model7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Model7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>个数
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Number1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Number1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Number2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Number2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Number3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Number3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Number4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Number4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Number5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Number5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Number6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Number6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_Number7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_Number7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服位移(mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldDrift1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldDrift1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldDrift2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldDrift2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldDrift3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldDrift3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldDrift4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldDrift4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldDrift5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldDrift5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldDrift6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldDrift6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldDrift7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldDrift7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服荷载 (t)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldLoad1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldLoad1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldLoad2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldLoad2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldLoad3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldLoad3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldLoad4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldLoad4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldLoad5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldLoad5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldLoad6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldLoad6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldLoad7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldLoad7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服后刚度 (t/cm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldStiffness1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldStiffness1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldStiffness2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldStiffness2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldStiffness3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldStiffness3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldStiffness4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldStiffness4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldStiffness5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldStiffness5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldStiffness6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldStiffness6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_YieldStiffness7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_YieldStiffness7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>极限荷载 (t)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitLoad1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitLoad1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitLoad2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitLoad2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitLoad3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitLoad3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitLoad4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitLoad4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitLoad5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitLoad5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitLoad6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitLoad6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitLoad7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitLoad7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>极限位移(mm)
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitStiffness1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitStiffness1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitStiffness2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitStiffness2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitStiffness3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitStiffness3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitStiffness4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitStiffness4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitStiffness5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitStiffness5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitStiffness6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitStiffness6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BrB_LimitStiffness7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicBrB_LimitStiffness7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="4">其它类型阻尼器
                            </td>
                            <td>型号
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Model1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicOther_Model1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Model2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicOther_Model2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Model3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicOther_Model3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Model4"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicOther_Model4"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Model5"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicOther_Model5"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Model6"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicOther_Model6"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Model7"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicOther_Model7"  Checked="true"  ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>个数
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Number1"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicOther_Number1"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Number2"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicOther_Number2"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Number3"   Width="80%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static"  style="display:none" ID="IsAntiSeismicOther_Number3"  Checked="true"  ToolTip="公开" />
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Number4"   Width="80%"></asp:Label>
                                
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Number5"   Width="80%"></asp:Label>
                                
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Number6"   Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Other_Number7"   Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>……</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                    <a onclick="javascript:onPrev('04')"  class="btnt up" style="margin-left:20px;">上 一 步</a>
                    <a onclick="javascript:onNext('04')"  class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab5">
                <asp:Panel ID="panelPart_1104" runat="server" ClientIDMode="Static"  GroupingText="工程概况、说明设计特点、技术经济指标">
                    <table>
                        <tr>
                            <td style="text-align:center;padding-left:10px;">工程概况、说明设计特点、技术经济指标：(限800字内)</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox runat="server" ClientIDMode="Static" ID="TechnologyFeature"   TextMode="MultiLine" style="width:97%;min-height:300px;display:block"></asp:TextBox>
                                <script id="TechnologyFeatureTextBox" class="review" type="text/plain" style="height: 300px;"></script>                                
                            </td>
                        </tr>
                    </table>
                    <table>
                          <tr>
                          <td  colspan="11" style="border:none;">
                              <h3>审核意见</h3>
                          </td>
                       </tr>
                        <tr>
                            <td>
                                曾获奖项（省、自治区、直辖市和各部门勘察设计同业协会评选的二等奖以上）
                            </td>
                            <td>
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="AwardsTextBox" class="review Award" type="text/plain" style="height: 300px;"></script>
                            </td> 
                        </tr>
                       <%-- <tr>
                            <td>
                                申报单位<br />意   见
                            </td>
                            <td>
                                <asp:TextBox ID="UnitOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="UnitOpinionTextBox" type="text/plain" style="height: 300px;"></script>
                            </td> 
                        </tr>--%>
                        <tr>
                            <td>
                                申报单位或省市同业协会抗震防灾分会/专业委员会推荐意见
                            </td>
                            <td>
                                <asp:TextBox ID="RecommendOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="RecommendOpinionTextBox"class="review Award" type="text/plain" style="height: 300px;"></script>
                            </td> 
                        </tr>  
                    </table> 
                    <div style="text-align: center; margin-top: 40px;">
                    <a onclick="javascript:onPrev('05')"  class="btnt up" style="margin-left:20px;">上 一 步</a>
                    <a onclick="javascript:onNext('05')"  class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab6">
                <uc:Appendix runat="server" id="AppendixReview"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab7">
                <uc:LegalStates runat="server" ID="LegalStatesReview"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab8">
                <uc:Certificate runat="server" ID="CertificateReview"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab9">
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
              onPrev("06");
          });
          $("#AppendixNext").click(function () {
              onNext("06");
          });
          $("#LegalStatesPrev").click(function () {
              onPrev("07");
          });
          $("#LegalStatesNext").click(function () {
              onNext("07");
          });
          $("#CertificatePrev").click(function () {
              onPrev("08");
          });
          $("#CertificateNext").click(function () {
              onNext("08");
          });
          $("#CommentsPrev").click(function () {
              onPrev("09");
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
          InitUEditor('TechnologyFeatureTextBox', 1000);                               // 工程概况、说明设计特点、技术经济指标
          InitUEditor('AwardsTextBox', 1000);
          //InitUEditor('UnitOpinionTextBox', 2000);
          InitUEditor('RecommendOpinionTextBox', 1000);
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
