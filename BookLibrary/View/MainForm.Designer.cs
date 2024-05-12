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
            BooksControls = new View.Panels.BooksControls();
            ButtonAddBook = new Button();
            ButtonEditBook = new Button();
            ButtonRemoveBook = new Button();
            GroupBoxSelectedBook.SuspendLayout();
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
            ListBoxBooks.SelectedIndexChanged += ListBoxBooks_SelectedIndexChanged;
            // 
            // GroupBoxSelectedBook
            // 
            GroupBoxSelectedBook.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GroupBoxSelectedBook.Controls.Add(BooksControls);
            GroupBoxSelectedBook.Location = new Point(305, 0);
            GroupBoxSelectedBook.Name = "GroupBoxSelectedBook";
            GroupBoxSelectedBook.Size = new Size(489, 211);
            GroupBoxSelectedBook.TabIndex = 1;
            GroupBoxSelectedBook.TabStop = false;
            GroupBoxSelectedBook.Text = "Selected Book";
            // 
            // BooksControls
            // 
            BooksControls.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BooksControls.BackColor = Color.Transparent;
            BooksControls.Location = new Point(0, 12);
            BooksControls.Margin = new Padding(0);
            BooksControls.Name = "BooksControls";
            BooksControls.Size = new Size(489, 196);
            BooksControls.TabIndex = 13;
            BooksControls.ListBoxSelectedBookUpdate += BooksControls_ListBoxSelectedBookUpdate;
            BooksControls.GroupBoxSelectedBookEnableToggle += GroupBoxSelectedBookEnableToggle;
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
            ButtonAddBook.Click += ButtonAddBook_Click;
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
            ButtonEditBook.Click += ButtonEditBook_Click;
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
            ButtonRemoveBook.Click += ButtonRemoveBook_Click;
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
            FormClosed += MainForm_FormClosed;
            GroupBoxSelectedBook.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListBoxBooks;
        private GroupBox GroupBoxSelectedBook;
        private Button ButtonAddBook;
        private Button ButtonEditBook;
        private Button ButtonRemoveBook;
        private View.Panels.BooksControls BooksControls;
    }
}
