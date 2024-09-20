namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            DiscountsTabTableLayoutPanel = new TableLayoutPanel();
            InfoLabel = new Label();
            CalculateButton = new Button();
            ApplyButton = new Button();
            UpdateButton = new Button();
            TextProductsAmountLabel = new Label();
            ProductsAmountLabel = new Label();
            TextDiscountAmountLabel = new Label();
            DiscountAmountLabel = new Label();
            DiscountsTabTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DiscountsTabTableLayoutPanel
            // 
            DiscountsTabTableLayoutPanel.ColumnCount = 4;
            DiscountsTabTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            DiscountsTabTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            DiscountsTabTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3114758F));
            DiscountsTabTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.7796F));
            DiscountsTabTableLayoutPanel.Controls.Add(InfoLabel, 0, 0);
            DiscountsTabTableLayoutPanel.Controls.Add(CalculateButton, 0, 1);
            DiscountsTabTableLayoutPanel.Controls.Add(ApplyButton, 1, 1);
            DiscountsTabTableLayoutPanel.Controls.Add(UpdateButton, 2, 1);
            DiscountsTabTableLayoutPanel.Controls.Add(TextProductsAmountLabel, 3, 0);
            DiscountsTabTableLayoutPanel.Controls.Add(ProductsAmountLabel, 3, 1);
            DiscountsTabTableLayoutPanel.Controls.Add(TextDiscountAmountLabel, 3, 2);
            DiscountsTabTableLayoutPanel.Controls.Add(DiscountAmountLabel, 3, 3);
            DiscountsTabTableLayoutPanel.Dock = DockStyle.Fill;
            DiscountsTabTableLayoutPanel.Location = new Point(0, 0);
            DiscountsTabTableLayoutPanel.Name = "DiscountsTabTableLayoutPanel";
            DiscountsTabTableLayoutPanel.RowCount = 4;
            DiscountsTabTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DiscountsTabTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DiscountsTabTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DiscountsTabTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DiscountsTabTableLayoutPanel.Size = new Size(549, 209);
            DiscountsTabTableLayoutPanel.TabIndex = 0;
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            DiscountsTabTableLayoutPanel.SetColumnSpan(InfoLabel, 3);
            InfoLabel.Dock = DockStyle.Fill;
            InfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            InfoLabel.Location = new Point(3, 0);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(384, 52);
            InfoLabel.TabIndex = 0;
            InfoLabel.Text = "Info: ";
            InfoLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // CalculateButton
            // 
            CalculateButton.Dock = DockStyle.Fill;
            CalculateButton.Location = new Point(3, 55);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(131, 46);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Dock = DockStyle.Fill;
            ApplyButton.Location = new Point(140, 55);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(131, 46);
            ApplyButton.TabIndex = 2;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Dock = DockStyle.Fill;
            UpdateButton.Location = new Point(277, 55);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(110, 46);
            UpdateButton.TabIndex = 3;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // TextProductsAmountLabel
            // 
            TextProductsAmountLabel.AutoSize = true;
            TextProductsAmountLabel.Dock = DockStyle.Bottom;
            TextProductsAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextProductsAmountLabel.Location = new Point(393, 32);
            TextProductsAmountLabel.Name = "TextProductsAmountLabel";
            TextProductsAmountLabel.Size = new Size(153, 20);
            TextProductsAmountLabel.TabIndex = 4;
            TextProductsAmountLabel.Text = "Products Amount:";
            TextProductsAmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // ProductsAmountLabel
            // 
            ProductsAmountLabel.AutoSize = true;
            ProductsAmountLabel.Dock = DockStyle.Top;
            ProductsAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ProductsAmountLabel.Location = new Point(393, 52);
            ProductsAmountLabel.Name = "ProductsAmountLabel";
            ProductsAmountLabel.Size = new Size(153, 32);
            ProductsAmountLabel.TabIndex = 5;
            ProductsAmountLabel.Text = "0";
            ProductsAmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // TextDiscountAmountLabel
            // 
            TextDiscountAmountLabel.AutoSize = true;
            TextDiscountAmountLabel.Dock = DockStyle.Bottom;
            TextDiscountAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextDiscountAmountLabel.Location = new Point(393, 136);
            TextDiscountAmountLabel.Name = "TextDiscountAmountLabel";
            TextDiscountAmountLabel.Size = new Size(153, 20);
            TextDiscountAmountLabel.TabIndex = 6;
            TextDiscountAmountLabel.Text = "Discount Amount:";
            TextDiscountAmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Dock = DockStyle.Top;
            DiscountAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            DiscountAmountLabel.Location = new Point(393, 156);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(153, 32);
            DiscountAmountLabel.TabIndex = 7;
            DiscountAmountLabel.Text = "0";
            DiscountAmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // DiscountsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DiscountsTabTableLayoutPanel);
            Name = "DiscountsTab";
            Size = new Size(549, 209);
            DiscountsTabTableLayoutPanel.ResumeLayout(false);
            DiscountsTabTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel DiscountsTabTableLayoutPanel;
        private Label InfoLabel;
        private Button CalculateButton;
        private Button ApplyButton;
        private Button UpdateButton;
        private Label TextProductsAmountLabel;
        private Label ProductsAmountLabel;
        private Label TextDiscountAmountLabel;
        private Label DiscountAmountLabel;
    }
}
