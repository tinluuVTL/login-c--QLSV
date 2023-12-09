namespace HKT_Team
{
    partial class UC_QLLH
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHC = new System.Windows.Forms.DataGridView();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbTimTheoKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTimKiemTheoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNamNhapHoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaLop = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tbSiSo = new System.Windows.Forms.TextBox();
            this.tbKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHC)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHC
            // 
            this.dgvHC.AllowUserToAddRows = false;
            this.dgvHC.AllowUserToDeleteRows = false;
            this.dgvHC.ColumnHeadersHeight = 29;
            this.dgvHC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLop,
            this.colKhoa,
            this.ColSiSo,
            this.colNamHoc});
            this.dgvHC.Location = new System.Drawing.Point(418, 142);
            this.dgvHC.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHC.Name = "dgvHC";
            this.dgvHC.ReadOnly = true;
            this.dgvHC.RowHeadersVisible = false;
            this.dgvHC.RowHeadersWidth = 51;
            this.dgvHC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHC.Size = new System.Drawing.Size(1037, 517);
            this.dgvHC.TabIndex = 11;
            // 
            // colLop
            // 
            this.colLop.DataPropertyName = "MaLop";
            this.colLop.HeaderText = "Tên Lớp";
            this.colLop.MinimumWidth = 6;
            this.colLop.Name = "colLop";
            this.colLop.ReadOnly = true;
            this.colLop.Width = 250;
            // 
            // colKhoa
            // 
            this.colKhoa.DataPropertyName = "Khoa";
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.MinimumWidth = 6;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.ReadOnly = true;
            this.colKhoa.Width = 250;
            // 
            // ColSiSo
            // 
            this.ColSiSo.DataPropertyName = "SiSo";
            this.ColSiSo.HeaderText = "Sĩ Só";
            this.ColSiSo.MinimumWidth = 6;
            this.ColSiSo.Name = "ColSiSo";
            this.ColSiSo.ReadOnly = true;
            this.ColSiSo.Width = 250;
            // 
            // colNamHoc
            // 
            this.colNamHoc.DataPropertyName = "NamHoc";
            this.colNamHoc.HeaderText = "Năm Học";
            this.colNamHoc.MinimumWidth = 6;
            this.colNamHoc.Name = "colNamHoc";
            this.colNamHoc.ReadOnly = true;
            this.colNamHoc.Width = 250;
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTatCa.Location = new System.Drawing.Point(901, 23);
            this.btnTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(100, 43);
            this.btnTatCa.TabIndex = 6;
            this.btnTatCa.Text = "Tất Cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTatCa);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cbbTimTheoKhoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbTimKiemTheoTen);
            this.panel1.Location = new System.Drawing.Point(418, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 71);
            this.panel1.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTimKiem.Location = new System.Drawing.Point(763, 23);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 43);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cbbTimTheoKhoa
            // 
            this.cbbTimTheoKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimTheoKhoa.FormattingEnabled = true;
            this.cbbTimTheoKhoa.Location = new System.Drawing.Point(477, 31);
            this.cbbTimTheoKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTimTheoKhoa.Name = "cbbTimTheoKhoa";
            this.cbbTimTheoKhoa.Size = new System.Drawing.Size(252, 28);
            this.cbbTimTheoKhoa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, -2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm kiếm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbTimKiemTheoTen
            // 
            this.tbTimKiemTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiemTheoTen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTimKiemTheoTen.Location = new System.Drawing.Point(37, 28);
            this.tbTimKiemTheoTen.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimKiemTheoTen.Name = "tbTimKiemTheoTen";
            this.tbTimKiemTheoTen.Size = new System.Drawing.Size(275, 26);
            this.tbTimKiemTheoTen.TabIndex = 0;
            this.tbTimKiemTheoTen.Text = "nhập mã lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thông tin chi tiết";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 96);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Khoa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(255, 386);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 14;
            // 
            // tbNamNhapHoc
            // 
            this.tbNamNhapHoc.Location = new System.Drawing.Point(172, 220);
            this.tbNamNhapHoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbNamNhapHoc.Name = "tbNamNhapHoc";
            this.tbNamNhapHoc.Size = new System.Drawing.Size(191, 22);
            this.tbNamNhapHoc.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Năm Nhập Học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Sĩ Số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lớp";
            // 
            // tbMaLop
            // 
            this.tbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaLop.Location = new System.Drawing.Point(117, 23);
            this.tbMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaLop.Name = "tbMaLop";
            this.tbMaLop.Size = new System.Drawing.Size(245, 26);
            this.tbMaLop.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.tbSiSo);
            this.panel2.Controls.Add(this.tbKhoa);
            this.panel2.Controls.Add(this.tbNamNhapHoc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbMaLop);
            this.panel2.Location = new System.Drawing.Point(13, 159);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 516);
            this.panel2.TabIndex = 10;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(226, 386);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 45);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(23, 386);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 45);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(226, 311);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbSiSo
            // 
            this.tbSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSiSo.Location = new System.Drawing.Point(118, 160);
            this.tbSiSo.Margin = new System.Windows.Forms.Padding(4);
            this.tbSiSo.Name = "tbSiSo";
            this.tbSiSo.Size = new System.Drawing.Size(245, 26);
            this.tbSiSo.TabIndex = 37;
            // 
            // tbKhoa
            // 
            this.tbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKhoa.Location = new System.Drawing.Point(117, 96);
            this.tbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.tbKhoa.Name = "tbKhoa";
            this.tbKhoa.Size = new System.Drawing.Size(245, 26);
            this.tbKhoa.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(550, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản lý Lớp Học";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 42;
            this.button1.Text = "Nạp Lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvHC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "UC_QLLH";
            this.Size = new System.Drawing.Size(1469, 688);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbTimTheoKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTimKiemTheoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNamNhapHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaLop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSiSo;
        private System.Windows.Forms.TextBox tbKhoa;
        private System.Windows.Forms.DataGridView dgvHC;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamHoc;
        private System.Windows.Forms.Button button1;
    }
}
