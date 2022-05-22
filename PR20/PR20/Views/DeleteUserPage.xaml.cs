using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PR20.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeleteUserPage : ContentPage
    {
        public DeleteUserPage()
        {
            InitializeComponent();
        }

        async void DELETEuser(object sender, EventArgs e)
        {
            try
            {
                int test = Int32.Parse(eID.Text);

                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.DeleteAsync($"https://reqres.in/api/users/{eID.Text}");

                HttpContent responseContent = response.Content;
                var result = await responseContent.ReadAsStringAsync();
                lResult.Text = $"Удача... Вроде ^^' ({result})";
            }
            catch
            {
                lResult.Text = $"Неудача. Введите ЧИСЛО для возможного результата, а не ({eID.Text})";
            }
        }
    }
}