using HKT_Team.BusinessLayer;
using HKT_Team.DataLayer;
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
    public partial class UC_QLUser : UserControl
    {
        public UC_QLUser()
        {
            InitializeComponent();

        }

        BLLUser bd;

        string err = string.Empty;
        private void HienThiDanhSachUsers()
        {

            var bindingList = new BindingList<User>(ClsMain.users);
            var source = new BindingSource(bindingList, null);
            dgvTaiKhoan.DataSource = source;
        }
        User user = null;
        int index = -1;
        public bool isAdd = false;

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvTaiKhoan.Rows.Count > 0)
            {
                user = new User()
                {
                    ID = Convert.ToInt32(dgvTaiKhoan.CurrentRow.Cells["colID"].Value.ToString()),
                   
                    TaiKhoan = dgvTaiKhoan.CurrentRow.Cells["colTaiKhoan"].Value.ToString(),
                    MatKhau = dgvTaiKhoan.CurrentRow.Cells["colMatKhau"].Value.ToString(),
                    HoVaTen = dgvTaiKhoan.CurrentRow.Cells["colHoVaTen"].Value.ToString(),
                    LoaiUser = dgvTaiKhoan.CurrentRow.Cells["colLoaiUser"].Value.ToString(),
                    NhoMatKhau = Convert.ToBoolean(dgvTaiKhoan.CurrentRow.Cells["colNhoMatKhau"].Value.ToString())
                };
                index = dgvTaiKhoan.CurrentRow.Index;
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            HienThiDanhSachUsers();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
                if (user != null)
                {
                    ClsMain.users.RemoveAt(index);
                   
                    HienThiDanhSachUsers();
                }
            
           
            else
            {
                MessageBox.Show("Chưa chọn tài khoản cần xóa!\nXin vui lòng chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
                {
                    if (!string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        if (!string.IsNullOrEmpty(txtHoVaTen.Text))
                        {
                            user = new User()
                            {
                                ID = Convert.ToInt32(txtID.Text),
                                TaiKhoan = txtTaiKhoan.Text,
                                MatKhau = txtMatKhau.Text,
                                HoVaTen = txtHoVaTen.Text,
                                LoaiUser=cbQuyen.Text,
                                NhoMatKhau = ckbNhoMatKhau.Checked
                            };
                            if (isAdd)
                            {
                                ClsMain.users.Add(user);
                            }
                            else
                            {
                                //sua
                                UpdateUser();
                            }

                         
                           
                            
                        }
                    }
                }
            }

            HienThiDanhSachUsers();
        }
        private void UpdateUser()
        {
            foreach (User item in ClsMain.users)
            {
                if (item.ID == user.ID)
                {
                    item.TaiKhoan = user.TaiKhoan;
                    item.MatKhau = user.MatKhau;
                    item.HoVaTen = user.HoVaTen;
                    item.LoaiUser= user.LoaiUser;
                    item.NhoMatKhau = user.NhoMatKhau;
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
