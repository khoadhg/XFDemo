using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFDemo.Models;

namespace XFDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : ContentPage
	{
        List<Doctor> Doctors { get; set; }

        public MainView()
        {
            InitializeComponent();
            if (Doctors == null)
            {
                Doctors = new List<Doctor>
                {
                    new Doctor()
                    {
                        Name = "NV A",
                        Title = "Y TA",
                        Address= "Can Tho",
                        PhoneNumber= "+918508244",
                        Image = "https://www.thuonghieu.info.vn/wp-content/uploads/2017/03/C%C3%B4ng-ty-C%E1%BB%95-ph%E1%BA%A7n-D%C6%B0%E1%BB%A3c-H%E1%BA%ADu-Giang.jpg"
                    },
                    new Doctor()
                    {
                        Name = "NV B",
                        Title = "Bac Si",
                        Address= "Can Tho",
                        PhoneNumber= "123 2",
                         Image = "https://www.thuonghieu.info.vn/wp-content/uploads/2017/03/C%C3%B4ng-ty-C%E1%BB%95-ph%E1%BA%A7n-D%C6%B0%E1%BB%A3c-H%E1%BA%ADu-Giang.jpg"
                    }
            };
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            ListViewDoctor.ItemsSource = Doctors;
        }
        private void ListViewDoctor_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var doctor = (Doctor)e.Item;

            Navigation.PushAsync(new DoctorView(doctor));
        }
    }
}