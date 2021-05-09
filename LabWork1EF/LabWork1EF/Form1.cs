using System;
using System.Windows.Forms;

namespace LabWork1EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String l = "Admin";
            String p = "Admin";
            
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                TableSelectMain dlg = new TableSelectMain();
                dlg.Show(this);
            }
            else
            {
                MessageBox.Show(
                "Your data is entered incorrectly",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
