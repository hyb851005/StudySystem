<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddTopic.aspx.cs"  ValidateRequest="false" EnableEventValidation="false"  Inherits="AddTopic" Title="Untitled Page" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td align="left" height="40" style="border-bottom: #339933 double; text-align: left">
                主题：<asp:TextBox ID="tb_title" runat="server" MaxLength="100" Rows="1" Width="493px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="color: #999999; border-bottom: #cccccc 1px dashed; text-align: center">
                内容</td>
        </tr>
        <tr>
            <td style="height: 161px" valign="top">
                <FCKeditorV2:FCKeditor ID="ArticleContent" runat="server" BasePath="~/FCKeditor/" Height="300px">
                    &nbsp;</FCKeditorV2:FCKeditor>
            </td>
        </tr>
        <tr>
            <td align="center" valign="top">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="发布" />&nbsp;</td>
        </tr>
    </table>
</asp:Content>

