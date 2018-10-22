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

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            valueLabel.Text = args.NewValue.ToString("F3");
        }

        async void backToHome(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}