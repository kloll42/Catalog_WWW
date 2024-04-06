using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_BD1
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void EnterAdminButton_Click(object sender, EventArgs e)
        {
            var loginAdmin = LoginaAdminBox.Text;
            var passAdmin = PassAdminBox.Text;

            DB db = new DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable table = new DataTable();

            MySqlCommand query = new MySqlCommand($"SELECT login_teach, pass_teach FROM teachers WHERE login_teach = '{loginAdmin}' and pass_teach = '{passAdmin}'", db.getConnection());

            adapter.SelectCommand = query;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вход выполнен");
                this.Hide();
                ExamEdit examEditForm = new ExamEdit();
                examEditForm.Show();
            }
            else
                MessageBox.Show("Неправильно введен логин или пароль");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackToLigonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
