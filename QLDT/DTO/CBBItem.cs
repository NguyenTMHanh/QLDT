using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.DTO
{
    public class CBBItem
    {
        private string _value; //id
        private string _Text;  //ten

        public string Value { get => _value; set => _value = value; }
        public string Text { get => _Text; set => _Text = value; }

        public override string ToString()
        {
            return Text;
        }
    }
}
