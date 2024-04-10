using ExamPrep.Models;
using ExamPrep.UserControls;

namespace ExamPrep
{
    public partial class MainForm : Form
    {
        public List<RepairRecordModel> repairRecords;
        public int numCompleted;
        public DateTime? avgDateTime;

        public MainForm()
        {
            InitializeComponent();
            repairRecords = new List<RepairRecordModel>();
            numCompleted = 0;
            avgDateTime = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelCompleted.Text = "";
            labelAngDateTime.Text = "";
            GetStatistics();
        }

        public void CreateRepairRecord(RepairRecordModel dto)
        {
            repairRecords.Add(dto);
            RefreshRepairRecordUserControls();
        }

        public void UpdateRepairRecord(RepairRecordModel dto)
        {
            var repairRecord = repairRecords.First(x => x.RepairRecordId == dto.RepairRecordId);
            repairRecord.RepairRecordDate = dto.RepairRecordDate;
            repairRecord.RepairRecordCompletedDate = dto.RepairRecordCompletedDate;
            repairRecord.RepairRecordStatus = dto.RepairRecordStatus;
            repairRecord.RepairRecordDevice = dto.RepairRecordDevice;
            repairRecord.RepairRecordType = dto.RepairRecordType;
            repairRecord.RepairRecordDesc = dto.RepairRecordDesc;
            repairRecord.RepairRecordMasterFullName = dto.RepairRecordMasterFullName;
            repairRecord.RepairRecordClientFullName = dto.RepairRecordClientFullName;
            repairRecord.RepairRecordPhone = dto.RepairRecordPhone;
            repairRecord.RepairRecordEmail = dto.RepairRecordEmail;
            RefreshRepairRecordUserControls();
        }

        private void CreateRepairRecordUserControl(RepairRecordModel repairRecord)
        {
            RepairRecordUserControl repairRecordUserControl = new RepairRecordUserControl
            {
                RepairRecordId = repairRecord.RepairRecordId.ToString(),
                RepairRecordDate = repairRecord.RepairRecordDate.ToString(),
                RepairRecordCompletedDate = repairRecord.RepairRecordCompletedDate.ToString() ?? string.Empty,
                RepairRecordStatus = repairRecord.RepairRecordStatus,
                RepairRecordDevice = repairRecord.RepairRecordDevice,
                RepairRecordType = repairRecord.RepairRecordType,
                RepairRecordDesc = repairRecord.RepairRecordDesc,
                RepairRecordMasterFullName = repairRecord.RepairRecordMasterFullName,
                RepairRecordClientFullName = repairRecord.RepairRecordClientFullName,
                RepairRecordPhone = repairRecord.RepairRecordPhone,
                RepairRecordEmail = repairRecord.RepairRecordEmail,
            };

            repairRecordUserControl.btnUpdateClicked += btnUpdate_Click!;
            repairRecordUserControl.btnDeleteClicked += btnDelete_Click!;

            RepairRecordsPanel.Controls.Add(repairRecordUserControl);
        }

        public void RefreshRepairRecordUserControls()
        {
            RepairRecordsPanel.Controls.Clear();
            foreach (RepairRecordModel item in repairRecords) CreateRepairRecordUserControl(item);
        }

        public void GetStatistics()
        {
            numCompleted = 0;
            double temp = 0;
            foreach (RepairRecordModel item in repairRecords)
            {
                if (item.RepairRecordStatus == Status.Завершен.ToString())
                    numCompleted++;

                if (item.RepairRecordCompletedDate != null)
                    temp += (item.RepairRecordCompletedDate.Value - item.RepairRecordDate).TotalSeconds;
            }

            labelCompleted.Text = Convert.ToString(numCompleted);

            if (numCompleted > 0) labelAngDateTime.Text = Convert.ToString(temp / numCompleted);
            else labelAngDateTime.Text = "0";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int lastRepairRecordId = repairRecords.LastOrDefault()?.RepairRecordId ?? 0;
            CreateRepairRecordForm createRepairRecordForm = new CreateRepairRecordForm(this, lastRepairRecordId);
            createRepairRecordForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var repairRecordUserControl = sender as RepairRecordUserControl;
            var repairRecord = repairRecords.First(x => x.RepairRecordId == Convert.ToInt32(repairRecordUserControl!.RepairRecordId));
            UpdateRepairRecordForm updateRepairRecordForm = new UpdateRepairRecordForm(this, repairRecord);
            updateRepairRecordForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var repairRecordUserControl = sender as RepairRecordUserControl;
            var repairRecord = repairRecords.First(x => x.RepairRecordId == Convert.ToInt32(repairRecordUserControl!.RepairRecordId));
            repairRecords.Remove(repairRecord);
            RefreshRepairRecordUserControls();
            GetStatistics();
        }
    }
}

