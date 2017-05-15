using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using AppSQLite.Interfaces;
using SQLite;

namespace AppSQLite
{
    public partial class App : Application
    {
        static SQLiteConnection database;

        public static SQLiteConnection Database
        {
            get
            {
                if (database == null)
                {
                    database = new SQLiteConnection(DependencyService.Get<IFileHelper>().GetLocalFilePath("Database.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppSQLite.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
