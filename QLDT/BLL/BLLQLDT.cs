using QLDT.DAL;
using QLDT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.BLL
{
    public class BLLQLDT
    {
        private static BLLQLDT _Instance;
        public static BLLQLDT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLQLDT();
                }
                return _Instance;
            }
            private set { }
        }
        private BLLQLDT() { }
        public string GetNameCDTByIdCDT(string id_CDT)
        {
            string NameCDT = "";
            foreach (CapDeTai i in DALQLDT.Instance.GetAllCDT())
            {
                if (id_CDT == i.id_Cap)
                {
                    NameCDT = i.NameCap;
                    break;
                }
            }
            return NameCDT;
        }
        public List<DeTai_View> ViewDT()
        {
            List<DeTai_View> data = new List<DeTai_View>();
            int stt = 0;
            foreach (DeTai i in DALQLDT.Instance.GetAllDT())
            {
                data.Add(new DeTai_View
                {
                    STT = ++stt,
                    id_DT = i.id_DT,
                    Name = i.Name,
                    NN = i.NN,
                    TinhTrang = i.TinhTrang,
                    ChuNhiem = i.ChuNhiem,
                    NameCap = GetNameCDTByIdCDT(i.id_Cap)
                });
            }
            return data;
        }
        public DeTai GetDTByIdDT(string id_DT)
        {
            DeTai dt = new DeTai();
            foreach (DeTai i in DALQLDT.Instance.GetAllDT())
            {
                if (i.id_DT == id_DT)
                {
                    dt = i;
                    break;
                }
            }
            return dt;
        }
        public List<string> GetCBBChuNhiem()
        {
            List<string> data = new List<string>();
            foreach (DeTai i in DALQLDT.Instance.GetAllDT())
            {
                bool check = false;
                foreach (string item in data)
                {
                    if (i.ChuNhiem == item)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    data.Add(i.ChuNhiem);
                }
            }
            return data;
        }
        public List<CBBItem> GetCBBCDT()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (CapDeTai i in DALQLDT.Instance.GetAllCDT())
            {
                data.Add(new CBBItem
                {
                    Value = i.id_Cap,
                    Text = i.NameCap
                });
            }
            return data;
        }
        public string GetIdCDTByNameCDT(string NameCDT)
        {
            string id_CDT = "";
            foreach (CapDeTai i in DALQLDT.Instance.GetAllCDT())
            {
                if (NameCDT == i.NameCap)
                {
                    id_CDT = i.id_Cap;
                    break;
                }
            }
            return id_CDT;
        }
        public void UpdateDTBLL(DeTai d)
        {
            DALQLDT.Instance.UpdateDTDAL(d);
        }
        public void DeleteDTBLL(List<string> li)
        {
            foreach (string i in li)
            {
                DALQLDT.Instance.DeleteDTDAL(i);
            }
        }
        public void AddDTBLL(DeTai d)
        {
            DALQLDT.Instance.AddDTDAL(d);
        }
        public List<DeTai> GetDTByIdCDT(string id_CDT)
        {
            List<DeTai> li = new List<DeTai>();
            foreach(DeTai i in DALQLDT.Instance.GetAllDT())
            {
                if(i.id_Cap == id_CDT)
                {
                    li.Add(i);
                }
            }
            return li;
        }
        public List<DeTai_View> GetDTViewByIDCDT(string id_CDT)
        {
            List<DeTai_View> li = new List<DeTai_View>();
            string Name = "";
            foreach(CapDeTai i in DALQLDT.Instance.GetAllCDT())
            {
                if(i.id_Cap == id_CDT)
                {
                    Name = i.NameCap;
                    break;
                }
            }
            int stt = 1;
            foreach (DeTai i in GetDTByIdCDT(id_CDT))
            {
                
                li.Add(new DeTai_View
                {
                    STT = stt++,
                    id_DT = i.id_DT,
                    Name = i.Name,
                    NN = i.NN,
                    TinhTrang = i.TinhTrang,
                    ChuNhiem = i.ChuNhiem,
                    NameCap = GetNameCDTByIdCDT(i.id_Cap)
                }) ;
            }
            return li;
        }
        
    }
}
