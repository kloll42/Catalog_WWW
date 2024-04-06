using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class Link : Form
    {
        public int InboxData;

        public Link()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            int id = InboxData;

            string link = textBox1.Text;

            if (textBox1.Text.Equals(""))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MySqlCommand query = new MySqlCommand($"UPDATE contents SET `Link` = '{link}' WHERE ID_Contents = '{id}'", db.getConnection());

                db.openConnection();

                query.ExecuteNonQuery();

                this.Close();
            }
        }

        private void Link_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
