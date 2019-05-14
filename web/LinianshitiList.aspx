<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LinianshitiList.aspx.cs" Inherits="KeJianList" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td align="left" bgcolor="#fbfbfb" class="middle_border_1 margin_middle1" style="width: 661px">
             <div class="t_2"><a href="javascript:void(0);">多媒体课件</a></div>
                     <div style="clear: both;">
                        <table border="0" width="99%" cellspacing="5">
                            <tr>
                                <td>
                                    数据查询：<asp:TextBox ID="txtkey" runat="server"></asp:TextBox>
                                    <asp:Button ID="btn_search" runat="server" Text="搜索" 
                                        onclick="btn_search_Click" />
                                </td>
                                <td align="right">
                                    当前共
                                    <asp:Label ID="lab_all_count" runat="server" Text="0"></asp:Label>
                                    条数据记录
                                </td>
                            </tr>
                        </table>
                    </div>
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="1" RepeatDirection="Horizontal"
                    Width="682px">
                    <ItemTemplate>
                     <table id="Table1" runat="server" border="0" cellpadding="0" cellspacing="0" style="width:100%;">
                            <tr>
                                <td align="left" height="30" style="border-bottom:1px dashed #FF9966; width:380px;">
                                    <li style="left: 0px; top: 0px">
                                    &nbsp;&nbsp;
                                    <a href='<%#Eval("id","FileInfo.aspx?id={0}")%>'>
                                        <%#Eval("TitleName").ToString().Length > 25 ? CutChar(Eval("TitleName").ToString(), 32) + "..." : Eval("TitleName")%>
                                    </a>
                                    </li>
                                </td>
                                <td align="center" height="30" style="border-bottom:1px dashed #FF9966; width:120px; text-align:center;">
                                    <asp:Label ID="Label2" runat="server" Height="20px" Text='<%# DataBinder.Eval(Container, "DataItem.Addtime") %>'
                                        Width="193px"></asp:Label> 
                                </td>
                            </tr>
                        </table> 
                    </ItemTemplate>
                </asp:DataList></td>
        </tr>
            <tr runat="server" visible="false" id="trFenye">
            <td align="center" bgcolor="#fbfbfb" class="middle_border_1 margin_middle1" style="width: 661px;
                height: 38px">
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
    </table>
</asp:Content>

