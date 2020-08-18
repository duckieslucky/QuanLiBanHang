using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Input;
using Microsoft.VisualBasic;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace GUI.Resources
{
    public enum Role : int
    {
        Quanly = 1,
        Banhang = 2,
        Kiemkho = 3
    }
    public class Helper_GUI
    {
        public static string PathToReportSource = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\ReportViewer\";

        public static CultureInfo culture = new CultureInfo("vi-VN");
        
        public static string ConvertToVNmoney(decimal value)
        {
            return String.Format(culture, "{0:N0}", value);
        }

        public static Dictionary<string, int> Get_MonthList()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            for(int i = 1; i <= 12; i++)
            {
                result.Add($"Tháng {i}", i);
            }
            return result;
        }

        public static Dictionary<string, int> Get_YearList(int limit = 5)
        {
            int yearNow = DateTime.Now.Year;
            Dictionary<string, int> result = new Dictionary<string, int>();
            for (int i = 0; i < 5 ; i++)
            {
                var temp = yearNow - i;
                result.Add($"Năm {temp}", temp);
            }
            return result;
        }

        public static void Load_LocalReport(ReportViewer rp,Report_DTO resource)
        {
            //default set
            rp.LocalReport.DataSources.Clear();
            if(rp.ProcessingMode != ProcessingMode.Local)
            {
                rp.ProcessingMode = ProcessingMode.Local;
            }
        
            //handle rdlc
            rp.LocalReport.ReportPath = Helper_GUI.PathToReportSource + resource.RdlcFile;

            //handle parameter
            if(resource.ListPara != null)
            {
                rp.LocalReport.SetParameters(resource.ListPara);
            }

            //handle tablses
            resource.ListTable.ForEach(s => rp.LocalReport.DataSources.Add(s));

            //change width
            rp.ZoomMode = ZoomMode.PageWidth;

            //refesh
            rp.RefreshReport();
        }

        public static void Set_DatetimeVN_Grid(DataGridView dgv,string columnName, bool useTime = false)
        {
            if (useTime)
            {
                dgv.Columns[columnName].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
            }
            else
            {
                dgv.Columns[columnName].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            dgv.Columns[columnName].DefaultCellStyle.FormatProvider = culture;
        }

        public static void Set_CurrencyVN_Grid(DataGridView dgv, string columnName)
        {
            dgv.Columns[columnName].DefaultCellStyle.Format = "c0";
            dgv.Columns[columnName].DefaultCellStyle.FormatProvider = culture;
        }
    }
}
