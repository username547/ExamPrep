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
            textBoxDevice = new TextBox();
            comboBoxType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBoxClientFullName = new TextBox();
            label4 = new Label();
            textBoxPhone = new TextBox();
            label5 = new Label();
            textBoxEmail = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            textBoxDesc = new TextBox();
            label6 = new Label();
            label7 = new Label();
            comboBoxStatus = new ComboBox();
            label8 = new Label();
            textBoxMasterFullName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Оборудование";
            // 
            // textBoxDevice
            // 
            textBoxDevice.Location = new Point(12, 32);
            textBoxDevice.Name = "textBoxDevice";
            textBoxDevice.Size = new Size(160, 27);
            textBoxDevice.TabIndex = 1;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(181, 31);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(100, 28);
            comboBoxType.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F);
            label2.Location = new Point(178, 9);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "Тип неиспр.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F);
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 4;
            label3.Text = "ФИО Клиента";
            // 
            // textBoxClientFullName
            // 
            textBoxClientFullName.Location = new Point(12, 138);
            textBoxClientFullName.Name = "textBoxClientFullName";
            textBoxClientFullName.Size = new Size(379, 27);
            textBoxClientFullName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F);
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 6;
            label4.Text = "Тел. Клиента";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(12, 191);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(180, 27);
            textBoxPhone.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F);
            label5.Location = new Point(281, 168);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 8;
            label5.Text = "Email Клиента";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(211, 191);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(180, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Comic Sans MS", 9F);
            btnCreate.Location = new Point(12, 404);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Добавить";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Comic Sans MS", 9F);
            btnCancel.Location = new Point(297, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(12, 244);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.ScrollBars = ScrollBars.Vertical;
            textBoxDesc.Size = new Size(379, 154);
            textBoxDesc.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9F);
            label6.Location = new Point(12, 221);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 13;
            label6.Text = "Описание";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9F);
            label7.Location = new Point(291, 9);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 14;
            label7.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(291, 31);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(100, 28);
            comboBoxStatus.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9F);
            label8.Location = new Point(12, 62);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 16;
            label8.Text = "ФИО Мастера";
            // 
            // textBoxMasterFullName
            // 
            textBoxMasterFullName.Location = new Point(12, 85);
            textBoxMasterFullName.Name = "textBoxMasterFullName";
            textBoxMasterFullName.Size = new Size(379, 27);
            textBoxMasterFullName.TabIndex = 17;
            // 
            // CreateRepairRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 440);
            Controls.Add(textBoxMasterFullName);
            Controls.Add(label8);
            Controls.Add(comboBoxStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxDesc);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(textBoxPhone);
            Controls.Add(label4);
            Controls.Add(textBoxClientFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxDevice);
            Controls.Add(label1);
            Name = "CreateRepairRecordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateRepairRecordForm";
            Load += CreateRepairRecordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxDevice;
        private ComboBox comboBoxType;
        private Label label2;
        private Label label3;
        private TextBox textBoxClientFullName;
        private Label label4;
        private TextBox textBoxPhone;
        private Label label5;
        private TextBox textBoxEmail;
        private Button btnCreate;
        private Button btnCancel;
        private TextBox textBoxDesc;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxStatus;
        private Label label8;
        private TextBox textBoxMasterFullName;
    }
}