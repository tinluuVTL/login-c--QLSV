using DevExpress.XtraTab;
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
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_QLSV uC_QuanLySinhVien_Main = new UC_QLSV();
            XtraTabPage xtraTabPage = new XtraTabPage();
            xtraTabPage.Controls.Add(uC_QuanLySinhVien_Main);
            xtraTabPage.Text = "QLSV";
            xtraTabControl1.TabPages.Add(xtraTabPage);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog();
        }

        private void btn_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog();
        }

        private void btn_QLDSL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_QLLH uC_QuanLyDanhSachLop_Main = new UC_QLLH();
            XtraTabPage xtraTabPage = new XtraTabPage();
            xtraTabPage.Controls.Add(uC_QuanLyDanhSachLop_Main);
            xtraTabPage.Text = "QLLopHoc";
            xtraTabControl1.TabPages.Add(xtraTabPage);
        }

        private void xtraTabPage4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_QuanLyTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           UC_QLUser uC_QuanLyTaiKhoan_Main = new UC_QLUser();   
            XtraTabPage xtraTabPage = new XtraTabPage();
            xtraTabPage.Controls.Add(uC_QuanLyTaiKhoan_Main);
            xtraTabPage.Text = " QLTK";
            xtraTabControl1.TabPages.Add(xtraTabPage);  
            
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabControl1.TabPages.Remove(xtraTabControl1.SelectedTabPage);
        }

        private void btn_Dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabControl1.TabPages.Clear();   
        }
    }
}
