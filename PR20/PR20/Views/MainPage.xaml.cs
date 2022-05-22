using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PR20.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void GoToGET(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GetUserPage));
        }

        async void GoToPOST(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PostUserPage));
        }

        async void GoToPUT(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PutUserPage));
        }

        async void GoToDELETE(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DeleteUserPage));
        }
    }
}