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
	public partial class Lista2 : ContentPage
	{
		public Lista2 ()
		{
			InitializeComponent ();
            CargarEventos();

        }


        private async void CargarEventos()
        {
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://misapis.azurewebsites.net");
            client.BaseAddress = new Uri("https://suspapi.azurewebsites.net");

            var request = await client.GetAsync("/api/eventos");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var listado = JsonConvert.DeserializeObject<List<Evento>>(responseJson);
                listEvento.ItemsSource = listado;
            }
            else
            {
                await DisplayAlert("Lo sentimos!", "Ha ocurrido un error de comunicacion", "OK");
            }
        }

        private async void ListPeliculas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Evento = (Evento)e.SelectedItem;
            //await Navigation.PushAsync(new LoginPage(Evento));
            await DisplayAlert("Evento", "El evento fue reportado con el 123", "OK");
        }
    }
}