﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class beforeBrowserClosed_word : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void AceoffixCtrl1_Load(object sender, EventArgs e)
    {
        AceoffixCtrl1.ServerPage = "../aceoffix-runtime/server.aspx";
        AceoffixCtrl1.AddCustomToolButton("Save", "SaveDocument()", 1);
        AceoffixCtrl1.Caption = "The default auto save interval is 1 minite.";
        AceoffixCtrl1.SaveFilePage = "savefile.aspx";
        AceoffixCtrl1.OpenDocument("doc/introduce.doc", Aceoffix.OpenModeType.docNormalEdit, "John Scott"); // docReadOnly: Disabled Edit, Paste.

    }
}