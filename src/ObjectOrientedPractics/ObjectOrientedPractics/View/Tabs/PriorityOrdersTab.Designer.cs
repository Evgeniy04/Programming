namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            PriorityOptionsPanel = new Panel();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            SelectedOrderLabel = new Label();
            AddItemButton = new Button();
            PriorityOptionsLabel = new Label();
            RemoveItemButton = new Button();
            ClearOrderButton = new Button();
            AddressControl = new Controls.AddressControl();
            OrderItemsPanel = new Panel();
            OrderItemsListBox = new ListBox();
            OrderItemsLabel = new Label();
            AmountPanel = new Panel();
            AmountLabel = new Label();
            TextAmountLabel = new Label();
            SelectedOrderPanel = new Panel();
            StatusComboBox = new ComboBox();
            ChangedAtTextBox = new TextBox();
            IdTextBox = new TextBox();
            StatusLabel = new Label();
            ChangedAtLabel = new Label();
            IdLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            PriorityOptionsPanel.SuspendLayout();
            OrderItemsPanel.SuspendLayout();
            AmountPanel.SuspendLayout();
            SelectedOrderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.24138F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.75862F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 189F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191F));
            tableLayoutPanel1.Controls.Add(PriorityOptionsPanel, 3, 1);
            tableLayoutPanel1.Controls.Add(SelectedOrderLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(AddItemButton, 0, 5);
            tableLayoutPanel1.Controls.Add(PriorityOptionsLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(RemoveItemButton, 1, 5);
            tableLayoutPanel1.Controls.Add(ClearOrderButton, 4, 5);
            tableLayoutPanel1.Controls.Add(AddressControl, 0, 2);
            tableLayoutPanel1.Controls.Add(OrderItemsPanel, 0, 3);
            tableLayoutPanel1.Controls.Add(AmountPanel, 4, 4);
            tableLayoutPanel1.Controls.Add(SelectedOrderPanel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(0, 710);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(706, 711);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PriorityOptionsPanel
            // 
            tableLayoutPanel1.SetColumnSpan(PriorityOptionsPanel, 2);
            PriorityOptionsPanel.Controls.Add(DeliveryTimeComboBox);
            PriorityOptionsPanel.Controls.Add(DeliveryTimeLabel);
            PriorityOptionsPanel.Dock = DockStyle.Fill;
            PriorityOptionsPanel.Location = new Point(328, 34);
            PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            PriorityOptionsPanel.Size = new Size(375, 109);
            PriorityOptionsPanel.TabIndex = 0;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(129, 9);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(243, 28);
            DeliveryTimeComboBox.TabIndex = 1;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(20, 12);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(103, 20);
            DeliveryTimeLabel.TabIndex = 0;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Dock = DockStyle.Fill;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SelectedOrderLabel.Location = new Point(3, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Padding = new Padding(19, 0, 0, 0);
            SelectedOrderLabel.Size = new Size(160, 31);
            SelectedOrderLabel.TabIndex = 0;
            SelectedOrderLabel.Text = "Selected Order";
            SelectedOrderLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // AddItemButton
            // 
            AddItemButton.Dock = DockStyle.Fill;
            AddItemButton.Location = new Point(3, 674);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(160, 34);
            AddItemButton.TabIndex = 1;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Dock = DockStyle.Fill;
            PriorityOptionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PriorityOptionsLabel.Location = new Point(328, 0);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Padding = new Padding(19, 0, 0, 0);
            PriorityOptionsLabel.Size = new Size(183, 31);
            PriorityOptionsLabel.TabIndex = 2;
            PriorityOptionsLabel.Text = "Priority Options";
            PriorityOptionsLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Dock = DockStyle.Fill;
            RemoveItemButton.Location = new Point(169, 674);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(118, 34);
            RemoveItemButton.TabIndex = 3;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Dock = DockStyle.Fill;
            ClearOrderButton.Location = new Point(517, 674);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(186, 34);
            ClearOrderButton.TabIndex = 4;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
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
            tableLayoutPanel1.SetColumnSpan(AddressControl, 5);
            AddressControl.Dock = DockStyle.Fill;
            AddressControl.Location = new Point(3, 149);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(700, 174);
            AddressControl.TabIndex = 5;
            // 
            // OrderItemsPanel
            // 
            tableLayoutPanel1.SetColumnSpan(OrderItemsPanel, 5);
            OrderItemsPanel.Controls.Add(OrderItemsListBox);
            OrderItemsPanel.Controls.Add(OrderItemsLabel);
            OrderItemsPanel.Dock = DockStyle.Fill;
            OrderItemsPanel.Location = new Point(3, 329);
            OrderItemsPanel.Name = "OrderItemsPanel";
            OrderItemsPanel.Size = new Size(700, 279);
            OrderItemsPanel.TabIndex = 6;
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.Location = new Point(3, 32);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(694, 204);
            OrderItemsListBox.TabIndex = 1;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OrderItemsLabel.Location = new Point(19, 9);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(89, 20);
            OrderItemsLabel.TabIndex = 0;
            OrderItemsLabel.Text = "OrderItems";
            // 
            // AmountPanel
            // 
            AmountPanel.Controls.Add(AmountLabel);
            AmountPanel.Controls.Add(TextAmountLabel);
            AmountPanel.Dock = DockStyle.Fill;
            AmountPanel.Location = new Point(517, 614);
            AmountPanel.Name = "AmountPanel";
            AmountPanel.Size = new Size(186, 54);
            AmountPanel.TabIndex = 7;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            AmountLabel.Location = new Point(0, 26);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(183, 32);
            AmountLabel.TabIndex = 1;
            AmountLabel.Text = "0";
            AmountLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // TextAmountLabel
            // 
            TextAmountLabel.AutoSize = true;
            TextAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextAmountLabel.Location = new Point(115, 0);
            TextAmountLabel.Name = "TextAmountLabel";
            TextAmountLabel.Size = new Size(71, 20);
            TextAmountLabel.TabIndex = 0;
            TextAmountLabel.Text = "Amount:";
            // 
            // SelectedOrderPanel
            // 
            tableLayoutPanel1.SetColumnSpan(SelectedOrderPanel, 3);
            SelectedOrderPanel.Controls.Add(StatusComboBox);
            SelectedOrderPanel.Controls.Add(ChangedAtTextBox);
            SelectedOrderPanel.Controls.Add(IdTextBox);
            SelectedOrderPanel.Controls.Add(StatusLabel);
            SelectedOrderPanel.Controls.Add(ChangedAtLabel);
            SelectedOrderPanel.Controls.Add(IdLabel);
            SelectedOrderPanel.Dock = DockStyle.Fill;
            SelectedOrderPanel.Location = new Point(3, 34);
            SelectedOrderPanel.Name = "SelectedOrderPanel";
            SelectedOrderPanel.Size = new Size(319, 109);
            SelectedOrderPanel.TabIndex = 8;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(87, 75);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(229, 28);
            StatusComboBox.TabIndex = 5;
            // 
            // ChangedAtTextBox
            // 
            ChangedAtTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ChangedAtTextBox.Location = new Point(87, 42);
            ChangedAtTextBox.Name = "ChangedAtTextBox";
            ChangedAtTextBox.Size = new Size(229, 27);
            ChangedAtTextBox.TabIndex = 4;
            ChangedAtTextBox.KeyPress += DisableTextBox;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Location = new Point(87, 9);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(229, 27);
            IdTextBox.TabIndex = 3;
            IdTextBox.KeyPress += DisableTextBox;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(19, 78);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(52, 20);
            StatusLabel.TabIndex = 2;
            StatusLabel.Text = "Status:";
            // 
            // ChangedAtLabel
            // 
            ChangedAtLabel.AutoSize = true;
            ChangedAtLabel.Location = new Point(19, 45);
            ChangedAtLabel.Name = "ChangedAtLabel";
            ChangedAtLabel.Size = new Size(64, 20);
            ChangedAtLabel.TabIndex = 1;
            ChangedAtLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(19, 12);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PriorityOrdersTab";
            Size = new Size(706, 711);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            PriorityOptionsPanel.ResumeLayout(false);
            PriorityOptionsPanel.PerformLayout();
            OrderItemsPanel.ResumeLayout(false);
            OrderItemsPanel.PerformLayout();
            AmountPanel.ResumeLayout(false);
            AmountPanel.PerformLayout();
            SelectedOrderPanel.ResumeLayout(false);
            SelectedOrderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label SelectedOrderLabel;
        private Button AddItemButton;
        private Label PriorityOptionsLabel;
        private Button RemoveItemButton;
        private Button ClearOrderButton;
        private Controls.AddressControl AddressControl;
        private Panel OrderItemsPanel;
        private Panel AmountPanel;
        private Label TextAmountLabel;
        private Label AmountLabel;
        private Panel PriorityOptionsPanel;
        private Panel SelectedOrderPanel;
        private ComboBox StatusComboBox;
        private TextBox ChangedAtTextBox;
        private TextBox IdTextBox;
        private Label StatusLabel;
        private Label ChangedAtLabel;
        private Label IdLabel;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private ListBox OrderItemsListBox;
        private Label OrderItemsLabel;
    }
}
