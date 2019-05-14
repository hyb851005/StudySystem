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

public partial class Admin_NewsSendMessage : System.Web.UI.Page
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    Alert js = new Alert();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {//资讯类的评论
            hf_filetype.Value = "2";

            GetDate();

        }
    }
    protected void gvInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SystemMgr.BLL.Common mydata = new SystemMgr.BLL.Common();

        string ID = gvInfo.DataKeys[e.RowIndex].Values[0].ToString();
        try
        {
            bool b = SystemMgr.BLL.Common.RunSqlBool("delete  from SendMessage  where  id='" + ID + "'");

            Label4.Text = "删除成功！";
            gvInfo.EditIndex = -1;
            GetDate();
        }
        catch
        {

            Label4.Text = "删除失败！";
        }

    }
    private void GetDate()
    {
        try
        {
            gvInfo.DataSource = GetCodeBy(0);
            gvInfo.DataBind();
        }
        catch
        {

        }

    }
    protected void gvInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvInfo.PageIndex = e.NewPageIndex;
        GetDate();
    }
    protected void gvInfo_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //鼠标移动变色
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //当鼠标放上去的时候 先保存当前行的背景颜色 并给附一颜色 
            e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#f6f6f6',this.style.fontWeight='';");
            //当鼠标离开的时候 将背景颜色还原的以前的颜色 
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
        }
        //单击行改变行背景颜色 
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onclick", "this.style.backgroundColor='#f6f6f6'; this.style.color='buttontext';this.style.cursor='default';");
        }

    }

    public DataSet GetCodeBy(int iCount)
    {
        SystemMgr.BLL.Common date = new SystemMgr.BLL.Common();
        string strTop = "";
        if (iCount > 1)
        {
            strTop = "top " + iCount.ToString();
        }

        //string sql = "select * from [FileInfo] where TitleName like '%" + keyword.Text.Trim() + "%'  order  by addtime desc";
        string sql = "select  " + strTop + " a.id,a.filetype,a.fileid,a.userid,a.sendMessage,a.sendtime,u.username,b.name from SendMessage a left join News b on a.fileid=b.id left join users u on a.userid=u.id where a.filetype=" + hf_filetype.Value + " and (u.username like '%" + keyword.Text.Trim() + "%' or b.name like '%" + keyword.Text.Trim() + "%') order by a.sendtime desc";
        SqlConnection con = SystemMgr.BLL.Common.getConnection();
        SqlCommand cmd = new SqlCommand(sql, con);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = null;
        try
        {
            con.Open();
            ds = new DataSet();
            da.Fill(ds);

        }
        catch (SqlException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
        return ds;
    }
    //搜索
    protected void btn_search_Click(object sender, EventArgs e)
    {
        GetDate();
    }
}
