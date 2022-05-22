using Newtonsoft.Json;
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
    public partial class PostUserPage : ContentPage
    {
        public PostUserPage()
        {
            InitializeComponent();
        }

        async void POSTuser(object sender, EventArgs e)
        {
            var user = new User { name = eName.Text, job = eJob.Text };
            // сериализация объекта с помощью Json.NET
            string json = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(json);

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync("https://reqres.in/api/users", content);

            HttpContent responseContent = response.Content;
            var result = await responseContent.ReadAsStringAsync();
            lResult.Text = $"Удача! ({result})";
        }


    }

    internal class User
    {
        public string name { get; set; }
        public string job { get; set; }
    }
}