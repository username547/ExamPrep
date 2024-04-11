using ModelAndStatistics;

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
            LoadPrevData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Type selectedType;
            Status selectedStatus;

            if (!Enum.TryParse(comboBoxType.SelectedItem?.ToString(), out selectedType) ||
                !Enum.TryParse(comboBoxStatus.SelectedItem?.ToString(), out selectedStatus))
            {
                MessageBox.Show("Выберите тип и статус для записи об ремонте.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDevice.Text) ||
                string.IsNullOrWhiteSpace(textBoxDesc.Text) ||
                string.IsNullOrWhiteSpace(textBoxMasterFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxClientFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Заполните все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dto.RepairRecordCompletedDate = selectedStatus == Status.Завершен ? DateTime.Now : null;
            _dto.RepairRecordStatus = selectedStatus.ToString();
            _dto.RepairRecordDevice = textBoxDevice.Text;
            _dto.RepairRecordType = selectedType.ToString();
            _dto.RepairRecordDesc = textBoxDesc.Text;
            _dto.RepairRecordMasterFullName = textBoxMasterFullName.Text;
            _dto.RepairRecordClientFullName = textBoxClientFullName.Text;
            _dto.RepairRecordPhone = textBoxPhone.Text;
            _dto.RepairRecordEmail = textBoxEmail.Text;

            _mainForm.UpdateRepairRecord(_dto);
            _mainForm.GetStatistics();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void FillComboBox()
        {
            foreach (Type type in Enum.GetValues(typeof(Type))) comboBoxType.Items.Add(type.ToString());
            foreach (Status status in Enum.GetValues(typeof(Status))) comboBoxStatus.Items.Add(status.ToString());
            comboBoxType.SelectedIndex = comboBoxType.Items.IndexOf(_dto.RepairRecordType);
            comboBoxStatus.SelectedIndex = comboBoxStatus.Items.IndexOf(_dto.RepairRecordStatus);
        }

        private void LoadPrevData()
        {
            textBoxDevice.Text = _dto.RepairRecordDevice;
            textBoxDesc.Text = _dto.RepairRecordDesc;
            textBoxMasterFullName.Text = _dto.RepairRecordMasterFullName;
            textBoxClientFullName.Text = _dto.RepairRecordClientFullName;
            textBoxPhone.Text = _dto.RepairRecordPhone;
            textBoxEmail.Text = _dto.RepairRecordEmail;
        }
    }
}
