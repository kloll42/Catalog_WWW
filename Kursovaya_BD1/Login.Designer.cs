namespace Kursovaya_BD1
{
    partial class Login
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
            this.enterButton = new System.Windows.Forms.Button();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registredButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.AdminFormButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(12, 177);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(113, 37);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // loginbox
            // 
            this.loginbox.Location = new System.Drawing.Point(51, 51);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(149, 20);
            this.loginbox.TabIndex = 1;
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(51, 111);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(149, 20);
            this.passbox.TabIndex = 2;
            this.passbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // registredButton
            // 
            this.registredButton.Location = new System.Drawing.Point(142, 177);
            this.registredButton.Name = "registredButton";
            this.registredButton.Size = new System.Drawing.Size(108, 37);
            this.registredButton.TabIndex = 5;
            this.registredButton.Text = "Регистрация";
            this.registredButton.UseVisualStyleBackColor = true;
            this.registredButton.Click += new System.EventHandler(this.registred_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(142, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 37);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AdminFormButton1
            // 
            this.AdminFormButton1.Location = new System.Drawing.Point(12, 226);
            this.AdminFormButton1.Name = "AdminFormButton1";
            this.AdminFormButton1.Size = new System.Drawing.Size(113, 37);
            this.AdminFormButton1.TabIndex = 7;
            this.AdminFormButton1.Text = "Вход для преподавателя";
            this.AdminFormButton1.UseVisualStyleBackColor = true;
            this.AdminFormButton1.Click += new System.EventHandler(this.AdminFormButton1_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 275);
            this.Controls.Add(this.AdminFormButton1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registredButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.enterButton);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registredButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button AdminFormButton1;
    }
}

