namespace BookLibrary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Установка пользовательского формата даты для отображения только года
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";

            // Скрытие элементов, которые не относятся к году
            dateTimePicker1.ShowUpDown = true; // Показать только стрелки вверх и вниз

            // Отключение возможности редактирования текста
            //dateTimePicker1.Enabled = false;

        }
    }
}
