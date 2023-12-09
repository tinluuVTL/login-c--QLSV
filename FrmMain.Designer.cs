namespace HKT_Team
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLSV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLDSL = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QuanLyTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Dong = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateTimeOffsetEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(107, 111, 107, 111);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_DangXuat,
            this.btn_DangNhap,
            this.btn_QLSV,
            this.btn_QLDSL,
            this.btn_PhucHoi,
            this.btn_QuanLyTaiKhoan,
            this.btn_Xoa,
            this.btn_Dong,
            this.barButtonItem1,
            this.barEditItem1,
            this.barEditItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 1174;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateTimeOffsetEdit1,
            this.repositoryItemImageEdit1});
            this.ribbonControl1.Size = new System.Drawing.Size(1142, 201);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng Xuất";
            this.btn_DangXuat.Id = 2;
            this.btn_DangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.Image")));
            this.btn_DangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.LargeImage")));
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Caption = "Đăng Nhập";
            this.btn_DangNhap.Id = 3;
            this.btn_DangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.ImageOptions.Image")));
            this.btn_DangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.ImageOptions.LargeImage")));
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btn_QLSV
            // 
            this.btn_QLSV.Caption = "QuanLySinhVien";
            this.btn_QLSV.Id = 4;
            this.btn_QLSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QLSV.ImageOptions.Image")));
            this.btn_QLSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QLSV.ImageOptions.LargeImage")));
            this.btn_QLSV.Name = "btn_QLSV";
            this.btn_QLSV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_QLSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btn_QLDSL
            // 
            this.btn_QLDSL.Caption = "QuanLyDanhSachLop";
            this.btn_QLDSL.Id = 5;
            this.btn_QLDSL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QLDSL.ImageOptions.Image")));
            this.btn_QLDSL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QLDSL.ImageOptions.LargeImage")));
            this.btn_QLDSL.Name = "btn_QLDSL";
            this.btn_QLDSL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QLDSL_ItemClick);
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Caption = "Phục Hồi";
            this.btn_PhucHoi.Id = 6;
            this.btn_PhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_PhucHoi.ImageOptions.Image")));
            this.btn_PhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_PhucHoi.ImageOptions.LargeImage")));
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_QuanLyTaiKhoan
            // 
            this.btn_QuanLyTaiKhoan.Caption = "QuanLyTaiKhoan";
            this.btn_QuanLyTaiKhoan.Id = 7;
            this.btn_QuanLyTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyTaiKhoan.ImageOptions.Image")));
            this.btn_QuanLyTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QuanLyTaiKhoan.ImageOptions.LargeImage")));
            this.btn_QuanLyTaiKhoan.Name = "btn_QuanLyTaiKhoan";
            this.btn_QuanLyTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QuanLyTaiKhoan_ItemClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.Id = 9;
            this.btn_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.ImageOptions.Image")));
            this.btn_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.ImageOptions.LargeImage")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Caption = "Đóng tất cả";
            this.btn_Dong.Id = 10;
            this.btn_Dong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dong.ImageOptions.Image")));
            this.btn_Dong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Dong.ImageOptions.LargeImage")));
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Dong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Dong_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "time";
            this.barEditItem1.Edit = this.repositoryItemDateTimeOffsetEdit1;
            this.barEditItem1.Id = 12;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemDateTimeOffsetEdit1
            // 
            this.repositoryItemDateTimeOffsetEdit1.AutoHeight = false;
            this.repositoryItemDateTimeOffsetEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateTimeOffsetEdit1.Name = "repositoryItemDateTimeOffsetEdit1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = global::HKT_Team.Properties.Resources.start;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hê thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_PhucHoi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Login";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage2.ImageOptions.Image = global::HKT_Team.Properties.Resources.thong_tin;
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tác Vụ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_QLSV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Sinh Viên";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_QLDSL);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Lớp";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_QuanLyTaiKhoan);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tài Khoản";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_Xoa);
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_Dong);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Đóng form";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Thống Kê";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 670);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1142, 30);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 201);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(1142, 469);
            this.xtraTabControl1.TabIndex = 2;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(977, 362);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(977, 362);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(977, 362);
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl2.Location = new System.Drawing.Point(1, 1);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage4;
            this.xtraTabControl2.Size = new System.Drawing.Size(977, 385);
            this.xtraTabControl2.TabIndex = 0;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage4,
            this.xtraTabPage5,
            this.xtraTabPage6});
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(975, 360);
            this.xtraTabPage4.Text = "xtraTabPage4";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(975, 360);
            this.xtraTabPage5.Text = "xtraTabPage5";
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.AutoScroll = true;
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(975, 360);
            this.xtraTabPage6.Text = "xtraTabPage6";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemImageEdit1;
            this.barEditItem2.Id = 13;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 700);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.BarButtonItem btn_DangNhap;
        private DevExpress.XtraBars.BarButtonItem btn_QLSV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_QLDSL;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraBars.BarButtonItem btn_QuanLyTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_Dong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
    }
}