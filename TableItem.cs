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

namespace FCI
{
    public class TableItem
    {
        public string Heading;
        public string SubHeading;
        public int ImageResourceId;
        public TableItem(string Heading, string SubHeading, int ImageResourceId)
        {

            this.Heading = Heading;

            this.SubHeading = SubHeading;

            this.ImageResourceId = ImageResourceId;

        }

    }
}