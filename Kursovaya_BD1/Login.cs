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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya_BD1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            var loginUser = loginbox.Text;
            var passUser = passbox.Text;

            DB db = new DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            DataTable table = new DataTable();

            MySqlCommand query = new MySqlCommand ($"SELECT login, pass FROM students WHERE login = '{loginUser}' and pass = '{passUser}'", db.getConnection());

            adapter.SelectCommand = query;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вход выполнен!");
                this.Hide();
                ExamShow ExamShowForm = new ExamShow();
                ExamShowForm.Show();
            }
            else
            {
                MessageBox.Show("Неправильно введен логин или пароль!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginbox.Text = "";
                passbox.Text = "";
            }          
        }

        private void registred_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registed registedForm = new Registed();
            registedForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminFormButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin AdminLoginForm = new AdminLogin();
            AdminLoginForm.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
