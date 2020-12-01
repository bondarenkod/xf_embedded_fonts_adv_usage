using fonts_demo.ViewModels;
using fonts_demo.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace fonts_demo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
