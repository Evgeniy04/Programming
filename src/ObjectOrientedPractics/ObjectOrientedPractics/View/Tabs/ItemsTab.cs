﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Класс управления вкладкой товаров (ItemsTab).
    /// Позволяет добавлять, удалять и редактировать товары в списке.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        List<Item> _items;
        /// <summary>
        /// Текущий выбранный товар.
        /// </summary>
        Item _currentItem;
        /// <summary>
        /// Флаг, указывающий на системные изменения, чтобы избежать лишних действий при обновлении UI.
        /// </summary>
        bool _isSystemChanged = false;

        /// <summary>
        /// Получает или задает список товаров.
        /// При установке значения добавляет товары в ListBox и вызывает событие сброса выбранного элемента.
        /// </summary>
        /// <value>Список объектов <see cref="Items"/>, представляющий клиентов.</value>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (value == null) return;
                _items = value;
                UpdateItemsListBox();
                SelectedItemEvent(true);
            }
        }
        /// <summary>
        /// Событие изменения товаров.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Инициализирует новый экземпляр <c>ItemsTab</c>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            SelectedItemEvent(true);
            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
            SortComboBox.Items.AddRange(["Name", "Cost (Ascending)", "Cost (Descending)"]);
            SortComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки добавления нового товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Items.Add(new Item());
            UpdateItemsListBox();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки удаления текущего товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentItem != null)
            {
                Items.Remove(_currentItem);
                UpdateItemsListBox();
                SelectedItemEvent(true);
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного элемента в ComboBox для категорий.
        /// </summary>
        /// <param name="sender">Источник события, ComboBox.</param>
        /// <param name="e">Аргументы события изменения индекса.</param>
        private void ItemDataGenerateButton_Click(object sender, EventArgs e)
        {
            if (_currentItem == null || ItemsListBox.SelectedItems == null || !int.TryParse(IdTextBox.Text, out int _)) return;
            Item item = ItemFactory.Randomize();
            NameRichTextBox.Text = item.Name;
            DescriptionRichTextBox.Text = item.Info;
            CostTextBox.Text = item.Cost.ToString();
            CategoryComboBox.SelectedItem = item.Category;
            ItemsListBox.SelectedItem = _currentItem;
            UpdateItemsListBox();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле CostTextBox. 
        /// В случае ошибки отображает всплывающую подсказку с сообщением и меняет фон на розовый.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem == null || _isSystemChanged) return;

            if (!Double.TryParse(CostTextBox.Text, out double cost))
            {
                CostTextBox.BackColor = Color.Pink;
                return;
            }

            try
            {
                CostTextBox.BackColor = Color.White;
                _currentItem.Cost = cost;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (ArgumentException error)
            {
                CreateTooltip(CostTextBox, error.Message);
                CostTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле NameRichTextBox. 
        /// В случае ошибки отображает всплывающую подсказку с сообщением и меняет фон на розовый.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void NameRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem == null || _isSystemChanged) return;

            try
            {
                NameRichTextBox.BackColor = Color.White;
                _currentItem.Name = NameRichTextBox.Text;
                UpdateItemsListBox();
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (ArgumentException error)
            {
                CreateTooltip(NameRichTextBox, error.Message);
                NameRichTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле DescriptionRichTextBox. 
        /// В случае ошибки отображает всплывающую подсказку с сообщением и меняет фон на розовый.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DescriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem == null || _isSystemChanged) return;

            try
            {
                DescriptionRichTextBox.BackColor = Color.White;
                _currentItem.Info = DescriptionRichTextBox.Text;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (ArgumentException error)
            {
                CreateTooltip(DescriptionRichTextBox, error.Message);
                DescriptionRichTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в текстовом поле.
        /// Обновляет список элементов, сбрасывает текущий элемент и уведомляет о выборе.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Событие, содержащее данные изменения текста.</param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateItemsListBox();
            _currentItem = new Item();
            ItemsListBox.SelectedItem = null;
            SelectedItemEvent(true);
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного элемента в комбобоксе сортировки.
        /// Обновляет список элементов и восстанавливает выбранный элемент.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Событие, содержащее данные изменения выбранного элемента.</param>
        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItemsListBox();
            ItemsListBox.SelectedItem = _currentItem;
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного элемента в ComboBox категорий.
        /// Обновляет категорию текущего элемента, если выбор был изменен пользователем.
        /// </summary>
        /// <param name="sender">Источник события, обычно это CategoryComboBox.</param>
        /// <param name="e">Параметры события изменения индекса.</param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem == null || CategoryComboBox.SelectedItem == null || _isSystemChanged) return;

            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обработчик выбора товара в списке.
        /// Обновляет текущий товар и отображает его данные.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                _currentItem = (Item)ItemsListBox.SelectedItem;
                _isSystemChanged = true;
                SelectedItemEvent();
                _isSystemChanged = false;
            }
        }

        /// <summary>
        /// Обновляет список клиентов в <c>ItemsListBox</c> и выделяет текущий товар.
        /// </summary>
        private void UpdateItemsListBox()
        {
            if (Items == null) return;

            var filteredItems = DataTools.Filter(Items, (item) => item.Name.Contains(FindTextBox.Text, StringComparison.OrdinalIgnoreCase));
            List<Item> sortedItems;

            switch (SortComboBox.SelectedIndex)
            {
                case 1:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => item1.Cost > item2.Cost);
                    break;
                case 2:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => item1.Cost < item2.Cost);
                    break;
                default:
                    sortedItems = DataTools.Sort(filteredItems, (item1, item2) => string.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase) > 0);
                    break;
            }
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(sortedItems.ToArray());
        }

        /// <summary>
        /// Обновляет текстовые поля в зависимости от выбранного клиента.
        /// </summary>
        /// <param name="isEmpty">Указывает, отображать ли заглушку.</param>
        private void SelectedItemEvent(bool isEmpty = false)
        {
            IdTextBox.BackColor = NameRichTextBox.BackColor = DescriptionRichTextBox.BackColor = CostTextBox.BackColor = Color.White;
            IdTextBox.Text = isEmpty ? "Ничего не выбрано" : _currentItem.Id.ToString();
            NameRichTextBox.Text = isEmpty ? "" : _currentItem.Name.ToString();
            DescriptionRichTextBox.Text = isEmpty ? "" : _currentItem.Info.ToString();
            CostTextBox.Text = isEmpty ? "0" : _currentItem.Cost.ToString();
            CategoryComboBox.SelectedItem = isEmpty ? null : _currentItem.Category;
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
        /// <summary>
        /// Создает подсказку с сообщением об ошибке для большого текстового поля.
        /// </summary>
        /// <param name="richTextBox">Поле с текстом, для которого создается подсказка.</param>
        /// <param name="errorMessage">Сообщение об ошибке.</param>
        private void CreateTooltip(RichTextBox richTextBox, string errorMessage)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutomaticDelay = 500;
            toolTip.SetToolTip(richTextBox, errorMessage);
        }

        /// <summary>
        /// Отключает ввод данных в текстовое поле при нажатии клавиши.
        /// </summary>
        private void DisableTextBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
