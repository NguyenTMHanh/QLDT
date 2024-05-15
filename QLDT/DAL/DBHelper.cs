using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.DAL
{
    public class DBHelper
    {
        private SqlConnection cnn { get; set; }
        public static DBHelper _Instance;
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string cnntr = @"Data Source=HANH;Initial Catalog=QuanLyDeTaiNghienCuuKhoaHoc;Integrated Security=True";
                    _Instance = new DBHelper(cnntr);
                }
                return _Instance;
            }
            private set { }
        }

        public DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
