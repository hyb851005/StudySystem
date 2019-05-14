<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PageDown.ascx.cs" Inherits="PageDown" %>
<div class="foot w_980">
    <div class="footmenu">
    </div>
    <p style="font-size: 14px; text-align: center;">
        版权所有： &nbsp;&nbsp;
        <%=SystemMgr .BLL.Common.GetWebTitle() %>
        &nbsp;&nbsp;&nbsp;&nbsp; <a href="Admin/Login.aspx" target="_blank">后台入口</a>
    </p>
</div>
