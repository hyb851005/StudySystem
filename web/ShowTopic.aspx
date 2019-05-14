<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowTopic.aspx.cs" ValidateRequest="false" EnableEventValidation="false"    Inherits="ShowTopic" Title="Untitled Page" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div class="t_2"><a href="javascript:void(0);">在线交流社区</a></div>
    <table style="width: 100%" cellpadding="0" cellspacing="0">
        <tr>
            <td align="left" style=" font-weight:bold;border-bottom: #f8cba9 1px solid; border-left: #ee9119 1px solid;border-right: #ee9119 1px solid;border-top: #ee9119 1px solid;background-color:#efefef; text-align: left; height: 40px;">
              &nbsp;&nbsp;  主题：<asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align:right; background-color:#efefef;border-left: #ee9119 1px solid;border-right: #ee9119 1px solid;">
                发帖人：<asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                发帖时间：<asp:Label ID="Label2" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="text-align: left; background-color:#efefef; padding:10px;border-left: #ee9119 1px solid;border-right: #ee9119 1px solid;border-bottom: #ee9119 1px solid;">
               <asp:Label ID="Label3" runat="server"></asp:Label>
               <br />
               <br />
            </td>
        </tr>
        <tr>
        <td><br /></td>
        </tr>
        <tr>
            <td style=" text-align: left;" align="left" valign="top">
                <asp:DataList ID="DataList1" runat="server" Width="100%">
                    <ItemTemplate>
                        <table style="width: 100%">
                            <tr>
                                <td style="width: 100%;background-color:#efefef; line-height:30px;">
                                <div style="float:left;">
                                    &nbsp;&nbsp;姓名：<%#Eval("ReplayUser") %></div>
                                <div style="float:right;">
                                    回复时间：<%#Eval("AddTime","{0:d}") %>&nbsp;&nbsp;
                                </div>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 100%; padding:10px; line-height:20px;">
                                    回复内容：<%#Eval("Replay") %></td>
                            </tr> 
                        </table>
                        <hr />
                    </ItemTemplate>
                </asp:DataList></td>
        </tr>
            <tr runat="server" visible="false" id="trFenye">
            <td align="center"  valign="top">
                共【<asp:Label ID="lblSumPage" runat="server"></asp:Label>】页 &nbsp; &nbsp; &nbsp;
                当前第【<asp:Label ID="lblCurrentPage" runat="server"></asp:Label>】页&nbsp;
                <asp:HyperLink ID="hyfirst" runat="server">首页</asp:HyperLink>
                &nbsp; &nbsp; &nbsp;<asp:HyperLink ID="lnkPrev" runat="server">上一页</asp:HyperLink>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                <asp:HyperLink ID="lnkNext" runat="server">下一页</asp:HyperLink>
                &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                <asp:HyperLink ID="hylastpage" runat="server">尾页</asp:HyperLink>
            </td>
        </tr>
        <tr>
        <td><br /></td>
        </tr>
        <tr>
        <td style=" background-color:#f8cba9; height:30px; line-height:30px; font-weight:bold;">&nbsp;&nbsp;我要回复</td>
        </tr>
        <tr>
            <td style=" text-align: left; " align="left" valign="top">
                <FCKeditorV2:FCKeditor ID="ArticleContent" runat="server" BasePath="~/FCKeditor/" Height="300px">
                    &nbsp;</FCKeditorV2:FCKeditor>
            </td>
        </tr>
        <tr>
            <td align="center" valign="top">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="回复" /></td>
        </tr>
    </table>
</asp:Content>

