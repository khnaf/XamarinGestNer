using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinGEstener.Resources.ClasseMetier
{
    public class Container
    {
        [PrimaryKey, AutoIncrement]
        public int codeprop { get; set; }
        public int numserie { get; set; }
        public int chiffrAuto { get; set; }
        public string codeForm { get; set; }
        public string sociClass { get; set; }
        public double massBrutMax { get; set; }
        public double tare { get; set; }
        public double chargeBrutMax { get; set; }
        public string agreDouan { get; set; }
        public string agreDiv { get; set; }
        public string idlISO { get; set; }
        public string CodPays { get; set; }
        public DateTime dateEntree { get; set; }
        public string emplacmeent { get; set; }

        public Container(int unCodeprop, int unNumserie, int unChiffrAuto, string unCodeForm, string unSociClass, double uneMassBrutMax, double unTare, double uneChargeBrutMax, string unAgreDouan, string unAgreDiv, string unIdlISO)
        {
            codeprop = unCodeprop;
            numserie = unNumserie;
            chiffrAuto = unChiffrAuto;
            codeForm = unCodeForm;
            sociClass = unSociClass;
            massBrutMax = uneMassBrutMax;
            tare = unTare;
            chargeBrutMax = uneChargeBrutMax;
            agreDouan = unAgreDouan;
            agreDiv = unAgreDiv;
            idlISO = unIdlISO;
        }
        public Container(int unCodeprop, string unEmplacement, int unNumserie, DateTime uneDateEntree, string unCodPays) {
            codeprop = unCodeprop;
            emplacmeent = unEmplacement;
            numserie = unNumserie;
            dateEntree = uneDateEntree;
            CodPays = unCodPays;
            
        }
        public Container() { }

    }
}