namespace ExamPrep
{
    partial class CreateRepairRecordForm
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
            label1 = new Label();
            TextBoxDevice = new TextBox();
            ComboBoxType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            TextBoxClientFullName = new TextBox();
            label4 = new Label();
            TextBoxPhone = new TextBox();
            label5 = new Label();
            TextBoxEmail = new TextBox();
            CreateRepairRecordBtn = new Button();
            CancelBtn = new Button();
            TextBoxDesc = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ComboBoxStatus = new ComboBox();
            label8 = new Label();
            TextBoxMasterFullName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Оборудование";
            // 
            // TextBoxDevice
            // 
            TextBoxDevice.Location = new Point(12, 32);
            TextBoxDevice.Name = "TextBoxDevice";
            TextBoxDevice.Size = new Size(160, 27);
            TextBoxDevice.TabIndex = 1;
            // 
            // ComboBoxType
            // 
            ComboBoxType.FormattingEnabled = true;
            ComboBoxType.Location = new Point(181, 31);
            ComboBoxType.Name = "ComboBoxType";
            ComboBoxType.Size = new Size(100, 28);
            ComboBoxType.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 9);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 3;
            label2.Text = "Тип неиспр.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 4;
            label3.Text = "ФИО Клиента";
            // 
            // TextBoxClientFullName
            // 
            TextBoxClientFullName.Location = new Point(12, 138);
            TextBoxClientFullName.Name = "TextBoxClientFullName";
            TextBoxClientFullName.Size = new Size(379, 27);
            TextBoxClientFullName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 6;
            label4.Text = "Тел. Клиента";
            // 
            // TextBoxPhone
            // 
            TextBoxPhone.Location = new Point(12, 191);
            TextBoxPhone.Name = "TextBoxPhone";
            TextBoxPhone.Size = new Size(160, 27);
            TextBoxPhone.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(284, 168);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 8;
            label5.Text = "Email Клиента";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(231, 191);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(160, 27);
            TextBoxEmail.TabIndex = 9;
            // 
            // CreateRepairRecordBtn
            // 
            CreateRepairRecordBtn.Location = new Point(12, 404);
            CreateRepairRecordBtn.Name = "CreateRepairRecordBtn";
            CreateRepairRecordBtn.Size = new Size(94, 29);
            CreateRepairRecordBtn.TabIndex = 10;
            CreateRepairRecordBtn.Text = "Добавить";
            CreateRepairRecordBtn.UseVisualStyleBackColor = true;
            CreateRepairRecordBtn.Click += CreateRepairRecordBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(297, 404);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 29);
            CancelBtn.TabIndex = 11;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // TextBoxDesc
            // 
            TextBoxDesc.Location = new Point(12, 244);
            TextBoxDesc.Multiline = true;
            TextBoxDesc.Name = "TextBoxDesc";
            TextBoxDesc.ScrollBars = ScrollBars.Vertical;
            TextBoxDesc.Size = new Size(379, 154);
            TextBoxDesc.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 221);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 13;
            label6.Text = "Описание";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(291, 9);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 14;
            label7.Text = "Статус";
            // 
            // ComboBoxStatus
            // 
            ComboBoxStatus.FormattingEnabled = true;
            ComboBoxStatus.Location = new Point(291, 31);
            ComboBoxStatus.Name = "ComboBoxStatus";
            ComboBoxStatus.Size = new Size(100, 28);
            ComboBoxStatus.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 62);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 16;
            label8.Text = "ФИО Мастера";
            // 
            // TextBoxMasterFullName
            // 
            TextBoxMasterFullName.Location = new Point(12, 85);
            TextBoxMasterFullName.Name = "TextBoxMasterFullName";
            TextBoxMasterFullName.Size = new Size(379, 27);
            TextBoxMasterFullName.TabIndex = 17;
            // 
            // CreateRepairRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 440);
            Controls.Add(TextBoxMasterFullName);
            Controls.Add(label8);
            Controls.Add(ComboBoxStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TextBoxDesc);
            Controls.Add(CancelBtn);
            Controls.Add(CreateRepairRecordBtn);
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
            Name = "CreateRepairRecordForm";
            Text = "CreateRepairRecordForm";
            Load += CreateRepairRecordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxDevice;
        private ComboBox ComboBoxType;
        private Label label2;
        private Label label3;
        private TextBox TextBoxClientFullName;
        private Label label4;
        private TextBox TextBoxPhone;
        private Label label5;
        private TextBox TextBoxEmail;
        private Button CreateRepairRecordBtn;
        private Button CancelBtn;
        private TextBox TextBoxDesc;
        private Label label6;
        private Label label7;
        private ComboBox ComboBoxStatus;
        private Label label8;
        private TextBox TextBoxMasterFullName;
    }
}