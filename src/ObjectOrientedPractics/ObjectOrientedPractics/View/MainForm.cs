using Model;
using System.Text.Json;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Получает или задает объект <see cref="Store"/>, представляющий магазин.
        /// </summary>
        Store _store { get; set; }
        /// <summary>
        /// Путь до папки с файлом сохранения.
        /// </summary>
        string _appFolderPath { get; set; }

        /// <summary>
        /// Конструктор главной формы.
        /// Инициализирует компоненты и загружает данные из файла сохранения, если они существуют.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _store = new Store();
            // Получение пути к файлу с данными приложения
            string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _appFolderPath = Path.Combine(appDataFolderPath, "avradev", "OOP");
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
                    Store data = JsonSerializer.Deserialize<Store>(jsonString)!;
                    // Запись данных в провайдер
                    if (data == null) return;
                    _store = data;
                }
                catch
                {
                    Console.WriteLine();
                }
            }
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;

            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
        }

        /// <summary>
        /// Обработчик события закрытия формы.
        /// Сериализует данные и сохраняет их в файл.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события закрытия формы.</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Открываем поток для записи в файл
            using FileStream stream = new FileStream(_appFolderPath + @"\data.json", FileMode.Create);
            // Сериализуем список книг в XML и записываем его в файл
            JsonSerializer.Serialize(stream, _store);
        }
    }
}
