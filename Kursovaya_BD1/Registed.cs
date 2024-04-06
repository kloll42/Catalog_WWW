using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class Registed : Form
    {
        public Registed()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            var newFirstName = newFirstNameBox.Text;
            var newSecondName = newSecondNameBox.Text;
            var name = newFirstName + " " + newSecondName;
            var newLogin = newLoginBox.Text;
            var newPass = newPassBox.Text;

            if (checkuser())
            {
                return;
            }

            DB db = new DB();

            List<int> Grupid = db.SelectID(
            "SELECT DISTINCT `ID_group` FROM `group_stud`");

            var Group = Grupid[comboBox1.SelectedIndex];

            MySqlCommand registred = new MySqlCommand($"INSERT INTO `students` (`Name`, `login`, `pass`, `ID_group`) VALUES ('{name}', '{newLogin}', '{newPass}', '{Group}'", db.getConnection());
           
            if (registred.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Success");
                this.Close();                
                Login loginForm = new Login();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }


        }
        private Boolean checkuser()
        {
            var login = newLoginBox.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlCommand checkReg = new MySqlCommand($"SELECT login FROM kursovaya.students where login = '{login}'", db.getConnection());

            adapter.SelectCommand = checkReg;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (table.Rows.Count == 0 && (newFirstNameBox.Text.Equals("")) || (newSecondNameBox.Text.Equals("")) || (comboBox1.Text.Equals("")) || (newLoginBox.Text.Equals("")) || (newPassBox.Text.Equals("")))
            {
                MessageBox.Show("Вы не ввели все необходимые данные!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Registed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void Registed_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            List<string> Grup = db.Select(
            "SELECT DISTINCT `number` FROM `group_stud`");
            comboBox1.Items.AddRange(Grup.ToArray());
        }
    }
}
