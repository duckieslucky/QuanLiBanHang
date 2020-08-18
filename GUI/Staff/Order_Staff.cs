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
using DTO;
using BUL;
using GUI.Resources.CustomComponent;
using System.Management;
using System.Threading;
using GUI.Resources;

namespace GUI.Staff
{
    public partial class Order_Staff : ChildForm
    {
        #region Data
        public List<CThoadon_DTO> lChitiet { get; set; } // for viewbill
        private List<SanPham_DTO> lSanpham;
        private List<MenuCon_DTO> lMenucon;
        private List<MenuCha_DTO> lMenucha;
        
        #endregion

        public Order_Staff()
        {
            InitializeComponent();
        }

        private void Order_Staff_Load(object sender, EventArgs e)
        {
            Load_All();
            Default_Set();
        }

        private void Default_Set()
        {
            //cbx menu cha
            cbxDanhmuc.DataSource = lMenucha;
            cbxDanhmuc.DisplayMember = "ten";
            cbxDanhmuc.ValueMember = "id";

            //cbx menu con
            cbxMenuCon.DataSource = lMenucon ;
            cbxMenuCon.DisplayMember = "ten";
            cbxMenuCon.ValueMember = "id";


        }

        #region Method GUI


        #endregion


        #region Loading Zone

        private void Load_All()
        {
            Load_MenuCha();
            Load_MenuCon();
            
            Load_SanPham();
            Load_HoaDon();
        }

        public void Load_SanPham()
        {
            lSanpham = SanPhamBUL.Instance.Retrieve();
            Food_Loader(lSanpham);
            
            
        }

        private void Load_HoaDon()
        {
            lChitiet = new List<CThoadon_DTO>();
            Bill_Loader(lChitiet);
        }

        private void Load_MenuCon()
        {
            lMenucon = new List<MenuCon_DTO>() { new MenuCon_DTO { Id = -1, Ten = "Tất cả sản phẩm", IdMenuCha = -1}, };
            lMenucon.AddRange(MenuConBUL.Instance.Retrieve());
        }

        private void Load_MenuCha()
        {
            lMenucha = new List<MenuCha_DTO>() { new MenuCha_DTO { Id = -1, Ten = "Tất cả sản phẩm" } };
            lMenucha.AddRange(MenuChaBUL.Instance.Retrieve());
        }

        private void Food_Loader(List<SanPham_DTO> DataSource)
        {
            //dùng suspend giảm repaint
            pnlFoods.SuspendLayout();
            pnlFoods.Controls.Clear();
            if (DataSource != null)
            {
                foreach (var s in DataSource)
                {
                    var card = new FoodCard(s) { Margin = new Padding(10, 5, 10, 5) };
                    card.AddCart += new EventHandler(In_AddToCart);

                    pnlFoods.Controls.Add(card);

                }
            }

            pnlFoods.ResumeLayout();
        }

        private void Bill_Loader(List<CThoadon_DTO> DataSource)
        {
            pnlChitiet.Controls.Clear();
            if (DataSource != null)
            {
                foreach (var s in DataSource)
                {
                    var row = new FoodGridRow(s) { Dock = DockStyle.Top };
                    row.RemoveItem += new EventHandler(In_RemoveFromCart);
                    row.QuantityChanged += new EventHandler(In_SumBill);
                    pnlChitiet.Controls.Add(row);
                }
            }

        }

        private void Payment_Loader(List<CThoadon_DTO> DataSource)
        {
            decimal sum = 0;
            if (DataSource.Count > 0)
            {
                sum = DataSource.Sum(s => s.Thanhtien);
            }

            lblSum.Text = Helper_GUI.ConvertToVNmoney(sum);
        }

        #endregion


        #region Events

        //solution search #2 - using
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            //reset cbxDanhmuc
            cbxDanhmuc.SelectedValue = -1;
            cbxMenuCon.SelectedValue = -1;

            //search
            if (!string.IsNullOrEmpty(tbxSearch.Text))
            {
                var filterSource = lSanpham.FindAll(s => s.Ten.ToLower().Contains(tbxSearch.Text.ToLower()));
                Food_Loader(filterSource);
            }
            else
            {
                Food_Loader(lSanpham);
            }
        }

        private void cbxDanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////search
            if (lSanpham == null)
            {
                return;
                //mess ...
            }

            int value = (int)(cbxDanhmuc.SelectedItem as MenuCha_DTO).Id;
            if(value == -1)
            {
                cbxMenuCon.DataSource = lMenucon;
            }
            else
            {
                var filterSource = lMenucon.FindAll(s => s.IdMenuCha == value);
                cbxMenuCon.DataSource = filterSource;                
            }
            cbxMenuCon_SelectedIndexChanged(null, null);
        }

        private void cbxMenuCon_SelectedIndexChanged(object sender, EventArgs e)
        {

            var ds = cbxMenuCon.DataSource as List<MenuCon_DTO>;
            ////search
            if (ds.Count < 1)
            {
                Food_Loader(null);
                return;
            }

            var obj = cbxMenuCon.SelectedItem as MenuCon_DTO;
            if (obj.Id == -1)
            {
                var listId = ds.Select(s => s.Id).ToArray();
                //use linq lamba for simple
                var filterSource = from s in lSanpham
                                   where listId.Contains((int)s.IdMenuCon)
                                   select s;
                Food_Loader(lSanpham);
            }
            else
            {
                var filterSource = lSanpham.FindAll(s => s.IdMenuCon == obj.Id);
                Food_Loader(filterSource);
            }

        }

        //reponsive for FoodCard
        private void pnlFoods_Resize(object sender, EventArgs e)
        {

        }

        private void cbxSale_CheckedChanged(object sender, EventArgs e)
        {
            tbxSale.Enabled = cbxSale.Checked;

        }

        private void lblSum_TextChanged(object sender, EventArgs e)
        {
            decimal sum = Convert.ToDecimal(lblSum.Text.Replace(".", ""));
            int sale = Convert.ToInt32(tbxSale.Text);

            double salePercent = (100 - sale) / 100.0;
            decimal total = sum * (decimal)salePercent;
            lblTotal.Text = Helper_GUI.ConvertToVNmoney(total);

        }

        private void tbxSale_TextChanged(object sender, EventArgs e)
        {
            int sale = 0;
            if (cbxSale.Checked && int.TryParse(tbxSale.Text, out sale))
            {
                lblSum_TextChanged(null, null);
            }
        }

        private void btnDirectPay_CheckedChanged(object sender, EventArgs e)
        {
            //btnSave.Enabled = !btnDirectPay.Checked;
        }

        private void btnUseTable_CheckedChanged(object sender, EventArgs e)
        {
            //none
        }

        private void btnShipping_CheckedChanged(object sender, EventArgs e)
        {
            //none
        }

        #endregion


        #region Interface Events

        // Thêm giỏ hàng !!!
        private void In_AddToCart(object sender, EventArgs e)
        {
            SanPham_DTO sp = (SanPham_DTO)(sender as FoodCard).Tag;
            CThoadon_DTO chitiet = lChitiet.Where(s => s.IdSanPham == sp.Id).FirstOrDefault();

            if (chitiet == null)
            {
                chitiet = new CThoadon_DTO()
                {
                    IdSanPham = sp.Id,
                    TenSanPham = sp.Ten,
                    Soluong = 1,
                    Giagoc = sp.Giagoc,
                    TileLoi = sp.TileLoi,
                    TileKm = sp.TileKm
                };
                lChitiet.Add(chitiet);

                var row = new FoodGridRow(chitiet) { Dock = DockStyle.Top };
                row.RemoveItem += new EventHandler(In_RemoveFromCart);
                row.QuantityChanged += new EventHandler(In_SumBill);
                pnlChitiet.Controls.Add(row);
                //load
                Payment_Loader(lChitiet);

            }
            else
            {
                //tăng 1
                chitiet.Soluong++;
                //cập nhật value
                foreach (FoodGridRow f in pnlChitiet.Controls)
                {
                    f.ResetValue();
                }
            }
        }

        private void In_RemoveFromCart(object sender, EventArgs e)
        {
            CThoadon_DTO ct = (CThoadon_DTO)(sender as FoodGridRow).Tag;
            lChitiet.Remove(ct);
            pnlChitiet.Controls.Remove((FoodGridRow)sender);
        }

        private void In_SumBill(object sender, EventArgs e)
        {
            Payment_Loader(lChitiet);
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn hủy bỏ giỏ hàng ?", "Thông báo", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                Clear_Chitiet();
            }
            
        }

        public void Clear_Chitiet()
        {
            lChitiet.Clear();
            pnlChitiet.Controls.Clear();
            Payment_Loader(lChitiet);
        }

        private void btnCashout_Click(object sender, EventArgs e)
        {
            if(lChitiet.Count > 0)
            {
                ViewBill f = new ViewBill();
                f.parent = this;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Giỏ hàng trống không thể tạo đơn !", "Cảnh báo");
            }
        }

        private void Order_Staff_Resize(object sender, EventArgs e)
        {

        }
    }
}
