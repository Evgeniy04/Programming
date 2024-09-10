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
    public partial class CartsTab : UserControl
    {
        List<Item> _items;
        List<Customer> _customers;

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
                ItemsListBox.Items.AddRange(value.ToArray());
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                if (value == null) return;
                _customers = value;
                CustomerComboBox.Items.AddRange(value.ToArray());
            }
        }

        public CartsTab()
        {
            InitializeComponent();
        }
    }
}
