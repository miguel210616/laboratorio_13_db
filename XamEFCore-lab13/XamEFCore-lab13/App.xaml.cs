using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamEFCoreLab13.Views;
using XamEFCoreLab13.DataContext;
using XamEFCoreLab13.Interfaces;

namespace XamEFCore_lab13
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            MainPage = new NavigationPage(new AlbumesPage());

        }

        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
