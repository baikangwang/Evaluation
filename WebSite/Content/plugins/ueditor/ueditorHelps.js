
function isFocus(e,id) {
    alert(UE.getEditor(id).isFocus());
    UE.dom.domUtils.preventDefault(e);
}

function setblur(e, id) {
    UE.getEditor(id).blur();
    UE.dom.domUtils.preventDefault(e)
}
function insertHtml(id) {
    var value = prompt('插入html代码', '');
    UE.getEditor(id).execCommand('insertHtml', value)
}
function createEditor(id) {
    enableBtn();
    UE.getEditor(id);
}
function getAllHtml(id) {
    alert(UE.getEditor(id).getAllHtml())
}
function getContent(id) {
    var arr = [];
    //arr.push("使用editor.getContent()方法可以获得编辑器的内容");
    //arr.push("内容为：");
    arr.push(UE.getEditor(id).getContent());
    arr.join("\n");
}
function getPlainTxt(id) {
    var arr = [];
    arr.push("使用editor.getPlainTxt()方法可以获得编辑器的带格式的纯文本内容");
    arr.push("内容为：");
    arr.push(UE.getEditor(id).getPlainTxt());
    alert(arr.join('\n'))
}
function setContent(isAppendTo,id) {
    var arr = [];
    arr.push("使用editor.setContent('欢迎使用ueditor')方法可以设置编辑器的内容");
    UE.getEditor(id).setContent('欢迎使用ueditor', isAppendTo);
    alert(arr.join("\n"));
}
function setDisabled(id) {
    UE.getEditor(id).setDisabled('fullscreen');
    disableBtn(id);
}

function setEnabled(id) {
    UE.getEditor(id).setEnabled();
    enableBtn();
}

function getText(id) {
    //当你点击按钮时编辑区域已经失去了焦点，如果直接用getText将不会得到内容，所以要在选回来，然后取得内容
    var range = UE.getEditor(id).selection.getRange();
    range.select();
    var txt = UE.getEditor(id).selection.getText();
    alert(txt)
}

function getContentTxt(id) {
    var arr = [];
    //arr.push("使用editor.getContentTxt()方法可以获得编辑器的纯文本内容");
    //arr.push("编辑器的纯文本内容为：");
    arr.push(UE.getEditor(id).getContentTxt());
    var s = document.getElementById('ConstructionFeatures');
    s.push = arr;
    alert(s);
    console.log(s);
}
function hasContent(id) {
    var arr = [];
    arr.push("使用editor.hasContents()方法判断编辑器里是否有内容");
    arr.push("判断结果为：");
    arr.push(UE.getEditor(id).hasContents());
    alert(arr.join("\n"));
}

function setFocus(id) {
    UE.getEditor(id).focus();
}
function deleteEditor(id) {
    disableBtn();
    UE.getEditor(id).destroy();
}
function disableBtn(str) {
    var div = document.getElementById('btns');
    var btns = UE.dom.domUtils.getElementsByTagName(div, "button");
    for (var i = 0, btn; btn = btns[i++];) {
        if (btn.id == str) {
            UE.dom.domUtils.removeAttributes(btn, ["disabled"]);
        } else {
            btn.setAttribute("disabled", "true");
        }
    }
}
function enableBtn() {
    var div = document.getElementById('btns');
    var btns = UE.dom.domUtils.getElementsByTagName(div, "button");
    for (var i = 0, btn; btn = btns[i++];) {
        UE.dom.domUtils.removeAttributes(btn, ["disabled"]);
    }
}

function getLocalData(id) {
    alert(UE.getEditor(id).execCommand("getlocaldata"));
}

function clearLocalData(id) {
    UE.getEditor(id).execCommand("clearlocaldata");
    alert("已清空草稿箱")
}