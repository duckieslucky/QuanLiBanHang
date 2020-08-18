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
using BUL;
using DTO;
using GUI.Resources.Themes;
using GUI.Resources;
using GUI.Resources.CustomComponent;

namespace GUI.Staff
{
    public partial class Home_Staff : ChildForm
    {
        List<HoaDon_DTO> lHoadon;
        BindingSource dgvSource;
        DateTime dateNow = DateTime.Now;
        public Home_Staff()
        {
            InitializeComponent();
        }

        private void Home_Staff_Load(object sender, EventArgs e)
        {

            //default setting
            dgvBill.AutoGenerateColumns = false;

            //load data
            FirstTime_Load();
            Card_Load();

            dgvBill.DataSource = dgvSource;
            
        }

        private void Card_Load()
        {
            //card load 
            //chưa thanh toán
            lblCard1.Text = HoaDonBUL.Instance.Count_BillByDate(dateNow, false).ToString();
            //tổng đơn
            lblCard3.Text = HoaDonBUL.Instance.Count_BillByDate(dateNow).ToString();
            //tiền chờ
            lblCard2.Text = Helper_GUI.ConvertToVNmoney(HoaDonBUL.Instance.Sum_BillByDate(dateNow, false));
            //tổng tiền
            lblCard4.Text = Helper_GUI.ConvertToVNmoney(HoaDonBUL.Instance.Sum_BillByDate(dateNow));

        }

        private void FirstTime_Load()
        {
            //source
            lHoadon = HoaDonBUL.Instance.Get_BillByDate(DateTime.Now, false);

            //dgv load
            dgvSource = new BindingSource() 
            {
                DataSource = lHoadon 
            };
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                var obj = dgvBill.CurrentRow.DataBoundItem as HoaDon_DTO;
                using (FastViewBill f = new FastViewBill(obj))
                {
                    f.ShowDialog();

                    //check xem khi nào thanh toán mới load
                    dgvSource.DataSource = HoaDonBUL.Instance.Get_BillByDate(DateTime.Now, false);
                    Card_Load();
                }
            }
        }
    }
}
