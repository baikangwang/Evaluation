<%@ Page  Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="AntiSeismic_V2.aspx.cs" Inherits="Evaluation.View.Declaration.AntiSeismic_V2"  validateRequest="false"%>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/Participant.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/Appendix.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStates_V2.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/Certificate.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/Css/Declaration.css" rel="stylesheet" />

    <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css"/>
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>
        
    <%--UEditor--%>
    <script src="../../Content/plugins/ueditor/ueditor.config.js"></script>
    <script src="../../Content/plugins/ueditor/ueditor.all.js"></script>
    <script src="../../Content/plugins/ueditor/lang/zh-cn/zh-cn.js"></script>

    <%--ui-choose--%> 
    <link href="../../Content/plugins/ui-choose/src/ui-choose.css" rel="stylesheet" />
    <script src="../../Content/plugins/ui-choose/src/ui-choose.js"></script>

    <script src="../../Content/Javascript/Declaration.js"></script>

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
            float:none!important; margin-left:4px;
        }
         #TechnologyFeatureTextBox{
            width:97%;margin-left:10px;text-align:center;
        }
      
        #content #test{
            height:2500px!important;
        }
        legend{
            margin-bottom: 0px!important;
        }
          #AwardsTextBox,#UnitOpinionTextBox,#RecommendOpinionTextBox{
            text-align:left;margin-left:8px;width:85%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <ul class="navs">
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=110000" id="nav02" runat="server" ClientIDMode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
        </li>       
    </ul>
   
    <div style="display:none"><asp:TextBox ID="txtSituation" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox ID="txtUser" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox ID="txtTemplate" runat="server" ClientIDMode="Static"></asp:TextBox></div>
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

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_1101" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 130px;">项目名称
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="DeclarationName" runat="server" ClientIDMode="Static" Width="95.3%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceDeclarationName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>主要设计单位
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="95.3%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceApprovalName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>境内、外合作设计单位</td>
                            <td style="padding: 0;" colspan="4">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 30.4%; border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:DropDownList runat="server" ID="DomesticOrAbord1" ClientIDMode="Static"></asp:DropDownList>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtDomesticOrAbord1" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                        </td>
                                        <td style="width: 23.8%; border-right: none; text-align: left;">
                                            <asp:TextBox ID="CooperativeUnit1" runat="server" ClientIDMode="Static" Style="width: 88%;" onblur="Sensitize('CooperativeUnit1','CollaborativePhase01')"></asp:TextBox>
                                        </td>
                                        <td style="border-right: none; width: 35%;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList1">
                                                <asp:DropDownList runat="server" ID="CollaborativePhase01" ClientIDMode="Static" Width="200px"></asp:DropDownList>
                                            </div>
                                            <div style="display: none">
                                                <asp:TextBox ID="CollaborativePhase1" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtCollaborativePhase1" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <%-- <asp:CheckBox runat="server" ID="IsResidentialCollaborativePhase1" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:DropDownList runat="server" ID="DomesticOrAbord2" ClientIDMode="Static"></asp:DropDownList>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtDomesticOrAbord2" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: left;" id="td2">
                                            <asp:TextBox ID="CooperativeUnit2" runat="server" ClientIDMode="Static" Style="width: 88%;" onblur="Sensitize('CooperativeUnit2','CollaborativePhase02')"></asp:TextBox>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList2">
                                                <asp:DropDownList runat="server" ID="CollaborativePhase02" ClientIDMode="Static" Width="200px"></asp:DropDownList>
                                            </div>
                                            <div style="display: none">
                                                <asp:TextBox ID="CollaborativePhase2" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtCollaborativePhase2" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <%--<asp:CheckBox runat="server" ID="IsResidentialCollaborativePhase2" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:DropDownList runat="server" ID="DomesticOrAbord3" ClientIDMode="Static"></asp:DropDownList>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtDomesticOrAbord3" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: left;" id="td3">
                                            <asp:TextBox ID="CooperativeUnit3" runat="server" ClientIDMode="Static" Style="width: 88%;" onblur="Sensitize('CooperativeUnit3','CollaborativePhase03')"></asp:TextBox>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList3">
                                                <asp:DropDownList runat="server" ID="CollaborativePhase03" ClientIDMode="Static" Width="200px"></asp:DropDownList>
                                            </div>
                                            <div style="display: none">
                                                <asp:TextBox ID="CollaborativePhase3" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtCollaborativePhase3" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <%--<asp:CheckBox runat="server" ID="IsResidentialCollaborativePhase3" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:DropDownList runat="server" ID="DomesticOrAbord4" ClientIDMode="Static"></asp:DropDownList>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtDomesticOrAbord4" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: left;" id="td4">
                                            <asp:TextBox ID="CooperativeUnit4" runat="server" ClientIDMode="Static" Style="width: 88%;" onblur="Sensitize('CooperativeUnit4','CollaborativePhase04')"></asp:TextBox>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList4">
                                                <asp:DropDownList runat="server" ID="CollaborativePhase04" ClientIDMode="Static" Width="200px"></asp:DropDownList>
                                            </div>
                                            <div style="display: none">
                                                <asp:TextBox ID="CollaborativePhase4" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtCollaborativePhase4" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <%--<asp:CheckBox runat="server" ID="IsResidentialCollaborativePhase4" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>                                                    
                        <tr>
                            <td>工程设计起止时间
                            </td>
                            <td style="margin-left:2.5%;">
                                <div class="datepicker input-group date" style="width: 47%;">
                                    <asp:TextBox ID="DesignStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计起始日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 1px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                               
                                <div class="datepicker input-group date" style="width: 47%;">
                                    <asp:TextBox ID="DesignEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计结束日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 1px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsCivilAirDefenceDesignEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>竣工验收时间
                            </td>
                            <td colspan="2">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="AcceptanceDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工验收日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsCivilAirDefenceAcceptanceDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td>
                                验收部门
                            </td> 
                            <td colspan="4">
                                <asp:TextBox ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td> 
                        </tr> 
                        <tr>
                            <td>申报单位<br />通讯地址
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefencePostalAddress" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                单位资质
                            </td>
                            <td>
                                <asp:TextBox ID="Qualification" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                            </td>
                            <td>
                                证书编号
                            </td>
                            <td>
                                <asp:TextBox ID="CertificateNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                            </td>  
                        </tr> 
                        <tr>
                            <td>申报单位联系人
                            </td>
                            <td style="width: 30%">
                                <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceLinkman" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>手    机
                            </td>
                            <td>
                                <asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceMobileNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>电    话
                            </td>
                            <td>
                                <asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceTelephoneNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefencePostcode" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>传    真
                            </td>
                            <td>
                                <asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceFaxNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceEmailAddress" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>                   
                    </table>
                    <div style="display:none"><a onclick="javascript:onSave('Template_1101')" id="Save_1101">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1101','Save')" class="btnt">保 &nbsp; &nbsp;存</a>
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" id="ucParticipant"></uc:Participant>
            </div> 
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_1102" runat="server" ClientIDMode="Static" GroupingText="抗震—技术申报内容—隔震">
                    <table>
                        <tr>
                            <td style="border: 0;" colspan="8">
                                <h3>Ⅰ——隔震工程项目情况表</h3>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 0; text-align: left;" colspan="8">
                                <p>1、总体信息</p>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 120px;">项目名称
                            </td>
                            <td colspan="5">
                                <asp:TextBox ID="ShockProjectName" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockProjectName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>用途
                            </td>
                            <td>
                                <asp:TextBox ID="ShockPurpose" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockPurpose" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="ShockConstructionSite" runat="server" ClientIDMode="Static" Width="94%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockConstructionSite" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>建设时间
                            </td>
                            <td colspan="2">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="ShockConstructionTime" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择建设日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width:35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsAntiSeismicShockConstructionTime" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>总高度<br />
                                (m)
                            </td>
                            <td>
                                <asp:TextBox ID="ShockTotalHeight" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockTotalHeight" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td style="width: 80px;">占地面积<br />
                                (㎡)
                            </td>
                            <td>
                                <asp:TextBox ID="ShockCoveredArea" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockCoveredArea" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td style="width: 120px;">建筑面积<br />
                                (㎡)
                            </td>
                            <td>
                                <asp:TextBox ID="ShockConstructionArea" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockConstructionArea" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td style="width: 120px;">隔震层面积<br />
                                (㎡)
                            </td>
                            <td>
                                <asp:TextBox ID="IsolationLayerArea" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicIsolationLayerArea" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>高宽比
                            </td>
                            <td>
                                <asp:TextBox ID="ShockHighAspectRatio" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockHighAspectRatio" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>层数
                            </td>
                            <td style="padding: 0">
                                <table>
                                    <tr>
                                        <td style="width: 53px;">地上：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="ShockLayer_Ground" runat="server" ClientIDMode="Static" Width="68%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicShockLayer_Ground" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>地下：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="ShockLayer_Underground" runat="server" ClientIDMode="Static" Width="68%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicShockLayer_Underground" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>首层层高<br />
                                (m)
                            </td>
                            <td>
                                <asp:TextBox ID="ShockFirstStoreyHeight" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockFirstStoreyHeight" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>标准层高<br />
                                (m)
                            </td>
                            <td>
                                <asp:TextBox ID="ShockStandardHeight" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockStandardHeight" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TechnologyDevelopmentOrganization" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTechnologyDevelopmentOrganization" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>施工单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TechnologyConstructionOrganization" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTechnologyConstructionOrganization" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="ShockDesignOrganization" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="ShockIsAntiSeismicDesignOrganization" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>施工图审查<br />
                                机构
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="ShockConstructionPlansCensorship" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockConstructionPlansCensorship" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>混凝土总用<br />
                                量(m3)
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="ShockConcreteAmount" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockConcreteAmount" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>每平方米混<br />
                                凝土折算厚<br />
                                度(cm/㎡)
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="ShockPerSqM_ConcreteReducedThickness" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockPerSqM_ConcreteReducedThickness" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>钢材总用量<br />
                                (t)
                            </td>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td>钢筋：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="ShockSteelAmount_rebar" runat="server" ClientIDMode="Static" Width="91%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicShockSteelAmount_rebar" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>型钢：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="ShockSteelAmount_SectionSteel" runat="server" ClientIDMode="Static" Width="91%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicShockSteelAmount_SectionSteel" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                        <td>钢筋：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="ShockPerSqM_SteelAmount_Rebar" runat="server" ClientIDMode="Static" Width="91%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicShockPerSqM_SteelAmount_Rebar" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>型钢：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="ShockPerSqM_SteelAmount_SectionSteel" runat="server" ClientIDMode="Static" Width="91%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicShockPerSqM_SteelAmount_SectionSteel" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                <asp:DropDownList ID="ShockSeismicAccelerationParameter" runat="server" ClientIDMode="Static" Width="97%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtShockSeismicAccelerationParameter" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox ID="IsAntiSeismicShockSeismicAccelerationParameter" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">设计基本地震动加速度(g)
                            </td>
                            <td>
                                <asp:TextBox ID="ShockBasicSeismicAcceleration" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockBasicSeismicAcceleration" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">场地类别
                            </td>
                            <td>
                                <asp:TextBox ID="ShockSiteType" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockSiteType" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">特征周期<br />
                                (s)
                            </td>
                            <td style="width: 100px;">
                                <asp:TextBox ID="ShockEigenperiod" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockEigenperiod" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">抗震设防<br />
                                类别
                            </td>
                            <td>
                                <asp:TextBox ID="ShockFortificationCategory" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockFortificationCategory" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">时程分析用地震波（名称/调幅值(gal)/特征周期（s））
                            </td>
                            <td colspan="7">
                                <asp:TextBox ID="ShockTimeHistoryAnalysis" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockTimeHistoryAnalysis" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">液化、震陷、断裂等不利场<br />
                                地因素措施
                            </td>
                            <td colspan="7">
                                <asp:TextBox ID="ShockAdverseFactorsMmeasures" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockAdverseFactorsMmeasures" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 80px;">基础形式
                            </td>
                            <td>
                                <asp:TextBox ID="ShockBaseType" runat="server" ClientIDMode="Static" Width="82%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockBaseType" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">上部结构形式
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="ShockUpperStructureForm" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockUpperStructureForm" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">地下室结构形式
                            </td>
                            <td>
                                <asp:TextBox ID="ShockBasementStructuralForm" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockBasementStructuralForm" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">隔震层位置（标高和层）
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="ShockIsolationLayerLocation" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockIsolationLayerLocation" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">水平向减震系数
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="ShockHorizontalDampingCoefficient" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicShockHorizontalDampingCoefficient" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">隔震设计基本周期(s)
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="IsolationDesignBasePeriod" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicIsolationDesignBasePeriod" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">上部结构基本周期(s)
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="UpperStructureBasePeriod" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicUpperStructureBasePeriod" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">隔震支座实际使用平均面压<br />
                                最大最小面压(MPa)
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="SurfacePressure" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicSurfacePressure" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">隔震支座设计最大位移(cm)
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="MaxDisplacement" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMaxDisplacement" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">隔震层顶板体系
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="RoofSystem" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicRoofSystem" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">隔震层下支墩（柱）主要断面
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="MainSection" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMainSection" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">总质量（t）
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TotalMass" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTotalMass" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">阻尼比(%)
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DampingRatio" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDampingRatio" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                <asp:TextBox ID="DampingSeismicAnalysisProgramName" runat="server" ClientIDMode="Static" Width="96%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDampingSeismicAnalysisProgramName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                <asp:TextBox ID="Isolation_M_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicSeismicIsolation_M_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Isolation_M_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicIsolation_M_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Isolation_L_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicIsolation_L_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Isolation_L_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicIsolation_L_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>基底最大剪力(kN）
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_M_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBaseShear_M_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_M_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBaseShear_M_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_L_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBaseShear_L_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_L_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBaseShear_L_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屋顶最大相对位移 (mm)
                            </td>
                            <td>
                                <asp:TextBox ID="RoofDrift_M_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicRoofDrift_M_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="RoofDrift_M_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicRoofDrift_M_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="RoofDrift_L_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicRoofDrift_L_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="RoofDrift_L_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicRoofDrift_L_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>最大层间相对位移 (mm)
                            </td>
                            <td>
                                <asp:TextBox ID="StoreyDrift_M_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicStoreyDrift_M_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="StoreyDrift_M_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicStoreyDrift_M_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="StoreyDrift_L_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicStoreyDrift_L_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="StoreyDrift_L_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicStoreyDrift_L_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>最大层间位移角
                            </td>
                            <td>
                                <asp:TextBox ID="StoryDriftRatio_M_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicStoryDriftRatio_M_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="StoryDriftRatio_M_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicStoryDriftRatio_M_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="StoryDriftRatio_L_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicStoryDriftRatio_L_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="StoryDriftRatio_L_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicStoryDriftRatio_L_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>最大反应加速度 (g)
                            </td>
                            <td>
                                <asp:TextBox ID="Acceleration_M_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicAcceleration_M_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Acceleration_M_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicAcceleration_M_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Acceleration_L_H" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicAcceleration_L_H" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Acceleration_L_V" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicAcceleration_L_V" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                        <td>
                                            <asp:TextBox ID="Manufacturer_IsolationBearing" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicManufacturer_IsolationBearing" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                        <td>阻尼器：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="Manufacturer_Damper" runat="server" ClientIDMode="Static" Width="91%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicManufacturer_Damper" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                <asp:TextBox ID="Bearing_Model1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_Model1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_Model2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_Model2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_Model3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_Model3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_Model4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_Model4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_Model5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_Model5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">个数
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_Number1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_Number1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_Number2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_Number2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_Number3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_Number3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_Number4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_Number4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_Number5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_Number5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">有效直径(mm)
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_EffectiveDiameter1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_EffectiveDiameter1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_EffectiveDiameter2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_EffectiveDiameter2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_EffectiveDiameter3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_EffectiveDiameter3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_EffectiveDiameter4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_EffectiveDiameter4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_EffectiveDiameter5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_EffectiveDiameter5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">铅芯直径(mm)
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_LeadDiameter1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_LeadDiameter1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_LeadDiameter2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_LeadDiameter2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_LeadDiameter3" runat="server" ClientIDMode="Static" Width="84%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_LeadDiameter3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_LeadDiameter4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_LeadDiameter4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_LeadDiameter5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_LeadDiameter5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">产品外径(mm)
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_OutsideDiameter1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_OutsideDiameter1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_OutsideDiameter2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_OutsideDiameter2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_OutsideDiameter3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_OutsideDiameter3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_OutsideDiameter4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_OutsideDiameter4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_OutsideDiameter5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_OutsideDiameter5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">橡胶层总厚度(mm)
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_RubberThickness1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_RubberThickness1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_RubberThickness2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_RubberThickness2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_RubberThickness3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_RubberThickness3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_RubberThickness4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_RubberThickness4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_RubberThickness5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_RubberThickness5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">一次形状系数
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_LinearShapeFactor1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_LinearShapeFactor1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_LinearShapeFactor2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_LinearShapeFactor2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_LinearShapeFactor3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_LinearShapeFactor3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_LinearShapeFactor4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_LinearShapeFactor4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_LinearShapeFactor5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_LinearShapeFactor5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">二次形状系数
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_QuadraticShapeFactor1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_QuadraticShapeFactor1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_QuadraticShapeFactor2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_QuadraticShapeFactor2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_QuadraticShapeFactor3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_QuadraticShapeFactor3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_QuadraticShapeFactor4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_QuadraticShapeFactor4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_QuadraticShapeFactor5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_QuadraticShapeFactor5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">橡胶剪切弹性模量 (N/m㎡)
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_ShearModulus1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_ShearModulus1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_ShearModulus2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_ShearModulus2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_ShearModulus3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_ShearModulus3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_ShearModulus4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_ShearModulus4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_ShearModulus5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_ShearModulus5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">竖向刚度 (kN/mm)
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_VerticalStiffness1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_VerticalStiffness1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_VerticalStiffness2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_VerticalStiffness2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_VerticalStiffness3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_VerticalStiffness3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_VerticalStiffness4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_VerticalStiffness4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_VerticalStiffness5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_VerticalStiffness5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                <asp:TextBox ID="Bearing_HorizontalStiffness1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_HorizontalStiffness1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_HorizontalStiffness2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_HorizontalStiffness2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_HorizontalStiffness3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_HorizontalStiffness3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_HorizontalStiffness4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_HorizontalStiffness4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_HorizontalStiffness5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_HorizontalStiffness5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>250%水平性能
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_HorizontalStiffness_Times1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_HorizontalStiffness_Times1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_HorizontalStiffness_Times2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_HorizontalStiffness_Times2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_HorizontalStiffness_Times3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_HorizontalStiffness_Times3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_HorizontalStiffness_Times4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_HorizontalStiffness_Times4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_HorizontalStiffness_Times5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_HorizontalStiffness_Times5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">等效阻尼比<br />
                                (%)
                            </td>
                            <td>100%水平性能
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_DampingRatio1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_DampingRatio1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_DampingRatio2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_DampingRatio2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_DampingRatio3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_DampingRatio3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_DampingRatio4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_DampingRatio4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_DampingRatio5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_DampingRatio5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>250%水平性能
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_DampingRatio_Times1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_DampingRatio_Times1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_DampingRatio_Times2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_DampingRatio_Times2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_DampingRatio_Times3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_DampingRatio_Times3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_DampingRatio_Times4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_DampingRatio_Times4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_DampingRatio_Times5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_DampingRatio_Times5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">屈服后刚度Kd(kN/m)
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_YieldStiffness1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_YieldStiffness1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_YieldStiffness2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_YieldStiffness2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_YieldStiffness3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_YieldStiffness3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_YieldStiffness4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_YieldStiffness4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_YieldStiffness5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_YieldStiffness5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">屈服力Qd(kN)
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_YieldStress1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_YieldStress1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_YieldStress2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_YieldStress2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_YieldStress3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_YieldStress3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_YieldStress4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_YieldStress4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Bearing_YieldStress5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBearing_YieldStress5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                <asp:TextBox ID="Damper_Model1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Model1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Model2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Model2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Model3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Model3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Model4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Model4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Model5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Model5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">个数
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Number1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Number1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Number2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Number2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Number3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Number3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Number4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Number4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Number5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Number5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">最大阻尼出力 (t)
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_MaxCapacity1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_MaxCapacity1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_MaxCapacity2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_MaxCapacity2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_MaxCapacity3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_MaxCapacity3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_MaxCapacity4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_MaxCapacity4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_MaxCapacity5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_MaxCapacity5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">阻尼系数C
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Coefficient1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Coefficient1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Coefficient2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Coefficient2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Coefficient3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Coefficient3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Coefficient4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Coefficient4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_Coefficient5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_Coefficient5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">速度指数α
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_VelocityIndex1" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_VelocityIndex1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_VelocityIndex2" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_VelocityIndex2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_VelocityIndex3" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_VelocityIndex3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_VelocityIndex4" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_VelocityIndex4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Damper_VelocityIndex5" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDamper_VelocityIndex5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                    </table>
                    <div style="display:none"><a onclick="javascript:onSave('Template_1102')" id="Save_1102">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                    <a onclick="javascript:onSave('Template_1102','Save')" class="btnt">保 &nbsp;&nbsp;存</a>
                    <a onclick="javascript:onPrev('03')"  class="btnt up" style="margin-left: 20px;">上 一 步</a>
                    <a onclick="javascript:onNext('03')"  class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab4">
                <asp:Panel ID="panelPart_1103" runat="server" ClientIDMode="Static" GroupingText="抗震—技术申报内容—消能减震">
                    <table>
                        <tr>
                            <td style="border: 0;" colspan="8">
                                <h3>Ⅱ——消能减震工程项目情况表</h3>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: 0; text-align: left;" colspan="8">
                                <p>1、总体信息</p>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 120px;">项目名称
                            </td>
                            <td colspan="5">
                                <asp:TextBox ID="ProjectName" runat="server" ClientIDMode="Static" Width="95.8%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicProjectName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>用途
                            </td>
                            <td>
                                <asp:TextBox ID="Purpose" runat="server" ClientIDMode="Static" Width="82%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicPurpose" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="ConstructionSite" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicConstructionSit" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>建设时间
                            </td>
                            <td colspan="2">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="ConstructionTime" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择建设起始日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox ID="IsAntiSeismicConstructionTime" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>总高度<br />
                                (m)
                            </td>
                            <td>
                                <asp:TextBox ID="TotalHeight" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTotalHeight" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">占地面积<br />
                                (㎡)
                            </td>
                            <td>
                                <asp:TextBox ID="CoveredArea" runat="server" ClientIDMode="Static" Width="83.2%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoveredArea" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">建筑面积<br />
                                (㎡)
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="ConstructionArea" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicConstructionArea" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>

                        </tr>
                        <tr>
                            <td>高宽比
                            </td>
                            <td>
                                <asp:TextBox ID="HighAspectRatio" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicHighAspectRatio" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>层数
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 53px;">地上：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="Layer_Ground" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicLayer_Ground" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>地下：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="Layer_Underground" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicLayer_Underground" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>首层层高<br />
                                (m)
                            </td>
                            <td>
                                <asp:TextBox ID="FirstStoreyHeight" runat="server" ClientIDMode="Static" Width="79%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicFirstStoreyHeight" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td style="width: 100px;">标准层高<br />
                                (m)
                            </td>
                            <td>
                                <asp:TextBox ID="StandardHeight" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicStandardHeight" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DampingDevelopmentOrganization" runat="server" ClientIDMode="Static" Width="93.2%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDampingDevelopmentOrganization" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>施工单位
                            </td>
                            <td  colspan="3">
                                <asp:TextBox ID="DampingConstructionOrganization" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDampingConstructionOrganization" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DampingDesignOrganization" runat="server" ClientIDMode="Static" Width="93.2%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDampingDesignOrganization" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>施工图审查<br />
                                机构
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DampingConstructionPlansCensorship" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDampingConstructionPlansCensorship" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>混凝土总用<br />
                                量(m3)
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DampingConcreteAmount" runat="server" ClientIDMode="Static" Width="93.2%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDampingConcreteAmount" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>每平方米混<br />
                                凝土折算厚<br />
                                度(cm/㎡)
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DampingPerSqM_ConcreteReducedThickness" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicDampingPerSqM_ConcreteReducedThickness" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>钢材总用量<br />
                                (t)
                            </td>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td>钢筋：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="DampingSteelAmount_rebar" runat="server" ClientIDMode="Static" Width="91%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicDampingSteelAmount_rebar" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>型钢：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="DampingSteelAmount_SectionSteel" runat="server" ClientIDMode="Static" Width="91%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicDampingSteelAmount_SectionSteel" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                            <asp:TextBox ID="DampingPerSqM_SteelAmount_Rebar" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicDampingPerSqM_SteelAmount_Rebar" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>型钢：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="DampingPerSqM_SteelAmount_SectionSteel" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicDampingPerSqM_SteelAmount_SectionSteel" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                <asp:DropDownList ID="SeismicAccelerationParameter" runat="server" ClientIDMode="Static" Width="97%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtSeismicAccelerationParameter" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox ID="IsAntiSeismicSeismicAccelerationParameter" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">设计基本地震动加速度(g)
                            </td>
                            <td>
                                <asp:TextBox ID="BasicSeismicAcceleration" runat="server" ClientIDMode="Static" Width="84%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicSeismicBasicSeismicAcceleration" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>场地类别
                            </td>
                            <td>
                                <asp:TextBox ID="SiteType" runat="server" ClientIDMode="Static" Width="84%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicSiteType" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>特征周期(s)
                            </td>
                            <td>
                                <asp:TextBox ID="Eigenperiod" runat="server" ClientIDMode="Static" Width="84%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicEigenperiod" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>抗震设防类别
                            </td>
                            <td>
                                <asp:TextBox ID="FortificationCategory" runat="server" ClientIDMode="Static" Width="84%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicFortificationCategory" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">时程分析用地震波（名称/调幅值(gal)/特征周期（s））
                            </td>
                            <td colspan="7">
                                <asp:TextBox ID="TimeHistoryAnalysis" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTimeHistoryAnalysis" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">液化、震陷、断裂等不利场地因素措施
                            </td>
                            <td colspan="7">
                                <asp:TextBox ID="AdverseFactorsMmeasures" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicAdverseFactorsMmeasures" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 100px;">基础形式
                            </td>
                            <td style="width: 100px;">
                                <asp:TextBox ID="BaseType" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBaseType" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">上部结构形式
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="UpperStructureForm" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicUpperStructureForm" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">地下室结构形式
                            </td>
                            <td>
                                <asp:TextBox ID="BasementStructuralForm" runat="server" ClientIDMode="Static" Width="84%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBasementStructuralForm" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">隔震层位置（标高和层）
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="IsolationLayerLocation" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBasementIsolationLayerLocation" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">水平向减震系数
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="HorizontalDampingCoefficient" runat="server" ClientIDMode="Static" Width="94%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicHorizontalDampingCoefficient" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">主体结构阻尼比
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MainBodyDampingRatio" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMainBodyDampingRatio" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">结构附加有效阻尼比
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="AdditionalEffectiveDampingRatio" runat="server" ClientIDMode="Static" Width="94%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicAdditionalEffectiveDampingRatio" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">结构前6阶周期 (s)
                            </td>
                            <td colspan="7">
                                <asp:TextBox ID="Cyc" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCyc" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                            <asp:TextBox ID="SeismicAnalysisProgramName" runat="server" ClientIDMode="Static" Width="96%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicSeismicAnalysisProgramName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                <asp:TextBox ID="NoCoupling_H_T1" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicNoCoupling_H_T1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="NoCoupling_H_Fek_kN" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox> %
                       <asp:CheckBox ID="IsAntiSeismicNoCoupling_H_Fek_kN" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="NoCoupling_H_Fek_Geq" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicNoCoupling_H_Fek_Geq" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="NoCoupling_H_Uu_mm" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicNoCoupling_H_Uu_mm" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="NoCoupling_H_Uu_h" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicNoCoupling_H_Uu_h" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>纵向
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="NoCoupling_V_T1" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicNoCoupling_V_T1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="NoCoupling_V_Fek_kN" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox> %
                       <asp:CheckBox ID="IsAntiSeismicNoCoupling_V_Fek_kN" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="NoCoupling_V_Fek_Geq" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicNoCoupling_V_Fek_Geq" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="NoCoupling_V_Uu_mm" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicNoCoupling_V_Uu_mm" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="NoCoupling_V_Uu_h" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicNoCoupling_V_Uu_h" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                <asp:TextBox ID="Coupling_T1" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_T1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_Corner1" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_Corner1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_TorsionCoefficient1" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_TorsionCoefficient1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>横向
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_H_Fek_kN" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_H_Fek_kN" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_H_Fek_Geq" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_H_Fek_Geq" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_H_Ue_mm" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_H_Ue_mm" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_H_Ue_h" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_H_Ue_h" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>2
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_T2" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_T2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_Corner2" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_Corner2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_TorsionCoefficient2" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_TorsionCoefficient2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>纵向
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_V_Fek_kN" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_V_Fek_kN" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_V_Fek_Geq" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_V_Fek_Geq" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_V_Ue_mm" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_V_Ue_mm" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_V_Ue_h" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_V_Ue_h" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>3
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_T3" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_T3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_Corner3" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_Corner3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_TorsionCoefficient3" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicCoupling_TorsionCoefficient3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">地震作用最大方向：
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="MaxActionDirection" runat="server" ClientIDMode="Static" Width="93.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMaxActionDirection" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">时程分析程序名称：
                            </td>
                            <td colspan="7">
                                <asp:TextBox ID="TimeHistoryAnalysisProgramName" runat="server" ClientIDMode="Static" Width="96.9%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTimeHistoryAnalysisProgramName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                <asp:TextBox ID="TimeHistory_WaveName1" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTimeHistory_WaveName1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_kN1" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTimeHistory_Fek_kN1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_Geq1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> %
                       <asp:CheckBox ID="IsAntiSeismicTimeHistory_Fek_Geq1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_U_h1" runat="server" ClientIDMode="Static" Width="89%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTimeHistory_U_h1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:TextBox ID="TimeHistory_WaveName2" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTimeHistory_WaveName2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_kN2" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTimeHistory_Fek_kN2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_Geq2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> %
                       <asp:CheckBox ID="IsAntiSeismicTimeHistory_Fek_Geq2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_U_h2" runat="server" ClientIDMode="Static" Width="89%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTimeHistory_U_h2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:TextBox ID="TimeHistory_WaveName3" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTimeHistory_WaveName3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_kN3" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTimeHistory_Fek_kN3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_Geq3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> %
                       <asp:CheckBox ID="IsAntiSeismicTimeHistory_Fek_Geq3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_U_h3" runat="server" ClientIDMode="Static" Width="89%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicTimeHistory_U_h3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                            <asp:TextBox ID="Manufacturer_ViscousDamper" runat="server" ClientIDMode="Static" Width="96%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicManufacturer_ViscousDamper" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>金属阻尼器：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="Manufacturer_MetallicDamper" runat="server" ClientIDMode="Static" Width="96%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicManufacturer_MetallicDamper" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>屈曲约束支撑：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="Manufacturer_BrB" runat="server" ClientIDMode="Static" Width="96%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicManufacturer_BrB" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>其他：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="Manufacturer_Other" runat="server" ClientIDMode="Static" Width="96%"></asp:TextBox>
                                            <asp:CheckBox ID="IsAntiSeismicManufacturer_Other" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                                <asp:TextBox ID="ViscousDamper_Model1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Model1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Model2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Model2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Model3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Model3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Model4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Model4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Model5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Model5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Model6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Model6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Model7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Model7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>个数
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Number1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Number1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Number2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Number2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Number3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Number3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Number4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Number4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Number5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Number5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Number6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Number6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Number7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Number7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>极限位移(mm)
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_LimitDrift1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_LimitDrift1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_LimitDrift2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_LimitDrift2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_LimitDrift3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_LimitDrift3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_LimitDrift4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_LimitDrift4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_LimitDrift5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_LimitDrift5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_LimitDrift6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_LimitDrift6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_LimitDrift7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_LimitDrift7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>最大阻尼出力 (t)
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_MaxCapacity1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_MaxCapacity1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_MaxCapacity2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_MaxCapacity2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_MaxCapacity3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_MaxCapacity3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_MaxCapacity4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_MaxCapacity4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_MaxCapacity5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_MaxCapacity5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_MaxCapacity6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_MaxCapacity6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_MaxCapacity7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_MaxCapacity7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>阻尼系数C
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Coefficient1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Coefficient1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Coefficient2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Coefficient2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Coefficient3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Coefficient3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Coefficient4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Coefficient4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Coefficient5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Coefficient5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Coefficient6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Coefficient6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_Coefficient7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_Coefficient7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>速度指数α
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_VelocityIndex1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_VelocityIndex1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_VelocityIndex2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_VelocityIndex2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_VelocityIndex3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_VelocityIndex3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_VelocityIndex4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_VelocityIndex4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_VelocityIndex5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_VelocityIndex5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_VelocityIndex6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_VelocityIndex6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="ViscousDamper_VelocityIndex7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicViscousDamper_VelocityIndex7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="7">金属型阻尼器
                            </td>
                            <td>型号
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Model1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Model1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Model2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Model2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Model3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Model3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Model4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Model4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Model5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Model5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Model6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Model6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Model7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Model7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>个数
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Number1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Number1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Number2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Number2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Number3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Number3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Number4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Number4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Number5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Number5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Number6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Number6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_Number7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_Number7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服位移(mm)
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldDrift1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldDrift1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldDrift2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldDrift2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldDrift3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldDrift3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldDrift4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldDrift4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldDrift5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldDrift5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldDrift6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldDrift6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldDrift7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldDrift7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服荷载 (t)
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldLoad1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldLoad1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldLoad2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldLoad2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldLoad3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldLoad3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldLoad4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldLoad4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldLoad5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldLoad5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldLoad6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldLoad6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldLoad7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldLoad7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服后刚度 (t/cm)
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldStiffness1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldStiffness1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldStiffness2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldStiffness2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldStiffness3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldStiffness3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldStiffness4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldStiffness4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldStiffness5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldStiffness5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldStiffness6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldStiffness6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_YieldStiffness7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_YieldStiffness7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>极限荷载 (t)
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitLoad1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitLoad1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitLoad2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitLoad2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitLoad3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitLoad3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitLoad4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitLoad4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitLoad5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitLoad5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitLoad6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitLoad6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitLoad7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitLoad7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>极限位移(mm)
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitStiffness1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitStiffness1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitStiffness2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitStiffness2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitStiffness3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitStiffness3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitStiffness4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitStiffness4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitStiffness5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitStiffness5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitStiffness6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitStiffness6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="MetallicDamper_LimitStiffness7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicMetallicDamper_LimitStiffness7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="7">屈曲约束支撑
                            </td>
                            <td>型号
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Model1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Model1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Model2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Model2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Model3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Model3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Model4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Model4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Model5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Model5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Model6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Model6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Model7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Model7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>个数
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Number1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Number1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Number2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Number2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Number3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Number3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Number4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Number4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Number5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Number5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Number6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Number6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_Number7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_Number7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服位移(mm)
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldDrift1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldDrift1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldDrift2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldDrift2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldDrift3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldDrift3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldDrift4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldDrift4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldDrift5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldDrift5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldDrift6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldDrift6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldDrift7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldDrift7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服荷载 (t)
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldLoad1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldLoad1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldLoad2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldLoad2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldLoad3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldLoad3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldLoad4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldLoad4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldLoad5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldLoad5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldLoad6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldLoad6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldLoad7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldLoad7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>屈服后刚度 (t/cm)
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldStiffness1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldStiffness1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldStiffness2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldStiffness2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldStiffness3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldStiffness3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldStiffness4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldStiffness4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldStiffness5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldStiffness5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldStiffness6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldStiffness6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_YieldStiffness7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_YieldStiffness7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>极限荷载 (t)
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitLoad1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitLoad1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitLoad2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitLoad2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitLoad3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitLoad3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitLoad4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitLoad4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitLoad5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitLoad5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitLoad6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitLoad6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitLoad7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitLoad7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>极限位移(mm)
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitStiffness1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitStiffness1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitStiffness2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitStiffness2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitStiffness3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitStiffness3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitStiffness4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitStiffness4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitStiffness5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitStiffness5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitStiffness6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitStiffness6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="BrB_LimitStiffness7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicBrB_LimitStiffness7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="4">其它类型阻尼器
                            </td>
                            <td>型号
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Model1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Model1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Model2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Model2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Model3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Model3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Model4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Model4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Model5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Model5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Model6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Model6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Model7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Model7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>个数
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Number1" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Number1" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Number2" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Number2" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Number3" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Number3" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Number4" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Number4" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Number5" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Number5" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Number6" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Number6" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Other_Number7" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                <asp:CheckBox ID="IsAntiSeismicOther_Number7" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                    <div style="display:none"><a onclick="javascript:onSave('Template_1103')" id="Save_1103">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                    <a onclick="javascript:onSave('Template_1103','Save')" class="btnt">保 &nbsp; &nbsp;存</a>
                    <a onclick="javascript:onPrev('04')"  class="btnt up" style="margin-left:20px;">上 一 步</a>
                    <a onclick="javascript:onNext('04')"  class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab5">
                <asp:Panel ID="panelPart_1104" runat="server" ClientIDMode="Static" GroupingText="工程概况、说明设计特点、技术经济指标">
                    <table>
                        <tr>
                            <td style="text-align:left;padding-left:10px;">（600～1000字，提供必要的图纸和计算分析）</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="TechnologyFeature" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="TechnologyFeatureTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsAntiSeismicTechnologyFeature" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                                <script id="AwardsTextBox" type="text/plain" style="height: 300px;"></script>
                            </td> 
                        </tr>
<%--                        <tr>
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
                                <script id="RecommendOpinionTextBox" type="text/plain" style="height: 300px;"></script>
                            </td> 
                        </tr>  
                    </table> 
                    <div style="display:none"><a onclick="javascript:onSave('Template_1104')" id="Save_1104">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                    <a onclick="javascript:onSave('Template_1104','Save')" class="btnt">保 &nbsp;&nbsp;存</a>
                    <a onclick="javascript:onPrev('05')"  class="btnt up" style="margin-left:20px;">上 一 步</a>
                    <a onclick="javascript:onNext('05')"  class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab6">
                <uc:Appendix runat="server" id="Appendix"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab7">
                <uc:LegalStates runat="server" ID="ucLegalStates"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab8">
                <uc:Certificate runat="server" ID="ucCertificate"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab9">
                <uc:Comments runat="server" ID="ucComments"></uc:Comments>
            </div>
        </div>
    </div>
    
  <script type="text/javascript">
      $('#ProfessionalCategories').ui_choose();
      $('#SeismicAccelerationParameter').ui_choose();
      $('#ShockSeismicAccelerationParameter').ui_choose();

      switch ($('#SeismicAccelerationParameter').val()) {
          case "3101":
              $('#txtSeismicAccelerationParameter').val("小于等于0.05g");
              break;
          case "3102":
              $('#txtSeismicAccelerationParameter').val("小于等于0.10g");
              break;
          case "3103":
              $('#txtSeismicAccelerationParameter').val("小于等于0.15g");
              break;
          case "3104":
              $('#txtSeismicAccelerationParameter').val("小于等于0.20g");
              break;
          case "3105":
              $('#txtSeismicAccelerationParameter').val("小于等于0.30g");
              break;
          case "3106":
              $('#txtSeismicAccelerationParameter').val("大于等于0.40g");
              break;
      }

      switch ($('#ShockSeismicAccelerationParameter').val()) {
          case "3101":
              $('#txtShockSeismicAccelerationParameter').val("小于等于0.05g");
              break;
          case "3102":
              $('#txtShockSeismicAccelerationParameter').val("小于等于0.10g");
              break;
          case "3103":
              $('#txtShockSeismicAccelerationParameter').val("小于等于0.15g");
              break;
          case "3104":
              $('#txtShockSeismicAccelerationParameter').val("小于等于0.20g");
              break;
          case "3105":
              $('#txtShockSeismicAccelerationParameter').val("小于等于0.30g");
              break;
          case "3106":
              $('#txtShockSeismicAccelerationParameter').val("大于等于0.40g");
              break;
      }

      for (i = 1; i < 16; i++) {
          if ($("#ParticipantName" + i).val() == "") {
              $("#IDNumber" + i).attr('disabled', true);
          }
      }
      //重置附件顺序
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

      //页面跳转（保存）
      function onSave(PartCode, Tip) {
          var selectPrize1 = $("#CollaborativePhase01").multipleSelect("getSelects").toString();
          var selectPrize2 = $("#CollaborativePhase02").multipleSelect("getSelects").toString();
          var selectPrize3 = $("#CollaborativePhase03").multipleSelect("getSelects").toString();
          var selectPrize4 = $("#CollaborativePhase04").multipleSelect("getSelects").toString();

          $("#CollaborativePhase1").val(selectPrize1);
          $("#CollaborativePhase2").val(selectPrize2);
          $("#CollaborativePhase3").val(selectPrize3);
          $("#CollaborativePhase4").val(selectPrize4);

          // 富文本框取值
          $("#TechnologyFeature").val(EncodeUEditorContent(UE.getEditor('TechnologyFeatureTextBox').getContent()));      // 工程概况、说明设计特点、技术经济指标
          $("#Awards").val(EncodeUEditorContent(UE.getEditor('AwardsTextBox').getContent()));
          //$("#UnitOpinion").val(EncodeUEditorContent(UE.getEditor('UnitOpinionTextBox').getContent()));
          $("#RecommendOpinion").val(EncodeUEditorContent(UE.getEditor('RecommendOpinionTextBox').getContent()));
          if (!checkUEditor('TechnologyFeatureTextBox')
                          || !checkUEditor('AwardsTextBox')
             //|| !checkUEditor('UnitOpinionTextBox')
             || !checkUEditor('RecommendOpinionTextBox')
                ) {
              return false;
          }

          var result = [];
          $("[data='" + PartCode + "']").not("span").each(function () {
              if ($(this).attr("id") != null) {
                  result.push({ Name: $(this).attr("id"), Value: $(this).val() });
              }
          });
          $.ajax({
              type: "post",
              url: "../Mutual/Declaration.ashx",
              data: {
                  "Action": "Save",
                  "PartCode": PartCode,
                  "DeclarationID": $("#txtdeclID").val(),
                  "PageData": result
              },
              success: function (data, status) {
                  if (data == "success" && Tip == 'Save') {
                      ShowMessag("已保存");
                  }
              },
              error: function (data) {
                  ShowMessag("保存失败, 请重新保存！");
              },
          });
          //刷新分工表
          //$.ajax({
          //    type: "post",
          //    url: "../Mutual/Declaration.ashx",
          //    data: {
          //        "Action": "FreshDivision",
          //        "DeclarationID": $("#txtDeclarationID").val(),
          //    },
          //    success: function (data, status) {
          //        if (data != "[]") {
          //            data = JSON.parse(data);
          //            if (data[0]) {
          //                $("#txtDeclarationUnit2").val(data[0]["Data"]);
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase2_0" + i).val("×");
          //                }
          //                $("#CollaborativePhase2_10").val("×");
          //                $("#CollaborativePhase2_11").val("×");
          //            }
          //            if (data[2]) {
          //                var strs = new Array();
          //                if (data[2]["Data"] != null) {
          //                    strs = data[2]["Data"].split(",");
          //                    for (i = 0; i < strs.length; i++) {
          //                        var ee = strs[i].substring(2, 4);
          //                        $("#CollaborativePhase2_" + ee).val("√");
          //                    }
          //                }
          //            }
          //            if (data[3]) {
          //                $("#txtDeclarationUnit3").val(data[3]["Data"]);
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase3_0" + i).val("×");
          //                }
          //                $("#CollaborativePhase3_10").val("×");
          //                $("#CollaborativePhase3_11").val("×");
          //            }
          //            else {
          //                $("#txtDeclarationUnit3").val("");
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase3_0" + i).val("");
          //                }
          //                $("#CollaborativePhase3_10").val("");
          //                $("#CollaborativePhase3_11").val("");
          //            }
          //            if (data[5]) {
          //                var strs = new Array();
          //                if (data[5]["Data"] != null) {
          //                    strs = data[5]["Data"].split(",");
          //                    for (i = 0; i < strs.length; i++) {
          //                        var ee = strs[i].substring(2, 4);
          //                        $("#CollaborativePhase3_" + ee).val("√");
          //                    }
          //                }
          //            }
          //            if (data[6]) {
          //                $("#txtDeclarationUnit4").val(data[6]["Data"]);
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase4_0" + i).val("×");
          //                }
          //                $("#CollaborativePhase4_10").val("×");
          //                $("#CollaborativePhase4_11").val("×");
          //            }
          //            else {
          //                $("#txtDeclarationUnit4").val("");
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase4_0" + i).val("");
          //                }
          //                $("#CollaborativePhase4_10").val("");
          //                $("#CollaborativePhase4_11").val("");
          //            }
          //            if (data[8]) {
          //                var strs = new Array();
          //                if (data[8]["Data"] != null) {
          //                    strs = data[8]["Data"].split(",");
          //                    for (i = 0; i < strs.length; i++) {
          //                        var ee = strs[i].substring(2, 4);
          //                        $("#CollaborativePhase4_" + ee).val("√");
          //                    }
          //                }
          //            }
          //            if (data[9]) {
          //                $("#txtDeclarationUnit5").val(data[9]["Data"]);
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase5_0" + i).val("×");
          //                }
          //                $("#CollaborativePhase5_10").val("×");
          //                $("#CollaborativePhase5_11").val("×");
          //            }
          //            else {
          //                $("#txtDeclarationUnit5").val("");
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase5_0" + i).val("");
          //                }
          //                $("#CollaborativePhase5_10").val("");
          //                $("#CollaborativePhase5_11").val("");

          //            }
          //            if (data[11]) {
          //                var strs = new Array();
          //                if (data[11]["Data"] != null) {
          //                    strs = data[11]["Data"].split(",");
          //                    for (i = 0; i < strs.length; i++) {
          //                        var ee = strs[i].substring(2, 4);
          //                        $("#CollaborativePhase5_" + ee).val("√");
          //                    }
          //                }
          //            }
          //        }
          //    },
          //});
          SetCollaborationInfo();
      }


      $(function () {
          SetCollaborationInfo();
          notBackspace();     
          // 富文本框
          InitUEditor('TechnologyFeatureTextBox', 1000);                               // 工程概况、说明设计特点、技术经济指标
          InitUEditor('AwardsTextBox', 1000);
          //InitUEditor('UnitOpinionTextBox', 2000);
          InitUEditor('RecommendOpinionTextBox', 1000);
          //保存上个pannel编辑内容
           $("#tabfather li a[data-toggle='tab']").click(function () {
              var TabsId = getCookie('TabId');
              var n = TabsId.substr(-2, 2);
              var id = $(this).attr("id").substr(-2, 2);
              ShowTab(id);
              //ShowMessag(n);
              //if (n == "01") {
              //    //$("#Save_1101").click();
              //}
              //if (n == "02") {
              //    for (i = 1; i < 16; i++) {
              //        if ($("#ParticipantName" + i).val().length != 0 && $("#IDType" + i).find("option:selected").text() == "身份证") {
              //            if ($("#IDNumber" + i).val().length != 18) {
              //                ShowMessag("您输入的身份证号不正确！");
              //                $("#IDNumber" + i).css("border-color", "red");
              //                return false;
              //            }
              //        }
              //    }
              //    $("#Save_Participant").click();
              //}
              //else {
              //    n = parseInt(n) - 1;
              //    if (String(n).length == 1) {
              //        //$("#Save_110" + n).click();
              //    }
              //    else {
              //       // $("#Save_11" + n).click();
              //    }
              //}             
              //点击存储本次Tab的ID
              addCookie('TabId', $(this).attr("id"), 1);
              //ShowMessag($(this).attr("id"));
          })
      });
      //CollaborativePhase02CooperativeUnit1
      function Sensitize(CooperativeUnit, CollaborativePhase) {
          var i = CooperativeUnit.substr(-1);
          if ($("#" + CooperativeUnit).val().trim()!= "") {
              $("#" + CollaborativePhase).attr('disabled', false);
              $("#DeclarationList" + i + " div button").removeClass("disabled");
          }
          else {
              $("#" + CollaborativePhase).attr('disabled', true);
              $("#DeclarationList" + i + " div button span").html("");
              $("#DeclarationList" + i + " div button").addClass("disabled");
              $("#" + CollaborativePhase).multipleSelect("uncheckAll");
          }
      }

      for (d = 2; d < 5; d++) {
          if ($("#CooperativeUnit" + d).val() == "") {
              $("#CooperativeUnit" + d).attr('disabled', true);
          }
          if ($("#CollaborativePhase" + d).val() == "") {
              $("#CollaborativePhase0" + d).attr('disabled', true);
          }
      }

      if ($("#CollaborativePhase1").val() == "") {
          $("#CollaborativePhase01").attr('disabled', true);
      }


      $("#td2").click(function () {
          if ($("#DeclarationList1 div button span").html() != "") {
              $("#CooperativeUnit2").attr('disabled', false);
          }
      })
      $("#td3").click(function () {
          if ($("#DeclarationList2 div button span").html() != "") {
              $("#CooperativeUnit3").attr('disabled', false);
          }
      })
      $("#td4").click(function () {
          if ($("#DeclarationList3 div button span").html() != "") {
              $("#CooperativeUnit4").attr('disabled', false);
          }
      })

      $("#CooperativeUnit2").change(function () {
          if ($("#CooperativeUnit2").val() == "") {
              $("#CooperativeUnit2").attr('disabled', true);
          }
      })
      $("#CooperativeUnit3").change(function () {
          if ($("#CooperativeUnit3").val() == "") {
              $("#CooperativeUnit3").attr('disabled', true);
          }
      })
      $("#CooperativeUnit4").change(function () {
          if ($("#CooperativeUnit4").val() == "") {
              $("#CooperativeUnit4").attr('disabled', true);
          }
      })
    </script>
</asp:Content>
