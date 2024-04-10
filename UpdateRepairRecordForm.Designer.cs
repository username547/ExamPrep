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
            textBoxMasterFullName = new TextBox();
            label8 = new Label();
            comboBoxStatus = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            textBoxDesc = new TextBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            textBoxEmail = new TextBox();
            label5 = new Label();
            textBoxPhone = new TextBox();
            label4 = new Label();
            textBoxClientFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBoxType = new ComboBox();
            textBoxDevice = new TextBox();
            label1 = new Label();
            label9 = new Label();
            textBoxId = new TextBox();
            SuspendLayout();
            // 
            // textBoxMasterFullName
            // 
            textBoxMasterFullName.Location = new Point(12, 138);
            textBoxMasterFullName.Name = "textBoxMasterFullName";
            textBoxMasterFullName.Size = new Size(379, 27);
            textBoxMasterFullName.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 9F);
            label8.Location = new Point(12, 115);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 34;
            label8.Text = "ФИО Мастера";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(291, 84);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(100, 28);
            comboBoxStatus.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9F);
            label7.Location = new Point(291, 62);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 32;
            label7.Text = "Статус";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9F);
            label6.Location = new Point(12, 274);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 31;
            label6.Text = "Описание";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(12, 297);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.ScrollBars = ScrollBars.Vertical;
            textBoxDesc.Size = new Size(379, 154);
            textBoxDesc.TabIndex = 30;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Comic Sans MS", 9F);
            btnCancel.Location = new Point(297, 457);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Comic Sans MS", 9F);
            btnUpdate.Location = new Point(12, 457);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Изменить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(211, 244);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(180, 27);
            textBoxEmail.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F);
            label5.Location = new Point(281, 221);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 26;
            label5.Text = "Email Клиента";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(12, 244);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(180, 27);
            textBoxPhone.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F);
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 24;
            label4.Text = "Тел. Клиента";
            // 
            // textBoxClientFullName
            // 
            textBoxClientFullName.Location = new Point(12, 191);
            textBoxClientFullName.Name = "textBoxClientFullName";
            textBoxClientFullName.Size = new Size(379, 27);
            textBoxClientFullName.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F);
            label3.Location = new Point(12, 168);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 22;
            label3.Text = "ФИО Клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F);
            label2.Location = new Point(178, 62);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 21;
            label2.Text = "Тип неиспр.";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(181, 84);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(100, 28);
            comboBoxType.TabIndex = 20;
            // 
            // textBoxDevice
            // 
            textBoxDevice.Location = new Point(12, 85);
            textBoxDevice.Name = "textBoxDevice";
            textBoxDevice.Size = new Size(160, 27);
            textBoxDevice.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 18;
            label1.Text = "Оборудование";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 36;
            label9.Text = "Номер";
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(12, 32);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 27);
            textBoxId.TabIndex = 37;
            // 
            // UpdateRepairRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 491);
            Controls.Add(textBoxId);
            Controls.Add(label9);
            Controls.Add(textBoxMasterFullName);
            Controls.Add(label8);
            Controls.Add(comboBoxStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxDesc);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
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
            Name = "UpdateRepairRecordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateRepairRecordForm";
            Load += UpdateRepairRecordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMasterFullName;
        private Label label8;
        private ComboBox comboBoxStatus;
        private Label label7;
        private Label label6;
        private TextBox textBoxDesc;
        private Button btnCancel;
        private Button btnUpdate;
        private TextBox textBoxEmail;
        private Label label5;
        private TextBox textBoxPhone;
        private Label label4;
        private TextBox textBoxClientFullName;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxType;
        private TextBox textBoxDevice;
        private Label label1;
        private Label label9;
        private TextBox textBoxId;
    }
}