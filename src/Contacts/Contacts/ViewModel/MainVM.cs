using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна приложения, отвечает за взаимодействие между View и Model.
    /// </summary>
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Модель контакта, данные которой отображаются и редактируются в View.
        /// </summary>
        private Contact Contact { get; set; } = new Contact("", "", "");
        /// <summary>
        /// Команда для сохранения данных контакта в файл.
        /// </summary>
        public ICommand SaveCommand { get; }
        /// <summary>
        /// Команда для загрузки данных контакта из файла.
        /// </summary>
        public ICommand LoadCommand { get; }
        /// <summary>
        /// Событие, которое необходимо вызвать для уведомления View об изменениях свойств ViewModel.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Имя контакта, связанное с соответствующим полем в View.
        /// </summary>
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
        /// <summary>
        /// Номер телефона контакта, связанный с соответствующим полем в View.
        /// </summary>
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
        /// <summary>
        /// Адрес электронной почты контакта, связанный с соответствующим полем в View.
        /// </summary>
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

        /// <summary>
        /// Метод для уведомления View об изменении значения свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменившегося свойства (автоматически подставляется компилятором).</param>
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public MainVM()
        {
            SaveCommand = new SaveCommand(_ =>
            {
                ContactSerializer.Save(Contact);
            });
            LoadCommand = new LoadCommand(_ =>
            {
                Contact = ContactSerializer.Load();

                NotifyPropertyChanged(nameof(Name));
                NotifyPropertyChanged(nameof(PhoneNumber));
                NotifyPropertyChanged(nameof(Email));
            });
        }
    }
}
