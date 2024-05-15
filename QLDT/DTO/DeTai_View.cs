using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.DTO
{
    public class DeTai_View
    {
        public int STT { get; set; }
        public string id_DT { get; set; }
        public string Name { get; set; }
        public DateTime NN { get; set; }
        public bool TinhTrang { get; set; }
        public string ChuNhiem { get; set; }
        public string NameCap { get; set; }
    }
}
