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
            Model.Address address2 = new Model.Address();
            SelectedCustomerPanel = new Panel();
            IsPriorityCheckBox = new CheckBox();
            SelectedItemLabel = new Label();
            FullnameTextBox = new TextBox();
            IdTextBox = new TextBox();
            FullnameLabel = new Label();
            IdLabel = new Label();
            CustomersLabel = new Label();
            CustomersTableLayoutPanel = new TableLayoutPanel();
            CustomerDataGenerateButton = new Button();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            CustomersListBox = new ListBox();
            AddressControl = new Controls.AddressControl();
            AddOrderGenerateButton = new Button();
            discountsTab1 = new DiscountsTab();
            SelectedCustomerPanel.SuspendLayout();
            CustomersTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedCustomerPanel
            // 
            SelectedCustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectedCustomerPanel.BackColor = SystemColors.ControlLightLight;
            SelectedCustomerPanel.Controls.Add(IsPriorityCheckBox);
            SelectedCustomerPanel.Controls.Add(SelectedItemLabel);
            SelectedCustomerPanel.Controls.Add(FullnameTextBox);
            SelectedCustomerPanel.Controls.Add(IdTextBox);
            SelectedCustomerPanel.Controls.Add(FullnameLabel);
            SelectedCustomerPanel.Controls.Add(IdLabel);
            SelectedCustomerPanel.Location = new Point(346, 3);
            SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            CustomersTableLayoutPanel.SetRowSpan(SelectedCustomerPanel, 2);
            SelectedCustomerPanel.Size = new Size(469, 144);
            SelectedCustomerPanel.TabIndex = 3;
            // 
            // IsPriorityCheckBox
            // 
            IsPriorityCheckBox.AutoSize = true;
            IsPriorityCheckBox.Location = new Point(122, 114);
            IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            IsPriorityCheckBox.Size = new Size(92, 24);
            IsPriorityCheckBox.TabIndex = 3;
            IsPriorityCheckBox.Text = "Is Priority";
            IsPriorityCheckBox.UseVisualStyleBackColor = true;
            IsPriorityCheckBox.CheckedChanged += IsPriorityCheckBox_CheckedChanged;
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
            CustomersTableLayoutPanel.Controls.Add(discountsTab1, 3, 3);
            CustomersTableLayoutPanel.Controls.Add(CustomerDataGenerateButton, 2, 4);
            CustomersTableLayoutPanel.Controls.Add(CustomersLabel, 0, 0);
            CustomersTableLayoutPanel.Controls.Add(RemoveItemButton, 1, 4);
            CustomersTableLayoutPanel.Controls.Add(AddItemButton, 0, 4);
            CustomersTableLayoutPanel.Controls.Add(CustomersListBox, 0, 1);
            CustomersTableLayoutPanel.Controls.Add(SelectedCustomerPanel, 3, 0);
            CustomersTableLayoutPanel.Controls.Add(AddressControl, 3, 2);
            CustomersTableLayoutPanel.Controls.Add(AddOrderGenerateButton, 1, 0);
            CustomersTableLayoutPanel.Location = new Point(0, 0);
            CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            CustomersTableLayoutPanel.RowCount = 5;
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 119F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            CustomersTableLayoutPanel.Size = new Size(818, 542);
            CustomersTableLayoutPanel.TabIndex = 2;
            // 
            // CustomerDataGenerateButton
            // 
            CustomerDataGenerateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerDataGenerateButton.Location = new Point(264, 497);
            CustomerDataGenerateButton.Name = "CustomerDataGenerateButton";
            CustomerDataGenerateButton.Size = new Size(76, 42);
            CustomerDataGenerateButton.TabIndex = 3;
            CustomerDataGenerateButton.Text = "Gen";
            CustomerDataGenerateButton.UseVisualStyleBackColor = true;
            CustomerDataGenerateButton.Click += CustomerDataGenerateButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(161, 497);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(97, 42);
            RemoveItemButton.TabIndex = 5;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveCustomerButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddItemButton.Location = new Point(3, 497);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(152, 42);
            AddItemButton.TabIndex = 4;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddCustomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersTableLayoutPanel.SetColumnSpan(CustomersListBox, 3);
            CustomersListBox.Dock = DockStyle.Fill;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(3, 34);
            CustomersListBox.MinimumSize = new Size(0, 324);
            CustomersListBox.Name = "CustomersListBox";
            CustomersTableLayoutPanel.SetRowSpan(CustomersListBox, 3);
            CustomersListBox.Size = new Size(337, 457);
            CustomersListBox.TabIndex = 4;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // AddressControl
            // 
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = 100000;
            address2.Street = "";
            AddressControl.Address = address2;
            AddressControl.BackColor = SystemColors.ControlLightLight;
            AddressControl.Dock = DockStyle.Fill;
            AddressControl.Location = new Point(346, 153);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(469, 194);
            AddressControl.TabIndex = 6;
            // 
            // AddOrderGenerateButton
            // 
            AddOrderGenerateButton.Dock = DockStyle.Fill;
            AddOrderGenerateButton.Location = new Point(158, 0);
            AddOrderGenerateButton.Margin = new Padding(0);
            AddOrderGenerateButton.Name = "AddOrderGenerateButton";
            AddOrderGenerateButton.Size = new Size(103, 31);
            AddOrderGenerateButton.TabIndex = 3;
            AddOrderGenerateButton.Text = "GenOrder";
            AddOrderGenerateButton.UseVisualStyleBackColor = true;
            AddOrderGenerateButton.Click += AddOrderGenerateButton_Click;
            // 
            // discountsTab1
            // 
            discountsTab1.Dock = DockStyle.Fill;
            discountsTab1.Location = new Point(346, 353);
            discountsTab1.Name = "discountsTab1";
            CustomersTableLayoutPanel.SetRowSpan(discountsTab1, 2);
            discountsTab1.Size = new Size(469, 186);
            discountsTab1.TabIndex = 3;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(CustomersTableLayoutPanel);
            Name = "CustomersTab";
            Size = new Size(818, 542);
            SelectedCustomerPanel.ResumeLayout(false);
            SelectedCustomerPanel.PerformLayout();
            CustomersTableLayoutPanel.ResumeLayout(false);
            CustomersTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SelectedCustomerPanel;
        private Label SelectedItemLabel;
        private TextBox FullnameTextBox;
        private TextBox IdTextBox;
        private Label FullnameLabel;
        private Label IdLabel;
        private TableLayoutPanel CustomersTableLayoutPanel;
        private Label CustomersLabel;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private Button CustomerDataGenerateButton;
        public ListBox CustomersListBox;
        private Controls.AddressControl AddressControl;
        private Button AddOrderGenerateButton;
        private CheckBox IsPriorityCheckBox;
        private DiscountsTab discountsTab1;
    }
}
