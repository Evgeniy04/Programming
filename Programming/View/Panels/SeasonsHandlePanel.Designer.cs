namespace Programming.View.Panels
{
    partial class SeasonsHandlePanel
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
            this.GroupBoxSeasonHandle = new System.Windows.Forms.GroupBox();
            this.ButtonSeasonHandleGo = new System.Windows.Forms.Button();
            this.ComboBoxSeasons = new System.Windows.Forms.ComboBox();
            this.LabelChoseSeason = new System.Windows.Forms.Label();
            this.GroupBoxSeasonHandle.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxSeasonHandle
            // 
            this.GroupBoxSeasonHandle.Controls.Add(this.ButtonSeasonHandleGo);
            this.GroupBoxSeasonHandle.Controls.Add(this.ComboBoxSeasons);
            this.GroupBoxSeasonHandle.Controls.Add(this.LabelChoseSeason);
            this.GroupBoxSeasonHandle.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxSeasonHandle.Name = "GroupBoxSeasonHandle";
            this.GroupBoxSeasonHandle.Size = new System.Drawing.Size(377, 164);
            this.GroupBoxSeasonHandle.TabIndex = 8;
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
            // SeasonsHandlePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxSeasonHandle);
            this.Name = "SeasonsHandlePanel";
            this.Size = new System.Drawing.Size(377, 164);
            this.GroupBoxSeasonHandle.ResumeLayout(false);
            this.GroupBoxSeasonHandle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxSeasonHandle;
        private System.Windows.Forms.Button ButtonSeasonHandleGo;
        private System.Windows.Forms.ComboBox ComboBoxSeasons;
        private System.Windows.Forms.Label LabelChoseSeason;
    }
}
