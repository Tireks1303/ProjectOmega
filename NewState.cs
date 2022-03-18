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
    public partial class NewState : Form
    {
        DataBase db = new DataBase();
        public NewState()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NewState_Load(object sender, EventArgs e)
        {

        }


        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            db.openConnection();

            var fullname = nameField.Text;
            var seriaNum = numField.Text;
            var bdate = bField.Text;
            var citizenship = cField.Text;
            var gaveout = gField.Text;
            var gdate = dField.Text;
            int code;

            if (fullname != "" && seriaNum != "" && bdate != "" && citizenship != "" && gaveout != "" && gdate != "" && codeField.Text != "")
            {
                if (int.TryParse(codeField.Text, out code))
                {
                    var query = $"INSERT INTO data_students (fullname, serianum, bdate, citizenship, gaveout, gdate, code) " +
                        $"VALUES ('{fullname}', '{seriaNum}', '{bdate}', '{citizenship}', '{gaveout}', '{gdate}', '{code}')";

                    var cmd = new SqlCommand(query, db.GetConnection());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Успешно! Новая запись добавлена.");
                    this.Close();
                    MainFrame mainFrame = new MainFrame();
                    mainFrame.Show();
                }
                else
                {
                    MessageBox.Show("Ошибка! Проверьте корректность введенных данных.");
                }

                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainFrame mainFrame = new MainFrame();
            mainFrame.Show();
        }
    }
}
