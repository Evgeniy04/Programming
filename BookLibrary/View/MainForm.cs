using System.Text.Json;

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
        /// ����������� ��������� ��� TextBoxTitle
        /// </summary>
        ToolTip ToolTipTextBoxTitle = new ToolTip();
        /// <summary>
        /// ����������� ��������� ��� TextBoxAuthor
        /// </summary>
        ToolTip ToolTipTextBoxAuthor = new ToolTip();
        /// <summary>
        /// ����������� ��������� ��� NumericUpDownPageCount
        /// </summary>
        ToolTip ToolTipNumericUpDownPageCount = new ToolTip();
        /// <summary>
        /// ����������� ��������� ��� NumericUpDownReleaseYear
        /// </summary>
        ToolTip ToolTipNumericUpDownReleaseYear = new ToolTip();
        /// <summary>
        /// ���� �� ����� � ������ ����������
        /// </summary>
        string _appFolderPath;

        /// <summary>
        /// ������ ��������� ������ <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            NumericUpDownReleaseYear.Minimum = int.MinValue + 1;
            NumericUpDownReleaseYear.Maximum = DateTime.Now.Year + 1;

            // ��������� �������� ���������� ������
            if (TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle();

            object[] genres = Enum.GetValues(typeof(Genres)).Cast<object>().ToArray();
            ComboBoxGenres.Items.AddRange(genres);

            // ������������ ����������� ���������
            // ���������� ToolTip �� TextBox
            ToolTipTextBoxTitle.SetToolTip(TextBoxTitle, "�� ����� 100 � �� ����� 1 ��������.");
            ToolTipTextBoxAuthor.SetToolTip(TextBoxAuthor, "�� ����� 1 �������.");
            ToolTipNumericUpDownPageCount.SetToolTip(NumericUpDownPageCount, "�� ����� 1 ��������.");
            ToolTipNumericUpDownReleaseYear.SetToolTip(NumericUpDownReleaseYear, $"����� �� ����� ���� �������� ������� {DateTime.Now.Year} (��������) ����.");

            // ��������� ���� � ����� � ������� ����������
            string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _appFolderPath = Path.Combine(appDataFolderPath, "avradev", "Book Library");
            if (!Directory.Exists(_appFolderPath))
            {
                Directory.CreateDirectory(_appFolderPath);
            }

            // ������ ������ �� ����� ����������
            if (File.Exists(_appFolderPath + @"\data.json"))
            {
                try
                {
                    // ������ JSON �� �����
                    string jsonString = File.ReadAllText(_appFolderPath + @"\data.json");

                    // �������������� JSON � ������
                    ListBoxBooks.Items.AddRange(JsonSerializer.Deserialize<List<Book>>(jsonString)!.Cast<Object>().ToArray());
                } catch
                {
                    Console.WriteLine();
                }
            }
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
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
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
                ToolTipTextBoxTitle.Show("�� ����� 100 � �� ����� 1 ��������.", TextBoxTitle, 10000);
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
                ToolTipTextBoxAuthor.Show("�� ����� 1 �������.", TextBoxAuthor, 10000);
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
                ToolTipNumericUpDownPageCount.Show("�� ����� 1 ��������.", NumericUpDownPageCount, 10000);
            }
        }

        /// <summary>
        /// �������� ��� ������� �����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void NumericUpDownReleaseYear_ValueChanged(object sender, EventArgs e)
        {
            if (_currentBook == null) return;
            try
            {
                _currentBook.ReleaseYear = (int)NumericUpDownReleaseYear.Value;
                NumericUpDownReleaseYear.BackColor = AppColors.Default;
                ListBoxSelectedBookUpdate();
            }
            catch
            {
                NumericUpDownReleaseYear.BackColor = AppColors.Invalid;
                ToolTipNumericUpDownReleaseYear.Show($"����� �� ����� ���� �������� ������� {DateTime.Now.Year} (��������) ����.", NumericUpDownReleaseYear, 10000);
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
            NumericUpDownReleaseYear.Enabled = !NumericUpDownReleaseYear.Enabled;
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
            NumericUpDownReleaseYear.Value = _currentBook.ReleaseYear;
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
        /// ������������ � ������ ������ ���� � ����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ��������� ����� ��� ������ � ����
            using (FileStream stream = new FileStream(_appFolderPath + @"\data.json", FileMode.Create))
            {
                // ����������� ������ ���� � XML � ���������� ��� � ����
                JsonSerializer.Serialize(stream, ListBoxBooks.Items);
            }
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
