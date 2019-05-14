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
using System.Text;

public partial class VPlay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["url"] != null)
        {
            string url = Request.QueryString["url"].ToString();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<object classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0\" width=\"32\" height=\"32\">");
            sb.AppendLine(string.Format("  <param name=\"movie\" value=\"{0}\">", url));
            sb.AppendLine("<param name=\"quality\" value=\"high\">");
            sb.AppendLine(string.Format("<embed src=\"{0}\" quality=\"high\" pluginspage=\"http://www.macromedia.com/go/getflashplayer\" type=\"application/x-shockwave-flash\" width=\"360\" height=\"300\"></embed>", url));
            sb.AppendLine("</object>");

            lit_play.Text = sb.ToString();
        }
    }
}
