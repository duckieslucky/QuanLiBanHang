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
using GUI.Resources;

namespace GUI.Admin
{
    public partial class Home_Admin : ChildForm
    {
        public Home_Admin()
        {
            InitializeComponent();
        }

        private void Home_Admin_Load(object sender, EventArgs e)
        {
            Card_Load();

            Chart_Load();
        }


        private void Card_Load()
        {
            //card load 
            DateTime dateNow = DateTime.Now;
            //chưa thanh toán
            lblCard1.Text = HoaDonBUL.Instance.Count_BillByDate(dateNow, false).ToString();
            //tổng đơn
            lblCard3.Text = HoaDonBUL.Instance.Count_BillByDate(dateNow).ToString();
            //tiền chờ
            lblCard2.Text = Helper_GUI.ConvertToVNmoney(HoaDonBUL.Instance.Sum_BillByDate(dateNow, false));
            //tổng tiền
            lblCard4.Text = Helper_GUI.ConvertToVNmoney(HoaDonBUL.Instance.Sum_BillByDate(dateNow));

        }

        private void Chart_Load()
        {
            var src = HoaDonBUL.Instance.UPD_DoanhThu_NgayTrongTuan();
            chartLeft.DataSource = src;
            chartLeft.Series["Doanh thu"].XValueMember = "Ngay";
            chartLeft.Series["Doanh thu"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            chartLeft.Series["Doanh thu"].YValueMembers = "Doanhthu";
            chartLeft.Series["Doanh thu"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            chartLeft.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "c0";

            //chartLeft.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            //chartLeft.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            chartLeft.Series["Doanh thu"].IsValueShownAsLabel = true;
            chartLeft.Series["Doanh thu"].LabelFormat = "c0";
        }

        private void btnReport_Cot_Click(object sender, EventArgs e)
        {
            chartLeft.Series["Doanh thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void btnReport_Tron_Click(object sender, EventArgs e)
        {
            chartLeft.Series["Doanh thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            
           // chartLeft.Series["Doanh thu"].Label = "#PERCENT";

        }
    }
}
