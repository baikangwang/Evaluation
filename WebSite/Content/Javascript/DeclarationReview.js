function preZeroFill(num, size) {
    if (num >= Math.pow(10, size)) { //���num����λ����С��sizeλ
        return num.toString();
    } else {
        var _str = Array(size + 1).join('0') + num;
        return _str.slice(_str.length - size);
    }
}

//ҳ����ת����һ����
function onNext(Page) {
    Page = parseInt(Page) + 1;

    $("#tab_" + preZeroFill(Page, 2)).click();
    $("html,body").animate({ scrollTop: 0 }, 200);
}
function OPOP() {
    $("#TOPP").click();
}

//ҳ����ת����һ����
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
    //tabdrop��ʼ��
    $('.nav-pills, .nav-tabs').tabdrop();
    //���õ�ǰҳ��nav
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
    
  
    
    //�����ύ��ť
    $("#btnSubmit").hide()
})
// дcookies 
function addCookie(name, value, expiresHours) {
   
    var cookieString = name + "=" + escape(value);
    //�ж��Ƿ����ù���ʱ�� 
    if (expiresHours > 0) {
        var date = new Date();
        date.setTime(date.getTime + expiresHours * 3600 * 1000);
        cookieString = cookieString + "; expires=" + date.toGMTString();
    }
    document.cookie = cookieString;
}

// ��ȡcookies 
function getCookie(name) {
    var strCookie = document.cookie;
    var arrCookie = strCookie.split("; ");
    for (var i = 0; i < arrCookie.length; i++) {
        var arr = arrCookie[i].split("=");
        if (arr[0] == name) return arr[1];
    }
    return "";
}

//����#nav03,#PrizeName5
function setNav3(DeclarationName,PrizeName) {
    $("#nav03").text(DeclarationName)
    $("#PrizeName5").text(PrizeName)
}

// �滻�ַ���
function Replace(str, reallyDo, replaceWith) {
    var e = new RegExp(reallyDo, "g");
    words = str.replace(e, replaceWith);
    return words;
};

// HTML����
function EncodeUEditorContent(UEditorContent) {
    //var result = Replace(UEditorContent, '<', '&lt;');
    //result = Replace(result, '>', '&gt;');
    //result = Replace(result, '"', '&quot;');
    //result = Replace(result, "'", '&rsquo;');
    //result = Replace(result, "/", "&frasl;");

    return UEditorContent;
}

// HTML����
function DecodeUEditorContent(UEditorContent) {
    //var result = Replace(UEditorContent, '&lt;', '<');
    //result = Replace(result, '&gt;', '>');
    //result = Replace(result, '&quot;', '"');
    //result = Replace(result, '&rsquo;', "'");
    //result = Replace(result, "&frasl;", "/");
    //result = Replace(result, "&nbsp;", " ");

    return UEditorContent;
}





