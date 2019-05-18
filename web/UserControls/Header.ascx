<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header.ascx.cs" Inherits="UserControls_Header" %>
<table width="100%" border="0" height="86" cellpadding="0" cellspacing="0" background='<%# Request.ApplicationPath + "/App_Themes/Default/Images/title_r1_c4.jpg" %>'>
	<tr>
		<td width="50%"><asp:Image ID="GucasImage" BorderWidth="0" runat="server" ImageUrl="~/App_Themes/Default/Images/title_r1_c1.jpg" /></td>
		<td width="18%"><asp:Image ID="Image1" BorderWidth="0" runat="server" ImageUrl="~/App_Themes/Default/Images/title_r1_c3.jpg" /></td>
		<td width="28%">&nbsp;</td>
		<td width="4%" align="right"><asp:Image BorderWidth="0" ID="Image2" runat="server" ImageUrl="~/App_Themes/Default/Images/title_r1_c5.jpg" /></td>
	</tr>
</table>