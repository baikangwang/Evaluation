<%@ Page Title="奖项设置" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="PrizeSet.aspx.cs" Inherits="Evaluation.View.ActivityManage.PrizeSet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #div table {
            width: 600px;
            height: 300px;
        }       
        #Btn_Submit{margin-left:260px;width:100px;margin-top:20px;}
        ul{list-style:none;margin:0;padding:0;}
        input[type="text"] {
            width:250px;
            border: 1px solid #ccc;
            line-height:12px;
        }
        #btnCreatePrize, #btnUpdatePrize, #ContentPlaceHolder1_btnCancel {
            width: 78px;
            border-radius: 6px;
            background: #33B0BA;
            color: #fff;
            border: none;
            text-align:center;
            height:26px;         
            padding:0px!important;
            line-height:26px;
            font-size: 13px;
            margin-top:15px;
            cursor:pointer;
        }
      
        .prise input{
            height:26px;
        }
        .prise selsct {
            height: 26px;
        }

        .prezeitem {
            margin: 18px 0;
        }

        .ms-parent {
            width: 250px !important;
        }

        .texrArea {
            width: 200px;
        }

        .fontPosition {
            position: relative;
        }

        .bootstrap-switch {
            position: relative;
            top: -2px;
        }
        #multiplePrize{
            position:relative;
            left:-14px;
        }
      .ui-choose{
          margin-top:-4px!important;
      }
      .fontPosition.list{
        display:inline-block;float:left;
      }
      #ContentPlaceHolder1_lstAppendixDiscription td,#ContentPlaceHolder1_lsAtlasDiscription td, #ContentPlaceHolder1_lstMedia td{
         border:1px solid #ccc;text-align:center;
      }
        #ContentPlaceHolder1_lstAppendixDiscription, #ContentPlaceHolder1_lsAtlasDiscription, #ContentPlaceHolder1_lstMedia {
            border: 1px solid #ccc;
            width: 249px;
            float: left;       
        }
     
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">评优管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ActivityManage/PrizeList.aspx">奖项管理</a>
        </li>        
    </ul>
    <div class="container">
        <div class="row">
            <asp:HiddenField runat="server" ClientIDMode="Static" ID="hfOpenFrom" />
            <asp:HiddenField runat="server" ClientIDMode="Static" ID="hfSpecialID" />
            <div class="col-sm-12">
                <div class="prise" style="width:400px;margin:15px auto;border:1px solid #E1E1E1;padding: 4px 25px 5px 45px;border-radius:5px;">
                    <div class="prezeitem">
                        <span>所属专业：</span>
                        <asp:DropDownList ID="ddlSpecialty" CssClass="selectedDownList" runat="server" ClientIDMode="Static"></asp:DropDownList>
                    </div>
                    <div class="prezeitem">
                        <span>奖项名称：</span>
                        <asp:TextBox ID="txtPrizeName" ClientIDMode="Static" runat="server"></asp:TextBox>
                        <asp:TextBox ID="txtPrizeID" ClientIDMode="Static" runat="server"></asp:TextBox>
                        <span id="msPrizeName" class="Promptmessage" style="color:red;" hidden="hidden">*请输入奖项名称</span>
                    </div>
                    
                    <div class="prezeitem" style="display:none">
                        <span>奖项编码：</span>
                        <asp:TextBox runat="server" ID="txtPrizeCode" ClientIDMode="Static"></asp:TextBox>
                    </div>
                    <div class="prezeitem">
                        <asp:Label runat="server" Text="" Visible="false">奖项模版：</asp:Label>
                        <asp:DropDownList ID="ddlTemplateCode" ClientIDMode="Static" runat="server" Visible="false"></asp:DropDownList>
                    </div>
                    <div class="prezeitem">
                        <span>排列序号：</span>
                        <asp:TextBox ID="txtOrdinal" ClientIDMode="Static" runat="server" onkeyup="value=value.replace(/[^\d]/g,'')"></asp:TextBox>
                    </div>
                    <div class="prezeitem">
                        <span>奖项类别：</span>
                        <asp:DropDownList runat="server" ClientIDMode="Static"  CssClass="selectedDownList" ID="ddlPrizeType" >
                          <asp:ListItem>-- 请选择 --</asp:ListItem>
                        </asp:DropDownList>
                        <div>
                            <span id="msPrizeType" class="Promptmessage" style="color:red;" hidden="hidden">*请选择奖项类别</span>
                        </div> 
                    </div>
                    <div class="prezeitem" style="width: 380px;margin-left: -28px;">
                        <span>项目人员数量：</span>
                        <asp:TextBox ID="txtParticipantLimit" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </div>
                 
                    <div runat="server" id="singlePrize"  class="prezeitem" clientidmode="Static">
                        <span>奖项名额：</span>
                        <asp:TextBox ID="txtPrizeNum" ClientIDMode="Static" runat="server" onkeyup="value=value.replace(/[^\d]/g,'')"></asp:TextBox>
                        <div>
                            <span id="msPrizeNum" class="Promptmessage" style="color:red;" hidden="hidden">*请输入奖项名额</span>
                        </div> 
                    </div>

                    <div runat="server" id="multiplePrize" clientidmode="Static" style="width:367px;">
                        <div class="prezeitem">
                            <span>一等奖数量： </span>
                            <asp:TextBox ID="txtFirstPrizeNum" ClientIDMode="Static" runat="server" onkeyup="value=value.replace(/[^\d]/g,'')"></asp:TextBox>
                            <div>
                                <span id="msFirstPrizeNum" class="Promptmessage" style="color:red;" hidden="hidden">*请输入一等奖数量</span>
                            </div> 
                        </div>
                        <div class="prezeitem">
                            <span>二等奖数量： </span>
                            <asp:TextBox ID="txtSecondPrizeNum" ClientIDMode="Static" runat="server" onkeyup="value=value.replace(/[^\d]/g,'')"></asp:TextBox>
                            <div>
                                <span id="msSecondPrizeNum" class="Promptmessage" style="color:red;" hidden="hidden">*请输入二等奖数量</span>
                            </div>
                        </div>
                        <div class="prezeitem">
                            <span>三等奖数量： </span>
                            <asp:TextBox ID="txtThirdPrizeNum" ClientIDMode="Static" runat="server" onkeyup="value=value.replace(/[^\d]/g,'')"></asp:TextBox>
                            <div>
                                <span id="msThirdPrizeNum" class="Promptmessage" style="color:red;" hidden="hidden">*请输入三等奖数量</span>
                            </div>
                        </div>
                        <div style="width: 340px; margin: 0 auto;">
                            <span>投票方式： </span>
                            <asp:DropDownList runat="server" ID="ddlVoteType" ClientIDMode="Static">
                                <asp:ListItem Selected="True" Text="单轮投票" Value="2201"></asp:ListItem>
                                <asp:ListItem Selected="False" Text="两轮投票" Value="2202"></asp:ListItem>
                                <asp:ListItem Selected="False" Text="多轮投票" Value="2203"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div runat="server" id="divMultipleVoteRound" name="divMultipleVoteRound" style="margin: 20px 0;margin-left:-14px;">
                            <span>当前轮次为：</span>
                            <span style="color: red;margin-left:10px;" id="MultipleVoteRound"></span>                
                            <input type="button" id="btnPrev" class="btnt" value="返回上一轮" style="margin-right: 10px;margin-left:15px;" />
                            <input type="button" id="btnNext" class="btnt" value="开启下一轮" />
                        </div>
                    </div>
                    <div class="prezeitem" style="overflow: hidden;">
                        <span class="fontPosition list">附件列表： </span>
                        <table id="lstAppendixDiscription" runat="server" ></table>
                    </div>
                     <div class="prezeitem" style="overflow:hidden;">
                        <span class="fontPosition list">图集列表：</span>
                        <table id="lsAtlasDiscription" runat="server"></table>
                    </div>
                     <div class="prezeitem" style="overflow:hidden;">
                        <span class="fontPosition list">视频列表：</span>
                        <table id="lstMedia" runat="server"></table>
                    </div>
                    <div class="prezeitem">
                        <input id="btnCreatePrize" clientidmode="Static" class="btnt" type="button" runat="server" value="添&nbsp;&nbsp;&nbsp;加"  style="margin-left:22%;"/>
                        <input id="btnUpdatePrize" clientidmode="Static" class="btnt" type="button" runat="server" value="保&nbsp;&nbsp;&nbsp;存" style="margin-left:22%;"/>
                        <input id="btnCancel" class="btnt" runat="server" type="button" value="返&nbsp;&nbsp;&nbsp;回" onclick="back();"  style="margin-left:12px;"/>
                        <div style="display: none">
                            <asp:TextBox ID="txtSpecialtyID" ClientIDMode="Static" runat="server"></asp:TextBox>
                        </div>
                    </div>
            </div>
        </div>
        </div>
    </div>
    <script>
        $("#ddlSpecialty,#ddlPrizeType").multipleSelect({
            single: true,
            allSelected: '',
        });

        $('#ContentPlaceHolder1_lstAppendixDiscription tr td:nth-child(1),#ContentPlaceHolder1_lstMedia tr td:nth-child(1),#ContentPlaceHolder1_lsAtlasDiscription tr td:nth-child(1)').css({ 'width': '30px' });
        $('#ddlVoteType').ui_choose();

        function back() {
            window.location.href = document.referrer + "#divPrizeList";
        }

        $(function () {
            if ($('#ContentPlaceHolder1_lsAtlasDiscription').children('tbody').length == 0) {
                $('#ContentPlaceHolder1_lsAtlasDiscription').parent().hide();
            }
            if ($('#ContentPlaceHolder1_lstAppendixDiscription').children('tbody').length == 0) {
                $('#ContentPlaceHolder1_lstAppendixDiscription').parent().hide();
            }
            if ($('#ContentPlaceHolder1_lstMedia').children('tbody').length == 0) {
                $('#ContentPlaceHolder1_lstMedia').parent().hide();
            }

            DefaultValue();
            GetActivityMultipleVoteRound();
        });

        $("#txtPrizeID").hide();

        $("#ddlSpecialtyID option").each(function () {
            $(this).css("disabled", "disabled");
        });

        $("#singlePrize").hide();
        $("#multiplePrize").hide();
        $("#ddlPrizeType").change(function () {
            //奖项类别改变时，清空输入框,并根据所选类别，显示和隐藏对应的输入框
            $("#txtPrizeNum").val("");
            $("#txtThirdPrizeNum").val("");
            $("#txtSecondPrizeNum").val("");
            $("#txtFirstPrizeNum").val("");
            if ($("#ddlPrizeType").val() == "0301" || $("#ddlPrizeType").val() == "0304") {
                $("#multiplePrize").show();
                $("#singlePrize").hide();
            }
            if ($("#ddlPrizeType").val() == "0302") {
                $("#singlePrize").show();
                $("#multiplePrize").hide();
            }
            if ($("#ddlPrizeType").val() == "0303") {
                $("#singlePrize").show();
                $("#multiplePrize").hide();
            }
            if ($("#ddlPrizeType").val() == "-- 请选择 --") {
                $("#multiplePrize").hide();
                $("#singlePrize").hide();
            }
        });

        //绑定页面初值
        function DefaultValue() {
            $.ajax({
                url: "../Mutual/ActivityManage.ashx",
                type: "post",
                data: { "Action": "BindPrizeCodeAndTemplateCode", "SpecialtyID": $("#ddlSpecialty").val() },
                success: function (data) {
                    var Result = JSON.parse(data);
                    $("#txtPrizeCode").val(Result[0]);
                    //当添加时，$("#ddlTemplateCode")的值才会跟着变化
                    if ($("#ddlSpecialty").attr("disabled") != "disabled") {
                        $("#ddlTemplateCode").val(Result[1]);
                        $("#txtOrdinal").val(Result[2]);
                    }
                }
            });

            //修改时，根据下拉框显示
            if ($("#ddlPrizeType").val() == "0302" || $("#ddlPrizeType").val() == "0303") {
                $("#singlePrize").show();
            }

            if ($("#ddlPrizeType").val() == "0301" || $("#ddlPrizeType").val() == "0304") {
                $("#multiplePrize").show();
            }
        }

        $("#ddlSpecialty").change(function () {
            DefaultValue();
        });

        //添加奖项
        $("#btnCreatePrize").click(function () {
            var num = 0;
            if ($("#txtPrizeName").val() == null || $("#txtPrizeName").val() == "") {
                $("#msPrizeName").show();
                $("#msPrizeName").css({ 'display': 'block', "margin-left": '72px' });
                num++;
            } else {
                $("#msPrizeName").hide();
            }

            if ($("#ddlPrizeType").val() == null || $("#ddlPrizeType").val() == "-- 请选择 --") {
                $("#msPrizeType").show();
                $("#msPrizeType").css({ 'display': 'block', "margin-left": '72px' });
                num++;
            } else {
                $("#msPrizeType").hide();
            }

            if ($("#ddlPrizeType").val() == "0301" || $("#ddlPrizeType").val() == "0304") {
                if ($("#txtFirstPrizeNum").val() == null || $("#txtFirstPrizeNum").val() == "") {
                    $("#msFirstPrizeNum").show();
                    $("#msFirstPrizeNum").css({ 'display': 'block', "margin-left": '72px' });
                    num++;
                }
                if ($("#txtSecondPrizeNum").val() == null || $("#txtSecondPrizeNum").val() == "") {
                    $("#msSecondPrizeNum").show();
                    $("#msSecondPrizeNum").css({ 'display': 'block', "margin-left": '72px' });
                    num++;
                }
                if ($("#txtThirdPrizeNum").val() == null || $("#txtThirdPrizeNum").val() == "") {
                    $("#msThirdPrizeNum").show();
                    $("#msThirdPrizeNum").css({ 'display': 'block', "margin-left": '72px' });
                    num++;
                }
            }
            else {
                if ($("#txtPrizeNum").val() == null || $("#txtPrizeNum").val() == "") {
                    $("#msPrizeNum").show();
                    $("#msPrizeNum").css({ 'display': 'block', "margin-left": '72px' });
                    num++;
                }
            }

            if (num > 0) {
                return false;
            }

            $.ajax({
                url: "../Mutual/ActivityManage.ashx",
                type: "post",
                data: {
                    "Action": "SetPrize",
                    "SpecialtyID": $("#ddlSpecialty").val(),
                    "PrizeName": $("#txtPrizeName").val(),
                    "VoteType": $("#ddlVoteType").val(),
                    "Ordinal": $("#txtOrdinal").val(),
                    "PrizeTypeCode": $("#ddlPrizeType").val(),
                    "VoteType": $("#ddlVoteType").val(),
                    "PrizeCode": $("#txtPrizeCode").val(),
                    "TemplateCode": $("#ddlTemplateCode").val(),
                    "ParticipantLimit": $("#txtParticipantLimit").val(),
                    "PrizeLimitNum": $("#txtPrizeNum").val(),
                    "FirstPrizeLimitNum": $("#txtFirstPrizeNum").val(),
                    "SecondPrizeLimitNum": $("#txtSecondPrizeNum").val(),
                    "ThirdPrizeLimitNum": $("#txtThirdPrizeNum").val()
                },
                success: function (data) {
                    DefaultValue();
                    ShowMessag(data);
                    $('.layui-layer-btn0').on('click', function () {                  
                        if (data == "添加成功！") {
                            if ($("#hfSpecialID").val() == "") {
                                window.location = document.referrer;
                            }
                            else {
                                window.location = "../ActivityManage/SpecialtySet.aspx?sid=" + $("#hfSpecialID").val() + "&show=prize"+ "#ContentPlaceHolder1_divPrizeList";                                
                            }
                        }
                    });
                }
            });
        });

        //修改奖项
        $("#btnUpdatePrize").click(function () {
            var ddl = $("#ddlIsMultipleVoting"); //document.getElementById("ddlIsMultipleVoting")
            var MultipleVoting = ddl.val();
            $.ajax({
                url: "../Mutual/ActivityManage.ashx",
                type: "post",
                data: {
                    "Action": "SetPrize",
                    "PrizeID": $("#txtPrizeID").val(),
                    "SpecialtyID": $("#ddlSpecialty").val(),
                    "PrizeName": $("#txtPrizeName").val(),
                    "IsMultipleVoting": $("#ddlIsMultipleVoting").val(),
                    "Ordinal": $("#txtOrdinal").val(),
                    "PrizeCode": $("#txtPrizeCode").val(),
                    "PrizeTypeCode": $("#ddlPrizeType").val(),
                    "VoteType": $("#ddlVoteType").val(),
                    "TemplateCode": $("#ddlTemplateCode").val(),
                    "ParticipantLimit": $("#txtParticipantLimit").val(),
                    "PrizeLimitNum": $("#txtPrizeNum").val(),
                    "FirstPrizeLimitNum": $("#txtFirstPrizeNum").val(),
                    "SecondPrizeLimitNum": $("#txtSecondPrizeNum").val(),
                    "ThirdPrizeLimitNum": $("#txtThirdPrizeNum").val()
                },
                success: function (data) {
                    DefaultValue();
                    ShowMessag(data);
                    if (data == "修改成功！") {
                        $('.layui-layer-btn0').on('click', function () {
                            if ($("#hfSpecialID").val() == "") {
                                window.location = document.referrer;
                            }
                            else {
                                //window.location = document.referrer + "?sid=" + $("#hfSpecialID").val();
                                window.location.href = document.referrer + "#divPrizeList";
                            }
                        });
                    };
                }
            })
        })

        //获取当前综合奖多伦投票的轮次
        function GetActivityMultipleVoteRound() {
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: { "Action": "GetPrizeMultipleVoteRound", "PrizeID": $("#txtPrizeID").val() },
                success: function (data) {
                    $("#MultipleVoteRound").text(data);
                }
            });
        }

        //返回综合奖多伦投票的上一轮
        $("#btnPrev").click(function () {
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: { "Action": "StartMultipleVote", "btnValue": $("#btnPrev").val(), "PrizeID": $("#txtPrizeID").val() },
                success: function (data) {
                    GetActivityMultipleVoteRound();
                    if (data.length > 0) {
                        ShowMessag(data);
                    }
                }
            });
        });

        //开启综合奖多伦投票的下一轮
        $("#btnNext").click(function () {
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "StartMultipleVote",
                    "btnValue": $("#btnNext").val(),
                    "PrizeID": $("#txtPrizeID").val()
                },
                success: function (data) {
                    GetActivityMultipleVoteRound();
                    if (data.length > 0) {
                        ShowMessag(data);
                    }
                }
            });
        });
    </script>
</asp:Content>
