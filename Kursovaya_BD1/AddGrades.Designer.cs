namespace Kursovaya_BD1
{
    partial class AddGrades
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
            this.StudComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExamComboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GradeComboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateComboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GroupComboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudComboBox1
            // 
            this.StudComboBox1.FormattingEnabled = true;
            this.StudComboBox1.Location = new System.Drawing.Point(12, 86);
            this.StudComboBox1.Name = "StudComboBox1";
            this.StudComboBox1.Size = new System.Drawing.Size(121, 21);
            this.StudComboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Студент";
            // 
            // ExamComboBox2
            // 
            this.ExamComboBox2.FormattingEnabled = true;
            this.ExamComboBox2.Location = new System.Drawing.Point(12, 138);
            this.ExamComboBox2.Name = "ExamComboBox2";
            this.ExamComboBox2.Size = new System.Drawing.Size(181, 21);
            this.ExamComboBox2.TabIndex = 0;
            this.ExamComboBox2.SelectedIndexChanged += new System.EventHandler(this.ExamComboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Экзамен";
            // 
            // GradeComboBox3
            // 
            this.GradeComboBox3.FormattingEnabled = true;
            this.GradeComboBox3.Location = new System.Drawing.Point(12, 238);
            this.GradeComboBox3.Name = "GradeComboBox3";
            this.GradeComboBox3.Size = new System.Drawing.Size(121, 21);
            this.GradeComboBox3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Оценка";
            // 
            // DateComboBox4
            // 
            this.DateComboBox4.FormattingEnabled = true;
            this.DateComboBox4.Location = new System.Drawing.Point(12, 192);
            this.DateComboBox4.Name = "DateComboBox4";
            this.DateComboBox4.Size = new System.Drawing.Size(308, 21);
            this.DateComboBox4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата экзамена";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupComboBox5
            // 
            this.GroupComboBox5.FormattingEnabled = true;
            this.GroupComboBox5.Location = new System.Drawing.Point(12, 35);
            this.GroupComboBox5.Name = "GroupComboBox5";
            this.GroupComboBox5.Size = new System.Drawing.Size(121, 21);
            this.GroupComboBox5.TabIndex = 0;
            this.GroupComboBox5.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox5_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Группа";
            // 
            // AddGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 391);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateComboBox4);
            this.Controls.Add(this.GradeComboBox3);
            this.Controls.Add(this.ExamComboBox2);
            this.Controls.Add(this.GroupComboBox5);
            this.Controls.Add(this.StudComboBox1);
            this.Name = "AddGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить оценку";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddGrades_FormClosed);
            this.Load += new System.EventHandler(this.AddGrades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StudComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ExamComboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GradeComboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DateComboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox GroupComboBox5;
        private System.Windows.Forms.Label label5;
    }
}