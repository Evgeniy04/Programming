using ObjectOrientedPractics.Model;
//using System.Text.Json;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;
using Newtonsoft.Json;
using System;
using Microsoft.VisualBasic.Devices;

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
        /// ��������� �������������.
        /// </summary>
        JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        };

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
                    Store data = JsonConvert.DeserializeObject<Store>(File.ReadAllText(_appFolderPath + @"\data.json"), _settings)!;
                    if (data != null) _store = data;
                }
                catch
                {
                    Console.WriteLine();
                }
            }
            ItemsTab.Items = _store.Items;
            CustomersTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;

            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;

            OrdersTab.Customers = _store.Customers;
        }

        /// <summary>
        /// ���������� ������� �������� �����.
        /// ����������� ������ � ��������� �� � ����.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">��������� ������� �������� �����.</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(_appFolderPath + @"\data.json", JsonConvert.SerializeObject(_store, Formatting.Indented, _settings));
        }

        /// <summary>
        /// ������� ����� �������.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">���������.</param>
        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartsTab.RefreshData();
            OrdersTab.RefreshData();
        }
    }
}
