using fonts_demo.Services;
using fonts_demo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fonts_demo
{
    public static class AppFont
    {
        public static string Regular { get; set; }
    }

    public partial class App : Application
    {

        public App()
        {
            AppFont.Regular = fonts_collection_1.ExportFonts.Regular;
            //AppFont.Regular = fonts_collection_2.ExportFonts.Regular;

            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
