<%@ Page  Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="PublicConstruction.aspx.cs" Inherits="Evaluation.View.Declaration.PublicConstruction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
     <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css"/>
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>
   
    <style>
        table{border:none; border-collapse: collapse;}
        table tr{border:none;margin-bottom:0px;}
        table tr td{border:1px solid;padding:5px;text-align:center;}
        table tr td table{border:none;}
        table tr td table tr{border:none;}
        table tr td table td{border-left:none;border-top:none;text-align:center;border-bottom:none;} 
        .shejidanwei tr td{border-top:1px solid;} 
        input{border-style: none;
            border-color: inherit;
            border-width: medium;
            text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Panel ID="Panel1" runat="server" GroupingText="项目基本情况">
            <table>
                <tr>
                    <td>项目报优名称</td>
                    <td><asp:TextBox ID="DeclarationName" runat="server" Width="99%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>立项名称</td>
                    <td><asp:TextBox ID="ApprovalName" runat="server" Width="99%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>设计单位(主申报)</td>
                    <td style="padding:0;">
                        <table class="shejidanwei">
                            <tr>
                                <td style="border-top:none;">申报单位</td>
                                <td colspan="3" style="border-top:none;border-right:none;"><asp:TextBox ID="DeclarationUnit" runat="server" Width="99%"></asp:TextBox></td>
                            </tr>
                                <tr>
                                <td>通讯地址</td>
                                <td colspan="3" style="border-right:none;"><asp:TextBox ID="PostalAddress" runat="server" Width="99%"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>联系人</td>
                                <td><asp:TextBox ID="Linkman" runat="server"></asp:TextBox></td>
                                <td>手机</td>
                                <td style="border-right:none;"><asp:TextBox ID="MobileNumber" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>电话</td>
                                <td><asp:TextBox ID="TelephoneNumber" runat="server"></asp:TextBox></td>
                                <td>邮政编码</td>
                                <td style="border-right:none;"><asp:TextBox ID="Postcode" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>传真</td>
                                <td><asp:TextBox ID="FaxNumber" runat="server"></asp:TextBox></td>
                                <td>电子邮箱</td>
                                <td style="border-right:none;"><asp:TextBox ID="EmailAddress" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>境内、外合作设计单位</td>
                    <td><asp:TextBox ID="CooperativeUnit" runat="server" Width="99%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>建设单位</td>
                    <td><asp:TextBox ID="DevelopmentOrganization" runat="server" Width="99%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>施工单位</td>
                    <td><asp:TextBox ID="ConstructionOrganization" runat="server" Width="99%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>使用单位</td>
                    <td><asp:TextBox ID="UseUnit" runat="server" Width="99%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>建设地点</td>
                    <td><asp:TextBox ID="ConstructionLocation" runat="server" Width="99%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>设计类别</td>
                    <td style="padding:0;">
                        <table>
                            <tr>
                                <td><asp:TextBox ID="DesignCategory" runat="server"></asp:TextBox></td>
                                <td style="width:140px;">设计起止时间</td>
                                <td style="border-right:none;"><asp:TextBox ID="DesignStartDate" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>开工时间</td>
                    <td style="padding:0;">
                        <table>
                            <tr>
                                <td><asp:TextBox ID="ConstructionStartDate" runat="server"></asp:TextBox></td>
                                <td style="width:140px;">竣工时间</td>
                                <td style="border-right:none;"><asp:TextBox ID="ConstructionEndDate" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>竣工验收时间</td>
                    <td style="padding:0;">
                        <table>
                            <tr>
                                <td><asp:TextBox ID="AcceptanceDate" runat="server"></asp:TextBox></td>
                                <td style="width:140px;">竣工验收部门</td>
                                <td style="border-right:none;"><asp:TextBox ID="AcceptanceDepartment" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>消防备案时间</td>
                    <td style="padding:0;">
                        <table>
                            <tr>
                                <td><asp:TextBox ID="FireControlRecordDate" runat="server"></asp:TextBox></td>
                                <td style="width:140px;">交付使用时间</td>
                                <td style="border-right:none;"><asp:TextBox ID="DeliveryDate" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>投资来源</td>
                    <td style="padding:0;">
                        <table>
                            <tr>
                                <td><asp:TextBox ID="InvestSource" runat="server"></asp:TextBox></td>
                                <td style="width:140px;">申报等级</td>
                                <td style="border-right:none;"><asp:TextBox ID="DeclarationLevel" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" GroupingText="主要设计人员情况">
            <table>
                <tr>
                    <td>序号</td>
                    <td style="width:100px;">姓名</td>
                    <td style="width:60px;">职称</td>
                    <td style="width:100px;">专业</td>
                    <td>设计职务及设计中主要负责何项工作</td>
                    <td>身份证号/军官证号</td>
                </tr>
                <tr>
                    <td>1</td>
                    <td><asp:TextBox ID="TextBox325" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox337" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox338" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox351" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox364" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>2</td>
                    <td><asp:TextBox ID="TextBox365" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox366" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox367" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox368" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox369" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>3</td>
                    <td><asp:TextBox ID="TextBox370" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox371" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox372" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox373" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox374" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>4</td>
                    <td><asp:TextBox ID="TextBox375" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox376" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox377" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox378" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox379" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>5</td>
                    <td><asp:TextBox ID="TextBox380" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox381" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox382" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox383" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox384" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>6</td>
                    <td><asp:TextBox ID="TextBox385" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox386" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox387" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox388" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox389" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>7</td>
                    <td><asp:TextBox ID="TextBox390" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox391" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox392" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox393" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox394" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>8</td>
                    <td><asp:TextBox ID="TextBox395" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox396" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox397" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox398" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox399" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>9</td>
                    <td><asp:TextBox ID="TextBox400" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox401" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox402" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox403" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox404" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>10</td>
                    <td><asp:TextBox ID="TextBox405" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox406" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox407" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox408" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox409" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>11</td>
                    <td><asp:TextBox ID="TextBox410" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox411" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox412" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox413" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox414" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>12</td>
                    <td><asp:TextBox ID="TextBox415" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox416" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox417" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox418" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox419" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>13</td>
                    <td><asp:TextBox ID="TextBox420" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox421" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox422" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox423" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox424" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>14</td>
                    <td><asp:TextBox ID="TextBox425" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox426" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox427" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox428" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox429" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>15</td>
                    <td><asp:TextBox ID="TextBox430" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox431" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox432" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox433" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox434" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" GroupingText="技术申报内容(建筑专业)">
            <table>
                <tr>
                    <td rowspan="2" style="width:100px;">建筑功能（使用性质）</td>
                    <td style="width:50px;">地上</td>
                    <td colspan="3" style="width:600px;">共享服务展示、多功能会议区、网管开发运营业务、信息管理、行政办公管理等</td>
                    <td style="width:200px;">用地性质</td>
                    <td style="width:200px;">公共设施</td>
                </tr>
                <tr>
                    <td style="width:50px;">地下</td>
                    <td colspan="3">IDC供电、机电用房、汽车库、下沉庭院等</td>
                    <td>设计使用年限</td>
                    <td><asp:TextBox ID="DesignServiceLife" runat="server"></asp:TextBox>年</td>
                </tr>
                <tr>
                    <td colspan="2">总用地面积</td>
                    <td style="width:200px"><asp:TextBox ID="TotalLandArea" runat="server"></asp:TextBox>ha</td>
                    <td style="width:200px">代征地面积</td>
                    <td style="width:200px"><asp:TextBox ID="ExpropriationArea" runat="server"></asp:TextBox>ha</td>
                    <td>建设用地面积</td>
                    <td><asp:TextBox ID="ConstructionArea" runat="server"></asp:TextBox>㎡</td>
                </tr>
                <tr>
                    <td colspan="2">总建筑面积</td>
                    <td><asp:TextBox ID="OverallFloorage" runat="server"></asp:TextBox>㎡</td>
                    <td>地上面积</td>
                    <td><asp:TextBox ID="OvergroundArea" runat="server"></asp:TextBox>㎡</td>
                    <td>地下面积</td>
                    <td><asp:TextBox ID="UndergroundArea" runat="server"></asp:TextBox>㎡</td>
                </tr>
                <tr>
                    <td colspan="2">建筑基底面积</td>
                    <td><asp:TextBox ID="BuildingArea" runat="server"></asp:TextBox>ha</td>
                    <td>绿地面积</td>
                    <td><asp:TextBox ID="GreenArea" runat="server"></asp:TextBox>㎡</td>
                    <td>绿化率</td>
                    <td><asp:TextBox ID="GreeningRate" runat="server"></asp:TextBox>%</td>
                </tr>
                <tr>
                    <td colspan="2">容 积 率</td>
                    <td><asp:TextBox ID="PlotRatio" runat="server"></asp:TextBox></td>
                    <td>建筑密度</td>
                    <td><asp:TextBox ID="BuildingDensity" runat="server"></asp:TextBox>%</td>
                    <td>建筑分类/耐火等级</td>
                    <td><asp:TextBox ID="BuildingClassification" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">建筑高度</td>
                    <td><asp:TextBox ID="BuildingHeight" runat="server"></asp:TextBox>m</td>
                    <td>地上层数</td>
                    <td><asp:TextBox ID="GroundLayerCount" runat="server"></asp:TextBox>层</td>
                    <td>地下层数</td>
                    <td><asp:TextBox ID="UndergroundLayerCount" runat="server"></asp:TextBox>层</td>
                </tr>
                <tr>
                    <td colspan="2">机动车停车计</td>
                    <td><asp:TextBox ID="AutoParkingCount" runat="server"></asp:TextBox>辆</td>
                    <td>地上停车</td>
                    <td><asp:TextBox ID="GroundAutoParkingCount" runat="server"></asp:TextBox>辆</td>
                    <td>地下停车</td>
                    <td><asp:TextBox ID="UndergroundAutoParkingCount" runat="server"></asp:TextBox>辆</td>
                </tr>
                <tr>
                    <td colspan="2">自行车停车计</td>
                    <td><asp:TextBox ID="BicycleParkingCount" runat="server"></asp:TextBox>辆</td>
                    <td>地上停车</td>
                    <td><asp:TextBox ID="GroundBicycleParkingCount" runat="server"></asp:TextBox>辆</td>
                    <td>地下停车</td>
                    <td><asp:TextBox ID="UndergroundBicycleParkingCount" runat="server"></asp:TextBox>辆</td>
                </tr>
                <tr>
                    <td rowspan="2" colspan="2">放空地下室</td>
                    <td>建筑面积</td>
                    <td>战时用途</td>
                    <td><asp:TextBox ID="Basement_WartimeUse" runat="server"></asp:TextBox></td>
                    <td>抗力级别</td>
                    <td><asp:TextBox ID="Basement_ResistanceLevel" runat="server"></asp:TextBox>级</td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="Basement_ConstructionArea" runat="server"></asp:TextBox>㎡</td>
                    <td>平时用途</td>
                    <td><asp:TextBox ID="Basement_UsuallyUse" runat="server"></asp:TextBox></td>
                    <td>防化级别</td>
                    <td><asp:TextBox ID="Basement_AntichemicalLevel" runat="server"></asp:TextBox>级</td>
                </tr>
                <tr>
                    <td colspan="7">居 住 建 筑 类 需 补 充 填 写 以 下 各 项</td>
                </tr>
                <tr>
                    <td colspan="2">住宅用地</td>
                    <td><asp:TextBox ID="ResidentialLand" runat="server"></asp:TextBox>ha</td>
                    <td>配套公建用地</td>
                    <td><asp:TextBox ID="SupportingConstructionLand" runat="server"></asp:TextBox>ha</td>
                    <td>非配套公建用地</td>
                    <td><asp:TextBox ID="NonMatchingConstructionLand" runat="server"></asp:TextBox>ha</td>
                </tr>
                <tr>
                    <td colspan="2">道路用地</td>
                    <td><asp:TextBox ID="LandForRoads" runat="server"></asp:TextBox>ha</td>
                    <td>公共绿地</td>
                    <td><asp:TextBox ID="GreenSpace" runat="server"></asp:TextBox>ha</td>
                    <td>配套公建面积</td>
                    <td><asp:TextBox ID="SupportingConstructionArea" runat="server"></asp:TextBox>㎡</td>
                </tr>
                <tr>
                    <td colspan="2">居住建筑面积</td>
                    <td><asp:TextBox ID="ResidentialBuildingArea" runat="server"></asp:TextBox>㎡</td>
                    <td>平均每套建筑面积</td>
                    <td><asp:TextBox ID="AverageAreaPerSet" runat="server"></asp:TextBox>㎡/套</td>
                    <td>非配套公建面积</td>
                    <td><asp:TextBox ID="NonMatchingConstructionArea" runat="server"></asp:TextBox>㎡</td>
                </tr>
                <tr>
                    <td colspan="2">总居住户数</td>
                    <td><asp:TextBox ID="TotalHousehold" runat="server"></asp:TextBox>户</td>
                    <td>每户人均数</td>
                    <td><asp:TextBox ID="AveragePersonPerHousehold" runat="server"></asp:TextBox>人/户</td>
                    <td>总居住人数</td>
                    <td><asp:TextBox ID="TotalPerson" runat="server"></asp:TextBox>人</td>
                </tr>
                <tr>
                    <td colspan="2">公共人均绿地</td>
                    <td><asp:TextBox ID="PerPersonGreenSpace" runat="server"></asp:TextBox>㎡/人</td>
                    <td>机动车指标</td>
                    <td><asp:TextBox ID="VehicleIndicators" runat="server"></asp:TextBox>辆/户</td>
                    <td>自行车指标</td>
                    <td><asp:TextBox ID="BicycleIndicators" runat="server"></asp:TextBox>辆/户</td>
                </tr>
                <tr>
                    <td colspan="2" rowspan="4">住宅类型</td>
                    <td>总栋数</td>
                    <td>保障房</td>
                    <td>商品房</td>
                    <td>公寓</td>
                    <td>其他</td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="BuildingCount" runat="server"></asp:TextBox>栋</td>
                    <td><asp:TextBox ID="SecurityHousing" runat="server"></asp:TextBox>栋</td>
                    <td><asp:TextBox ID="CommercialHousing" runat="server"></asp:TextBox>栋</td>
                    <td><asp:TextBox ID="Apartment" runat="server"></asp:TextBox>栋</td>
                    <td><asp:TextBox ID="OtherResidentialType" runat="server"></asp:TextBox>栋</td>
                </tr>
                <tr>
                    <td rowspan="2">其中保障房包含</td>
                    <td>限价商品房</td>
                    <td>经济适用房</td>
                    <td>公租房</td>
                    <td>廉租房</td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="CappedPriceHousing" runat="server"></asp:TextBox>栋</td>
                    <td><asp:TextBox ID="AffordableHousing" runat="server"></asp:TextBox>栋</td>
                    <td><asp:TextBox ID="PRH" runat="server"></asp:TextBox>栋</td>
                    <td><asp:TextBox ID="LowRentHousing" runat="server"></asp:TextBox>栋</td>
                </tr>
                <tr>
                    <td colspan="2">层数特征</td>
                    <td colspan="5" style="padding:0;">
                        <table >
                            <tr>
                                <td style="width:348px;">1-6层</td>
                                <td style="width:348px;">7-10层</td>
                                <td style="width:348px;">10层以上</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td rowspan="2">层数（层）</td>
                    <td>地上</td>
                    <td colspan="5" style="padding:0;">
                        <table >
                            <tr>
                                <td style="width:348px;"><asp:TextBox ID="GroundLayer_Less6" runat="server"></asp:TextBox></td>
                                <td style="width:348px;"><asp:TextBox ID="GroundLayer_7To10" runat="server"></asp:TextBox></td>
                                <td style="width:348px;"><asp:TextBox ID="GroundLayer_Above10" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>地下</td>
                    <td colspan="5" style="padding:0;">
                        <table >
                            <tr>
                                <td style="width:348px;"><asp:TextBox ID="UndergroundLayer_Less6" runat="server"></asp:TextBox></td>
                                <td style="width:348px;"><asp:TextBox ID="UndergroundLayer_7To10" runat="server"></asp:TextBox></td>
                                <td style="width:348px;"><asp:TextBox ID="UndergroundLayer_Above10" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">高度（m）</td>
                    <td colspan="5" style="padding:0;">
                        <table >
                            <tr>
                                <td style="width:348px;"><asp:TextBox ID="Height_Less6" runat="server"></asp:TextBox></td>
                                <td style="width:348px;"><asp:TextBox ID="Height_7To10" runat="server"></asp:TextBox></td>
                                <td style="width:348px;"><asp:TextBox ID="Height_Above10" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">栋数（栋）</td>
                    <td colspan="5" style="padding:0;">
                        <table >
                            <tr>
                                <td style="width:348px;"><asp:TextBox ID="Count_Less6" runat="server"></asp:TextBox></td>
                                <td style="width:348px;"><asp:TextBox ID="Count_7To10" runat="server"></asp:TextBox></td>
                                <td style="width:348px;"><asp:TextBox ID="Count_Above10" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">备注</td>
                    <td colspan="5"><asp:TextBox ID="ResidentialInfoMemo" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <asp:TextBox ID="ConstructionFeatures" runat="server" TextMode="MultiLine" style="width:900px;height:500px;">
                 建筑专业设计主要特点（限800~1500字）：
            </asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" GroupingText="技术申报内容(结构专业)">
            <table>
                <tr>
                    <td colspan="3">结构体系</td>
                    <td colspan="3"><asp:TextBox ID="StructuralSystem" runat="server"></asp:TextBox></td>
                    <td>抗震设防烈度</td>
                    <td><asp:TextBox ID="FortificationIntensity" runat="server"></asp:TextBox>度</td>
                </tr>
                <tr>
                    <td colspan="3">抗震设防类别</td>
                    <td colspan="3"><asp:TextBox ID="FortificationCategory" runat="server"></asp:TextBox></td>
                    <td>基本地震加速度</td>
                    <td><asp:TextBox ID="BasicSeismicAcceleration" runat="server"></asp:TextBox>g</td>
                </tr>
                <tr>
                    <td colspan="3">设计地震分组</td>
                    <td colspan="3"><asp:TextBox ID="SeismicGrouping" runat="server"></asp:TextBox></td>
                    <td>建筑场地土类别</td>
                    <td><asp:TextBox ID="SiteSoilType" runat="server"></asp:TextBox>类</td>
                </tr>
                <tr>
                    <td colspan="3">基础类型</td>
                    <td colspan="3"><asp:TextBox ID="BaseType" runat="server"></asp:TextBox></td>
                    <td>结构安全等级</td>
                    <td><asp:TextBox ID="SafetyLevel" runat="server"></asp:TextBox>级</td>
                </tr>
                <tr>
                    <td colspan="3">混凝土总用量（砖混结构可不填写此栏及后三栏）</td>
                    <td colspan="3"><asp:TextBox ID="ConcreteAmount" runat="server"></asp:TextBox>m³</td>
                    <td>每平方米混凝土折算厚度</td>
                    <td><asp:TextBox ID="PerSqM_ConcreteReducedThickness" runat="server"></asp:TextBox>cm/㎡</td>
                </tr>
                <tr>
                    <td rowspan="2" colspan="3">钢材总用量</td>
                    <td colspan="3">钢筋:<asp:TextBox ID="SteelAmount_rebar" runat="server" style="width:60%"></asp:TextBox>t</td>
                    <td rowspan="2">每平方米钢材用量</td>
                    <td>钢筋:<asp:TextBox ID="PerSqM_SteelAmount_rebar" runat="server" style="width:60%"></asp:TextBox>kg/㎡</td>
                </tr>
                <tr>
                   <td colspan="3">型钢:<asp:TextBox ID="SteelAmount_SectionSteel" runat="server" style="width:60%"></asp:TextBox>t</td>
                   <td>型钢:<asp:TextBox ID="PerSqM_SteelAmount_SectionSteel" runat="server" style="width:60%"></asp:TextBox>kg/㎡</td>
                </tr>
                <tr>
                    <td rowspan="21">抗震分析主要结果</td>
                    <td colspan="5">程序名称：PKPM</td>
                    <td>是否考虑扭转耦联</td>
                    <td><asp:TextBox ID="TextBox105" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width:50px;">振型号</td>
                    <td style="width:100px;">周期</td>
                    <td style="width:100px;">转角</td>
                    <td style="width:100px;">平动系数(x+y)</td>
                    <td style="width:100px;">扭转系数</td>
                    <td>X向基底剪力(kN)</td>
                    <td>Y向基底剪力(kN)</td>
                </tr>
                <tr>
                    <td>1</td>
                    <td><asp:TextBox ID="VibrationModeCycle1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="VibrationModeAngle1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TranslationalCoefficient1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TorsionCoefficient1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_X" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_Y" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>2</td>
                    <td><asp:TextBox ID="VibrationModeCycle2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="VibrationModeAngle2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TranslationalCoefficient2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TorsionCoefficient2" runat="server"></asp:TextBox></td>
                    <td>X向基底剪重比</td>
                    <td>Y向基底剪重比</td>
                </tr>
                <tr>
                    <td>3</td>
                    <td><asp:TextBox ID="VibrationModeCycle3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="VibrationModeAngle3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TranslationalCoefficient3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TorsionCoefficient3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BasalShearRatio_X" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BasalShearRatio_Y" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>4</td>
                    <td><asp:TextBox ID="VibrationModeCycle4" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="VibrationModeAngle4" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TranslationalCoefficient4" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TorsionCoefficient4" runat="server"></asp:TextBox></td>
                    <td>X向最小剪重比（层号）</td>
                    <td>Y向最小剪重比（层号）</td>
                </tr>
                <tr>
                    <td>5</td>
                    <td><asp:TextBox ID="VibrationModeCycle5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="VibrationModeAngle5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TranslationalCoefficient5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TorsionCoefficient5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MinShearWeightRatio_X" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MinShearWeightRatio_Y" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>6</td>
                    <td><asp:TextBox ID="VibrationModeCycle6" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="VibrationModeAngle6" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TranslationalCoefficient6" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TorsionCoefficient6" runat="server"></asp:TextBox></td>
                    <td>X向最大层间位移角</td>
                    <td>Y向最大层间位移角</td>
                </tr>
                <tr>
                    <td>7</td>
                    <td><asp:TextBox ID="VibrationModeCycle7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="VibrationModeAngle7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TranslationalCoefficient7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TorsionCoefficient7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_X" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_Y" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>8</td>
                    <td><asp:TextBox ID="VibrationModeCycle8" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="VibrationModeAngle8" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TranslationalCoefficient8" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TorsionCoefficient8" runat="server"></asp:TextBox></td>
                    <td>X向最大位移比（层号）</td>
                    <td>Y向最大位移比（层号）</td>
                </tr>
                <tr>
                    <td>9</td>
                    <td><asp:TextBox ID="VibrationModeCycle9" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="VibrationModeAngle9" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TranslationalCoefficient9" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TorsionCoefficient9" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxDisplacementRatio_X" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxDisplacementRatio_Y" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="7">注：单塔可仅填前三个振型 </td>
                </tr>
                <tr>
                    <td colspan="3">时程分析波名</td>
                    <td>X向基底剪力(kN)</td>
                    <td>X向最大层间位移角</td>
                    <td>Y向基底剪力(kN)</td>
                    <td>Y向最大层间位移角</td>
                </tr>
                <tr>
                    <td colspan="1">1</td>
                    <td colspan="2"><asp:TextBox ID="TimeHistoryAnalysisName1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_X1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_X1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_Y1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_Y1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="1">2</td>
                    <td colspan="2"><asp:TextBox ID="TimeHistoryAnalysisName2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_X2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_X2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_Y2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_Y2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="1">3</td>
                    <td colspan="2"><asp:TextBox ID="TimeHistoryAnalysisName3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_X3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_X3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_Y3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_Y3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="1">4</td>
                    <td colspan="2"><asp:TextBox ID="TimeHistoryAnalysisName4" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_X4" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_X4" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_Y4" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_Y4" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="1">5</td>
                    <td colspan="2"><asp:TextBox ID="TimeHistoryAnalysisName5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_X5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_X5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_Y5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_Y5" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="1">6</td>
                    <td colspan="2"><asp:TextBox ID="TimeHistoryAnalysisName6" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_X6" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_X6" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_Y6" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_Y6" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="1">7</td>
                    <td colspan="2"><asp:TextBox ID="TimeHistoryAnalysisName7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_X7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_X7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_Y7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_Y7" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="3">各波平均值(当选3条波时为包络值)</td>
                    <td><asp:TextBox ID="BaseShear_X_Avg" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_X_Avg" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="BaseShear_Y_Avg" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="MaxStoreyDriftAngle_Y_Avg" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <asp:TextBox ID="StructuralFeatures" runat="server" TextMode="MultiLine" style="width:900px;height:500px;">
                 结构专业设计主要特点（限400~600字）：
                （重点介绍技术的难点、创新点及先进性。）
            </asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server" GroupingText="技术申报内容(设备专业)">
            <table>
                <tr>
                    <td>供暖方式</td>
                    <td colspan="2"><asp:TextBox ID="HeatingMode" runat="server"></asp:TextBox></td>
                    <td>供暖建筑面积</td>
                    <td colspan="2"><asp:TextBox ID="HeatingConstructionArea" runat="server"></asp:TextBox>㎡</td>
                </tr>
                <tr>
                    <td>供暖热负荷</td>
                    <td colspan="2"><asp:TextBox ID="SpaceHeatingLoad" runat="server"></asp:TextBox>KW</td>
                    <td>供暖热负荷指标</td>
                    <td colspan="2"><asp:TextBox ID="SpaceHeatingLoadIndicators" runat="server"></asp:TextBox>W/㎡</td>
                </tr>
                <tr>
                    <td>空调系统形式</td>
                    <td colspan="2"><asp:TextBox ID="AirConSysMode" runat="server"></asp:TextBox></td>
                    <td>空调建筑面积</td>
                    <td colspan="2"><asp:TextBox ID="AirConBuildingArea" runat="server"></asp:TextBox>㎡</td>
                </tr>
                <tr>
                    <td rowspan="2">空调冷负荷</td>
                    <td rowspan="2" colspan="2"><asp:TextBox ID="AirConCoolingLoad" runat="server"></asp:TextBox>KW</td>
                    <td rowspan="2">空调冷指标</td>
                    <td colspan="2"><asp:TextBox ID="AirConCoolingIndicators_TotalArea" runat="server" style="width:50%"></asp:TextBox>W/㎡（总建筑面积）</td>
                </tr>
                <tr>
                    <td colspan="2"><asp:TextBox ID="AirConCoolingIndicators_AirConArea" runat="server" style="width:50%"></asp:TextBox>W/㎡（空调建筑面积）</td>
                </tr>
                <tr>
                    <td rowspan="2">空调热负荷</td>
                    <td rowspan="2" colspan="2"><asp:TextBox ID="AirConHeatingLoad" runat="server"></asp:TextBox>KW</td>
                    <td rowspan="2">空调热指标</td>
                    <td colspan="2"><asp:TextBox ID="AirConHeatingIndicators_TotalArea" runat="server" style="width:50%"></asp:TextBox>W/㎡（总建筑面积）</td>
                </tr>
                <tr>
                    <td colspan="2"><asp:TextBox ID="AirConHeatingIndicators_AirConArea" runat="server" style="width:50%"></asp:TextBox>W/㎡（空调建筑面积）</td>
                </tr>
                <tr>
                    <td colspan="6">冷源</td>
                </tr>
                <tr>
                    <td rowspan="3">冷水机组类型</td>
                    <td><asp:TextBox ID="ChillerType1" runat="server"></asp:TextBox></td>
                    <td rowspan="3">单台设计制冷量</td>
                    <td><asp:TextBox ID="ChillerOutput1" runat="server"></asp:TextBox></td>
                    <td rowspan="3">台数</td>
                    <td><asp:TextBox ID="ChillerQuantity1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="ChillerType2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="ChillerOutput2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="ChillerQuantity2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="ChillerType3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="ChillerOutput3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="ChillerQuantity3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="6">热源</td>
                </tr>
                <tr>
                    <td rowspan="3">制热设备类型</td>
                    <td><asp:TextBox ID="HeatingEquipmentType1" runat="server"></asp:TextBox></td>
                    <td rowspan="3">单台设计供热</td>
                    <td><asp:TextBox ID="HeatingEquipmentOutput1" runat="server"></asp:TextBox></td>
                    <td rowspan="3">台数</td>
                    <td><asp:TextBox ID="HeatingEquipmentQuantity1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="HeatingEquipmentType2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="HeatingEquipmentOutput2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="HeatingEquipmentQuantity2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="HeatingEquipmentType3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="HeatingEquipmentOutput3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="HeatingEquipmentQuantity3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>供暖系统制式</td>
                    <td colspan="5"><asp:TextBox ID="HeatingSystem" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>空调水系统制式</td>
                    <td colspan="5"><asp:TextBox ID="AirConWaterSystem" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>给水系统形式</td>
                    <td colspan="5"><asp:TextBox ID="WaterSupplySystem" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>中水系统形式</td>
                    <td colspan="5"><asp:TextBox ID="ReclaimedWaterSystem" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>雨、污水系统形式</td>
                    <td colspan="5"><asp:TextBox ID="SewageSystem" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>消防给水系统形式</td>
                    <td colspan="5"><asp:TextBox ID="FireWaterSupplySystem" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:TextBox ID="Features_HVAC" runat="server" TextMode="MultiLine" Style="width: 900px; height: 500px;">
                             设计特点：
                            暖通、空调：（限制200～300字）
                        </asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel6" runat="server" GroupingText="技术申报内容(电气专业)">
            <table>
                <tr>
                    <td colspan="2">供电电源设计情况</td>
                    <td colspan="5"><asp:TextBox ID="ElectricitySupplyDesign" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">用电负荷等级确定情况</td>
                    <td colspan="5"><asp:TextBox ID="ElectricityLoadLevels" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">防雷设计类别及方式</td>
                    <td colspan="5"><asp:TextBox ID="LightningProtection" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">强电设计</td>
                    <td colspan="5"><asp:TextBox ID="HighVoltageDesign" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">弱电设计</td>
                    <td colspan="5"><asp:TextBox ID="LowVoltageDesign" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">电力总用电负荷</td>
                    <td colspan="2"><asp:TextBox ID="TotalElectricityload" runat="server"></asp:TextBox>KW</td>
                    <td colspan="2">照明总用电负荷</td>
                    <td><asp:TextBox ID="TotalLightingLoad" runat="server" style="width:40%"></asp:TextBox>KW</td>
                </tr>
                <tr>
                    <td colspan="2">变压器配置</td>
                    <td colspan="2"><asp:TextBox ID="TransformerConfig" runat="server"></asp:TextBox>KVA</td>
                    <td colspan="2">变压器装机密度</td>
                    <td><asp:TextBox ID="TransformerDensity" runat="server" style="width:40%"></asp:TextBox>KVA/㎡</td>
                </tr>
                <tr>
                    <td colspan="2">备用电源设置情况及总容量</td>
                    <td colspan="2"><asp:TextBox ID="StandbyElectricity" runat="server"></asp:TextBox>KW</td>
                    <td colspan="2">备用电源装机密度</td>
                    <td><asp:TextBox ID="StandbyElectricityDensity" runat="server" style="width:40%"></asp:TextBox>KVA/㎡或KW/㎡</td>
                </tr>
                <tr>
                    <td rowspan="3" colspan="1">居住建筑</td>
                    <td>住宅类型</td>
                    <td>经济适用房</td>
                    <td colspan="2">商品房</td>
                    <td>公寓</td>
                    <td>其他</td>
                </tr>
                <tr>
                    <td>用电指标（kVA/㎡）</td>
                    <td><asp:TextBox ID="Indicators_AffordableHousing" runat="server"></asp:TextBox></td>
                    <td colspan="2"><asp:TextBox ID="Indicators_CommercialHousing" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="Indicators_Apartment" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="txt" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>备注</td>
                    <td colspan="5"><asp:TextBox ID="ElectricityMemo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="7">
                        <asp:TextBox ID="ElectricityFeatures" runat="server" TextMode="MultiLine" Style="width: 900px; height: 500px;">
                              设计特点：
                            强电：（限制200～300字）
                            双路10KV高压电缆埋地引入地下一层的高压分界室电缆夹层，
                            经分界柜后引至用户变配电所的电缆夹层。变配电所10KV配电采用铠装移开式金属封闭开关柜，
                            单母线分段运行，手动联络；变压器为四台环氧浇注干式变压器，型号分别为两台SCB9-10/0.4/.
                        </asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel7" runat="server" GroupingText="技术经济指标">
            <table>
                <tr>
                    <td>单位规模建筑面积指标</td>
                    <td colspan="2"><asp:TextBox ID="UnitAreaIndicators" runat="server"></asp:TextBox></td>
                    <td>㎡/<asp:TextBox ID="TextBox248" runat="server" style="width:30px;"></asp:TextBox></td>
                    <td>使用面积系数</td>
                    <td colspan="2"><asp:TextBox ID="UseAreaCoefficient" runat="server"></asp:TextBox></td>
                    <td>%</td>
                </tr>
                <tr>
                    <td>单位建筑面积耗热量指标</td>
                    <td colspan="2"><asp:TextBox ID="UnitAreaHotConsumption" runat="server"></asp:TextBox></td>
                    <td>W/㎡</td>
                    <td>单位建筑面积耗冷量指标</td>
                    <td colspan="2"><asp:TextBox ID="UnitAreaColdConsumption" runat="server"></asp:TextBox></td>
                    <td>W/㎡</td>
                </tr>
                <tr>
                    <td>单位建筑面积变压器装机容量</td>
                    <td colspan="2"><asp:TextBox ID="UnitAreaTransformerCapacity" runat="server"></asp:TextBox></td>
                    <td>VA/㎡</td>
                    <td>日供水量</td>
                    <td colspan="2"><asp:TextBox ID="DailyWaterSupply" runat="server"></asp:TextBox></td>
                    <td>m3/日</td>
                </tr>
                <tr>
                    <td colspan="4">概算</td>
                    <td colspan="4">竣工决算</td>
                </tr>
                <tr>
                    <td rowspan="2">总造价</td>
                    <td>人民币</td>
                    <td><asp:TextBox ID="Estimate_RMB" runat="server"></asp:TextBox></td>
                    <td>万元</td>
                    <td rowspan="2">总造价</td>
                    <td>人民币</td>
                    <td><asp:TextBox ID="Settlement_RMB" runat="server"></asp:TextBox></td>
                    <td>万元</td>
                </tr>
                <tr>
                    <td>外币</td>
                    <td><asp:TextBox ID="Estimate_ForeignCurrency" runat="server"></asp:TextBox></td>
                    <td>万美元</td>
                    <td>外币</td>
                    <td><asp:TextBox ID="Settlement_ForeignCurrency" runat="server"></asp:TextBox></td>
                    <td>万美元</td>
                </tr>
                <tr>
                    <td rowspan="2">土建与安装工程的比例</td>
                    <td>土建</td>
                    <td><asp:TextBox ID="Estimate_CivilEngineering" runat="server"></asp:TextBox></td>
                    <td>%</td>
                    <td rowspan="2">土建与安装工程的比例</td>
                    <td>土建</td>
                    <td><asp:TextBox ID="Settlement_CivilEngineering" runat="server"></asp:TextBox></td>
                    <td>%</td>
                </tr>
                <tr>
                    <td>安装</td>
                    <td><asp:TextBox ID="Estimate_Install" runat="server"></asp:TextBox></td>
                    <td>%</td>
                    <td>安装</td>
                    <td><asp:TextBox ID="Settlement_Install" runat="server"></asp:TextBox></td>
                    <td>%</td>
                </tr>
                <tr>
                    <td>单位建筑面积造价</td>
                    <td colspan="2"><asp:TextBox ID="Estimate_PerUnitAreaRMB" runat="server"></asp:TextBox></td>
                    <td>元/㎡</td>
                    <td>单位建筑面积造价</td>
                    <td colspan="2"><asp:TextBox ID="Settlement_OneUnitAreaRMB" runat="server"></asp:TextBox></td>
                    <td>元/㎡</td>
                </tr>
                <tr>
                    <td>单位规模造价</td>
                    <td colspan="2"><asp:TextBox ID="Estimate_PerUnitScaleRMB" runat="server"></asp:TextBox></td>
                    <td>元/<asp:TextBox ID="TextBox265" runat="server" style="width:30px;"></asp:TextBox></td>
                    <td>单位规模造价</td>
                    <td colspan="2"><asp:TextBox ID="Settlement_OneUnitScaleRMB" runat="server"></asp:TextBox></td>
                    <td>元/<asp:TextBox ID="TextBox266" runat="server" style="width:30px;"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="8">
                        <asp:TextBox ID="EconomicsFeatures" runat="server" TextMode="MultiLine" Style="width: 900px; height: 500px;">
                              经济专业主要特点：（限制在200字）
                            1、多与甲方沟通：了解甲方想法，做到心里有数。根据甲方变化的要求，完成了多个版本的编制。
                            2、与设计人沟通：主动与设计人联系，请设计人帮助提供解决方案，请设计负责人审核，为概算把关。
                            3、加强自审：按重点自审，在成稿后再进行二次自审，做到不出大错误。
                        </asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" GroupingText="附件目录">
            <asp:TextBox ID="TextBox268" runat="server" TextMode="MultiLine" Style="width: 900px; height: 500px;">
                （1）政府规划部门签发的规划意见书及附图；
                （2）政府规划部门签发的建筑工程规划许可证；
                （3）发展改革委员会（或其他上级单位）批复；
                （4）消防部门建筑工程消防验收意见书或相关文件（如专家论证会意见、未被抽查受理凭证）；
                （5）建筑工程竣工验收备案表或四方验收证明；
                （6）建筑工程规划验收备案；
                （7）使用单位的反馈意见及盖章（注：除非为同一单位，不应以建设单位代替使用单位；住宅使用方一般为物业公司）；
                （8）施工单位的反馈意见及盖章；
                （9）境内外合作设计项目需填写《合作设计项目合作声明》；
                （10）施工图审查机构审查书；
                （11）无重大安全质量事故证明文件；
                （12）其他文件（已有奖励、涉密项目处理、专项技术成果认定证明；经济、社会或环境效益证明文件）。
                 (以上材料附于此页)
            </asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel9" runat="server" GroupingText="评审意见">
            <label>专业评审组初审意见：</label>
            <br />
            <asp:TextBox ID="TextBox269" runat="server" TextMode="MultiLine" Style="width: 900px; height: 500px;">
                组长（签名）:                             年              月             日

            </asp:TextBox>
            <br />
            <label>评审委员会审定意见：</label>
            <br />
            <asp:TextBox ID="TextBox270" runat="server" TextMode="MultiLine" Style="width: 900px; height: 500px;">
                主任委员（签名）:                             年              月             日
            </asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel10" runat="server" GroupingText="申报单位法人代表人声明">
            <table>
                <tr>
                    <td colspan="2">申报单位法人代表人声明</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="TextBox271" runat="server" TextMode="MultiLine" Style="width: 900px; height: 500px;">
                            本人 朱（法定代表人） 1101081 （身份证号码）郑重声明，我单位申请参加 建筑综合奖 奖项的评选，
                        其申报表及附件材料填报的全部数据、内容真实，纸质、光盘等媒介资料相符。申报资料如有虚假，本单位将
                        自动退出北京市优秀工程勘察设计奖的评选，并愿接受主管部门所做的处理。附表：《申报项目次序表》。
                        </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>单位法定代表人（签名）：<asp:TextBox ID="TextBox272" runat="server"></asp:TextBox></td>
                    <td>单位公章：<asp:TextBox ID="TextBox273" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">日期：<asp:TextBox ID="TextBox274" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel11" runat="server" GroupingText="申报项目次序表">
            <table>
                <tr>
                    <td colspan="3">申报项目次序表</td>
                </tr>
                <tr>
                    <td colspan="3">奖项名称:<asp:TextBox ID="TextBox275" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>申报等级</td>
                    <td>本奖项排序</td>
                    <td>项目名称</td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="TextBox276" runat="server">一等奖</asp:TextBox></td>
                    <td>1</td>
                    <td><asp:TextBox ID="TextBox277" runat="server">中国网通科研中心（亦庄二期）</asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="TextBox278" runat="server"></asp:TextBox></td>
                    <td>2</td>
                    <td><asp:TextBox ID="TextBox279" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="TextBox280" runat="server"></asp:TextBox></td>
                    <td>3</td>
                    <td><asp:TextBox ID="TextBox281" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="TextBox282" runat="server"></asp:TextBox></td>
                    <td>4</td>
                    <td><asp:TextBox ID="TextBox283" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="TextBox284" runat="server"></asp:TextBox></td>
                    <td>5</td>
                    <td><asp:TextBox ID="TextBox285" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="TextBox286" runat="server"></asp:TextBox></td>
                    <td>6</td>
                    <td><asp:TextBox ID="TextBox287" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="TextBox288" runat="server"></asp:TextBox></td>
                    <td>7</td>
                    <td><asp:TextBox ID="TextBox289" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="TextBox290" runat="server"></asp:TextBox></td>
                    <td>8</td>
                    <td><asp:TextBox ID="TextBox291" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="TextBox292" runat="server"></asp:TextBox></td>
                    <td>9</td>
                    <td><asp:TextBox ID="TextBox293" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="TextBox294" runat="server"></asp:TextBox></td>
                    <td>10</td>
                    <td><asp:TextBox ID="TextBox295" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="3">单位公章：<asp:TextBox ID="TextBox296" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="3">日期：<asp:TextBox ID="TextBox297" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align:left;">注：每个奖项填制一份表格。</td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel12" runat="server" GroupingText="合作勘察设计项目合作声明">
            <table>
                <tr>
                    <td>合作勘察设计项目合作声明</td>
                </tr>
                <tr>
                    <td style="text-align:left;"><asp:TextBox ID="TextBox298" runat="server" style="width:200px;border-bottom:solid 1px;"></asp:TextBox>
                         工程项目为我们合作完成，我们各方均同意以
                        <asp:TextBox ID="TextBox299" runat="server" style="width:200px;border-bottom:solid 1px;"></asp:TextBox>（单位）
                        为主申报单位，参加北京市优秀工程勘察设计奖评选。
                        <br />
                        特此声明。
                    </td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td colspan="13">合作设计项目分工表</td>
                </tr>
                <tr>
                    <td>排序</td>
                    <td>勘察设计单位（全称）</td>
                    <td>概念性方案设计</td>
                    <td>方案设计(建筑)</td>
                    <td>方案设计（结构）</td>
                    <td>初步设计（建筑）</td>
                    <td>初步设计（结构）</td>
                    <td>初步设计（设备）</td>
                    <td>初步设计（电气）</td>
                    <td>施工图设计（建筑）</td>
                    <td>施工图设计（结构）</td>
                    <td>施工图设计（设备）</td>
                    <td>施工图设计（电气）</td>
                </tr>
                <tr>
                    <td>1</td>
                    <td><asp:TextBox ID="TextBox300" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox301" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox302" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox303" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox304" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox305" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox306" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox307" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox308" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox309" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox310" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox311" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>2</td>
                    <td><asp:TextBox ID="TextBox313" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox314" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox315" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox316" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox317" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox318" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox319" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox320" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox321" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox322" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox323" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox324" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>3</td>
                    <td><asp:TextBox ID="TextBox326" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox327" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox328" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox329" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox330" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox331" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox332" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox333" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox334" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox335" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox312" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox336" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>4</td>
                    <td><asp:TextBox ID="TextBox339" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox340" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox341" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox342" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox343" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox344" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox345" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox346" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox347" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox348" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox349" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox350" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>5</td>
                    <td><asp:TextBox ID="TextBox352" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox353" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox354" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox355" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox356" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox357" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox358" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox359" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox360" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox361" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox362" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox363" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="13">
                        <label>（此表为建筑类奖项填写，其它专业奖项可参照此表根据不同专业实际情况填写）</label>
                        <br />
                        <label>注：1. 排序应以承担工作为依据，主申报单位列在首位。合作单位签名盖章表的排序与此表排序相对应。</label>
                        <br />
                        <label>2. 在承担的栏中填写“√”，在未承担的栏中填写“×”，不应空白。</label>
                    </td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td colspan="5">合作单位（机构）签名盖章</td>
                </tr>
                <tr>
                    <td>1</td>
                    <td>2</td>
                    <td>3</td>
                    <td>4</td>
                    <td>5</td>
                </tr>
                <tr>
                    <td style="height:200px;">
                        <label>单位法定代表人（签名）：</label>
                        <br />
                        <br /><br /><br />
                        <label>（单位公章）</label>
                    </td>
                    <td>
                        <label>单位法定代表人（签名）：</label>
                        <br />
                        <br /><br /><br />
                        <label>（单位公章）</label>
                    </td>
                    <td>
                        <label>单位法定代表人（签名）：</label>
                        <br />
                       <br /><br /><br />
                        <label>（单位公章）</label>
                    </td>
                    <td>
                        <label>单位法定代表人（签名）：</label>
                        <br />
                    <br /><br /><br />
                        <label>（单位公章）</label>
                    </td>
                    <td>
                        <label>单位法定代表人（签名）：</label>
                        <br />
                       <br /><br /><br />
                        <label>（单位公章）</label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
</asp:Content>
