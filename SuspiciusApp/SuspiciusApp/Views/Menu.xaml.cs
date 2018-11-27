﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuspiciusApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListarPage : ContentPage
	{
		public ListarPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync( new ListarPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mi_cuenta());
        }

        private  void Button_Clicked_2(object sender, EventArgs e)
        {
             Navigation.PushAsync(new Ubicacion());
        }
    }
}