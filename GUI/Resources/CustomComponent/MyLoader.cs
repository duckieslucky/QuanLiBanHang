using BunifuVSIX.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Resources.CustomComponent
{
    public partial class MyLoader : Form
    {
        public static MyLoader Loader;
        //public Action Worker { get; set; }

        //public MyLoader(string message, Action method)
        //{
        //    InitializeComponent();
        //    if (!String.IsNullOrEmpty(message))
        //    {
        //        this.message.Text = message;
        //    }
        //    if (method != null)
        //    {
        //        Worker = method;
        //    }
        //    else
        //    {
        //        throw new Exception("You must declare a function/method");
        //    }
        //}

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    Task.Factory.StartNew(Worker)
        //                .ContinueWith(t =>
        //                {
        //                    this.status.Text = "Hoàn tất!";
        //                    this.message.Text = "Bắt đầu thao tác";
        //                    this.loader.Value = 100;
        //                    this.timeFadeOut.Start();
        //                }
        //                , TaskScheduler.FromCurrentSynchronizationContext());
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        //public static void Show(UserControl parent, string message, Action method)
        //{
        //    //using (MyLoader m = new MyLoader(message, method))
        //    //{
        //    //    parent.SuspendLayout();
        //    //    m.ShowDialog();
        //    //    parent.ResumeLayout();
        //    //}
        //}

        //public static void ShowDialog(string message, Action method)
        //{
        //    //using (MyLoader m = new MyLoader(message, method))
        //    //{
        //    //    m.ShowDialog();
        //    //}
        //}

        private void timeFadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timeFadeOut.Stop();
                //this.Close();
            }
        }
        

        public static void CompleteWork()
        {
            Loader.status.Text = "Hoàn tất!";
            Loader.message.Text = "Bắt đầu thao tác";
            Loader.loader.Value = 100;
            Loader.timeFadeOut.Start();
            Loader.Close();
        }

        public static void ShowLoader()
        {
            Loader = new MyLoader();
            Loader.ShowDialog();
        }

        public static void CloseLoader()
        {
            Loader.timeFadeOut.Start();
            Loader.Close();
            Loader.Dispose();
        }

    }
}
