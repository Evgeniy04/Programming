using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        List<Item> _items = [];
        Item _currentItem;
        bool isSystemChanged = false;

        public ItemsTab()
        {
            InitializeComponent();
            _items.Add(new Item("один", "декс", 12));
            ItemsListBox.Items.AddRange(_items.ToArray());
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _items.Add(new Item());
            ItemsListBox.Items.Add(_items[_items.Count - 1]);
            //UpdateItemsListBox();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentItem != null)
            {
                _items.Remove(_currentItem);
                ItemsListBox.Items.Remove(_currentItem);
                SelectedItemEvent(true);
            }
        }

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
            } catch (ArgumentException error)
            {
                CreateTooltip(CostTextBox, error.Message);
                CostTextBox.BackColor = Color.Pink;
            }
        }

        private void NameRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem == null || isSystemChanged) return;

            try
            {
                NameRichTextBox.BackColor = Color.White;
                _currentItem.Name = NameRichTextBox.Text;
            }
            catch (ArgumentException error)
            {
                CreateTooltip(NameRichTextBox, error.Message);
                NameRichTextBox.BackColor = Color.Pink;
            }
        }

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

        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(_items.ToArray());
        }

        private void SelectedItemEvent(bool isEmpty = false)
        {
            IdTextBox.BackColor = NameRichTextBox.BackColor = DescriptionRichTextBox.BackColor = CostTextBox.BackColor = Color.White;
            IdTextBox.Text = isEmpty ? "Ничего не выбрано" : _currentItem.Id.ToString();
            NameRichTextBox.Text = isEmpty ? "" : _currentItem.Name.ToString();
            DescriptionRichTextBox.Text = isEmpty ? "" : _currentItem.Info.ToString();
            CostTextBox.Text = isEmpty ? "0" : _currentItem.Cost.ToString();
        }

        private void CreateTooltip(TextBox textBox, string errorMessage)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutomaticDelay = 500;
            toolTip.SetToolTip(textBox, errorMessage);
        }
        private void CreateTooltip(RichTextBox richTextBox, string errorMessage)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutomaticDelay = 500;
            toolTip.SetToolTip(richTextBox, errorMessage);
        }

        private void DisableTextBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
