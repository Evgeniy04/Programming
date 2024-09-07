﻿namespace ObjectOrientedPractics.View.Tabs
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
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ItemsListBox = new ListBox();
            SelectedItemPanel.SuspendLayout();
            ItemsTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedItemPanel
            // 
            SelectedItemPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectedItemPanel.BackColor = SystemColors.ControlLightLight;
            SelectedItemPanel.Controls.Add(SelectedItemLabel);
            SelectedItemPanel.Controls.Add(DescriptionRichTextBox);
            SelectedItemPanel.Controls.Add(NameRichTextBox);
            SelectedItemPanel.Controls.Add(CostTextBox);
            SelectedItemPanel.Controls.Add(IdTextBox);
            SelectedItemPanel.Controls.Add(DescriptionLabel);
            SelectedItemPanel.Controls.Add(NameLabel);
            SelectedItemPanel.Controls.Add(CostLabel);
            SelectedItemPanel.Controls.Add(IdLabel);
            SelectedItemPanel.Location = new Point(343, 3);
            SelectedItemPanel.Name = "SelectedItemPanel";
            ItemsTableLayoutPanel.SetRowSpan(SelectedItemPanel, 3);
            SelectedItemPanel.Size = new Size(472, 406);
            SelectedItemPanel.TabIndex = 3;
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
            DescriptionRichTextBox.Location = new Point(13, 257);
            DescriptionRichTextBox.MinimumSize = new Size(196, 50);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(447, 131);
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
            NameRichTextBox.Size = new Size(447, 82);
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
            ItemsLabel.Dock = DockStyle.Bottom;
            ItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ItemsLabel.Location = new Point(3, 11);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(150, 20);
            ItemsLabel.TabIndex = 0;
            ItemsLabel.Text = "Items";
            // 
            // ItemsTableLayoutPanel
            // 
            ItemsTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsTableLayoutPanel.ColumnCount = 4;
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.8125F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.1875F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 477F));
            ItemsTableLayoutPanel.Controls.Add(ItemsLabel, 0, 0);
            ItemsTableLayoutPanel.Controls.Add(RemoveItemButton, 1, 2);
            ItemsTableLayoutPanel.Controls.Add(AddItemButton, 0, 2);
            ItemsTableLayoutPanel.Controls.Add(ItemsListBox, 0, 1);
            ItemsTableLayoutPanel.Controls.Add(SelectedItemPanel, 3, 0);
            ItemsTableLayoutPanel.Location = new Point(0, 0);
            ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            ItemsTableLayoutPanel.RowCount = 3;
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 91.3043442F));
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ItemsTableLayoutPanel.Size = new Size(818, 412);
            ItemsTableLayoutPanel.TabIndex = 1;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(159, 366);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(107, 43);
            RemoveItemButton.TabIndex = 5;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddItemButton.Location = new Point(3, 366);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(150, 43);
            AddItemButton.TabIndex = 4;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsTableLayoutPanel.SetColumnSpan(ItemsListBox, 3);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(3, 34);
            ItemsListBox.MinimumSize = new Size(0, 324);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(334, 324);
            ItemsListBox.TabIndex = 4;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
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
        private ListBox ItemsListBox;
        private Label ItemsLabel;
        private Button RemoveItemButton;
        private Button AddItemButton;
    }
}
