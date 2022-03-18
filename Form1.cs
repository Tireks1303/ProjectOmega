using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Abitur
{
    public partial class Form1 : Form
    {
        DataBase db = new DataBase();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pwdField.PasswordChar = '●';
            pwdField.MaxLength = 10;
            loginField.MaxLength = 50;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var loginUser = loginField.Text;
            var pwdUser = pwdField.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string query = $"SELECT id, user_login, user_pwd FROM sign_in WHERE user_login = '{loginUser}' AND user_pwd = '{pwdUser}'";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Вход выполнен успешно! Нажмите ОК, чтобы продолжить.");
                this.Hide();
                MainFrame mainFrame = new MainFrame();
                mainFrame.Show();
            }
            else
            {
                MessageBox.Show("Ошибка! Данный аккаунт не существует или некорректный ввод данных. Нажмите ОК и повторите попытку.");
            }
        }
    }
}
