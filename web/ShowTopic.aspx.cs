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
public partial class ShowTopic : System.Web.UI.Page
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = SystemMgr .BLL.Common.GetWebTitle();
        if (!IsPostBack)
        {


            BinderTopic();
            BinderReplay();

        }
    }
 
    private void BinderTopic()
    {
        int id = Int16.Parse(Request.QueryString["id"].ToString());
        SqlDataReader dr;
        dr = SystemMgr.BLL.Common.GetDataReader("select * from  Topic where id=" + id);
        dr.Read();
        Label1.Text = dr["Topic"].ToString();
        Label2.Text = dr["Addtime"].ToString();
        Label3.Text = dr["Content"].ToString();
        Label4.Text = dr["AddUser"].ToString();
    }
    private void BinderReplay()
    {
        int id = Int16.Parse(Request.QueryString["id"].ToString());
        string sql = "select * from  Replay where TopicId=" + id + " order by addtime desc";
        SqlConnection con = SystemMgr.BLL.Common.getConnection();
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        sda.Fill(ds);
         
        if (ds.Tables[0].Rows.Count == 0)
        {
            trFenye.Visible = false;
        }
        else
        {
            trFenye.Visible = true;
        }


        PagedDataSource objPds = new PagedDataSource();
        objPds.DataSource = ds.Tables[0].DefaultView;

        objPds.AllowPaging = true;
        objPds.PageSize = 5;

        int CurPage;
        if (Request.QueryString["Page"] != null)
            CurPage = Convert.ToInt32(Request.QueryString["Page"]);
        else
            CurPage = 1;

        objPds.CurrentPageIndex = CurPage - 1;
        lblCurrentPage.Text = CurPage.ToString();
        lblSumPage.Text = objPds.PageCount.ToString();

        if (!objPds.IsFirstPage)
        {
            this.hyfirst.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + 1+"&id="+id;
            lnkPrev.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage - 1) + "&id=" + id;
        }

        if (!objPds.IsLastPage)
        {
            hylastpage.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + objPds.PageCount + "&id=" + id;

            lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage + 1) + "&id=" + id;
        }

        this.DataList1.DataSource = objPds;
        this.DataList1.DataBind();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["UserId"] == null)
        {
            Alert.AlertAndRedirect("对不起您没有登录", "Default.aspx");
        }
        else
        {
            int id = Int16.Parse(Request.QueryString["id"].ToString());

             bool b = SystemMgr.BLL.Common.RunSqlBool("insert into Replay(Replay,ReplayUser,TopicId)values('" + ArticleContent.Value + "','" + Session["UserName"].ToString() + "'," + id + ")");

              b = SystemMgr.BLL.Common.RunSqlBool("update Topic set isReplay='1' where id=" + id);
            Alert.AlertAndRedirect("回复成功！", "ShowTopic.aspx?id=" + id);
            BinderTopic();
            BinderReplay();
        }
    }
}
