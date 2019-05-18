<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Examine.aspx.cs" Inherits="Examine" StylesheetTheme="Default" %>
<%@ Register Src="UserControls/TitleUC.ascx" TagName="TitleUC" TagPrefix="ucTitle" %>

<!DOCTYPE html PUBLIC "-//W3C//Dtd XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/Dtd/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>在线考试页面</title>    
</head>
<body background="App_Themes/Default/Images/l_b_bg.jpg" class="body">
	<form id="form2" runat="server">
	<ucTitle:TitleUC ID="TitleUC1" runat="server" Title="在线考试页面" />
    <table width="100%" height="89%" border="0" cellspacing="0" cellpadding="0">		
		<tr valign="top"> 
			<td height="100%" colspan="3" bgcolor="#FFFFFF" class="l-r-space">
				<table width="100%" border="0" cellpadding="1" cellspacing="1" bgcolor="#009DE9">
					<tr>
						<td bgcolor="#FFFFFF" height="50" align="center" valign="middle">
							<asp:Label ID="lbTotalScore" runat="server" Font-Bold="true" ForeColor="Red"></asp:Label>
						</td>
					</tr>
					<tr>
						<td bgcolor="#FFFFFF">							
							<asp:GridView ID="gvQuestion" runat="server" AutoGenerateColumns="False" ShowHeader="False" SkinID="GridViewSkin" DataKeyNames="ID" OnRowDataBound="gvQuestion_RowDataBound">
								<Columns>
									<asp:TemplateField>
										<ItemTemplate>
											<asp:Label ID="lbIndex" runat="server"></asp:Label>．<%# Eval("Title") %><br />
											<asp:RadioButtonList ID="rblAnswer" runat="server" RepeatDirection="Vertical"></asp:RadioButtonList>
											<hr />
										</ItemTemplate>
									</asp:TemplateField>
								</Columns>
							</asp:GridView>
						</td>
					</tr>
					<tr>
						<td bgcolor="#FFFFFF" align="center" height="50" valign="middle"><asp:ImageButton ID="ibtCommit" runat="server" ImageUrl="~/App_Themes/Default/Images/bcommit.gif" AlternateText="提交" OnClick="ibtCommit_Click" />
						</td>
					</tr>
				</table>
			</td>
		</tr>		
    </table>    
    </form>
</body>
</html>
