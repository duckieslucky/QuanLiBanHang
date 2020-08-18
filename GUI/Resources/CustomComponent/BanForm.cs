using BUL;
using DTO;
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
    public partial class BanForm : Form
    {
        public ViewBill parent;
        private List<Ban_DTO> data;
        public BanForm()
        {
            InitializeComponent();
        }

        private void BanForm_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;
            data = BanBUL.Instance.Retrieve().FindAll(s => s.Controng == true);
            dgv.DataSource = data;
            Set_ButtonColumn();
            Set_index();
        }

        private void Set_index()
        {
            int i = 1;
            foreach(DataGridViewRow dr in dgv.Rows)
            {
                dr.Cells["stt"].Value = i;
                dr.Cells["trangthai"].Value = "Còn trống";
                i++;
            }
        }

        private void Set_ButtonColumn()
        {
            DataGridViewButtonColumn SelectColumn = new DataGridViewButtonColumn();
            SelectColumn.Name = "btnChon_column";
            SelectColumn.Text = "Chọn";
            SelectColumn.HeaderText = "Tùy chọn";
            SelectColumn.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            SelectColumn.DefaultCellStyle.NullValue = "Chọn";
            int columnIndex = dgv.ColumnCount;
            if (dgv.Columns["btnChon_column"] == null)
            {
                dgv.Columns.Insert(columnIndex, SelectColumn);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                parent.ban = senderGrid.Rows[e.RowIndex].DataBoundItem as Ban_DTO;
                MessageBox.Show($"Bạn đã chọn {parent.ban.Ten} cho hóa đơn", "Thông báo");
                this.Close();
            }
            
        }
    }
}
