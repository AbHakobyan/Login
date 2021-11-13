using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        DataAccess dao;

        public Form1()
        {
            InitializeComponent();
            dao = new DataAccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SplashForm splashForm = new SplashForm();
            splashForm.Close();
        }

        private void buttonRegistrSubmit_Click(object sender, EventArgs e)
        {
            if (textRegistrPassword.Text != textRegistrConfirmPassword.Text)
            {
                MessageBox.Show("Password not mutch");
                return;
            }
            if (!dao.SignUp(textRegistrEmail.Text,textRegistrPassword.Text))
            {
                MessageBox.Show("Registr faild");
                return;
            }

            VerifyTokenForm form = new VerifyTokenForm();
            form.Email = textRegistrEmail.Text;
            form.Pw = textRegistrPassword.Text;
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Verifaed done");
            }
            else
            {
                MessageBox.Show("Incorect");
            }
        }

        private void buttonLoginSubmit_Click(object sender, EventArgs e)
        {
            LoginStatus loginStatus = dao.ChekLogin(textLoginEmail.Text,textLoginPassword.Text);
            if (loginStatus == LoginStatus.OK)
            {
                MessageBox.Show("You're loged");
                ProductForm productForm = new ProductForm();
                productForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Loged faild");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            SplashForm splashForm = new SplashForm();
            splashForm.Close();
            Application.Exit();
        }
    }
}
