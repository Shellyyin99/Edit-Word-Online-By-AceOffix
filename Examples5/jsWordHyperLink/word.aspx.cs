﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class jsWordHyperLink_word : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AceoffixCtrl1.ServerPage = "../aceoffix-runtime/server.aspx";
        AceoffixCtrl1.AddCustomToolButton("Hyperlink", "addHyperLink()", 5);
        AceoffixCtrl1.Menubar = false;
        AceoffixCtrl1.OpenDocument("doc/test.doc", Aceoffix.OpenModeType.docNormalEdit, "John Scott");

    }
}