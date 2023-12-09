using HKT_Team.BusinessLayer;

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
    public partial class UC_QLSV : UserControl
    {
        string flag;
        DataTable dtSV;
        int index;
        public UC_QLSV()
        {
            InitializeComponent();

            dtSV = createTable();

        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHs");
            dt.Columns.Add("HoTen");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Lop");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh");
            return dt;
        }

        private void cbbMaLopHC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (flag == "add")
            {
                if (checkData())
                {
                    dtSV.Rows.Add(tbMaSV.Text, tbHoTen.Text, tbDiaChi.Text, tbSoDt.Text, tbLop.Text, tbGioiTinh.Text, tbNgaysinh.Text);
                    dgvSV.DataSource = dtSV;
                    dgvSV.RefreshEdit();
                }

            }
            else if (flag == "edit")
            {
                if (checkData())
                {
                    dtSV.Rows[index][0] = tbMaSV.Text;
                    dtSV.Rows[index][1] = tbHoTen.Text;
                    dtSV.Rows[index][2] = tbDiaChi.Text;
                    dtSV.Rows[index][3] = tbSoDt.Text;
                    dtSV.Rows[index][4] = tbLop.Text;
                    dtSV.Rows[index][5] = tbGioiTinh.Text;
                    dtSV.Rows[index][6] = tbNgaysinh.Text;
                    dgvSV.DataSource = dtSV;
                    dgvSV.RefreshEdit();
                }
            }
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(tbMaSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbNgaysinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập Ngày Sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNgaysinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbHoTen.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập Địa Chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDiaChi.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(tbGioiTinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập giới Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbGioiTinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbLop.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbSoDt.Text))
            {
                MessageBox.Show("Bạn chưa nhập số ĐT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSoDt.Focus();
                return false;
            }
            return true;


        }


        private void dgvSV_SelectionChanged(object sender, EventArgs e)
        {

            index = dgvSV.CurrentCell == null ? -1 : dgvSV.CurrentCell.RowIndex;
            if (index != -1)
            {
                tbMaSV.Text = dgvSV.Rows[index].Cells[0].Value.ToString();
                tbHoTen.Text = dgvSV.Rows[index].Cells[1].Value.ToString();
                tbDiaChi.Text = dgvSV.Rows[index].Cells[2].Value.ToString();
                tbSoDt.Text = dgvSV.Rows[index].Cells[3].Value.ToString();
                tbLop.Text = dgvSV.Rows[index].Cells[4].Value.ToString();
                tbGioiTinh.Text = dgvSV.Rows[index].Cells[5].Value.ToString();
                tbNgaysinh.Text = dgvSV.Rows[index].Cells[6].Value.ToString();
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = "edit";

            dtSV.Rows[index][0] = tbMaSV.Text;
            dtSV.Rows[index][1] = tbHoTen.Text;
            dtSV.Rows[index][2] = tbDiaChi.Text;
            dtSV.Rows[index][3] = tbSoDt.Text;
            dtSV.Rows[index][4] = tbLop.Text;
            dtSV.Rows[index][5] = tbGioiTinh.Text;
            dtSV.Rows[index][6] = tbNgaysinh.Text;
            dgvSV.DataSource = dtSV;
            dgvSV.RefreshEdit();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tên sinh viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtSV.Rows.RemoveAt(index);
                dgvSV.DataSource = dtSV;
                dgvSV.RefreshEdit();
            }
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            flag = "add";
            tbMaSV.Text = "";
            tbHoTen.Text = "";
            tbDiaChi.Text = "";
            tbSoDt.Text = "";
            tbLop.Text = "";
            tbGioiTinh.Text = "";
            tbNgaysinh.Text = "";

        }
    }
}
