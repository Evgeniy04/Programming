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
        /// Путь до папки с файлом сохранения.
        /// </summary>
        string _appFolderPath;

        /// <summary>
        /// Конструктор главной формы.
        /// Инициализирует компоненты и загружает данные из файла сохранения, если они существуют.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
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
                    Tuple<List<Item>, List<Customer>> data = JsonSerializer.Deserialize<Tuple<List<Item>, List<Customer>>>(jsonString)!;
                    // Запись данных в провайдер
                    ItemsTab.ItemsListBox.Items.AddRange(data.Item1.ToArray());
                    CustomersTab.CustomersListBox.Items.AddRange(data.Item2.ToArray());
                    Provider.Items = data.Item1;
                    Provider.Customers = data.Item2;
                }
                catch
                {
                    Console.WriteLine();
                }
            }
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
            Tuple<List<Item>, List<Customer>> array = Tuple.Create(Provider.Items, Provider.Customers);
            JsonSerializer.Serialize(stream, array);
        }
    }
}
