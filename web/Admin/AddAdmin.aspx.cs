using System;
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
public partial class Admin_AddAdmin : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Admin"] == null)
        {
            Response.Write("<script language='javascript'>alert('您还没有登陆');top.location.href='login.aspx'</script>");
            Response.End();
        }
        else
        {

        }
    }

    //添加帐号
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //验证输入
        if (txtname.Text.Trim() == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请输入用户名称');</script>");
            txtname.Focus();
            return;
        }
        if (txtpwd.Text.Trim() == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请输入登录密码');</script>");
            txtpwd.Focus();
            return;
        }

        try
        {

            SqlConnection con = SystemMgr.BLL.Common.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = (SqlConnection)con;//对象实例化
            cmd.CommandText = "insert into Admin (Apwd,Aname)values(@Apwd,@Aname)";


            cmd.Parameters.Add("@Apwd", SqlDbType.VarChar);
            cmd.Parameters.Add("@Aname", SqlDbType.VarChar);


            cmd.Parameters["@Apwd"].Value = this.txtpwd.Text;
            cmd.Parameters["@Aname"].Value = this.txtname.Text;

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script language='javascript'>alert('添加成功');location.href='AdminList.aspx'</script>");
        }
        catch
        {
            Response.Write("<script language='javascript'>alert('添加失败');location.href='AdminList.aspx'</script>");
        }
    }
}
