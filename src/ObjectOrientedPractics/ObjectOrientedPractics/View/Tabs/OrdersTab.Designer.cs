namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            Model.Address address1 = new Model.Address();
            tableLayoutPanel1 = new TableLayoutPanel();
            SelectedItemPanel = new Panel();
            PriorityOptionsPanel = new Panel();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            PriorityOptionsLabel = new Label();
            OrderItemsListBox = new ListBox();
            AmountLabel = new Label();
            TextAmountLabel = new Label();
            AddressControl = new Controls.AddressControl();
            StatusComboBox = new ComboBox();
            StatusLabel = new Label();
            SelectedOrderLabel = new Label();
            ChangedAtTextBox = new TextBox();
            IdTextBox = new TextBox();
            OrderItemsLabel = new Label();
            ChangedAtLabel = new Label();
            IdLabel = new Label();
            OrdersLabel = new Label();
            OrdersDataGridView = new DataGridView();
            FindLabel = new Label();
            FindTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SelectedItemPanel.SuspendLayout();
            PriorityOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.2854F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.7146F));
            tableLayoutPanel1.Controls.Add(SelectedItemPanel, 2, 0);
            tableLayoutPanel1.Controls.Add(OrdersLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(OrdersDataGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(FindLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(FindTextBox, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(0, 565);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(979, 565);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // SelectedItemPanel
            // 
            SelectedItemPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectedItemPanel.BackColor = SystemColors.ControlLightLight;
            SelectedItemPanel.Controls.Add(PriorityOptionsPanel);
            SelectedItemPanel.Controls.Add(OrderItemsListBox);
            SelectedItemPanel.Controls.Add(AmountLabel);
            SelectedItemPanel.Controls.Add(TextAmountLabel);
            SelectedItemPanel.Controls.Add(AddressControl);
            SelectedItemPanel.Controls.Add(StatusComboBox);
            SelectedItemPanel.Controls.Add(StatusLabel);
            SelectedItemPanel.Controls.Add(SelectedOrderLabel);
            SelectedItemPanel.Controls.Add(ChangedAtTextBox);
            SelectedItemPanel.Controls.Add(IdTextBox);
            SelectedItemPanel.Controls.Add(OrderItemsLabel);
            SelectedItemPanel.Controls.Add(ChangedAtLabel);
            SelectedItemPanel.Controls.Add(IdLabel);
            SelectedItemPanel.Dock = DockStyle.Fill;
            SelectedItemPanel.Location = new Point(438, 3);
            SelectedItemPanel.Name = "SelectedItemPanel";
            tableLayoutPanel1.SetRowSpan(SelectedItemPanel, 3);
            SelectedItemPanel.Size = new Size(538, 559);
            SelectedItemPanel.TabIndex = 4;
            // 
            // PriorityOptionsPanel
            // 
            PriorityOptionsPanel.Controls.Add(DeliveryTimeComboBox);
            PriorityOptionsPanel.Controls.Add(DeliveryTimeLabel);
            PriorityOptionsPanel.Controls.Add(PriorityOptionsLabel);
            PriorityOptionsPanel.Location = new Point(269, 0);
            PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            PriorityOptionsPanel.Size = new Size(266, 149);
            PriorityOptionsPanel.TabIndex = 1;
            PriorityOptionsPanel.Visible = false;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(112, 47);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(151, 28);
            DeliveryTimeComboBox.TabIndex = 2;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(3, 51);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(103, 20);
            DeliveryTimeLabel.TabIndex = 1;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PriorityOptionsLabel.Location = new Point(3, 8);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Size = new Size(120, 20);
            PriorityOptionsLabel.TabIndex = 0;
            PriorityOptionsLabel.Text = "Priority Options";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.BackColor = SystemColors.Control;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.Location = new Point(11, 353);
            OrderItemsListBox.MinimumSize = new Size(0, 150);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(524, 144);
            OrderItemsListBox.TabIndex = 19;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            AmountLabel.Location = new Point(146, 527);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(389, 32);
            AmountLabel.TabIndex = 18;
            AmountLabel.Text = "0";
            AmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TextAmountLabel
            // 
            TextAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TextAmountLabel.AutoSize = true;
            TextAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextAmountLabel.Location = new Point(464, 507);
            TextAmountLabel.Name = "TextAmountLabel";
            TextAmountLabel.Size = new Size(71, 20);
            TextAmountLabel.TabIndex = 17;
            TextAmountLabel.Text = "Amount:";
            // 
            // AddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            AddressControl.Address = address1;
            AddressControl.Enabled = false;
            AddressControl.Location = new Point(0, 148);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(477, 179);
            AddressControl.TabIndex = 16;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(93, 114);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(151, 28);
            StatusComboBox.TabIndex = 14;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(13, 117);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(52, 20);
            StatusLabel.TabIndex = 2;
            StatusLabel.Text = "Status:";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SelectedOrderLabel.Location = new Point(13, 8);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(111, 20);
            SelectedOrderLabel.TabIndex = 1;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // ChangedAtTextBox
            // 
            ChangedAtTextBox.BackColor = SystemColors.Control;
            ChangedAtTextBox.Location = new Point(93, 81);
            ChangedAtTextBox.Name = "ChangedAtTextBox";
            ChangedAtTextBox.Size = new Size(151, 27);
            ChangedAtTextBox.TabIndex = 11;
            ChangedAtTextBox.KeyPress += DisableTextBox;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(93, 48);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(151, 27);
            IdTextBox.TabIndex = 10;
            IdTextBox.KeyPress += DisableTextBox;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OrderItemsLabel.Location = new Point(13, 330);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(97, 20);
            OrderItemsLabel.TabIndex = 8;
            OrderItemsLabel.Text = "Order Items:";
            // 
            // ChangedAtLabel
            // 
            ChangedAtLabel.AutoSize = true;
            ChangedAtLabel.Location = new Point(11, 84);
            ChangedAtLabel.Name = "ChangedAtLabel";
            ChangedAtLabel.Size = new Size(71, 20);
            ChangedAtLabel.TabIndex = 7;
            ChangedAtLabel.Text = "Changed:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(11, 51);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 6;
            IdLabel.Text = "ID:";
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Dock = DockStyle.Bottom;
            OrdersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OrdersLabel.Location = new Point(3, 11);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(62, 20);
            OrdersLabel.TabIndex = 1;
            OrdersLabel.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToOrderColumns = true;
            OrdersDataGridView.AllowUserToResizeColumns = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(OrdersDataGridView, 2);
            OrdersDataGridView.Dock = DockStyle.Fill;
            OrdersDataGridView.Location = new Point(3, 34);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersVisible = false;
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersDataGridView.Size = new Size(429, 498);
            OrdersDataGridView.TabIndex = 2;
            OrdersDataGridView.CellContentClick += OrdersDataGridView_CellContentClick;
            OrdersDataGridView.KeyPress += DisableTextBox;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Dock = DockStyle.Fill;
            FindLabel.Location = new Point(3, 535);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(62, 30);
            FindLabel.TabIndex = 5;
            FindLabel.Text = "Find:";
            FindLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FindTextBox
            // 
            FindTextBox.Dock = DockStyle.Fill;
            FindTextBox.Location = new Point(71, 538);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(361, 27);
            FindTextBox.TabIndex = 6;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OrdersTab";
            Size = new Size(979, 565);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            SelectedItemPanel.ResumeLayout(false);
            SelectedItemPanel.PerformLayout();
            PriorityOptionsPanel.ResumeLayout(false);
            PriorityOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label OrdersLabel;
        private DataGridView OrdersDataGridView;
        private Panel SelectedItemPanel;
        private ComboBox StatusComboBox;
        private Label StatusLabel;
        private Label SelectedOrderLabel;
        private TextBox ChangedAtTextBox;
        private TextBox IdTextBox;
        private Label OrderItemsLabel;
        private Label ChangedAtLabel;
        private Label IdLabel;
        private Controls.AddressControl AddressControl;
        private Label AmountLabel;
        private Label TextAmountLabel;
        private ListBox OrderItemsListBox;
        private Label FindLabel;
        private TextBox FindTextBox;
        private Panel PriorityOptionsPanel;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private Label PriorityOptionsLabel;
    }
}
