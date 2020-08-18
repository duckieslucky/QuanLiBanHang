using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   

    public class Report_DTO
    {
        private string rdlcFile;
        private List<ReportParameter> listPara;
        private List<ReportDataSource> listTable;
        public Report_DTO()
        {
            RdlcFile = string.Empty;
            ListPara = new List<ReportParameter>();
            ListTable = new List<ReportDataSource>();
        }

        public string RdlcFile { get => rdlcFile; set => rdlcFile = value; }
        public List<ReportParameter> ListPara { get => listPara; set => listPara = value; }
        public List<ReportDataSource> ListTable { get => listTable; set => listTable = value; }

        public void ClearSource()
        {
            ListPara = new List<ReportParameter>();
            ListTable = new List<ReportDataSource>();
        }
        
    }
}
