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
public partial class Admin_XiuGaiXinWenLeiBie : System.Web.UI.Page
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Admin"] == null)
            {
                Response.Write("<script language='javascript'>alert('您还没有登陆');top.location.href='login.aspx'</script>");
            }
            else
            {
                SqlConnection con = SystemMgr.BLL.Common.getConnection(); 
                con.Open();
                SqlCommand cmd = new SqlCommand("select  * from Infotype where id=" + Request.QueryString["id"].ToString(), con);//从数据库中选择数据
                cmd.Parameters.Add("@name", SqlDbType.VarChar);

                cmd.Parameters["@name"].Value = txtname.Text;
                SqlDataReader sdr = cmd.ExecuteReader();//读数据
                if (sdr.Read())
                {
                    txtname.Text = Convert.ToString(sdr["name"]);

                }
                con.Close();
            }

        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string id=Request.QueryString["id"].ToString();
         bool b = SystemMgr.BLL.Common.RunSqlBool("update  Infotype set name='"+txtname.Text+"' where id="+id);

        Response.Write("<script language='javascript'>alert('修改成功');location.href='NewsTypeList.aspx'</script>");
    }
}
