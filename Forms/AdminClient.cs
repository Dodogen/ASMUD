using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ASMUD.Forms
{
    public partial class AdminClient : Form
    {
        public AdminClient()
        {
            InitializeComponent();
        }

        private void AdminClient_Load(object sender, EventArgs e)
        {
            textBox_Description.Text = "Панель администратора";
            textBox_DateToday.Text = DateTime.Today.ToShortDateString();
            ShowSQLTableByQuery(SQLQueries.GET_CLERKS);
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

        private void button_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Выполнил ст. гр. 10702221 Барковец Р.",
                "Помощь",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
