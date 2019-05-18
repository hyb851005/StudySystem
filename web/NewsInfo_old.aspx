<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="NewsInfo.aspx.cs" Inherits="NewsInfo" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <input type="hidden" runat="server" id="hf_uid" />
    <input type="hidden" runat="server" id="hf_id" />
    <input type="hidden" runat="server" id="hf_filetype" />


      <table width="100%" height="89%" border="0" cellspacing="0" cellpadding="0">		
		<tr valign="top"> 
			<td height="100%" colspan="3" bgcolor="#FFFFFF" class="l-r-space">
				<table width="100%" border="0" cellpadding="1" cellspacing="1" bgcolor="#009DE9">
					<tr>
						<td bgcolor="#FFFFFF" height="50" align="center" valign="middle">
							<asp:Label ID="lbTotalScore" runat="server" Font-Bold="true" ForeColor="Red">sss</asp:Label>
						</td>
					</tr>
					<tr>
						<td bgcolor="#FFFFFF">							
							<asp:GridView ID="gvQuestion" runat="server" AutoGenerateColumns="False" ShowHeader="False" SkinID="GridViewSkin" DataKeyNames="ID" OnRowDataBound="gvQuestion_RowDataBound" GridLines ="None">
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


    <table id="Table1" align="center" border="0" bordercolordark="#ffffff" bordercolorlight="#ffcf00"
        cellpadding="0" cellspacing="0" style="width: 100%">
        <tbody>
            <tr>
                <td align="center" bgcolor="rgb(210,232,255)" class="tabTitle" colspan="1" style="height: 30px;
                    line-height: 30px; font-weight: bold;">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right" bgcolor="rgb(210,232,255)" class="tabTitle" colspan="1" style="height: 30px;
                    line-height: 30px;">
                    更新日期：
                    <asp:Label ID="Label1" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>

            <tr>
                <td colspan="1" style="width: 921px; height: auto; text-align: left">
                     
                    <div id="DIV1" runat="server" style="height: auto; padding: 10px; line-height: 24px;">
                    </div>
                    <br />
                  <asp:Literal ID="litImg" runat="server"></asp:Literal>

                </td>
            </tr>
            
            
        <tr>
            <td align="right" bgcolor="rgb(210,232,255)" class="tabTitle" colspan="1" style="height: 30px;
                line-height: 30px; text-align: left;">
                <strong>会员评论</strong>
            </td>
        </tr>
        <tr>
            <td>
                <div style="margin: 5px;">
                    <table border="0" align="center" style="width: 617px">
                        <tr>
                            <td align="right" style="width: 534px">
                                <asp:TextBox ID="txtContent" TextMode="multiLine" runat="server" Height="83px" Width="514px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="Button3" runat="server" Text="立即留言" Height="53px" Width="60px" OnClick="Button3_Click" /><br />
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入"
                                    ControlToValidate="txtContent"></asp:RequiredFieldValidator>--%>
                            </td>
                        </tr>
                    </table>
                </div>
                
                <div style="line-height:20px;">
                            <asp:GridView ID="gvData" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" Width="612px" EmptyDataText="没有相关评论数据" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="gvData_RowDeleting" DataKeyNames="id">
                                <RowStyle BackColor="#EFF3FB" />
                                <Columns>
                                    <asp:TemplateField FooterText="username" HeaderText="用户"> 
                                        <ItemTemplate>
                                            会员:<asp:Label ID="Label1" runat="server" Text='<%#Eval("UserName") %>'></asp:Label>
                                            <asp:Label ID="labUserID" Visible="false" runat="server" Text='<%#Eval("userid") %>'></asp:Label>
                                            <asp:Label ID="labproid" Visible="false" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                                            <br />
                                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("sendtime") %>'></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle Width="180px"  HorizontalAlign="center"/>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="评论内容">
                                        <ItemTemplate>
                                        
                                    <%--      <asp:TextBox ID="TextBox1" runat="server" TextMode="multiLine" Height="60" Text='<%#Eval("Content") %>' ReadOnly="true"></asp:TextBox> 
                                          --%>
                                        <asp:Literal ID="lit_content" runat="server" Text='<%#Eval("sendmessage") %>'></asp:Literal> 
                                        </ItemTemplate> 
                                        <ItemStyle Width="600px" />
                                    </asp:TemplateField>
                                    <asp:TemplateField ShowHeader="False">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbtnDel" runat="server" Enabled="false" CausesValidation="False" CommandName="Delete"
                                                Text="删除" OnClientClick="return confirm('确定要删除吗？')"></asp:LinkButton>
                                        </ItemTemplate>
                                        <ItemStyle Width="80px" HorizontalAlign="Center" />
                                    </asp:TemplateField>
                                </Columns>
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <AlternatingRowStyle BackColor="White" />
                            </asp:GridView>
                            <br />
                            <br />
                        </div>
            </td>
        </tr>
        </tbody>
    </table>

</asp:Content>
