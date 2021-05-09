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
    public partial class Buses : Form
    {
        BusesContext db;
        public Buses()
        {
            InitializeComponent();

            db = new BusesContext();
            db.Buses1.Load();

            dataGridView1.DataSource = db.Buses1.Local.ToBindingList();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            /*
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автобусные_маршрутыDataSet4.Автобусы". При необходимости она может быть перемещена или удалена.
            this.автобусыTableAdapter.Fill(this.автобусные_маршрутыDataSet4.Автобусы);
           
            var command = new System.Data.SqlClient.SqlCommand("DELETE FROM Автобусы WHERE Код_автобуса = @Код_автобуса", автобусыTableAdapter.Connection);
            var parameter = command.Parameters.Add("@Код_автобуса", SqlDbType.Int, 5, "Код_автобуса");
            parameter.SourceVersion = DataRowVersion.Original;
            автобусыTableAdapter.Adapter.DeleteCommand = command;
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
            Search dlg = new Search();
            dlg.Show(this);
        }
    }
    }

