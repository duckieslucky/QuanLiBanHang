using BUL;
using DTO;
using GUI.Resources.CustomComponent;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class testAPi : Form
    {
        public testAPi()
        {
            InitializeComponent();
        }

        private void testAPi_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource = MenuChaBUL.Instance.Retrieve();
            //comboBox1.DisplayMember = "ten";
            //comboBox1.ValueMember = "id";

            //dgv.DataSource = CungCapBUL.Instance.Retrieve();
            //MessageBox.Show(HoaDonBUL.Instance.Get_NewId());

            //string id = HoaDonBUL.Instance.Get_NewId();
            //HoaDon_DTO h = new HoaDon_DTO()
            //{
            //    Id = "08062020HD002",
            //    Checkout = DateTime.Now,
            //    Tongtien = 0.00,
            //    Trangthai = true,
            //    Shipping = false,
            //    Huydon = true,
            //    Ghichu = "Thử cho vui",
            //    Sudungban = true,
            //    IdBan = 1,
            //    IdNhanVien = 1
            //};
            //HoaDonBUL.Instance.UpdateHoaDon(h);

            //var sp = SanPhamBUL.Instance.Retrieve().FirstOrDefault();
            //MessageBox.Show(sp.Tinh_Giaban().ToString());
            //SanPhamBUL.Instance.UpdateSanPham(new SanPham_DTO()
            //{
            //    Id = 2,
            //    Ten = "Test ok",
            //    Soluong = 1,
            //    Dvt = "test",
            //    Giagoc = 3000,
            //    TileLoi = 0.3f,
            //    TileKm = 0,
            //    IdMenuCon = null
            //}) ;

            //dgv.DataSource = SanPhamBUL.Instance.Retrieve();
            //ChiTietHoaDonBUL.Instance.InsertChiTiet(new CThoadon_DTO()
            //{
            //    IdPhieu = "08062020HD003",
            //    IdSanPham = 1,
            //    Soluong = 2,
            //    Dongia = 1000
            //});
            //dgv.DataSource = ChiTietHoaDonBUL.Instance.FindList("08062020HD002");
            //MessageBox.Show(sp.Tinh_Thanhtien().ToString());

            //List<CThoadon_DTO> l = new List<CThoadon_DTO>()
            //{
            //    new CThoadon_DTO(){ IdPhieu = "HD0002" , IdSanPham = 1, Soluong = 5, Dongia = 1000},
            //    new CThoadon_DTO(){ IdPhieu = "HD0002" , IdSanPham = 2, Soluong = 5, Dongia = 2000},
            //};

            //MessageBox.Show(ChiTietHoaDonBUL.Instance.InsertListChiTiet(l).ToString()) ;
            //var a = HoaDonBUL.Instance.Find("10062020HD002");
            //dgv.DataSource = HoaDonBUL.Instance.Get_BillRangeDate(DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackupBUL.Instance.Backup("123");
        }
    }
}
