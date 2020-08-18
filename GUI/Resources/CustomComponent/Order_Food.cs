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
    public partial class Order_Food : Form
    {
        public Order_Food()
        {
            InitializeComponent();
        }

        private void Order_Food_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel2, gunaVScrollBar1, true);

            gunaLabel_date.Text = DateTime.Now.ToLongDateString();
        }
    }
}
