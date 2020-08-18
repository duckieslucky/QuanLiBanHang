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
using GUI.Resources.CustomComponent;
using GUI.Resources;
namespace GUI.Admin
{
    public enum CRUD_State
    {
        View,
        Insert,
        Update,
        Delete,
    }

    public partial class Product_Admin : ChildForm
    {
        private CRUD_State mode;
        private BoolBinding viewState;
        private BindingSource sanpham;
        private SanPham_DTO newItem;

        public Product_Admin()
        {
            InitializeComponent();
        }

        private void Product_Admin_Load(object sender, EventArgs e)
        {
            //default set
            viewState = new BoolBinding(false);
            mode = CRUD_State.View;

            this.dgvSP.AutoGenerateColumns = false;
            cbxMenuConUpdate.DisplayMember = cbxMenuCon.DisplayMember = "Ten"; 
            cbxMenuConUpdate.ValueMember = cbxMenuCon.ValueMember = "Id"; 

            //data
            sanpham = new BindingSource(SanPhamBUL.Instance.Retrieve(), null);
            dgvSP.DataSource = sanpham;

            //combobox
            var temp1 = MenuConBUL.Instance.Retrieve();
            temp1.Add(new MenuCon_DTO() { Id = null, Ten = "Ngừng bán" });
            cbxMenuConUpdate.DataSource = temp1;

            var temp2 = MenuConBUL.Instance.Retrieve();
            temp2.Add(new MenuCon_DTO() { Id = -1, Ten = "Tất cả" });
            temp2.Add(new MenuCon_DTO() { Id = null, Ten = "Ngừng bán" });
            cbxMenuCon.DataSource = temp2;

            //bind
            BindingUI();
            BindingData();
        }

        #region Events

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "btnUpdate" && e.RowIndex >= 0)
            {
                viewState.State = true;
                mode = CRUD_State.Update;
                newItem = dgvSP.CurrentRow.DataBoundItem as SanPham_DTO;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            viewState.State = true;
            mode = CRUD_State.Insert;
            ClearForm();
            newItem = new SanPham_DTO();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess;
            //valid

            //update DTO
            newItem.Ten = tbxTen.Text;
            newItem.Dvt = tbxDVT.Text;
            newItem.Giagoc = Convert.ToDecimal(tbxGiagoc.Text.Replace("VND", string.Empty));
            newItem.TileLoi = Convert.ToSingle(tbxTile.Text);
            newItem.TileKm = Convert.ToSingle(tbxTileKM.Text);
            newItem.IdMenuCon = (int?)cbxMenuConUpdate.SelectedValue;
                //soluong khong doi
            
            //call BUL
            if (mode == CRUD_State.Insert)
            {
                isSuccess = SanPhamBUL.Instance.InsertSanPham(newItem);
            }
            else //update
            {
                isSuccess = SanPhamBUL.Instance.UpdateSanPham(newItem);
            }

            //Notification
            if (isSuccess)
            {
                if (mode == CRUD_State.Insert)
                {
                    MessageBox.Show("Đã thêm sản phẩm mới !");
                }
                else
                {
                    MessageBox.Show("Đã cập nhật thông tin sản phẩm !");
                }
                sanpham.DataSource = SanPhamBUL.Instance.Retrieve();

                //change state
                viewState.State = false;
                mode = CRUD_State.View;
                ClearForm();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra !!!", "Cảnh báo");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            viewState.State = false;
            mode = CRUD_State.View;
            ClearForm();
            if (newItem != null)
            {
                newItem = null;
            }
            
        }

        

        //searching
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods

        private void BindingData()
        {
            lblId.DataBindings.Add(new Binding("Text", sanpham, "Id", true, DataSourceUpdateMode.Never));
            tbxTen.DataBindings.Add(new Binding("Text", sanpham, "Ten", true, DataSourceUpdateMode.Never));
            tbxDVT.DataBindings.Add(new Binding("Text", sanpham, "Dvt", true, DataSourceUpdateMode.Never));
            tbxGiagoc.DataBindings.Add(new Binding("Text", sanpham, "Giagoc", true, DataSourceUpdateMode.Never)
            {
                FormatString = "c2",
            });
            tbxTile.DataBindings.Add(new Binding("Text", sanpham, "TileLoi", true, DataSourceUpdateMode.Never));
            tbxTileKM.DataBindings.Add(new Binding("Text", sanpham, "TileKm", true, DataSourceUpdateMode.Never));
            lblSL.DataBindings.Add(new Binding("Text", sanpham, "Soluong", true, DataSourceUpdateMode.Never));
            lblGiaban.DataBindings.Add(new Binding("Text", sanpham, "Giaban", true, DataSourceUpdateMode.Never)
            {
                FormatString ="c2"
            });

            cbxMenuConUpdate.DataBindings.Add(new Binding("SelectedValue", sanpham, "IdMenuCon", true, DataSourceUpdateMode.Never));
        }

        private void BindingUI()
        {
            //form
            lblId.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxTen.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxDVT.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxGiagoc.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxTile.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxTileKM.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            cbxMenuConUpdate.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));

            //button
            padBottomRight.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));

            //gridview
            dgvSP.DataBindings.Add(new Binding("Enabled", viewState, "OppState", true, DataSourceUpdateMode.OnPropertyChanged));
        }



        private void ClearForm()
        {
            lblId.Text = "Tự động cập nhật";
            tbxTen.Clear();
            tbxDVT.Clear();
            tbxGiagoc.Clear();
            tbxTile.Clear();
            tbxTileKM.Clear();
            cbxMenuConUpdate.SelectedIndex = 0;
            lblSL.Text = "0";
            lblGiaban.Text = "Tự động cập nhật";
        }







        #endregion

        private void cbxMenuCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = (int?)cbxMenuCon.SelectedValue;
            switch (value)
            {
                case null:
                    sanpham.DataSource = SanPhamBUL.Instance.Retrieve_Deleted();
                    break;
                case -1:
                    sanpham.DataSource = SanPhamBUL.Instance.Retrieve();
                    break;
                default:
                    sanpham.DataSource = SanPhamBUL.Instance.Retrieve(value);
                    break;
            }
        }
    }
}
