using LabWork1EF.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LabWork1EF
{
    public partial class Roads : Form
    {
        RoadsContext db;
        public Roads()
        {
            InitializeComponent();
            db = new RoadsContext();
            db.Roads1.Load();

            dataGridView1.DataSource = db.Roads1.Local.ToBindingList();
        }



        private void Roads_Load(object sender, EventArgs e)
        {
            /*
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автобусные_маршрутыDataSet6.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter1.Fill(this.автобусные_маршрутыDataSet6.Рейсы);

            var command = new System.Data.SqlClient.SqlCommand("DELETE FROM Рейсы WHERE Код_рейса = @Код_рейса", рейсыTableAdapter1.Connection);
            var parameter = command.Parameters.Add("@Код_рейса", SqlDbType.Int, 5, "Код_рейса");
            parameter.SourceVersion = DataRowVersion.Original;
            рейсыTableAdapter1.Adapter.DeleteCommand = command;
            */
        }

        public void button1_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchRoads dlg = new SearchRoads();
            dlg.Show(this);
        }

       
    }
}

