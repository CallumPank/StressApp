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
	public partial class Distressed : ContentPage
	{
		public Distressed ()
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

        private void backToHome(object sender, EventArgs args)
        {
            Data userdata = new Data()
            {
                //I have no idea what the end of Slider should be so i'm leaving it
                //SliderDataDistressed = Slider.Text
                
            };

            using (SQLite.SQLiteConnection connect = new SQLite.SQLiteConnection(App.DataBase_Path))
            {
                connect.CreateTable<Data>();
                var numberOfRows = connect.Insert(userdata);

                if (numberOfRows > 0)
                    DisplayAlert("Success", "Data successfully saved", "Close");
                else
                    DisplayAlert("Failed", "Data not saved", "Close");
            }

        }
    }
}