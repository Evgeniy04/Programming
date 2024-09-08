namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            SelectedCustomerPanel = new Panel();
            SelectedItemLabel = new Label();
            AddressRichTextBox = new RichTextBox();
            FullnameTextBox = new TextBox();
            IdTextBox = new TextBox();
            AddressLabel = new Label();
            FullnameLabel = new Label();
            IdLabel = new Label();
            CustomersLabel = new Label();
            CustomersTableLayoutPanel = new TableLayoutPanel();
            CustomerDataGenerateButton = new Button();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomerPanel.SuspendLayout();
            CustomersTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedCustomerPanel
            // 
            SelectedCustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectedCustomerPanel.BackColor = SystemColors.ControlLightLight;
            SelectedCustomerPanel.Controls.Add(SelectedItemLabel);
            SelectedCustomerPanel.Controls.Add(AddressRichTextBox);
            SelectedCustomerPanel.Controls.Add(FullnameTextBox);
            SelectedCustomerPanel.Controls.Add(IdTextBox);
            SelectedCustomerPanel.Controls.Add(AddressLabel);
            SelectedCustomerPanel.Controls.Add(FullnameLabel);
            SelectedCustomerPanel.Controls.Add(IdLabel);
            SelectedCustomerPanel.Location = new Point(346, 3);
            SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            CustomersTableLayoutPanel.SetRowSpan(SelectedCustomerPanel, 2);
            SelectedCustomerPanel.Size = new Size(469, 191);
            SelectedCustomerPanel.TabIndex = 3;
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SelectedItemLabel.Location = new Point(13, 8);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(139, 20);
            SelectedItemLabel.TabIndex = 1;
            SelectedItemLabel.Text = "Selected Customer";
            // 
            // AddressRichTextBox
            // 
            AddressRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressRichTextBox.Location = new Point(122, 117);
            AddressRichTextBox.MinimumSize = new Size(196, 0);
            AddressRichTextBox.Name = "AddressRichTextBox";
            AddressRichTextBox.Size = new Size(332, 71);
            AddressRichTextBox.TabIndex = 12;
            AddressRichTextBox.Text = "";
            AddressRichTextBox.TextChanged += AddressRichTextBox_TextChanged;
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullnameTextBox.Location = new Point(122, 81);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(332, 27);
            FullnameTextBox.TabIndex = 11;
            FullnameTextBox.TextChanged += FullnameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(122, 48);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 10;
            IdTextBox.KeyPress += DisableTextBox;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(13, 117);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(65, 20);
            AddressLabel.TabIndex = 8;
            AddressLabel.Text = "Address:";
            // 
            // FullnameLabel
            // 
            FullnameLabel.AutoSize = true;
            FullnameLabel.Location = new Point(13, 84);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(79, 20);
            FullnameLabel.TabIndex = 7;
            FullnameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(13, 51);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 6;
            IdLabel.Text = "ID:";
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Dock = DockStyle.Bottom;
            CustomersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CustomersLabel.Location = new Point(3, 11);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(152, 20);
            CustomersLabel.TabIndex = 0;
            CustomersLabel.Text = "Customers";
            // 
            // CustomersTableLayoutPanel
            // 
            CustomersTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersTableLayoutPanel.ColumnCount = 4;
            CustomersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.37456F));
            CustomersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6672163F));
            CustomersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.03746F));
            CustomersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.92076F));
            CustomersTableLayoutPanel.Controls.Add(CustomerDataGenerateButton, 2, 3);
            CustomersTableLayoutPanel.Controls.Add(CustomersLabel, 0, 0);
            CustomersTableLayoutPanel.Controls.Add(RemoveItemButton, 1, 3);
            CustomersTableLayoutPanel.Controls.Add(AddItemButton, 0, 3);
            CustomersTableLayoutPanel.Controls.Add(CustomersListBox, 0, 1);
            CustomersTableLayoutPanel.Controls.Add(SelectedCustomerPanel, 3, 0);
            CustomersTableLayoutPanel.Location = new Point(0, 0);
            CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            CustomersTableLayoutPanel.RowCount = 4;
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CustomersTableLayoutPanel.Size = new Size(818, 412);
            CustomersTableLayoutPanel.TabIndex = 2;
            // 
            // CustomerDataGenerateButton
            // 
            CustomerDataGenerateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerDataGenerateButton.Location = new Point(264, 366);
            CustomerDataGenerateButton.Name = "CustomerDataGenerateButton";
            CustomerDataGenerateButton.Size = new Size(76, 43);
            CustomerDataGenerateButton.TabIndex = 3;
            CustomerDataGenerateButton.Text = "Gen";
            CustomerDataGenerateButton.UseVisualStyleBackColor = true;
            CustomerDataGenerateButton.Click += CustomerDataGenerateButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(161, 366);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(97, 43);
            RemoveItemButton.TabIndex = 5;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveCustomerButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddItemButton.Location = new Point(3, 366);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(152, 43);
            AddItemButton.TabIndex = 4;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddCustomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersTableLayoutPanel.SetColumnSpan(CustomersListBox, 3);
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(3, 34);
            CustomersListBox.MinimumSize = new Size(0, 324);
            CustomersListBox.Name = "CustomersListBox";
            CustomersTableLayoutPanel.SetRowSpan(CustomersListBox, 2);
            CustomersListBox.Size = new Size(337, 324);
            CustomersListBox.TabIndex = 4;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(CustomersTableLayoutPanel);
            Name = "CustomersTab";
            Size = new Size(818, 412);
            SelectedCustomerPanel.ResumeLayout(false);
            SelectedCustomerPanel.PerformLayout();
            CustomersTableLayoutPanel.ResumeLayout(false);
            CustomersTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SelectedCustomerPanel;
        private Label SelectedItemLabel;
        private RichTextBox AddressRichTextBox;
        private TextBox FullnameTextBox;
        private TextBox IdTextBox;
        private Label AddressLabel;
        private Label FullnameLabel;
        private Label IdLabel;
        private TableLayoutPanel CustomersTableLayoutPanel;
        private Label CustomersLabel;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private ListBox CustomersListBox;
        private Button CustomerDataGenerateButton;
    }
}
