using System;
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
using Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Класс управления вкладкой товаров (ItemsTab).
    /// Позволяет добавлять, удалять и редактировать товары в списке.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Текущий выбранный товар.
        /// </summary>
        Item _currentItem;
        /// <summary>
        /// Флаг, указывающий на системные изменения, чтобы избежать лишних действий при обновлении UI.
        /// </summary>
        bool isSystemChanged = false;

        /// <summary>
        /// Инициализирует новый экземпляр <c>ItemsTab</c>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            Provider.ItemsListBox = ItemsListBox;
            SelectedItemEvent(true);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки добавления нового товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Provider.Items.Add(new Item());
            ItemsListBox.Items.Add(Provider.Items[Provider.Items.Count - 1]);
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
                Provider.Items.Remove(_currentItem);
                ItemsListBox.Items.Remove(_currentItem);
                SelectedItemEvent(true);
            }
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле CostTextBox. 
        /// В случае ошибки отображает всплывающую подсказку с сообщением и меняет фон на розовый.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem == null || isSystemChanged) return;

            if (!Double.TryParse(CostTextBox.Text, out double cost))
            {
                CostTextBox.BackColor = Color.Pink;
                return;
            }

            try
            {
                CostTextBox.BackColor = Color.White;
                _currentItem.Cost = cost;
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
            if (_currentItem == null || isSystemChanged) return;

            try
            {
                NameRichTextBox.BackColor = Color.White;
                _currentItem.Name = NameRichTextBox.Text;
                UpdateItemsListBox();
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
            if (_currentItem == null || isSystemChanged) return;

            try
            {
                DescriptionRichTextBox.BackColor = Color.White;
                _currentItem.Info = DescriptionRichTextBox.Text;
            }
            catch (ArgumentException error)
            {
                CreateTooltip(DescriptionRichTextBox, error.Message);
                DescriptionRichTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Обработчик выбора товара в списке.
        /// Обновляет текущий товар и отображает его данные.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && ItemsListBox.SelectedItem != null)
            {
                _currentItem = (Item)ItemsListBox.SelectedItem;
                isSystemChanged = true;
                SelectedItemEvent();
                isSystemChanged = false;
            }
        }

        /// <summary>
        /// Обновляет список клиентов в <c>ItemsListBox</c> и выделяет текущий товар.
        /// </summary>
        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(Provider.Items.ToArray());
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

        private void ItemDataGenerateButton_Click(object sender, EventArgs e)
        {
            if (_currentItem == null || ItemsListBox.SelectedItems == null || !int.TryParse(IdTextBox.Text, out int _)) return;
            Item item = ItemFactory.Randomize();
            NameRichTextBox.Text = item.Name;
            DescriptionRichTextBox.Text = item.Info;
            CostTextBox.Text = item.Cost.ToString();
        }
    }
}
