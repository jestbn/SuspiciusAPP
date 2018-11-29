using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace SuspiciusApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Ubicacion : ContentPage
	{
		public Ubicacion ()
		{
			InitializeComponent ();
            try
            {
                MyMap.MoveToRegion(
                    MapSpan.FromCenterAndRadius(
                            new Position(6.24, -75.56), Distance.FromMiles(1)));
            }
            catch (Exception e)
            {
                DisplayAlert("Tenemos problemas", "Intenta mas tarde :) " + e.ToString(), "OK!");
                Navigation.PushAsync(new LoginPage());
                // throw;
            }
            
            //var map = new Map(MapSpan.FromCenterAndRadius(
            //    new Position(6.244364, -75.560773),
            //    Distance.FromKilometers(0.5)))
            //        {
            //            IsShowingUser = true,
            //            VerticalOptions = LayoutOptions.FillAndExpand
            //        };
		}
	}
}