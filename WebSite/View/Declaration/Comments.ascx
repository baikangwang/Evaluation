<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Comments.ascx.cs" Inherits="Evaluation.View.Declaration.Comments" %>

<asp:Panel ID="panelComments" runat="server" GroupingText="评审意见">
    <div style="display:none;">
        <asp:TextBox ID="txtGrade" runat="server" ClientIDMode="Static"></asp:TextBox>
        <asp:TextBox ID="DeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox>
    </div>
    <table>
        <tr>
            <td colspan="4">
                评审意见
            </td> 
        </tr>
        <tr>
            <td colspan="4" style="border-bottom: none;">
                <p>评审意见填写人:<asp:Literal ID="txtReviewWriter" runat="server" ClientIDMode="Static"></asp:Literal></p>
                <asp:TextBox ID="FirstComment" runat="server" TextMode="MultiLine" ClientIDMode="Static" style="width:95%; height:350px;" data="Review"></asp:TextBox>
                <script id="FirstCommentTextBox" type="text/plain" style=" height: 300px;"></script>
            </td>
        </tr>
        <tr>
            <td style="width: 40%; border-top: none; border-right: none;">组长（签名）:
            </td>
            <td style="width: 10%; border-right: none; border-left: none; border-top: none;">
            </td>
            <td style="width: 40%; border-top: none; border-left: none; border-right: none;">评审日期:
            </td>
            <td style="width: 10%; border-top: none; border-left: none;">
            </td>
        </tr>
    </table>

    <div style="text-align: center; margin-top: 40px;">
        <a class="btnt up" id="CommentsPrev">上 一 步</a>
        <a class="btnt up" id="CommitComment" onclick="javascript:SetReviewComment();return false;" style="margin:0 20px;">提交评审</a>        
    </div>
</asp:Panel>
<script>
    function onSave(PartCode, Tip) {

        var result = [];
        $("[data='" + PartCode + "']").not("span").each(function () {
            if ($(this).attr("id") != null) {
                result.push({ Name: $(this).attr("id"), Value: $(this).val() });
            }
        });
        $.ajax({
            type: "post",
            url: "../Mutual/Declaration.ashx",
            data: {
                "Action": "Save",
                "PartCode": PartCode,
                "PageData": result,
                "DeclarationID":$('#DeclarationID').val(),
            },
            success: function (data, status) {
                if (data == "success" && Tip == 'Save') {
                    ShowMessag("已保存");
                }
            },
            error: function (data) {
                ShowMessag(data);
            },
        })
    }

    function SetReviewComment() {
        $.ajax({
            type: "post",
            url: "../Mutual/Declaration.ashx",
            data: {
                "Action": "SetReviewComment",
                "DeclarationID": $('#DeclarationID').val(),
                "ReviewComment": EncodeUEditorContent(UE.getEditor('FirstCommentTextBox').getContent()),
            },
            success: function (data) {
                if (data == "success") {
                    ShowMessag("已保存");
                }
            },
            error: function (data) {
                ShowMessag(data);
            },
        });
    }

    // 初始化富文本框
    function InitReviewComment(container, max) {
        var text = $("#" + container.replace("TextBox", ""));
        text.hide();

        var ue = UE.getEditor(container, {
            allHtmlEnabled: true,
            retainOnlyLabelPasted: true,
            pasteplain: true,
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

        ue.ready(function () {
            if (text.val() != "") {
                //设置编辑器的内容
                ue.setContent(DecodeUEditorContent(text.val()), false);
            }
        });
    }

    var Grade = $("#txtGrade").val();
    if (Grade == "Open") {
        $(".ExpertReviewList2").css("display", "block");
        $("#CertificateNext").css("display", "");
    }

    InitReviewComment('FirstCommentTextBox', 2000);

    </script>
