using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model.Services;

namespace View.Model
{
    /// <summary>
    /// Класс, представляющий контакт.
    /// </summary>
    internal class Contact : INotifyPropertyChanged
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Электронная почта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Событие, которое необходимо вызвать для уведомления View об изменениях свойств Contact.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Получить или изменить имя.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Получить или изменить номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 25, nameof(PhoneNumber));
                _phoneNumber = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Получить или изменить электронную почту.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Email));
                _email = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Метод для уведомления View об изменении значения свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменившегося свойства 
        /// (автоматически подставляется компилятором).</param>
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Электронная почта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Конструктор класса без параметров.
        /// </summary>
        public Contact()
        {
            Name = "";
            PhoneNumber = "";
            Email = "";
        }

        /// <summary>
        /// Копировать значения свойств из исходного объекта в переданный объект.
        /// </summary>
        /// <param name="otherContact">Другой объект.</param>
        public void CopyValues(Contact otherContact)
        {
            otherContact.Name = Name;
            otherContact.PhoneNumber = PhoneNumber;
            otherContact.Email = Email;
        }

        /// <summary>
        /// Получить клон экземпляра класса.
        /// </summary>
        /// <returns>Новый экземпляр класса.</returns>
        public Contact Clone()
        {
            return (Contact)MemberwiseClone();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
