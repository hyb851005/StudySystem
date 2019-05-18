using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Data.Linq;

public partial class Admin_QuestionManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if(!Page.IsPostBack)
		{
			BindPageData();
            if (ddlSubject.Items.Count > 0)
            {   ///设置第一个为默认选项，并显示该考试科目的考题
                ddlSubject.SelectedIndex = 0;
                BindPageData(Int32.Parse(ddlSubject.SelectedValue));
            }
		}
    }

	private void BindPageData()
	{   ///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
		///查询考试科目
		var query = from s in db.Subject					
					select s;
		///绑定控件数据，并显示考试科目
        ddlSubject.DataSource = query;
        ddlSubject.DataTextField = "Name";
        ddlSubject.DataValueField = "ID";
        ddlSubject.DataBind();
	}

	private void BindPageData(int subjectID)
	{   ///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
		///查询考题
		var query = from q in db.Subject
                    //where q.SubjectID == subjectID
					select q;
		///绑定控件数据，并显示考题
		gvQuestion.DataSource = query;
		gvQuestion.DataBind();
	}
    //protected void ddlSubject_SelectedIndexChanged(object sender,EventArgs e)
    //{
    //    if (ddlSubject.SelectedIndex > -1)
    //    {   ///显示考题
    //        BindPageData(Int32.Parse(ddlSubject.SelectedValue));
    //    }
    //}

    protected void ibtAdd_Click(object sender, ImageClickEventArgs e)
	{
        Response.Redirect("~/Admin/AddSubject.aspx");
	}
	protected void gvQuestion_RowCommand(object sender,GridViewCommandEventArgs e)
	{
        //if(e.CommandName == "edit")
        //{   ///跳转到修改考题页面
        //    Response.Redirect("~/Admin/UpdateQuestion.aspx?QuestionID=" + e.CommandArgument.ToString());
        //}
		if(e.CommandName == "del")
		{
			///创建ExamineDB数据库的数据上下文
			ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
			///产生答案
            //var queryA = from a in db.Answer
            //            where a.QuestionID.Value.ToString() == e.CommandArgument.ToString()
            //            select a;
            //db.Answer.DeleteAllOnSubmit(queryA);
			///删除考题
			var queryQ = from q in db.Subject
						 where q.ID.ToString() == e.CommandArgument.ToString()
						 select q;
            db.Subject.DeleteAllOnSubmit(queryQ);
			///提交到数据库
			db.SubmitChanges();
			///重新显示考题
            BindPageData(Int32.Parse(ddlSubject.SelectedValue));
		}
	}
	protected void gvQuestion_RowDataBound(object sender,GridViewRowEventArgs e)
	{
		if(e.Row.RowType == DataControlRowType.DataRow)
		{   ///显示考题的序号
			Label lbIndex = (Label)e.Row.FindControl("lbIndex");
			if(lbIndex != null)
			{
				lbIndex.Text = (e.Row.RowIndex + 1).ToString();
			}
		}
		///添加删除确认的对话框
		ImageButton deleteBtn = (ImageButton)e.Row.FindControl("ibtDelete");
		if(deleteBtn != null)
		{
			deleteBtn.Attributes.Add("onclick","return confirm('你确定要删除所选择的试题库吗?');");
		}
	}
}
