<%@ Page Title="项目申报表" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="Declaration.aspx.cs" Inherits="Evaluation.View.Declaration.Declaration" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        * {
            margin: 0px;
        }

        #form1 {
            margin: 0px auto;
        }

            #form1 li {
                list-style: none;
            }

        #head, #bkjz {
            text-align: center;
        }

        #txtDeclarateDate {
            width: 150px;
        }

        #head {
            font-size: 30px;
        }
        #rdlPrize tbody tr td input {
            text-align: left;
            margin-right: 4px;
        }

        #rdlPrize {
            margin-top: 20px;
            font-weight: 400;
        }

            #rdlPrize tbody label {
                font-weight: normal !important;
            }

        #center {
            font-size: 26px;
        }

        #font {
            font-size: 20px;
            margin-top: 100px;
        }

        #bkjz {
            font-size: 18px;
        }

        #next {
            text-align: center;
            margin-top: 30px;
        }

        #txtProjectName, #ContentPlaceHolder1_txtDeclarateDate {
            border-top-style: none;
            border-right-style: none;
            border-left-style: none;
            border-bottom: 1px solid #CDCDCD;
            background: #EEEEEE;
            width: 100%;
        }

        label, input, button, select, textarea {
            font-size: 15px !important;
        }

        #ContentPlaceHolder1_rdlPrize {
            margin-top: 13px;
        }

        #ddlSpecialty {
            margin: 0 10px 0 0;
        }
    </style>
    <%--<!--专业树插件-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/metisMenu/metisMenu.css" />
    <script type="text/javascript" src="../../Content/plugins/metisMenu/metisMenu.js"></script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <asp:HiddenField runat="server" ID="hdDeclarationID" ClientIDMode="Static" />
    <div style="display: none">
        <asp:TextBox ID="txtSituation" runat="server" ClientIDMode="Static"></asp:TextBox>
    </div>
    <div style="padding-top: 20px;">
        <div id="head">
            <asp:Literal ID="litTitle" runat="server" Text="北京市优秀建筑工程设计项目申报表"></asp:Literal>
        </div>
        <div id="center">

            <table style="margin: 30px auto 20px 35%;" id="tbInformation" runat="server" ClientIDMode="Static" >
                <tr>
                    <td style="width: 100px;">
                        <label id="lblSpecil" runat="server">申报专业：</label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlSpecialty" ClientIDMode="Static" Width="150px"></asp:DropDownList>
                    </td>
                    <td style="padding-left:10px;">
                        <asp:DropDownList runat="server" ID="ddlChildSpecialty" ClientIDMode="Static" Width="150px"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label style="margin-top: 20px;">申报奖项：</label></td>
                    <td colspan="2">
                        <div class="DeclarationList">
                            <asp:RadioButtonList runat="server" ID="rdlPrize" ClientIDMode="Static" name='approve'></asp:RadioButtonList></div>
                        <div class="ExpertReviewList" style="display: none; margin-top: 15px">
                            <asp:Literal runat="server" ID="litrdlPrize" ClientIDMode="Static"></asp:Literal></div>
                    </td>
                </tr>
                <tr id="ImportData" runat="server" ClientIDMode="Static">
                    <td>
                        <label style="margin-top: 20px;">导入数据：</label></td>
                    <td colspan="2">
                        <div class="DeclarationList" style="margin-top: 20px;">
                        <asp:DropDownList runat="server" ID="ImportDeclarationData" ClientIDMode="Static" name='approve' ></asp:DropDownList></div>
                    </td>
                </tr>
                <tr id="RecommendationAssociation" runat="server" ClientIDMode="Static">
                    <td style="width: 27%;">
                        <label style="margin-top: 20px;">推荐协会：</label></td>
                    <td colspan="2">
                        <div class="DeclarationList" style="margin-top: 20px;">
                            <asp:DropDownList runat="server" ID="ChooseAssociation" ClientIDMode="Static" name='approve' ></asp:DropDownList></div>
                        <div class="ExpertReviewList" style="display: none;margin-top: 20px;">
                            <asp:Literal runat="server" ID="litChooseAssociation" ClientIDMode="Static"></asp:Literal>
                        </div>
                    </td>
                </tr>
            </table>
            <div id="font">
                <table style="margin: 0 auto 0 35%; width: 320px">
                    <tr>
                        <td style="width: 30%;height:40px;">
                            <label>项目名称：</label>
                        </td>
                        <td>
                            <div class="DeclarationList">
                                <asp:TextBox runat="server" ID="txtProjectName" ClientIDMode="Static" placeholder="请输入项目名称" Style="width: 90%; margin-left: -5px"></asp:TextBox></div>
                            <div class="ExpertReviewList" style="display: none; margin-bottom: 3px;">
                                <asp:Literal runat="server" ID="litProjectName" ClientIDMode="Static"></asp:Literal></div>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 30%;">
                            <label>申报单位：</label>
                        </td>
                        <td>
                            <asp:Literal runat="server" ID="txtOrganizationName" ClientIDMode="Static"></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 30%;">
                            <label>填报日期：</label>
                        </td>
                        <td>
                            <div class="DeclarationList">
                                <div class="datepicker input-group date" style="width: 70%; margin-left: -3px;">
                                    <asp:TextBox ID="txtDeclarateDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择申报日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                            </div>
                            <div class="ExpertReviewList" style="display: none;">
                                <asp:Literal runat="server" ID="litDeclarateDate" ClientIDMode="Static"></asp:Literal>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <div style="width: 200px; height: 100px; margin: 20px auto 0 auto; text-align: center;">
                    <br />
                    <br />
                    <asp:Button runat="server" ID="btnNext" Text="下 一 步" OnClick="btnNext_Click" class="btnt" Style="margin-right:10px;" ClientIDMode="Static"></asp:Button>
                    <input type="button" name="name" class="btnt" value="返　回" onclick="history.go(-1)"/>
                    <br />
                    <br />
                    <br />
                    <br/>
                    <span id="bkjz">协会监制</span>
                </div>
            </div>
        </div>
    </div>
    <%--</form>--%>
    <script>
        $("#ddlSpecialty,#ddlChildSpecialty,#ImportDeclarationData,#ChooseAssociation").multipleSelect({
            allSelected: '',
            single: true
        });
        document.onkeydown = function (event_e) {
            if (window.event)
                event_e = window.event;
            var int_keycode = event_e.charCode || event_e.keyCode;
            if (int_keycode == 13) {
                return false;
            }
        }

       function ToDBC(txtstring) {
            //var tmp = "";
            //for (var i = 0; i < txtstring.length; i++) {
            //    if (txtstring.charCodeAt(i) == 32) {
            //        tmp = tmp + String.fromCharCode(12288);
            //    }
            //    if (txtstring.charCodeAt(i) < 127) {
            //        tmp = tmp + String.fromCharCode(txtstring.charCodeAt(i) + 65248);
            //    }
            //}
            return txtstring;
       }
        //function ToDBC(str){
         //      var result = "";
         //      var len = str.length;
         //      for(var i=0;i<len;i++)
         //{
          //     var cCode = str.charCodeAt(i);
             //全角与半角相差（除空格外）：65248(十进制)
         //     cCode = (cCode>=0x0021 && cCode<=0x007E)?(cCode + 65248) : cCode;
            //处理空格
          //  cCode = (cCode==0x0020)?0x03000:cCode;
          //  result += String.fromCharCode(cCode);
        // }
        // return result;
       //  };
        function UserAddVerify() {
            if ($("#txtProjectName").val() == "") {
                ShowMessag("请填写项目名称");
                return false;
            }
            else {
                var flag = true;
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    async: false,
                    data: {
                        "Action": "GetError",
                        "DeclarationID": $("#hdDeclarationID").val(),
                        "PrizeID": $("input[name='ctl00$ContentPlaceHolder1$rdlPrize']:checked").val(),
                        "PrizeID2": $("input[name='rdlPrize']:checked").val(),
                        "DeclarationName": ToDBC($("#txtProjectName").val()),
                        "DeclarationStatus": $("#txtSituation").val()
                    },
                    success: function (data) {
                        if (data != "") {
                            data = JSON.parse(data);
                            ShowMessag(data);
                            flag = false;
                        }
                    },
                    error: function (e) {
                        ShowMessag(e);
                        flag = true;
                    }
                });
                if (flag) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        //根据场景设置控件样式
        if ($("#txtSituation").val() == "ExpertReview" || $("#txtSituation").val() == "Delete" || $("#txtSituation").val() == "Auditing") {
            $(".DeclarationList").css("display", "none");
            $(".ExpertReviewList").css("display", "block");
        }

        //日期控件
        $(".datepicker").datepicker({
            language: "zh-CN",
            autoclose: true,
            todayHighlight: true,
            format: "yyyy-mm-dd"
        });

        //奖项联动
        $(document).ready(function () {
            var msg = $("#hdMsg").val();
            if (msg != '') {
                ShowMessag(msg);
                if (msg == '该专业下暂无奖项，无法申报!') {
                    $('.layui-layer-btn0').on('click', function () {
                        window.location = "../Mutual/HomePage.aspx"
                    });
                }
            }

            //给下拉框注册事件  
            $("#ddlSpecialty").change(function () {
                if ($(this).val() != "") {
                    //Value不为空的情况接着判断  
                    if (!$("#ddlSpecialty").data($(this).val())) {
                        $.ajax({
                            url: '../Mutual/Declaration.ashx',
                            type: "post",
                            async: false,
                            data: { "Action": "GetChildList", "SpecialtyID": $(this).val() },
                            success: function (data) {
                                if (data != "") {
                                    data = JSON.parse(data);
                                    if (data[0] == "Specialty") {
                                        $("#ddlChildSpecialty").empty();
                                        for (var i = 0; i < data[1].length; i++) {
                                            $("<option value='" + data[1][i].SpecialtyID + "'>" + data[1][i].SpecialtyName + "</option>").appendTo($("#ddlChildSpecialty"));
                                        }
                                        $("#ddlChildSpecialty").val(data[1][0].SpecialtyID);
                                        bindPrize(data[1][0].SpecialtyID);
                                        $("#ddlChildSpecialty").next().children().click();
                                        $("#ddlChildSpecialty").show();
                                        $("#rdlPrize").hide();
                                        //
                                        $("#ImportData").hide();
                                    }
                                    else {
                                        $("#rdlPrize").empty(data[1]);
                                        $("<tbody></tbody").appendTo($("#rdlPrize"));
                                        for (var i = 0; i < data[1].length; i++) {
                                            $("<tr><td><input type='radio' id='rdlPrize_" + i + "' name='rdlPrize' value='" + data[1][i].PrizeID + "'><lable for='rdlPrize_" + i + "'>" + data[1][i].PrizeName + "</lable></td></tr>").appendTo($("#rdlPrize"));
                                        }
                                        $("#rdlPrize").val(data[1][0].PrizeID);
                                        $("#ddlChildSpecialty").hide();
                                        $("#rdlPrize").show();
                                        //
                                        $("#ImportData").hide();
                                    }
                                }
                            }
                        });
                    }
                }
            });

            function bindPrize(SpecialtyID) {
                //ShowMessag(SpecialtyID);
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    async: true,
                    data: { "Action": "GetChildList", "SpecialtyID": SpecialtyID },
                    success: function (data) {
                        if (data != "") {
                            data = JSON.parse(data);
                            if (data[0] == "Prize") {
                                //ShowMessag(1);
                                $("#rdlPrize").empty(data[1]);
                                $("<tbody></tbody").appendTo($("#rdlPrize"));
                                for (var i = 0; i < data[1].length; i++) {
                                    $("<tr><td><input type='radio' id='rdlPrize_" + i + "' name='rdlPrize' value='" + data[1][i].PrizeID + "'><lable for='rdlPrize_" + i + "'>" + data[1][i].PrizeName + "</lable></td></tr>").appendTo($("#rdlPrize"));
                                }
                                $("#rdlPrize").val(data[1][0].PrizeID);
                                //$("#ddlChildSpecialty").hide();
                                $("#rdlPrize").show();
                            }
                        }
                    }
                });
            }

            $("#ddlChildSpecialty").change(function () {
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    async: false,
                    data: { "Action": "GetChildList", "SpecialtyID": $(this).val() },
                    success: function (data) {
                        if (data != "") {
                            data = JSON.parse(data);
                            if (data[0] == "Prize") {
                                $("#rdlPrize").empty(data[1]);
                                $("<tbody></tbody").appendTo($("#rdlPrize"));
                                for (var i = 0; i < data[1].length; i++) {
                                    $("<tr><td><input type='radio' id='rdlPrize_" + i + "' name='rdlPrize' value='" + data[1][i].PrizeID + "'><lable for='rdlPrize_" + i + "'>" + data[1][i].PrizeName + "</lable></td></tr>").appendTo($("#rdlPrize"));
                                }
                                $("#rdlPrize").val(data[1][0].PrizeID);
                                //$("#ddlChildSpecialty").hide();
                                $("#rdlPrize").show();
                            }
                        }
                    }
                });
            });
        });

        $("#rdlPrize input[name='ctl00$ContentPlaceHolder1$rdlPrize']").click(function () {
            var PrizeID = $("#rdlPrize input[name='ctl00$ContentPlaceHolder1$rdlPrize']:checked").val();
            $.ajax({
                url: '../Mutual/Declaration.ashx',
                type: "post",
                async: false,
                data: { "Action": "GetImportDeclaration", "PrizeID": PrizeID },
                success: function (data) {
                    if (data != "") {
                        data = JSON.parse(data);
                        if (data[0] == "lstDeclaration") {
                            console.log(data);
                            $("#ImportDeclarationData").empty();
                            $("<option value='0'>< --不导入-- ></option>").appendTo($("#ImportDeclarationData"));
                            for (var i = 0; i < data[1].length; i++) {
                                $("<option value='" + data[1][i].DeclarationID + "'>" + data[1][i].DeclarationName + "</option>").appendTo($("#ImportDeclarationData"));
                            }
                        }
                    }
                }
            });
        })
        $("#rdlPrize").click(function () {            
            var PrizeID = $("#rdlPrize input[name='rdlPrize']:checked").val();
            if (PrizeID)
            {
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    async: false,
                    data: { "Action": "GetImportDeclaration", "PrizeID": PrizeID },
                    success: function (data) {
                        if (data != "") {
                            data = JSON.parse(data);
                            console.log(data);
                            if (data == "1") {
                                $("#ImportDeclarationData").empty();
                                $("#ImportData").hide();
                            }
                            else if (data[0] == "lstDeclaration") {
                                console.log(data);
                                $("#ImportDeclarationData").empty();
                                $("<option value='0'>< --不导入-- ></option>").appendTo($("#ImportDeclarationData"));
                                for (var i = 0; i < data[1].length; i++) {
                                    $("<option value='" + data[1][i].DeclarationID + "'>" + data[1][i].DeclarationName + "</option>").appendTo($("#ImportDeclarationData"));
                                }
                                $("#ImportData").show();
                            }
                        }
                    }
                });                
            }

        })
    </script>
</asp:Content>
