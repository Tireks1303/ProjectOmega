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
    public partial class ChangeFrame : Form
    {
        public string id_change;
        public string fullname_change;
        public string birthdate_change;
        public string citizenship_change;
        public string serianum_change;
        public string givedate_change;
        public string whogive_change;
        public string code_change;


        DataBase db = new DataBase();
        public ChangeFrame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ChangeFrame_Load(object sender, EventArgs e)
        {
            nameField.Text = fullname_change;
            bField.Text = birthdate_change;
            cField.Text = citizenship_change;
            numField.Text = serianum_change;
            dField.Text = givedate_change;
            gField.Text = whogive_change;
            codeField.Text = code_change;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainFrame mainFrame = new MainFrame();
            mainFrame.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            db.openConnection();

            var fullname = nameField.Text;
            var birthdate = bField.Text;
            var citizenship = cField.Text;
            var serianum = numField.Text;
            var givedate = dField.Text;
            var whogive = gField.Text;
            int code;

            if (fullname != null && birthdate != null && citizenship != null && serianum != null && givedate != null
                && whogive != null && cField.Text != null)
            {
                if (int.TryParse(codeField.Text, out code))
                {
                    var query = $"INSERT INTO data_students (fullname, serianum, bdate, citizenship, gaveout, gdate, code) " +
                        $"VALUES ('{fullname}', '{serianum}', '{birthdate}', '{citizenship}', '{whogive}', '{givedate}', '{code}')";

                    var cmd = new SqlCommand(query, db.GetConnection());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Изменения сохранены!");
                    this.Hide();
                    MainFrame mainFrame = new MainFrame();
                    mainFrame.Show();
                }
                else
                {
                    MessageBox.Show("Ошибка сохранения изменений! Проверьте корректность ввода.");
                }
                db.closeConnection();
            }
            else 
            {
                MessageBox.Show("Необходимо заполнить все поля!");
            }

            


        }
    }
}
