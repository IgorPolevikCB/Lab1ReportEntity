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
    public partial class PromPoints : Form
    {
        PromPointsContext db;
        public PromPoints()
        {
            InitializeComponent();

            db = new PromPointsContext();
            db.PromPoints1.Load();

            dataGridView1.DataSource = db.PromPoints1.Local.ToBindingList();
        }

        private void PromPoints_Load_1(object sender, EventArgs e)
        {
            /*
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автобусные_маршрутыDataSet7.Промежуточные_пункты". При необходимости она может быть перемещена или удалена.
            this.промежуточные_пунктыTableAdapter.Fill(this.автобусные_маршрутыDataSet7.Промежуточные_пункты);

            var command = new System.Data.SqlClient.SqlCommand("DELETE FROM промежуточные_пункты WHERE Код_пункта = @Код_пункта", промежуточные_пунктыTableAdapter.Connection);
            var parameter = command.Parameters.Add("@Код_пункта", SqlDbType.Int, 5, "Код_пункта");
            parameter.SourceVersion = DataRowVersion.Original;
            промежуточные_пунктыTableAdapter.Adapter.DeleteCommand = command;
            */
        }



        public void button1_Click(object sender, EventArgs e)
        {
            //промежуточные_пунктыTableAdapter.Update(автобусные_маршрутыDataSet7);
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
            SearchPromPoints dlg = new SearchPromPoints();
            dlg.Show(this);
        }

       
    }
}