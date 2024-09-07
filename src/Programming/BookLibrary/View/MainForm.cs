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
        /// ���� �� ����� � ������ ����������.
        /// </summary>
        string _appFolderPath;

        /// <summary>
        /// ������ ��������� ������ <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // ��������� �������� ���������� ������
            if (SharedResources.TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle(null, null);

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
                }
                catch
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
            if (SharedResources.CurrentBook == null) return;
            if (!SharedResources.TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle(null, null);
        }

        /// <summary>
        /// ������� �����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void ButtonRemoveBook_Click(object sender, EventArgs e)
        {
            if (SharedResources.CurrentBook == null) return;
            if (SharedResources.TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle(null, null);
            ListBoxBooks.Items.Remove(SharedResources.CurrentBook);
            SharedResources.CurrentBook = null;
        }

        /// <summary>
        /// ���������� ��������� ���������� �������� � ������ ����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void ListBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxBooks.SelectedItem == null || _isProgrammaticChange) return;
            if (SharedResources.TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle(null, null);
            SharedResources.CurrentBook = (Book)ListBoxBooks.SelectedItem;
            GroupBoxSelectedBookUpdate();
        }

        /// <summary>
        /// ���������� ���������� � ��������� ����� � GroupBox "Selected Book".
        /// </summary>
        private void GroupBoxSelectedBookUpdate()
        {
            if (SharedResources.CurrentBook == null) return;
            SharedResources.TextBoxTitle.BackColor = AppColors.Default;
            SharedResources.TextBoxAuthor.BackColor = AppColors.Default;
            SharedResources.TextBoxTitle.Text = SharedResources.CurrentBook.Title;
            SharedResources.TextBoxAuthor.Text = SharedResources.CurrentBook.Author;
            SharedResources.ComboBoxGenres.SelectedItem = SharedResources.CurrentBook.Genre;
            SharedResources.NumericUpDownPageCount.Value = SharedResources.CurrentBook.PageCount;
            SharedResources.NumericUpDownReleaseYear.Value = SharedResources.CurrentBook.ReleaseYear;
        }

        /// <summary>
        /// ���������� ���������� � ��������� ����� � ���������� � ���������� ������� � ListBox �� ����� �������.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void BooksControls_ListBoxSelectedBookUpdate(object sender, EventArgs e)
        {
            if (SharedResources.CurrentBook == null) return;
            _isProgrammaticChange = true;
            // �������� ������ ����  ����
            object[] booksObj = new object[ListBoxBooks.Items.Count];
            ListBoxBooks.Items.CopyTo(booksObj, 0);
            List<Book> books = booksObj.Cast<Book>().ToList();
            // ���������� � ���������� �������
            books.Sort((x, y) => x.ToString().CompareTo(y.ToString()));
            ListBoxBooks.Items.Clear();
            ListBoxBooks.Items.AddRange(books.Cast<object>().ToArray());
            ListBoxBooks.SelectedItem = SharedResources.CurrentBook;
            _isProgrammaticChange = false;
        }

        /// <summary>
        /// ����������� ����������� ��������� ���������� ������.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void GroupBoxSelectedBookEnableToggle(object? sender, EventArgs? e)
        {
            SharedResources.TextBoxTitle.Enabled = !SharedResources.TextBoxTitle.Enabled;
            SharedResources.TextBoxAuthor.Enabled = !SharedResources.TextBoxAuthor.Enabled;
            SharedResources.ComboBoxGenres.Enabled = !SharedResources.ComboBoxGenres.Enabled;
            SharedResources.NumericUpDownPageCount.Enabled = !SharedResources.NumericUpDownPageCount.Enabled;
            SharedResources.NumericUpDownReleaseYear.Enabled = !SharedResources.NumericUpDownReleaseYear.Enabled;
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

        /// <summary>
        /// ������������ � ������ ������ ���� � ����.
        /// </summary>
        /// <param name="sender">������-����������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ��������� ����� ��� ������ � ����
            using FileStream stream = new FileStream(_appFolderPath + @"\data.json", FileMode.Create);
            // ����������� ������ ���� � XML � ���������� ��� � ����
            JsonSerializer.Serialize(stream, ListBoxBooks.Items);
        }
    }
}
