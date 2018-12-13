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
	public partial class Contact : ContentPage
	{
		public Contact ()
		{
			InitializeComponent ();
		}

        
        private void backToHome(object sender, EventArgs args)
        {
            Data userdata = new Data()
            {
                NameOfContact = NameEntry1.Text,
                Relationship = RelationshipEntry1.Text,
                MobileNumber = MobileEntry1.Text,
                HomeNumber = HomeEntry1.Text
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