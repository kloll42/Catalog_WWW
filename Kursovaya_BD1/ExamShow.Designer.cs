﻿namespace Kursovaya_BD1
{
    partial class ExamShow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BackToLoginButton2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(792, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // GroupComboBox1
            // 
            this.GroupComboBox1.FormattingEnabled = true;
            this.GroupComboBox1.Location = new System.Drawing.Point(12, 461);
            this.GroupComboBox1.Name = "GroupComboBox1";
            this.GroupComboBox1.Size = new System.Drawing.Size(92, 21);
            this.GroupComboBox1.TabIndex = 2;
            this.GroupComboBox1.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Группа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ссылки с информацией по экзаменам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackToLoginButton2
            // 
            this.BackToLoginButton2.Location = new System.Drawing.Point(659, 449);
            this.BackToLoginButton2.Name = "BackToLoginButton2";
            this.BackToLoginButton2.Size = new System.Drawing.Size(143, 39);
            this.BackToLoginButton2.TabIndex = 5;
            this.BackToLoginButton2.Text = "Вернуться на экран входа";
            this.BackToLoginButton2.UseVisualStyleBackColor = true;
            this.BackToLoginButton2.Click += new System.EventHandler(this.BackToLoginButton2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Оценки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExamShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BackToLoginButton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupComboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExamShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экзамены";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.ExamViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox GroupComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackToLoginButton2;
        private System.Windows.Forms.Button button2;
    }
}