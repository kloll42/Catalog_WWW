namespace Kursovaya_BD1
{
    partial class AdminLogin
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
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassAdminBox = new System.Windows.Forms.TextBox();
            this.LoginaAdminBox = new System.Windows.Forms.TextBox();
            this.EnterAdminButton = new System.Windows.Forms.Button();
            this.BackToLigonButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(72, 187);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 37);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин";
            // 
            // PassAdminBox
            // 
            this.PassAdminBox.Location = new System.Drawing.Point(46, 105);
            this.PassAdminBox.Name = "PassAdminBox";
            this.PassAdminBox.Size = new System.Drawing.Size(149, 20);
            this.PassAdminBox.TabIndex = 9;
            this.PassAdminBox.UseSystemPasswordChar = true;
            // 
            // LoginaAdminBox
            // 
            this.LoginaAdminBox.Location = new System.Drawing.Point(46, 45);
            this.LoginaAdminBox.Name = "LoginaAdminBox";
            this.LoginaAdminBox.Size = new System.Drawing.Size(149, 20);
            this.LoginaAdminBox.TabIndex = 8;
            // 
            // EnterAdminButton
            // 
            this.EnterAdminButton.Location = new System.Drawing.Point(12, 142);
            this.EnterAdminButton.Name = "EnterAdminButton";
            this.EnterAdminButton.Size = new System.Drawing.Size(113, 37);
            this.EnterAdminButton.TabIndex = 7;
            this.EnterAdminButton.Text = "Войти";
            this.EnterAdminButton.UseVisualStyleBackColor = true;
            this.EnterAdminButton.Click += new System.EventHandler(this.EnterAdminButton_Click);
            // 
            // BackToLigonButton1
            // 
            this.BackToLigonButton1.Location = new System.Drawing.Point(134, 142);
            this.BackToLigonButton1.Name = "BackToLigonButton1";
            this.BackToLigonButton1.Size = new System.Drawing.Size(108, 37);
            this.BackToLigonButton1.TabIndex = 13;
            this.BackToLigonButton1.Text = "Назад";
            this.BackToLigonButton1.UseVisualStyleBackColor = true;
            this.BackToLigonButton1.Click += new System.EventHandler(this.BackToLigonButton1_Click);
            // 
            // AdminLogin
            // 
            this.AcceptButton = this.EnterAdminButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 236);
            this.Controls.Add(this.BackToLigonButton1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassAdminBox);
            this.Controls.Add(this.LoginaAdminBox);
            this.Controls.Add(this.EnterAdminButton);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход для преподавателя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassAdminBox;
        private System.Windows.Forms.TextBox LoginaAdminBox;
        private System.Windows.Forms.Button EnterAdminButton;
        private System.Windows.Forms.Button BackToLigonButton1;
    }
}