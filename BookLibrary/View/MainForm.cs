namespace BookLibrary
{
    /// <summary>
    /// ������� �����.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������ ��������� ������ <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // ��������� ����������������� ������� ���� ��� ����������� ������ ����
            DateTimePickerReleaseYear.Format = DateTimePickerFormat.Custom;
            DateTimePickerReleaseYear.CustomFormat = "yyyy";
            // �������� ������ ������� ����� � ����
            DateTimePickerReleaseYear.ShowUpDown = true;
            DateTimePickerReleaseYear.MaxDate = DateTime.Now;


        }
    }
}
