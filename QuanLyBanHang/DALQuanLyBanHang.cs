using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    class DALQuanLyBanHang
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter dap;
        private DataSet ds;
        private DataTable dt;
        private string conectionString = "";
        
        public DALQuanLyBanHang()
        {
            conectionString = Properties.Settings.Default.QuanLyBanHangConnectionString;
            con = new SqlConnection(conectionString);
        }
        public DALQuanLyBanHang(string _connectionString)
        {
            con = new SqlConnection(_connectionString);
        }
        
        public string ConnectionString
        {
            get
            {
                return conectionString;
            }
            set
            {
                conectionString = value;
            }
        }
      
        public DataSet GetData(string sql)
        {
            dap = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }
        
        public void DoExecute(string sql)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
