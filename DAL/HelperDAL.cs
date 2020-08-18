using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class HelperDAL
    {
        //hanle sql data type
        public static object HandleNull(object value)
        {
            return value ?? (object)DBNull.Value;
        }

        public static int HandleBit(bool value)
        {
            return Convert.ToInt32(value);
        }

        //obj to sqlparameter
        public static SqlParameter[] ExtractParameter(string query, object[] values)
        {
            List<string> paraName = Regex.Matches(query, @"\@\w+")
                                         .Cast<Match>()
                                         .Select(m => m.Value)
                                         .ToList();
            if (paraName.Count == values.Length)
            {
                List<SqlParameter> result = new List<SqlParameter>();
                for (int i = 0; i < paraName.Count; i++)
                {
                    result.Add(new SqlParameter(paraName[i], values[i]));
                }
                return result.ToArray();
            }
            else
            {
                throw new Exception("Error: not same length of 2 array");
            }
        }

        //day - month - year
        public static string GetDateString()
        {
            return DateTime.Now.ToString("ddMMyyyy", CultureInfo.InvariantCulture);
        }
        
        public static object HandleFormatDate(DateTime yourDate)
        {
            return yourDate.ToString("yyyy-MM-dd");
        }
    }
}
