using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ASMUD
{
    public partial class UserClient : Form
    {
        List<string> allSubjects = new List<string>()
        {
            "Физ-ра",
            "СУБД",
            "СИТАРИС",
            "МИАКГ",
            "Метрология",
            "ТПО",
            "Изображения",
            "РИПОД",
            "СЯП",
        };
        public UserClient()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox_DateToday.Text = DateTime.Today.ToShortDateString();
        }

        private void button_Schedule_Click(object sender, EventArgs e)
        {
            textBox_Description.Text = "Расписание актуально на " + textBox_DateToday.Text;
            dataGridView_Data.DataSource = null;

            dataGridView_Data.DataSource = CreateDayShedule(
                "Понедельник",
                "Вторник",
                "Среда",
                "Четверг",
                "Пятница",
                "Суббота");
        }

        private void button_Teachers_Click(object sender, EventArgs e)
        {
            textBox_Description.Text = "Текущие преподаватели кафедры";
            ShowSQLTableByQuery(SQLQueries.GET_TEACHERS);
        }

        private void button_Cabinets_Click(object sender, EventArgs e)
        {
            textBox_Description.Text = "Все доступные кабинеты на " + textBox_DateToday.Text;
            ShowSQLTableByQuery(SQLQueries.GET_CABINETS);
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Выполнил ст. гр. 10702221 Барковец Р.",
                "Помощь",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void checkBox_IsEditing_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbox = sender as CheckBox;
            if (cbox.Checked)
            {
                dataGridView_Data.Enabled = true;
            }
            else
            {
                dataGridView_Data.Enabled = false;
            }
        }

        private void ShowSQLTableByQuery(string query)
        {
            dataGridView_Data.DataSource = null;
            using (SqlConnection connection = DBConnector.CreateConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView_Data.DataSource = ds.Tables[0];
            }
        }

        private DataTable CreateDayShedule(params string[] names)
        {
            DataTable dt = new DataTable();

            for (int i = 0; i < names.Length; i++)
            {
                dt.Columns.Add(names[i], typeof(string));
            }

            Random r = new Random();
            for (int i = 0; i < names.Length; i++)
            {
                dt.Rows.Add(
                    allSubjects[r.Next(0, allSubjects.Count)],
                    allSubjects[r.Next(0, allSubjects.Count)],
                    allSubjects[r.Next(0, allSubjects.Count)],
                    allSubjects[r.Next(0, allSubjects.Count)],
                    allSubjects[r.Next(0, allSubjects.Count)],
                    allSubjects[r.Next(0, allSubjects.Count)]
                    );
            }
            dt.AcceptChanges();
            return dt;
        }
    }
}
