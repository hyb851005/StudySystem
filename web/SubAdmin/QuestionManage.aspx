<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuestionManage.aspx.cs" Inherits="Admin_QuestionManage" StyleSheetTheme="Default" %>
<%@ Register Src="../UserControls/TitleUC.ascx" TagName="TitleUC" TagPrefix="ucTitle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>考题管理</title>
</head>
<body background="../App_Themes/Default/Images/l_b_bg.jpg" class="body">
	<form id="form2" runat="server">
	<ucTitle:TitleUC ID="TitleUC1" runat="server" Title="考题管理" />
    <table width="100%" height="89%" border="0" cellspacing="0" cellpadding="0">		
		<tr valign="top"> 
			<td height="100%" colspan="3" bgcolor="#FFFFFF" class="l-r-space">
				<table width="100%" border="0" cellpadding="1" cellspacing="1" bgcolor="#009DE9">
					<tr>
						<td bgcolor="#FFFFFF">
							<table class="Table" cellpadding="2" cellspacing="0" border="0">									
								<tr>
									<td width="120" valign="middle" class="LeftTD" align="right">
										请选择考试科目:</td>
									<td valign="middle"><asp:DropDownList ID="ddlSubject" runat="server" 
											SkinID="ddlSkin" onselectedindexchanged="ddlSubject_SelectedIndexChanged"></asp:DropDownList></td>
								</tr>								
								<tr>
									<td width="120" valign="top" class="LeftTD" align="right">
										考题:</td>
									<td valign="middle">
										<asp:GridView ID="gvQuestion" runat="server" SkinID="GridViewSkin" 
											onrowcommand="gvQuestion_RowCommand" onrowdatabound="gvQuestion_RowDataBound">
											<Columns>
												<asp:TemplateField HeaderText="序号" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="6%" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black">
													<ItemTemplate>
														<asp:Label ID="lbIndex" runat="server"></asp:Label>
													</ItemTemplate>
												</asp:TemplateField>
												<asp:TemplateField HeaderText="考题内容" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="64%" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black">
													<ItemTemplate>
														<%# Eval("Title") %>
													</ItemTemplate>
												</asp:TemplateField>
												<asp:TemplateField HeaderText="分值" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black">
													<ItemTemplate>
														<%# Eval("Score") %>
													</ItemTemplate>
												</asp:TemplateField>
												<asp:TemplateField HeaderText="答案" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black">
													<ItemTemplate>
														<%# Eval("Answer") %>
													</ItemTemplate>
												</asp:TemplateField>
												<asp:TemplateField HeaderText="操作" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black">
													<ItemTemplate>
														<asp:ImageButton ID="ibtUpdate" runat="server" CommandName="edit" CommandArgument='<%# Eval("ID") %>' ImageUrl="~/App_Themes/Default/Images/edit.gif" />&nbsp;&nbsp;<asp:ImageButton ID="ibtDelete" runat="server" CommandName="del" CommandArgument='<%# Eval("ID") %>' ImageUrl="~/App_Themes/Default/Images/delete.gif" />
													</ItemTemplate>
												</asp:TemplateField>
											</Columns>
										</asp:GridView>
									</td>
								</tr>
								<tr>
									<td width="120" height="30" valign="middle" class="LeftTD" align="right">
										<asp:Label ID="Label1" runat="server" Width="60"></asp:Label></td>
									<td valign="middle">
										<asp:ImageButton ID="ibtAdd" runat="server" 
											ImageUrl="~/App_Themes/Default/Images/badd.gif" onclick="ibtAdd_Click" />
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


