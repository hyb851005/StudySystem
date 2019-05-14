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

public partial class UserStReg : System.Web.UI.Page
{
    

    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = SystemMgr .BLL.Common.GetWebTitle();
        if (!Page.IsPostBack) 
        {
            TextBox1.Attributes.Add("value", TextBox1.Text.Trim ());
            TextBox2.Attributes.Add("value", TextBox2.Text.Trim());
        }

    }
    //用户注册信息
    protected void Button1_Click(object sender, EventArgs e)
    {
        //验证用户名是否已存在
        SqlDataReader dr;
        dr = SystemMgr.BLL.Common.GetDataReader("select * from  Users where UserName='" + txtname.Text.Trim() + "'");
        if (dr.Read())
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('输入的登录帐号已存在，注册失败.');</script>");
            return;
        }

        //保存用户注册信息
        bool b = SystemMgr.BLL.Common.RunSqlBool("insert into Users(emal,UserName,Sex,Age,Ds,pwd,UserType,XueXiao,XingMing,Photo,Tel)values('" + txtemal.Text + "','" + txtname.Text + "','" + DropDownList1.SelectedItem.Text + "','" + Age.Text + "','" + txtds.Text + "','" + TextBox1.Text + "','学生','" + XueXiao.Text + "','" + XingMing.Text + "','" + pic.Text + "','" + Tel.Text + "')");
        if (b)
            Alert.AlertAndRedirect("注册成功！", "Default.aspx");
        else
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('注册失败.');</script>");
            return;
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
