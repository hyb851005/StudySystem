<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="BBS.aspx.cs" Inherits="BBS" Title="Untitled Page" %>

<%@ Register Src="PageCtrl.ascx" TagName="PageCtrl" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="t_2">
        <a href="javascript:void(0);">在线交流社区</a></div>
    <table style="width: 100%;">
        <tr>
            <td style="height: 24px" align="right">
                &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">发布信息</asp:LinkButton></td>
        </tr>
        <tr>
            <td style="text-align: left; height: 376px;" valign="top" align="left">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    DataSourceID="SqlDataSource1" EmptyDataText="暂无信息" PageSize="20" ForeColor="#333333"
                    GridLines="None">
                    <Columns>
                        <asp:TemplateField HeaderText="序号">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1%>
                            </ItemTemplate>
                            <HeaderStyle Height="30px" Width="60px" HorizontalAlign="center" />
                            <ItemStyle Height="30px" Width="60px" HorizontalAlign="center" />
                        </asp:TemplateField>
                        <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="ShowTopic.aspx?id={0}"
                            DataTextField="Topic" HeaderText="标题">
                            <HeaderStyle Height="30px" Width="400px" />
                            <ItemStyle Height="30px" Width="400px" />
                        </asp:HyperLinkField>
                        <asp:BoundField DataField="AddUser" HeaderText="发帖者">
                            <HeaderStyle Height="30px" Width="100px" HorizontalAlign="center" />
                            <ItemStyle Height="30px" Width="100px" HorizontalAlign="center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Addtime" DataFormatString="{0:d}" HeaderText="时间">
                            <HeaderStyle Height="30px" Width="120px" HorizontalAlign="center" />
                            <ItemStyle Height="30px" Width="120px" HorizontalAlign="center" />
                        </asp:BoundField>
                    </Columns>
                    <RowStyle BackColor="#E3EAEB" />
                    <FooterStyle BackColor="#ed7906" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#ed7906" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>">
                </asp:SqlDataSource>
                <uc1:PageCtrl ID="PageCtrl1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
