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
    public partial class PointEnd : Form
    {
        PointEndContext db;
        public PointEnd()
        {
            InitializeComponent();
            db = new PointEndContext();
            db.PointEnd1.Load();

            dataGridView1.DataSource = db.PointEnd1.Local.ToBindingList();
        }

        private void PointEnd_Load_1(object sender, EventArgs e)
        {
            /*
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автобусные_маршрутыDataSet9.Пункт_назначения". При необходимости она может быть перемещена или удалена.
            this.пункт_назначенияTableAdapter1.Fill(this.автобусные_маршрутыDataSet9.Пункт_назначения);

            var command = new System.Data.SqlClient.SqlCommand("DELETE FROM Пункт_назначения WHERE Код_пункта = @Код_пункта", пункт_назначенияTableAdapter1.Connection);
            var parameter = command.Parameters.Add("@Код_пункта", SqlDbType.Int, 5, "Код_пункта");
            parameter.SourceVersion = DataRowVersion.Original;
            пункт_назначенияTableAdapter1.Adapter.DeleteCommand = command;
            */
        }



        public void button1_Click(object sender, EventArgs e)
        {
            //пункт_назначенияTableAdapter1.Update(автобусные_маршрутыDataSet9);
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
            SearchPointEnd dlg = new SearchPointEnd();
            dlg.Show(this);
        }

       
    }
}