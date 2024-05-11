using System.Text.Json;

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
        /// Всплывающая подсказка для TextBoxTitle
        /// </summary>
        ToolTip ToolTipTextBoxTitle = new ToolTip();
        /// <summary>
        /// Всплывающая подсказка для TextBoxAuthor
        /// </summary>
        ToolTip ToolTipTextBoxAuthor = new ToolTip();
        /// <summary>
        /// Всплывающая подсказка для NumericUpDownPageCount
        /// </summary>
        ToolTip ToolTipNumericUpDownPageCount = new ToolTip();
        /// <summary>
        /// Всплывающая подсказка для NumericUpDownReleaseYear
        /// </summary>
        ToolTip ToolTipNumericUpDownReleaseYear = new ToolTip();
        /// <summary>
        /// Путь до папки с файлом сохранения
        /// </summary>
        string _appFolderPath;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            NumericUpDownReleaseYear.Minimum = int.MinValue + 1;
            NumericUpDownReleaseYear.Maximum = DateTime.Now.Year + 1;

            // Отключить элементы управления книгой
            if (TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle();

            object[] genres = Enum.GetValues(typeof(Genres)).Cast<object>().ToArray();
            ComboBoxGenres.Items.AddRange(genres);

            // Иницализация всплывающих подсказок
            // Добавление ToolTip на TextBox
            ToolTipTextBoxTitle.SetToolTip(TextBoxTitle, "Не более 100 и не менее 1 символов.");
            ToolTipTextBoxAuthor.SetToolTip(TextBoxAuthor, "Не менее 1 символа.");
            ToolTipNumericUpDownPageCount.SetToolTip(NumericUpDownPageCount, "Не менее 1 страницы.");
            ToolTipNumericUpDownReleaseYear.SetToolTip(NumericUpDownReleaseYear, $"Книга не может быть выпущена позднее {DateTime.Now.Year} (текущего) года.");

            // Получение пути к файлу с данными приложения
            string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _appFolderPath = Path.Combine(appDataFolderPath, "avradev", "Book Library");
            if (!Directory.Exists(_appFolderPath))
            {
                Directory.CreateDirectory(_appFolderPath);
            }

            // Чтение данных из файла сохранения
            if (File.Exists(_appFolderPath + @"\data.json"))
            {
                try
                {
                    // Чтение JSON из файла
                    string jsonString = File.ReadAllText(_appFolderPath + @"\data.json");

                    // Десериализация JSON в объект
                    ListBoxBooks.Items.AddRange(JsonSerializer.Deserialize<List<Book>>(jsonString)!.Cast<Object>().ToArray());
                } catch
                {
                    Console.WriteLine();
                }
            }
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
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
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
                ToolTipTextBoxTitle.Show("Не более 100 и не менее 1 символов.", TextBoxTitle, 10000);
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
                ToolTipTextBoxAuthor.Show("Не менее 1 символа.", TextBoxAuthor, 10000);
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
                ToolTipNumericUpDownPageCount.Show("Не менее 1 страницы.", NumericUpDownPageCount, 10000);
            }
        }

        /// <summary>
        /// Изменить год выпуска книги.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
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
                ToolTipNumericUpDownReleaseYear.Show($"Книга не может быть выпущена позднее {DateTime.Now.Year} (текущего) года.", NumericUpDownReleaseYear, 10000);
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
            NumericUpDownReleaseYear.Enabled = !NumericUpDownReleaseYear.Enabled;
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
            NumericUpDownReleaseYear.Value = _currentBook.ReleaseYear;
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
        /// Сериализация и запись списка книг в файл.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Открываем поток для записи в файл
            using (FileStream stream = new FileStream(_appFolderPath + @"\data.json", FileMode.Create))
            {
                // Сериализуем список книг в XML и записываем его в файл
                JsonSerializer.Serialize(stream, ListBoxBooks.Items);
            }
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
