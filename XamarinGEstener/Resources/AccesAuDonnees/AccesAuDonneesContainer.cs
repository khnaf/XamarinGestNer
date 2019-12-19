using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using SQLite;
using XamarinGEstener.Resources.ClasseMetier;
using Android.Util;

namespace XamarinGEstener.Resources.AccesAuDonnees
{
    public class AccesAuDonneesContainer
    {
        string dossier = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        string nomBDD = "container.db";

        /// <summary>
        /// Retourne le path vers la base de données
        /// </summary>
        /// <returns></returns>
        public string GetBDDdossier()
        {
            return Path.Combine(dossier, nomBDD);
        }
        
        public bool createDatabase()
        {
            try
            {
                using (var connexion = new SQLiteConnection(Path.Combine(dossier, nomBDD)))
                {
                    
                    connexion.CreateTable<Container>();
                    return true;
                }
            }
            catch(SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }

            
        }
        public bool deleteDatabase()
        {
            try
            {
                using (var connexion = new SQLiteConnection(Path.Combine(dossier, nomBDD)))
                {

                    connexion.DropTable<Container>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }


        }

        public bool InsertIntoTable(Container unContainer)
        {
            try
            {
                using (var connexion = new SQLiteConnection(Path.Combine(dossier, nomBDD)))
                {
                    connexion.Insert(unContainer);
                    return true;
                }

            }catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public List<Container> SelectTable()
        {
            try
            {
                using (var connexion = new SQLiteConnection(Path.Combine(dossier, nomBDD)))
                {
                    return connexion.Table<Container>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }

        public bool SelectTable(int codprop)
        {
            try
            {
                using (var connexion = new SQLiteConnection(Path.Combine(dossier, nomBDD)))
                {
                    connexion.Query<Container>("SELECT * FROM CONTAINER WHERE CODPROP = ?",codprop);
                    return true;
                }

            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }

        }

       

    }
}