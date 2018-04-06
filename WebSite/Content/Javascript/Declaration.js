//禁用相关输入框
$("#DeclarationName").attr('disabled', "true");
$(function () {
$('table tr td').css({ 'text-align': 'center' })
$('table tr td table td').css({ 'text-align': 'center' });
$('input').parent().css({ 'text-align': 'left'})
$('input').css({ 'margin-left': '10px' })
$('.datepicker.input-group.date input').css({ 'margin-left': '' })
$('#AcceptanceDepartment').parent().css({ 'text-align': 'center' })
$('#AcceptanceDepartment').css({ 'margin-left': '' });
$(".ceng tr td").css({ 'text-align': 'center','border-right':'none' });
$(".ceng tr td input").css({ 'width': '75%' });
$('#Benefit').css({ 'margin-left': '20px' })
$('.kc').css({ 'text-align': 'center' })
$("#DivisionTable tbody> tr> td").css("text-align", "center");
$("#DivisionTable tbody> tr> td input").css('margin-left', '');
$(".control-label").parent().css({ 'text-align': 'center' });
})


//弹出框
function ShowMessag(msg) {
    layer.open({
        type: 1
      , title: '提示'
      , content: '<div style="padding:20px 10px 0 10px;;text-align:center;">' + msg + '</div>'
      , btn: '确  认'
      , btnAlign: 'c' //按钮居中
      , shade: 0 //不显示遮罩
      , yes: function () {
          layer.closeAll();
      }
    });
}

function ShowMessags(msg) {
    layer.open({
        type: 1
      , title: '提示'
      , content: '<div style="padding: 20px 10px 0 10px;;text-align:center;">' + msg + '</div>'
      , btn: ['确  定', '取  消']
      , btnAlign: 'c' //按钮居中
      , shade: 0 //不显示遮罩
      , yes: function () {
          layer.closeAll();
      }
    });
}

// 写cookies 
function addCookie(name, value, expiresHours) {
    var cookieString = name + "=" + escape(value);
    //判断是否设置过期时间 
    if (expiresHours > 0) {
        var date = new Date();
        date.setTime(date.getTime + expiresHours * 3600 * 1000);
        cookieString = cookieString + "; expires=" + date.toGMTString();
    }
    document.cookie = cookieString;
}

// 读取cookies 
function getCookie(name) {
    var strCookie = document.cookie;
    var arrCookie = strCookie.split("; ");
    for (var i = 0; i < arrCookie.length; i++) {
        var arr = arrCookie[i].split("=");
        if (arr[0] == name) {
            return arr[1];
        }
    }
    return "";
}

// 给数字字符串补零，不支持负数
function preZeroFill(num, size) {
    if (num >= Math.pow(10, size)) { //如果num本身位数不小于size位
        return num.toString();
    } else {
        var _str = Array(size + 1).join('0') + num;
        return _str.slice(_str.length - size);
    }
}

//页面跳转（下一步）
function onNext(Page) {
    Page = parseInt(Page) + 1;

    $("#tab_" + preZeroFill(Page, 2)).click();
}

function OPOP()
{
    $("#TOPP").click();
}

//页面跳转（上一步）
function onPrev(Page) {
    Page = parseInt(Page) - 1;
    $("#tab_" + preZeroFill(Page, 2)).click();
}

function ShowTab(strPage) {
    $(".tab-pane").hide();
    var iPage = parseInt(strPage);
    $("#btab" + iPage).show();
}

// 替换字符串
function Replace(str, reallyDo, replaceWith) {
    var e = new RegExp(reallyDo, "g");
    words = str.replace(e, replaceWith);
    return words;
}

// HTML编码
function EncodeUEditorContent(UEditorContent) {
    var result = Replace(UEditorContent, '<', '&lt;');
    result = Replace(result, '>', '&gt;');
    result = Replace(result, '"', '&quot;');
    result = Replace(result, "'", '&rsquo;');
    result = Replace(result, "/", "&frasl;");

    return result;
}

// HTML解码
function DecodeUEditorContent(UEditorContent) {
    var result = Replace(UEditorContent, '&lt;', '<');
    result = Replace(result, '&gt;', '>');
    result = Replace(result, '&quot;', '"');
    result = Replace(result, '&rsquo;', "'");
    result = Replace(result, "&frasl;", "/");
    result = Replace(result, "&nbsp;", " ");

    return result;
}

function SetCollaborationInfo() {
    $("#DivisionTable tr:gt(1)").empty();

    // 刷主申报单位
    var i = 0;
    var j = 0;
    var item = "<tr>";
    for (i = 0; i < 13; i++) {
        item += "<td style='text-align:center'>";
        if (i == 0) {
            item += j + 1;
        }
        else if (i == 1) {
            item += $("#DeclarationUnit").val();
        }
        else {
            item += "√";
        }
        item += "</td>";
    }
    item += "</tr>";

    $("#DivisionTable").append(item);

    //刷新分工表
    for (var j = 1; j <= 4; j++) {
        var item = "<tr>";
        for (i = 0; i < 13; i++) {
            item += "<td style='text-align:center'>";
            if (i == 0) {
                item += j + 1;
            }
            else if (i == 1) {
                item += $("#CooperativeUnit" + j).val();              
            }
            else {
                if ($("#CooperativeUnit" + j).val() == "") {
                  continue;
                }
                var str = [];
                var length = $("#DivisionTable tr:nth-child(2) td").length;
                $.each($("#DivisionTable tr:nth-child(2) td"), function (s, v) {
                    str.push($("#DivisionTable tr:nth-child(2) td").eq(s).attr('data-v'))
                })

                if ($("#CollaborativePhase0" + j).multipleSelect('getSelects').indexOf(
                    $("#DivisionTable tr:nth-child(2)").find("td:eq(" + i + ")").attr('data-v')) != -1) {
                    item += "√";
                } else {
                    item += "×";
                }
            }
            item += "</td>";
        }
        item += "</tr>";
        $("#DivisionTable").append(item);
    }
};

function SetCollaborationInfo1() {
    $("#DivisionTable3  tr:gt(1)").empty();

    // 刷主申报单位
    var i = 0;
    var j = 0;
    var item = "<tr>";
    for (i = 0; i < 7; i++) {
        item += "<td style='text-align:center'>";
        if (i == 0) {
            item += j + 1;
        }
        else if (i == 1) {
            item += $("#DeclarationUnit").val();
        }
        else {
            item += "√";
        }
        item += "</td>";
    }
    item += "</tr>";

    $("#DivisionTable3").append(item);

    //刷新分工表
    for (var j = 1; j <= 4; j++) {
        var item = "<tr>";
        for (i = 0; i < 7; i++) {
            item += "<td style='text-align:center'>";
            if (i == 0) {
                item += j + 1;
            }
            else if (i == 1) {
                item += $("#CooperativeUnit" + j).val();
            }
            else {
                if ($("#CooperativeUnit" + j).val() == "") {
                    continue;
                }
                var str = [];
                var length = $("#DivisionTable3 tr:nth-child(2) td").length;
                $.each($("#DivisionTable3 tr:nth-child(2) td"), function (s, v) {
                    str.push($("#DivisionTable3 tr:nth-child(2) td").eq(s).attr('data-v'))
                })

                if ($("#CollaborativePhase0" + j).multipleSelect('getSelects').indexOf(
                    $("#DivisionTable3 tr:nth-child(2)").find("td:eq(" + i + ")").attr('data-v')) != -1) {
                    item += "√";
                } else {
                    item += "×";
                }
            }
            item += "</td>";
        }
        item += "</tr>";
        $("#DivisionTable3").append(item);
    }
};

function SetCollaborationInfo2() {
    $("#DivisionTable2  tr:gt(0)").empty();

    // 刷主申报单位
    var i = 0;
    var j = 0;
    var item = "<tr>";
    for (i = 0; i < 3; i++) {
        item += "<td style='text-align:center'>";
        if (i == 0) {
            item += j + 1;
        }
        else if (i == 1) {
            item += $("#DeclarationUnit").val() || $("#ChiefEditorUnit").val();
        }
        else if (i == 2) {
            item += "/";
        }
        item += "</td>";
    }
    item += "</tr>";

    $("#DivisionTable2").append(item);

    //刷新分工表
    for (var j = 1; j <= 4; j++) {
        var item = "<tr>";
        for (i = 0; i < 3; i++) {
            item += "<td style='text-align:center'>";
            if (i == 0) {
                item += j + 1;
            }
            else if (i == 1) {
                item += $("#CooperativeUnit" + j).val();
            }
            else if (i == 2) {
                item += $("#UndertakeWork" + j).val();
            }
            item += "</td>";
        }
        item += "</tr>";
        $("#DivisionTable2").append(item);
    }
};

$(function () {   
    $('#tabfather li a').attr('href', '');
    function Submit() {
        var IsAllowUpdate = $("#IsAllowUpdate").val();
        if (IsAllowUpdate == "True") {
            $.ajax({
                url: '../Mutual/Declaration.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "SubmitDeclaration",
                    "DeclarationID": $("#txtdeclID").val()
                },
                success: function (data) {
                    if (data != "") {
                        data = JSON.parse(data);
                        ShowMessag(data);

                        $("[isrequired='True']").css('border-color', 'rgba(128,128,128,0.5)');                      
                            $("input[isrequired='True']").each(function () {
                                if ($(this).val() == "") {                               
                                    var id = $(this).attr('id');
                                    $("#" + id).css('border-color', '#FC7464');
                                }
                            });                      
                    }
                }
            });
        }
        else {
            ShowMessags("注意：一旦提交则不可重新编辑修改！是否确认提交？")
            $('.layui-layer-btn0').on('click', function () {
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    async: false,
                    data: {
                        "Action": "SubmitDeclaration",
                        "DeclarationID": $("#txtdeclID").val()
                    },
                    success: function (data) {
                        if (data != "") {
                            data = JSON.parse(data);
                            ShowMessag(data);
                        }
                    }
                });
            });
        }
    }

    $("#btnSubmit").click(function () {      
            Submit();        
    });
    //if (!$.cookie('IsAllowSubmit')) {
    $('input[isrequired="True"]').parent().append('<b style="color:#FC7464;position:relative;top:3px;">*</b>');
    $('textarea[isrequired="True"]').each(function () {
        if ($(this).siblings().length > 0) {
            $(this).parent().append('<b style="color:#FC7464;position:relative;bottom:200px;right:7px;float:right;">*</b>');
        } else {
            $(this).parent().append('<b style="color:#FC7464;position:relative;bottom:80px;right:7px;float:right;">*</b>');
        }
    });   
   // }

    $("input[recordtype='date']").parent().find("b").css({ 'padding-left': '5px', 'position': 'relative', 'top': '0' });
    $("input[recordtype='date']").closest("td").css('line-height', '10px');
    $('#DeclarationName').attr('disabled', true);
    $('#DeclarationUnit').attr('disabled', true);
    $('#PostalAddress').attr('disabled', true);
    $('#Linkman').attr('disabled', true);
    $('#MobileNumber').attr('disabled', true);
    $('#Postcode').attr('disabled', true);
    $('#TelephoneNumber').attr('disabled', true);
    $('#FaxNumber').attr('disabled', true);
    $('#EmailAddress').attr('disabled', true);
    $('#ChiefEditorUnit').attr('disabled', true);
    $('#StandardName').attr('disabled', true);

    $("#CollaborativePhase01").multipleSelect();
    $("#CollaborativePhase02").multipleSelect();
    $("#CollaborativePhase03").multipleSelect();
    $("#CollaborativePhase04").multipleSelect();

    $('#DomesticOrAbord1').ui_choose();
    $('#DomesticOrAbord2').ui_choose();
    $('#DomesticOrAbord3').ui_choose();
    $('#DomesticOrAbord4').ui_choose();
    $('#DesignCategory').ui_choose();
    $('#InvestSource').ui_choose();
    $('#DeclarationLevel').ui_choose();

    //设置cookie初始值
    addCookie('TabId', 'tab_01', 1);
    if ($('#CollaborativePhase1').length != 0) {

        var CollaborativePhase1 = $('#CollaborativePhase1').val().split(',');
        var CollaborativePhase2 = $('#CollaborativePhase2').val().split(',');
        var CollaborativePhase3 = $('#CollaborativePhase3').val().split(',');
        var CollaborativePhase4 = $('#CollaborativePhase4').val().split(',');

        $("#CollaborativePhase01").multipleSelect("setSelects", CollaborativePhase1);
        $("#CollaborativePhase02").multipleSelect("setSelects", CollaborativePhase2);
        $("#CollaborativePhase03").multipleSelect("setSelects", CollaborativePhase3);
        $("#CollaborativePhase04").multipleSelect("setSelects", CollaborativePhase4);

    }

    //添加全选复选框
    $('legend').each(function () {
        if ($(this).parent().parent().attr("id").indexOf("panelPart") >= 0) {
            var ck = "<input type=\"checkbox\" checked=\"checked\" style=\"float:left;\">";
            $(this).append(ck);
        }
    });

    //锚标记
    $("#ContentPlaceHolder1_divfather a").each(function () {
        $(this).attr("href", "#");
    });

    //下拉列表多选样式

    $(".Selects input").each(function () {
        $(this).css("float", "left");
        $(this).css("display", "block");
    });

    $(".Selects div ul").each(function () {
        $(this).find('input').eq(1).attr("checked", false);
        $(this).find('li').eq(1).css("display", "none");
    })

    $(".ms-select-all  label span").each(function () {
        $(this).html("全选");
    });

    //日期控件
    $(".datepicker").datepicker({
        language: "zh-CN",
        autoclose: true,
        todayHighlight: true,
        format: "yyyy-mm-dd"
    });

    $('.datepicker.input-group.date').css('width', '70%')
    //tabdrop初始化
    $('.nav-pills, .nav-tabs').tabdrop();
    var user = $("#txtUser").val();
    var Grade = $("#txtGrade").val();

    if ($('#txtSituation').val() == "Declara") {
        $('#nav01').html("项目申报");
        $('#nav03').html($("#DeclarationName").val());
    }

    if ($('#txtSituation').val() == "Declaration") {
        $('#nav01').html("项目管理");
        $('#nav02').html("项目管理");
        $('#nav02').attr('href', '../Declaration/DeclarationList.aspx')
        $('#nav03').html($("#DeclarationName").val());
        if ($("#StandardName")) {
            $('#nav03').html($("#StandardName").val());
        }
    }
    // 根据场景改变控件样式
    if ($('#txtSituation').val() == "ExpertReview" || $('#txtSituation').val() == "Delete" || $('#txtSituation').val() == "Auditing") {
        //日期插件里小图的样式
        $(".input-group-addon").css("display", "none");

        //// textBox的样式
        $(":text").css("border", "none");
        $(":text").css("background", "#EEEEEE");
        $(":text").attr('disabled', "true");
        $(":text").css("color", "black");

        //textarea的样式
        $("textarea").css("border", "none");
        $("textarea").css("background", "#EEEEEE");
        $("textarea").attr('disabled', "true");
        $("textarea").css("color", "black");
        if (user == "0805") {
            $(".CommentsDis").attr('disabled', false);
            $(".CommentsDis").css("border", "1px solid black");
            $(".CommentsDis").css("background", "white");
        }
        //合作单位样式
        $(".DeclarationList").css("display", "none");
        $(".ExpertReviewList").css("display", "block");

        if (Grade == "Open") {
            $(".ExpertReviewList2").css("display", "block");
            $("#CertificateNext").css("display", "");
        }
        for (i = 1; i < 5; i++) {
            if ($('#CooperativeUnit' + i).val() == "") {
                $('#txtDomesticOrAbord' + i).val("");
            }
            else {
                if ($('#DomesticOrAbord' + i).val() == "1901") {
                    $('#txtDomesticOrAbord' + i).val("国内");
                }
                else {
                    $('#txtDomesticOrAbord' + i).val("国外");
                }
            }
        }

        $("#txtCollaborativePhase1").val($("#CollaborativePhase01").multipleSelect("getSelects", "text").toString());
        $("#txtCollaborativePhase2").val($("#CollaborativePhase02").multipleSelect("getSelects", "text").toString());
        $("#txtCollaborativePhase3").val($("#CollaborativePhase03").multipleSelect("getSelects", "text").toString());
        $("#txtCollaborativePhase4").val($("#CollaborativePhase04").multipleSelect("getSelects", "text").toString());

        // 设计类别样式 ProjectSource
        switch ($('#DesignCategory').val()) {
            case "1401":
                $('#txtDesignCategory').val("新建");
                break;
            case "1402":
                $('#txtDesignCategory').val("改建");
                break;
            case "1403":
                $('#txtDesignCategory').val("扩建");
                break;
            case "1404":
                $('#txtDesignCategory').val("修缮");
                break;
        }

        //资金来源样式
        switch ($('#InvestSource').val()) {
            case "1501":
                $('#txtInvestSource').val("计划");
                break;
            case "1502":
                $('#txtInvestSource').val("自筹");
                break;
            case "1503":
                $('#txtInvestSource').val("贷款");
                break;
            case "1504":
                $('#txtInvestSource').val("合资");
                break;
            case "1505":
                $('#txtInvestSource').val("外资");
                break;
        }

        //参与人员样式
        for (i = 1; i < 16; i++) {
            if ($("#ParticipantName" + i).val() != "") {
                $("#txtIDType" + i).val($("#IDType" + i).find("option:selected").text());
            }
        }

        //nav 样式


        if ($('#txtSituation').val() == "Delete") {
            $('#nav01').html("项目管理");
            $('#nav02').html("已删除项目");
            $('#nav02').attr('href', '../Declaration/DeclarationDeleted.aspx')
            $('#nav03').html($("#DeclarationName").val());
        }
        if ($('#txtSituation').val() == "Auditing") {
            $('#nav01').html("评优管理");
            $('#nav02').html("项目审核");
            $('#nav02').attr('href', '../ActivityManage/DeclarationAuditing.aspx')
            $('#nav03').html($("#DeclarationName").val());
        }
        else {
            $('#nav01').html("项目管理");
            $('#nav02').html("项目管理");
            $('#nav02').attr('href', '../Declaration/DeclarationList.aspx')
            $('#nav03').html($("#DeclarationName").val());
        }
        if (user == "0805") {
            $('#nav01').html("专家评选");
            $('#nav02').html("专家评审");
            $('#nav02').attr('href', '../ExpertElect/ExpertReview.aspx')
            $('#nav03').html($("#DeclarationName").val());
        }


        //尾页样式
        $("#btnSubmit").css("display", "none");
        $("#btnSubmitBack").css("display", "none");
        $("#btnSubmit").css("display", "none");

    }
});

function notBackspace() {
    var keyCode, target; document.onkeydown = keydown; function keydown(e) {
        e = e || window.event; keyCode = e.keyCode ||
        e.which, target = e.srcElement || e.target;
        //只有当前对象为text、textarea、password并且只是可读状态时才禁用返回键 
        if (keyCode === 8 && (target.type === "text" || target.type === "textarea" ||
        target.type === "password") && target.readOnly === true)
        { keyCode = 0; e.returnValue = false; return false; }
    }
}
// 初始化富文本框
function InitUEditor(container, max) {
    var text = $("#" + container.replace("TextBox", ""));
    text.hide();

    var ue = UE.getEditor(container, {
        allHtmlEnabled: true,
        retainOnlyLabelPasted: true,
        pasteplain:true,
        tableDragable: false,
        ignoreBlank: true,
        autoHeightEnabled: false,
        allowDivTransToP: false,
        maximumWords: max,
        toolbars: [[
                'source', '|',
                'undo', 'redo', '|',
                'bold', 'italic', 'underline', 'strikethrough', 'removeformat', '|',
                'forecolor', 'backcolor', '|',
                'cleardoc', '|',
                'paragraph', 'fontfamily', 'fontsize', '|',
                'indent', '|',
                'justifyleft', 'justifycenter', 'justifyright', 'justifyjustify', '|'
        ]]
    });

    if (text.val() != "") {
        ue.ready(function () {
            //设置编辑器的内容
            ue.setContent(DecodeUEditorContent(text.val()), false);
        });
    }

    ue.addListener('blur', function () {
        checkUEditor(container);
    });

    ue.addListener('beforepaste', function (o, html) {
        // 粘贴的特殊处理
    });

    //text.addListener('blur', function () {
    //    if (text.text.length > max) {
    //        ShowMessag("字数超出限制！");
    //        text.focus();
    //    }
    //});
}

function checkUEditor(container) {
    var editor = UE.getEditor(container);
 
    if (editor.getContentLength(true, editor.options.ignoreBlank) > editor.options.maximumWords) {
        ShowMessag("字数超出限制！");        
        //editor.focus(false);      
        return false;
    }

    return true;
}
