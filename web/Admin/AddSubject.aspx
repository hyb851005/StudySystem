<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddSubject.aspx.cs" Inherits="Admin_AddQuestion" StyleSheetTheme="Default" %>
<%@ Register Src="../UserControls/TitleUC.ascx" TagName="TitleUC" TagPrefix="ucTitle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>添加考题</title>
</head>
<body background="../App_Themes/Default/Images/l_b_bg.jpg" class="body">
	<form id="form2" runat="server">
	<ucTitle:TitleUC ID="TitleUC1" runat="server" Title="添加考题" />
    <table width="100%" height="89%" border="0" cellspacing="0" cellpadding="0">		
		<tr valign="top"> 
			<td height="100%" colspan="3" bgcolor="#FFFFFF" class="l-r-space">
				<table width="100%" border="0" cellpadding="1" cellspacing="1" bgcolor="#009DE9">
					<tr>
						<td bgcolor="#FFFFFF">
							<table class="Table" cellpadding="2" cellspacing="0" border="0">									
								<tr>
									<td width="120" valign="top" class="LeftTD" align="right">
										试题库名:</td>
									<td valign="middle">
										<asp:TextBox ID="tbTitle" runat="server" TextMode="MultiLine" 
											Height="150px" Width="100%"></asp:TextBox>
									</td>
								</tr>
								<%--<tr>
									<td width="120" valign="middle" class="LeftTD" align="right">
										分值:</td>
									<td valign="middle"><asp:TextBox ID="tbScore" runat="server"></asp:TextBox></td>
								</tr>	
								<tr>
									<td width="120" valign="middle" class="LeftTD" align="right">
										正确答案:</td>
									<td valign="middle"><asp:DropDownList ID="ddlAnswer" runat="server" SkinID="ddlSkin">
										<asp:ListItem>A</asp:ListItem>
										<asp:ListItem>B</asp:ListItem>
										<asp:ListItem>C</asp:ListItem>
										<asp:ListItem>D</asp:ListItem>
										</asp:DropDownList></td>
								</tr>	
								<tr>
									<td width="120" valign="top" class="LeftTD" align="right">
										答案A:</td>
									<td valign="middle">
										<asp:TextBox ID="tbAnswerA" runat="server" TextMode="MultiLine" 
											Height="50px" Width="100%"></asp:TextBox>
									</td>
								</tr>
								<tr>
									<td width="120" valign="top" class="LeftTD" align="right">
										答案B:</td>
									<td valign="middle">
										<asp:TextBox ID="tbAnswerB" runat="server" TextMode="MultiLine" 
											Height="50px" Width="100%"></asp:TextBox>
									</td>
								</tr>
								<tr>
									<td width="120" valign="top" class="LeftTD" align="right">
										答案C:</td>
									<td valign="middle">
										<asp:TextBox ID="tbAnswerC" runat="server" TextMode="MultiLine" 
											Height="50px" Width="100%"></asp:TextBox>
									</td>
								</tr>
								<tr>
									<td width="120" valign="top" class="LeftTD" align="right">
										答案D:</td>
									<td valign="middle">
										<asp:TextBox ID="tbAnswerD" runat="server" TextMode="MultiLine" 
											Height="50px" Width="100%"></asp:TextBox>
									</td>
								</tr>--%>
								<tr>
									<td width="120" height="30" valign="middle" class="LeftTD" align="right">
										<asp:Label ID="Label1" runat="server" Width="60"></asp:Label></td>
									<td valign="middle">
										<asp:ImageButton ID="ibtCommit" runat="server" 
											ImageUrl="~/App_Themes/Default/Images/bcommit.gif" onclick="ibtCommit_Click" />
									</td>
								</tr>
							</table>    
						</td>
					</tr>
				</table>
			</td>
		</tr>		
    </table>    
    </form>
</body>
</html>

