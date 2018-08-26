using Plugin.Messaging;
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
	public partial class DoctorView : ContentPage
	{
        Doctor Doctors { get; set; }
        Doctor EditDoctor { get; set; }
        Doctor CurrentDoctor { get; set; }
        public DoctorView (Doctor doctor)
		{
			InitializeComponent ();

            CurrentDoctor = doctor;
            EditDoctor = new Doctor()
            {
                Title = doctor.Title,
                Address = doctor.Address,
                PhoneNumber = doctor.PhoneNumber,
                Name = doctor.Name
            };

            BindingContext = EditDoctor;
        }
        public DoctorView()
        {
            InitializeComponent();
        }

        private void CallPhone_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall(Doctors.PhoneNumber );
        }

        private void SMSPhone_Clicked(object sender, EventArgs e)
        {
           // var smsMessenger = CrossMessaging.Current.SmsMessenger;
           // if (smsMessenger.CanSendSms)
            {
                Navigation.PushAsync(new Page1());
                //smsMessenger.SendSmsInBackground(Doctors.PhoneNumber, "Test send SMS");
                //DisplayAlert("Thong Bao", "Goi tin nhan thanh cong!", "OK");
            }
               // smsMessenger.SendSms(Doctors.PhoneNumber, "Test send SMS");
           
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            CurrentDoctor.Name = EditDoctor.Name;
            CurrentDoctor.Title = EditDoctor.Title;
            Navigation.PopAsync();
                
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {

        }
    }
}