namespace ExamPrep.UserControls
{
    partial class RepairRecordUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TextBoxId = new TextBox();
            label2 = new Label();
            TextBoxDate = new TextBox();
            label3 = new Label();
            TextBoxDevice = new TextBox();
            label4 = new Label();
            TextBoxType = new TextBox();
            label5 = new Label();
            TextBoxDesc = new TextBox();
            label6 = new Label();
            label7 = new Label();
            TextBoxFullName = new TextBox();
            label8 = new Label();
            TextBoxPhone = new TextBox();
            label9 = new Label();
            TextBoxEmail = new TextBox();
            ButtonUpdate = new Button();
            ButtonDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Номер";
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(3, 23);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.Size = new Size(100, 27);
            TextBoxId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Дата";
            // 
            // TextBoxDate
            // 
            TextBoxDate.Location = new Point(109, 23);
            TextBoxDate.Name = "TextBoxDate";
            TextBoxDate.Size = new Size(100, 27);
            TextBoxDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 4;
            label3.Text = "Оборудование";
            // 
            // TextBoxDevice
            // 
            TextBoxDevice.Location = new Point(215, 23);
            TextBoxDevice.Name = "TextBoxDevice";
            TextBoxDevice.Size = new Size(113, 27);
            TextBoxDevice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 6;
            label4.Text = "Тип неиспр.";
            // 
            // TextBoxType
            // 
            TextBoxType.Location = new Point(334, 23);
            TextBoxType.Name = "TextBoxType";
            TextBoxType.Size = new Size(100, 27);
            TextBoxType.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 53);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 8;
            label5.Text = "Описание";
            // 
            // TextBoxDesc
            // 
            TextBoxDesc.Location = new Point(3, 76);
            TextBoxDesc.Multiline = true;
            TextBoxDesc.Name = "TextBoxDesc";
            TextBoxDesc.ScrollBars = ScrollBars.Vertical;
            TextBoxDesc.Size = new Size(431, 100);
            TextBoxDesc.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(470, 12);
            label6.Name = "label6";
            label6.Size = new Size(174, 20);
            label6.TabIndex = 10;
            label6.Text = "Информация о клиенте";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(474, 38);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 11;
            label7.Text = "ФИО";
            // 
            // TextBoxFullName
            // 
            TextBoxFullName.Location = new Point(522, 35);
            TextBoxFullName.Name = "TextBoxFullName";
            TextBoxFullName.Size = new Size(220, 27);
            TextBoxFullName.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(480, 71);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 13;
            label8.Text = "Тел.";
            // 
            // TextBoxPhone
            // 
            TextBoxPhone.Location = new Point(522, 68);
            TextBoxPhone.Name = "TextBoxPhone";
            TextBoxPhone.Size = new Size(220, 27);
            TextBoxPhone.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(470, 104);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 15;
            label9.Text = "Email";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(522, 101);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(220, 27);
            TextBoxEmail.TabIndex = 16;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(522, 147);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(94, 29);
            ButtonUpdate.TabIndex = 17;
            ButtonUpdate.Text = "Изменить";
            ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(648, 147);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(94, 29);
            ButtonDelete.TabIndex = 18;
            ButtonDelete.Text = "Удалить";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // RepairRecordUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonUpdate);
            Controls.Add(TextBoxEmail);
            Controls.Add(label9);
            Controls.Add(TextBoxPhone);
            Controls.Add(label8);
            Controls.Add(TextBoxFullName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TextBoxDesc);
            Controls.Add(label5);
            Controls.Add(TextBoxType);
            Controls.Add(label4);
            Controls.Add(TextBoxDevice);
            Controls.Add(label3);
            Controls.Add(TextBoxDate);
            Controls.Add(label2);
            Controls.Add(TextBoxId);
            Controls.Add(label1);
            Name = "RepairRecordUserControl";
            Size = new Size(745, 179);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxId;
        private Label label2;
        private TextBox TextBoxDate;
        private Label label3;
        private TextBox TextBoxDevice;
        private Label label4;
        private TextBox TextBoxType;
        private Label label5;
        private TextBox TextBoxDesc;
        private Label label6;
        private Label label7;
        private TextBox TextBoxFullName;
        private Label label8;
        private TextBox TextBoxPhone;
        private Label label9;
        private TextBox TextBoxEmail;
        private Button ButtonUpdate;
        private Button ButtonDelete;
    }
}
