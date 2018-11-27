using Newtonsoft.Json;
using SuspiciusApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuspiciusApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Mi_cuenta : ContentPage
	{

		public Mi_cuenta()
		{
            CargarUser();
        }
        private async void CargarUser()
        {
            try
            {

            
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://misapis.azurewebsites.net");
            client.BaseAddress = new Uri("https://suspapi.azurewebsites.net");

            var request = await client.GetAsync("/api/users");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var listado = JsonConvert.DeserializeObject<List<Micuenta>>(responseJson);
                ListaUser.ItemsSource = listado;
            }
            else
            {
                await DisplayAlert("Lo sentimos!", "Ha ocurrido un error de comunicacion", "OK");
            }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}