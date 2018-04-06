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
    $("html,body").animate({ scrollTop: 0 }, 200);
}
function OPOP() {
    $("#TOPP").click();
}

//页面跳转（上一步）
function onPrev(Page) {

    Page = parseInt(Page) - 1;
    $("#tab_" + preZeroFill(Page, 2)).click();
    $("html,body").animate({ scrollTop: 0 }, 200);
}

function ShowTab(strPage) {
    $(".tab-pane").hide();
    var iPage = parseInt(strPage);
    $("#btab" + iPage).show();
};

$(function () {
    $('#tabfather li a').attr('href', '');
    $("#tabfather li a[data-toggle='tab']").click(function () {
        var id = $(this).attr("id").substr(-2, 2);
        ShowTab(id)
    });
    //tabdrop初始化
    $('.nav-pills, .nav-tabs').tabdrop();
    //设置当前页面nav
    var currentcolumn = JSON.parse($.cookie('currentPage'))
    if (currentcolumn!=null) {
        $("#nav01").text(currentcolumn.column1 + ' > ')
        $("#nav02").text(currentcolumn.column2 + ' > ')
        $("#nav02").attr("href", currentcolumn.column2Link)
    } else {
        $("#nav01").text("")
        $("#nav02").text("")
        $("#nav02").attr("href", "")
        $("#nav03").text("")
    }
    
  
    
    //隐藏提交按钮
    $("#btnSubmit").hide()
})
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
        if (arr[0] == name) return arr[1];
    }
    return "";
}

//设置#nav03,#PrizeName5
function setNav3(DeclarationName,PrizeName) {
    $("#nav03").text(DeclarationName)
    $("#PrizeName5").text(PrizeName)
}

// 替换字符串
function Replace(str, reallyDo, replaceWith) {
    var e = new RegExp(reallyDo, "g");
    words = str.replace(e, replaceWith);
    return words;
};

// HTML编码
function EncodeUEditorContent(UEditorContent) {
    //var result = Replace(UEditorContent, '<', '&lt;');
    //result = Replace(result, '>', '&gt;');
    //result = Replace(result, '"', '&quot;');
    //result = Replace(result, "'", '&rsquo;');
    //result = Replace(result, "/", "&frasl;");

    return UEditorContent;
}

// HTML解码
function DecodeUEditorContent(UEditorContent) {
    //var result = Replace(UEditorContent, '&lt;', '<');
    //result = Replace(result, '&gt;', '>');
    //result = Replace(result, '&quot;', '"');
    //result = Replace(result, '&rsquo;', "'");
    //result = Replace(result, "&frasl;", "/");
    //result = Replace(result, "&nbsp;", " ");

    return UEditorContent;
}





