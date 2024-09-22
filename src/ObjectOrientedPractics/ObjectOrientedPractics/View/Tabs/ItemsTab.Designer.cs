namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            SelectedItemPanel = new Panel();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            SelectedItemLabel = new Label();
            DescriptionRichTextBox = new RichTextBox();
            NameRichTextBox = new RichTextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            ItemsLabel = new Label();
            ItemsTableLayoutPanel = new TableLayoutPanel();
            ItemDataGenerateButton = new Button();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ItemsListBox = new ListBox();
            FindLabel = new Label();
            FindTextBox = new TextBox();
            OrderByLabel = new Label();
            SortComboBox = new ComboBox();
            SelectedItemPanel.SuspendLayout();
            ItemsTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedItemPanel
            // 
            SelectedItemPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectedItemPanel.BackColor = SystemColors.ControlLightLight;
            SelectedItemPanel.Controls.Add(CategoryComboBox);
            SelectedItemPanel.Controls.Add(CategoryLabel);
            SelectedItemPanel.Controls.Add(SelectedItemLabel);
            SelectedItemPanel.Controls.Add(DescriptionRichTextBox);
            SelectedItemPanel.Controls.Add(NameRichTextBox);
            SelectedItemPanel.Controls.Add(CostTextBox);
            SelectedItemPanel.Controls.Add(IdTextBox);
            SelectedItemPanel.Controls.Add(DescriptionLabel);
            SelectedItemPanel.Controls.Add(NameLabel);
            SelectedItemPanel.Controls.Add(CostLabel);
            SelectedItemPanel.Controls.Add(IdLabel);
            SelectedItemPanel.Location = new Point(429, 3);
            SelectedItemPanel.Name = "SelectedItemPanel";
            ItemsTableLayoutPanel.SetRowSpan(SelectedItemPanel, 5);
            SelectedItemPanel.Size = new Size(386, 406);
            SelectedItemPanel.TabIndex = 3;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(93, 114);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 28);
            CategoryComboBox.TabIndex = 14;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            CategoryComboBox.KeyPress += DisableTextBox;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(15, 117);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(72, 20);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "Category:";
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SelectedItemLabel.Location = new Point(13, 8);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(104, 20);
            SelectedItemLabel.TabIndex = 1;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionRichTextBox.Location = new Point(13, 296);
            DescriptionRichTextBox.MinimumSize = new Size(196, 50);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(360, 92);
            DescriptionRichTextBox.TabIndex = 13;
            DescriptionRichTextBox.Text = "";
            DescriptionRichTextBox.TextChanged += DescriptionRichTextBox_TextChanged;
            // 
            // NameRichTextBox
            // 
            NameRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameRichTextBox.Location = new Point(13, 188);
            NameRichTextBox.MinimumSize = new Size(196, 0);
            NameRichTextBox.Name = "NameRichTextBox";
            NameRichTextBox.Size = new Size(360, 82);
            NameRichTextBox.TabIndex = 12;
            NameRichTextBox.Text = "";
            NameRichTextBox.TextChanged += NameRichTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(93, 81);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(151, 27);
            CostTextBox.TabIndex = 11;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(93, 48);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(151, 27);
            IdTextBox.TabIndex = 10;
            IdTextBox.KeyPress += DisableTextBox;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(13, 273);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 20);
            DescriptionLabel.TabIndex = 9;
            DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(13, 165);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 8;
            NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(13, 84);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(41, 20);
            CostLabel.TabIndex = 7;
            CostLabel.Text = "Cost:";
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
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Dock = DockStyle.Bottom;
            ItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ItemsLabel.Location = new Point(3, 11);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(79, 20);
            ItemsLabel.TabIndex = 0;
            ItemsLabel.Text = "Items";
            // 
            // ItemsTableLayoutPanel
            // 
            ItemsTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsTableLayoutPanel.ColumnCount = 5;
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.2642479F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.2642479F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.233161F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.2383461F));
            ItemsTableLayoutPanel.Controls.Add(ItemDataGenerateButton, 3, 4);
            ItemsTableLayoutPanel.Controls.Add(ItemsLabel, 0, 0);
            ItemsTableLayoutPanel.Controls.Add(RemoveItemButton, 2, 4);
            ItemsTableLayoutPanel.Controls.Add(AddItemButton, 0, 4);
            ItemsTableLayoutPanel.Controls.Add(ItemsListBox, 0, 2);
            ItemsTableLayoutPanel.Controls.Add(SelectedItemPanel, 4, 0);
            ItemsTableLayoutPanel.Controls.Add(FindLabel, 0, 1);
            ItemsTableLayoutPanel.Controls.Add(FindTextBox, 1, 1);
            ItemsTableLayoutPanel.Controls.Add(OrderByLabel, 0, 3);
            ItemsTableLayoutPanel.Controls.Add(SortComboBox, 1, 3);
            ItemsTableLayoutPanel.Location = new Point(0, 0);
            ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            ItemsTableLayoutPanel.RowCount = 5;
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            ItemsTableLayoutPanel.Size = new Size(818, 412);
            ItemsTableLayoutPanel.TabIndex = 1;
            // 
            // ItemDataGenerateButton
            // 
            ItemDataGenerateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemDataGenerateButton.Location = new Point(354, 367);
            ItemDataGenerateButton.Name = "ItemDataGenerateButton";
            ItemDataGenerateButton.Size = new Size(69, 42);
            ItemDataGenerateButton.TabIndex = 2;
            ItemDataGenerateButton.Text = "Gen";
            ItemDataGenerateButton.UseVisualStyleBackColor = true;
            ItemDataGenerateButton.Click += ItemDataGenerateButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(221, 367);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(127, 42);
            RemoveItemButton.TabIndex = 5;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsTableLayoutPanel.SetColumnSpan(AddItemButton, 2);
            AddItemButton.Location = new Point(3, 367);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(212, 42);
            AddItemButton.TabIndex = 4;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsTableLayoutPanel.SetColumnSpan(ItemsListBox, 4);
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(3, 68);
            ItemsListBox.MinimumSize = new Size(0, 200);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(420, 259);
            ItemsListBox.TabIndex = 4;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Dock = DockStyle.Fill;
            FindLabel.Location = new Point(3, 31);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(79, 34);
            FindLabel.TabIndex = 6;
            FindLabel.Text = "Find:";
            FindLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FindTextBox
            // 
            ItemsTableLayoutPanel.SetColumnSpan(FindTextBox, 3);
            FindTextBox.Dock = DockStyle.Fill;
            FindTextBox.Location = new Point(88, 34);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(335, 27);
            FindTextBox.TabIndex = 7;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // OrderByLabel
            // 
            OrderByLabel.AutoSize = true;
            OrderByLabel.Dock = DockStyle.Fill;
            OrderByLabel.Location = new Point(3, 330);
            OrderByLabel.Name = "OrderByLabel";
            OrderByLabel.Size = new Size(79, 34);
            OrderByLabel.TabIndex = 8;
            OrderByLabel.Text = "Order by:";
            OrderByLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SortComboBox
            // 
            ItemsTableLayoutPanel.SetColumnSpan(SortComboBox, 3);
            SortComboBox.Dock = DockStyle.Fill;
            SortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Location = new Point(88, 333);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(335, 28);
            SortComboBox.TabIndex = 9;
            SortComboBox.SelectedIndexChanged += SortComboBox_SelectedIndexChanged;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(ItemsTableLayoutPanel);
            Name = "ItemsTab";
            Size = new Size(818, 412);
            SelectedItemPanel.ResumeLayout(false);
            SelectedItemPanel.PerformLayout();
            ItemsTableLayoutPanel.ResumeLayout(false);
            ItemsTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel SelectedItemPanel;
        private Label SelectedItemLabel;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
        private TextBox IdTextBox;
        private RichTextBox DescriptionRichTextBox;
        private RichTextBox NameRichTextBox;
        private TextBox CostTextBox;
        private TableLayoutPanel ItemsTableLayoutPanel;
        private Label ItemsLabel;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private Button ItemDataGenerateButton;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        public ListBox ItemsListBox;
        private Label FindLabel;
        private TextBox FindTextBox;
        private Label OrderByLabel;
        private ComboBox SortComboBox;
    }
}
