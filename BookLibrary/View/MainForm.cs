namespace BookLibrary
{
    /// <summary>
    /// Главная форма.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Флаг, указывающий, что изменения производятся программно.
        /// </summary>
        bool _isProgrammaticChange = false;
        /// <summary>
        /// Текущая выбранная книга.
        /// </summary>
        Book? _currentBook;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Установка пользовательского формата даты для отображения только года
            DateTimePickerReleaseYear.Format = DateTimePickerFormat.Custom;
            DateTimePickerReleaseYear.CustomFormat = "yyyy";
            // Показать только стрелки вверх и вниз
            DateTimePickerReleaseYear.ShowUpDown = true;
            DateTimePickerReleaseYear.MaxDate = DateTime.Now;

            // Отключить элементы управления книгой
            if (TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle();

            object[] genres = Enum.GetValues(typeof(Genres)).Cast<object>().ToArray();
            ComboBoxGenres.Items.AddRange(genres);
        }

        /// <summary>
        /// Добавить новую книгу.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            ListBoxBooks.Items.Add(book);
        }

        /// <summary>
        /// Включить редактирование книги.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditBook_Click(object sender, EventArgs e)
        {
            if (_currentBook == null) return;
            if (!TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle();
        }

        /// <summary>
        /// Удалить книгу.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonRemoveBook_Click(object sender, EventArgs e)
        {
            if (_currentBook == null) return;
            if (TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle();
            ListBoxBooks.Items.Remove(_currentBook);
            _currentBook = null;
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента в списке книг.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ListBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxBooks.SelectedItem == null || _isProgrammaticChange) return;
            if (TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle();
            _currentBook = (Book)ListBoxBooks.SelectedItem;
            GroupBoxSelectedBookUpdate();
        }

        /// <summary>
        /// Обновление информации о выбранной книге в GroupBox "Selected Book".
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
        /// Обновление информации о выбранной книге и сортировка в алфавитном порядке в ListBox со всеми книгами.
        /// </summary>
        private void ListBoxSelectedBookUpdate()
        {
            if (_currentBook == null) return;
            _isProgrammaticChange = true;
            // Получить список всех  книг
            object[] booksObj = new object[ListBoxBooks.Items.Count];
            ListBoxBooks.Items.CopyTo(booksObj, 0);
            List<Book> books = booksObj.Cast<Book>().ToList();
            // Сортировка в алфавитном порядке
            books.Sort((x, y) => x.ToString().CompareTo(y.ToString()));
            ListBoxBooks.Items.Clear();
            ListBoxBooks.Items.AddRange(books.Cast<object>().ToArray());
            ListBoxBooks.SelectedItem = _currentBook;
            _isProgrammaticChange = false;
        }

        /// <summary>
        /// Изменить название книги.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
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
        /// Изменить автора книги.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
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
        /// Изменить жанр книги.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ComboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentBook == null || ComboBoxGenres.SelectedItem == null) return;
            _currentBook.Genre = (Genres)ComboBoxGenres.SelectedItem;
            TextBoxAuthor.BackColor = AppColors.Default;
            ListBoxSelectedBookUpdate();
        }

        /// <summary>
        /// Изменить количество страниц в книге.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
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
        /// Изменить год выпуска книги.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
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
        /// Переключает доступность элементов управления книгой.
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
        /// Обработчик события нажатия клавиши для отключения ввода в текстовом поле.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события нажатия клавиши.</param>
        void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
