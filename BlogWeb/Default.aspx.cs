﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt =
                new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkimdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBLDENEYIMTableAdapter dt2 =
                new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListele();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBLEGITIMTableAdapter dt3 =
                new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            Repeater3.DataSource = dt3.EgitimListele();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt4 =
                new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            Repeater4.DataSource = dt4.YetenekListesi();
            Repeater4.DataBind();

            DataSet1TableAdapters.TBLHOBILERTableAdapter dt5 =
                new DataSet1TableAdapters.TBLHOBILERTableAdapter();
            Repeater5.DataSource = dt5.HobilerListele();
            Repeater5.DataBind();

            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt6 =
                new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            Repeater6.DataSource = dt6.SertifikaListele();
            Repeater6.DataBind();

            DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt7 =
                new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
            Repeater7.DataSource = dt7.HakkimdaListele();
            Repeater7.DataBind();
        }
    }
}