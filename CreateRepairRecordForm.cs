using ExamPrep.Models;
using System.ComponentModel;

namespace ExamPrep
{
    public enum Type
    {
        Тип1,
        Тип2,
        Тип3,
        Тип4,
        Тип5,
    }

    public enum Status
    {
        Принят,
        Ожидание,
        Завершен,
    }

    public partial class CreateRepairRecordForm : Form
    {
        private MainForm _mainForm;
        private int _lastRepairRecordId;
        public CreateRepairRecordForm(MainForm mainForm, int lastIndex)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _lastRepairRecordId = lastIndex;
        }

        private void CreateRepairRecordForm_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            foreach (Type type in Enum.GetValues(typeof(Type))) ComboBoxType.Items.Add(type.ToString());
            foreach (Status status in Enum.GetValues(typeof(Status))) ComboBoxStatus.Items.Add(status.ToString());
            ComboBoxType.SelectedIndex = 0;
            ComboBoxStatus.SelectedIndex = 0;
        }

        private void ClearFormFields()
        {
            TextBoxDevice.Text = string.Empty;
            TextBoxDesc.Text = string.Empty;
            TextBoxClientFullName.Text = string.Empty;
            TextBoxPhone.Text = string.Empty;
            TextBoxEmail.Text = string.Empty;
        }

        private void CreateRepairRecordBtn_Click(object sender, EventArgs e)
        {
            _lastRepairRecordId++;

            _mainForm.CreateRepairRecord(new RepairRecordModel
            {
                RepairRecordId = _lastRepairRecordId,
                RepairRecordDate = DateOnly.FromDateTime(DateTime.Now),
                RepairRecordDevice = TextBoxDevice.Text,
                RepairRecordType = ComboBoxType.SelectedItem.ToString(),
                RepairRecordStatus = ComboBoxStatus.SelectedItem.ToString(),
                RepairRecordDesc = TextBoxDesc.Text,
                RepairRecordMasterFullName = TextBoxMasterFullName.Text,
                RepairRecordClientFullName = TextBoxClientFullName.Text,
                RepairRecordPhone = TextBoxPhone.Text,
                RepairRecordEmail = TextBoxEmail.Text,
            });
            ClearFormFields();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
