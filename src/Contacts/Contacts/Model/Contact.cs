using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model.Services;

namespace View.Model
{
    /// <summary>
    /// Класс, представляющий контакт.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        string _name;
        /// <summary>
        /// Номер телефона.
        /// </summary>
        string _phoneNumber;
        /// <summary>
        /// Электронная почта.
        /// </summary>
        string _email;

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
                ValueValidator.AssertStringOnLength(value, 12, nameof(PhoneNumber));
                _phoneNumber = value;
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
            }
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
            Name = "name";
            PhoneNumber = "";
            Email = "email";
        }
    }
}
