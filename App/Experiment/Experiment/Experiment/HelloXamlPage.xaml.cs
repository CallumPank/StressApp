using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Experiment
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HelloXamlPage : ContentPage
	{
		public HelloXamlPage ()
		{
			InitializeComponent ();
		}

        async void backToHome(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }

        async void contactNumbers(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Contact());
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs args)
        {
            valueLabel.Text = args.NewValue.ToString("F3");
        }


    }
}