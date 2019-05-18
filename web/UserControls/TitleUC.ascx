<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TitleUC.ascx.cs" Inherits="UserControls_TitleUC" %>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
	<tr> 
		<td width="4" height="4" align="left" valign="top" bgcolor="#FFFFFF"><asp:Image ID="ibgl" runat="server" ImageUrl="~/App_Themes/Default/Images/l_r_jiao1.gif" width="4" height="4" /></td>
		<td width="10000" height="4" align="left" bgcolor="#FFFFFF"><asp:Image ID="ibgc" runat="server" ImageUrl="~/App_Themes/Default/Images/tm.gif" width="1" height="4" /></td>
		<td width="4" height="4" align="right" valign="top" bgcolor="#FFFFFF"><asp:Image ID="ibgr" runat="server" ImageUrl="~/App_Themes/Default/Images/l_r_jiao2.gif" width="4" height="4" /></td>
	</tr>
	<tr valign="top"> 
		<td colspan="3" bgcolor="#FFFFFF" class="l-r-space">
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr> 
					<td width="5"><asp:Image ID="ibgtl" runat="server" ImageUrl="~/App_Themes/Default/Images/left_annu.gif" width="5" height="23" /></td>
					<td background='<%# Request.ApplicationPath + "/App_Themes/Default/Images/c_annu.gif" %>' class="l-r-lm">　<asp:Image ID="ibgtc" runat="server" ImageUrl="~/App_Themes/Default/Images/l_r_tb1.gif" width="14" height="12" align="absbottom" />　<%=title %></td>
					<td width="30" background='<%# Request.ApplicationPath + "/App_Themes/Default/Images/c_annu.gif" %>' class="l-r-lm"></td>
					<td width="5"><asp:Image ID="ibgtr" runat="server" ImageUrl="~/App_Themes/Default/Images/right_annu.gif" width="5" height="23" /></td>
				</tr>
			</table>
		</td>
	</tr>
</table>