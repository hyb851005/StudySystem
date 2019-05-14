<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowVideo.aspx.cs" Inherits="ShowVideo" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table id="Table1" align="center" border="0" bordercolordark="#ffffff" bordercolorlight="#ffcf00"
        cellpadding="0" cellspacing="0" style="width: 100%">
           <tr>
            <td align="center" bgcolor="rgb(210,232,255)" class="tabTitle" colspan="1" style="height:30px; line-height:30px; font-weight:bold;"> 
                    <asp:Label ID="Label2" runat="server" ></asp:Label>
                    </td>
        </tr>
        <tr>
            <td align="right" bgcolor="rgb(210,232,255)" class="tabTitle" colspan="1" style="height:30px; line-height:30px;">
              更新日期：  <asp:Label ID="Label1" runat="server" ></asp:Label>  &nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">下载视频</asp:LinkButton>
                      &nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton  ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">播放视频</asp:LinkButton>
                 
                <input
                    id="Hidden1" runat="server" type="hidden" /><input id="Hidden2" runat="server" type="hidden" /><input
                        id="Hidden3" runat="server" type="hidden" />
                           &nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
        </tr>
        <tr>
             <td colspan="1" style="width: 921px; height: auto; text-align: left"> 
                    <div id="DIV1" runat="server" style="height: auto; padding:10px; line-height:24px;">
                    </div> 
            </td>
        </tr>
    </table>
</asp:Content>

