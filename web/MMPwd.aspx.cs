﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class MMPwd : System.Web.UI.Page
{
    Alert alert = new Alert();
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //验证是否登录状态
            try
            {
                if (!(Session["UserId"] != null && Session["UserName"] != null && Session["roule"] != null))
                {
                    Response.Redirect("Default.aspx");
                }

            }
            catch (Exception ex)
            {

            }

            //if (Session["UserId"] == null)
            //{
            //    Alert.AlertAndRedirect("对不起您还没有登录", "Default.aspx");
            //}
            //else
            //{ }


        }
    }/// <summary>
    /// 修改密码
    /// </summary>
    private void UPpwd()
    {
        SystemMgr.BLL.Common mydata = new SystemMgr.BLL.Common();
        string Username = Session["UserId"].ToString();
        try
        {
            string sql = "update [Users]  set [pwd] ='" + txtpwd2.Text.ToString() + "' where [id]='" + Username + "' ";
             bool b = SystemMgr.BLL.Common.RunSqlBool(sql);



            LabelWarningMessage.Text = "修改成功！";


        }
        catch
        {

            LabelWarningMessage.Text = "修改失败！";
        }
    }
    /// <summary>
    /// 检验原来的密码
    /// </summary>
    private void chkpwd()
    {
        SqlDataReader dr;
        dr = SystemMgr.BLL.Common.GetDataReader("select * from  Users  where id='" + Session["UserId"].ToString() + "' and pwd='" + txtpwd1.Text + "'");
        if (dr.Read())
        {
            UPpwd();
        }
        else
        {
            LabelWarningMessage.Text = "原密码不正确！";
        }

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        chkpwd();
    }
}
