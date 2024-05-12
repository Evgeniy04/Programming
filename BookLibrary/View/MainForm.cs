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
        /// Путь до папки с файлом сохранения.
        /// </summary>
        string _appFolderPath;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Отключить элементы управления книгой
            if (SharedResources.TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle(null, null);

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
                }
                catch
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
            if (SharedResources.CurrentBook == null) return;
            if (!SharedResources.TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle(null, null);
        }

        /// <summary>
        /// Удалить книгу.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonRemoveBook_Click(object sender, EventArgs e)
        {
            if (SharedResources.CurrentBook == null) return;
            if (SharedResources.TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle(null, null);
            ListBoxBooks.Items.Remove(SharedResources.CurrentBook);
            SharedResources.CurrentBook = null;
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента в списке книг.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ListBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxBooks.SelectedItem == null || _isProgrammaticChange) return;
            if (SharedResources.TextBoxTitle.Enabled) GroupBoxSelectedBookEnableToggle(null, null);
            SharedResources.CurrentBook = (Book)ListBoxBooks.SelectedItem;
            GroupBoxSelectedBookUpdate();
        }

        /// <summary>
        /// Обновление информации о выбранной книге в GroupBox "Selected Book".
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
        /// Обновление информации о выбранной книге и сортировка в алфавитном порядке в ListBox со всеми книгами.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void BooksControls_ListBoxSelectedBookUpdate(object sender, EventArgs e)
        {
            if (SharedResources.CurrentBook == null) return;
            _isProgrammaticChange = true;
            // Получить список всех  книг
            object[] booksObj = new object[ListBoxBooks.Items.Count];
            ListBoxBooks.Items.CopyTo(booksObj, 0);
            List<Book> books = booksObj.Cast<Book>().ToList();
            // Сортировка в алфавитном порядке
            books.Sort((x, y) => x.ToString().CompareTo(y.ToString()));
            ListBoxBooks.Items.Clear();
            ListBoxBooks.Items.AddRange(books.Cast<object>().ToArray());
            ListBoxBooks.SelectedItem = SharedResources.CurrentBook;
            _isProgrammaticChange = false;
        }

        /// <summary>
        /// Переключает доступность элементов управления книгой.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void GroupBoxSelectedBookEnableToggle(object? sender, EventArgs? e)
        {
            SharedResources.TextBoxTitle.Enabled = !SharedResources.TextBoxTitle.Enabled;
            SharedResources.TextBoxAuthor.Enabled = !SharedResources.TextBoxAuthor.Enabled;
            SharedResources.ComboBoxGenres.Enabled = !SharedResources.ComboBoxGenres.Enabled;
            SharedResources.NumericUpDownPageCount.Enabled = !SharedResources.NumericUpDownPageCount.Enabled;
            SharedResources.NumericUpDownReleaseYear.Enabled = !SharedResources.NumericUpDownReleaseYear.Enabled;
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

        /// <summary>
        /// Сериализация и запись списка книг в файл.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Открываем поток для записи в файл
            using FileStream stream = new FileStream(_appFolderPath + @"\data.json", FileMode.Create);
            // Сериализуем список книг в XML и записываем его в файл
            JsonSerializer.Serialize(stream, ListBoxBooks.Items);
        }
    }
}
