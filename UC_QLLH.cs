using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HKT_Team
{
    public partial class UC_QLLH : UserControl
    {
        string flag;
        DataTable dtSV;
        int index;
        public UC_QLLH()
        {
            InitializeComponent();
            dtSV = createTable();
        }

        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaLop");
            dt.Columns.Add("Khoa");
            dt.Columns.Add("SiSo");
            dt.Columns.Add("NamHoc");
            return dt;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Lớp này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtSV.Rows.RemoveAt(index);
                dgvHC.DataSource = dtSV;
                dgvHC.RefreshEdit();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            flag = "edit";
            {
                if (checkData())
                {
                    dtSV.Rows[index][0] = tbMaLop.Text;
                    dtSV.Rows[index][1] = tbKhoa.Text;
                    dtSV.Rows[index][2] = tbSiSo.Text;
                    dtSV.Rows[index][3] = tbNamNhapHoc.Text;
                    dgvHC.DataSource = dtSV;
                    dgvHC.RefreshEdit();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            


            if (flag == "add")
            {
                if (checkData())
                {
                    dtSV.Rows.Add(tbMaLop.Text, tbKhoa.Text, tbSiSo.Text, tbNamNhapHoc.Text);
                    dgvHC.DataSource = dtSV;
                    dgvHC.RefreshEdit();
                }

            }
            else if (flag == "edit")
            {
                if (checkData())
                {
                    dtSV.Rows[index][0] = tbMaLop.Text;
                    dtSV.Rows[index][1] = tbKhoa.Text;
                    dtSV.Rows[index][2] = tbSiSo.Text;
                    dtSV.Rows[index][3] = tbNamNhapHoc.Text;
                    dgvHC.DataSource = dtSV;
                    dgvHC.RefreshEdit();
                }
            }
        }
        public bool checkData()
        {
            if (string.IsNullOrEmpty(tbMaLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên Lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaLop.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbKhoa.Text))
            {
                MessageBox.Show("Bạn chưa nhập Khoa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbKhoa.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbSiSo.Text))
            {
                MessageBox.Show("Bạn chưa nhập Sĩ số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSiSo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbNamNhapHoc.Text))
            {
                MessageBox.Show("Bạn chưa nhập Năm Học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNamNhapHoc.Focus();
                return false;
            }
            return true;
        }

        private void dgvHC_SelectionChanged(object sender, EventArgs e)
        {
            index = dgvHC.CurrentCell == null ? -1 : dgvHC.CurrentCell.RowIndex;
            if (index != -1)
            {
                tbMaLop.Text = dgvHC.Rows[index].Cells[0].Value.ToString();
                tbKhoa.Text = dgvHC.Rows[index].Cells[1].Value.ToString();
                tbSiSo.Text = dgvHC.Rows[index].Cells[2].Value.ToString();
                tbNamNhapHoc.Text = dgvHC.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = "add";

            tbMaLop.Text = "";
            tbKhoa.Text = "";
            tbSiSo.Text = "";
            tbNamNhapHoc.Text = "";

        }
    }
}

