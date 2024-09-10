namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            ItemsLabel = new Label();
            CartsTableLayoutPanel = new TableLayoutPanel();
            ItemsListBox = new ListBox();
            AddToCartButton = new Button();
            panel1 = new Panel();
            RemoveItemButton = new Button();
            CreateOrderButton = new Button();
            ClearCartButton = new Button();
            AmountLabel = new Label();
            TextAmountLabel = new Label();
            CartListBox = new ListBox();
            CustomerComboBox = new ComboBox();
            CustomerLabel = new Label();
            CartLabel = new Label();
            CartsTableLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Dock = DockStyle.Bottom;
            ItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ItemsLabel.Location = new Point(3, 11);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(153, 20);
            ItemsLabel.TabIndex = 0;
            ItemsLabel.Text = "Items";
            // 
            // CartsTableLayoutPanel
            // 
            CartsTableLayoutPanel.ColumnCount = 3;
            CartsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0914612F));
            CartsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.6609535F));
            CartsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.2475853F));
            CartsTableLayoutPanel.Controls.Add(ItemsLabel, 0, 0);
            CartsTableLayoutPanel.Controls.Add(ItemsListBox, 0, 1);
            CartsTableLayoutPanel.Controls.Add(AddToCartButton, 0, 3);
            CartsTableLayoutPanel.Controls.Add(panel1, 2, 0);
            CartsTableLayoutPanel.Dock = DockStyle.Fill;
            CartsTableLayoutPanel.Location = new Point(0, 0);
            CartsTableLayoutPanel.Name = "CartsTableLayoutPanel";
            CartsTableLayoutPanel.RowCount = 4;
            CartsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CartsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 58.84956F));
            CartsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 41.15044F));
            CartsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            CartsTableLayoutPanel.Size = new Size(756, 435);
            CartsTableLayoutPanel.TabIndex = 1;
            // 
            // ItemsListBox
            // 
            CartsTableLayoutPanel.SetColumnSpan(ItemsListBox, 2);
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(3, 34);
            ItemsListBox.Name = "ItemsListBox";
            CartsTableLayoutPanel.SetRowSpan(ItemsListBox, 2);
            ItemsListBox.Size = new Size(339, 349);
            ItemsListBox.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Dock = DockStyle.Fill;
            AddToCartButton.Location = new Point(3, 389);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(153, 43);
            AddToCartButton.TabIndex = 2;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(RemoveItemButton);
            panel1.Controls.Add(CreateOrderButton);
            panel1.Controls.Add(ClearCartButton);
            panel1.Controls.Add(AmountLabel);
            panel1.Controls.Add(TextAmountLabel);
            panel1.Controls.Add(CartListBox);
            panel1.Controls.Add(CustomerComboBox);
            panel1.Controls.Add(CustomerLabel);
            panel1.Controls.Add(CartLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(348, 3);
            panel1.Name = "panel1";
            CartsTableLayoutPanel.SetRowSpan(panel1, 4);
            panel1.Size = new Size(405, 429);
            panel1.TabIndex = 3;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(195, 259);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(107, 29);
            RemoveItemButton.TabIndex = 10;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(13, 259);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(112, 29);
            CreateOrderButton.TabIndex = 9;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearCartButton.Location = new Point(308, 259);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(94, 29);
            ClearCartButton.TabIndex = 8;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            AmountLabel.Location = new Point(319, 224);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(83, 32);
            AmountLabel.TabIndex = 7;
            AmountLabel.Text = "label2";
            // 
            // TextAmountLabel
            // 
            TextAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TextAmountLabel.AutoSize = true;
            TextAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextAmountLabel.Location = new Point(331, 204);
            TextAmountLabel.Name = "TextAmountLabel";
            TextAmountLabel.Size = new Size(71, 20);
            TextAmountLabel.TabIndex = 6;
            TextAmountLabel.Text = "Amount:";
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.Location = new Point(13, 97);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(389, 104);
            CartListBox.TabIndex = 5;
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(101, 28);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(301, 28);
            CustomerComboBox.TabIndex = 1;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CustomerLabel.Location = new Point(13, 31);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(82, 20);
            CustomerLabel.TabIndex = 0;
            CustomerLabel.Text = "Customer:";
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(13, 74);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(39, 20);
            CartLabel.TabIndex = 4;
            CartLabel.Text = "Cart:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartsTableLayoutPanel);
            Name = "CartsTab";
            Size = new Size(756, 435);
            CartsTableLayoutPanel.ResumeLayout(false);
            CartsTableLayoutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label ItemsLabel;
        private TableLayoutPanel CartsTableLayoutPanel;
        private ListBox ItemsListBox;
        private Button AddToCartButton;
        private Panel panel1;
        private Label CustomerLabel;
        private ComboBox CustomerComboBox;
        private ListBox CartListBox;
        private Label CartLabel;
        private Label TextAmountLabel;
        private Label AmountLabel;
        private Button RemoveItemButton;
        private Button CreateOrderButton;
        private Button ClearCartButton;
    }
}
