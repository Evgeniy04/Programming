namespace BookLibrary.View.Panels
{
    partial class BooksControls
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
            NumericUpDownReleaseYear = new NumericUpDown();
            ComboBoxGenres = new ComboBox();
            NumericUpDownPageCount = new NumericUpDown();
            TextBoxAuthor = new TextBox();
            LabelGenre = new Label();
            LabelAuthor = new Label();
            LabelPageCount = new Label();
            TextBoxTitle = new TextBox();
            LabelReleaseYear = new Label();
            LabelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownReleaseYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPageCount).BeginInit();
            SuspendLayout();
            // 
            // NumericUpDownReleaseYear
            // 
            NumericUpDownReleaseYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NumericUpDownReleaseYear.Location = new Point(107, 158);
            NumericUpDownReleaseYear.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumericUpDownReleaseYear.MaximumSize = new Size(200, 0);
            NumericUpDownReleaseYear.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            NumericUpDownReleaseYear.Name = "NumericUpDownReleaseYear";
            NumericUpDownReleaseYear.Size = new Size(72, 27);
            NumericUpDownReleaseYear.TabIndex = 20;
            NumericUpDownReleaseYear.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumericUpDownReleaseYear.ValueChanged += NumericUpDownReleaseYear_ValueChanged;
            // 
            // ComboBoxGenres
            // 
            ComboBoxGenres.FormattingEnabled = true;
            ComboBoxGenres.Location = new Point(107, 92);
            ComboBoxGenres.Name = "ComboBoxGenres";
            ComboBoxGenres.Size = new Size(200, 28);
            ComboBoxGenres.TabIndex = 19;
            ComboBoxGenres.TextChanged += ComboBoxGenres_SelectedIndexChanged;
            // 
            // NumericUpDownPageCount
            // 
            NumericUpDownPageCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NumericUpDownPageCount.Location = new Point(107, 125);
            NumericUpDownPageCount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumericUpDownPageCount.MaximumSize = new Size(200, 0);
            NumericUpDownPageCount.Name = "NumericUpDownPageCount";
            NumericUpDownPageCount.Size = new Size(72, 27);
            NumericUpDownPageCount.TabIndex = 18;
            NumericUpDownPageCount.ValueChanged += NumericUpDownPageCount_ValueChanged;
            // 
            // TextBoxAuthor
            // 
            TextBoxAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxAuthor.Location = new Point(107, 59);
            TextBoxAuthor.Name = "TextBoxAuthor";
            TextBoxAuthor.Size = new Size(203, 27);
            TextBoxAuthor.TabIndex = 17;
            TextBoxAuthor.TextChanged += TextBoxAuthor_TextChanged;
            // 
            // LabelGenre
            // 
            LabelGenre.AutoSize = true;
            LabelGenre.Location = new Point(51, 96);
            LabelGenre.Name = "LabelGenre";
            LabelGenre.Size = new Size(51, 20);
            LabelGenre.TabIndex = 16;
            LabelGenre.Text = "Genre:";
            // 
            // LabelAuthor
            // 
            LabelAuthor.AutoSize = true;
            LabelAuthor.Location = new Point(44, 62);
            LabelAuthor.Name = "LabelAuthor";
            LabelAuthor.Size = new Size(57, 20);
            LabelAuthor.TabIndex = 14;
            LabelAuthor.Text = "Author:";
            // 
            // LabelPageCount
            // 
            LabelPageCount.AutoSize = true;
            LabelPageCount.Location = new Point(14, 128);
            LabelPageCount.Name = "LabelPageCount";
            LabelPageCount.Size = new Size(87, 20);
            LabelPageCount.TabIndex = 15;
            LabelPageCount.Text = "Page Count:";
            // 
            // TextBoxTitle
            // 
            TextBoxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxTitle.Location = new Point(107, 26);
            TextBoxTitle.MaxLength = 101;
            TextBoxTitle.Name = "TextBoxTitle";
            TextBoxTitle.Size = new Size(376, 27);
            TextBoxTitle.TabIndex = 13;
            TextBoxTitle.TextChanged += TextBoxTitle_TextChanged;
            // 
            // LabelReleaseYear
            // 
            LabelReleaseYear.AutoSize = true;
            LabelReleaseYear.Location = new Point(6, 161);
            LabelReleaseYear.Name = "LabelReleaseYear";
            LabelReleaseYear.Size = new Size(95, 20);
            LabelReleaseYear.TabIndex = 12;
            LabelReleaseYear.Text = "Release Year:";
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Location = new Point(60, 29);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(41, 20);
            LabelTitle.TabIndex = 11;
            LabelTitle.Text = "Title:";
            // 
            // BooksControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NumericUpDownReleaseYear);
            Controls.Add(ComboBoxGenres);
            Controls.Add(NumericUpDownPageCount);
            Controls.Add(TextBoxAuthor);
            Controls.Add(LabelGenre);
            Controls.Add(LabelAuthor);
            Controls.Add(LabelPageCount);
            Controls.Add(TextBoxTitle);
            Controls.Add(LabelReleaseYear);
            Controls.Add(LabelTitle);
            Name = "BooksControls";
            Size = new Size(489, 211);
            ((System.ComponentModel.ISupportInitialize)NumericUpDownReleaseYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPageCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumericUpDownReleaseYear;
        private ComboBox ComboBoxGenres;
        private NumericUpDown NumericUpDownPageCount;
        private TextBox TextBoxAuthor;
        private Label LabelGenre;
        private Label LabelAuthor;
        private Label LabelPageCount;
        private TextBox TextBoxTitle;
        private Label LabelReleaseYear;
        private Label LabelTitle;
    }
}
