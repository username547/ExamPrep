using ExamPrep.Models;

namespace ExamPrep
{
    public partial class UpdateRepairRecordForm : Form
    {
        private MainForm _mainForm;
        private RepairRecordModel _dto;

        public UpdateRepairRecordForm(MainForm mainForm, RepairRecordModel dto)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _dto = dto;
        }

        private void UpdateRepairRecordForm_Load(object sender, EventArgs e)
        {
            FillComboBox();
            TextBoxDevice.Text = _dto.RepairRecordDevice;
            TextBoxDesc.Text = _dto.RepairRecordDesc;
            TextBoxMasterFullName.Text = _dto.RepairRecordMasterFullName;
            TextBoxClientFullName.Text = _dto.RepairRecordClientFullName;
            TextBoxPhone.Text = _dto.RepairRecordPhone;
            TextBoxEmail.Text = _dto.RepairRecordEmail;
        }

        private void UpdateRepairRecordBtn_Click(object sender, EventArgs e)
        {
            //_dto.RepairRecordDate = TextBoxRepairRecordDate;
            _dto.RepairRecordStatus = ComboBoxStatus.SelectedItem.ToString();
            _dto.RepairRecordDevice = TextBoxDevice.Text;
            _dto.RepairRecordType = ComboBoxType.SelectedItem.ToString();
            _dto.RepairRecordDesc = TextBoxDesc.Text;
            _dto.RepairRecordMasterFullName = TextBoxMasterFullName.Text;
            _dto.RepairRecordClientFullName = TextBoxClientFullName.Text;
            _dto.RepairRecordPhone = TextBoxPhone.Text;
            _dto.RepairRecordEmail = TextBoxEmail.Text;
            _mainForm.UpdateRepairRecord(_dto);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _mainForm.Show();
            this.Close();
        }

        private void FillComboBox()
        {
            foreach (Type type in Enum.GetValues(typeof(Type))) ComboBoxType.Items.Add(type.ToString());
            foreach (Status status in Enum.GetValues(typeof(Status))) ComboBoxStatus.Items.Add(status.ToString());
            ComboBoxType.SelectedIndex = ComboBoxType.Items.IndexOf(_dto.RepairRecordType);
            ComboBoxStatus.SelectedIndex = ComboBoxStatus.Items.IndexOf(_dto.RepairRecordStatus);
        }
    }
}
