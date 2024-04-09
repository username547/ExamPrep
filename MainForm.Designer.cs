namespace ExamPrep
{
    partial class MainForm
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
            RepairRecordsPanel = new FlowLayoutPanel();
            CreateBtn = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // RepairRecordsPanel
            // 
            RepairRecordsPanel.AutoScroll = true;
            RepairRecordsPanel.Location = new Point(12, 40);
            RepairRecordsPanel.Name = "RepairRecordsPanel";
            RepairRecordsPanel.Size = new Size(918, 472);
            RepairRecordsPanel.TabIndex = 0;
            // 
            // CreateBtn
            // 
            CreateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateBtn.Location = new Point(12, 518);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(94, 29);
            CreateBtn.TabIndex = 1;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(118, 227, 131);
            ClientSize = new Size(942, 553);
            Controls.Add(textBox1);
            Controls.Add(CreateBtn);
            Controls.Add(RepairRecordsPanel);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel RepairRecordsPanel;
        private Button CreateBtn;
        private TextBox textBox1;
    }
}