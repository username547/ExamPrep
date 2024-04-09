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
            get => TextBoxId.Text;
            set => TextBoxId.Text = value;
        }

        public string RepairRecordDate
        {
            get => TextBoxDate.Text;
            set => TextBoxDate.Text = value;
        }

        public string RepairRecordStatus
        {
            get => TextBoxStatus.Text;
            set => TextBoxStatus.Text = value;
        }

        public string RepairRecordDevice
        {
            get => TextBoxDevice.Text;
            set => TextBoxDevice.Text = value;
        }

        public string RepairRecordType
        {
            get => TextBoxType.Text;
            set => TextBoxType.Text = value;
        }

        public string RepairRecordDesc
        {
            get => TextBoxDesc.Text;
            set => TextBoxDesc.Text = value;
        }

        public string RepairRecordMasterFullName
        {
            get => TextBoxMasterFullName.Text;
            set => TextBoxMasterFullName.Text = value;
        }

        public string RepairRecordClientFullName
        {
            get => TextBoxClientFullName.Text;
            set => TextBoxClientFullName.Text = value;
        }

        public string RepairRecordPhone
        {
            get => TextBoxPhone.Text;
            set => TextBoxPhone.Text = value;
        }

        public string RepairRecordEmail
        {
            get => TextBoxEmail.Text;
            set => TextBoxEmail.Text = value;
        }
    }
}
