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
        /// �������� ��� ������ ������ <see cref="Store"/>, �������������� �������.
        /// </summary>
        Store _store { get; set; }
        /// <summary>
        /// ���� �� ����� � ������ ����������.
        /// </summary>
        string _appFolderPath { get; set; }

        /// <summary>
        /// ����������� ������� �����.
        /// �������������� ���������� � ��������� ������ �� ����� ����������, ���� ��� ����������.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _store = new Store();
            // ��������� ���� � ����� � ������� ����������
            string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _appFolderPath = Path.Combine(appDataFolderPath, "avradev", "OOP");
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
                    Store data = JsonSerializer.Deserialize<Store>(jsonString)!;
                    // ������ ������ � ���������
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
        /// ���������� ������� �������� �����.
        /// ����������� ������ � ��������� �� � ����.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">��������� ������� �������� �����.</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ��������� ����� ��� ������ � ����
            using FileStream stream = new FileStream(_appFolderPath + @"\data.json", FileMode.Create);
            // ����������� ������ ���� � XML � ���������� ��� � ����
            JsonSerializer.Serialize(stream, _store);
        }
    }
}
