﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Play : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["url"] != null)
        {


        }


    }
    public string PlayMedia()
    {
        string url = Request.QueryString["url"].ToString();
        string strScript =
         "<TABLE id=\"Table2\" align=\"center\" border=\"0\" runat=\"server\" width = '480' height ='450'>"
         + "<TR>"
         + "<TD align=\"center\">"
         + "<OBJECT id=\"mdpTrailer\" classid=\"clsid:22D6F312-B0F6-11D0-94AB-0080C74C7E95\" name=\"mdpTrailer\" width='480' height = '450'>"
         + "<PARAM NAME=\"AudioStream\" VALUE=\"-1\">"
         + "<PARAM NAME=\"AutoSize\" VALUE=\"-1\">"
         + "<PARAM NAME=\"AutoStart\" VALUE=\"0\">"
         + "<PARAM NAME=\"AnimationAtStart\" VALUE=\"-1\">"
         + "<PARAM NAME=\"AllowScan\" VALUE=\"-1\">"
         + "<PARAM NAME=\"AllowChangeDisplaySize\" VALUE=\"-1\">"
         + "<PARAM NAME=\"AutoRewind\" VALUE=\"0\">"
         + "<PARAM NAME=\"Balance\" VALUE=\"0\">"
         + "<PARAM NAME=\"BaseURL\" VALUE=\"\">"
         + "<PARAM NAME=\"BufferingTime\" VALUE=\"5\">"
         + "<PARAM NAME=\"CaptioningID\" VALUE=\"\">"
         + "<PARAM NAME=\"ClickToPlay\" VALUE=\"-1\">"
         + "<PARAM NAME=\"CursorType\" VALUE=\"0\">"
         + "<PARAM NAME=\"CurrentPosition\" VALUE=\"-1\">"
         + "<PARAM NAME=\"CurrentMarker\" VALUE=\"0\">"
         + "<PARAM NAME=\"DefaultFrame\" VALUE=\"\">"
         + "<PARAM NAME=\"DisplayBackColor\" VALUE=\"0\">"
         + "<PARAM NAME=\"DisplayForeColor\" VALUE=\"16777215\">"
         + "<PARAM NAME=\"DisplayMode\" VALUE=\"0\">"
         + "<PARAM NAME=\"DisplaySize\" VALUE=\"4\">"
         + "<PARAM NAME=\"Enabled\" VALUE=\"-1\">"
         + "<PARAM NAME=\"EnableContextMenu\" VALUE=\"-1\">"
         + "<PARAM NAME=\"EnablePositionControls\" VALUE=\"-1\">"
         + "<PARAM NAME=\"EnableFullScreenControls\" VALUE=\"0\">"
         + "<PARAM NAME=\"EnableTracker\" VALUE=\"-1\">"
         + "<PARAM NAME=\"Filename\" VALUE=\"" + url + "\">"
         + "<PARAM NAME=\"InvokeURLs\" VALUE=\"-1\">"
         + "<PARAM NAME=\"Language\" VALUE=\"-1\">"
         + "<PARAM NAME=\"Mute\" VALUE=\"0\">"
         + "<PARAM NAME=\"PlayCount\" VALUE=\"1\">"
         + "<PARAM NAME=\"PreviewMode\" VALUE=\"0\">"
         + "<PARAM NAME=\"Rate\" VALUE=\"1\">"
         + "<PARAM NAME=\"SAMILang\" VALUE=\"\">"
         + "<PARAM NAME=\"SAMIStyle\" VALUE=\"\">"
         + "<PARAM NAME=\"SAMIFileName\" VALUE=\"\">"
         + "<PARAM NAME=\"SelectionStart\" VALUE=\"-1\">"
         + "<PARAM NAME=\"SelectionEnd\" VALUE=\"-1\">"
         + "<PARAM NAME=\"SendOpenStateChangeEvents\" VALUE=\"-1\">"
         + "<PARAM NAME=\"SendWarningEvents\" VALUE=\"-1\">"
         + "<PARAM NAME=\"SendErrorEvents\" VALUE=\"-1\">"
         + "<PARAM NAME=\"SendKeyboardEvents\" VALUE=\"0\">"
         + "<PARAM NAME=\"SendMouseClickEvents\" VALUE=\"0\">"
         + "<PARAM NAME=\"SendMouseMoveEvents\" VALUE=\"0\">"
         + "<PARAM NAME=\"SendPlayStateChangeEvents\" VALUE=\"-1\">"
         + "<PARAM NAME=\"ShowCaptioning\" VALUE=\"0\">"
         + "<PARAM NAME=\"ShowControls\" VALUE=\"-1\">"
         + "<PARAM NAME=\"ShowAudioControls\" VALUE=\"-1\">"
         + "<PARAM NAME=\"ShowDisplay\" VALUE=\"0\">"
         + "<PARAM NAME=\"ShowGotoBar\" VALUE=\"0\">"
         + "<PARAM NAME=\"ShowPositionControls\" VALUE=\"-1\">"
         + "<PARAM NAME=\"ShowStatusBar\" VALUE=\"0\">"
         + "<PARAM NAME=\"ShowTracker\" VALUE=\"-1\">"
         + "<PARAM NAME=\"TransparentAtStart\" VALUE=\"0\">"
         + "<PARAM NAME=\"VideoBorderWidth\" VALUE=\"0\">"
         + "<PARAM NAME=\"VideoBorderColor\" VALUE=\"0\">"
         + "<PARAM NAME=\"VideoBorder3D\" VALUE=\"0\">"
         + "<PARAM NAME=\"Volume\" VALUE=\"-600\">"
         + "<PARAM NAME=\"WindowlessVideo\" VALUE=\"0\">"
         + "</OBJECT>"
         + "</TD>"
         + "</TR>"
         + "</TABLE>";

        return strScript;
    }
}
