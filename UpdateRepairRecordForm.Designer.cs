namespace ExamPrep
{
    partial class UpdateRepairRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxMasterFullName = new TextBox();
            label8 = new Label();
            ComboBoxStatus = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            TextBoxDesc = new TextBox();
            CancelBtn = new Button();
            UpdateRepairRecordBtn = new Button();
            TextBoxEmail = new TextBox();
            label5 = new Label();
            TextBoxPhone = new TextBox();
            label4 = new Label();
            TextBoxClientFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ComboBoxType = new ComboBox();
            TextBoxDevice = new TextBox();
            label1 = new Label();
            label9 = new Label();
            TextBoxId = new TextBox();
            SuspendLayout();
            // 
            // TextBoxMasterFullName
            // 
            TextBoxMasterFullName.Location = new Point(12, 138);
            TextBoxMasterFullName.Name = "TextBoxMasterFullName";
            TextBoxMasterFullName.Size = new Size(379, 27);
            TextBoxMasterFullName.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 115);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 34;
            label8.Text = "ФИО Мастера";
            // 
            // ComboBoxStatus
            // 
            ComboBoxStatus.FormattingEnabled = true;
            ComboBoxStatus.Location = new Point(291, 84);
            ComboBoxStatus.Name = "ComboBoxStatus";
            ComboBoxStatus.Size = new Size(100, 28);
            ComboBoxStatus.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(291, 62);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 32;
            label7.Text = "Статус";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 274);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 31;
            label6.Text = "Описание";
            // 
            // TextBoxDesc
            // 
            TextBoxDesc.Location = new Point(12, 297);
            TextBoxDesc.Multiline = true;
            TextBoxDesc.Name = "TextBoxDesc";
            TextBoxDesc.ScrollBars = ScrollBars.Vertical;
            TextBoxDesc.Size = new Size(379, 154);
            TextBoxDesc.TabIndex = 30;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(297, 457);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 29);
            CancelBtn.TabIndex = 29;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // UpdateRepairRecordBtn
            // 
            UpdateRepairRecordBtn.Location = new Point(12, 457);
            UpdateRepairRecordBtn.Name = "UpdateRepairRecordBtn";
            UpdateRepairRecordBtn.Size = new Size(94, 29);
            UpdateRepairRecordBtn.TabIndex = 28;
            UpdateRepairRecordBtn.Text = "Изменить";
            UpdateRepairRecordBtn.UseVisualStyleBackColor = true;
            UpdateRepairRecordBtn.Click += UpdateRepairRecordBtn_Click;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(231, 244);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(160, 27);
            TextBoxEmail.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(284, 221);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 26;
            label5.Text = "Email Клиента";
            // 
            // TextBoxPhone
            // 
            TextBoxPhone.Location = new Point(12, 244);
            TextBoxPhone.Name = "TextBoxPhone";
            TextBoxPhone.Size = new Size(160, 27);
            TextBoxPhone.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 24;
            label4.Text = "Тел. Клиента";
            // 
            // TextBoxClientFullName
            // 
            TextBoxClientFullName.Location = new Point(12, 191);
            TextBoxClientFullName.Name = "TextBoxClientFullName";
            TextBoxClientFullName.Size = new Size(379, 27);
            TextBoxClientFullName.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 168);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 22;
            label3.Text = "ФИО Клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 62);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 21;
            label2.Text = "Тип неиспр.";
            // 
            // ComboBoxType
            // 
            ComboBoxType.FormattingEnabled = true;
            ComboBoxType.Location = new Point(181, 84);
            ComboBoxType.Name = "ComboBoxType";
            ComboBoxType.Size = new Size(100, 28);
            ComboBoxType.TabIndex = 20;
            // 
            // TextBoxDevice
            // 
            TextBoxDevice.Location = new Point(12, 85);
            TextBoxDevice.Name = "TextBoxDevice";
            TextBoxDevice.Size = new Size(160, 27);
            TextBoxDevice.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 18;
            label1.Text = "Оборудование";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 36;
            label9.Text = "Номер";
            // 
            // TextBoxId
            // 
            TextBoxId.Enabled = false;
            TextBoxId.Location = new Point(12, 32);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.Size = new Size(100, 27);
            TextBoxId.TabIndex = 37;
            // 
            // UpdateRepairRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 491);
            Controls.Add(TextBoxId);
            Controls.Add(label9);
            Controls.Add(TextBoxMasterFullName);
            Controls.Add(label8);
            Controls.Add(ComboBoxStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TextBoxDesc);
            Controls.Add(CancelBtn);
            Controls.Add(UpdateRepairRecordBtn);
            Controls.Add(TextBoxEmail);
            Controls.Add(label5);
            Controls.Add(TextBoxPhone);
            Controls.Add(label4);
            Controls.Add(TextBoxClientFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ComboBoxType);
            Controls.Add(TextBoxDevice);
            Controls.Add(label1);
            Name = "UpdateRepairRecordForm";
            Text = "UpdateRepairRecordForm";
            Load += UpdateRepairRecordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxMasterFullName;
        private Label label8;
        private ComboBox ComboBoxStatus;
        private Label label7;
        private Label label6;
        private TextBox TextBoxDesc;
        private Button CancelBtn;
        private Button UpdateRepairRecordBtn;
        private TextBox TextBoxEmail;
        private Label label5;
        private TextBox TextBoxPhone;
        private Label label4;
        private TextBox TextBoxClientFullName;
        private Label label3;
        private Label label2;
        private ComboBox ComboBoxType;
        private TextBox TextBoxDevice;
        private Label label1;
        private Label label9;
        private TextBox TextBoxId;
    }
}