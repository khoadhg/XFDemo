using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();
            EntryUserName.Focus();

        }

        private void OnClick(object sender, EventArgs e)
        {
            if (EntryUserName.Text == "abc" && EntryPassword.Text == "123")
            {
                App.Current.MainPage = new NavigationPage( new MainView());
                     }
            else {
                DisplayAlert("Error!", "Wrong User or Pass", "OK");
            }
                
        }
    }
}