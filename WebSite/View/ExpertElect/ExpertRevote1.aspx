<%@ Page Title="等票复投" MasterPageFile="~/View/Mutual/Site.Master" Language="C#"  AutoEventWireup="true" CodeBehind="ExpertRevote.aspx.cs" Inherits="Evaluation.View.ExpertElect.ExpertRevote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ExperRevote">
        <ul class="navs">
        <li class="nav1" id="main" style="float: left; padding-right: 5px;">
            <a href="#">专家评选</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="../ExpertElect/ExpertReview.aspx">等票复投</a>
        </li>
    </ul>
        <div class="select">
            <span>请选择专业：
			    <select name="" id="professional1">
                    <option value="">请选择</option>
                    <option value="">建筑</option>
                    <option value="">市政</option>
                </select>
            </span>
            <span>请选择申报奖项：
			    <select name="" id="professional">
                    <option value="">请选择</option>
                    <option value="">建筑</option>
                    <option value="">市政</option>
                </select>
            </span>

            <span>
                <input type="submit" name="" id="" value="查询" /></span>
        </div>
        <div class="prompt">
			<i class="fa fa-bell " style="font-size:16px;" ;></i>
			<span>提示信息：一等奖3进1 &nbsp 二等奖10进3   &nbsp  三等奖18进6；已投票总数30。</span>
        </div>
        <div class="table-responsive">
            <table class="table table-bordered">
                <tr>
                    <th>序号</th>
                    <th>项目名称</th>
                    <th>申报单位</th>
                    <th>专业</th>
                    <th>申报奖项</th>
                    <th>推荐</th>
                </tr>
                <tr>
                    <td>1</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京市公司</td>
                    <td>建筑</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class="fa fa-thumbs-up" style="color: #FF9933; font-size: 20px;"></i>
                        <span class="firstPrize">一等奖</span>
                        <i class="fa fa-thumbs-up" style="color: #999999; font-size: 20px;"></i>
                        <span class="secondPrize">二等奖</span>
                    </td>
                </tr>
                <tr>
                    <td>1</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京市公司</td>
                    <td>建筑</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class="fa fa-thumbs-up" style="color: #FF9933; font-size: 20px;"></i>
                        <span class="firstPrize">一等奖</span>
                        <i class="fa fa-thumbs-up" style="color: #999999; font-size: 20px;"></i>
                        <span class="secondPrize">二等奖</span>
                    </td>
                </tr>

                <tr>
                    <td>1</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京市公司</td>
                    <td>建筑</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class="fa fa-thumbs-up" style="color: #FF9933; font-size: 20px;"></i>
                        <span class="firstPrize">一等奖</span>
                        <i class="fa fa-thumbs-up" style="color: #999999; font-size: 20px;"></i>
                        <span class="secondPrize">二等奖</span>
                    </td>
                </tr>

                <tr>
                    <td>1</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京市公司</td>
                    <td>建筑</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class="fa fa-thumbs-up" style="color: #FF9933; font-size: 20px;"></i>
                        <span class="firstPrize">一等奖</span>
                        <i class="fa fa-thumbs-up" style="color: #999999; font-size: 20px;"></i>
                        <span class="secondPrize">二等奖</span>
                    </td>
                </tr>

                <tr>
                    <td>1</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京市公司</td>
                    <td>建筑</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class="fa fa-thumbs-up" style="color: #FF9933; font-size: 20px;"></i>
                        <span class="firstPrize">一等奖</span>
                        <i class="fa fa-thumbs-up" style="color: #999999; font-size: 20px;"></i>
                        <span class="secondPrize">二等奖</span>
                    </td>
                </tr>
            </table>
        </div>
        <div class="footer">
            <div class="footerLeft">
                <span>共500，条当前显示条数：</span>
                <select name="" id="">
                    <option value="">10条</option>
                    <option value="">20条</option>
                    <option value="">50条</option>
                    <option value="">100条</option>
                </select>
            </div>
            <div class="footerRight">
                <span>首页</span>
                <span>上一页</span>
                <span>共1页</span>
                <span>下一页</span>
                <span>尾页</span>
            </div>
        </div>
        <div class="save"><input type="submit" value="保存投票结果" /></div>
    </div>
    <%--<ul class="navs" >
        <li class="nav1" id="main">           
          <a href="#">专家评选</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#">等票复投</a>
        </li>        
    </ul>
    <div style="border:1px solid #e1e1e1;border-radius:5px;padding:11px;margin-bottom:25px;">
       选择专业 ： <asp:DropDownList runat="server" ID="ddlSpecialty" ClientIDMode="Static" Style="width: 60%;"></asp:DropDownList>    
       申报奖项 ： <asp:DropDownList ID="ddlPrizeName" runat="server" ClientIDMode="Static" Style="width: 168px; height: 26px; margin-left: -13px; margin-right: 15px;"></asp:DropDownList>
    </div>
    <div class="select">          
         <input type="button" name="" id="" value="查  &nbsp;询" class="btnt" onclick="Search();" style="margin:0 7px;" />          
    </div>
    <div>提示信息
         
    </div>
    <table id="tbReVote"></table>
    <div id="btnDiv">
        <input type="button" class="btnt" id="btnVote" value="保 &nbsp;存" />
        <input type="button" class="btnt" id="btnSubmit" value="提 &nbsp;交" />
    </div>

    <script>     
        $(function () {
            $("#ddlSpecialty,#ddlPrizeName").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });
            $('select').multipleSelect('checkAll');
            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
            } 
        })

        function InitTable(PageSize, CuttentPage) {
            $("#tbReVote").bootstrapTable('destroy');
            $.ajax({
                url: '../Mutual/Declaration.ashx',
                type: "post",
                data: { "Action": "GetReVoteDeclarationList", "Specialtys": Specialtys, "PrizeID": PrizeID, "PageSize": PageSize, "CuttentPage": CuttentPage },
                success: function (data) {
                    if (data != "") {
                        var data = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbar',                //工具按钮用哪个容器
                            striped: true,                      //是否显示行间隔色
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            clickToSelect: true,
                            uniqueId: "GroupID",            //每一行的唯一标识，一般为主键列
                            queryParams: "",//传递参数（*）
                            columns: [{ checkbox: true },
                                { field: 'Ordinal', title: '序号', align: 'center', valign: 'middle' },
                                { field: 'DeclarationName', title: '项目名称', align: 'center', valign: 'middle' },
                                { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                { field: 'Specialty', title: '专业', align: 'center', valign: 'middle' },
                                { field: 'PrizeName', title: '申报奖项', align: 'center', valign: 'middle' }]
                        }
                        function formatTableUnit(row, index) {
                            return {
                                css: {
                                    "white-space": "nowrap",
                                    "text-overflow": "ellipsis",
                                    "overflow": "hidden"
                                }
                            }
                        }
                        option.data = data.Table;
                        $('#tbExpertGroup').bootstrapTable(option)

                        $("#divPagination").empty();
                        $("#divPagination").append(recordsCount(data.RecordNumber, data.CuttentPage, data.PerPage));
                        $("#divPagination").append(myPaginationLinks(data.RecordNumber, data.CuttentPage, data.PagesCount, "page_link", "active", "disabled"));
                        $("#divPagination").append(selectPerPage());
                        $("#per_page_select").val(data.PerPage);
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbExpertGroup'));
                    }
                }
            })
        }
    </script>--%>
</asp:Content>

