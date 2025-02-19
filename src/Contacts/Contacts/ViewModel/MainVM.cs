﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
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
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
        /// <summary>
        /// Модель контакта, данные которой отображаются и редактируются в View.
        /// </summary>
        private Contact? _selectedContact { get; set; }
        /// <summary>
        /// Команда для добавления контакта.
        /// </summary>
        public ICommand AddContactCommand { get; }
        /// <summary>
        /// Команда для подтверждения действия.
        /// </summary>
        public ICommand ApplyCommand { get; }
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
            get { return SelectedContact.Name; }
            set
            {
                if (SelectedContact.Name != value)
                {
                    SelectedContact.Name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        /// <summary>
        /// Номер телефона контакта, связанный с соответствующим полем в View.
        /// </summary>
        public string PhoneNumber
        {
            get { return SelectedContact.PhoneNumber; }
            set
            {
                if (SelectedContact.PhoneNumber != value)
                {
                    SelectedContact.PhoneNumber = value;
                    NotifyPropertyChanged();
                }
            }
        }
        /// <summary>
        /// Адрес электронной почты контакта, связанный с соответствующим полем в View.
        /// </summary>
        public string Email
        { 
            get { return SelectedContact.Email; }
            set
            {
                if (SelectedContact.Email != value)
                {
                    SelectedContact.Email = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get { return _selectedContact ?? new Contact(); }
            set
            {
                if (value != _selectedContact)
                {
                    _selectedContact = value;
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
            AddContactCommand = new RelayCommand(_ =>
            {
                SelectedContact = new Contact();
                NotifyPropertyChanged(nameof(Name));
                NotifyPropertyChanged(nameof(PhoneNumber));
                NotifyPropertyChanged(nameof(Email));
            });
            ApplyCommand = new RelayCommand(_ =>
            {
                Contacts.Add(SelectedContact);
            });

            SaveCommand = new RelayCommand(_ =>
            {
                ContactSerializer.Save(Contacts);
            });
            LoadCommand = new RelayCommand(_ =>
            {
                Contacts = ContactSerializer.Load();

                NotifyPropertyChanged(nameof(Name));
                NotifyPropertyChanged(nameof(PhoneNumber));
                NotifyPropertyChanged(nameof(Email));
            });
        }
    }
}
