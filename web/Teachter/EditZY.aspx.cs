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
using System.IO;

public partial class Teachter_EditZY : System.Web.UI.Page
{

    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Get_Article();
        }
    }

    private void Get_Article()
    {
        int id = int.Parse(Request.QueryString["id"].ToString());
        SqlDataReader dr = SystemMgr.BLL.Common.GetDataReader("select * from WorkInfo where id=" + id);
        dr.Read();
        TextBox1.Text = dr["TitleName"].ToString();
        ArticleContent.Value = dr["FileDs"].ToString();
        pic.Text = dr["FilePath"].ToString();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        string res;
        upload up = new upload();
        res = up.Up(file1, "../files/");

        this.Label1.Visible = true;
        this.Label1.Text = up.Resup[Convert.ToInt32(res)];
        this.pic.Text = up.s;
        Hidden1.Value = up.fname;
    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        string filename = Hidden1.Value;
        int i = this.pic.Text.LastIndexOf(".");
        string newname = this.pic.Text.Substring(i);//获取文件的扩展名
        int id = int.Parse(Request.QueryString["id"].ToString());
        bool b = SystemMgr.BLL.Common.RunSqlBool("update WorkInfo set TitleName='" + TextBox1.Text + "',FileDs='" + ArticleContent.Value + "',FilePath='" + pic.Text + "' ,Ename='" + newname + "',addtime=getdate() where id=" + id);
        Alert.AlertAndRedirect("修改成功！", "ZYManger.aspx");
    }
}
