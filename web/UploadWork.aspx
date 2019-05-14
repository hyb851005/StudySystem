<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UploadWork.aspx.cs" Inherits="UploadWork" Title="Untitled Page" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="t_2">
        <a href="javascript:void(0);">用户中心 > 上传练习题 </a>
    </div>
     
       <input type="hidden" runat="server" id="hf_uid" />
        <div>
            <table width="98%" border="0" cellpadding="0" cellspacing="1" bgcolor="#e3ebfe" align="center">
                <tr>
                    <td height="26">
                        <table width="98%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td align="center" style="height: 22px">
                                    上传我的练习题</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        <table align="center" bgcolor="#e3ebfe" border="0" cellpadding="2" cellspacing="1"
            style="margin-top: 8px" width="98%">
            <tr>
                <td style="width: 100px; height: 21px" class="td2" align="center">
                    练习题名称：</td>
                <td style="height: 21px" class="td2" colspan="3">
                    <asp:DropDownList ID="ddlWorkList" runat="server">
                    </asp:DropDownList> 
                </td>
            </tr>
            <tr>
                <td align="center" class="td2" style="height: 21px">
                    上传练习题要求：</td>
                <td align="left" class="td2" colspan="3" style="height: 21px">
                    <div>
                        请选择文件：
                        <input id="file1" runat="server" class="inputBox" type="file" /><asp:Button ID="Button2"
                            runat="server" CausesValidation="False" CssClass="formbutton" OnClick="Button1_Click"
                            Text="上传" /><asp:Label ID="Label1" runat="server" Visible="False"></asp:Label><input
                                id="Hidden1" runat="server" type="hidden" />
                    </div>
                    <div>
                        上传文件名：
                        <asp:TextBox ID="pic" runat="server" CssClass="inputBox" ReadOnly="True"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="pic"
                            ErrorMessage="请上传文件"></asp:RequiredFieldValidator>
                        （注：上传浏览文件后自动生成文件名称，不需要填写此项）
                    </div>
                </td>
            </tr>
            <tr>
                <td style="height: 54px" class="td2" align="center">
                    练习题说明：</td>
                <td style="height: 54px" class="td2" colspan="7">
                    <FCKeditorV2:FCKeditor ID="ArticleContent" runat="server" Height="400" BasePath="~/FCKeditor/">
                        &nbsp;</FCKeditorV2:FCKeditor>
                </td>
            </tr>
            <tr bgcolor="#e7e7e7">
                <td align="center" colspan="10" height="24">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="添加" /></td>
            </tr>
        </table>
</asp:Content>


