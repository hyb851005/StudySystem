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

using System.Linq;
using System.Data.Linq;

public partial class NewsInfo : System.Web.UI.Page
{
    int subjectID = -1;

    public string sql, dID;

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
            hf_filetype.Value = "2"; //资讯信息类的
            hf_id.Value = Request.QueryString["id"].ToString().Trim();

            if (Session["UserId"] != null && Session["UserId"].ToString() != "")
            {
                hf_uid.Value = Session["UserId"].ToString();
            }

            sql = "select * from News where id=" + hf_id.Value;
            getdata(sql);
        }

        if (Request.Params["id"] != null)
        {
            subjectID = Int32.Parse(Request.Params["id"].ToString());
        }
        if (!Page.IsPostBack)
        {
            BindPageData();
        }

    }

    private void getdata(string sql)
    {
        SqlDataReader dr = SystemMgr.BLL.Common.GetDataReader(sql);
        lbTotalScore.Text = "测试中";
        if (dr.Read())
        {
            Label1.Text = dr["Addtime"].ToString();
            Label2.Text =  dr["name"].ToString() ;
            this.DIV1.InnerHtml = dr["content"].ToString();

            if (dr["imgurl"].ToString().Length > 5)
            {
                litImg.Text = "<div style=\"text-align:center; width:680px; overflow:hidden;\"><img src=\"files/" + dr["imgurl"].ToString() + "\"/></div>";
            }
            else {
                litImg.Text = "";
            }
        }

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
        DataSet ds = SystemMgr.BLL.Common.GetDs("select a.id,a.filetype,a.fileid,a.userid,a.sendMessage,a.sendtime,u.username from SendMessage a left join FileInfo b on a.fileid=b.id left join users u on a.userid=u.id where a.filetype=" + hf_filetype.Value + " and a.fileid=" + hf_id.Value, "sendmessage");
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

    private void BindPageData()
    {   ///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
        ///获取考题的考题信息
        var query = from q in db.Question
                    where q.SubjectID == subjectID
                    select q;
        ///显示考题
        gvQuestion.DataSource = query;
        gvQuestion.DataBind();
    }

    private void BindAnswerData(CheckBoxList rbl, int questionID)
    {   ///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
        ///获取考题的答案信息
        var query = from a in db.Answer
                    where a.QuestionID == questionID
                    select a;
        ///绑定到指定的列表控件
        rbl.DataSource = query;
        rbl.DataTextField = "Body";
        rbl.DataValueField = "ID";
        rbl.DataBind();
    }

    protected void gvQuestion_RowDataBound(object sender, GridViewRowEventArgs e)
    {   ///显示题号
		Label lbIndex = (Label)e.Row.FindControl("lbIndex");
        if (lbIndex != null)
        {
            lbIndex.Text = (e.Row.RowIndex + 1).ToString();
        }
        ///找到显示答案的列表，并显示考题的答案
        //RadioButtonList rbl = (RadioButtonList)e.Row.FindControl("rblAnswer");
        CheckBoxList rbl = (CheckBoxList)e.Row.FindControl("rblAnswer");
        if (rbl != null)
        {
            BindAnswerData(rbl, Int32.Parse(gvQuestion.DataKeys[e.Row.RowIndex]["ID"].ToString()));
        }
    }

    protected void ibtCommit_Click(object sender, ImageClickEventArgs e)
    {
        int totalScore = 0;
        ///创建ExamineDB数据库的数据上下文
        ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
        ///获取当前考生的在线考试的ID值
        //if(Session["OnlineExamineID"] == null) return;
        //int onlineExamineID = Int32.Parse(Session["OnlineExamineID"].ToString());

        foreach (GridViewRow row in gvQuestion.Rows)
        {
            //RadioButtonList rbl = (RadioButtonList)row.FindControl("rblAnswer");
            CheckBoxList rbl = (CheckBoxList)row.FindControl("rblAnswer");
            if (rbl != null)
            {   ///获取考题ID值，考生的答案等信息
				int questionID = Int32.Parse(gvQuestion.DataKeys[row.RowIndex]["ID"].ToString());
                string answer = string.Empty;
                if (rbl.SelectedIndex > -1)
                {
                    for (int i = 0; i < rbl.Items.Count; i++)
                    {
                        if (rbl.Items[i].Selected)
                        {
                            answer += ((char)(((int)'A') + i)).ToString();
                            answer += "/";
                        }
                    }
                    answer = answer.Substring(0, answer.Length - 1);
                    //answer = ((char)(((int)'A') + rbl.SelectedIndex)).ToString();
                    //Response.Write(answer);
                    //Response.Write(",");
                }
                ///将考生的答案添加到数据库中
                //ExamineeAnswer ea = new ExamineeAnswer();
                //ea.OnlineExamineID = onlineExamineID;
                //ea.QuestionID = questionID;
                //ea.Answer = answer;
                //db.ExamineeAnswer.InsertOnSubmit(ea);
                ///获取当前考题的正确答案，并得出考生的得分
                var query = from q in db.Question
                            where q.ID == questionID
                            select q;
                if (query.Count() > 0)
                {   ///比较考生的答案和该题的正确答案，如果正确，则计算分值
					Question cq = query.First();
                    if (cq.Answer.ToUpper().Trim() == answer.ToUpper().Trim())
                    {
                        totalScore += cq.Score.Value;
                    }
                }
            }
        }
        ///将考试成绩保存到数据库
        //var queryoex = from oe in db.OnlineExamine
        //			  where oe.ID == onlineExamineID
        //			  select oe;
        //foreach(OnlineExamine oex in queryoex)
        //{
        //	oex.Score = totalScore;
        //}
        ///讲考生答题保存到数据库
        //db.SubmitChanges();
        ///显示考试成绩
        lbTotalScore.Text = "提交完成，本次测试成绩为：" + totalScore.ToString() + "分";
    }


}