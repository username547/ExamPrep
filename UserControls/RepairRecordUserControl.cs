using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPrep.UserControls
{
    public partial class RepairRecordUserControl : UserControl
    {
        public RepairRecordUserControl()
        {
            InitializeComponent();
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

        public string RepairRecordFullName
        {
            get => TextBoxFullName.Text;
            set => TextBoxFullName.Text = value;
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
