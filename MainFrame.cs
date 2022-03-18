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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class MainFrame : Form
    {
        DataBase db = new DataBase();

        int selectedRow;

        string id_change;
        string fullname_change;
        string birthdate_change;
        string citizenship_change;
        string serianum_change;
        string givedate_change;
        string whogive_change;
        string code_change;

        public MainFrame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView);
        }

        private void CreateColumns()
        {
            dataGridView.Columns.Add("id", "ID");
            dataGridView.Columns.Add("fullname", "ФИО");
            dataGridView.Columns.Add("serianum", "Серия Номер");
            dataGridView.Columns.Add("bdate", "Дата рождения");
            dataGridView.Columns.Add("citizenship", "Гражданство");
            dataGridView.Columns.Add("gaveout", "Кем выдано");
            dataGridView.Columns.Add("gdate", "Дата выдачи");
            dataGridView.Columns.Add("code", "Код подр.");
            dataGridView.Columns.Add("status", String.Empty);

            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewState newState = new NewState();
            newState.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView);
        }

        private void ReadSingleRow(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4),
                record.GetString(5),
                record.GetString(6),
                record.GetInt32(7),
                RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dataGrid)
        { 
            dataGridView.Rows.Clear();
            string query = $"SELECT * FROM data_students";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());

            db.openConnection();

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dataGrid, reader);
            }
            reader.Close();
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        public void DeleteRow()
        {
            int index = dataGridView.CurrentCell.RowIndex;

            //dataGridView.Rows[index].Visible = false;

            if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }

            dataGridView.Rows[index].Cells[8].Value = RowState.Deleted;

            Update();
            RefreshDataGrid(dataGridView);
        }

        private void Update()
        {

            db.openConnection();

            for (int index = 0; index < dataGridView.Rows.Count; index++)
            {
                try
                {
                    var rowState = (RowState)dataGridView.Rows[index].Cells[8].Value;

                    if (rowState == RowState.Existed) continue;

                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);

                        var deleteQuery = $"DELETE FROM data_students WHERE id = '{id}'";

                        var command = new SqlCommand(deleteQuery, db.GetConnection());
                        command.ExecuteNonQuery();
                        Console.WriteLine("Удаление выполнено");
                    }
                }
                catch (Exception e)
                {
                    continue;
                }
                

            }

            db.closeConnection(); 
            }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeFrame changeFrame = new ChangeFrame();

            changeFrame.id_change = id_change;
            changeFrame.fullname_change = fullname_change;
            changeFrame.birthdate_change = birthdate_change;
            changeFrame.citizenship_change = citizenship_change;
            changeFrame.serianum_change = serianum_change;
            changeFrame.givedate_change = givedate_change;
            changeFrame.whogive_change = whogive_change;
            changeFrame.code_change = code_change;

            if (id_change != null && fullname_change != null && birthdate_change != null && citizenship_change != null && serianum_change != null && givedate_change != null
                && whogive_change != null && code_change != null)
            {
                this.Hide();
                changeFrame.Show();
            }
            else
            {
                MessageBox.Show("Выберите запись для изменения!");
            }

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[selectedRow];

                id_change = row.Cells[0].Value.ToString();
                fullname_change = row.Cells[1].Value.ToString();
                birthdate_change = row.Cells[2].Value.ToString();
                citizenship_change = row.Cells[3].Value.ToString();
                serianum_change = row.Cells[4].Value.ToString();
                givedate_change = row.Cells[5].Value.ToString();
                whogive_change = row.Cells[6].Value.ToString();
                code_change = row.Cells[7].Value.ToString();


            }
        }
    }
}
