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
    public partial class FoodGridRow : UserControl
    {
        public event EventHandler RemoveItem;
        public event EventHandler QuantityChanged;

        public FoodGridRow()
        {
            InitializeComponent();
        }

        public FoodGridRow(CThoadon_DTO ct)
        {
            InitializeComponent();
            this.Tag = ct;
            lblName.Text = ct.TenSanPham;
            lblPrice.Text = Helper_GUI.ConvertToVNmoney(ct.Dongia);
            lblSum.Text = Helper_GUI.ConvertToVNmoney(ct.Thanhtien);
        }

        public void ResetValue()
        {
            NumQuantity.Value = (long)(this.Tag as CThoadon_DTO).Soluong;
        }

        private void NumQuantity_ValueChanged(object sender, EventArgs e)
        {

            CThoadon_DTO cur = this.Tag as CThoadon_DTO;
            cur.Soluong = (int)NumQuantity.Value;
            lblSum.Text = Helper_GUI.ConvertToVNmoney(cur.Thanhtien);

            //add interface
            if (QuantityChanged != null) //making sure someone is listening for the event
            {
                QuantityChanged(this, null);
            }

            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (RemoveItem != null) //making sure someone is listening for the event
            {
                RemoveItem(this, null);
                QuantityChanged(this, null);
            }
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
