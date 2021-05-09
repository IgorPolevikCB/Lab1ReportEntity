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
    public partial class DaysTrip : Form
    {
        DaysTripContext db;
        public DaysTrip()
        {
            InitializeComponent();

            db = new DaysTripContext();
            db.DaysTrip1.Load();

            dataGridView1.DataSource = db.DaysTrip1.Local.ToBindingList();
        }

        private void PointEnd_Load_1(object sender, EventArgs e)
        {
            /*
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автобусные_маршрутыDataSet10.Дни_движения". При необходимости она может быть перемещена или удалена.
            this.дни_движенияTableAdapter.Fill(this.автобусные_маршрутыDataSet10.Дни_движения);
            

            var command = new System.Data.SqlClient.SqlCommand("DELETE FROM Дни_движения WHERE Код_дня = @Код_дня", дни_движенияTableAdapter.Connection);
            var parameter = command.Parameters.Add("@Код_дня", SqlDbType.Int, 5, "Код_дня");
            parameter.SourceVersion = DataRowVersion.Original;
            дни_движенияTableAdapter.Adapter.DeleteCommand = command;
            */
        }



        public void button1_Click(object sender, EventArgs e)
        {
            //дни_движенияTableAdapter.Update(автобусные_маршрутыDataSet10);
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
            SearchDaysTrip dlg = new SearchDaysTrip();
            dlg.Show(this);
        }


    }
}