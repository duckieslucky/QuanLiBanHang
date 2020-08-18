using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
using GUI.Admin;
using GUI.Resources;
using GUI.Resources.CustomComponent;
using GUI.Resources.Themes;
using GUI.Staff;
using Microsoft.ReportingServices.Interfaces;

namespace GUI
{
    public partial class Dashboard_GUI : Form
    {
        #region Main Form Method
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveableForm(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private Thread loader;
        #region EVENT FORM
        public Dashboard_GUI()
        {
            //Control.CheckForIllegalCrossThreadCalls = false;
            //Thread t = new Thread()
            //MyLoader.ShowLoader();
            //MyLoader.CloseLoader();
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }
        private void Dashboard_GUI_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Default_Load();
        }
        #endregion

        #region Status bar
        private void btnUser_Click(object sender, EventArgs e)
        {
            using (PersonalSetting f = new PersonalSetting())
            {
                f.ShowDialog();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            int maxiumWidth = 215;
            int miniumWidth = 60;

            if (pnlMenuForm.Width == maxiumWidth)
            {
                pnlMenuForm.Width = miniumWidth;
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
                //xử lí thông tin nhân viên reponsive
                padUserInfo.Visible = false;
            }
            else 
            {
                pnlMenuForm.Width = maxiumWidth;
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
                //
                padUserInfo.Visible = true;

            }
        }

        private void btnSignOut_Bar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm f = new SettingForm();
        }

        private void btnSignOut_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private UserControl display;

        //WRITE CODE HERE
        private void Default_Load()
        {
            this.Hide();

            //load data;
            lblName.Text = User.FullName;
            lblCv.Text = User.Chucvu;

            //events
            pnlStatusBar.MouseDown += new MouseEventHandler(MoveableForm);


            //phân quyền
            phanquyen();
        }

        
        //PHÂN QUYỀN
        private void phanquyen()
        {
            switch (User.Role)
            {
                case (int)Role.Banhang:
                    Role_BanHang();
                    break;

                case (int)Role.Kiemkho:
                    Role_KiemKho();
                    break;

                case (int)Role.Quanly:
                    Role_Quanly();
                    break;

                default:
                    MessageBox.Show("Lỗi quyền truy cập!");
                    this.Close();
                    break;
            }
        }
        
        private void Role_BanHang()
        {
            //phanquyen
            btnProduct.Visible = false;
            btnProvider.Visible = false;
            btnStaff.Visible = false;
            btnReport.Visible = false;
            btnBackup.Visible = false;
            //defalt
            Load_ChildForm(new Home_Staff());
            //add event
            btnHome.Click += (sender, e) => { Load_ChildForm(new Home_Staff()); };
            btnSale.Click += (sender, e) => { Load_ChildForm(new Order_Staff()); };
            btnTable.Click += (sender, e) => { Load_ChildForm(new Tables_Staff()); };
            btnBill.Click += (sender, e) => { Load_ChildForm(new Bill_Staff()); };
            btnImport.Click += (sender, e) => { Load_ChildForm(new Provider_Staff()); };
        }

        private void Role_KiemKho()
        {
            //phanquyen
            pnlButton.Controls.Clear();

            //defalt
            Load_ChildForm(new KiemKho_Staff());

            //add event
           
        }

        private void Role_Quanly()
        {
            //phanquyen
            
            //defalt
            Load_ChildForm(new Home_Admin());

            //add event
            btnHome.Click += (sender, e) => { Load_ChildForm(new Home_Admin()); };
            btnSale.Click += (sender, e) => { Load_ChildForm(new Order_Staff()); };
            btnTable.Click += (sender, e) => { Load_ChildForm(new Tables_Staff()); };
            btnBill.Click += (sender, e) => { Load_ChildForm(new Bill_Staff()); };
            btnImport.Click += (sender, e) => { Load_ChildForm(new Import_Admin()); };
            btnProduct.Click += (sender, e) => { Load_ChildForm(new Product_Admin()); };
            btnProvider.Click += (sender, e) => { Load_ChildForm(new Provider_Admin()); };
            btnStaff.Click += (sender, e) => { Load_ChildForm(new User_Admin()); };
            btnReport.Click += (sender, e) => { Load_ChildForm(new Report_Admin()); };
            btnBackup.Click += (sender, e) => { Load_ChildForm(new Backup_Admin()); };
        }

        private void Load_ChildForm(UserControl child)
        {
            if(display != null)
            {
                display.Dispose();
            } 
            this.pnlChildForm.SuspendLayout();
            display = child;
            this.pnlChildForm.Controls.Add(display);
            display.Dock = DockStyle.Fill;
            this.pnlChildForm.ResumeLayout();
        }

    }
}
