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
            DiscountsLabel = new Label();
            AddButton = new Button();
            RemoveButton = new Button();
            DiscountsListBox = new ListBox();
            DiscountsTabTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DiscountsTabTableLayoutPanel
            // 
            DiscountsTabTableLayoutPanel.ColumnCount = 2;
            DiscountsTabTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.491806F));
            DiscountsTabTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.508194F));
            DiscountsTabTableLayoutPanel.Controls.Add(DiscountsLabel, 0, 0);
            DiscountsTabTableLayoutPanel.Controls.Add(AddButton, 1, 1);
            DiscountsTabTableLayoutPanel.Controls.Add(RemoveButton, 1, 2);
            DiscountsTabTableLayoutPanel.Controls.Add(DiscountsListBox, 0, 1);
            DiscountsTabTableLayoutPanel.Dock = DockStyle.Fill;
            DiscountsTabTableLayoutPanel.Location = new Point(0, 0);
            DiscountsTabTableLayoutPanel.Name = "DiscountsTabTableLayoutPanel";
            DiscountsTabTableLayoutPanel.RowCount = 4;
            DiscountsTabTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            DiscountsTabTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            DiscountsTabTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            DiscountsTabTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            DiscountsTabTableLayoutPanel.Size = new Size(549, 209);
            DiscountsTabTableLayoutPanel.TabIndex = 0;
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Dock = DockStyle.Bottom;
            DiscountsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DiscountsLabel.Location = new Point(3, 11);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(381, 20);
            DiscountsLabel.TabIndex = 0;
            DiscountsLabel.Text = "Discounts";
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(390, 34);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(156, 53);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(390, 93);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(156, 53);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.Dock = DockStyle.Fill;
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.Location = new Point(3, 34);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsTabTableLayoutPanel.SetRowSpan(DiscountsListBox, 3);
            DiscountsListBox.Size = new Size(381, 172);
            DiscountsListBox.TabIndex = 3;
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
        private Label DiscountsLabel;
        private Button AddButton;
        private Button RemoveButton;
        private ListBox DiscountsListBox;
    }
}
