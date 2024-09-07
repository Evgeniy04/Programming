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
            this.ButtonSeasonHandleGo = new System.Windows.Forms.Button();
            this.ComboBoxSeasons = new System.Windows.Forms.ComboBox();
            this.LabelChoseSeason = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSeasonHandleGo
            // 
            this.ButtonSeasonHandleGo.Location = new System.Drawing.Point(192, 14);
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
            this.ComboBoxSeasons.Location = new System.Drawing.Point(3, 15);
            this.ComboBoxSeasons.Name = "ComboBoxSeasons";
            this.ComboBoxSeasons.Size = new System.Drawing.Size(183, 21);
            this.ComboBoxSeasons.TabIndex = 1;
            // 
            // LabelChoseSeason
            // 
            this.LabelChoseSeason.AutoSize = true;
            this.LabelChoseSeason.Location = new System.Drawing.Point(3, 0);
            this.LabelChoseSeason.Name = "LabelChoseSeason";
            this.LabelChoseSeason.Size = new System.Drawing.Size(77, 13);
            this.LabelChoseSeason.TabIndex = 0;
            this.LabelChoseSeason.Text = "Chose season:";
            // 
            // SeasonsHandlePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonSeasonHandleGo);
            this.Controls.Add(this.ComboBoxSeasons);
            this.Controls.Add(this.LabelChoseSeason);
            this.Name = "SeasonsHandlePanel";
            this.Size = new System.Drawing.Size(273, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSeasonHandleGo;
        private System.Windows.Forms.ComboBox ComboBoxSeasons;
        private System.Windows.Forms.Label LabelChoseSeason;
    }
}
