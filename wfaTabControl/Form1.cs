using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaTabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.IndexOf("@") == -1)
                errorProvider1.SetError(txtEmail, "Email inválido!");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0)
                btnAdicionar.Enabled = true;
            else
            {
                btnAdicionar.Enabled = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }
    }
}
