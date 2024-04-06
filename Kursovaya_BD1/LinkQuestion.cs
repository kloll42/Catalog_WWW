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
    public partial class LinkQuestion : Form
    {
        public LinkQuestion()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LinkQuestionForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            CreateColumns();

            List<string> Exam = db.Select(
            "SELECT DISTINCT `Name` FROM `exam_topics` ORDER BY `Name`");
            ExamComboBox1.Items.AddRange(Exam.ToArray());
            this.ExamComboBox1.SelectedIndexChanged += new EventHandler(ExamComboBox1_SelectedIndexChanged);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void LinkQuestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Exam", "Экзамен");
            dataGridView1.Columns.Add("Quest", "Вопрос");
            dataGridView1.Columns.Add("Link", "Ссылка");

        }

        private void ExamComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Exam = (string)ExamComboBox1.SelectedItem;
            LoadData(dataGridView1, Exam);
        }

        private void LoadData(DataGridView read, string Exam)
        {
            dataGridView1.Rows.Clear();
            DB db = new DB();
            MySqlCommand query = new MySqlCommand
                (
                "SELECT DISTINCT `exam_topics`.`Name`, `contents`.`Name`, `contents`.`Link`" +
                "FROM `exam_topics` " +
                "INNER JOIN `contents` ON `exam_topics`.`ID_Topics` = `contents`.`ID_Topic` " +
                $"WHERE `exam_topics`.`Name` = '{Exam}'", db.getConnection()
                );

            db.openConnection();
            DbDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(read, reader);
            }

            reader.Close();
        }

        private void ReadSingleRow(DataGridView read, IDataRecord record)
        {
            read.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamShow ExamShowForm = new ExamShow();
            ExamShowForm.Show();
        }
    }
}
