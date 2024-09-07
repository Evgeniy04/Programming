using System.Data;

namespace BookLibrary.View.Panels
{
    public partial class BooksControls : UserControl
    {
        /// <summary>
        /// Событие, возникающее изменении выбранной книги.
        /// </summary>
        public event EventHandler ListBoxSelectedBookUpdate;
        /// <summary>
        /// Событие, возникающее для смены режима панели управления книгой.
        /// </summary>
        public event EventHandler GroupBoxSelectedBookEnableToggle;
        /// <summary>
        /// Всплывающая подсказка для TextBoxTitle.
        /// </summary>
        ToolTip ToolTipTextBoxTitle = new ToolTip();
        /// <summary>
        /// Всплывающая подсказка для TextBoxAuthor.
        /// </summary>
        ToolTip ToolTipTextBoxAuthor = new ToolTip();
        /// <summary>
        /// Всплывающая подсказка для NumericUpDownPageCount.
        /// </summary>
        ToolTip ToolTipNumericUpDownPageCount = new ToolTip();
        /// <summary>
        /// Всплывающая подсказка для NumericUpDownReleaseYear.
        /// </summary>
        ToolTip ToolTipNumericUpDownReleaseYear = new ToolTip();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="BooksControls"/>.
        /// </summary>
        public BooksControls()
        {
            InitializeComponent();

            // Иницализация всплывающих подсказок
            // Добавление ToolTip на TextBox
            ToolTipTextBoxTitle.SetToolTip(TextBoxTitle, "Не более 100 и не менее 1 символов.");
            ToolTipTextBoxAuthor.SetToolTip(TextBoxAuthor, "Не менее 1 символа.");
            ToolTipNumericUpDownPageCount.SetToolTip(NumericUpDownPageCount, "Не менее 1 страницы.");
            ToolTipNumericUpDownReleaseYear.SetToolTip(NumericUpDownReleaseYear, $"Книга не может быть выпущена позднее {DateTime.Now.Year} (текущего) года.");

            NumericUpDownReleaseYear.Minimum = int.MinValue + 1;
            NumericUpDownReleaseYear.Maximum = DateTime.Now.Year + 1;

            object[] genres = Enum.GetValues(typeof(Genres)).Cast<object>().ToArray();
            ComboBoxGenres.Items.AddRange(genres);

            SharedResources.TextBoxTitle = TextBoxTitle;
            SharedResources.TextBoxAuthor = TextBoxAuthor;
            SharedResources.ComboBoxGenres = ComboBoxGenres;
            SharedResources.NumericUpDownPageCount = NumericUpDownPageCount;
            SharedResources.NumericUpDownReleaseYear = NumericUpDownReleaseYear;
        }

        /// <summary>
        /// Изменить название книги.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            if (SharedResources.CurrentBook == null) return;
            try
            {
                SharedResources.CurrentBook.Title = TextBoxTitle.Text;
                TextBoxTitle.BackColor = AppColors.Default;
                ListBoxSelectedBookUpdate.Invoke(this, EventArgs.Empty);
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
            if (SharedResources.CurrentBook == null) return;
            try
            {
                SharedResources.CurrentBook.Author = TextBoxAuthor.Text;
                TextBoxAuthor.BackColor = AppColors.Default;
                ListBoxSelectedBookUpdate.Invoke(this, EventArgs.Empty);
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
            if (SharedResources.CurrentBook == null || ComboBoxGenres.SelectedItem == null) return;
            SharedResources.CurrentBook.Genre = (Genres)ComboBoxGenres.SelectedItem;
            TextBoxAuthor.BackColor = AppColors.Default;
            ListBoxSelectedBookUpdate.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Изменить количество страниц в книге.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        private void NumericUpDownPageCount_ValueChanged(object sender, EventArgs e)
        {
            if (SharedResources.CurrentBook == null) return;
            try
            {
                SharedResources.CurrentBook.PageCount = (int)NumericUpDownPageCount.Value;
                NumericUpDownPageCount.BackColor = AppColors.Default;
                ListBoxSelectedBookUpdate.Invoke(this, EventArgs.Empty);
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
            if (SharedResources.CurrentBook == null) return;
            try
            {
                SharedResources.CurrentBook.ReleaseYear = (int)NumericUpDownReleaseYear.Value;
                NumericUpDownReleaseYear.BackColor = AppColors.Default;
                ListBoxSelectedBookUpdate.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                NumericUpDownReleaseYear.BackColor = AppColors.Invalid;
                ToolTipNumericUpDownReleaseYear.Show($"Книга не может быть выпущена позднее {DateTime.Now.Year} (текущего) года.", NumericUpDownReleaseYear, 10000);
            }
        }
    }
}
