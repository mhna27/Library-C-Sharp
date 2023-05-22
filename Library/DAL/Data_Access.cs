using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Data_Access
    {
        const string Connection_String = @"server=.\SQLMOHASEBAN; database=Library; Trusted_Connection=True";
        SqlConnection sql_conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dataTable;
        public Data_Access()
        {
            sql_conn = new SqlConnection();
            cmd = new SqlCommand();
            adapter = new SqlDataAdapter();
            dataTable = new DataTable();
            cmd.Connection = sql_conn;

        }
        public void Connect()
        {
            if (sql_conn != null)
            {
                sql_conn.ConnectionString = Connection_String;
                sql_conn.Open();
            }
        }
        public void Disconnect()
        {
            if (sql_conn != null)
            {
                sql_conn.Close();
            }
        }
        public DataTable Select_Data(string query)
        {
            if (sql_conn != null)
            {
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                dataTable.Clear();
                adapter.Fill(dataTable);
                return dataTable;
            }
            return null;
        }
        public void Do_Command(string query)
        {
            if (sql_conn != null)
            {
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
        }
        public void Exec_Store_Procedre(string proc_Name, SqlParameter[] sqlParameter)
        {
            if (sql_conn != null)
            {
                SqlCommand sql_cmnd = new SqlCommand(proc_Name, sql_conn);
                sql_cmnd.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter param in sqlParameter)
                {
                    sql_cmnd.Parameters.Add(param);
                }

                sql_cmnd.ExecuteNonQuery();
                sql_cmnd.Dispose();
            }
        }
    }
}
