using CSharpLearning.WinApp.MathOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearning.WinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddition frmAddition = new frmAddition();
            frmAddition.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMultiply frmMultiply = new frmMultiply();
            frmMultiply.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Subtract frmSubtract = new Subtract();  
            frmSubtract.ShowDialog();
        }
    }
}
