using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataProvider
    {
        private static DataProvider instance;
        
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            set => instance = value;
        }

        private readonly string dbConnect = @"Data Source=.;Initial Catalog=QLBH;Integrated Security=True";
        
        private SqlConnection connection;

        public string DatabaseName
        {
            get
            {
                try
                {
                    Create_Connection();
                    return connection.Database;
                }
                catch
                {
                    return string.Empty;
                }
                finally
                {
                    Close_Connection();
                }
            }
        }

        public void Create_Connection()
        {
            connection = new SqlConnection(dbConnect);
        }

        public void Close_Connection()
        {
            if(connection != null)
                connection.Close();
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] paras = null)
        {
            DataTable dt = new DataTable();

            Create_Connection();
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection  = connection;
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    if (paras != null) cmd.Parameters.AddRange(paras);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch
            {

            }
            finally
            {
                Close_Connection();
            }

            return dt;
        }

        public bool ExecuteNonQuery(string query, SqlParameter[] paras = null)
        {
            bool isSuccess = false;
            SqlTransaction trans = null;

            Create_Connection();
            try
            {
                connection.Open();
                trans = connection.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.Transaction = trans;
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    if (paras != null) cmd.Parameters.AddRange(paras);

                    isSuccess = cmd.ExecuteNonQuery() > 0;
                }
                trans.Commit();
            }
            catch
            {
                trans.Rollback();
            }
            finally
            {
                Close_Connection();
            }

            return isSuccess;
        }

        public bool ExecuteNonQuery_Advance(Action<SqlCommand> yourMethod)
        {
            bool isSuccess = false;
            SqlTransaction trans = null;

            Create_Connection();
            try
            {
                connection.Open();
                trans = connection.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.Transaction = trans;
                    cmd.CommandType = CommandType.Text;
                    yourMethod(cmd);
                }
                trans.Commit();
                isSuccess = true;
            }
            catch
            {
                trans.Rollback();
            }
            finally
            {
                Close_Connection();
            }

            return isSuccess;
        }

        public object ExecuteScalar(string query, SqlParameter[] paras = null)
        {
            object result = null;

            Create_Connection();
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    if(paras != null) cmd.Parameters.AddRange(paras);

                    result = cmd.ExecuteScalar();
                }
            }
            catch
            {
                
            }
            finally
            {
                Close_Connection();
            }

            return result;
        }

        //option
        public bool BackupData(string path)
        {
            Create_Connection();
            try
            {
                connection.Open();
                string query = "BACKUP DATABASE [" + connection.Database + "] TO DISK='" + path + "\\" + connection.Database + "-" + DateTime.Now.ToString("ddMMyyyy") + ".bak'";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                Close_Connection();
            }

            return true;
        }

        public bool RestoreData(string path)
        {
            Create_Connection();
            try
            {
                connection.Open();
                string database = connection.Database;
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    cmd.CommandText = sqlStmt2;
                    cmd.ExecuteNonQuery();

                    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + path + "'WITH REPLACE;";
                    cmd.CommandText = sqlStmt3;
                    cmd.ExecuteNonQuery();

                    string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    cmd.CommandText = sqlStmt4;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                Close_Connection();
            }

            return true;
        }
    }
}
