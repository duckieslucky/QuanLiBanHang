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
using GUI.Resources.CustomComponent;
using DTO;
using BUL;

namespace GUI.Staff
{
    public partial class Tables_Staff : ChildForm
    {
        List<Ban_DTO> tableList;
        List<HoaDon_DTO> billList; // bill chờ cập nhật bàn
        public Tables_Staff()
        {
            InitializeComponent();
        }

        private void Order_Staff_Load(object sender, EventArgs e)
        {
            tableList = BanBUL.Instance.Retrieve();
            billList = HoaDonBUL.Instance.Get_BanBillByDate(DateTime.Now).FindAll(s=>s.Sudungban && s.Trangthai == false).ToList();
            Table_Loader(tableList);
            Bill_Loader(billList);
        }

      

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Table_Loader(List<Ban_DTO> DataSource)
        {
            fpnlViewTables.SuspendLayout();
            fpnlViewTables.Controls.Clear();
            foreach (var i in DataSource)
            {
                var card = new TableCard(i);
                card.Clean += new EventHandler(In_CleanTable);
                card.ViewDetail += new EventHandler(In_ViewBill);
                fpnlViewTables.Controls.Add(card);
            }
            fpnlViewTables.ResumeLayout();
        }

        private void Bill_Loader(List<HoaDon_DTO> DataSource)
        {
            pnlBill.Controls.Clear();
            foreach (var i in DataSource)
            {
                pnlBill.Controls.Add(new TableGridRow(i) { Dock = DockStyle.Top });
            }
        }


        #region Interface
        private void In_CleanTable(object sender, EventArgs e)
        {
            Ban_DTO ban = (Ban_DTO)(sender as TableCard).Tag;
            var bill = billList.Find(s => s.IdBan == ban.Id);
            if (bill.Trangthai)
            {
                ban.Controng = true;
                if (BanBUL.Instance.UpdateBan(ban))
                {
                    MessageBox.Show($"Đã yêu cầu dọn bàn {ban.Ten}");
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống");
                }
            }
            else
            {
                MessageBox.Show("Bàn chưa thanh toán không thể dọn");
            }
        }

        private void In_ViewBill(object sender, EventArgs e)
        {
            Ban_DTO ban = (Ban_DTO)(sender as TableCard).Tag;
            var bill = billList.Find(s => s.IdBan == ban.Id);
            if(bill != null)
            {
                using(FastViewBill f = new FastViewBill(bill))
                {
                    f.ShowDialog();
                }

            }
        }

        private void In_Booking(object sender, EventArgs e)
        {
            //Ban_DTO ban = (Ban_DTO)(sender as TableCard).Tag;
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            var resetTable = tableList.FindAll(s => s.Controng == false);
            if(resetTable.Count > 0)
            {
                foreach(var t in resetTable)
                {
                    t.Controng = true;
                    try
                    {
                        BanBUL.Instance.UpdateBan(t);
                    }
                    catch(Exception err)
                    {

                    }
                }
            }

            // refesh source
            tableList = BanBUL.Instance.Retrieve();
            Table_Loader(tableList);
        }
    }
}
