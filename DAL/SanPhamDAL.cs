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
    public class SanPhamDAL
    {
        private static SanPhamDAL instance;

        public static SanPhamDAL Instance 
        { 
            get
            {
                if(instance == null)
                {
                    instance = new SanPhamDAL();
                }
                return instance;
            }
            private set => instance = value; 
        }

        public List<SanPham_DTO> Retrieve()
        {
            string query = "select * from SanPham where idMenuCon is not NULL";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<SanPham_DTO> lResult = SanPham_DTO.TableToList(dt);

            return lResult;
        }

        public List<SanPham_DTO> Retrieve(int? madm)
        {
            string query = $"select * from SanPham where idMenuCon is not NULL and idMenuCon = @idMenuCon";
            object[] values = { HelperDAL.HandleNull(madm) };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            List<SanPham_DTO> lResult = SanPham_DTO.TableToList(dt);

            return lResult;
        }

        public List<SanPham_DTO> Retrieve_Deleted()
        {
            string query = $"select * from SanPham where idMenuCon is NULL";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, null);
            List<SanPham_DTO> lResult = SanPham_DTO.TableToList(dt);

            return lResult;
        }

        public bool InsertSanPham(SanPham_DTO sp)
        {
            string query = "insert into SanPham(ten, soluong, dvt, giagoc, tileLoi, tileKm, [idMenuCon]) values(@ten, @soluong, @dvt, @giagoc, @tileLoi, @tileKm, @idMenuCon)";
            object[] values = { sp.Ten, 0 , sp.Dvt, sp.Giagoc, sp.TileLoi, sp.TileKm , HelperDAL.HandleNull(sp.IdMenuCon) };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));

        }

        public bool UpdateSanPham(SanPham_DTO sp)
        {
            string query = "update SanPham set ten = @ten, soluong = @soluong, dvt = @dvt, giagoc = @giagoc, tileLoi = @tileLoi, tileKm = @tileKm, idMenuCon = @idMenuCon where id = @id";
            object[] values = { sp.Ten, 0, sp.Dvt, sp.Giagoc, sp.TileLoi, sp.TileKm, HelperDAL.HandleNull(sp.IdMenuCon), sp.Id };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public bool DeleteSanPham(SanPham_DTO sp)
        {
            return false;
        }

        public SanPham_DTO Find(object id)
        {
            string query = "select * from SanPham where id = @id";
            object[] values = { id };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            if (dt.Rows.Count > 0)
            {
                return SanPham_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }

        //more
        public List<SanPham_DTO> UPD_YeuCapNhap_ByRangeDate(bool trangthai, DateTime start, DateTime end)
        {
            string query = "EXEC UPD_YeuCapNhap_ByRangeDate @trangthai, @startDate , @endDate";
            object[] values = { HelperDAL.HandleNull(trangthai), HelperDAL.HandleFormatDate(start), HelperDAL.HandleFormatDate(end) };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            List<SanPham_DTO> lResult = SanPham_DTO.TableToList(dt);
            return lResult;
        }

        public List<SanPham_DTO> UPD_YeuCapNhap_ByTrangThai(bool trangthai)
        {
            string query = "EXEC UPD_YeuCapNhap_ByTrangThai @trangthai";
            object[] values = { HelperDAL.HandleNull(trangthai)};
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            List<SanPham_DTO> lResult = SanPham_DTO.TableToList(dt);
            return lResult;
        }

        public List<SanPham_DTO> UPD_LayDanhSachSanPham_YeuCapNhap_TheoMaphieu(string idPhieu)
        {
            string query = "EXEC UPD_LayDanhSachSanPham_YeuCapNhap_TheoMaphieu @idPhieu";
            object[] values = { idPhieu };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            List<SanPham_DTO> lResult = SanPham_DTO.TableToList(dt);
            return lResult;
        }
    }
}
