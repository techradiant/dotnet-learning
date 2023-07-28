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

namespace UserLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection conect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lenovo\\OneDrive\\Documents\\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter adpt = new SqlDataAdapter("Select Count (*) From [Table] where USERNAME = '" + textBox1.Text +"' and PASSWORD = '" + textBox2.Text +"'",conect );
            DataTable dat = new DataTable();
            adpt.Fill(dat); ;

            if (dat.Rows[0][0].ToString() == "1") 
            {
                this.Hide();

                Main secondScreen = new Main();
                secondScreen.Show();
            }
            else
            {
                MessageBox.Show("Please Check User Name and Password");
            }
        }
    }
}
