namespace BookLibrary
{
    /// <summary>
    /// Главная форма.
    /// </summary>
    public partial class MainForm : Form
    {
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


        }
    }
}
