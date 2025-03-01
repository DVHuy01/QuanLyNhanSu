namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    partial class UserControlNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhongBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmQuanLyNhanVien = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolThem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSua = new System.Windows.Forms.ToolStripMenuItem();
            this.toolXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            this.toolTinhTien = new System.Windows.Forms.ToolStripMenuItem();
            this.cmQuanLyNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tìm Kiếm";
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNV,
            this.colTenNV,
            this.colGioiTinh,
            this.colSoDienThoai,
            this.colChucVu,
            this.colPhongBan});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(3, 90);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(831, 233);
            this.materialListView1.TabIndex = 11;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã Nhân Viên";
            this.colMaNV.Width = 128;
            // 
            // colTenNV
            // 
            this.colTenNV.Text = "Tên Nhân Viên";
            this.colTenNV.Width = 126;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới Tính";
            this.colGioiTinh.Width = 111;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.Text = "Số điện thoại";
            this.colSoDienThoai.Width = 137;
            // 
            // colChucVu
            // 
            this.colChucVu.Text = "Chức Vụ";
            this.colChucVu.Width = 106;
            // 
            // colPhongBan
            // 
            this.colPhongBan.Text = "Phòng Ban";
            this.colPhongBan.Width = 109;
            // 
            // cmQuanLyNhanVien
            // 
            this.cmQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmQuanLyNhanVien.Depth = 0;
            this.cmQuanLyNhanVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmQuanLyNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThem,
            this.toolSua,
            this.toolXoa,
            this.toolTinhTien});
            this.cmQuanLyNhanVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmQuanLyNhanVien.Name = "contextMenuStrip1";
            this.cmQuanLyNhanVien.Size = new System.Drawing.Size(139, 100);
            // 
            // toolThem
            // 
            this.toolThem.Name = "toolThem";
            this.toolThem.Size = new System.Drawing.Size(138, 24);
            this.toolThem.Text = "Thêm";
            this.toolThem.Click += new System.EventHandler(this.toolThem_Click);
            // 
            // toolSua
            // 
            this.toolSua.Name = "toolSua";
            this.toolSua.Size = new System.Drawing.Size(138, 24);
            this.toolSua.Text = "Sửa";
            this.toolSua.Click += new System.EventHandler(this.toolSua_Click);
            // 
            // toolXoa
            // 
            this.toolXoa.Name = "toolXoa";
            this.toolXoa.Size = new System.Drawing.Size(138, 24);
            this.toolXoa.Text = "Xoá";
            this.toolXoa.Click += new System.EventHandler(this.toolXoa_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.AnimateReadOnly = false;
            this.tbTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTimKiem.Depth = 0;
            this.tbTimKiem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTimKiem.Hint = "Nhập thông tin cần tìm";
            this.tbTimKiem.LeadingIcon = null;
            this.tbTimKiem.Location = new System.Drawing.Point(97, 20);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimKiem.MaxLength = 50;
            this.tbTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTimKiem.Multiline = false;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(266, 50);
            this.tbTimKiem.TabIndex = 12;
            this.tbTimKiem.Text = "";
            this.tbTimKiem.TrailingIcon = null;
            // 
            // toolTinhTien
            // 
            this.toolTinhTien.Name = "toolTinhTien";
            this.toolTinhTien.Size = new System.Drawing.Size(138, 24);
            this.toolTinhTien.Text = "Tính Tiền";
            // 
            // UserControlNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ContextMenuStrip = this.cmQuanLyNhanVien;
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "UserControlNhanVien";
            this.Size = new System.Drawing.Size(837, 326);
            this.Load += new System.EventHandler(this.UserControlNhanVien_Load);
            this.cmQuanLyNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colTenNV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colSoDienThoai;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmQuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem toolThem;
        private System.Windows.Forms.ToolStripMenuItem toolSua;
        private System.Windows.Forms.ToolStripMenuItem toolXoa;
        private MaterialSkin.Controls.MaterialTextBox tbTimKiem;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.ColumnHeader colPhongBan;
        private System.Windows.Forms.ToolStripMenuItem toolTinhTien;
    }
}
