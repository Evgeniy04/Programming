using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        PercentDiscount PercentDiscount {  get; set; }
        public List<Item> Items { get; set; }

        public DiscountsTab()
        {
            InitializeComponent();
            PercentDiscount = new PercentDiscount();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            PercentDiscount.Calculate(Items);
            UpdateLables();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            PercentDiscount.Apply(Items);
            UpdateLables();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            PercentDiscount.Update(Items);
            UpdateLables();
        }

        private void UpdateLables()
        {
            InfoLabel.Text = PercentDiscount.Info;
            ProductsAmountLabel.Text = PercentDiscount.GetAmount(Items).ToString();
            DiscountAmountLabel.Text = PercentDiscount.Calculate(Items).ToString();
        }
    }
}
