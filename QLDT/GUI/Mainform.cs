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

namespace QLDT.GUI
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            Show_Search();
            SetCBBCDT();
        }
        public DataTable CreateDataTableDT()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã đề tài", typeof(string));
            dt.Columns.Add("Tên đề tài", typeof(string));
            dt.Columns.Add("Cấp đề tài", typeof(string));
            dt.Columns.Add("Chủ nhiệm", typeof(string));
            dt.Columns.Add("Tình trạng", typeof(bool));
            dt.Columns.Add("Ngày nhận", typeof(DateTime));
            return dt;
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvDT.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dtgvDT.CurrentRow;
                string id_DT = row.Cells["Mã đề tài"].Value.ToString();
                DeTai dt = BLLQLDT.Instance.GetDTByIdDT(id_DT);
                Addform addform = new Addform(dt.id_DT, dt.Name, dt.NN, dt.ChuNhiem, BLLQLDT.Instance.GetNameCDTByIdCDT(dt.id_Cap), dt.TinhTrang);
                addform.EventForOk += new EventForOkSuccess(Ok_EventForUpdate);
                addform.ShowDialog();
                ShowDT();
            }
        }
        void Ok_EventForUpdate(object sender, OkSuccessEventArgs e)
        {
            DeTai d = new DeTai();
            d.id_DT = e.Id;
            d.Name = e.Name;
            d.NN = Convert.ToDateTime(e.NN);
            d.ChuNhiem = e.ChuNhiem;
            d.TinhTrang = e.TinhTrang;
            d.id_Cap = BLLQLDT.Instance.GetIdCDTByNameCDT(e.Cap);
            BLLQLDT.Instance.UpdateDTBLL(d);
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (dtgvDT.SelectedRows.Count >= 0)
            {
                List<string> MDTDel = new List<string>();
                foreach (DataGridViewRow i in dtgvDT.SelectedRows)
                {
                    MDTDel.Add(i.Cells["Mã đề tài"].Value.ToString());
                }
                BLLQLDT.Instance.DeleteDTBLL(MDTDel);
                ShowDT();
            }
        }
        private void ShowDT()
        {
            DataTable dt = CreateDataTableDT();
            foreach (DeTai_View i in BLLQLDT.Instance.ViewDT())
            {
                DataRow row = dt.NewRow();
                row["STT"] = i.STT;
                row["Mã đề tài"] = i.id_DT;
                row["Tên đề tài"] = i.Name;
                row["Cấp đề tài"] = i.NameCap;
                row["Chủ nhiệm"] = i.ChuNhiem;
                row["Tình trạng"] = i.TinhTrang;
                row["Ngày nhận"] = i.NN;
                dt.Rows.Add(row);
            }
            dtgvDT.DataSource = dt;
        }
        void Ok_EventForOk(object sender, OkSuccessEventArgs e)
        {
            DeTai d = new DeTai();
            d.id_DT = e.Id;
            d.Name = e.Name;
            d.NN = Convert.ToDateTime(e.NN);
            d.ChuNhiem = e.ChuNhiem;
            d.TinhTrang = e.TinhTrang;
            d.id_Cap = BLLQLDT.Instance.GetIdCDTByNameCDT(e.Cap);
            BLLQLDT.Instance.AddDTBLL(d);
            
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            Addform addform = new Addform();
            addform.EventForOk += new EventForOkSuccess(Ok_EventForOk);
            addform.ShowDialog();
            ShowDT();
        }
        
        private void bttSearch_Click(object sender, EventArgs e)
        {
            string s = txtSearch.Text;
            DataTable dt = CreateDataTableDT();
            foreach (DeTai_View i in BLLQLDT.Instance.ViewDT())
            {
                DataRow row = dt.NewRow();
                row["STT"] = i.STT;
                row["Mã đề tài"] = i.id_DT;
                row["Tên đề tài"] = i.Name;
                row["Cấp đề tài"] = i.NameCap;
                row["Chủ nhiệm"] = i.ChuNhiem;
                row["Tình trạng"] = i.TinhTrang;
                row["Ngày nhận"] = i.NN;
                dt.Rows.Add(row);
            }
            DataTable temp = CreateDataTableDT();
            foreach (DataRow row in dt.Rows)
            {
                if (Check(row[cbbSeach.Text].ToString(), s))
                {
                    add_Row(row, temp);
                }
            }
            dtgvDT.DataSource = temp;
        }
        private bool Check(string value1, string value2)
        {
            return value1.Trim().Equals(value2.Trim());
        }
        private void add_Row(DataRow row, DataTable temp)
        {
            DataRow row_temp = temp.NewRow();
            row_temp["STT"] = row["STT"];
            row_temp["Mã đề tài"] = row["Mã đề tài"];
            row_temp["Tên đề tài"] = row["Tên đề tài"];
            row_temp["Cấp đề tài"] = row["Cấp đề tài"];
            row_temp["Chủ nhiệm"] = row["Chủ nhiệm"];
            row_temp["Tình trạng"] = row["Tình trạng"];
            row_temp["Ngày nhận"] = row["Ngày nhận"];
            temp.Rows.Add(row_temp);
        }
        public void Show_Search()
        {
            cbbSeach.Items.Add("Mã đề tài");
            cbbSeach.Items.Add("Tên đề tài");
            cbbSeach.Items.Add("Cấp đề tài");
            cbbSeach.Items.Add("Chủ nhiệm");
            cbbSeach.Items.Add("Tình trạng");
            cbbSeach.Items.Add("Ngày nhận");
        }

        private void bttSort_Click(object sender, EventArgs e)
        {
            

        }
        public void SetCBBCDT()
        {
            cbbCDT.Items.Clear();
            foreach (CBBItem i in BLLQLDT.Instance.GetCBBCDT())
            {
                cbbCDT.Items.Add(i);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbCDT.SelectedIndex >= 0)
            {
                string id_CDT = ((CBBItem)cbbCDT.SelectedItem).Value;
                DataTable dt = CreateDataTableDT();
                foreach (DeTai_View i in BLLQLDT.Instance.GetDTViewByIDCDT(id_CDT))
                {
                    DataRow row = dt.NewRow();
                    row["STT"] = i.STT;
                    row["Mã đề tài"] = i.id_DT;
                    row["Tên đề tài"] = i.Name;
                    row["Cấp đề tài"] = i.NameCap;
                    row["Chủ nhiệm"] = i.ChuNhiem;
                    row["Tình trạng"] = i.TinhTrang;
                    row["Ngày nhận"] = i.NN;
                    dt.Rows.Add(row);
                }
                dtgvDT.DataSource = dt;
            }
        }
    }
}
