using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using LabWork1EF.Controller;
//using PolevikDatabaseADOMDK.Models;

namespace LabWork1EF
{
    public partial class Routes : Form
    {

        RoutesContext db;

        public Routes()
        {

            InitializeComponent();
            //DBConnection.Conncet();
            db = new RoutesContext();
            db.Routes1.Load();

            dataGridView1.DataSource = db.Routes1.Local.ToBindingList();
           
        }

        
        public void Routes_Load(object sender, EventArgs e)
        {

            /* OLD METHOD
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автобусные_маршрутыDataSet5.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.автобусные_маршрутыDataSet5.Маршруты);
    
            var command = new System.Data.SqlClient.SqlCommand("DELETE FROM Маршруты WHERE Код_маршрута = @Код_маршрута", маршрутыTableAdapter.Connection);
            var parameter = command.Parameters.Add("@Код_маршрута", SqlDbType.Int, 5, "Код_маршрута");
            parameter.SourceVersion = DataRowVersion.Original;
            маршрутыTableAdapter.Adapter.DeleteCommand = command;
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
            SearchRoutes dlg = new SearchRoutes();
            dlg.Show(this);
        }
    }
}

