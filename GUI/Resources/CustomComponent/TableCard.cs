using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace GUI.Resources.CustomComponent
{
    public partial class TableCard : UserControl
    {
        public event EventHandler Clean;
        public event EventHandler ViewDetail;
        public event EventHandler Booking;

        public enum state
        {
            available,
            holder,
            used
        }

        public TableCard()
        {
            InitializeComponent();
        }

        public TableCard(Ban_DTO data)
        {
            InitializeComponent();
            this.Tag = data;
            this.lblName.Text = data.Ten;
            Init();
        }

        private void SetState(state curState)
        {

            if (curState == state.used)
            {
                this.lblState.Text = "Đang sử dụng";
                this.CircleAlert.FillColor = Color.Red;
                this.btnClean.Enabled = true;
                this.btnHold.Enabled = false;
                this.btnDetails.Enabled = true;
            }
            else if (curState == state.holder)
            {
                this.lblState.Text = "Bàn đặt";
                this.CircleAlert.FillColor = Color.Yellow;
                this.btnClean.Enabled = true;
                this.btnHold.Enabled = false;
                this.btnDetails.Enabled = false;
            }
            else //available
            {
                this.lblState.Text = "Còn trống";
                this.CircleAlert.FillColor = Color.Green;
                this.btnClean.Enabled = false;
                this.btnHold.Enabled = true;
                this.btnDetails.Enabled = false;
            }

        }


        private state DeterminState()
        {
            bool? status = (this.Tag as Ban_DTO).Controng;
            if (status == false)
            {
                return state.used;
            }
            else if (status == null)
            {
                return state.holder;
            }
            else
            {
                return state.available;
            }
        }

        private void Init()
        {
            state my = DeterminState();
            SetState(my);
        }

        private void btnClean_Click(object sender, System.EventArgs e)
        {
            if (Clean != null) //making sure someone is listening for the event
            {
                Clean(this, null);
                Init();
            }
        }

        private void btnDetails_Click(object sender, System.EventArgs e)
        {
            if (ViewDetail != null) //making sure someone is listening for the event
            {
                ViewDetail(this, null);
                Init();
            }
        }

        private void btnHold_Click(object sender, System.EventArgs e)
        {
            if (Booking != null) //making sure someone is listening for the event
            {
                Booking(this, null);
                Init();
            }
        }
    }
}
