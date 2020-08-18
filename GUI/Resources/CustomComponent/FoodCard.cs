using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI.Resources.CustomComponent
{
    public partial class FoodCard : UserControl
    {
        public event EventHandler AddCart;

        public FoodCard()
        {
            InitializeComponent();
        }

        public FoodCard(SanPham_DTO sp)
        {
            InitializeComponent();
            this.Tag = sp;
            lblDongia.Text = Helper_GUI.ConvertToVNmoney(sp.Giaban) + " VNĐ";
            lblTen.Text = sp.Ten;
            lblSoluong.Text = sp.Soluong.ToString();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (AddCart != null) //making sure someone is listening for the event
            {
                AddCart(this, null);
            }
        }
    }
}
