using QLDT.BLL;
using QLDT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLDT.GUI
{
    public partial class Addform : Form
    {
        public event EventForOkSuccess EventForOk = null;
        public Addform()
        {
            InitializeComponent();
            SetCBBChuNhiem();
            SetCBBCDT();
        }
        public Addform(string id, string name, DateTime nn, string chuNhiem, string cap, bool tinhTrang)
        {
            InitializeComponent();
            SetCBBChuNhiem();
            SetCBBCDT();
            txtMDT.Text = id;
            txtName.Text = name;
            dttNN.Text = nn.ToString();
            cbbCN.Text = chuNhiem;
            cbbCDT.Text = cap;
            rdHT.Checked = tinhTrang;
            rdCHT.Checked = !tinhTrang;
        }

        public void SetCBBChuNhiem()
        {
            cbbCN.Items.Clear();
            foreach (string i in BLLQLDT.Instance.GetCBBChuNhiem())
            {
                cbbCN.Items.Add(i);
            }
        }
        public void SetCBBCDT()
        {
            cbbCDT.Items.Clear();
            foreach (CBBItem i in BLLQLDT.Instance.GetCBBCDT())
            {
                cbbCDT.Items.Add(i);
            }
        }
        void Ok_EventForOk(object sender, OkSuccessEventArgs e)
        {
            txtMDT.Text = e.Id;
            txtName.Text = e.Name;
            dttNN.Text = e.NN.ToString();
            cbbCDT.Text = BLLQLDT.Instance.GetIdCDTByNameCDT(e.Cap);
            cbbCN.Text = e.ChuNhiem;
            if(e.TinhTrang == true)
            {
                rdHT.Checked = true;
            }
            else
            {
                rdHT.Checked = false;
            }

        }
        private void bttOk_Click(object sender, EventArgs e)
        {
            if (EventForOk != null)
            {
                bool TinhTrang;
                if (rdCHT.Checked)
                {
                    TinhTrang = false;
                }
                else
                {
                    TinhTrang = true;
                }

                EventForOk(this, new OkSuccessEventArgs
                {
                    Id = txtMDT.Text,
                    Name = txtName.Text,
                    NN = Convert.ToDateTime(dttNN.Text),
                    ChuNhiem = cbbCN.Text,
                    Cap = cbbCDT.Text,
                    TinhTrang = TinhTrang
                });
                this.Close();
            }
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            txtMDT.Text = null;
            txtName.Text = null;
            dttNN.Text = null;
            cbbCN.Text = null;
            cbbCDT.Text = null;
            rdHT.Checked = false;
            rdCHT.Checked = false;
        }
    }
}
