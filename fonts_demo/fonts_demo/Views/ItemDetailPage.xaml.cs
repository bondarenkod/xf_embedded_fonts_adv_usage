using fonts_demo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace fonts_demo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}