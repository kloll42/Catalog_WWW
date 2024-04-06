using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya_BD1
{
    public partial class ExamShow : Form
    {
        public ExamShow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Date", "Дата"); 
            dataGridView1.Columns.Add("Exam", "Экзамен"); 
            dataGridView1.Columns.Add("Group", "Номер группы"); 
            dataGridView1.Columns.Add("Course", "Курс"); 
            dataGridView1.Columns.Add("Teacher", "Преподаватель"); 

        }

        private void ReadSingleRow(DataGridView read, IDataRecord record)
        {
            read.Rows.Add(record.GetDateTime(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetString(4));
        }

        private void LoadData(DataGridView read, string Group)
        {
            dataGridView1.Rows.Clear();
            DB db = new DB();
            MySqlCommand query = new MySqlCommand
                ("SELECT DISTINCT Date, exam_topics.Name, grup_curs.grup, grup_curs.curs, teachers.Name " +
                "FROM exams " +
                "INNER JOIN exam_topics ON exams.ID_Topics = exam_topics.ID_Topics " +
                "INNER JOIN teachers ON exams.ID_Teacher = teachers.ID_Teacher " +
                "INNER JOIN ( SELECT group_stud.number as grup, courses.Name as curs, group_stud.ID_group as id " +
                "FROM group_stud " +
                "INNER JOIN courses ON group_stud.ID_Course = courses.ID_Courses) as grup_curs ON exams.ID_group = id " +                
                $"WHERE grup_curs.grup = '{Group}'", db.getConnection());

            db.openConnection();
            DbDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(read, reader);
            }

            reader.Close();
        }

        private void ExamViewForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            CreateColumns();

            List<string> Group = db.Select(
            "SELECT DISTINCT `number` FROM `group_stud` ORDER BY `number`");
            GroupComboBox1.Items.AddRange(Group.ToArray());
            this.GroupComboBox1.SelectedIndexChanged += new EventHandler(GroupComboBox1_SelectedIndexChanged);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GroupComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Group = (string)GroupComboBox1.SelectedItem;
            LoadData(dataGridView1, Group);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LinkQuestion LinkQuestionForm = new LinkQuestion();
            LinkQuestionForm.Show();
        }

        private void BackToLoginButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grades gradesForm = new Grades();
            gradesForm.Show();
        }
    }
}
