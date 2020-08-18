using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class HoaDonDAL
    {
        private static HoaDonDAL instance;

        public static HoaDonDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonDAL();
                }
                return instance;
            }
            private set => instance = value;
        }

        //all case
        public List<HoaDon_DTO> Retrieve()
        {
            string query = "select * from HoaDon";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<HoaDon_DTO> lResult = HoaDon_DTO.TableToList(dt);
            return lResult;
        }

        public List<HoaDon_DTO> Retrieve_View()
        {
            string query = "select * from HoaDon_View";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<HoaDon_DTO> lResult = HoaDon_DTO.TableToList(dt);
            return lResult;
        }

        public void InsertHoaDon(HoaDon_DTO hd,SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            string query = "insert into HoaDon values" +
                "(@id, @checkin, @checkout, @tongtien, @giamgia, @trangthai, @shipping, @huydon, @ghichu, @sudungban, @idBan, @idNhanVien)";
            object[] values ={
                hd.Id, 
                hd.Checkin, 
                HelperDAL.HandleNull(hd.Checkout),
                HelperDAL.HandleNull(hd.Tongtien),
                hd.Giamgia,
                hd.Trangthai,
                hd.Shipping,
                hd.Huydon,
                hd.Ghichu,
                hd.Sudungban,
                HelperDAL.HandleNull(hd.IdBan),
                hd.IdNhanVien
            };
            cmd.CommandText = query;
            cmd.Parameters.AddRange(HelperDAL.ExtractParameter(query, values));
            cmd.ExecuteNonQuery();
        }

        public bool InsertHoaDon_IncludeChiTiet(HoaDon_DTO hd, List<CThoadon_DTO> listItem)
        {
            return DataProvider.Instance.ExecuteNonQuery_Advance(cmd =>
            {
                InsertHoaDon(hd, cmd);
                listItem.ForEach(i => ChiTietHoaDonDAL.Instance.InsertChiTiet(i, cmd));
            });
        }

        public bool UpdateHoaDon(HoaDon_DTO hd)
        {
            string query = "update HoaDon set checkout = @checkout, tongtien = @tongtien, trangthai = @trangthai, shipping = @shipping, huydon = @huydon, ghichu = @ghichu, sudungban = @sudungban, idBan = @idBan where id = @id";
            SqlParameter[] paras = 
            {
                new SqlParameter("@id", hd.Id),
                new SqlParameter("@checkout", HelperDAL.HandleNull(hd.Checkout)),
                new SqlParameter("@tongtien", HelperDAL.HandleNull(hd.Tongtien)),
                new SqlParameter("@trangthai", hd.Trangthai),
                new SqlParameter("@shipping", hd.Shipping),
                new SqlParameter("@huydon", hd.Huydon),
                new SqlParameter("@ghichu", HelperDAL.HandleNull(hd.Ghichu)),
                new SqlParameter("@sudungban", hd.Sudungban),
                new SqlParameter("@idBan", HelperDAL.HandleNull(hd.IdBan)),
            };
            
            return DataProvider.Instance.ExecuteNonQuery(query, paras);
        }

        //viết sau
        public bool CancelHoaDon(HoaDon_DTO hd)
        {
            return false;
        }

        public HoaDon_DTO Find(object id)
        {
            string query = "select * from HoaDon where id = @id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new SqlParameter[] 
            {
                new SqlParameter("@id", id)
            });
            if (dt.Rows.Count > 0)
            {
                return HoaDon_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }


        

        //more option
        //View
        public List<HoaDon_DTO> Get_BillRangeDate(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT * FROM HoaDon_View where DATEADD(dd, 0, DATEDIFF(dd, 0, checkin )) between @min AND @max";
            SqlParameter[] paras =
            {
                new SqlParameter("@min", HelperDAL.HandleFormatDate(startDate)),
                new SqlParameter("@max", HelperDAL.HandleFormatDate(endDate)),

            };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, paras);
            return HoaDon_DTO.TableToList(dt);
        }

        //View
        public List<HoaDon_DTO> Get_BillByDate(DateTime date) 
        {
            string query = "SELECT * FROM HoaDon_View where id like @prefix";
            SqlParameter[] paras =
            {
                new SqlParameter("@prefix", date.ToString("ddMMyyyy") + "%"),
            };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, paras);
            return HoaDon_DTO.TableToList(dt);
        }

        public List<HoaDon_DTO> Get_BillByDate(DateTime date, bool trangthai)
        {
            string query = "SELECT * FROM HoaDon_View where id like @prefix and trangthai = @trangthai";
            SqlParameter[] paras =
            {
                new SqlParameter("@prefix", date.ToString("ddMMyyyy") + "%"),
                new SqlParameter("@trangthai", trangthai),
            };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, paras);
            return HoaDon_DTO.TableToList(dt);
        }

        //
        public int Count_BillByDate(DateTime yourDate)
        {
            string query = "SELECT count(*) FROM HoaDon where id like @prefix";
            SqlParameter[] paras =
            {
                new SqlParameter("@prefix", yourDate.ToString("ddMMyyyy") + "%"),
            };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, paras);
            return count;
        }

        public int Count_BillByDate(DateTime yourDate, bool trangthai)
        {
            string query = "SELECT count(*) FROM HoaDon where id like @prefix and trangthai = @trangthai";
            SqlParameter[] paras =
            {
                new SqlParameter("@prefix", yourDate.ToString("ddMMyyyy") + "%"),
                new SqlParameter("@trangthai", trangthai),
            };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, paras);
            return count;
        }

        public int Count_BillByDate(DateTime yourDate, bool trangthai, bool sudungban)
        {
            string query = "SELECT count(*) FROM HoaDon where id like @prefix and trangthai = @trangthai and sudungban = @sudungban";
            SqlParameter[] paras =
            {
                new SqlParameter("@prefix", yourDate.ToString("ddMMyyyy") + "%"),
                new SqlParameter("@trangthai", trangthai),
                new SqlParameter("@sudungban", sudungban),
            };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, paras);
            return count;
        }

        public decimal Sum_BillByDate(DateTime yourDate)
        {
            string query = "SELECT SUM(tongtien * (100 - giamgia) / 100) FROM HoaDon WHERE id like @prefix";
            SqlParameter[] paras =
            {
                new SqlParameter("@prefix", yourDate.ToString("ddMMyyyy") + "%"),
            };
            object sum = DataProvider.Instance.ExecuteScalar(query, paras);
            return  sum == DBNull.Value ? 0 : Convert.ToDecimal(sum);
        }

        public decimal Sum_BillByDate(DateTime yourDate, bool trangthai)
        {
            string query = "SELECT SUM(tongtien * (100 - giamgia) / 100) FROM HoaDon WHERE id like @prefix and trangthai = @trangthai";
            SqlParameter[] paras =
            {
                new SqlParameter("@prefix", yourDate.ToString("ddMMyyyy") + "%"),
                new SqlParameter("@trangthai", trangthai),
            };
            object sum = DataProvider.Instance.ExecuteScalar(query, paras);
            return sum == DBNull.Value ? 0 : Convert.ToDecimal(sum);
        }

        public DataTable UPD_DoanhThu_NgayTrongTuan()
        {
            string query = "EXEC UPD_DoanhThu_NgayTrongTuan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
