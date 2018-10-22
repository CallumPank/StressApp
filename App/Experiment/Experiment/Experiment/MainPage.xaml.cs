using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Experiment
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        async void checkIn(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HelloXamlPage());
        }

        async void distressed(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Distressed());
        }

        async void harmed(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Harmed());
        }

        async void contact(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Contact());
        }
    }
}
