namespace Kursovaya_BD1
{
    partial class AddExam
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ExamComboBox1 = new System.Windows.Forms.ComboBox();
            this.GroupComboBox2 = new System.Windows.Forms.ComboBox();
            this.TeachComboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton1 = new System.Windows.Forms.Button();
            this.CancelButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 25);
            this.dateTimePicker1.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // ExamComboBox1
            // 
            this.ExamComboBox1.FormattingEnabled = true;
            this.ExamComboBox1.Location = new System.Drawing.Point(12, 69);
            this.ExamComboBox1.Name = "ExamComboBox1";
            this.ExamComboBox1.Size = new System.Drawing.Size(223, 21);
            this.ExamComboBox1.TabIndex = 1;
            // 
            // GroupComboBox2
            // 
            this.GroupComboBox2.FormattingEnabled = true;
            this.GroupComboBox2.Location = new System.Drawing.Point(12, 116);
            this.GroupComboBox2.Name = "GroupComboBox2";
            this.GroupComboBox2.Size = new System.Drawing.Size(223, 21);
            this.GroupComboBox2.TabIndex = 2;
            // 
            // TeachComboBox4
            // 
            this.TeachComboBox4.FormattingEnabled = true;
            this.TeachComboBox4.Location = new System.Drawing.Point(12, 165);
            this.TeachComboBox4.Name = "TeachComboBox4";
            this.TeachComboBox4.Size = new System.Drawing.Size(223, 21);
            this.TeachComboBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Экзамен";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Преподаватель";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SaveButton1
            // 
            this.SaveButton1.Location = new System.Drawing.Point(12, 207);
            this.SaveButton1.Name = "SaveButton1";
            this.SaveButton1.Size = new System.Drawing.Size(90, 36);
            this.SaveButton1.TabIndex = 10;
            this.SaveButton1.Text = "Сохранить";
            this.SaveButton1.UseVisualStyleBackColor = true;
            this.SaveButton1.Click += new System.EventHandler(this.SaveButton1_Click);
            // 
            // CancelButton2
            // 
            this.CancelButton2.Location = new System.Drawing.Point(149, 207);
            this.CancelButton2.Name = "CancelButton2";
            this.CancelButton2.Size = new System.Drawing.Size(86, 36);
            this.CancelButton2.TabIndex = 11;
            this.CancelButton2.Text = "Отменить";
            this.CancelButton2.UseVisualStyleBackColor = true;
            this.CancelButton2.Click += new System.EventHandler(this.CancelButton2_Click);
            // 
            // AddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 255);
            this.Controls.Add(this.CancelButton2);
            this.Controls.Add(this.SaveButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeachComboBox4);
            this.Controls.Add(this.GroupComboBox2);
            this.Controls.Add(this.ExamComboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AddExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить экзамен";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddExam_FormClosed);
            this.Load += new System.EventHandler(this.AddExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ExamComboBox1;
        private System.Windows.Forms.ComboBox GroupComboBox2;
        private System.Windows.Forms.ComboBox TeachComboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveButton1;
        private System.Windows.Forms.Button CancelButton2;
    }
}