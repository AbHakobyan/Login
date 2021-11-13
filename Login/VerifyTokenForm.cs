using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class VerifyTokenForm : Form
    {
        public string Email { get; set; }
        public string Pw { get; set; }
        public VerifyTokenForm()
        {
            InitializeComponent();
        }

        private void buttonVerifyDone_Click(object sender, EventArgs e)
        {
            if (new DataAccess().VerifyCode(Email,Pw,textTokenDone.Text))
            {
                DialogResult = DialogResult.OK;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
