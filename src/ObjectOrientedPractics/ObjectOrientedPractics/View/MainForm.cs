using Model;
using System.Text.Json;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Путь до папки с файлом сохранения.
        /// </summary>
        string _appFolderPath;
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
                    Provider.Items = data.Item1;
                    Provider.Customers = data.Item2;
                }
                catch
                {
                    Console.WriteLine();
                }
            }
        }

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
