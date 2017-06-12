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




namespace FCI
{
    class DB
    {
        string dbPath = Path.Combine(
System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
         "Departments.db3");
        public DB()
        {
            if (!File.Exists(dbPath))

            {

            }

            //if (db.Table<Departments>().Count() == 0)

        }
    }
}