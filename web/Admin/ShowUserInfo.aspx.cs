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
public partial class Admin_ShowUserInfo : System.Web.UI.Page
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
            string id = Request.QueryString["id"].ToString();
            SqlDataReader dr = SystemMgr.BLL.Common.GetDataReader("select * from Users where id=" + id);
            dr.Read();
            txtname.Text = dr["UserName"].ToString();
            XingMing.Text = dr["XingMing"].ToString();
            Age.Text = dr["Age"].ToString();
            txtds.Text = dr["Ds"].ToString();
            txtemal.Text = dr["emal"].ToString();
            XueXiao.Text = dr["XueXiao"].ToString();

            Image1.ImageUrl = "../files/" + dr["Photo"].ToString();
            Tel.Text = dr["Tel"].ToString();
        }
    }
}
