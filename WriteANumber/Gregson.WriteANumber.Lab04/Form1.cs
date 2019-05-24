using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gregson.WriteANumber.Lab04
{
    public partial class frmNumbersToWords : Form
    {
        public frmNumbersToWords()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Convert convert = new Convert();

            txtOutput.Text = convert.thousands(txtInput.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void frmNumbersToWords_Load(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
