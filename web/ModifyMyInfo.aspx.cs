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
public partial class ModifyMyInfo : System.Web.UI.Page
{
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
            
            SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
            string id = Session["UserId"].ToString();
            SqlDataReader dr = SystemMgr.BLL.Common.GetDataReader("select * from Users where id=" + id);
            dr.Read();
            txtname.Text = dr["UserName"].ToString();
            XingMing.Text = dr["XingMing"].ToString();
            Age.Text = dr["Age"].ToString();
            txtds.Text = dr["Ds"].ToString();
            txtemal.Text = dr["emal"].ToString();
            XueXiao.Text = dr["XueXiao"].ToString();
            pic.Text = dr["Photo"].ToString();
            Image1.ImageUrl = "files/" + dr["Photo"].ToString();
            Tel.Text = dr["Tel"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //验证是否登录状态
        try
        {
            if (!(Session["UserId"] != null && Session["UserName"] != null && Session["roule"] != null))
            {
                Response.Redirect("Default.aspx");
            }

            //保存修改信息
            string id = Session["UserId"].ToString();
             bool b = SystemMgr.BLL.Common.RunSqlBool("update  Users set UserName='" + txtname.Text + "',XingMing='" + XingMing.Text + "',Age='" + Age.Text + "',Ds='" + txtds.Text + "',emal='" + txtemal.Text + "',XueXiao='" + XueXiao.Text + "',Tel='" + Tel.Text + "',Photo='" + pic.Text + "' where id=" + id);
            Alert.AlertAndRedirect("修改成功", "UserHome.aspx");
      
        }
        catch (Exception ex)
        {

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string res;
        upload up = new upload();
        res = up.Up(file1, "files/");
        this.Label1.Visible = true;
        this.Label1.Text = up.Resup[Convert.ToInt32(res)];
        this.pic.Text = up.s;
        Image1.ImageUrl = "files/" + pic.Text;
    }
}
