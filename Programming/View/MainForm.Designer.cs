namespace Programming
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.GroupBoxSeasonHandle = new System.Windows.Forms.GroupBox();
            this.ButtonSeasonHandleGo = new System.Windows.Forms.Button();
            this.ComboBoxSeasons = new System.Windows.Forms.ComboBox();
            this.LabelChoseSeason = new System.Windows.Forms.Label();
            this.GroupBoxWeekdayParsing = new System.Windows.Forms.GroupBox();
            this.LabelResultWeekdayParsing = new System.Windows.Forms.Label();
            this.ButtonWeekdayParsing = new System.Windows.Forms.Button();
            this.TextBoxDayInput = new System.Windows.Forms.TextBox();
            this.LabelTypeValueForParsing = new System.Windows.Forms.Label();
            this.GroupBoxEnumerations = new System.Windows.Forms.GroupBox();
            this.LabelIntValue = new System.Windows.Forms.Label();
            this.IntValue = new System.Windows.Forms.TextBox();
            this.LabelChooseValue = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.LabelChooseEnumeration = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage.SuspendLayout();
            this.GroupBoxSeasonHandle.SuspendLayout();
            this.GroupBoxWeekdayParsing.SuspendLayout();
            this.GroupBoxEnumerations.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.GroupBoxSeasonHandle);
            this.EnumsTabPage.Controls.Add(this.GroupBoxWeekdayParsing);
            this.EnumsTabPage.Controls.Add(this.GroupBoxEnumerations);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(792, 424);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSeasonHandle
            // 
            this.GroupBoxSeasonHandle.Controls.Add(this.ButtonSeasonHandleGo);
            this.GroupBoxSeasonHandle.Controls.Add(this.ComboBoxSeasons);
            this.GroupBoxSeasonHandle.Controls.Add(this.LabelChoseSeason);
            this.GroupBoxSeasonHandle.Location = new System.Drawing.Point(409, 252);
            this.GroupBoxSeasonHandle.Name = "GroupBoxSeasonHandle";
            this.GroupBoxSeasonHandle.Size = new System.Drawing.Size(377, 164);
            this.GroupBoxSeasonHandle.TabIndex = 7;
            this.GroupBoxSeasonHandle.TabStop = false;
            this.GroupBoxSeasonHandle.Text = "Season Handle";
            // 
            // ButtonSeasonHandleGo
            // 
            this.ButtonSeasonHandleGo.Location = new System.Drawing.Point(195, 30);
            this.ButtonSeasonHandleGo.Name = "ButtonSeasonHandleGo";
            this.ButtonSeasonHandleGo.Size = new System.Drawing.Size(79, 23);
            this.ButtonSeasonHandleGo.TabIndex = 2;
            this.ButtonSeasonHandleGo.Text = "Go!";
            this.ButtonSeasonHandleGo.UseVisualStyleBackColor = true;
            this.ButtonSeasonHandleGo.Click += new System.EventHandler(this.ButtonSeasonHandleGo_Click);
            // 
            // ComboBoxSeasons
            // 
            this.ComboBoxSeasons.FormattingEnabled = true;
            this.ComboBoxSeasons.Location = new System.Drawing.Point(6, 31);
            this.ComboBoxSeasons.Name = "ComboBoxSeasons";
            this.ComboBoxSeasons.Size = new System.Drawing.Size(183, 21);
            this.ComboBoxSeasons.TabIndex = 1;
            // 
            // LabelChoseSeason
            // 
            this.LabelChoseSeason.AutoSize = true;
            this.LabelChoseSeason.Location = new System.Drawing.Point(6, 16);
            this.LabelChoseSeason.Name = "LabelChoseSeason";
            this.LabelChoseSeason.Size = new System.Drawing.Size(77, 13);
            this.LabelChoseSeason.TabIndex = 0;
            this.LabelChoseSeason.Text = "Chose season:";
            // 
            // GroupBoxWeekdayParsing
            // 
            this.GroupBoxWeekdayParsing.Controls.Add(this.LabelResultWeekdayParsing);
            this.GroupBoxWeekdayParsing.Controls.Add(this.ButtonWeekdayParsing);
            this.GroupBoxWeekdayParsing.Controls.Add(this.TextBoxDayInput);
            this.GroupBoxWeekdayParsing.Controls.Add(this.LabelTypeValueForParsing);
            this.GroupBoxWeekdayParsing.Location = new System.Drawing.Point(8, 252);
            this.GroupBoxWeekdayParsing.Name = "GroupBoxWeekdayParsing";
            this.GroupBoxWeekdayParsing.Size = new System.Drawing.Size(377, 164);
            this.GroupBoxWeekdayParsing.TabIndex = 1;
            this.GroupBoxWeekdayParsing.TabStop = false;
            this.GroupBoxWeekdayParsing.Text = "Weekday Parsing";
            // 
            // LabelResultWeekdayParsing
            // 
            this.LabelResultWeekdayParsing.AutoSize = true;
            this.LabelResultWeekdayParsing.Location = new System.Drawing.Point(6, 55);
            this.LabelResultWeekdayParsing.Name = "LabelResultWeekdayParsing";
            this.LabelResultWeekdayParsing.Size = new System.Drawing.Size(0, 13);
            this.LabelResultWeekdayParsing.TabIndex = 1;
            // 
            // ButtonWeekdayParsing
            // 
            this.ButtonWeekdayParsing.Location = new System.Drawing.Point(195, 30);
            this.ButtonWeekdayParsing.Name = "ButtonWeekdayParsing";
            this.ButtonWeekdayParsing.Size = new System.Drawing.Size(79, 23);
            this.ButtonWeekdayParsing.TabIndex = 8;
            this.ButtonWeekdayParsing.Text = "Parse";
            this.ButtonWeekdayParsing.UseVisualStyleBackColor = true;
            this.ButtonWeekdayParsing.Click += new System.EventHandler(this.ButtonWeekdayParsing_Click);
            // 
            // TextBoxDayInput
            // 
            this.TextBoxDayInput.Location = new System.Drawing.Point(6, 31);
            this.TextBoxDayInput.Name = "TextBoxDayInput";
            this.TextBoxDayInput.Size = new System.Drawing.Size(183, 20);
            this.TextBoxDayInput.TabIndex = 7;
            // 
            // LabelTypeValueForParsing
            // 
            this.LabelTypeValueForParsing.AutoSize = true;
            this.LabelTypeValueForParsing.Location = new System.Drawing.Point(3, 16);
            this.LabelTypeValueForParsing.Name = "LabelTypeValueForParsing";
            this.LabelTypeValueForParsing.Size = new System.Drawing.Size(115, 13);
            this.LabelTypeValueForParsing.TabIndex = 0;
            this.LabelTypeValueForParsing.Text = "Type value for parsing:";
            // 
            // GroupBoxEnumerations
            // 
            this.GroupBoxEnumerations.AutoSize = true;
            this.GroupBoxEnumerations.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxEnumerations.Controls.Add(this.LabelIntValue);
            this.GroupBoxEnumerations.Controls.Add(this.IntValue);
            this.GroupBoxEnumerations.Controls.Add(this.LabelChooseValue);
            this.GroupBoxEnumerations.Controls.Add(this.EnumsListBox);
            this.GroupBoxEnumerations.Controls.Add(this.LabelChooseEnumeration);
            this.GroupBoxEnumerations.Controls.Add(this.ValuesListBox);
            this.GroupBoxEnumerations.Location = new System.Drawing.Point(8, 6);
            this.GroupBoxEnumerations.Name = "GroupBoxEnumerations";
            this.GroupBoxEnumerations.Size = new System.Drawing.Size(778, 240);
            this.GroupBoxEnumerations.TabIndex = 6;
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
            // IntValue
            // 
            this.IntValue.Enabled = false;
            this.IntValue.Location = new System.Drawing.Point(314, 31);
            this.IntValue.Name = "IntValue";
            this.IntValue.Size = new System.Drawing.Size(120, 20);
            this.IntValue.TabIndex = 2;
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
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumsTabPage.PerformLayout();
            this.GroupBoxSeasonHandle.ResumeLayout(false);
            this.GroupBoxSeasonHandle.PerformLayout();
            this.GroupBoxWeekdayParsing.ResumeLayout(false);
            this.GroupBoxWeekdayParsing.PerformLayout();
            this.GroupBoxEnumerations.ResumeLayout(false);
            this.GroupBoxEnumerations.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TextBox IntValue;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Label LabelIntValue;
        private System.Windows.Forms.Label LabelChooseValue;
        private System.Windows.Forms.Label LabelChooseEnumeration;
        private System.Windows.Forms.GroupBox GroupBoxEnumerations;
        private System.Windows.Forms.GroupBox GroupBoxWeekdayParsing;
        private System.Windows.Forms.Label LabelTypeValueForParsing;
        private System.Windows.Forms.Button ButtonWeekdayParsing;
        private System.Windows.Forms.TextBox TextBoxDayInput;
        private System.Windows.Forms.Label LabelResultWeekdayParsing;
        private System.Windows.Forms.GroupBox GroupBoxSeasonHandle;
        private System.Windows.Forms.Button ButtonSeasonHandleGo;
        private System.Windows.Forms.ComboBox ComboBoxSeasons;
        private System.Windows.Forms.Label LabelChoseSeason;
    }
}

