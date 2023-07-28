using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearning.WinApp.MathOperations
{
    public partial class frmSubtract : Form
    {
        public frmSubtract()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Int32.Parse(txtFirstNumber.Text);
            b = Int32.Parse(txtSecondNumber.Text);
            c = a - b;
            txtOutput.Text = c.ToString();
        }
    }
}
