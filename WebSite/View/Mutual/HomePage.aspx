<%@ Page  Language="C#" AutoEventWireup="true"  MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="HomePage.aspx.cs" Inherits="Evaluation.View.Mutual.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"> 
    <style>
        
        table {
            width: 100%;
        }
         .container{
            padding-right:0;
        }
        .widget.box .widget-content.left {
            padding: 21px 15px 21px 15px;
        }
         .widget.box .widget-content.left .user div{
            line-height: 21px;
            width: 100%;
            background:#F5FAFA;
            border:1px solid #BDDEFC;
            border-radius:3px;
            color: #99CCFF;
            margin-bottom:15px;
        }
           .widget.box .widget-content.left .user .last-child{
           margin-bottom:0;
        }
          .widget.box .widget-content.left .user div span:first-child{
           padding-left:10px;
        }

       .btn-group .btn:hover{
           background:inherit;
           color:inherit
       }

        .page-title > h3 {
            font-family: "微软雅黑";
        }

        .row-bg {
            background-color: #eeeeee;
            border-top: 0;
            border-bottom: 0;
            margin: 0 -20px !important;
            margin-bottom: 0 !important;
            padding-left: 5px;
            padding-right: 5px;
            padding-top: 25px;
        }

        .statbox .visual.cyan {
            background-color: #cc99cc;
        }

        .statbox .visual.blue {
            background-color: #99ccff;
        }

        .statbox .visual.red {
            background-color: #66cccc;
        }

        tbody td {
            position: relative;
        }

        tbody .hidden-xs div {
            position: absolute;
            top: 12px;
            left: 22px;
        }

        .progress {
            height: 6px;
            border-radius: 30px;
            overflow: initial;
          
           
        }
        .table tbody>tr>td.schedule{
            padding-right:45px;
        }
            .progress .progress-bar {
                position: relative;
                border-radius: 30px;
            }

        .triangle {
            width: 0;
            height: 0;
            border-left: 4px solid transparent;
            border-right: 4px solid transparent;
            position: absolute;
            top: -7px;
            right: -4px;
        }

        .progress-bar span {
            position: absolute;
            top: -7px;
            left:137px;
            color: #000000;
            font-size:13px;
        }

      

        .table tbody > tr > td {
            border: 0;vertical-align: middle;
            text-align: center;
           
        }

        .table thead > tr > th {
            border-bottom: 0;
        }
       
        .table tr:nth-child(1) {
            background: none;
        }

      
        .row-bg {
            padding-top: 0;
        
            box-shadow: 0 0 0;
        }
        .widget-header a{
            font-size:12px;
            float:right; color:#555;opacity:0.7;
            display:block;margin-right:30px;
        }
      
        .widget-header a:hover{
           opacity:1;text-decoration:none;color:#555;background:none;
       }
    
        h4{
            font-family:"微软雅黑"
        }
  
        .echarts-dataview button{
            border-radius: 6px;
            background: #33B0BA;
            color: #fff;
            border: none;
            padding: 6px 13px;
            font-size: 13px;
        }
        .echarts-dataview textarea{
            border:1px solid;
        }
        a:hover{
            background-color:transparent;
            color:inherit;
        }
        #ContentPlaceHolder1_tbNotice a{
            text-overflow:ellipsis;
            overflow:hidden;
            white-space:nowrap;
            width:238px;
            padding:0;
            display:block;
            margin:0 auto;
        }
        .notice{
            height:178px;
            overflow-y:hidden;
        }
        #tbNotice th{          
                                
            background:#85E1E1;
            padding:2px 18px;

        }
        #ContentPlaceHolder1_tbNotice td {
            padding:2px 8px;
        }

       #content{
           padding-top:95px!important;
       }

    </style>
  </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <asp:HiddenField runat="server" ID="hdUserid" ClientIDMode="Static" />
    <div class="container" style="min-width:300px">        
        <div class="row row-bg">
            <div class="col-sm-6 col-md-3">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual cyan">
                            <i class="fa fa-user"></i>
                        </div>
                        <div class="title">本周新增申报</div>
                        <div class="value"><asp:Literal runat="server" ID="litNewDeclaration"></asp:Literal></div>
                        <a class="more" id="more1" href="../Declaration/DeclarationList.aspx?From=Home&Type=New">查看更多<i class="pull-right fa fa-angle-right"></i></a>
                    </div>
                </div>
            </div>
            <div class="col-sm-6 col-md-3">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual blue">
                            <i class="fa fa-user-md"></i>
                        </div>
                        <div class="title">本周提交申报</div>
                        <div class="value"><asp:Literal runat="server" ID="litCompleteDeclaration"></asp:Literal></div>
                        <a class="more" id="more2" href="../Declaration/DeclarationList.aspx?From=Home&Type=Submit">查看更多<i class="pull-right fa fa-angle-right"></i></a>
                    </div>
                </div>
            </div>
            <div class="col-sm-6 col-md-3 hidden-xs">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual yellow">
                            <i class="fa fa-mortar-board"></i>
                        </div>
                        <div class="title">专家总数</div>
                        <div class="value"><asp:Literal runat="server" ID="litExpertCount"></asp:Literal></div>
                        <a class="more" id="more3" href="#">查看更多<i class="pull-right fa fa-angle-right"></i></a>
                    </div>
                </div>
            </div>
            <div class="col-sm-6 col-md-3 hidden-xs">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual red">
                            <i class="fa fa-envelope"></i>
                        </div>
                        <div class="title">总申报项目数</div>
                        <div class="value"><asp:Literal runat="server" ID="litDeclarationCount"></asp:Literal></div>
                        <a class="more" id="more4" href="#">查看更多<i class="pull-right fa fa-angle-right"></i></a>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="widget box">
                    <div class="widget-header">
                        <h4><i class="fa fa-reorder"></i>用户信息</h4>
                        <div class="toolbar no-padding">
                            <div class="btn-group">
                                <span class="btn btn-xs widget-collapse"><i class="fa fa-angle-down"></i></span>
                            </div>
                        </div>
                    </div>
                    <div class="widget-content left">
                    
                        <div class="user">
                            <div>
                                 <span>用户名 :</span>
                                 <span><asp:Literal runat="server" ID="litUserName"></asp:Literal></span>
                            </div>

                            <div>
                                <span>用户邮箱 :</span>
                                 <span><asp:Literal runat="server" ID="litEmail"></asp:Literal></span>
                            </div>
                            <div>
                                <span>用户类别 :</span>
                                 <span><asp:Literal runat="server" ID="litUserType"></asp:Literal></span>
                            </div>
                            <div class="last-child">
                                <span>最后登录时间 :</span>
                                 <span><asp:Literal runat="server" ID="litLastLoginTime"></asp:Literal></span>
                            </div>
                        </div>                               
                        </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="widget box">
                    <div class="widget-header">

                        <h4><i class="fa fa-reorder"></i>最新公告信息</h4>
                        
                        <div class="toolbar no-padding">
                            <div class="btn-group">
                                <span class="btn btn-xs widget-collapse">
                                    <i class="fa fa-angle-down"></i>
                                </span>
                            </div>
                        </div>
                        <a href="../ActivityManage/NoticeList.aspx">查看更多</a>
                    </div>
                    <div class="widget-content no-padding notice">                
                    <table id="tbNotice" runat="server" class="table table-striped table-checkable table-hover">
                        <thead>
                            <tr>
                                <th class="hidden-xs " style="vertical-align: middle;background-color:#85E1E1" >公告标题</th>
                                <th class="align-center" style="vertical-align: middle;background-color:#85E1E1">发布时间</th>
                                <th class="align-center"  style="background-color:#85E1E1">点击数</th>
                            </tr>
                        </thead>                     
                    </table>
                </div>
                </div>
            </div>
        </div>
        <div class="row row-3">
            <div class="col-md-6">
                <div class="widget box">
                    <div class="widget-header ">
                        <h4><i class="fa fa-reorder"></i>本周新增项目柱状图</h4>
                        <div class="toolbar no-padding">
                            <div class="btn-group">
                                <span class="btn btn-xs widget-collapse">
                                    <i class="fa fa-angle-down"></i>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="widget-content">
                        <div id="chart_simple" style="height: 219px;">
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="widget box">
                    <div class="widget-header">
                        <h4><i class="fa fa-reorder"></i>各专业收件封存项目分布图</h4>
                        <div class="toolbar no-padding">
                            <div class="btn-group">
                                <span class="btn btn-xs widget-collapse">
                                    <i class="fa fa-angle-down"></i>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="widget-content">
                        <div id="chart_pie" style="height: 219px;">
                            <script type="text/javascript">
                                 //基于准备好的dom，初始化echarts图表
                                var doc = document,
                                ele = doc.documentElement,
                                bodys = doc.bodys,
                                clientWidth = ele ? ele.clientWidth : bodys.clientWidth,
                                clientHeight = ele ? ele.clientHeight : bodys.clientHeight;
                                window.onresize = function (e) {
                                    bindpie();
                                    bindbar();
                                }
                                $(function () {
                                    bindbar();
                                    bindpie();
                                });
                               
                                function bindbar(queryData) {
                                    var myChart = echarts.init(document.getElementById('chart_simple'));
                                    option = {
                                        title: {
                                            x: 'center',
                                            text: '本周各专业新增申报项目数',
                                        },
                                        tooltip: {
                                            trigger: 'axis'
                                        },
                                        toolbox: {
                                            show: true,
                                            feature: {
                                                dataView: { show: true, readOnly: false },
                                                restore: { show: true },
                                                saveAsImage: { show: true },
                                            }
                                        },
                                        calculable: true,
                                        grid: {
                                            borderWidth: 0,
                                            x: '5%',
                                            x2: '5%',
                                            y: '15%',
                                            y2: '5%'
                                        },
                                        xAxis: [
                                            {
                                                type: 'category',
                                                show: false,
                                                data: []
                                            }
                                        ],
                                        yAxis: [
                                            {
                                                type: 'value',
                                                show: false
                                            }
                                        ],
                                        series: [
                                            {
                                                name: '数量',
                                                type: 'bar',
                                                itemStyle: {
                                                    normal: {
                                                        color: function (params) {
                                                            var colorList = [
                                                              '#C1232B', '#B5C334', '#FCCE10', '#E87C25', '#27727B',
                                                               '#FE8463', '#9BCA63', '#FAD860', '#F3A43B', '#60C0DD',
                                                               '#D7504B', '#C6E579', '#F4E001', '#F0805A', '#26C0C0',
                                                               '#A15202', '#333333'
                                                            ];
                                                            return colorList[params.dataIndex]
                                                        },
                                                        label: {
                                                            show: true,
                                                            position: 'top',
                                                            formatter: '{c}'
                                                        }
                                                    }
                                                },
                                                data: []
                                            }
                                        ]
                                    };
                                    $.ajax({
                                        url: '../Mutual/Common.ashx',
                                        type: "post",
                                        async: false,
                                        data: { "Action": "GetBar" },
                                        success: function (data) {
                                            var data = JSON.parse(data)
                                            if (data != "当前没有激活的活动！") {
                                                option.series[0].data = data[1];
                                                option.xAxis[0].data = data[0];
                                            }
                                            myChart.setOption(option);
                                        }
                                    });
                                }
                                function bindpie(queryData) {
                                    var myChart = echarts.init(document.getElementById('chart_pie'));
                                    option = {
                                        toolbox: {
                                            show: true,
                                            feature: {
                                                dataView: { show: true, readOnly: false },
                                                restore: { show: true },
                                                saveAsImage: { show: true },
                                            }
                                        },
                                        legend: {
                                            orient: 'vertical',
                                            x: 'left',
                                            y: 'bottom',
                                            padding: 4,
                                            itemGap: 4,
                                            data: []
                                        },
                                        tooltip: {
                                            trigger: 'item',
                                            formatter: "{b}<br/>{c} ({d}%)"
                                        },
                                        //这个是启动拖拽特性
                                        calculable: true,
                                        series: [
                                            {
                                                name: '访问来源',
                                                type: 'pie',
                                                radius: 90,
                                                center: ['70%', '50%'],
                                                itemStyle: {
                                                    normal: {
                                                        //提示性文字
                                                        label: {
                                                            show: false
                                                        },
                                                        //上面提示性文字的提示性线条
                                                        labelLine: {
                                                            show: false
                                                        }
                                                    }
                                                },
                                                data: []
                                            }
                                        ]
                                    };

                                    $.ajax({
                                        url: '../Mutual/Common.ashx',
                                        type: "post",
                                        async: false,
                                        data: { "Action": "GetPie" },
                                        success: function (data) {
                                            var aa = JSON.parse(data)
                                            if (aa != "当前没有激活的活动！") {
                                                var a = aa[0];

                                                $.each(a, function (i) {
                                                    option.series[0].data[i] = { value: a[i].Value, name: a[i].Key },
                                                    option.legend.data[i] = a[i].Key
                                                })
                                            }
                                            myChart.setOption(option);
                                        }
                                    });
                                }
                            </script>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="widget box" style="margin-bottom:0">
                    <div class="widget-header">
                        <h4><i class="fa fa-reorder"></i>最新申报项目</h4>
                        <div class="toolbar no-padding">
                            <div class="btn-group">
                                <span class="btn btn-xs widget-collapse">
                                    <i class="fa fa-angle-down"></i>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="widget-content no-padding">
                        <table id="NewDeclaration" runat="server" class="table table-striped table-checkable table-hover" style="text-align:center;">
                            <thead>
                                <tr style="background:#85E1E1">
                                    <th class="hidden-xs " style="vertical-align: middle;background-color:#85E1E1" >项目编号</th>
                                    <th class="align-center" style="vertical-align: middle;background-color:#85E1E1">项目名称</th>                                  
                                    <th class="align-center" style="vertical-align: middle;background-color:#85E1E1">申报专业</th>
                                    <th class="align-center" style="vertical-align: middle;background-color:#85E1E1">申报奖项</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div style="display:none"><p id="pUserType" runat="server" ClientIDMode="Static"></p></div> 
    <script>
        $(function () {          
            //缓存当前页面所属栏目
            var ocolumn2Link = "../../View/Mutual/HomePage";
            var currerntNav = { column1:'首页', column2Link: ocolumn2Link, column2: "最新申报项目" }
            $.cookie('currentPage', JSON.stringify(currerntNav), { path: '/' });
            
        })

        var Userid = $('#hdUserid').val();

        var msg = $("#hdMsg").val();
        if (msg != "") {
            ShowMessag(msg);
            location.href = "../UserManage/UpdatePassword?setPsUserID=" + Userid + "";
        }
    </script>
 </asp:Content>