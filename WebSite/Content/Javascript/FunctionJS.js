
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

// 采用正则表达式获取地址栏参数
function GetQueryString(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
    var r = window.location.search.substr(1).match(reg);
    if (r != null) return unescape(r[2]); return null;
}

