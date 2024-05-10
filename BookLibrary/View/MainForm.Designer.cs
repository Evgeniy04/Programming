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
            listBox1 = new ListBox();
            GroupBoxSelectedBook = new GroupBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            TextBoxAuthor = new TextBox();
            LabelGenre = new Label();
            LabelPageCount = new Label();
            LabelAuthor = new Label();
            TextBoxTitle = new TextBox();
            LabelReleaseYear = new Label();
            LabelTitle = new Label();
            GroupBoxSelectedBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(275, 384);
            listBox1.TabIndex = 0;
            // 
            // GroupBoxSelectedBook
            // 
            GroupBoxSelectedBook.Controls.Add(comboBox1);
            GroupBoxSelectedBook.Controls.Add(numericUpDown1);
            GroupBoxSelectedBook.Controls.Add(TextBoxAuthor);
            GroupBoxSelectedBook.Controls.Add(LabelGenre);
            GroupBoxSelectedBook.Controls.Add(LabelAuthor);
            GroupBoxSelectedBook.Controls.Add(dateTimePicker1);
            GroupBoxSelectedBook.Controls.Add(LabelPageCount);
            GroupBoxSelectedBook.Controls.Add(TextBoxTitle);
            GroupBoxSelectedBook.Controls.Add(LabelReleaseYear);
            GroupBoxSelectedBook.Controls.Add(LabelTitle);
            GroupBoxSelectedBook.Location = new Point(293, 12);
            GroupBoxSelectedBook.Name = "GroupBoxSelectedBook";
            GroupBoxSelectedBook.Size = new Size(495, 195);
            GroupBoxSelectedBook.TabIndex = 1;
            GroupBoxSelectedBook.TabStop = false;
            GroupBoxSelectedBook.Text = "Selected Book";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(107, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(107, 125);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(87, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(87, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // TextBoxAuthor
            // 
            TextBoxAuthor.Location = new Point(107, 59);
            TextBoxAuthor.Name = "TextBoxAuthor";
            TextBoxAuthor.Size = new Size(151, 27);
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
            // LabelPageCount
            // 
            LabelPageCount.AutoSize = true;
            LabelPageCount.Location = new Point(14, 128);
            LabelPageCount.Name = "LabelPageCount";
            LabelPageCount.Size = new Size(87, 20);
            LabelPageCount.TabIndex = 4;
            LabelPageCount.Text = "Page Count:";
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
            // TextBoxTitle
            // 
            TextBoxTitle.Location = new Point(107, 26);
            TextBoxTitle.Name = "TextBoxTitle";
            TextBoxTitle.Size = new Size(382, 27);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GroupBoxSelectedBook);
            Controls.Add(listBox1);
            Name = "MainForm";
            Text = "Book Library";
            GroupBoxSelectedBook.ResumeLayout(false);
            GroupBoxSelectedBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private GroupBox GroupBoxSelectedBook;
        private TextBox TextBoxTitle;
        private Label LabelReleaseYear;
        private Label LabelTitle;
        private Label LabelAuthor;
        private Label LabelGenre;
        private Label LabelPageCount;
        private DateTimePicker dateTimePicker1;
        private TextBox TextBoxAuthor;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
    }
}
