using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_BD1
{
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Student", "Студент");
            dataGridView1.Columns.Add("Exam", "Экзамен");
            dataGridView1.Columns.Add("Grade", "Оценка");
            dataGridView1.Columns.Add("Date", "Дата");
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            DB dB = new DB();
            CreateColumns();

            List<string> Group = dB.Select(
            "SELECT DISTINCT `number` FROM `group_stud` ORDER BY `number`");
            comboBox1.Items.AddRange(Group.ToArray());
            this.comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

            List<string> Stud = dB.Select(
           "SELECT DISTINCT `Name` FROM `students` ORDER BY `Name`");
            comboBox2.Items.AddRange(Stud.ToArray());
            this.comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ReadSingleRow(DataGridView read, IDataRecord record)
        {
            read.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2), record.GetDateTime(3));
        }

        private void LoadData(DataGridView read)
        {
            var Stud = comboBox2.SelectedItem;

            dataGridView1.Rows.Clear();

            DB db = new DB();
            MySqlCommand query = new MySqlCommand
                ("SELECT DISTINCT students.Name, exam_topics.Name, Grade, Date " +
                "FROM grades " +
                "INNER JOIN exams ON grades.ID_Exams = exams.ID_Exams " +
                "INNER JOIN exam_topics ON exams.ID_Topics = exam_topics.ID_Topics " +
                "INNER JOIN students ON grades.ID_Students = students.ID_Student " +
                $"WHERE students.Name = '{Stud}' ", db.getConnection());

            db.openConnection();
            DbDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(read, reader);
            }

            reader.Close();
        }

        private void Grades_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB dB = new DB();
            List<int> ID_Group = dB.SelectID(
            "SELECT DISTINCT `ID_group` FROM `group_stud`");

            var Group = ID_Group[comboBox1.SelectedIndex];

            comboBox2.Items.Clear();
            comboBox2.ResetText();
            List<string> Stud = dB.Select(
           "SELECT DISTINCT `Name` FROM `students` " +
           $"WHERE ID_group = '{Group}' ");
            comboBox2.Items.AddRange(Stud.ToArray());
            this.comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamShow examShowForm = new ExamShow();
            examShowForm.Show();
        }
    }
}
