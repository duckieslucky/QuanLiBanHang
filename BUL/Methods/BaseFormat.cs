using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BUL.Methods
{
    public static class BaseFormat
    {
        public static string DateNow 
        {
            get
            {
                return DateTime.Now.ToString("ddMMyyyy");
            }
        }

        public static string Generator_ViewId(string whichBill, int count)
        {
            return whichBill + count.ToString("000");
        }

    }

    
}
