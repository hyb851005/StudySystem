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

public partial class MasterPage : System.Web.UI.MasterPage
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
     
        if (!IsPostBack)
        {
            DataList2.DataSource = SystemMgr.BLL.Common.GetDataReader("select top  5 * from  FileInfo  order by  addtime desc ");
            DataList2.DataBind();

            DataList1.DataSource = SystemMgr.BLL.Common.GetDataReader("select top  5 * from  Video   order by  addtime desc ");
            DataList1.DataBind();
        }

    }
    protected string CutChar(string strChar, int intLength)
    {
        //取得自定义长度的字符串
        if (strChar.Length > intLength)
        { return strChar.Substring(0, intLength); }
        else
        { return strChar; }

    }
}
