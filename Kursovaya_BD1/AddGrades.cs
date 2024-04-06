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
    public partial class AddGrades : Form
    {
        public AddGrades()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GradesAdmin gradesAdminForm = new GradesAdmin();
            gradesAdminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB dB = new DB();

            List<int> StudID = dB.SelectID(
            $"SELECT DISTINCT `ID_Student` FROM `students` WHERE Name = '{StudComboBox1.Text}'");

            List<int> ExamID = dB.SelectID(
            $"SELECT DISTINCT `ID_Exams` FROM `exams` WHERE Date = '{DateComboBox4.Text}'");

            var newstud = StudID[0];
            var newexam = ExamID[0];
            var newgrade = GradeComboBox3.Text;

            if (GroupComboBox5.Text.Equals("") || StudComboBox1.Text.Equals("") || ExamComboBox2.Text.Equals("") || DateComboBox4.Text.Equals("") || GradeComboBox3.Text.Equals(""))
                MessageBox.Show("Вы не выбрали данные!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO grades (ID_Students, ID_Exams, Grade) VALUES('{newstud}', '{newexam}', '{newgrade}') ", dB.getConnection());

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

        private void AddGrades_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddGrades_Load(object sender, EventArgs e)
        {
            DB dB = new DB();

            List<string> Grup = dB.Select(
            "SELECT DISTINCT `number` FROM `group_stud`");
            GroupComboBox5.Items.AddRange(Grup.ToArray());

            List<string> Stud = dB.Select(
            "SELECT DISTINCT `Name` FROM `students` ");
            StudComboBox1.Items.AddRange(Stud.ToArray());

            List<string> Exam = dB.Select(
            "SELECT DISTINCT `Name` FROM `exam_topics`");
            ExamComboBox2.Items.AddRange(Exam.ToArray());
            
            GradeComboBox3.Items.AddRange(new object[] {3,4,5});

        }

        private void GroupComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudComboBox1.Items.Clear();

            DB dB = new DB();

            List<int> ID_Group = dB.SelectID(
            "SELECT DISTINCT `ID_group` FROM `group_stud`");

            var Group = ID_Group[GroupComboBox5.SelectedIndex];

            StudComboBox1.Items.Clear();
            StudComboBox1.ResetText();
            List<string> Stud = dB.Select(
            "SELECT DISTINCT `Name` FROM `students` " +
            $"WHERE ID_group = '{Group}' ");
            StudComboBox1.Items.AddRange(Stud.ToArray());
        }

        private void ExamComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateComboBox4.Items.Clear();

            DB dB = new DB();

            List<int> ID_Topic = dB.SelectID(
            "SELECT DISTINCT `ID_Topics` FROM `exam_topics`");

            var Topic = ID_Topic[ExamComboBox2.SelectedIndex];

            DateComboBox4.Items.Clear();
            DateComboBox4.ResetText();
            List<string> Date = dB.SelectDate(
                "SELECT DISTINCT `Date` FROM `exams` " +
                $"WHERE ID_Topics = '{Topic}' ");
                DateComboBox4.Items.AddRange(Date.ToArray());
        }

    }
}
