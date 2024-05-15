using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.DTO
{
    public delegate void EventForOkSuccess(object sender, OkSuccessEventArgs e);
    public class OkSuccessEventArgs : EventArgs
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ChuNhiem { get; set; }
        public DateTime NN { get; set; }
        public bool TinhTrang { get; set; }
        public string Cap { get; set; }
    }
}
