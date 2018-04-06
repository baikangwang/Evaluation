<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="TraditionalBuildingReview.aspx.cs" Inherits="Evaluation.View.Declaration.TraditionalBuildingReveiw" ValidateRequest="false" %>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/ParticipantReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/AppendixReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStatesreview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/Certificatereview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
        #divFather{
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
        .file-caption-main {
            width: 80% !important;
        }

        .form-control {
            border-top-left-radius: 4px;
            border-bottom-left-radius: 4px;
        }

        .file-caption-name {
            height: 16px!important;
        }

        .hidden-xs {
            display: inline !important;
        }

        .btn.btn-primary.btn-file {
            border-top-right-radius: 4px;
            border-bottom-right-radius: 4px;
        }
       
        #tbReview{
            position:relative;
        }
        a:hover{
            cursor:pointer;
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
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a>
            <a href="../Declaration/Declare.aspx?SepcCode=030000" id="nav02"></a>
            <a href="#" id="nav03"></a>
        </li>
    </ul>
      <div style="display: none">
        <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox>
    </div>
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

        <div class="tab-content" id="divFather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0301" GroupingText="项目基本情况" class="panelPart">
                    <table>
                        <tr>
                            <td style="width: 150px;">项目名称</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationName" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位</td>
                            <td style="padding: 0;">
                                <table class="shejidanwei">
                                    <tr>
                                        <td style="border-top: none;">单位名称</td>
                                        <td colspan="4" style="border-top: none; border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationUnit" Width="96.5%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>通讯地址</td>
                                        <td colspan="4" style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="PostalAddress" Width="96.5%"></asp:Label>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>联系人</td>
                                        <td>
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Linkman" Width="91.5%"></asp:Label>
                                        </td>
                                        <td>电话</td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="TelephoneNumber" Width="91.5%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>手机</td>
                                        <td>
                                            <asp:Label runat="server" ClientIDMode="Static" ID="MobileNumber" Width="91.5%"></asp:Label>
                                        </td>
                                        <td>传真</td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="FaxNumber" Width="91.5%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>邮政编码</td>
                                        <td>
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Postcode" Width="91.5%"></asp:Label>
                                        </td>
                                        <td>电子邮箱</td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="EmailAddress" Width="91.5%"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
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
                            <td>业主单位</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="OwnerUnit" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>施工单位</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionOrganization" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>项目地点</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionLocation" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>设计类别</td>
                            <td>
                                <div class="DeclarationList">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DesignCategory"></asp:Label>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="txtDesignCategory" Width="90%"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>设计开始时间
                            </td>
                            <td style="padding: 0">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 39%">
                                            <div>
                                                <asp:Label runat="server" ClientIDMode="Static" ID="DesignStartDate"></asp:Label>
                                            </div>
                                        </td>
                                        <td>设计终止时间
                                        </td>
                                        <td style="width: 41%; border-right: none;">
                                            <div style="margin: 0px auto">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="DesignEndDate"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>竣工时间
                            </td>
                            <td style="padding: 0">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 39%;">
                                            <div style="margin: 0px auto">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionEndDate"></asp:Label>
                                            </div>
                                        </td>
                                        <td>验收时间　
                                        </td>
                                        <td style="width: 41%; border-right: none;">
                                            <div style="margin:0 auto">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="AcceptanceDate"></asp:Label>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>交付使用时间
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 39%;">
                                            <div style="margin: 0px auto">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="DeliveryDate"></asp:Label>
                                            </div>
                                        </td>
                                        <td>验收部门　
                                        </td>
                                        <td style="width: 41%; border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="AcceptanceDepartment" Width="68%"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>资金来源
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 40%; border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="InvestSource"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="padding: 0; display: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationLevel"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
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
                <uc:Participant runat="server" ID="ParticipantReview"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0302">
                    <h2 style="text-align: center; font-weight: bold">技术申报内容</h2>
                    <table style="margin-top: 30px">
                        <tr>
                            <td style="text-align: center; padding-left: 10px; ">设计主要特点：（限制在800-1500字)</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="TechnicalDeclarationContent" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;">
                                </asp:TextBox>
                                <script id="TechnicalDeclarationContentTextBox" type="text/plain" style="height: 300px;"></script>
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
                <uc:LegalStates runat="server" ID="LegalStatesreview"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab6">
                <uc:Certificate runat="server" ID="Certificatereview"></uc:Certificate>
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
            //$('#TechnicalDeclarationContent').html($('#TechnicalDeclarationContent').text()); 
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
            $("#Divisiontable").empty();       
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
        //附件目录
        //function setPart8Data(data) {
        //    var EnclosureData = JSON.parse(data)[3];
        //    console.log(EnclosureData)
        //    var ImageData = JSON.parse(data)[4];
        //    console.log(ImageData)
        //    //附件
        //    if (EnclosureData.length > 0) {
        //        $("#Enclosurelist").empty()
        //        for (var i = 0; i < EnclosureData.length; i++) {
        //            var index = i + 1;
        //            if (EnclosureData[i].URL) {
        //                var oUrl = "../../" + EnclosureData[i].URL.replace(/\\/g, "/")
        //            } else {
        //                var oUrl = ""

        //            }
        //            if (EnclosureData[i].FileName) {
        //                var fileName = EnclosureData[i].FileName
        //                var oIcon = "<i class='fa fa-download'></i>"

        //            } else {
        //                var fileName = "---"
        //                var oIcon = ""
        //            }
        //            var item = "<tr>" +
        //                  "<td>" + index + "</td>" +
        //                  "<td>" + fileName + "</td>" +
        //                  "<td>" +
        //                  "<a href= '" + oUrl + "' download=" + fileName + ">" + fileName + "</a>" +
        //                  "<a href='" + oUrl + "' download=" + fileName + ">" + oIcon + "</a>" +
        //                  "</td>" +
        //                  "<tr>"

        //            $("#Enclosurelist").append(item);

        //        }
        //    } else {
        //        $("#Appendix").hide();
        //        $("#AppendixTable").append("<div style='border:1px solid #777; text-align:center;width:90%;padding:5px'>该专业下暂无附件集目录！</div>")
        //    }

        //    //图集
        //    if (ImageData.length > 0) {
        //        $("#Imagelist").empty()
        //        var orderNum = 0;
        //        for (var i = 0; i < ImageData.length; i++) {

        //            var CorrelationID = ImageData[i].CorrelationID ? "Correlation" + ImageData[i].CorrelationID : "CorrelationID_" + i;
        //            var element = $("#" + CorrelationID)
        //            if (ImageData[i].URL) {
        //                var oUrl = "<br/><img src='../../" + ImageData[i].URL.replace(/\\/g, "/") + "' width='150px'/><br/>" +
        //                "<span>" + ImageData[i].FileName + "</span>" +
        //                "<a href='../../" + ImageData[i].URL.replace(/\\/g, "/") + "' download=" + ImageData[i].FileName + "><i class='fa fa-download'></i></a>"
        //            } else {
        //                var oUrl = "--"

        //            }
        //            if (element && element.length >= 1) {
        //                $("#" + CorrelationID).append(item);
        //            } else {
        //                orderNum = orderNum + 1;
        //                var item = "<tr>" +
        //                    "<td>" + orderNum + "</td>" +
        //                    "<td>" + ImageData[i].CorrelationName + "</td>" +
        //                    "<td id=" + CorrelationID + ">" + oUrl + "</td>" +
        //                "<tr>"
        //                $("#Imagelist").append(item);

        //            }
        //        }
        //    } else {
        //        $("#Atlas").hide();
        //        $("#AtlasTable").append("<div style='border:1px solid #777; text-align:center;width:90%;padding:5px'>该专业下暂无图集目录！</div>")
        //    }

        //}
        
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
                    setNav3(DeclarationName, PrizeName);
                    setData(data);
                    setPart2Data(data);
                    setPart5Data(data);
                    setPart6Data(data);
                    setPart8Data(data)
                }
            });

            InitUEditor('TechnicalDeclarationContentTextBox', 1500);              // 设计主要特点
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

