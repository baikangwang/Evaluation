<%@ Page Title="绿色建筑" Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="GreenBuildingReview.aspx.cs" Inherits="Evaluation.View.Declaration.GreenBuildingReview" validateRequest="false" %>

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
     
        #AcceptanceDate{
            margin-left: 0px!important;
        }
        #ArchitectureMainFeaturesTextBox{
            text-align:left;
        }
        
        fieldset p{
           
            padding-left:10px;
        }
        #ProjectOverviewTextBox,#KeyTechnologyTextBox,#EffectTextBox,#BenefitTextBox,
        #MechanicalMainFeaturesTextBox,#StructureMainFeaturesTextBox,#ElectricalMainFeaturesTextBox,
        #EconomicsFeaturesTextBox,#AwardsTextBox,#CompanyOpinionTextBox,#AssociationOpinionTextBox{
            text-align:left;
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
            <a href="#" id="nav01"></a><a href="../Declaration/Declare.aspx?SepcCode=040000" id="nav02"  ></a><a href="#" id="nav03"></a>
        </li>       
    </ul>
     <div style="display: none">
        <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox></div>  
    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather">

        <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>        
        <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
        <li><a id="tab_03" href="#btab3" data-toggle="tab">3、项目特点</a></li>
        <li><a id="tab_04" href="#btab4" data-toggle="tab">4、建筑专业</a></li>
        <li><a id="tab_05" href="#btab5" data-toggle="tab">5、结构专业</a></li>
        <li><a id="tab_06" href="#btab6" data-toggle="tab">6、设备专业</a></li>
        <li><a id="tab_07" href="#btab7" data-toggle="tab">7、电气专业</a></li>
        <li><a id="tab_08" href="#btab8" data-toggle="tab">8、经济指标</a></li>
        <li><a id="tab_10" href="#btab10" data-toggle="tab">9、附件目录</a></li>
        <li><a id="tab_11" href="#btab11" data-toggle="tab">10、法人声明</a></li>
        <li><a id="tab_12" href="#btab12" data-toggle="tab">11、合作声明</a></li>
        <li><a id="tab_13" href="#btab13" data-toggle="tab" class="ExpertReviewList2" style="display:none;">12、评审意见</a></li>                           

        </ul>
        <div class="tab-content"  id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_0401"   GroupingText="全国优秀工程勘察设计行业奖申报表">
                    <table>
                        <tr>
                            <td style="width: 150px;">项目名称
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DeclarationName"   Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>主要设计单位
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DeclarationUnit"   Width="97%"></asp:Label>
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
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit2"   Style="width: 88%;" ></asp:Label>
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
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="CooperativeUnit3"   Style="width: 88%;"></asp:Label>
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
                                            <%--<asp:CheckBox  ID="IsResidentialCollaborativePhase3"  ToolTip="公开" Checked="true" />--%>
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
                                            <%--<asp:CheckBox  ID="IsResidentialCollaborativePhase4"  ToolTip="公开" Checked="true" />--%>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>绿建咨询单位
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="AdvisoryUnit"   Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>工程设计<br />
                                起止时间
                            </td>
                            <td style="width: 35%">
                                <div>
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="ProjectStartDate"></asp:Label>
                                    <span style="padding:0 0.5em">至</span>
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="ProjectEndDate"></asp:Label>

                                </div>
                            
                                
                            </td>
                            <td>竣工验收时间
                            </td>
                            <td>
                                <div style="margin:0px auto;">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="AcceptanceDate" ></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>验收部门
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="AcceptanceDepartment"   Width="97%"></asp:Label>
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
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Qualification"   Width="93%"></asp:Label>
                            </td>
                            <td>证书编号
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="CertificateNumber"   Width="93%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位联系人
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Linkman"   Width="93%"></asp:Label>
                            </td>
                            <td>电话
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TelephoneNumber"   Width="93%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Postcode"   Width="93%"></asp:Label>
                            </td>
                            <td>手机
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="MobileNumber"   Width="93%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="EmailAddress"   Width="93%"></asp:Label>
                            </td>
                            <td>传真
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="FaxNumber"   Width="93%"></asp:Label>
                            </td>
                        </tr>
                         <tr>
                            <td colspan="4">
                                曾获奖项
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:TextBox  runat="server"  ClientIDMode="Static" ID="Awards"   TextMode="MultiLine" Style="width: 95%; height: 200px;display:none;"></asp:TextBox>
                                <script id="AwardsTextBox" type="text/plain" style=" height: 300px;"></script>
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
                    <div style="text-align:center;margin-top:40px;">
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" id="ParticipantReview"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_0402"   GroupingText="工程勘察设计项目特点">
                    <table style="height: 500px;">
                        <tr>
                            <td>项目概况<br/>
                                （项目总体介绍、工程性质、工程投资、项目规模、解决的主要技术问题、复杂程度及影响程度等，限500字）
                            </td>
                        </tr>
                      
                        <tr>
                            <td>                           
                                <asp:TextBox  runat="server"  ClientIDMode="Static" ID="ProjectOverview"   TextMode="MultiLine" Style="width: 95%; height: 300px;display:block"></asp:TextBox>
                                <script id="ProjectOverviewTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>关键绿色策略与技术<br/>（项目主要绿色设计策略和技术措施，介绍项目的总体绿色设计目标和策略，
                                    并分别从节地与室外环境、节能与能源利用、节水与水资源利用、节材与材料资源利用、室外环境质量、运行管理等方面进行阐述，限1500字）
                            </td>
                            </tr>
                        <tr>
                            <td>                            
                                <asp:TextBox  runat="server"  ClientIDMode="Static" ID="KeyTechnology"   TextMode="MultiLine" Style="width: 95%; height: 300px;display:block"></asp:TextBox>
                                <script id="KeyTechnologyTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>技术成效与深度
                        <br />
                                （解决的关键技术难题，包括：被动式和主动式技术策略整合的成效与深度；绿色策略与技术和当地气候、社会、经济技术条件的适宜性、技术集成性和创新性；
                                    设计中建筑艺术与绿色策略与技术的有机结合等，对于有示范性的项目还包括达到示范性低碳、节能、环保指标的技术路线等，限1500字）
                            </td>
                        </tr>
                        <tr>
                            <td>                              
                                <asp:TextBox  runat="server"  ClientIDMode="Static" ID="Effect"   TextMode="MultiLine" Style="width: 95%; height: 300px;display:block"></asp:TextBox>
                                <script id="EffectTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>综合效益 <br />
                                （项目产生的经济、社会、环境效益，以及示范推广价值，限500字）
                            </td>
                            </tr>
                        <tr>
                            <td>                              
                                <asp:TextBox  runat="server"  ClientIDMode="Static"  ID="Benefit" TextMode="MultiLine" style="width: 95%; height: 300px;margin-left:20px;display:block"></asp:TextBox>
                                <script id="BenefitTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align:center;margin-top:40px;">
                        <a onclick="onPrev('03')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="onNext('03')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab4">
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_0403"   GroupingText="专业技术指标（建筑专业）"  >
                    <table>
                        <tr>
                            <td style="width: 155px">建筑用途（性质）
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UseProperty"   Width="85%"></asp:Label>
                            </td>
                            <td style="width: 155px">建筑规模
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="BuildingScale"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">总用地面积
                            </td>
                            <td rowspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TotalLandArea"   Width="85%"></asp:Label>
                            </td>
                            <td rowspan="2">其  中
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">代征地面积:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="ExpropriationArea"   Width="80%"></asp:Label> ha
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
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="ConstructionArea"   Width="80%"></asp:Label> ha
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">总建筑面积
                            </td>
                            <td rowspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="OverallFloorage"   Width="85%"></asp:Label>
                            </td>
                            <td rowspan="2">其  中
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地上            
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="OvergroundArea"   Width="80%"></asp:Label> ㎡
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地下            
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="UndergroundArea"   Width="80%"></asp:Label> ㎡
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>建筑基底面积
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="BuildingArea"   Width="85%"></asp:Label> ㎡

                            </td>
                            <td>容 积 率
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PlotRatio"   Width="86.5%"></asp:Label> %

                            </td>
                        </tr>
                        <tr>
                            <td>绿 地 面 积
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="GreenArea"   Width="85%"></asp:Label> ㎡

                            </td>
                            <td>绿 化 率
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="GreeningRate"   Width="86.5%"></asp:Label> %

                            </td>
                        </tr>
                        <tr>
                            <td>建筑高度 
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="BuildingHeight"   Width="85%"></asp:Label> m 

                            </td>
                            <td>建筑分类<br />
                                （高层建筑）
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="BuildingClassification"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">层数
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地上          
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="OvergroundLayerCount"   Width="77%"></asp:Label> 层
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">耐火等级
                            </td>
                            <td rowspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="FireResistanceRating"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地下             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="UndergroundLayerCount"   Width="77%"></asp:Label> 层
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
                                        <td style="width: 100px;">地上            
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="LayerHeight_Overground"   Width="77%"></asp:Label> m
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
                                        <td style="width: 100px;">主楼             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="ElevatorNumber_MainBuilding"   Width="80%"></asp:Label> 台
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地下             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="LayerHeight_Underground"   Width="77%"></asp:Label>
                                            m
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="padding: 0">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">裙房           
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="ElevatorNumber_PodiumBuilding"   Width="80%"></asp:Label> 台
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>住宅类型<br />
                                （居住建筑）
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="HousingType"   Width="95%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">住宅平均每套<br />
                                建筑面积<br />
                                （居住建筑）
                            </td>
                            <td rowspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitConstructionArea"   Width="83.9%"></asp:Label> ㎡/套
                            </td>
                            <td rowspan="2">总居住户数<br />
                                （居住建筑）
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TotalFamilies"   Width="86.5%"></asp:Label> 户
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TotalPerson"   Width="86.5%"></asp:Label>
                                人
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">机动车停放数量
                            </td>
                            <td rowspan="2" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 100px">总计             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="AutoParkingCount"   Width="77%"></asp:Label>
                                            辆
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>地上
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="OvergroundAutoParkingCount"   Width="86.5%"></asp:Label> 辆
                            </td>
                        </tr>
                        <tr>
                            <td>地下
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndergroundAutoParkingCount"   Width="86.5%"></asp:Label> 辆
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">自行车停放数量
                            </td>
                            <td rowspan="2" style="padding: 0">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 100px;">总计           
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="BicycleParkingCount"   Width="77%"></asp:Label> 辆
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>地上
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="OvergroundBicycleParkingCount"   Width="86.5%"></asp:Label> 辆

                            </td>
                        </tr>
                        <tr>
                            <td>地下
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndergroundBicycleParkingCount"   Width="86.5%"></asp:Label> 辆
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 154px">周围道路宽度及性质：            
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="RoadWidth"   Width="95%"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>地下建筑面积与总用地面<br />
                                积比（公共建筑）
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndergroundAreaTotalAreaRatio"   Width="85%"></asp:Label> %
                            </td>
                            <td>地下建筑面积与地上建筑<br />
                                面积比（居住建筑）
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UndergroundAreaOvergroundAreaRatio"   Width="86.5%"></asp:Label> %
                            </td>
                        </tr>
                        <tr>
                            <td>人均居住用地指标<br />
                                （居住建筑）
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="AvgPersonLandIndication"   Width="85%"></asp:Label> ㎡
                            </td>
                            <td>下凹式绿地率
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="LowerConcaveGreenSpaceRatio"   Width="86.5%"></asp:Label>
                                %
                            </td>
                        </tr>
                        <tr>
                            <td>硬质铺装地面中透水铺装<br />
                                面积比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PermeablePavementRatio"   Width="85%"></asp:Label> %
                            </td>
                            <td>屋顶绿化率
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="RoofGreeningRate"   Width="86.5%"></asp:Label> %
                            </td>
                        </tr>
                        <tr>
                            <td>外窗可开启面积比例
                            </td>
                            <td>                   
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ExternalWindowOpenableAreaRatio"   Width="85%"></asp:Label> %
                            </td>
                            <td>玻璃幕墙透明部分可开启<br />
                                面积比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TransparentPartOpenableAreaRatio"   Width="86.5%"></asp:Label>%
                            </td>
                        </tr>
                        <tr>
                            <td>围护结构热工性能比国家<br />
                                现行节能标准提高比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IncreaseRatio"   Width="85%"></asp:Label> %
                            </td>
                            <td>建筑节能率
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="EnergyEfficiency"   Width="86.5%"></asp:Label> %
                            </td>
                        </tr>
                        <tr>
                            <td>主要功能房间室内噪声级<br />
                                指标是否满足标准
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IsNoiseLevelQualified"   Width="85%"></asp:Label></div> 
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtIsNoiseLevelQualified"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                            <td>主要功能房间构造隔声性<br />
                                能要求低限标准（满足标<br />
                                准）/高要求标准
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="SoundInsulation"   Width="86.5%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtSoundInsulation"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>主要功能房间采光系数达<br />
                                标面积比例（公共建筑）
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DaylightFactor"   Width="85%"></asp:Label> %

                            </td>
                            <td>卧室、起居室的窗地面积比<br />
                                （居住建筑）                      
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="WindowToGroundAreaRatio"   Width="86.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>主要功能房间平均自然通<br />
                                风换气次数不小于2次/h<br />
                                的面积比例（公共建筑）
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NaturalVentilationAreaRatio"   Width="85%"></asp:Label> %

                            </td>
                            <td>通风开口面积占房间地板<br />
                                面积的比例（居住建筑）                      
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="VentilationOpeningAreaRatio"   Width="86.5%"></asp:Label> %
                            </td>
                        </tr>
                        <tr>
                            <td>设有可控遮阳部分占外窗<br />
                                及玻璃幕墙面积的比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ShadingAreaRatio"   Width="85%"></asp:Label> %

                            </td>
                            <td>可再利用材料和可再循环<br />
                                材料用量比例                     
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="RecycledMaterialsRatio"   Width="86.5%"></asp:Label>
                                %

                            </td>
                        </tr>
                        <tr>
                            <td>装饰性构建造价占工程总<br />
                                建安造价的比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DecorativeRatio"   Width="85%"></asp:Label>
                                %

                            </td>
                            <td>可重复使用隔断（墙）比例                    
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ReusableWallRatio"   Width="86.5%"></asp:Label> %

                            </td>
                        </tr>
                        <tr>
                            <td>工业化生产预制构件用量<br />
                                比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PrefabricatedRatio"   Width="85%"></asp:Label> %

                            </td>
                            <td>本地生产的建筑材料比例                  
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="LocallyMaterialsRatio"   Width="86.5%"></asp:Label> %

                            </td>
                        </tr>
                        <tr>
                            <td>利废建材的种类
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="WasteMaterialsKinds"   Width="85%"></asp:Label>
                            </td>
                            <td>利废建材占同类建材用量<br />
                                的比例                 
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="WasteMaterialsRatio"   Width="86.5%"></asp:Label> %

                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">土建工程与装修工程一体化设计（是/否）
                            </td>
                            <td colspan="2">
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IsIntegratedDesign"   Width="92%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtIsIntegratedDesign"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="text-align:center;padding-left:10px;">建筑专业设计主要特点：（不少于500字）</td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:TextBox  runat="server"  ClientIDMode="Static" ID="ArchitectureMainFeatures"   TextMode="MultiLine" style="width: 95%;min-height: 300px; display:block"></asp:TextBox>
                                <script id="ArchitectureMainFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align:center;margin-top:40px;">
                        <a onclick="javascript:onPrev('04')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('04')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>                
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab5">
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_0404"   GroupingText="专业技术指标（结构专业）"  >
                    <table>
                        <tr>
                            <td colspan="3">结构体系</td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="StructuralSystem"  Width="90%"></asp:Label>
                            </td>
                            <td style="width:135px;">抗震设防烈度</td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="SeismicFortificationIntensity"  Width="80%"></asp:Label> 度
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">抗震设防类别</td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="SeismicFortificationCategory"  style="width:90%;margin-left:4%;"></asp:Label> 类
                            </td>
                            <td>设计基本地震加速度值</td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="BasicSeismicAcceleration"  Width="80%"></asp:Label>  g
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">设计地震分组</td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="EarthquakeGrouping"  style="width:90%;margin-left:4%;"></asp:Label> 组
                            </td>
                            <td>场 地 类 别</td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ConstructionSiteSoilType"  Width="80%"></asp:Label> 类
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">基础类型</td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="BaseType"  Width="90%"></asp:Label>
                            </td>
                            <td>建筑形体规则性</td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="BuildingShape"  Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">混凝土总用量</td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ConcreteAmount"  style="width:90%;margin-left:5%;"></asp:Label> m³
                            </td>
                            <td>每平方米混凝土折算厚度</td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PerSqM_ConcreteReducedThickness"  Width="80%"></asp:Label> cm/㎡
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" colspan="3">钢材总用量</td>
                            <td colspan="1">钢筋           
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SteelAmount_rebar" Style="width: 86%"></asp:Label>
                                t
                            </td>
                            <td rowspan="2">每平方米<br />
                                钢材用量</td>                            
                             <td colspan="1">钢筋           
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PerSqM_SteelAmount_rebar"  Style="width: 82.5%"></asp:Label> kg/㎡
                                t
                            </td>
                        </tr>
                        <tr>                           
                            <td colspan="1">型钢           
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="SteelAmount_SectionSteel"  Style="width: 86%"></asp:Label> t                               
                            </td>                         
                            <td colspan="1">型钢           
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PerSqM_SteelAmount_SectionSteel"  Style="width: 82.5%"></asp:Label> kg/㎡
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="13">抗<br />
                                震<br />
                                分<br />
                                析
                            </td>
                            <td colspan="3">程序名称           
                            </td>
                            <td colspan="7">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SeismicAnalysisProgramName" Style="width: 97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="3">不<br />
                                考<br />
                                虑<br />
                                耦<br />
                                扭<br />
                                联<br />
                                转
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
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NoCoupling_H_T1"  Style="width: 90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NoCoupling_H_Fek_kN"  Style="width: 75%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NoCoupling_H_Fek_Geq"  Style="width: 85%"></asp:Label> %

                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NoCoupling_H_Uu_mm"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NoCoupling_H_Uu_h"  Style="width: 75%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">纵向
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NoCoupling_V_T1"  Style="width: 90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NoCoupling_V_Fek_kN"  Style="width: 75%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NoCoupling_V_Fek_Geq"  Style="width: 85%"></asp:Label> %

                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NoCoupling_V_Uu_mm"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NoCoupling_V_Uu_h"  Style="width: 75%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="4">考<br />
                                虑<br />
                                耦<br />
                                扭<br />
                                转<br />
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
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_T1"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_Corner1"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_TorsionCoefficient1"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>横向
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_H_Fek_kN"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_H_Fek_Geq"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_H_Ue_mm"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_H_Ue_h"  Style="width: 75%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>2
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_T2"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_Corner2"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_TorsionCoefficient2"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>纵向
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_V_Fek_kN"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_V_Fek_Geq"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_V_Ue_mm"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_V_Ue_h"  Style="width: 75%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>3
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_T3"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_Corner3"  Style="width: 75%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Coupling_TorsionCoefficient3"  Style="width: 75%"></asp:Label>
                            </td>
                            <%--<td colspan="5" style="padding: 0">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 150px">地震作用最大方向：           
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="MaxActionDirection"  Style="width: 93.5%"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>--%>
                            <td colspan="1">地震作用最大方向</td>
                             <td colspan="4"> 
                                 <asp:Label  runat="server"  ClientIDMode="Static" ID="MaxActionDirection"  Style="width: 93.5%"></asp:Label>
                             </td>
                        </tr>
                        <tr>
                           <%-- <td colspan="10" style="padding: 0px;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 150px">时程分析程序名称：           
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistoryAnalysisProgramName"  Style="width: 96.6%"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>--%>
                            <td colspan="3">时程分析程序名称</td>
                             <td colspan="7">
                                 <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistoryAnalysisProgramName"  Style="width: 96.6%"></asp:Label>
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
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_WaveName1"  Style="width: 92.5%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_Fek_kN1"  Style="width: 89%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_Fek_Geq1"  Style="width: 82%"></asp:Label> %

                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_U_h1"  Style="width: 75%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_WaveName2"  Style="width: 92.5%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_Fek_kN2"  Style="width: 89%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_Fek_Geq2"  Style="width: 82%"></asp:Label> %

                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_U_h2"  Style="width: 75%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_WaveName3"  Style="width: 92.5%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_Fek_kN3"  Style="width: 89%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_Fek_Geq3"  Style="width: 82%"></asp:Label>
                                %

                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TimeHistory_U_h3"  Style="width: 75%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">现浇混凝土采<br />
                                用预拌混凝土<br />
                                (是否)
                            </td>
                            <td colspan="3">
                                 <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ISReadyMixedConcrete"  Style="width: 90%"></asp:Label></div> 
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtISReadyMixedConcrete"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                            <td colspan="4">采用预拌砂浆比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ReadyMixedMortarRatio"  Style="width: 73%"></asp:Label>
                                %

                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" rowspan="3">混凝土结构
                            </td>
                            <td colspan="7">400Mpa级及以上受力普通钢筋比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NormalSteelRatio"  Style="width: 73%"></asp:Label> %

                            </td>
                        </tr>
                        <tr>

                            <td colspan="7">C50混凝土用量占竖向承重结构中混凝土总量的比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="C50ConcreteRatio"  Style="width: 73%"></asp:Label> %

                            </td>
                        </tr>
                        <tr>

                            <td colspan="7">高耐久性混凝土占混凝土总量的比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="HighDurabilityConcreteRatio"  Style="width: 73%"></asp:Label> %

                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">钢结构
                            </td>
                            <td colspan="7">Q235及以上高强钢材用量占钢材总量的比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Q235SteelRatio"  Style="width: 73%"></asp:Label> %

                            </td>
                        </tr>
                        <tr>
                            <td colspan="11" style="text-align: center;">结构专业设计主要特点：（不少于600字）</td>
                        </tr>
                        <tr>
                            <td colspan="11">
                                <asp:TextBox  runat="server"  ClientIDMode="Static" ID="StructureMainFeatures" TextMode="MultiLine" style="width: 97%; min-height: 300px;display:block"></asp:TextBox>
                                <script id="StructureMainFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align:center;margin-top:40px;">
                        <a onclick="javascript:onPrev('05')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('05')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab6">
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_0405"   GroupingText="专业技术指标（设备专业）"  >
                    <table>
                        <tr>
                            <td style="width:150px;">采  暖  方  式
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="HeatingMode"  Style="width: 97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>采暖/空调总热负荷
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="SpaceHeatingLoad"  Style="width: 83%"></asp:Label> kW

                            </td>
                            <td style="width:150px;">空调总冷负荷
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="AirConCoolingLoad"  Style="width: 84%"></asp:Label> kW
                            </td>
                        </tr>
                        <tr>
                            <td>空调通风方式
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="AirConVentilationMode"  Style="width: 97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>空调水系统方式
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="AirConWaterSystemMode"  Style="width: 97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>给水系统方式
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="WaterSupplySystemMode"  Style="width: 97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>中水回收使用方式
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ReclaimedWaterRecycling"  Style="width: 97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>雨、污水排放方式
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="SewageDischargeMode"  Style="width: 97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>消防给水方式
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="FireWaterSupplyMode"  Style="width: 97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">供暖、空调末端装置可独立启停的主要功能房间数量比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IndependentRatio"  Style="width: 92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">冷、热源机组能效指标比现行国家标准提高或降低幅度
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="EnergyEfficiencyIndex"  Style="width: 92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">供暖、通风与空调系统能耗降低幅度
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="EnergyConsumptionReductionRange"  Style="width: 92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">由可再生能源提供的空调用冷量和热量比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="RenewableEnergyForAirConRatio"  Style="width: 92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">采用蓄冷蓄热系统（是/否）
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IsUsingStorageSystem"  Style="width: 92%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtIsUsingStorageSystem"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">利用余热废热供给建筑蒸汽、供暖或生活热水需求（是/否）
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IsUsingWasteHeat"  Style="width: 92%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtIsUsingWasteHeat"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">集中供暖系统热水循环泵的耗电输热比和通风空调系统风机的单<br />
                                位风量耗功率符合相关国家标准（是/否）
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IsStandard"  Style="width: 92%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtIsStandard"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">空调冷热水系统循环水泵的耗电输冷（热）比<br />
                                比现行国家标准规定值降低的比率
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ConsumptionRatio"  Style="width: 90%;margin-bottom:5px;margin-left:7%;"></asp:Label> %
                                <br />
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="LowerThanStandardValueRatio"  Style="width: 90%;margin-left:7%;"></asp:Label> %
                            </td>
                        </tr>
                        <tr>
                            <td>场地年径流总量控制率
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="RunoffControlRate"  Style="width: 88%"></asp:Label> %

                            </td>
                            <td>非传统水源利用率
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="NonTraditionalWaterUseRatio"  Style="width: 90%;margin-left:7%;"></asp:Label> %

                            </td>
                        </tr>
                        <tr>
                            <td>平均日用水量
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DailyWaterConsumption"  Style="width: 88%"></asp:Label> /d

                            </td>
                            <td>用水点供水压力
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="WaterSupplyPressure"  Style="width: 83%;margin-left:5px;"></asp:Label> MPa

                            </td>
                        </tr>
                        <tr>
                            <td>卫生器具用水效率等级
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="WaterEfficiencyRatingForSanitary"  Style="width: 88%"></asp:Label> 级

                            </td>
                            <td>分类设置用水计量装置<br />
                                （是/否）
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IsClassifyMeterage"  Style="width: 90%"></asp:Label></div> 
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtIsClassifyMeterage"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>绿化灌溉系统类别
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="GreeningIrrigationSystemType"  Style="width: 88%"></asp:Label>
                            </td>
                            <td>由可再生能源提供的生<br />
                                活用热水比例
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="RenewableEnergyForLivingHotWater"  Style="width: 90%"></asp:Label> %

                            </td>
                        </tr>
                        <tr>
                            <td>相关节水技术或措施
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="WaterSavingTechnology"  Style="width: 97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="text-align:center;padding-left:10px;">设备专业设计主要特点：</td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:TextBox  runat="server"  ClientIDMode="Static" ID="MechanicalMainFeatures"   TextMode="MultiLine" style="width: 98%; height: 300px; display:block"></asp:TextBox>
                                <script id="MechanicalMainFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>                
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('06')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('06')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab7">
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_0406"   GroupingText="专业技术指标（电气专业）"  >
                    <table>
                        <tr>
                            <td style="width:200px;">动力总电负荷
                            </td>
                            <td style="width:290px">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PowerTotalElectricLoad"  Style="width: 85%"></asp:Label> kW

                            </td>
                            <td colspan="2">照明总电负荷
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="LightingTotalElectricLoad"  Style="width: 80%"></asp:Label>
                                kW

                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">供电电源设计情况
                            </td>
                            <td rowspan="2" colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DesignOfPowerSupply"  Style="width: 95%"></asp:Label>
                            </td>
                            <td>变压器装机台数
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TransformerInstalledNumber"  Style="width: 80%"></asp:Label> 台

                            </td>
                        </tr>
                        <tr>
                            <td>变压器装机容量
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TransformerInstalledCapacity"  Style="width: 80%"></asp:Label>
                                kVA

                            </td>
                        </tr>
                        <tr>
                            <td>用电负荷等级确定情况
                            </td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PowerLoadLevel"  Style="width: 96.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>变压器装置指标
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TransformerIndex"  Style="width: 75%"></asp:Label> W/㎡

                            </td>
                            <td colspan="2">低压供电半径
                            </td>
                            <td>不大于 <asp:Label  runat="server"  ClientIDMode="Static" ID="LowVoltagePowerSupplyRadius"  Style="width: 65%"></asp:Label> m                      
                            </td>
                        </tr>
                        <tr>
                            <td>三相配电变压器能效等级
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="TransformerEnergyEfficiencyRating"  Style="width: 75%"></asp:Label>
                                级能效
                            </td>
                            <td colspan="2">电源侧功率因数
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PowerFactor"  Style="width: 86%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>主要谐波源
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="HarmonicSource"  Style="width: 75%"></asp:Label>
                            </td>
                            <td colspan="2">谐波治理措施
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="HarmonicControl"  Style="width: 86%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>照明方式节能措施
                            </td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="EnergySavingMeasures"  Style="width: 96.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="3">照明功率密度值
                            </td>
                            <td colspan="3">所有区域均达到现行值(是/否)
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IsAllAreasReachCurrentValue"  Style="width: 87%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtIsAllAreasReachCurrentValue"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">主要功能房间达到目标值(是/否)
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IsMainRoomAchieveTargetValue"  Style="width: 87%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtIsMainRoomAchieveTargetValue"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">所有区域均达到目标值(是/否)
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IsAllAreasAchieveTargetValue"  Style="width: 87%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtIsAllAreasAchieveTargetValue"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="4">主要照明灯具的效率
                            </td>
                            <td>灯具名称
                            </td>
                            <td>灯具效率
                            </td>
                            <td rowspan="2">显色指数<br />
                                是否全部<br />
                                达标
                            </td>
                            <td rowspan="2">
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IsColorRenderingIndexUpToStandard"  Style="width: 87%"></asp:Label></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtIsColorRenderingIndexUpToStandard"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="LampName1"  Style="width: 90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="LampEfficiency1"  Style="width: 80%"></asp:Label> %

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="LampName2"  Style="width: 90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="LampEfficiency2"  Style="width: 80%"></asp:Label> %

                            </td>
                            <td rowspan="2">眩光值<br />
                                是否全部<br />
                                达标
                            </td>
                            <td rowspan="2">
                                <div class="DeclarationList">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IsGlareValueUpToStandard"  Style="width: 87%"></asp:Label></div>
                                 <div class="ExpertReviewList" style="display: none">
                                    <asp:Label  runat="server"  ClientIDMode="Static" ID="txtIsGlareValueUpToStandard"   Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="LampName3"  Style="width: 90%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="LampEfficiency3"  Style="width: 80%"></asp:Label>
                                %

                            </td>
                        </tr>
                        <tr>
                            <td>动 力 内 容
                            </td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DynamicContent"  Style="width: 96.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>采用独立分项计量
                            </td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IndependentComponentMeasurement"  Style="width: 96.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>弱电设计内容
                            </td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="WeakDesignContent"  Style="width: 96.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>室内空气质量监控系统方式
                            </td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="IndoorAirQualityMonitoringSystem"  Style="width: 96.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>由可再生能源提供的电量比例
                            </td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="RenewableEnergySourcesRatio"  Style="width: 96.5%;margin-left:2%;"></asp:Label> %

                            </td>
                        </tr>
                        <tr>
                            <td>防雷设防类别及方式
                            </td>
                            <td colspan="4">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="LightningProtectionClass"  Style="width: 96.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5" style="text-align:center;padding-left:10px;">电气专业设计主要特点</td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:TextBox  runat="server"  ClientIDMode="Static" ID="ElectricalMainFeatures"   TextMode="MultiLine" style="width: 97%; height: 300px; display:block"></asp:TextBox>
                                <script id="ElectricalMainFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('07')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('07')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab8">
                <asp:Panel  runat="server"  ClientIDMode="Static" ID="panelPart_0407"   GroupingText="专业技术指标（技术经济指标）"  >
                    <table>
                        <tr>
                            <td style="width:170px;">单位规模建筑面积指标
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 75%; border-right: none;">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitAreaIndicators"  Style="width: 98%"></asp:Label>
                                        </td>
                                        <td style="border-right: none">㎡/                                            
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitAreaIndicatorsUnit"  Style="width: 75%; margin-left: 0px;"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="width:170px;">使用面积系数
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UseAreaCoefficient"  Style="width: 77%;display:inline-block;"></asp:Label>  %
                               

                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积耗热
                        量指标
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitAreaHotConsumption"  Width="73%"></asp:Label> W/㎡

                            </td>
                            <td>单位建筑面积耗
                        冷量指标
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitAreaColdConsumption"  Width="77%"></asp:Label> W/㎡

                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积变压
                        器装机容量
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitAreaTransformerCapacity"  Width="73%"></asp:Label>
                                VA/㎡

                            </td>
                            <td>日供水量
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="DailyWaterSupply"  Width="77%"></asp:Label> m³/日

                            </td>
                        </tr>
                        <tr>
                            <td>建筑总能耗
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="ConstructionTotalEnergyConsumption"  Width="73%"></asp:Label> MJ/a

                            </td>
                            <td>单位面积能耗
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="UnitAreaEnergyConsumption"  Style="width: 77%;display:inline-block;"></asp:Label> kWh/㎡a

                            </td>
                        </tr>
                        <tr>
                            <td>年用水总量
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PerYearTotalWaterConsumption"  Width="73%"></asp:Label> M³/a

                            </td>
                            <td>年节水量
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PerYearWaterSaving"  Style="width: 77%;display:inline-block;"></asp:Label>&nbsp;    t

                            </td>
                        </tr>
                        <tr>
                            <td>年节电量
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PerYearPowerSaving"  Style="width: 73%;display:inline-block;"></asp:Label> 万kWh/a

                            </td>
                            <td>年节煤量
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PerYearCoalSaving"  Style="width: 77%;display:inline-block;"></asp:Label>
                                tce

                            </td>
                        </tr>
                        <tr>
                            <td>每年减排二氧化碳
                            </td>
                            <td colspan="3" >
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="PerYaerCarbonEmissionReduction"  Width="91%"></asp:Label>
                                   &nbsp;t

                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">概     算
                            </td>
                            <td colspan="2">竣 工 结 算
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">总造价
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">人民币:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_RMB"  Width="75%"></asp:Label> 万元
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">总造价
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">人民币:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_RMB"  Width="72%"></asp:Label> &nbsp;&nbsp; 万元
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">外币:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_ForeignCurrency"  Width="75%"></asp:Label> 美元
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">外币:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_ForeignCurrency"  Width="72%"></asp:Label> 万美元
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">土建与安装工<br />
                                程的比例
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">土建:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_CivilEngineering"  Width="75%"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;  %
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">土建与安装工<br />
                                程的比例
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">土建:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_CivilEngineering"  Width="72%"></asp:Label>  %
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">安装:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_Install"  Width="75%"></asp:Label>  %
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">安装:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_Install"  Width="72%"></asp:Label>  %
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积<br />
                                造价
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_PerUnitAreaRMB"  Width="83%"></asp:Label> 元/㎡

                            </td>
                            <td>单位建筑面积<br />
                                造价
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_OneUnitAreaRMB"  Width="81%"></asp:Label> 元/㎡

                            </td>
                        </tr>
                        <tr>
                            <td>单位规模造价
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 75%; border-right: none;">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_PerUnitScaleRMB"  Width="97.5%"></asp:Label>
                                        </td>
                                        <td style="border-right: none">元/                                            
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_PerUnitScaleRMBUnit"  Style="margin-left: 0; width: 75%;"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>单位规模造价
                            </td>
                            <td>
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 75%; border-right: none;">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_OneUnitScaleRMB"  Width="98.5%"></asp:Label>
                                        </td>
                                        <td style="border-right: none">元/                                            
                                        </td>
                                        <td style="border-right: none">
                                            <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_OneUnitScaleRMBUnit"  Style="margin-left: 0; width: 75%;"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>绿色建筑增量<br />
                                成本
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_IncrementalCost"  Width="72%"></asp:Label> 元/㎡

                            </td>
                            <td>绿色建筑增量<br />
                                成本
                            </td>
                            <td>
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Settlement_IncrementalCost"  Width="73%"></asp:Label> 元/㎡

                            </td>
                        </tr>
                        <tr>
                            <td>结算与概算出入<br />
                                的主要原因
                            </td>
                            <td colspan="3">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="Estimate_Settlement_Difference"   Width="98%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="text-align:center;padding-left:10px;">
                                经济专业主要特点：（不少于100字）
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:TextBox  runat="server"  ClientIDMode="Static" ID="EconomicsFeatures"   TextMode="MultiLine" Style="width: 97%; height: 300px;display:block"></asp:TextBox>
                                <script id="EconomicsFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>                
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('08')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('09')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab10">
              <uc:Appendix runat="server" id="AppendixReview"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab11">
              <uc:LegalStates runat="server" id="LegalStatesReview"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab12">
              <uc:Certificate runat="server" id="CertificateReview"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab13">
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
             //$('#ProjectOverview').html(DecodeUEditorContent($('#ProjectOverview').text()));
             //$('#KeyTechnology').html(DecodeUEditorContent($('#KeyTechnology').text()));
             //$('#Effect').html(DecodeUEditorContent($('#Effect').text()));
             //$('#Benefit').html(DecodeUEditorContent($('#Benefit').text()));
             //$('#ArchitectureMainFeatures').html(DecodeUEditorContent($('#ArchitectureMainFeatures').text()));
             //$('#StructureMainFeatures').html(DecodeUEditorContent($('#StructureMainFeatures').text()));
             //$('#MechanicalMainFeatures').html(DecodeUEditorContent($('#MechanicalMainFeatures').text()));
             //$('#ElectricalMainFeatures').html(DecodeUEditorContent($('#ElectricalMainFeatures').text()));
             //$('#EconomicsFeatures').html(DecodeUEditorContent($('#EconomicsFeatures').text()));
             //$('#Awards').html(DecodeUEditorContent($('#Awards').text()));
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
                 onPrev("9");
             });
             $("#AppendixNext").click(function () {
                 onNext("10");
             });
             $("#LegalStatesPrev").click(function () {
                 onPrev("11");
             });
             $("#LegalStatesNext").click(function () {
                 onNext("11");
             });
             $("#CertificatePrev").click(function () {
                 onPrev("12");
             });
             $("#CertificateNext").click(function () {
                 onNext("12");
             });
             $("#CommentsPrev").click(function () {
                 onPrev("13");
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

             InitUEditor('ProjectOverviewTextBox', 500);           // 项目概况
             InitUEditor('KeyTechnologyTextBox', 1500);            // 关键绿色策略与技术
             InitUEditor('EffectTextBox', 1500);                   // 技术成效与深度
             InitUEditor('BenefitTextBox', 500);                   // 综合效益
             InitUEditor('ArchitectureMainFeaturesTextBox', 500);  // 建筑专业设计主要特点
             InitUEditor('StructureMainFeaturesTextBox', 600);     // 结构专业设计主要特点
             InitUEditor('MechanicalMainFeaturesTextBox', 2000);   // 设备专业设计主要特点
             InitUEditor('ElectricalMainFeaturesTextBox', 2000);   // 电气专业设计主要特点
             InitUEditor('EconomicsFeaturesTextBox', 2000);        // 经济专业主要特点
             InitUEditor('AwardsTextBox', 2000);                   // 曾获奖项
         });

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
     
     



