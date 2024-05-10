namespace BookLibrary
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ListBoxBooks = new ListBox();
            GroupBoxSelectedBook = new GroupBox();
            ComboBoxGenre = new ComboBox();
            NumericUpDownPageCount = new NumericUpDown();
            TextBoxAuthor = new TextBox();
            LabelGenre = new Label();
            LabelAuthor = new Label();
            DateTimePickerReleaseYear = new DateTimePicker();
            LabelPageCount = new Label();
            TextBoxTitle = new TextBox();
            LabelReleaseYear = new Label();
            LabelTitle = new Label();
            ButtonAddBook = new Button();
            ButtonEditBook = new Button();
            ButtonRemoveBook = new Button();
            GroupBoxSelectedBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPageCount).BeginInit();
            SuspendLayout();
            // 
            // ListBoxBooks
            // 
            ListBoxBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ListBoxBooks.FormattingEnabled = true;
            ListBoxBooks.Location = new Point(12, 12);
            ListBoxBooks.Name = "ListBoxBooks";
            ListBoxBooks.Size = new Size(275, 384);
            ListBoxBooks.TabIndex = 0;
            // 
            // GroupBoxSelectedBook
            // 
            GroupBoxSelectedBook.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxSelectedBook.Controls.Add(ComboBoxGenre);
            GroupBoxSelectedBook.Controls.Add(NumericUpDownPageCount);
            GroupBoxSelectedBook.Controls.Add(TextBoxAuthor);
            GroupBoxSelectedBook.Controls.Add(LabelGenre);
            GroupBoxSelectedBook.Controls.Add(LabelAuthor);
            GroupBoxSelectedBook.Controls.Add(DateTimePickerReleaseYear);
            GroupBoxSelectedBook.Controls.Add(LabelPageCount);
            GroupBoxSelectedBook.Controls.Add(TextBoxTitle);
            GroupBoxSelectedBook.Controls.Add(LabelReleaseYear);
            GroupBoxSelectedBook.Controls.Add(LabelTitle);
            GroupBoxSelectedBook.Location = new Point(305, 0);
            GroupBoxSelectedBook.Name = "GroupBoxSelectedBook";
            GroupBoxSelectedBook.Size = new Size(489, 211);
            GroupBoxSelectedBook.TabIndex = 1;
            GroupBoxSelectedBook.TabStop = false;
            GroupBoxSelectedBook.Text = "Selected Book";
            // 
            // ComboBoxGenre
            // 
            ComboBoxGenre.FormattingEnabled = true;
            ComboBoxGenre.Location = new Point(107, 92);
            ComboBoxGenre.Name = "ComboBoxGenre";
            ComboBoxGenre.Size = new Size(203, 28);
            ComboBoxGenre.TabIndex = 9;
            // 
            // NumericUpDownPageCount
            // 
            NumericUpDownPageCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NumericUpDownPageCount.Location = new Point(107, 125);
            NumericUpDownPageCount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumericUpDownPageCount.MaximumSize = new Size(250, 0);
            NumericUpDownPageCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericUpDownPageCount.Name = "NumericUpDownPageCount";
            NumericUpDownPageCount.Size = new Size(72, 27);
            NumericUpDownPageCount.TabIndex = 8;
            NumericUpDownPageCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TextBoxAuthor
            // 
            TextBoxAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxAuthor.Location = new Point(107, 59);
            TextBoxAuthor.Name = "TextBoxAuthor";
            TextBoxAuthor.Size = new Size(203, 27);
            TextBoxAuthor.TabIndex = 6;
            // 
            // LabelGenre
            // 
            LabelGenre.AutoSize = true;
            LabelGenre.Location = new Point(51, 96);
            LabelGenre.Name = "LabelGenre";
            LabelGenre.Size = new Size(51, 20);
            LabelGenre.TabIndex = 5;
            LabelGenre.Text = "Genre:";
            // 
            // LabelAuthor
            // 
            LabelAuthor.AutoSize = true;
            LabelAuthor.Location = new Point(44, 62);
            LabelAuthor.Name = "LabelAuthor";
            LabelAuthor.Size = new Size(57, 20);
            LabelAuthor.TabIndex = 3;
            LabelAuthor.Text = "Author:";
            // 
            // DateTimePickerReleaseYear
            // 
            DateTimePickerReleaseYear.Location = new Point(107, 158);
            DateTimePickerReleaseYear.MaxDate = new DateTime(2024, 12, 25, 23, 59, 59, 0);
            DateTimePickerReleaseYear.Name = "DateTimePickerReleaseYear";
            DateTimePickerReleaseYear.Size = new Size(72, 27);
            DateTimePickerReleaseYear.TabIndex = 7;
            // 
            // LabelPageCount
            // 
            LabelPageCount.AutoSize = true;
            LabelPageCount.Location = new Point(14, 128);
            LabelPageCount.Name = "LabelPageCount";
            LabelPageCount.Size = new Size(87, 20);
            LabelPageCount.TabIndex = 4;
            LabelPageCount.Text = "Page Count:";
            // 
            // TextBoxTitle
            // 
            TextBoxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxTitle.Location = new Point(107, 26);
            TextBoxTitle.Name = "TextBoxTitle";
            TextBoxTitle.Size = new Size(376, 27);
            TextBoxTitle.TabIndex = 2;
            // 
            // LabelReleaseYear
            // 
            LabelReleaseYear.AutoSize = true;
            LabelReleaseYear.Location = new Point(6, 161);
            LabelReleaseYear.Name = "LabelReleaseYear";
            LabelReleaseYear.Size = new Size(95, 20);
            LabelReleaseYear.TabIndex = 1;
            LabelReleaseYear.Text = "Release Year:";
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Location = new Point(60, 29);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(41, 20);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Title:";
            // 
            // ButtonAddBook
            // 
            ButtonAddBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonAddBook.BackColor = Color.Transparent;
            ButtonAddBook.BackgroundImage = (Image)resources.GetObject("ButtonAddBook.BackgroundImage");
            ButtonAddBook.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonAddBook.FlatAppearance.BorderSize = 0;
            ButtonAddBook.FlatStyle = FlatStyle.Flat;
            ButtonAddBook.ForeColor = Color.Transparent;
            ButtonAddBook.Location = new Point(12, 401);
            ButtonAddBook.Margin = new Padding(0);
            ButtonAddBook.Name = "ButtonAddBook";
            ButtonAddBook.Size = new Size(40, 40);
            ButtonAddBook.TabIndex = 10;
            ButtonAddBook.UseVisualStyleBackColor = false;
            // 
            // ButtonEditBook
            // 
            ButtonEditBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonEditBook.BackColor = Color.Transparent;
            ButtonEditBook.BackgroundImage = (Image)resources.GetObject("ButtonEditBook.BackgroundImage");
            ButtonEditBook.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonEditBook.FlatAppearance.BorderSize = 0;
            ButtonEditBook.FlatStyle = FlatStyle.Flat;
            ButtonEditBook.ForeColor = Color.Transparent;
            ButtonEditBook.Location = new Point(61, 401);
            ButtonEditBook.Margin = new Padding(0);
            ButtonEditBook.Name = "ButtonEditBook";
            ButtonEditBook.Size = new Size(40, 40);
            ButtonEditBook.TabIndex = 11;
            ButtonEditBook.UseVisualStyleBackColor = false;
            // 
            // ButtonRemoveBook
            // 
            ButtonRemoveBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonRemoveBook.BackColor = Color.Transparent;
            ButtonRemoveBook.BackgroundImage = (Image)resources.GetObject("ButtonRemoveBook.BackgroundImage");
            ButtonRemoveBook.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonRemoveBook.FlatAppearance.BorderSize = 0;
            ButtonRemoveBook.FlatStyle = FlatStyle.Flat;
            ButtonRemoveBook.ForeColor = Color.Transparent;
            ButtonRemoveBook.Location = new Point(110, 401);
            ButtonRemoveBook.Margin = new Padding(0);
            ButtonRemoveBook.Name = "ButtonRemoveBook";
            ButtonRemoveBook.Size = new Size(40, 40);
            ButtonRemoveBook.TabIndex = 12;
            ButtonRemoveBook.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonRemoveBook);
            Controls.Add(ButtonEditBook);
            Controls.Add(ButtonAddBook);
            Controls.Add(GroupBoxSelectedBook);
            Controls.Add(ListBoxBooks);
            MinimumSize = new Size(818, 497);
            Name = "MainForm";
            Text = "Book Library";
            GroupBoxSelectedBook.ResumeLayout(false);
            GroupBoxSelectedBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPageCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListBoxBooks;
        private GroupBox GroupBoxSelectedBook;
        private TextBox TextBoxTitle;
        private Label LabelReleaseYear;
        private Label LabelTitle;
        private Label LabelAuthor;
        private Label LabelGenre;
        private Label LabelPageCount;
        private DateTimePicker DateTimePickerReleaseYear;
        private TextBox TextBoxAuthor;
        private ComboBox ComboBoxGenre;
        private NumericUpDown NumericUpDownPageCount;
        private Button ButtonAddBook;
        private Button ButtonEditBook;
        private Button ButtonRemoveBook;
    }
}
