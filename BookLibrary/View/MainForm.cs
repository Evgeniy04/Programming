namespace BookLibrary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // ��������� ����������������� ������� ���� ��� ����������� ������ ����
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";

            // ������� ���������, ������� �� ��������� � ����
            dateTimePicker1.ShowUpDown = true; // �������� ������ ������� ����� � ����

            // ���������� ����������� �������������� ������
            //dateTimePicker1.Enabled = false;

        }
    }
}
