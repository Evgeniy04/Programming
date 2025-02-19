using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    internal class MainVM : INotifyPropertyChanged
    {
        private Contact Contact { get; set; } = new Contact("", "", "");

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name
        {
            get { return Contact.Name; }
            set
            {
                if (Contact.Name != value)
                {
                    Contact.Name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string PhoneNumber
        {
            get { return Contact.PhoneNumber; }
            set
            {
                if (Contact.PhoneNumber != value)
                {
                    Contact.PhoneNumber = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Email
        { 
            get { return Contact.Email; }
            set
            {
                if (Contact.Email != value)
                {
                    Contact.Email = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
