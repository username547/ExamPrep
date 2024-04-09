using ExamPrep.Models;
using ExamPrep.UserControls;
using System.Security.Cryptography;

namespace ExamPrep
{
    public partial class MainForm : Form
    {
        public List<RepairRecordModel> repairRecords;

        public MainForm()
        {
            InitializeComponent();
            repairRecords = new List<RepairRecordModel>();
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
                RepairRecordId = Convert.ToString(repairRecord.RepairRecordId),
                RepairRecordDate = Convert.ToString(repairRecord.RepairRecordDate),
                RepairRecordStatus = Convert.ToString(repairRecord.RepairRecordStatus),
                RepairRecordDevice = Convert.ToString(repairRecord.RepairRecordDevice),
                RepairRecordType = Convert.ToString(repairRecord.RepairRecordType),
                RepairRecordDesc = Convert.ToString(repairRecord.RepairRecordDesc),
                RepairRecordMasterFullName = Convert.ToString(repairRecord.RepairRecordMasterFullName),
                RepairRecordClientFullName = Convert.ToString(repairRecord.RepairRecordClientFullName),
                RepairRecordPhone = Convert.ToString(repairRecord.RepairRecordPhone),
                RepairRecordEmail = Convert.ToString(repairRecord.RepairRecordEmail),
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

        private void CreateBtn_Click(object sender, EventArgs e)
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
        }
    }
}

