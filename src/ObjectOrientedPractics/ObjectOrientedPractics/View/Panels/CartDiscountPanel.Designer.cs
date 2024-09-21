namespace ObjectOrientedPractics.View.Panels
{
    partial class CartDiscountPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            CartDiscountTableLayoutPanel = new TableLayoutPanel();
            DiscountsLabel = new Label();
            TextDiscountAmountLabel = new Label();
            DiscountAmountLabel = new Label();
            DiscountsCheckedListBox = new CheckedListBox();
            CartDiscountTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CartDiscountTableLayoutPanel
            // 
            CartDiscountTableLayoutPanel.ColumnCount = 2;
            CartDiscountTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CartDiscountTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            CartDiscountTableLayoutPanel.Controls.Add(DiscountsLabel, 0, 0);
            CartDiscountTableLayoutPanel.Controls.Add(TextDiscountAmountLabel, 1, 0);
            CartDiscountTableLayoutPanel.Controls.Add(DiscountAmountLabel, 1, 1);
            CartDiscountTableLayoutPanel.Controls.Add(DiscountsCheckedListBox, 0, 1);
            CartDiscountTableLayoutPanel.Dock = DockStyle.Fill;
            CartDiscountTableLayoutPanel.Location = new Point(0, 0);
            CartDiscountTableLayoutPanel.Name = "CartDiscountTableLayoutPanel";
            CartDiscountTableLayoutPanel.RowCount = 2;
            CartDiscountTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CartDiscountTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CartDiscountTableLayoutPanel.Size = new Size(451, 273);
            CartDiscountTableLayoutPanel.TabIndex = 0;
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Dock = DockStyle.Bottom;
            DiscountsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DiscountsLabel.Location = new Point(3, 11);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(295, 20);
            DiscountsLabel.TabIndex = 0;
            DiscountsLabel.Text = "Discounts:";
            // 
            // TextDiscountAmountLabel
            // 
            TextDiscountAmountLabel.AutoSize = true;
            TextDiscountAmountLabel.Dock = DockStyle.Bottom;
            TextDiscountAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextDiscountAmountLabel.Location = new Point(304, 11);
            TextDiscountAmountLabel.Name = "TextDiscountAmountLabel";
            TextDiscountAmountLabel.Size = new Size(144, 20);
            TextDiscountAmountLabel.TabIndex = 1;
            TextDiscountAmountLabel.Text = "Discount Amount:";
            TextDiscountAmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Dock = DockStyle.Fill;
            DiscountAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            DiscountAmountLabel.Location = new Point(304, 31);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(144, 242);
            DiscountAmountLabel.TabIndex = 2;
            DiscountAmountLabel.Text = "0";
            DiscountAmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.BackColor = SystemColors.Control;
            DiscountsCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountsCheckedListBox.CheckOnClick = true;
            DiscountsCheckedListBox.Dock = DockStyle.Fill;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.HorizontalScrollbar = true;
            DiscountsCheckedListBox.IntegralHeight = false;
            DiscountsCheckedListBox.Location = new Point(3, 34);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(295, 236);
            DiscountsCheckedListBox.TabIndex = 3;
            DiscountsCheckedListBox.SelectedIndexChanged += DiscountsCheckedListBox_SelectedIndexChanged;
            // 
            // CartDiscountPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartDiscountTableLayoutPanel);
            Name = "CartDiscountPanel";
            Size = new Size(451, 273);
            CartDiscountTableLayoutPanel.ResumeLayout(false);
            CartDiscountTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel CartDiscountTableLayoutPanel;
        private Label DiscountsLabel;
        private Label TextDiscountAmountLabel;
        private Label DiscountAmountLabel;
        private CheckedListBox DiscountsCheckedListBox;
    }
}
