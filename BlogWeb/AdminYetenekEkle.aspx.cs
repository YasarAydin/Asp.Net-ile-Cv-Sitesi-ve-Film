﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminYetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonYetenekEkle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt =
                new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            dt.YetenekEkle(TextBoxYetenek.Text);
            Response.Redirect("AdminYetenekler.aspx");
        }
    }
}