using Newtonsoft.Json;
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
    public partial class PutUserPage : ContentPage
    {
        public PutUserPage()
        {
            InitializeComponent();
        }

        async void PUTuser(object sender, EventArgs e)
        {
            try
            {
                int test = Int32.Parse(eID.Text);

                var user = new User { name = eName.Text, job = eJob.Text };
                // сериализация объекта с помощью Json.NET
                string json = JsonConvert.SerializeObject(user);
                HttpContent content = new StringContent(json);

                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.PutAsync($"https://reqres.in/api/users/{eID.Text}", content);

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