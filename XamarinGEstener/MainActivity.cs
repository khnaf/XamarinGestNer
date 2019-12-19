using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.IO;
using XamarinGEstener.Resources.AccesAuDonnees;
using XamarinGEstener.Resources.ClasseMetier;
using System;
using System.Collections.Generic;
using Android.Views;

namespace XamarinGEstener
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", Icon = "@drawable/container", MainLauncher = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity
    {
        Container container1 = new Container(1,"ASV256", 1, DateTime.Now, "FR");
        Container container2 = new Container(2, "ASV257",2, DateTime.Now, "ES");
        Container container3 = new Container(3, "ASV258", 2, DateTime.Now, "IT");


        List<Container> ListCont = new List<Container>();
        AccesAuDonneesContainer db;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            db = new AccesAuDonneesContainer();

            db.deleteDatabase();
            db.createDatabase();
            db.InsertIntoTable(container1);
            db.InsertIntoTable(container2);
            db.InsertIntoTable(container3);


            //if (db.SelectTable(container1.codeprop) == false) {
            //    db.InsertIntoTable(container1);
            //}
            //if (db.SelectTable(container2.codeprop) == false)
            //{
            //    db.InsertIntoTable(container2);
            //}
            //if (db.SelectTable(container3.codeprop) == false)
            //{
            //    db.InsertIntoTable(container2);
            //}


            ListCont = db.SelectTable();

            Button Actualiser = (Button)FindViewById(Resource.Id.ButtonAcutaliser);
            TableLayout tc = (TableLayout)FindViewById(Resource.Id.tableLayoutContainer);
            
            
            

            Actualiser.Click += (o, e) =>
            {
                int compt = 0;
                string color;
                foreach (Container unContainer in ListCont)
                {
                     
                    TableRow tr = new TableRow(this);

                    tr.Id = (100 + compt);

                    if (compt % 2 != 0)
                    {
                        color = "#84939b";
                    }
                    else
                    {
                        color = "#a7aead";
                    }

                    tr.SetBackgroundColor(Android.Graphics.Color.ParseColor(color));

                    TextView tvemplacement = new TextView(this);
                    tvemplacement.Text = unContainer.emplacmeent;
                    tvemplacement.Id = (200 + compt);
                    tvemplacement.Gravity = GravityFlags.Center;
                    tvemplacement.SetWidth(tr.Width);
                    tr.AddView(tvemplacement);

                    TextView tvnumserie = new TextView(this);
                    tvnumserie.Text = unContainer.numserie.ToString();
                    tvnumserie.Id = (300 + compt);
                    tvnumserie.Gravity = GravityFlags.Center;
                    tvnumserie.SetWidth(tr.Width);
                    tr.AddView(tvnumserie);

                    TextView tvdateEntree = new TextView(this);
                    tvdateEntree.Text = unContainer.dateEntree.ToString();
                    tvdateEntree.Id = (400 + compt);
                    tvdateEntree.Gravity = GravityFlags.Center;
                    tvdateEntree.SetWidth(tr.Width);
                    tr.AddView(tvdateEntree);

                    TextView tvcodepays = new TextView(this);
                    tvcodepays.Text = unContainer.CodPays;
                    tvcodepays.Id = (500 + compt);
                    tvcodepays.Gravity = GravityFlags.Center;
                    tvcodepays.SetWidth(tr.Width);
                    tr.AddView(tvcodepays);

                    tc.AddView(tr);
                    compt++;

                    
                }
                ListCont.Clear();
            };
        }
    }
}