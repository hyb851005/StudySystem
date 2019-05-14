<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Play.aspx.cs" Inherits="Play" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table id="Table1" align="center" border="0" bordercolordark="#ffffff" bordercolorlight="#ffcf00"
        cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td colspan="1" style="width: 822px; height: 38px; text-align: left">
             <%=PlayMedia() %></td>
        </tr>
    </table>
</asp:Content>

