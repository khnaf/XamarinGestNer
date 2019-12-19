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
using Java.Lang;

namespace XamarinGEstener.Resources.ClasseMetier
{
    public class ViewHolder : Java.Lang.Object
    {
        public TableLayout RowEmplacement { get; set; }
        public TableLayout Numero { get; set; }
        public TableLayout DateEntree { get; set; }
        public TableLayout Pays { get; set; }


    }
    public class ListViewAdaptater : BaseAdapter
    {
        private Activity activity;
        private List<Container> ListeContainer;

        public ListViewAdaptater(Activity uneactivity, List<Container> uneListeContainer)
        {
            this.activity = uneactivity;
            this.ListeContainer = uneListeContainer;
        }
        public override int Count {
            get { return ListeContainer.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return ListeContainer[position].codeprop;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            throw new NotImplementedException();
        }
    }
}