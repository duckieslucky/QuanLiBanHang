using BUL;
using DTO;
using GUI.Admin;
using GUI.Resources.CustomComponent;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Users
{
    public partial class Login_GUI : Form
    {
        public Login_GUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (NhanVienBUL.Instance.Login(tbxUsername.Text, tbxPassword.Text))
            {
                //save id
                Properties.Settings.Default["previousUsername"] = tbxUsername.Text;
                Properties.Settings.Default.Save();
                //
                this.Hide();
                Dashboard_GUI f = new Dashboard_GUI();
                f.ShowDialog();
                this.Show();
                ResetForm();
                
            }
            else
            {
                MessageBox.Show("Sai thông tin");
                tbxPassword.ResetText();
                tbxPassword.Focus();
            }
        }

        private void ResetForm()
        {
            tbxUsername.Text = Properties.Settings.Default["previousUsername"].ToString();
            tbxPassword.ResetText();

            tbxUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
