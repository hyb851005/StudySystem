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
using System.Text;

public partial class FileInfo : System.Web.UI.Page
{
    public string sql;

    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    { 
        if (!IsPostBack)
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                Response.Redirect("default.aspx");
                return;
            }
            hf_filetype.Value = "1"; //多媒体课件
            hf_id.Value = Request.QueryString["id"].ToString().Trim();

            if (Session["UserId"] != null && Session["UserId"].ToString ()!="") 
            {
                hf_uid.Value = Session["UserId"].ToString();
            }

            sql = "select * from FileInfo where id=" + hf_id.Value;
            getdata(sql);
            //加载留言
            LoadComment();
        }
    }
    //加载文件详细信息
    private void getdata(string sql)
    {
        SqlDataReader dr = SystemMgr.BLL.Common.GetDataReader(sql);
        if (dr.Read())
        {
            Label1.Text = dr["Addtime"].ToString();
            Label2.Text = dr["TitleName"].ToString();
            div_content .Text = dr["FileDs"].ToString();
            Hidden1.Value = "files/" + dr["FilePath"].ToString();
            Hidden2.Value = dr["Ename"].ToString();
            Hidden3.Value = dr["FileName"].ToString();
        }

    }

    //下载文件
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string fileName = Hidden3.Value + Hidden2.Value;

        string filePath = Server.MapPath(Hidden1.Value);//路径

        //以字符流的形式下载文件 

        FileStream fs = new FileStream(filePath, FileMode.Open);

        byte[] bytes = new byte[(int)fs.Length];

        fs.Read(bytes, 0, bytes.Length);

        fs.Close();

        Response.ContentType = "application/octet-stream";

        //通知浏览器下载文件而不是打开 

        Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));

        Response.BinaryWrite(bytes);

        Response.Flush();

        Response.End();
    }


    //发表在线留言
    protected void Button3_Click(object sender, EventArgs e)
    { 
        if (hf_uid.Value != "")
        {
            //保存留言
            string sql = "insert into SendMessage(filetype,fileid,UserID,sendMessage,sendtime) values(" + hf_filetype.Value + "," + hf_id.Value + "," + hf_uid.Value + ",'" + txtContent.Text.Trim() + "',getdate())";
            if (SystemMgr.BLL.Common.RunSqlBool(sql))
            {
                LoadComment(); //删除后重新加载留言
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('留言提交成功');</script>");
                txtContent.Text = "";
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请先登录系统');</script>");
        }
    }

    //加载留言
    private void LoadComment()
    {
        DataSet ds = SystemMgr.BLL.Common.GetDs("select a.id,a.filetype,a.fileid,a.userid,a.sendMessage,a.sendtime,u.username from SendMessage a left join FileInfo b on a.fileid=b.id left join users u on a.userid=u.id where a.filetype=" + hf_filetype.Value + " and a.fileid=" + hf_id.Value,"sendmessage");
        gvData.DataSource = ds;
        gvData.DataBind();

    }
    //行绑定
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (((Label)e.Row.FindControl("labUserID")).Text == hf_uid.Value)
            {
                ((LinkButton)e.Row.FindControl("lbtnDel")).Enabled = true;
            }
        }
    }
    //删除
    protected void gvData_RowDeleting(object sender, GridViewDeleteEventArgs e)
    { 
        string id = ((Label)gvData.Rows[e.RowIndex].FindControl("labproid")).Text;
        if (SystemMgr.BLL.Common.RunSqlBool("delete SendMessage where id=" + id))
        {
            LoadComment(); //删除后重新加载留言
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('留言删除成功');</script>");
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('留言删除失败');</script>");
        }
    }
}
