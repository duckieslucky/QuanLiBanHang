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

namespace GUI.Admin
{
    public partial class Provider_Admin : ChildForm
    {
        private CRUD_State mode;
        private BoolBinding viewState;
        private BindingSource cungcap;
        private CungCap_DTO newItem;
        public Provider_Admin()
        {
            InitializeComponent();
        }

        private void Provider_Admin_Load(object sender, EventArgs e)
        {
            //default set
            viewState = new BoolBinding(false);
            mode = CRUD_State.View;
            
            //
            this.dgvCC.AutoGenerateColumns = false;
            cungcap = new BindingSource();
            dgvCC.DataSource = cungcap;

            default_Load();

            BindingUI();
            BindingData();
        }

        private void default_Load()
        {
            cungcap.DataSource = CungCapBUL.Instance.Retrieve();
        }
        private void BindingData()
        {
            lblId.DataBindings.Add(new Binding("Text", cungcap, "Id", true, DataSourceUpdateMode.Never));
            tbxDT.DataBindings.Add(new Binding("Text", cungcap, "Sdt", true, DataSourceUpdateMode.Never));
            tbxEmail.DataBindings.Add(new Binding("Text", cungcap, "Email", true, DataSourceUpdateMode.Never));
            tbxDC.DataBindings.Add(new Binding("Text", cungcap, "Diachi", true, DataSourceUpdateMode.Never));
            tbxTen.DataBindings.Add(new Binding("Text", cungcap, "Ten", true, DataSourceUpdateMode.Never));
            
        }


        private void BindingUI()
        {
            //form
            lblId.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxTen.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxDT.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxEmail.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxDC.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            

            //button
            padBottomRight.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));

            //gridview
            dgvCC.DataBindings.Add(new Binding("Enabled", viewState, "OppState", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            viewState.State = true;
            mode = CRUD_State.Insert;
            ClearForm();
            newItem = new CungCap_DTO();
        }

        private void ClearForm()
        {
            lblId.Text = "Tự động cập nhật";
            tbxTen.Clear();
            tbxDT.Clear();
            tbxEmail.Clear();
            tbxDC.Clear();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            if(newItem == null)
            {
                return;
            }

            newItem.Ten = tbxTen.Text;
            newItem.Sdt = tbxDT.Text;
            newItem.Email = tbxEmail.Text;
            newItem.Diachi = tbxDC.Text;

            if (mode == CRUD_State.Insert)
            {
                isSuccess = CungCapBUL.Instance.InsertCungCap(newItem);
            }
            else //update
            {
                isSuccess = CungCapBUL.Instance.UpdateCungCap(newItem);
            }

            //Notification
            if (isSuccess)
            {
                if (mode == CRUD_State.Insert)
                {
                    MessageBox.Show("Đã thêm đối tác mới !");
                }
                else
                {
                    MessageBox.Show("Đã cập nhật thông tin đối tác !");
                }
                cungcap.DataSource = CungCapBUL.Instance.Retrieve();

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

        private void dgvCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "colCapnhat" && e.RowIndex >= 0)
            {
                viewState.State = true;
                mode = CRUD_State.Update;
                newItem = dgvCC.CurrentRow.DataBoundItem as CungCap_DTO;
            }
        }
    }
}
