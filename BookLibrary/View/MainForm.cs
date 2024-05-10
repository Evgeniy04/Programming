namespace BookLibrary
{
    /// <summary>
    /// ������� �����.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// ����, �����������, ��� ��������� ������������ ����������.
        /// </summary>
        bool _isProgrammaticChange = false;
        /// <summary>
        /// ������� ��������� �����.
        /// </summary>
        Book? _currentBook;

        /// <summary>
        /// ������ ��������� ������ <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // ��������� ����������������� ������� ���� ��� ����������� ������ ����
            DateTimePickerReleaseYear.Format = DateTimePickerFormat.Custom;
            DateTimePickerReleaseYear.CustomFormat = "yyyy";
            // �������� ������ ������� ����� � ����
            DateTimePickerReleaseYear.ShowUpDown = true;
            DateTimePickerReleaseYear.MaxDate = DateTime.Now;

            // ��������� �������� ���������� ������
            if (TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle();

            object[] genres = Enum.GetValues(typeof(Genres)).Cast<object>().ToArray();
            ComboBoxGenres.Items.AddRange(genres);
        }

        /// <summary>
        /// �������� ����� �����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            ListBoxBooks.Items.Add(book);
        }

        /// <summary>
        /// �������� �������������� �����.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditBook_Click(object sender, EventArgs e)
        {
            if (_currentBook == null) return;
            if (!TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle();
        }

        /// <summary>
        /// ������� �����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void ButtonRemoveBook_Click(object sender, EventArgs e)
        {
            if (_currentBook == null) return;
            if (TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle();
            ListBoxBooks.Items.Remove(_currentBook);
            _currentBook = null;
        }

        /// <summary>
        /// ���������� ��������� ���������� �������� � ������ ����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void ListBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxBooks.SelectedItem == null || _isProgrammaticChange) return;
            if (TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle();
            _currentBook = (Book)ListBoxBooks.SelectedItem;
            GroupBoxSelectedBookUpdate();
        }

        /// <summary>
        /// ���������� ���������� � ��������� ����� � GroupBox "Selected Book".
        /// </summary>
        private void GroupBoxSelectedBookUpdate()
        {
            if (_currentBook == null) return;
            TextBoxTitle.BackColor = AppColors.Default;
            TextBoxAuthor.BackColor = AppColors.Default;
            TextBoxTitle.Text = _currentBook.Title;
            TextBoxAuthor.Text = _currentBook.Author;
            ComboBoxGenres.SelectedItem = _currentBook.Genre;
            NumericUpDownPageCount.Value = _currentBook.PageCount;
            DateTimePickerReleaseYear.Value = new DateTime(_currentBook.ReleaseYear, 01, 01);
        }

        /// <summary>
        /// ���������� ���������� � ��������� ����� � ���������� � ���������� ������� � ListBox �� ����� �������.
        /// </summary>
        private void ListBoxSelectedBookUpdate()
        {
            if (_currentBook == null) return;
            _isProgrammaticChange = true;
            // �������� ������ ����  ����
            object[] booksObj = new object[ListBoxBooks.Items.Count];
            ListBoxBooks.Items.CopyTo(booksObj, 0);
            List<Book> books = booksObj.Cast<Book>().ToList();
            // ���������� � ���������� �������
            books.Sort((x, y) => x.ToString().CompareTo(y.ToString()));
            ListBoxBooks.Items.Clear();
            ListBoxBooks.Items.AddRange(books.Cast<object>().ToArray());
            ListBoxBooks.SelectedItem = _currentBook;
            _isProgrammaticChange = false;
        }

        /// <summary>
        /// �������� �������� �����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            if (_currentBook == null) return;
            try
            {
                _currentBook.Title = TextBoxTitle.Text;
                TextBoxTitle.BackColor = AppColors.Default;
                ListBoxSelectedBookUpdate();
            }
            catch
            {
                TextBoxTitle.BackColor = AppColors.Invalid;
            }
        }

        /// <summary>
        /// �������� ������ �����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void TextBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            if (_currentBook == null) return;
            try
            {
                _currentBook.Author = TextBoxAuthor.Text;
                TextBoxAuthor.BackColor = AppColors.Default;
                ListBoxSelectedBookUpdate();
            }
            catch
            {
                TextBoxAuthor.BackColor = AppColors.Invalid;
            }
        }

        /// <summary>
        /// �������� ���� �����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void ComboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentBook == null || ComboBoxGenres.SelectedItem == null) return;
            _currentBook.Genre = (Genres)ComboBoxGenres.SelectedItem;
            TextBoxAuthor.BackColor = AppColors.Default;
            ListBoxSelectedBookUpdate();
        }

        /// <summary>
        /// �������� ���������� ������� � �����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void NumericUpDownPageCount_ValueChanged(object sender, EventArgs e)
        {
            if (_currentBook == null) return;
            try
            {
                _currentBook.PageCount = (int)NumericUpDownPageCount.Value;
                NumericUpDownPageCount.BackColor = AppColors.Default;
                ListBoxSelectedBookUpdate();
            }
            catch
            {
                NumericUpDownPageCount.BackColor = AppColors.Invalid;
            }
        }

        /// <summary>
        /// �������� ��� ������� �����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void DateTimePickerReleaseYear_ValueChanged(object sender, EventArgs e)
        {
            if (_currentBook == null) return;
            try
            {
                _currentBook.ReleaseYear = DateTimePickerReleaseYear.Value.Year;
                DateTimePickerReleaseYear.BackColor = AppColors.Default;
                ListBoxSelectedBookUpdate();
            }
            catch
            {
                DateTimePickerReleaseYear.BackColor = AppColors.Invalid;
            }
        }

        /// <summary>
        /// ����������� ����������� ��������� ���������� ������.
        /// </summary>
        private void GroupBoxSelectedBookEnableToggle()
        {
            TextBoxTitle.Enabled = !TextBoxTitle.Enabled;
            TextBoxAuthor.Enabled = !TextBoxAuthor.Enabled;
            ComboBoxGenres.Enabled = !ComboBoxGenres.Enabled;
            NumericUpDownPageCount.Enabled = !NumericUpDownPageCount.Enabled;
            DateTimePickerReleaseYear.Enabled = !DateTimePickerReleaseYear.Enabled;
        }

        /// <summary>
        /// ���������� ������� ������� ������� ��� ���������� ����� � ��������� ����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� ������� ������� �������.</param>
        void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
