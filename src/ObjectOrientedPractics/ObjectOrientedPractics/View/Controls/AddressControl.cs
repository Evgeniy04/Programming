using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Пользовательский элемент управления, представляющий адрес с полями для ввода и отображения.
    /// Позволяет управлять данными адреса и обновлять их отображение на основе ввода пользователя.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Поле, которое хранит адресс.
        /// </summary>
        Address _address;

        /// <summary>
        /// Получает или устанавливает объект <see cref="Address"/>.
        /// При установке нового значения обновляются данные в пользовательском элементе управления.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                UpdateData();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddressControl"/> и устанавливает начальное значение для <see cref="Address"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле индекса почты.
        /// Проверяет валидность введенного значения и обновляет свойство <see cref="Address.Index"/> если значение корректно.
        /// </summary>
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(PostIndexTextBox.Text, out int index))
            {
                PostIndexTextBox.BackColor = Color.Pink;
                return;
            }

            try
            {
                PostIndexTextBox.BackColor = Color.White;
                Address.Index = index;
            }
            catch (ArgumentException error)
            {
                CreateTooltip(PostIndexTextBox, error.Message);
                PostIndexTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле страны.
        /// Обновляет свойство <see cref="Address.Country"/> на основе введенного текста.
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = Color.White;
                Address.Country = CountryTextBox.Text;
            }
            catch (ArgumentException error)
            {
                CreateTooltip(CountryTextBox, error.Message);
                CountryTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле города.
        /// Обновляет свойство <see cref="Address.City"/> на основе введенного текста.
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = Color.White;
                Address.City = CityTextBox.Text;
            }
            catch (ArgumentException error)
            {
                CreateTooltip(CityTextBox, error.Message);
                CityTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле улицы.
        /// Обновляет свойство <see cref="Address.Street"/> на основе введенного текста.
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = Color.White;
                Address.Street = StreetTextBox.Text;
            }
            catch (ArgumentException error)
            {
                CreateTooltip(StreetTextBox, error.Message);
                StreetTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле здания.
        /// Обновляет свойство <see cref="Address.Building"/> на основе введенного текста.
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = Color.White;
                Address.Building = BuildingTextBox.Text;
            }
            catch (ArgumentException error)
            {
                CreateTooltip(BuildingTextBox, error.Message);
                BuildingTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле квартиры.
        /// Обновляет свойство <see cref="Address.Apartment"/> на основе введенного текста.
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = Color.White;
                Address.Apartment = ApartmentTextBox.Text;
            }
            catch (ArgumentException error)
            {
                CreateTooltip(ApartmentTextBox, error.Message);
                ApartmentTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Обновляет данные в пользовательском элементе управления на основе текущих значений свойства <see cref="Address"/>.
        /// </summary>
        private void UpdateData()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        /// <summary>
        /// Создает подсказку с сообщением об ошибке для текстового поля.
        /// </summary>
        /// <param name="textBox">Текстовое поле, для которого создается подсказка.</param>
        /// <param name="errorMessage">Сообщение об ошибке.</param>
        private void CreateTooltip(TextBox textBox, string errorMessage)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutomaticDelay = 500;
            toolTip.SetToolTip(textBox, errorMessage);
        }
    }
}
