namespace Programming.View.Panels
{
    partial class WeekdayParsingPanel
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
            this.LabelResultWeekdayParsing = new System.Windows.Forms.Label();
            this.ButtonWeekdayParsing = new System.Windows.Forms.Button();
            this.TextBoxDayInput = new System.Windows.Forms.TextBox();
            this.LabelTypeValueForParsing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelResultWeekdayParsing
            // 
            this.LabelResultWeekdayParsing.AutoSize = true;
            this.LabelResultWeekdayParsing.Location = new System.Drawing.Point(3, 40);
            this.LabelResultWeekdayParsing.Name = "LabelResultWeekdayParsing";
            this.LabelResultWeekdayParsing.Size = new System.Drawing.Size(0, 13);
            this.LabelResultWeekdayParsing.TabIndex = 1;
            // 
            // ButtonWeekdayParsing
            // 
            this.ButtonWeekdayParsing.Location = new System.Drawing.Point(192, 15);
            this.ButtonWeekdayParsing.Name = "ButtonWeekdayParsing";
            this.ButtonWeekdayParsing.Size = new System.Drawing.Size(79, 23);
            this.ButtonWeekdayParsing.TabIndex = 8;
            this.ButtonWeekdayParsing.Text = "Parse";
            this.ButtonWeekdayParsing.UseVisualStyleBackColor = true;
            this.ButtonWeekdayParsing.Click += new System.EventHandler(this.ButtonWeekdayParsing_Click);
            // 
            // TextBoxDayInput
            // 
            this.TextBoxDayInput.Location = new System.Drawing.Point(3, 16);
            this.TextBoxDayInput.Name = "TextBoxDayInput";
            this.TextBoxDayInput.Size = new System.Drawing.Size(183, 20);
            this.TextBoxDayInput.TabIndex = 7;
            // 
            // LabelTypeValueForParsing
            // 
            this.LabelTypeValueForParsing.AutoSize = true;
            this.LabelTypeValueForParsing.Location = new System.Drawing.Point(0, 1);
            this.LabelTypeValueForParsing.Name = "LabelTypeValueForParsing";
            this.LabelTypeValueForParsing.Size = new System.Drawing.Size(115, 13);
            this.LabelTypeValueForParsing.TabIndex = 0;
            this.LabelTypeValueForParsing.Text = "Type value for parsing:";
            // 
            // WeekdayParsingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelResultWeekdayParsing);
            this.Controls.Add(this.ButtonWeekdayParsing);
            this.Controls.Add(this.TextBoxDayInput);
            this.Controls.Add(this.LabelTypeValueForParsing);
            this.Name = "WeekdayParsingPanel";
            this.Size = new System.Drawing.Size(272, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelResultWeekdayParsing;
        private System.Windows.Forms.Button ButtonWeekdayParsing;
        private System.Windows.Forms.TextBox TextBoxDayInput;
        private System.Windows.Forms.Label LabelTypeValueForParsing;
    }
}
