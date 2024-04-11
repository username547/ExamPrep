using ModelAndStatistics;
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
        public CreateRepairRecordForm(MainForm mainForm, int lastId)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _lastRepairRecordId = lastId;
        }

        private void CreateRepairRecordForm_Load(object sender, EventArgs e) => FillComboBox();

        private void btnCreate_Click(object sender, EventArgs e)
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

            _lastRepairRecordId++;
            _mainForm.CreateRepairRecord(new RepairRecordModel
            {
                RepairRecordId = _lastRepairRecordId,
                RepairRecordDate = DateTime.Now,
                RepairRecordCompletedDate = selectedStatus == Status.Завершен ? DateTime.Now : null,
                RepairRecordStatus = selectedStatus.ToString(),
                RepairRecordDevice = textBoxDevice.Text,
                RepairRecordType = selectedType.ToString(),
                RepairRecordDesc = textBoxDesc.Text,
                RepairRecordMasterFullName = textBoxMasterFullName.Text,
                RepairRecordClientFullName = textBoxClientFullName.Text,
                RepairRecordPhone = textBoxPhone.Text,
                RepairRecordEmail = textBoxEmail.Text,
            });
            _mainForm.GetStatistics();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void FillComboBox()
        {
            foreach (Type type in Enum.GetValues(typeof(Type))) comboBoxType.Items.Add(type.ToString());
            foreach (Status status in Enum.GetValues(typeof(Status))) comboBoxStatus.Items.Add(status.ToString());
        }
    }
}
