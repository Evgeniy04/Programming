namespace Programming.View.Panels
{
    partial class EnumerationsPanel
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
            this.GroupBoxEnumerations = new System.Windows.Forms.GroupBox();
            this.LabelIntValue = new System.Windows.Forms.Label();
            this.TextBoxEnumsEnumerationsIntValue = new System.Windows.Forms.TextBox();
            this.LabelChooseValue = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.LabelChooseEnumeration = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.GroupBoxEnumerations.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxEnumerations
            // 
            this.GroupBoxEnumerations.AutoSize = true;
            this.GroupBoxEnumerations.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxEnumerations.Controls.Add(this.LabelIntValue);
            this.GroupBoxEnumerations.Controls.Add(this.TextBoxEnumsEnumerationsIntValue);
            this.GroupBoxEnumerations.Controls.Add(this.LabelChooseValue);
            this.GroupBoxEnumerations.Controls.Add(this.EnumsListBox);
            this.GroupBoxEnumerations.Controls.Add(this.LabelChooseEnumeration);
            this.GroupBoxEnumerations.Controls.Add(this.ValuesListBox);
            this.GroupBoxEnumerations.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxEnumerations.Name = "GroupBoxEnumerations";
            this.GroupBoxEnumerations.Size = new System.Drawing.Size(778, 240);
            this.GroupBoxEnumerations.TabIndex = 7;
            this.GroupBoxEnumerations.TabStop = false;
            this.GroupBoxEnumerations.Text = "Enumerations";
            // 
            // LabelIntValue
            // 
            this.LabelIntValue.AutoSize = true;
            this.LabelIntValue.Location = new System.Drawing.Point(311, 15);
            this.LabelIntValue.Name = "LabelIntValue";
            this.LabelIntValue.Size = new System.Drawing.Size(51, 13);
            this.LabelIntValue.TabIndex = 5;
            this.LabelIntValue.Text = "Int value:";
            // 
            // TextBoxEnumsEnumerationsIntValue
            // 
            this.TextBoxEnumsEnumerationsIntValue.Location = new System.Drawing.Point(314, 31);
            this.TextBoxEnumsEnumerationsIntValue.Name = "TextBoxEnumsEnumerationsIntValue";
            this.TextBoxEnumsEnumerationsIntValue.Size = new System.Drawing.Size(120, 20);
            this.TextBoxEnumsEnumerationsIntValue.TabIndex = 2;
            this.TextBoxEnumsEnumerationsIntValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // LabelChooseValue
            // 
            this.LabelChooseValue.AutoSize = true;
            this.LabelChooseValue.Location = new System.Drawing.Point(157, 15);
            this.LabelChooseValue.Name = "LabelChooseValue";
            this.LabelChooseValue.Size = new System.Drawing.Size(75, 13);
            this.LabelChooseValue.TabIndex = 4;
            this.LabelChooseValue.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "EducationForm",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(6, 31);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(120, 186);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // LabelChooseEnumeration
            // 
            this.LabelChooseEnumeration.AutoSize = true;
            this.LabelChooseEnumeration.Location = new System.Drawing.Point(3, 15);
            this.LabelChooseEnumeration.Name = "LabelChooseEnumeration";
            this.LabelChooseEnumeration.Size = new System.Drawing.Size(107, 13);
            this.LabelChooseEnumeration.TabIndex = 3;
            this.LabelChooseEnumeration.Text = "Choose enumaration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(160, 31);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(120, 186);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumerationsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxEnumerations);
            this.Name = "EnumerationsPanel";
            this.Size = new System.Drawing.Size(778, 240);
            this.GroupBoxEnumerations.ResumeLayout(false);
            this.GroupBoxEnumerations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxEnumerations;
        private System.Windows.Forms.Label LabelIntValue;
        private System.Windows.Forms.TextBox TextBoxEnumsEnumerationsIntValue;
        private System.Windows.Forms.Label LabelChooseValue;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label LabelChooseEnumeration;
        private System.Windows.Forms.ListBox ValuesListBox;
    }
}
