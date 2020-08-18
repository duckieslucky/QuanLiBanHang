using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Resources.CustomComponent
{
    public partial class SettingForm : Form
    {
        public Dashboard_GUI parent;

        public SettingForm()
        {
            InitializeComponent();
        }

        private void btnMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMenu.Checked)
            {

            }
        }

        private void btnDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDarkMode.Checked)
            {

            }
        }

        private void btnMaxScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMaxScreen.Checked)
            {
                parent.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnSignOut_Bar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
