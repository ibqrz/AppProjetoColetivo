﻿
using AppMarcas.Helpers;

namespace AppMarcas
{
    public partial class App : Application
    {

        static SQLiteDatabaseHelpers _db;
        public static SQLiteDatabaseHelpers Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                    "bando_sqlite_marcas.db3");
                    _db = new SQLiteDatabaseHelpers(path);

                    /*ou 
                    string path = "c:\\bando_sqlite_marcas.db3"; */
                }
                return _db;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
