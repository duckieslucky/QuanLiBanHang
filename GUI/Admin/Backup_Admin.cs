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

namespace GUI.Admin
{
    public partial class Backup_Admin : ChildForm
    {
        public Backup_Admin()
        {
            InitializeComponent();
        }

        private void Backup_Admin_Load(object sender, EventArgs e)
        {
            //retrive
            tbxRestore.Text = Properties.Settings.Default["previousBackup"].ToString();

            //
            btnBackup_Save.Enabled = false;
            btnRestore_Save.Enabled = false;
        }

        private void btnChon_1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbxBackup.Text = dlg.SelectedPath;
                btnBackup_Save.Enabled = true;
            }
        }

        private void btnBackup_Save_Click(object sender, EventArgs e)
        {
            if (BackupBUL.Instance.Backup(tbxBackup.Text))
            {
                //save path
                Properties.Settings.Default["previousBackup"] = tbxBackup.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show("Đã sao lưu dữ liệu !", "Thông báo");

            }
            else
            {
                MessageBox.Show("Không thể sao lưu dữ liệu !", "Thông báo");
            }
        }

        private void btnChon2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "File sao lưu (SQL)|*.bak";
            dlg.Title = "Khôi phục dữ liệu hệ thống";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbxRestore.Text = dlg.FileName;
                btnRestore_Save.Enabled = true;
            }
        }

        private void btnRestore_Save_Click(object sender, EventArgs e)
        {
            if (BackupBUL.Instance.Backup(tbxBackup.Text))
            {
                MessageBox.Show("Đã khôi phục dữ liệu !", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi không thể khôi phục !", "Thông báo");
            }
                
        }

    }
}
