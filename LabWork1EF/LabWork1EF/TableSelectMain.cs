using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork1EF
{
    public partial class TableSelectMain : Form
    {
        public TableSelectMain()
        {
            InitializeComponent();
        }
        //==============================Buttons-color==============================
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Lime;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Lime;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Lime;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }
        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Lime;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Transparent;
        }
        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Lime;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Transparent;
        }
        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
        }
        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Transparent;
        }
        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.Yellow;
        }
        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Transparent;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DBDiagram dlg = new DBDiagram();
            dlg.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Buses dlg = new Buses();
            dlg.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Routes dlg = new Routes();
            dlg.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Roads dlg = new Roads();
            dlg.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PromPoints dlg = new PromPoints();
            dlg.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PointEnd dlg = new PointEnd();
            dlg.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DaysTrip dlg = new DaysTrip();
            dlg.Show(this);
        }
    }
}
