namespace ExamPrep.UserControls
{
    public partial class RepairRecordUserControl : UserControl
    {
        public event EventHandler btnUpdateClicked;
        public event EventHandler btnDeleteClicked;

        public RepairRecordUserControl()
        {
            InitializeComponent();
            btnUpdate.Click += (sender, e) => btnUpdateClicked?.Invoke(this, EventArgs.Empty);
            btnDelete.Click += (sender, e) => btnDeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        public string RepairRecordId
        {
            get => textBoxId.Text;
            set => textBoxId.Text = value;
        }

        public string RepairRecordDate
        {
            get => textBoxDate.Text;
            set => textBoxDate.Text = value;
        }

        public string RepairRecordCompletedDate
        {
            get => textBoxCompletedDate.Text;
            set => textBoxCompletedDate.Text = value;
        }

        public string RepairRecordStatus
        {
            get => textBoxStatus.Text;
            set => textBoxStatus.Text = value;
        }

        public string RepairRecordDevice
        {
            get => textBoxDevice.Text;
            set => textBoxDevice.Text = value;
        }

        public string RepairRecordType
        {
            get => textBoxType.Text;
            set => textBoxType.Text = value;
        }

        public string RepairRecordDesc
        {
            get => TextBoxDesc.Text;
            set => TextBoxDesc.Text = value;
        }

        public string RepairRecordMasterFullName
        {
            get => textBoxMasterFullName.Text;
            set => textBoxMasterFullName.Text = value;
        }

        public string RepairRecordClientFullName
        {
            get => textBoxClientFullName.Text;
            set => textBoxClientFullName.Text = value;
        }

        public string RepairRecordPhone
        {
            get => textBoxPhone.Text;
            set => textBoxPhone.Text = value;
        }

        public string RepairRecordEmail
        {
            get => textBoxEmail.Text;
            set => textBoxEmail.Text = value;
        }
    }
}
