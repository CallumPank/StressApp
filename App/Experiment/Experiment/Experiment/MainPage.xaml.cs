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
        public object Email { get; private set; }

        public MainPage()
        {
            InitializeComponent();



        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.DataBase_Path))
            {
                connection.CreateTable<Data>();

                var data = connection.Table<Data>().ToList();

                userDataList.ItemsSource = data;
            }
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

        async void email(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new EmailPage());
        }

    }
}
