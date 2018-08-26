using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XFDemo.Models
{
    public class Doctor : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set {
            if(_name != value)
                {
                    _name = value;
                    // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    RaisePropertyChanged(nameof(Name));
                }
                    }
                }

        public string Title { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }
    }
    
       
       
   // public event PropertyChangedEventHandler PropertyChanged;
}



