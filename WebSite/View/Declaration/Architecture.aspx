<%@ Page Title="项目管理" Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="Architecture.aspx.cs" Inherits="Evaluation.View.Declaration.Architecture" validateRequest="false"%>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/Participant.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/Appendix.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStates.ascx" %>
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
        #StructuralFeaturesTextBox{
            text-align:left;margin-left:10px;width:97%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <ul class="navs">
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=060000" id="nav02" runat="server" ClientIDMode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
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
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、申报内容</a></li>            
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、附件目录</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、法人声明</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、合作声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab" class="ExpertReviewList2" style="display: none;">7、评审意见</a></li>
        </ul>

        <div class="tab-content active" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_0601" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 130px;">项目报优名称
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="DeclarationName" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureDeclarationName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>立项名称
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="ApprovalName" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureApprovalName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">申报单位<br />
                                （主申报）
                            </td>
                            <td style="width: 120px;">申报单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="96.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureDeclarationUnit" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>通讯地址
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="96.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitecturePostalAddress" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>联 系 人
                            </td>
                            <td style="width: 30%">
                                <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureLinkman" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>手    机
                            </td>
                            <td>
                                <asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureMobileNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>电    话
                            </td>
                            <td>
                                <asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureTelephoneNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitecturePostcode" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>传    真
                            </td>
                            <td>
                                <asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureFaxNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureEmailAddress" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                            <td>建设单位
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="DevelopmentOrganization" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureDevelopmentOrganization" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>施工单位
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="ConstructionOrganization" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureConstructionOrganization" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>使用单位
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="UseUnit" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureUseUnit" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="ConstructionLocation" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureConstructionLocation" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">建筑功能<br />
                                （使用性质）
                            </td>
                            <td>地上
                            </td>
                            <td>
                                <asp:TextBox ID="UseProperty_Overground" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureUseProperty_Overground" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td style="width: 120px;">用地性质
                            </td>
                            <td>
                                <asp:TextBox ID="LandNature" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureLandNature" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>地下
                            </td>
                            <td>
                                <asp:TextBox ID="UseProperty_Underground" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureUseProperty_Underground" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>设计使用年限
                            </td>
                            <td>
                                <asp:TextBox ID="DesignServiceLife" runat="server" ClientIDMode="Static" Width="81%"></asp:TextBox>  年
                        <asp:CheckBox ID="IsArchitectureDesignServiceLife" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>总建筑面积
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="OverallFloorage" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                m<sup>2</sup>
                                <asp:CheckBox ID="IsArchitectureOverallFloorage" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />

                            </td>
                            <td>用地面积
                            </td>
                            <td>
                                <asp:TextBox ID="TotalLandArea" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureTotalLandArea" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建筑高度
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="BuildingHeight" runat="server" ClientIDMode="Static" Width="89%"></asp:TextBox>  m
                        <asp:CheckBox ID="IsArchitectureBuildingHeight" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />

                            </td>
                            <td>建筑层数
                            </td>
                            <td>
                                <asp:TextBox ID="LayerCount" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureLayerCount" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计类别
                            </td>
                            <td colspan="2">
                                <div class="DeclarationList">
                                    <asp:DropDownList runat="server" ID="DesignCategory" ClientIDMode="Static"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display:none">
                                    <asp:TextBox ID="txtDesignCategory" runat="server" Width="90%" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsArchitectureDesignCategory" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>设计起止时间
                            </td>
                            <td style="margin-left:2.5%;">
                                <div class="datepicker input-group date" >
                                    <asp:TextBox ID="DesignStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计起始日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                              
                                <div class="datepicker input-group date" >
                                    <asp:TextBox ID="DesignEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计终止日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsArchitectureDesignEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>开工时间
                            </td>
                            <td colspan="2">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="ConstructionStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择开工日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsArchitectureConstructionStartDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>竣工时间
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="ConstructionEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsArchitectureConstructionEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>竣工验收时间
                            </td>
                            <td colspan="2">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="AcceptanceDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工验收日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsArchitectureAcceptanceDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>竣工验收部门
                            </td>
                            <td>
                                <asp:TextBox ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="65%"></asp:TextBox>
                                <asp:CheckBox ID="IsArchitectureAcceptanceDepartment" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>消防备案时间
                            </td>
                            <td colspan="2">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="FireControlRecordDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择消防备案日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsArchitectureFireControlRecordDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>交付使用时间
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="DeliveryDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择交付使用日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsArchitectureDeliveryDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>专业类别</td>
                            <td colspan="4">
                                <div class="DeclarationList">
                                    <asp:DropDownList runat="server" ID="ProfessionalCategories" ClientIDMode="Static"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtProfessionalCategories" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsMunicipalProfessionalCategories" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0601')" id="Save_0601">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0601','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" ID="ucParticipant"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_0602" runat="server" ClientIDMode="Static" GroupingText="技术申报内容">
                    <table>
                        <tr>
                            <td colspan="3">结构体系</td>
                            <td colspan="3">
                                <asp:TextBox ID="StructuralSystem" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureStructuralSystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td style="width: 130px;">抗震设防烈度</td>
                            <td style="width: 140px;">
                                <asp:TextBox ID="SeismicFortificationIntensity" runat="server" Width="61%"></asp:TextBox> 度
                        <asp:CheckBox runat="server" ID="IsArchitectureSeismicFortificationIntensity" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">抗震设防类别</td>
                            <td colspan="3">
                                <asp:TextBox ID="SeismicFortificationCategory" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureSeismicFortificationCategory" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>基本地震加速度</td>
                            <td>
                                <asp:TextBox ID="BasicSeismicAcceleration" runat="server" Width="61%"></asp:TextBox> &nbsp;g
                        <asp:CheckBox runat="server" ID="IsArchitectureBasicSeismicAcceleration" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">设计地震分组</td>
                            <td colspan="3">
                                <asp:TextBox ID="EarthquakeGrouping" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureEarthquakeGrouping" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>建筑场地土类别</td>
                            <td>
                                <asp:TextBox ID="ConstructionSiteSoilType" runat="server" Width="61%"></asp:TextBox> 类
                        <asp:CheckBox runat="server" ID="IsArchitectureConstructionSiteSoilType" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">基础类型</td>
                            <td colspan="3">
                                <asp:TextBox ID="BaseType" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseType" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>结构安全等级</td>
                            <td>
                                <asp:TextBox ID="StructuralSafetyLevel" runat="server" Width="61%"></asp:TextBox> 级
                        <asp:CheckBox runat="server" ID="IsArchitectureStructuralSafetyLevel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">混凝土总用量（砖混结构可不填写此栏及后三栏）</td>
                            <td colspan="3">
                                <asp:TextBox ID="ConcreteAmount" runat="server" Width="86%"></asp:TextBox> m³
                        <asp:CheckBox runat="server" ID="IsArchitectureConcreteAmount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>每平方米混凝土折算厚度</td>
                            <td>
                                <asp:TextBox ID="PerSqM_ConcreteReducedThickness" runat="server" Width="55%"></asp:TextBox> cm/㎡
                        <asp:CheckBox runat="server" ID="IsArchitecturePerSqM_ConcreteReducedThickness" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" colspan="3">钢材总用量</td>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">钢筋:
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="SteelAmount_rebar" runat="server" Style="width: 86%"></asp:TextBox> t
                                   <asp:CheckBox runat="server" ID="IsArchitectureSteelAmount_rebar" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">每平方米<br />
                                钢材用量</td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 42px;">钢筋:
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="PerSqM_SteelAmount_rebar" runat="server" Width="43%"></asp:TextBox> kg/㎡
                                    <asp:CheckBox runat="server" ID="IsArchitecturePerSqM_SteelAmount_rebar" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">型钢:
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="SteelAmount_SectionSteel" runat="server" Style="width: 86%"></asp:TextBox> t
                                     <asp:CheckBox runat="server" ID="IsArchitectureSteelAmount_SectionSteel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 42px;">型钢:
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="PerSqM_SteelAmount_SectionSteel" runat="server" Width="43%"></asp:TextBox> kg/㎡
                                   <asp:CheckBox runat="server" ID="IsArchitecturePerSqM_SteelAmount_SectionSteel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="21" style="width: 100px;">抗震分析主要结果</td>
                            <td colspan="5" style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="border-right: none;">程序名称：
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="ModeProgramName" runat="server" Width="90.5%"></asp:TextBox>
                                            <asp:CheckBox runat="server" ID="IsArchitectureModeProgramName" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>是否考虑扭转耦联</td>
                            <td>
                                <asp:TextBox ID="IsConsiderCoupling" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureIsConsiderCoupling" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                                <asp:TextBox ID="VibrationModeCycle1" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeCycle1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle1" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeAngle1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient1" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTranslationalCoefficient1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TorsionCoefficient1" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTorsionCoefficient1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_X" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_Y" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle2" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeCycle2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle2" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeAngle2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient2" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTranslationalCoefficient2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TorsionCoefficient2" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTorsionCoefficient2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>X向基底剪重比</td>
                            <td>Y向基底剪重比</td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle3" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeCycle3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle3" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeAngle3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient3" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTranslationalCoefficient3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TorsionCoefficient3" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTorsionCoefficient3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BasalShearRatio_X" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBasalShearRatio_X" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BasalShearRatio_Y" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBasalShearRatio_Y" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle4" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeCycle4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle4" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeAngle4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient4" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTranslationalCoefficient4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TorsionCoefficient4" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTorsionCoefficient4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>X向最小剪重比（层号）</td>
                            <td>Y向最小剪重比（层号）</td>
                        </tr>
                        <tr>
                            <td>5</td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle5" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeCycle5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle5" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeAngle5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient5" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTranslationalCoefficient5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TorsionCoefficient5" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTorsionCoefficient5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MinShearWeightRatio_X" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMinShearWeightRatio_X" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MinShearWeightRatio_Y" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMinShearWeightRatio_Y" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>6</td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle6" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeCycle6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle6" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeAngle6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient6" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTranslationalCoefficient6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TorsionCoefficient6" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTorsionCoefficient6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>X向最大层间位移角</td>
                            <td>Y向最大层间位移角</td>
                        </tr>
                        <tr>
                            <td>7</td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle7" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeCycle7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle7" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeAngle7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient7" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTranslationalCoefficient7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TorsionCoefficient7" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTorsionCoefficient7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_X" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_X" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_Y" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>8</td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle8" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeCycle8" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle8" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeAngle8" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient8" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTranslationalCoefficient8" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TorsionCoefficient8" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTorsionCoefficient8" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>X向最大位移比（层号）</td>
                            <td>Y向最大位移比（层号）</td>
                        </tr>
                        <tr>
                            <td>9</td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle9" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeCycle9" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle9" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureVibrationModeAngle9" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient9" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTranslationalCoefficient9" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TorsionCoefficient9" runat="server" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTorsionCoefficient9" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxDisplacementRatio_X" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxDisplacementRatio_X" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxDisplacementRatio_Y" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxDisplacementRatio_Y" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                                <asp:TextBox ID="TimeHistoryAnalysisName1" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTimeHistoryAnalysisName1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X1" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_X1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MaxStoreyDriftAngle_X1" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_X1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y1" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_Y1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y1" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_Y1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">2</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName2" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTimeHistoryAnalysisName2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X2" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_X2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MaxStoreyDriftAngle_X2" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_X2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y2" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_Y2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y2" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_Y2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">3</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName3" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTimeHistoryAnalysisName3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X3" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_X3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MaxStoreyDriftAngle_X3" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_X3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y3" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_Y3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y3" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_Y3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">4</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName4" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTimeHistoryAnalysisName4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X4" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_X4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MaxStoreyDriftAngle_X4" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_X4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y4" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_Y4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y4" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_Y4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">5</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName5" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTimeHistoryAnalysisName5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X5" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_X5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MaxStoreyDriftAngle_X5" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_X5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y5" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_Y5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y5" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_Y5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">6</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName6" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTimeHistoryAnalysisName6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X6" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_X6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MaxStoreyDriftAngle_X6" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_X6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y6" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_Y6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y6" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_Y6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">7</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName7" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureTimeHistoryAnalysisName7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X7" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_X7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MaxStoreyDriftAngle_X7" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_X7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y7" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_Y7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y7" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_Y7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">各波平均值(当选3条波时为包络值)</td>
                            <td>
                                <asp:TextBox ID="BaseShear_X_Avg" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_X_Avg" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MaxStoreyDriftAngle_X_Avg" runat="server" Width="77%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_X_Avg" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y_Avg" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureBaseShear_Y_Avg" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y_Avg" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsArchitectureMaxStoreyDriftAngle_Y_Avg" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8" style="text-align:left;padding-left:10px;">
                                结构专业设计主要特点：（限400～600字）（重点介绍技术的难点、创新点及先进性。）
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8">
                                <asp:TextBox ID="StructuralFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="StructuralFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsArchitectureStructuralFeatures" ClientIDMode="Static" ToolTip="公开" Checked="true" />                                
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0602')" id="Save_0602">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0602','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab4">
                <uc:Appendix runat="server" ID="Appendix"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab5">
              <uc:LegalStates runat="server" id="ucLegalStates"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab6">
              <uc:Certificate runat="server" id="ucCertificate"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab7">
              <uc:Comments runat="server" id="ucComments"></uc:Comments>
            </div> 
        </div>
    </div>
     
         
  <script type="text/javascript">
      $('#ProfessionalCategories').ui_choose();
      for (i = 1; i < 16; i++) {
          if ($("#ParticipantName" + i).val() == "") {
              $("#IDNumber" + i).attr('disabled', true);
          }
      }
      //重置附件顺序
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
          $("#StructuralFeatures").val(EncodeUEditorContent(UE.getEditor('StructuralFeaturesTextBox').getContent()));            // 结构专业设计主要特点

          if (!checkUEditor('StructuralFeaturesTextBox')
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
          SetCollaborationInfo();
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
      }
     

      $(function () {
          SetCollaborationInfo();
          notBackspace();
          // 富文本框
          InitUEditor('StructuralFeaturesTextBox',600);              // 建筑专业设计主要特点

          //保存上个pannel编辑内容
         $("#tabfather li a[data-toggle='tab']").click(function () {
              var TabsId = getCookie('TabId');
              var n = TabsId.substr(-2, 2);
              var id = $(this).attr("id").substr(-2, 2);
              ShowTab(id);
              //ShowMessag(n);
              //if (n == "01") {
              //   // $("#Save_0601").click();
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
              //    //$("#Save_Participant").click();
              //}
              //else {
              //    n = parseInt(n) - 1;
              //    if (String(n).length == 1) {
              //        ///$("#Save_060" + n).click();
              //    }
              //    else {
              //        //$("#Save_06" + n).click();
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
          if ($("#" + CooperativeUnit).val().trim() != "") {
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
