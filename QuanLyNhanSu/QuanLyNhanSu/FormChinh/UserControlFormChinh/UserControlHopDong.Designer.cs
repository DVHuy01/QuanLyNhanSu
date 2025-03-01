namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    partial class UserControlHopDong
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
            this.lsvHopDong = new MaterialSkin.Controls.MaterialListView();
            this.colMaHopDong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenHopDong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayKi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThoiHan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmQuanLyHopDong = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolThem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSua = new System.Windows.Forms.ToolStripMenuItem();
            this.toolXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            this.cmQuanLyHopDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm Kiếm";
            // 
            // lsvHopDong
            // 
            this.lsvHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvHopDong.AutoSizeTable = false;
            this.lsvHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsvHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvHopDong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHopDong,
            this.colTenHopDong,
            this.colNgayKi,
            this.colThoiHan,
            this.colLuong,
            this.colTenNV,
            this.colChucVu});
            this.lsvHopDong.Depth = 0;
            this.lsvHopDong.FullRowSelect = true;
            this.lsvHopDong.HideSelection = false;
            this.lsvHopDong.Location = new System.Drawing.Point(19, 88);
            this.lsvHopDong.MinimumSize = new System.Drawing.Size(200, 100);
            this.lsvHopDong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsvHopDong.MouseState = MaterialSkin.MouseState.OUT;
            this.lsvHopDong.Name = "lsvHopDong";
            this.lsvHopDong.OwnerDraw = true;
            this.lsvHopDong.Size = new System.Drawing.Size(872, 224);
            this.lsvHopDong.TabIndex = 9;
            this.lsvHopDong.UseCompatibleStateImageBehavior = false;
            this.lsvHopDong.View = System.Windows.Forms.View.Details;
            // 
            // colMaHopDong
            // 
            this.colMaHopDong.Text = "Mã Hợp Đồng";
            this.colMaHopDong.Width = 131;
            // 
            // colTenHopDong
            // 
            this.colTenHopDong.Text = "Tên Hợp Đồng";
            this.colTenHopDong.Width = 144;
            // 
            // colNgayKi
            // 
            this.colNgayKi.Text = "Ngày Kí";
            this.colNgayKi.Width = 118;
            // 
            // colThoiHan
            // 
            this.colThoiHan.Text = "Thời Hạn";
            this.colThoiHan.Width = 118;
            // 
            // colLuong
            // 
            this.colLuong.Text = "Lương";
            this.colLuong.Width = 106;
            // 
            // colTenNV
            // 
            this.colTenNV.Text = "Tên Nhân Viên";
            this.colTenNV.Width = 143;
            // 
            // colChucVu
            // 
            this.colChucVu.Text = "Chức Vụ";
            this.colChucVu.Width = 91;
            // 
            // cmQuanLyHopDong
            // 
            this.cmQuanLyHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmQuanLyHopDong.Depth = 0;
            this.cmQuanLyHopDong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmQuanLyHopDong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThem,
            this.toolSua,
            this.toolXoa});
            this.cmQuanLyHopDong.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmQuanLyHopDong.Name = "contextMenuStrip1";
            this.cmQuanLyHopDong.Size = new System.Drawing.Size(116, 76);
            // 
            // toolThem
            // 
            this.toolThem.Name = "toolThem";
            this.toolThem.Size = new System.Drawing.Size(115, 24);
            this.toolThem.Text = "Thêm";
            this.toolThem.Click += new System.EventHandler(this.toolThem_Click);
            // 
            // toolSua
            // 
            this.toolSua.Name = "toolSua";
            this.toolSua.Size = new System.Drawing.Size(115, 24);
            this.toolSua.Text = "Sửa";
            this.toolSua.Click += new System.EventHandler(this.toolSua_Click);
            // 
            // toolXoa
            // 
            this.toolXoa.Name = "toolXoa";
            this.toolXoa.Size = new System.Drawing.Size(115, 24);
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
            this.tbTimKiem.Location = new System.Drawing.Point(102, 16);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimKiem.MaxLength = 50;
            this.tbTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTimKiem.Multiline = false;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(266, 50);
            this.tbTimKiem.TabIndex = 11;
            this.tbTimKiem.Text = "";
            this.tbTimKiem.TrailingIcon = null;
            // 
            // UserControlHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ContextMenuStrip = this.cmQuanLyHopDong;
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.lsvHopDong);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "UserControlHopDong";
            this.Size = new System.Drawing.Size(894, 325);
            this.Load += new System.EventHandler(this.UserControlHopDong_Load);
            this.cmQuanLyHopDong.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialListView lsvHopDong;
        private System.Windows.Forms.ColumnHeader colMaHopDong;
        private System.Windows.Forms.ColumnHeader colTenHopDong;
        private System.Windows.Forms.ColumnHeader colNgayKi;
        private System.Windows.Forms.ColumnHeader colThoiHan;
        private System.Windows.Forms.ColumnHeader colLuong;
        private System.Windows.Forms.ColumnHeader colTenNV;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmQuanLyHopDong;
        private System.Windows.Forms.ToolStripMenuItem toolSua;
        private System.Windows.Forms.ToolStripMenuItem toolXoa;
        private MaterialSkin.Controls.MaterialTextBox tbTimKiem;
        private System.Windows.Forms.ToolStripMenuItem toolThem;
        private System.Windows.Forms.ColumnHeader colChucVu;
    }
}
