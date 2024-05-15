using QLDT.DTO;
using QLDT.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.DAL
{
    public class DALQLDT
    {
        private static DALQLDT _Instance;
        public static DALQLDT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DALQLDT();
                }
                return _Instance;
            }
            private set { }
        }
        private DALQLDT() { }
        public List<DeTai> GetAllDT()
        {
            List<DeTai> data = new List<DeTai>();
            string query = "select * from DeTai";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetDTByDataRow(i));
            }
            return data;
        }
        public DeTai GetDTByDataRow(DataRow i)
        {
            return new DeTai
            {
                id_DT = i["id_DT"].ToString(),
                Name = i["Name"].ToString(),
                NN = Convert.ToDateTime(i["NN"].ToString()),
                ChuNhiem = i["ChuNhiem"].ToString(),
                TinhTrang = Convert.ToBoolean(i["TinhTrang"].ToString()),
                id_Cap = i["id_Cap"].ToString()
            };
        }
        public List<CapDeTai> GetAllCDT()
        {
            List<CapDeTai> data = new List<CapDeTai>();
            string query = "select * from CapDeTai";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetCDTByDataRow(i));
            }
            return data;
        }
        public CapDeTai GetCDTByDataRow(DataRow i)
        {
            return new CapDeTai
            {
                id_Cap = i["id_Cap"].ToString(),
                NameCap = i["NameCap"].ToString(),
            };
        }
        public void UpdateDTDAL(DeTai d)
        {
            string query = "update DeTai Set Name = '" + d.Name + "', TinhTrang= '" + d.TinhTrang + "', NN = '" + d.NN + "', ChuNhiem = '" +d.ChuNhiem + "', id_Cap = '" + d.id_Cap + "' where id_DT= '" + d.id_DT + "'";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void DeleteDTDAL(string id_DT)
        {
            string query = "delete from DeTai where id_DT = '" + id_DT + "'";
            DBHelper.Instance.ExecuteDB(query);
        }
        public void AddDTDAL(DeTai d)
        {
            string query = "insert into DeTai (id_DT, Name, TinhTrang, NN, ChuNhiem, id_Cap) " +
               "VALUES ('" + d.id_DT + "', '" + d.Name + "', '" + d.TinhTrang + "', '" + d.NN + "', '" + d.ChuNhiem + "', '" + d.id_Cap + "')";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}
