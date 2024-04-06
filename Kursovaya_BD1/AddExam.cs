using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya_BD1
{
    public partial class AddExam : Form
    {
        public AddExam()
        {
            InitializeComponent();
        }

        private void AddExam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddExam_Load(object sender, EventArgs e)
        {
            DB dB = new DB();

            List<string> Exam = dB.Select(
            "SELECT DISTINCT `Name` FROM `exam_topics`");
            ExamComboBox1.Items.AddRange(Exam.ToArray());

            List<string> Group = dB.Select(
            "SELECT DISTINCT `number` FROM `group_stud`");
            GroupComboBox2.Items.AddRange(Group.ToArray());

            List<string> Teach = dB.Select(
            "SELECT DISTINCT `Name` FROM `teachers`");
            TeachComboBox4.Items.AddRange(Teach.ToArray());
        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            DB dB = new DB();

            if ((ExamComboBox1.Text.Equals("")) || (GroupComboBox2.Text.Equals("")) || (TeachComboBox4.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<int> ExamID = dB.SelectID(
                    "SELECT DISTINCT `ID_Topics` FROM `exam_topics`");

                List<int> GroupID = dB.SelectID(
                "SELECT DISTINCT `ID_group` FROM `group_stud`");

                List<int> TeachID = dB.SelectID(
                "SELECT DISTINCT `ID_Teacher` FROM `teachers`");

                var date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                var exam = ExamID[ExamComboBox1.SelectedIndex];
                var group = GroupID[GroupComboBox2.SelectedIndex];
                var teach = TeachID[TeachComboBox4.SelectedIndex];

                    MySqlCommand cmd = new MySqlCommand($"INSERT INTO exams(Date, ID_Teacher, ID_Topics, ID_group) VALUES('{date}', '{teach}', '{exam}', '{group}') ", dB.getConnection());

                    dB.openConnection();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные внесены!", "Success");

                    }
                    else
                    {
                        MessageBox.Show("Ошибка, данные не внесены!");
                    }
            }
        }

        private void CancelButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamEdit examEditForm = new ExamEdit();
            examEditForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
