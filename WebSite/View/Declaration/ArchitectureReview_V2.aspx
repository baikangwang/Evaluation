<%@ Page Title="项目管理" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="ArchitectureReview_V2.aspx.cs" Inherits="Evaluation.View.Declaration.ArchitectureReview_V2" validateRequest="false"%>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/ParticipantReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/AppendixReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStatesReview_V2.ascx" %>
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
        /*#StructuralFeaturesTextBox{
            text-align:left;width:99%;
        }*/

        .review {
            text-align:left;width:99%;
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
             width:79%;  text-align:left;margin-left:10px;
         }*/

            .review .Awards {
             width:79%;  text-align:left;margin-left:10px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a><a href="../Declaration/Declare.aspx?SepcCode=060000" id="nav02" runat="server" clientidmode="Static"></a><a href="#" id="nav03"></a>
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

        <div class="tab-content active" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0601" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 130px;">项目名称
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationName" Width="97%"></asp:Label>
                            </td>
                        </tr>
                         <tr>
                            <td>建筑结构设计项目名称
                            </td>
                            <td colspan="4">
                                <asp:Label ID="ApprovalName" runat="server" ClientIDMode="Static" Width="97%"></asp:Label>                             
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 120px;">主要设计单位
                            </td>
                            <td colspan="3">
                                <asp:Label ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="96.5%"></asp:Label>                              
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
                        <%--<tr>
                            <td>建设单位
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DevelopmentOrganization" Width="95.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>施工单位
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionOrganization" Width="95.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>使用单位
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UseUnit" Width="95.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点
                            </td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionLocation" Width="95.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">建筑功能<br />
                                （使用性质）
                            </td>
                            <td>地上
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="UseProperty_Overground" Width="92%"></asp:Label>
                            </td>
                            <td style="width: 120px;">用地性质
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="LandNature" Width="88%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>地下
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="UseProperty_Underground" Width="92%"></asp:Label>
                            </td>
                            <td>设计使用年限
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="DesignServiceLife" Width="88%"></asp:Label>
                                年
                            </td>
                        </tr>
                        <tr>
                            <td>总建筑面积
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="OverallFloorage" Width="90%"></asp:Label>
                                m<sup>2</sup>

                            </td>
                            <td>用地面积
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TotalLandArea" Width="88%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>建筑高度
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="BuildingHeight" Width="90%"></asp:Label>
                                m

                            </td>
                            <td>建筑层数
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="LayerCount" Width="88%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>设计类别
                            </td>
                            <td colspan="2">
                                <div class="DeclarationList">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DesignCategory"></asp:Label>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="txtDesignCategory" Width="90%"></asp:Label>
                                </div>
                            </td>
                            <td>设计起止时间
                            </td>
                            <td style="margin-left: 2.5%;">
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DesignStartDate"></asp:Label><span style="padding: 0 0.5em">至</span>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DesignEndDate"></asp:Label>

                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>开工时间
                            </td>
                            <td colspan="2">
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionStartDate"></asp:Label>
                                </div>
                            </td>
                            <td>竣工时间
                            </td>
                            <td>
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionEndDate"></asp:Label>
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
                                <asp:Label runat="server" ClientIDMode="Static" ID="AcceptanceDepartment" Width="68%"></asp:Label>
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
                            <td>专业类别</td>
                            <td colspan="4">
                                <div class="DeclarationList">
                                    <asp:Label runat="server" ID="ProfessionalCategories" ClientIDMode="Static"></asp:Label>
                                </div>
                                
                            </td>
                        </tr>--%>
                         <tr>
                            <td>建筑结构设计起止时间
                            </td>
                            <td style="margin-left:2.5%;">
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DesignStartDate"></asp:Label><span style="padding: 0 0.5em">至</span>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DesignEndDate"></asp:Label>
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
                            <td>验收部门
                            </td>
                            <td colspan="4">
                                <asp:Label ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="65%"></asp:Label>                              
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />通讯地址
                            </td>
                            <td colspan="3">
                                <asp:Label ID="PostalAddress" runat="server" ClientIDMode="Static" Width="96.5%"></asp:Label>                               
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
                            <td>联 系 人
                            </td>
                            <td style="width: 30%">
                                <asp:Label ID="Linkman" runat="server" ClientIDMode="Static" Width="90%"></asp:Label>                               
                            </td>
                            <td>手    机
                            </td>
                            <td>
                                <asp:Label ID="MobileNumber" runat="server" ClientIDMode="Static" Width="90%"></asp:Label>                            
                            </td>
                        </tr>
                        <tr>
                            <td>电    话
                            </td>
                            <td>
                                <asp:Label ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="90%"></asp:Label>                             
                            </td>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:Label ID="Postcode" runat="server" ClientIDMode="Static" Width="90%"></asp:Label>                              
                            </td>
                        </tr>
                        <tr>
                            <td>传    真
                            </td>
                            <td>
                                <asp:Label ID="FaxNumber" runat="server" ClientIDMode="Static" Width="90%"></asp:Label>                               
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:Label ID="EmailAddress" runat="server" ClientIDMode="Static" Width="90%"></asp:Label>                                
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
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant ID="ucParticipant" runat="server"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0602" GroupingText="技术申报内容">
                    <table>
                        <tr>
                            <td colspan="3">结构体系</td>
                            <td colspan="3" style="width:35%;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="StructuralSystem"></asp:Label>
                            </td>
                            <td>抗震设防烈度</td>
                            <td style="width:35%;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SeismicFortificationIntensity" Width="61%"></asp:Label>
                                度
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">抗震设防类别</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SeismicFortificationCategory" Width="90%"></asp:Label>
                            </td>
                            <td>设计基本地震加速度值</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BasicSeismicAcceleration" Width="61%"></asp:Label>
                                &nbsp;g
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">设计地震分组</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="EarthquakeGrouping" Width="90%"></asp:Label>
                            </td>
                            <td>场地类别</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionSiteSoilType" Width="61%"></asp:Label>
                                类
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">基础类型</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseType" Width="90%"></asp:Label>
                            </td>
                            <td>结构安全等级</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="StructuralSafetyLevel" Width="61%"></asp:Label>
                                级
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">混凝土总用量（砖混结构可不填写此栏及后三栏）</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConcreteAmount" Width="90%"></asp:Label>
                                m³
                            </td>
                            <td>每平方米混凝土折算厚度</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="PerSqM_ConcreteReducedThickness" Width="61%"></asp:Label>
                                cm/㎡
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" colspan="3">钢材总用量</td>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">钢筋
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="SteelAmount_rebar" Style="width: 86%"></asp:Label>
                                            t
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">每平方米<br />
                                钢材用量</td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">钢筋
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="PerSqM_SteelAmount_rebar" Width="49%"></asp:Label>
                                            kg/㎡
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">型钢
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="SteelAmount_SectionSteel" Style="width: 86%"></asp:Label>
                                            t
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">型钢
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="PerSqM_SteelAmount_SectionSteel" Width="49%"></asp:Label>
                                            kg/㎡
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                            </table>
                        <br /><br />
                        <table>
                        <tr>
                            <td rowspan="13" style="width: 30px;">抗<br />
                                震<br />
                                分<br />
                                析
                            </td>
                            <td colspan="3">程序名称
                            </td>
                            <td style="border-right: none;" colspan="8">
                                <asp:Label ID="SeismicAnalysisProgramName" runat="server" ClientIDMode="Static" Width="96%"></asp:Label>
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
                                <asp:Label ID="NoCoupling_H_T1" runat="server" ClientIDMode="Static" Width="88%"></asp:Label>                              
                            </td>
                            <td colspan="2">
                                <asp:Label ID="NoCoupling_H_Fek_kN" runat="server" ClientIDMode="Static" Width="73%"></asp:Label> %                     
                            </td>
                            <td colspan="2">
                                <asp:Label ID="NoCoupling_H_Fek_Geq" runat="server" ClientIDMode="Static" Width="88%"></asp:Label>                              
                            </td>
                            <td>
                                <asp:Label ID="NoCoupling_H_Uu_mm" runat="server" ClientIDMode="Static" Width="73%"></asp:Label>                             
                            </td>
                            <td>
                                <asp:Label ID="NoCoupling_H_Uu_h" runat="server" ClientIDMode="Static" Width="73%"></asp:Label>
                              
                            </td>
                        </tr>
                        <tr>
                            <td>纵向
                            </td>
                            <td colspan="2">
                                <asp:Label ID="NoCoupling_V_T1" runat="server" ClientIDMode="Static" Width="88%"></asp:Label>                               
                            </td>
                            <td colspan="2">
                                <asp:Label ID="NoCoupling_V_Fek_kN" runat="server" ClientIDMode="Static" Width="73%"></asp:Label>                       
                            </td>
                            <td colspan="2">
                                <asp:Label ID="NoCoupling_V_Fek_Geq" runat="server" ClientIDMode="Static" Width="88%"></asp:Label>                              
                            </td>
                            <td>
                                <asp:Label ID="NoCoupling_V_Uu_mm" runat="server" ClientIDMode="Static" Width="73%"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="NoCoupling_V_Uu_h" runat="server" ClientIDMode="Static" Width="73%"></asp:Label>                             
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
                                <asp:Label ID="Coupling_T1" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                               
                            </td>
                            <td>
                                <asp:Label ID="Coupling_Corner1" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                            
                            </td>
                            <td>
                                <asp:Label ID="Coupling_TorsionCoefficient1" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                             
                            </td>
                            <td>横向
                            </td>
                            <td>
                                <asp:Label ID="Coupling_H_Fek_kN" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                           
                            </td>
                            <td>
                                <asp:Label ID="Coupling_H_Fek_Geq" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                               
                            </td>
                            <td>
                                <asp:Label ID="Coupling_H_Ue_mm" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                              
                            </td>
                            <td>
                                <asp:Label ID="Coupling_H_Ue_h" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                              
                            </td>
                        </tr>
                        <tr>
                            <td>2
                            </td>
                            <td>
                                <asp:Label ID="Coupling_T2" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                               
                            </td>
                            <td>
                                <asp:Label ID="Coupling_Corner2" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                                
                            </td>
                            <td>
                                <asp:Label ID="Coupling_TorsionCoefficient2" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                              
                            </td>
                            <td>纵向
                            </td>
                            <td>
                                <asp:Label ID="Coupling_V_Fek_kN" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                            
                            </td>
                            <td>
                                <asp:Label ID="Coupling_V_Fek_Geq" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                          
                            </td>
                            <td>
                                <asp:Label ID="Coupling_V_Ue_mm" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                              
                            </td>
                            <td>
                                <asp:Label ID="Coupling_V_Ue_h" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td>3
                            </td>
                            <td>
                                <asp:Label ID="Coupling_T3" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                              
                            </td>
                            <td>
                                <asp:Label ID="Coupling_Corner3" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>
                             
                            </td>
                            <td>
                                <asp:Label ID="Coupling_TorsionCoefficient3" runat="server" ClientIDMode="Static" Width="80%"></asp:Label>                                
                            </td>
                            <td colspan="2">地震作用最大方向
                            </td>
                            <td colspan="3">
                                <asp:Label ID="MaxActionDirection" runat="server" ClientIDMode="Static" Width="93.5%"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">时程分析程序名称
                            </td>
                            <td colspan="7">
                                <asp:Label ID="TimeHistoryAnalysisProgramName" runat="server" ClientIDMode="Static" Width="96.9%"></asp:Label>                               
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
                                <asp:Label ID="TimeHistory_WaveName1" runat="server" ClientIDMode="Static" Width="92%"></asp:Label>                                
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_kN1" runat="server" ClientIDMode="Static" Width="85%"></asp:Label>                            
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_Geq1" runat="server" ClientIDMode="Static" Width="80%"></asp:Label> %                      
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_U_h1" runat="server" ClientIDMode="Static" Width="91%"></asp:Label>                              
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:Label ID="TimeHistory_WaveName2" runat="server" ClientIDMode="Static" Width="92%"></asp:Label>                               
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_kN2" runat="server" ClientIDMode="Static" Width="85%"></asp:Label>                              
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_Geq2" runat="server" ClientIDMode="Static" Width="80%"></asp:Label> %                      
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_U_h2" runat="server" ClientIDMode="Static" Width="91%"></asp:Label>                       
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:Label ID="TimeHistory_WaveName3" runat="server" ClientIDMode="Static" Width="92%"></asp:Label>                        
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_kN3" runat="server" ClientIDMode="Static" Width="85%"></asp:Label>                             
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_Fek_Geq3" runat="server" ClientIDMode="Static" Width="80%"></asp:Label> %                      
                            </td>
                            <td colspan="2">
                                <asp:Label ID="TimeHistory_U_h3" runat="server" ClientIDMode="Static" Width="91%"></asp:Label>                              
                            </td>
                        </tr>
                             <tr>
                            <td colspan="11" style="text-align:center;padding-left:10px;">
                                工程设计项目特点
                            </td>
                        </tr>
                        <tr>
                            <td colspan="11">
                                <p>（600～1000字，提供必要的图纸和计算分析）</p> 
                                <asp:TextBox ID="StructuralFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="StructuralFeaturesTextBox" class="review" type="text/plain" style="height: 300px;"></script>                               
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
                                曾获奖项
                            </td>
                            <td>
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="AwardsTextBox" class="review Awards" type="text/plain" style="height: 300px;"></script>
                            </td> 
                        </tr>
                        <tr>
                            <td>
                                申报单位<br />意   见
                            </td>
                            <td>
                                <asp:TextBox ID="UnitOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="UnitOpinionTextBox" class="review Awards" type="text/plain" style="height: 300px;"></script>
                            </td> 
                        </tr>
                        <tr>
                            <td>
                                地方、部门勘察设计同业协会推荐意见
                            </td>
                            <td>
                                <asp:TextBox ID="RecommendOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="RecommendOpinionTextBox" class="review Awards" type="text/plain" style="height: 300px;"></script>
                            </td> 
                        </tr>  
                    </table> 
                 <%--       <tr>
                            <td rowspan="21" style="width: 100px;">抗震分析</td>
                            <td colspan="5" style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="border-right: none;">程序名称：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="ModeProgramName" Width="90.5%"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>是否考虑扭转耦联</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="IsConsiderCoupling" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 50px;">振型号</td>
                            <td style="width: 100px;">周期</td>
                            <td style="width: 100px;">转角</td>
                            <td style="width: 100px;">平动系数(x+y)</td>
                            <td style="width: 100px;">扭转系数</td>
                            <td>X向基底剪力(kN)</td>
                            <td>Y向基底剪力(kN)</td>
                        </tr>
                        <tr>
                            <td>1</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle1" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle1" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient1" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient1" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle2" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle2" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient2" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient2" Width="80%"></asp:Label>
                            </td>
                            <td>X向基底剪重比</td>
                            <td>Y向基底剪重比</td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle3" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle3" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient3" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient3" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BasalShearRatio_X" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BasalShearRatio_Y" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle4" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle4" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient4" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient4" Width="80%"></asp:Label>
                            </td>
                            <td>X向最小剪重比（层号）</td>
                            <td>Y向最小剪重比（层号）</td>
                        </tr>
                        <tr>
                            <td>5</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle5" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle5" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient5" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient5" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MinShearWeightRatio_X" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MinShearWeightRatio_Y" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>6</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle6" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle6" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient6" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient6" Width="80%"></asp:Label>
                            </td>
                            <td>X向最大层间位移角</td>
                            <td>Y向最大层间位移角</td>
                        </tr>
                        <tr>
                            <td>7</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle7" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle7" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient7" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient7" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>8</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle8" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle8" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient8" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient8" Width="80%"></asp:Label>
                            </td>
                            <td>X向最大位移比（层号）</td>
                            <td>Y向最大位移比（层号）</td>
                        </tr>
                        <tr>
                            <td>9</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle9" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle9" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient9" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient9" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxDisplacementRatio_X" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxDisplacementRatio_Y" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7">注：单塔可仅填前三个振型 </td>
                        </tr>
                        <tr>
                            <td colspan="3">时程分析波名</td>
                            <td>X向基底剪力(kN)</td>
                            <td class="auto-style1">X向最大层间位移角</td>
                            <td>Y向基底剪力(kN)</td>
                            <td>Y向最大层间位移角</td>
                        </tr>
                        <tr>
                            <td colspan="1">1</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName1" Width="90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X1" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X1" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y1" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y1" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">2</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName2" Width="90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X2" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X2" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y2" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y2" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">3</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName3" Width="90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X3" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X3" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y3" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y3" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">4</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName4" Width="90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X4" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X4" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y4" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y4" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">5</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName5" Width="90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X5" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X5" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y5" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y5" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">6</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName6" Width="90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X6" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X6" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y6" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y6" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">7</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName7" Width="90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X7" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X7" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y7" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y7" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">各波平均值(当选3条波时为包络值)</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X_Avg" Width="80%"></asp:Label>
                            </td>
                            <td class="auto-style1">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X_Avg" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y_Avg" Width="80%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y_Avg" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8" style="text-align: center; padding-left: 10px;">结构专业设计主要特点：（限400～600字）（重点介绍技术的难点、创新点及先进性。）
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8">
                                <asp:TextBox runat="server" ClientIDMode="Static" ID="StructuralFeatures"  TextMode="MultiLine" Style="width: 97%; height: 300px; display: block"></asp:TextBox>
                                <script id="StructuralFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>--%>
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
           console.log("LegalPeopleName==" + LegalPeopleName + "LegalPeopleNumber====" + LegalPeopleNumber);
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

           InitUEditor('StructuralFeaturesTextBox', 600);              // 建筑专业设计主要特点
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
               toolbars: [[]]
           });
           ue.ready(function () {
               //设置编辑器的内容
               ue.setContent(text.val());
           });
       }
    </script>
</asp:Content>
