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
        /// ���� �� ����� � ������ ����������.
        /// </summary>
        string _appFolderPath;

        /// <summary>
        /// ����������� ������� �����.
        /// �������������� ���������� � ��������� ������ �� ����� ����������, ���� ��� ����������.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
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
                    Tuple<List<Item>, List<Customer>> data = JsonSerializer.Deserialize<Tuple<List<Item>, List<Customer>>>(jsonString)!;
                    // ������ ������ � ���������
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
            Tuple<List<Item>, List<Customer>> array = Tuple.Create(Provider.Items, Provider.Customers);
            JsonSerializer.Serialize(stream, array);
        }
    }
}
