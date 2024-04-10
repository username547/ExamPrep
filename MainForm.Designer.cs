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
            btnCreate = new Button();
            label1 = new Label();
            labelCompleted = new Label();
            label2 = new Label();
            labelAngDateTime = new Label();
            SuspendLayout();
            // 
            // RepairRecordsPanel
            // 
            RepairRecordsPanel.AutoScroll = true;
            RepairRecordsPanel.Location = new Point(12, 40);
            RepairRecordsPanel.Name = "RepairRecordsPanel";
            RepairRecordsPanel.Size = new Size(918, 506);
            RepairRecordsPanel.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreate.Location = new Point(12, 552);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Добавить";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 3;
            label1.Text = "Кол. выполненных";
            // 
            // labelCompleted
            // 
            labelCompleted.AutoSize = true;
            labelCompleted.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCompleted.Location = new Point(165, 11);
            labelCompleted.Name = "labelCompleted";
            labelCompleted.Size = new Size(40, 20);
            labelCompleted.TabIndex = 4;
            labelCompleted.Text = "text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(246, 9);
            label2.Name = "label2";
            label2.Size = new Size(209, 20);
            label2.TabIndex = 5;
            label2.Text = "Среднее время выполнения";
            // 
            // labelAngDateTime
            // 
            labelAngDateTime.AutoSize = true;
            labelAngDateTime.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAngDateTime.Location = new Point(461, 9);
            labelAngDateTime.Name = "labelAngDateTime";
            labelAngDateTime.Size = new Size(40, 20);
            labelAngDateTime.TabIndex = 6;
            labelAngDateTime.Text = "text";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(942, 593);
            Controls.Add(labelAngDateTime);
            Controls.Add(label2);
            Controls.Add(labelCompleted);
            Controls.Add(label1);
            Controls.Add(btnCreate);
            Controls.Add(RepairRecordsPanel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel RepairRecordsPanel;
        private Button btnCreate;
        private Label label1;
        private Label labelCompleted;
        private Label label2;
        private Label labelAngDateTime;
    }
}