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
            ItemsPanel = new Panel();
            ItemsListBox = new ListBox();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ItemsLabel = new Label();
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
            ItemsPanel.SuspendLayout();
            SelectedItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsPanel
            // 
            ItemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsPanel.Controls.Add(ItemsListBox);
            ItemsPanel.Controls.Add(RemoveItemButton);
            ItemsPanel.Controls.Add(AddItemButton);
            ItemsPanel.Controls.Add(ItemsLabel);
            ItemsPanel.Location = new Point(0, 0);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(325, 412);
            ItemsPanel.TabIndex = 2;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(13, 36);
            ItemsListBox.MinimumSize = new Size(0, 324);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(309, 324);
            ItemsListBox.TabIndex = 4;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(131, 370);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(112, 35);
            RemoveItemButton.TabIndex = 5;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddItemButton.Location = new Point(13, 370);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(112, 35);
            AddItemButton.TabIndex = 4;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
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
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(84, 81);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(125, 27);
            CostTextBox.TabIndex = 11;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(84, 48);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 10;
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
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(SelectedItemPanel);
            Controls.Add(ItemsPanel);
            Name = "ItemsTab";
            Size = new Size(818, 412);
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            SelectedItemPanel.ResumeLayout(false);
            SelectedItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ItemsPanel;
        private Label ItemsLabel;
        private Panel SelectedItemPanel;
        private Button AddItemButton;
        private Label SelectedItemLabel;
        private Button RemoveItemButton;
        private ListBox ItemsListBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
        private TextBox IdTextBox;
        private RichTextBox DescriptionRichTextBox;
        private RichTextBox NameRichTextBox;
        private TextBox CostTextBox;
    }
}
