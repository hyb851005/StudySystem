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

public partial class Admin_NewsList : System.Web.UI.Page
{

    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // 加载显示 信息类别
            DropDownList1.DataSource = SystemMgr.BLL.Common.GetDataReader("select * from Infotype");
            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "name";
            DropDownList1.DataBind();
            Get_Info();
        }
    }

    //删除信息记录
    protected void gvInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SystemMgr.BLL.Common mydata = new SystemMgr.BLL.Common();

        string ID = gvInfo.DataKeys[e.RowIndex].Values[0].ToString();
        try
        {
             bool b = SystemMgr.BLL.Common.RunSqlBool("delete  from News  where  id='" + ID + "'");

            Label4.Text = "删除成功！";
            gvInfo.EditIndex = -1;
            Get_Info();
        }
        catch
        {

            Label4.Text = "删除失败！";
        }

    }

    // 加载数据
    private void Get_Info()
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
    // 分页
    protected void gvInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvInfo.PageIndex = e.NewPageIndex;
        Get_Info();
    }
    //数据行绑定 触发事件
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
        
    //加载数据方法
    public DataSet GetCodeBy(int iCount)
    {
        SystemMgr.BLL.Common date = new SystemMgr.BLL.Common();
        string strTop = "";
        if (iCount > 1)
        {
            strTop = "top " + iCount.ToString();
        }

        lab_allcount.Text = "0";

        string sql = "select  " + strTop + "  * from [News] where typeid='"+DropDownList1.SelectedValue+"' and [name] like '%" + keyword .Text.Trim ()+ "%' order by addtime desc";
        SqlConnection con = SystemMgr.BLL.Common.getConnection();
        SqlCommand cmd = new SqlCommand(sql, con);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = null;
        try
        {
            con.Open();
            ds = new DataSet();
            da.Fill(ds);

            lab_allcount.Text = ds.Tables[0].Rows.Count.ToString();
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

    // 更换类别，重新加载数据记录
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Get_Info();

    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        Get_Info();
    }
}
