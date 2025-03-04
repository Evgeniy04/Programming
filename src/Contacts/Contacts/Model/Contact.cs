using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace View.Model
{
    /// <summary>
    /// Класс, представляющий контакт.
    /// </summary>
    internal class Contact : INotifyPropertyChanged, IDataErrorInfo
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
            get => _name;
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Получить или изменить номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Получить или изменить электронную почту.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
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
        public Contact Clone() => (Contact)MemberwiseClone();

        /// <summary>
        /// Индексатор, позволяющий обращаться к экземпляру класса как к массиву или словарю,
        /// используя ключ.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public string this[string propertyName]
        {
            get
            {
                string error = string.Empty;
                switch (propertyName)
                {
                    case nameof(Name):
                        if (string.IsNullOrWhiteSpace(Name))
                        {
                            error = "Имя обязательно для заполнения.";
                        }
                        else if (Name.Length > 100)
                        {
                            error = "Имя не может превышать 100 символов.";
                        }

                        break;
                    case nameof(PhoneNumber):
                        if (string.IsNullOrEmpty(PhoneNumber))
                        {
                            error = "Номер телефона обязателен для заполнения.";
                        }
                        else if (PhoneNumber.Length > 100)
                        {
                            error = "Номер телефона не может превышать 100 символов.";
                        }
                        else if (!Regex.IsMatch(PhoneNumber, @"^[0-9+\-\(\) ]*$"))
                        {
                            error = "Номер телефона может содержать только цифры и символы \"+-()\".";
                        }

                        break;
                    case nameof(Email):
                        if (string.IsNullOrWhiteSpace(Email))
                        {
                            error = "Электронная почта обязательна для заполнения.";
                        }
                        else if (Email.Length > 100)
                        {
                            error = "Электронная почта не может превышать 100 символов.";
                        }
                        else if (!Email.Contains("@"))
                        {
                            error = "Текст не соответствует формату электронной почты.";
                        }

                        break;
                }
                return error;
            }
        }

        /// <summary>
        /// Проверка на наличие ошибок.
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public bool HasErrors()
        {
            return typeof(Contact).GetProperties()
                .Any(prop => !string.IsNullOrEmpty(this[prop.Name]));
        }

        public string Error => String.Empty;
    }
}
