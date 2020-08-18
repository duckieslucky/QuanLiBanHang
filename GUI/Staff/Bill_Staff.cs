using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Users;
using GUI.Resources;
using DTO;
using GUI.Resources.CustomComponent;
using BUL;

namespace GUI.Staff
{
    public partial class Bill_Staff : ChildForm
    {
        public Bill_Staff()
        {
            InitializeComponent();
        }

        private void btnTim_HD_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_GH_Click(object sender, EventArgs e)
        {

        }

        private void dgvBill_HD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var obj = dgvBill_HD.CurrentRow.DataBoundItem as HoaDon_DTO;
                using (FastViewBill f = new FastViewBill(obj))
                {
                    f.ShowDialog();
                }
            }
        }

        private void dgvBill_GH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var hd = dgvBill_GH.Rows[e.RowIndex].DataBoundItem as HoaDon_DTO;
                using (FastViewBill f = new FastViewBill(hd))
                {
                    f.ShowDialog();
                    dgvBill_GH.DataSource = HoaDonBUL.Instance.Get_BillByDate(DateTime.Now).FindAll(s => s.Shipping == true && s.Trangthai == false);
                }
            }
        }

        private void Bill_Staff_Load(object sender, EventArgs e)
        {
            this.dgvBill_HD.AutoGenerateColumns = false;
            this.dgvBill_GH.AutoGenerateColumns = false;
            Helper_GUI.Set_CurrencyVN_Grid(dgvBill_HD, "tongtien_HD");
            Helper_GUI.Set_CurrencyVN_Grid(dgvBill_GH, "tongtien_GH");

            load_Data();
        }

        private void load_Data()
        {
            dgvBill_HD.DataSource = HoaDonBUL.Instance.Get_BillByDate(DateTime.Now);
            dgvBill_GH.DataSource = HoaDonBUL.Instance.Get_BillByDate(DateTime.Now).FindAll(s => s.Shipping == true && s.Trangthai == false);
        }
    }
}
