namespace ExamPrep.Models
{
    public class RepairRecordModel
    {
        public int RepairRecordId;
        public DateOnly RepairRecordDate;
        public string RepairRecordStatus { get; set; } = string.Empty;
        public string RepairRecordDevice { get; set; } = string.Empty;
        public string RepairRecordType { get; set; } = string.Empty;
        public string RepairRecordDesc { get; set; } = string.Empty;
        public string RepairRecordMasterFullName { get; set; } = string.Empty;
        public string RepairRecordClientFullName { get; set; } = string.Empty;
        public string RepairRecordPhone { get; set; } = string.Empty;
        public string RepairRecordEmail { get; set; } = string.Empty;
    }
}
