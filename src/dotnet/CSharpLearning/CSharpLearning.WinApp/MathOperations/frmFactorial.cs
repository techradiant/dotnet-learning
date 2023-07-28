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
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, i, fact = 1;
            a= Int32.Parse(txtInput.Text);
            fact = 1;
            for(i = a; i > 0; i--)
            {
                fact *= i;
            }

            txtOutput.Text = fact.ToString();

        }
    }
}
