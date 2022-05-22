using PR20.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PR20.Views
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