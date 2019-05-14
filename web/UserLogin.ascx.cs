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
public partial class UserLogin : System.Web.UI.UserControl
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //判断用户是否登录系统
            if (Session["UserId"] == null)
            {
                Login1.Visible = false;
                Login2.Visible = true;
            }
            else
            {
                Label1.Text = Session["UserName"].ToString();                
                Login1.Visible = true;
                Login2.Visible = false;

            }
        }
    }
    //跳转到注册界面
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserStReg.aspx");
    }
    //退出系统
    protected void Button4_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Session["UserId"] = null;
        Session["UserName"] = null;
        Response.Redirect("Default.aspx");
    }
    //跳转用户主界面
    protected void Button1_Click(object sender, EventArgs e)
    {
        //验证是否登录状态
        try {
            if (!(Session["UserId"] != null && Session["UserName"] != null && Session["roule"] != null)) 
            {
                Response.Redirect("Default.aspx");
            }
        }
        catch (Exception ex) 
        {
        
        }

        if (Session["roule"].ToString() == "学生")
        {
            Response.Redirect("UserHome.aspx");
        }
        else
        {
            Response.Redirect("Teachter/index.html");
        }
      
    }
    //验证用户登录
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TxtUserName.Text == "" && TxtPassword.Text == "")
        {
            Alert.AlertAndRedirect("没有输入账号和密码！", "Default.aspx");
        }
        else
        {
            SqlDataReader dr;
            dr = SystemMgr.BLL.Common.GetDataReader("select * from  Users where UserName='" + TxtUserName.Text.Trim() + "'and pwd='" + TxtPassword.Text.Trim() + "' ");
            if (dr.Read())
            {
                Session["UserId"] = dr["id"].ToString();
                Session["UserName"] = dr["UserName"].ToString();
                Session["XingMing"] = dr["XingMing"].ToString();
                Session["roule"] = dr["UserType"].ToString();
                Response.Redirect("Default.aspx");
            }
            else
            {
                Alert.AlertAndRedirect("账号或者密码不对请重新登陆！", "Default.aspx");
            }
        }
    }
}
