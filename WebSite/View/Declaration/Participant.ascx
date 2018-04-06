<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Participant.ascx.cs" Inherits="Evaluation.View.Declaration.Participant" %>

<style>
    #ContentPlaceHolder1_ucParticipant_tblParticipant .ms-parent {
    width:100px !important;
    height:25px!important;
    margin-bottom:3px;
}
   .ms-parent input {
    width:20%!important;
}
   input::-ms-clear{display:none;}
</style>
   <asp:Panel ID="panelParticipant" runat="server" GroupingText="在本项目中做出贡献的主要人员情况表">
        <table runat="server" id="tblParticipant" style="width:90%">
            <tr>
                <td style="width: 100px;">序 号</td>
                <td >姓名</td>
                <td >职称</td>
                <td >专业</td>
                <td>设计职务及设计中<br />主要负责何项工作</td>
                <td style="width:13%;">证件类别</td>
                <td>证件号</td>
                <td>工作单位</td>
            </tr>
            <tr>
                <td>1</td>
                <td>
                    <asp:TextBox ID="ParticipantName1" runat="server" ClientIDMode="Static" onblur="NameNumber('1')"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle1" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality1" runat="server" ClientIDMode="Static" ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties1" runat="server" ClientIDMode="Static" ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType1" ClientIDMode="Static"></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType1" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber1" runat="server" ClientIDMode="Static" onblur="PeopleNumber('1')"></asp:TextBox><span ID="IDNumberSpan1"></span></td>
                <td>
                    <asp:TextBox ID="Workplace1" runat="server" ClientIDMode="Static"></asp:TextBox></td>
            </tr>
            <tr>
                <td>2</td>
                <td>
                    <asp:TextBox ID="ParticipantName2" runat="server" ClientIDMode="Static" onblur="NameNumber('2')"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle2" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality2" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties2" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType2" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType2" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber2" runat="server" ClientIDMode="Static" onblur="PeopleNumber('2')"></asp:TextBox><span ID="IDNumberSpan2"></span></td>
                <td>
                    <asp:TextBox ID="Workplace2" runat="server" ClientIDMode="Static"></asp:TextBox></td>
            </tr>
            <tr>
                <td>3</td>
                <td>
                    <asp:TextBox ID="ParticipantName3" runat="server" ClientIDMode="Static" onblur="NameNumber('3')"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle3" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality3" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties3" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType3" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType3" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber3" runat="server" ClientIDMode="Static" onblur="PeopleNumber('3')"></asp:TextBox><span ID="IDNumberSpan3"></span></td>
                <td>
                    <asp:TextBox ID="Workplace3" runat="server" ClientIDMode="Static"></asp:TextBox></td>
            </tr>
            <tr>
                <td>4</td>
                <td>
                    <asp:TextBox ID="ParticipantName4" runat="server" ClientIDMode="Static" onblur="NameNumber('4')"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle4" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality4" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties4" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType4" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType4" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td> 
                <td>
                    <asp:TextBox ID="IDNumber4" runat="server" ClientIDMode="Static"  onblur="PeopleNumber('4')"></asp:TextBox><span ID="IDNumberSpan4"></span></td>
                <td>
                    <asp:TextBox ID="Workplace4" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>5</td>
                <td>
                    <asp:TextBox ID="ParticipantName5" runat="server" ClientIDMode="Static" onblur="NameNumber('5')" ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle5" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality5" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties5" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType5" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType5" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td> 
                <td>
                    <asp:TextBox ID="IDNumber5" runat="server" ClientIDMode="Static"  onblur="PeopleNumber('5')"></asp:TextBox><span ID="IDNumberSpan5"></span></td>
                <td>
                    <asp:TextBox ID="Workplace5" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>6</td>
                <td>
                    <asp:TextBox ID="ParticipantName6" runat="server" ClientIDMode="Static" onblur="NameNumber('6')" ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle6" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality6" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties6" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType6" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType6" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber6" runat="server" ClientIDMode="Static"  onblur="PeopleNumber('6')"></asp:TextBox><span ID="IDNumberSpan6"></span></td>
                <td>
                    <asp:TextBox ID="Workplace6" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>7</td>
                <td>
                    <asp:TextBox ID="ParticipantName7" runat="server" ClientIDMode="Static" onblur="NameNumber('7')" ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle7" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality7" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties7" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType7" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType7" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber7" runat="server" ClientIDMode="Static" onblur="PeopleNumber('7')" ></asp:TextBox><span ID="IDNumberSpan7"></span></td>
                <td>
                    <asp:TextBox ID="Workplace7" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>8</td>
                <td>
                    <asp:TextBox ID="ParticipantName8" runat="server" ClientIDMode="Static" onblur="NameNumber('8')" ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle8" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality8" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties8" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType8" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType8" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber8" runat="server" ClientIDMode="Static" onblur="PeopleNumber('8')" ></asp:TextBox><span ID="IDNumberSpan8"></span></td>
                <td>
                    <asp:TextBox ID="Workplace8" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>9</td>
                <td>
                    <asp:TextBox ID="ParticipantName9" runat="server" ClientIDMode="Static" onblur="NameNumber('9')" ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle9" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality9" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties9" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType9" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType9" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber9" runat="server" ClientIDMode="Static" onblur="PeopleNumber('9')" ></asp:TextBox><span ID="IDNumberSpan9"></span></td>
                <td>
                    <asp:TextBox ID="Workplace9" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>10</td>
                <td>
                    <asp:TextBox ID="ParticipantName10" runat="server" ClientIDMode="Static" onblur="NameNumber('10')" ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle10" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality10" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties10" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType10" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType10" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber10" runat="server" ClientIDMode="Static" onblur="PeopleNumber('10')" ></asp:TextBox><span ID="IDNumberSpan10"></span></td>
                <td>
                    <asp:TextBox ID="Workplace10" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>11</td>
                <td>
                    <asp:TextBox ID="ParticipantName11" runat="server" ClientIDMode="Static" onblur="NameNumber('11')" ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle11" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality11" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties11" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType11" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType11" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber11" runat="server" ClientIDMode="Static"  onblur="PeopleNumber('11')"></asp:TextBox><span ID="IDNumberSpan11"></span></td>
                <td>
                    <asp:TextBox ID="Workplace11" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>12</td>
                <td>
                    <asp:TextBox ID="ParticipantName12" runat="server" ClientIDMode="Static" onblur="NameNumber('12')" ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle12" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality12" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties12" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType12" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType12" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber12" runat="server" ClientIDMode="Static" onblur="PeopleNumber('12')" ></asp:TextBox><span ID="IDNumberSpan12"></span></td>
                <td>
                    <asp:TextBox ID="Workplace12" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>13</td>
                <td>
                    <asp:TextBox ID="ParticipantName13" runat="server" ClientIDMode="Static"  onblur="NameNumber('13')"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle13" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality13" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties13" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType13" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType13" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber13" runat="server" ClientIDMode="Static" onblur="PeopleNumber('13')" ></asp:TextBox><span ID="IDNumberSpan13"></span></td>
                <td>
                    <asp:TextBox ID="Workplace13" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>14</td>
                <td>
                    <asp:TextBox ID="ParticipantName14" runat="server" ClientIDMode="Static" onblur="NameNumber('14')" ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle14" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality14" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties14" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType14" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType14" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber14" runat="server" ClientIDMode="Static" onblur="PeopleNumber('14')" ></asp:TextBox><span ID="IDNumberSpan14"></span></td>
                <td>
                    <asp:TextBox ID="Workplace14" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>15</td>
                <td>
                    <asp:TextBox ID="ParticipantName15" runat="server" ClientIDMode="Static" onblur="NameNumber('15')" ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="AcademicTitle15" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Speciality15" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="Duties15" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
                <td>
                    <div class="DeclarationList"><asp:DropDownList runat="server" ID="IDType15" ClientIDMode="Static" ></asp:DropDownList></div>
                    <div class="ExpertReviewList" style="display:none"><asp:TextBox ID="txtIDType15" runat="server" ClientIDMode="Static" ></asp:TextBox></div>
                </td>
                <td>
                    <asp:TextBox ID="IDNumber15" runat="server" ClientIDMode="Static"  onblur="PeopleNumber('15')"></asp:TextBox><span ID="IDNumberSpan15"></span></td>
                <td>
                    <asp:TextBox ID="Workplace15" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            </tr>

        </table>
       <br />
       <p style="margin:0 0 0 58px;">
           注：<br />
           1、主要设计人员排序按照设计中所起作用的原则，不按技术职务职称；<br />
           2、境外设计人员可不填写此表；<br />
           3、项目人员总数原则上不超过<asp:Label ID="PeopleNum" runat="server" ClientIDMode="Static"></asp:Label>人。
       </p> 
       <%--<div style="display:none"><a onclick="javascript:onSave('Participant')" id="Save_Participant">保存</a></div> --%>
       <div style="display:none"><a onclick="javascript:onSave('Participant')">保存</a></div> 
       <div style="text-align: center; margin-top: 40px;">
           <a onclick="javascript:onSave('Participant','Save')" class="btnt">保&nbsp; &nbsp; 存</a>
           <a onclick="javascript:onPrev('02')" href="#tab_03" class="btnt up" style="margin-left: 20px;">上 一 步</a>
           <a onclick="javascript:onNext('02')" href="#tab_03" class="btnt up" style="margin:0 20px;">下 一 步</a>          
       </div>
    </asp:Panel>


<script>
    $(function () {
        $('.ms-parent input').css({ 'margin-left': '' });
        var PeopleNum = Number($('#PeopleNum').text());
        for (var i = 1; i <= $('#ContentPlaceHolder1_ucParticipant_tblParticipant tr').length ; i++) {           
            if (i > PeopleNum) {
                $('#ContentPlaceHolder1_ucParticipant_tblParticipant tr').eq(i).hide();               
            }
        }
    });
    $("#ContentPlaceHolder1_ucParticipant_panelParticipant select").multipleSelect({
        single: true
    });

    //身份证验证
    function PeopleNumber(ID) {
        if ($("#ParticipantName" + ID).val().length != 0 && $("#IDType" + ID).find("option:selected").text() == "身份证") {
            if ($("#IDNumber" + ID).val().length != 18) {
                if ($("#IDNumberSpan" + ID).val() != "*") {
                    ShowMessag("您输入的身份证号不正确！");
                    $("#IDNumber" + ID).focus();
                    $("#IDNumber" + ID).css("border-color", "red");
                    $("#IDNumberSpan" + ID).val("*");
                }
            }
            else {
                $("#IDNumber" + ID).css("border-color", "");
                $("#IDNumberSpan" + ID).val("");
            }
        }
    }

    function NameNumber(AD) {
        if ($("#ParticipantName" + AD).val() != "") {
            $("#IDNumber" + AD).attr('disabled', false);
        }
        else {
            $("#IDNumber" + AD).css("border-color", "");
            $("#IDNumberSpan" + AD).val("");
            $("#IDNumber" + AD).attr('disabled', true);
            $("#IDNumber" + AD).val("");

            $("#AcademicTitle" + AD).val("");
            $("#Speciality" + AD).val("");
            $("#Duties" + AD).val("");
            $("#IDType" + AD).find("option:selected").val("0901");
            $("#Workplace" + AD).val("");
            $("#IDNumberSpan" + AD).val("");
        }
    }
</script>