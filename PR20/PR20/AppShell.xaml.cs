using System;
using System.Collections.Generic;
using Xamarin.Forms;
using PR20.ViewModels;
using PR20.Views;

namespace PR20
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GetUserPage), typeof(GetUserPage));
            Routing.RegisterRoute(nameof(PostUserPage), typeof(PostUserPage));
            Routing.RegisterRoute(nameof(PutUserPage), typeof(PutUserPage));
            Routing.RegisterRoute(nameof(DeleteUserPage), typeof(DeleteUserPage));
        }

    }
}
