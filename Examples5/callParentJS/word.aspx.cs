﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class callParentJS_word : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AceoffixCtrl1.ServerPage = "../aceoffix-runtime/server.aspx";
        AceoffixCtrl1.AddCustomToolButton("Close", "Close()", 9);
        AceoffixCtrl1.OpenDocument("doc/test.doc", Aceoffix.OpenModeType.docNormalEdit, "Tom");

    }
}