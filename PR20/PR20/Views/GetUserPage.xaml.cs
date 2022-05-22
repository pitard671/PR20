using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PR20.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetUserPage : ContentPage
    {
        public GetUserPage()
        {
            InitializeComponent();
        }

        async void GETuser(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri($"https://reqres.in/api/users/{eID.Text}");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                HttpContent responseContent = response.Content;
                var json = await responseContent.ReadAsStringAsync();
                lResult.Text = (json.ToString());
            }
            else 
            {
                lResult.Text = "Кажется, такого пользователя не существует...";
            }

        }
    }
}