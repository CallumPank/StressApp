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
	public partial class Harmed : ContentPage
	{
		public Harmed ()
		{
			InitializeComponent ();
            Picker.Items.Add("1");
            Picker.Items.Add("2");
            Picker.Items.Add("3");
            Picker.Items.Add("4");
            Picker.Items.Add("5");
            Picker.Items.Add("6");
            Picker.Items.Add("7");
            Picker.Items.Add("8");
            Picker.Items.Add("9");
            Picker.Items.Add("10");
        }

        void EditorCompleted(object sender, EventArgs e)
        {
            var text = ((Editor)sender).Text; // sender is cast to an Editor to enable reading the `Text` property of the view.
        }

        void Save(object sender, EventArgs args)
        {
            DisplayAlert("Success", "Yus Yus", "Close");
        }

        async void contactNumbers(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Contact());
        }

        async void backToHome(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}