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
            ItemsListBox = new ListBox();
            SelectedItemPanel = new Panel();
            DescriptionRichTextBox = new RichTextBox();
            NameRichTextBox = new RichTextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            DescriptionLabel = new Label();
            SelectedItemLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            ItemsLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ItemsPanel = new Panel();
            SelectedItemPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ItemsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(ItemsListBox, 3);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(3, 3);
            ItemsListBox.MinimumSize = new Size(0, 324);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(319, 324);
            ItemsListBox.TabIndex = 4;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedItemPanel
            // 
            SelectedItemPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectedItemPanel.BackColor = SystemColors.ControlLightLight;
            SelectedItemPanel.Controls.Add(DescriptionRichTextBox);
            SelectedItemPanel.Controls.Add(NameRichTextBox);
            SelectedItemPanel.Controls.Add(CostTextBox);
            SelectedItemPanel.Controls.Add(IdTextBox);
            SelectedItemPanel.Controls.Add(DescriptionLabel);
            SelectedItemPanel.Controls.Add(SelectedItemLabel);
            SelectedItemPanel.Controls.Add(NameLabel);
            SelectedItemPanel.Controls.Add(CostLabel);
            SelectedItemPanel.Controls.Add(IdLabel);
            SelectedItemPanel.Location = new Point(337, 3);
            SelectedItemPanel.Name = "SelectedItemPanel";
            SelectedItemPanel.Size = new Size(478, 406);
            SelectedItemPanel.TabIndex = 3;
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionRichTextBox.Location = new Point(13, 257);
            DescriptionRichTextBox.MinimumSize = new Size(196, 145);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(453, 145);
            DescriptionRichTextBox.TabIndex = 13;
            DescriptionRichTextBox.Text = "";
            DescriptionRichTextBox.TextChanged += DescriptionRichTextBox_TextChanged;
            // 
            // NameRichTextBox
            // 
            NameRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameRichTextBox.Location = new Point(13, 140);
            NameRichTextBox.MinimumSize = new Size(196, 0);
            NameRichTextBox.Name = "NameRichTextBox";
            NameRichTextBox.Size = new Size(453, 82);
            NameRichTextBox.TabIndex = 12;
            NameRichTextBox.Text = "";
            NameRichTextBox.TextChanged += NameRichTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(84, 81);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(125, 27);
            CostTextBox.TabIndex = 11;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(84, 48);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 10;
            IdTextBox.KeyPress += DisableTextBox;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(13, 234);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 20);
            DescriptionLabel.TabIndex = 9;
            DescriptionLabel.Text = "Description:";
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SelectedItemLabel.Location = new Point(13, 13);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(104, 20);
            SelectedItemLabel.TabIndex = 1;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(13, 117);
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
            ItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ItemsLabel.Location = new Point(13, 13);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(49, 20);
            ItemsLabel.TabIndex = 0;
            ItemsLabel.Text = "Items";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.6F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.Controls.Add(RemoveItemButton, 1, 1);
            tableLayoutPanel1.Controls.Add(AddItemButton, 0, 1);
            tableLayoutPanel1.Controls.Add(ItemsListBox, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 36);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.76596F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2340422F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(325, 376);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Dock = DockStyle.Fill;
            RemoveItemButton.Location = new Point(162, 333);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(85, 40);
            RemoveItemButton.TabIndex = 5;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Dock = DockStyle.Fill;
            AddItemButton.Location = new Point(3, 333);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(153, 40);
            AddItemButton.TabIndex = 4;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ItemsPanel
            // 
            ItemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsPanel.Controls.Add(tableLayoutPanel1);
            ItemsPanel.Controls.Add(ItemsLabel);
            ItemsPanel.Location = new Point(0, 0);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(325, 412);
            ItemsPanel.TabIndex = 2;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(SelectedItemPanel);
            Controls.Add(ItemsPanel);
            Name = "ItemsTab";
            Size = new Size(818, 412);
            SelectedItemPanel.ResumeLayout(false);
            SelectedItemPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel SelectedItemPanel;
        private Label SelectedItemLabel;
        private ListBox ItemsListBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
        private TextBox IdTextBox;
        private RichTextBox DescriptionRichTextBox;
        private RichTextBox NameRichTextBox;
        private TextBox CostTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private Label ItemsLabel;
        private Panel ItemsPanel;
    }
}
