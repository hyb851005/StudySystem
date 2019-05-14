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

public partial class UploadWork : System.Web.UI.Page
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserId"] != null && Session["UserId"].ToString() != "")
            {
                hf_uid.Value = Session["UserId"].ToString();

                getdata();
            }
        }
    }

    private void getdata()
    {
        string sql = "select a.*,b.UserName,b.Xingming+' - '+a.TitleName as ftitle from WorkInfo a left join Users b on a.UserID=b.ID order by a.addtime desc";
        ddlWorkList.DataSource = SystemMgr.BLL.Common.GetDv(sql);
        ddlWorkList.DataTextField = "ftitle";
        ddlWorkList.DataValueField = "id";
        ddlWorkList.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string res;
        upload up = new upload();
        res = up.Up(file1, "files/");

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

        string sql = "insert into DoWorkList(UserId,WorkID,FTitle,FContent,FilePath,Ename,FileName,addtime)values(" + hf_uid.Value + "," + ddlWorkList.SelectedValue + ",'" + ddlWorkList.SelectedItem.Text + "','" + ArticleContent.Value + "','" + pic.Text + "','" + newname + "','" + filename + "',getdate())";
        bool b = SystemMgr.BLL.Common.RunSqlBool(sql);

        Alert.AlertAndRedirect("练习题上传成功", "MyWorkList.aspx");
    }
}
