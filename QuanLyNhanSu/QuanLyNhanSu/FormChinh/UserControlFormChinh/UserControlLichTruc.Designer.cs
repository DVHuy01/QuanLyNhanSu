namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    partial class UserControlLichTruc
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
            this.tbTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvLichTruc = new MaterialSkin.Controls.MaterialListView();
            this.colMaLich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenCa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chbSang = new MaterialSkin.Controls.MaterialCheckbox();
            this.chChieu = new MaterialSkin.Controls.MaterialCheckbox();
            this.colTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChuThich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.AnimateReadOnly = false;
            this.tbTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTimKiem.Depth = 0;
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTimKiem.Hint = "Nhập thông tin cần tìm";
            this.tbTimKiem.LeadingIcon = null;
            this.tbTimKiem.Location = new System.Drawing.Point(101, 21);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimKiem.MaxLength = 50;
            this.tbTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTimKiem.Multiline = false;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(266, 50);
            this.tbTimKiem.TabIndex = 13;
            this.tbTimKiem.Text = "";
            this.tbTimKiem.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tìm Kiếm";
            // 
            // lsvLichTruc
            // 
            this.lsvLichTruc.AutoSizeTable = false;
            this.lsvLichTruc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsvLichTruc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvLichTruc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaLich,
            this.colNgay,
            this.colTenNV,
            this.colTenCV,
            this.colTenCa,
            this.colTrangThai,
            this.colChuThich});
            this.lsvLichTruc.Depth = 0;
            this.lsvLichTruc.FullRowSelect = true;
            this.lsvLichTruc.HideSelection = false;
            this.lsvLichTruc.Location = new System.Drawing.Point(3, 84);
            this.lsvLichTruc.MinimumSize = new System.Drawing.Size(200, 100);
            this.lsvLichTruc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsvLichTruc.MouseState = MaterialSkin.MouseState.OUT;
            this.lsvLichTruc.Name = "lsvLichTruc";
            this.lsvLichTruc.OwnerDraw = true;
            this.lsvLichTruc.Size = new System.Drawing.Size(922, 346);
            this.lsvLichTruc.TabIndex = 14;
            this.lsvLichTruc.UseCompatibleStateImageBehavior = false;
            this.lsvLichTruc.View = System.Windows.Forms.View.Details;
            // 
            // colMaLich
            // 
            this.colMaLich.Text = "Mã Lịch";
            this.colMaLich.Width = 101;
            // 
            // colNgay
            // 
            this.colNgay.Text = "Ngày";
            this.colNgay.Width = 106;
            // 
            // colTenNV
            // 
            this.colTenNV.Text = "Tên nhân viên";
            this.colTenNV.Width = 153;
            // 
            // colTenCV
            // 
            this.colTenCV.Text = "Tên chức vụ";
            this.colTenCV.Width = 162;
            // 
            // colTenCa
            // 
            this.colTenCa.Text = "Tên ca";
            this.colTenCa.Width = 116;
            // 
            // chbSang
            // 
            this.chbSang.AutoSize = true;
            this.chbSang.Depth = 0;
            this.chbSang.Location = new System.Drawing.Point(395, 26);
            this.chbSang.Margin = new System.Windows.Forms.Padding(0);
            this.chbSang.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbSang.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbSang.Name = "chbSang";
            this.chbSang.ReadOnly = false;
            this.chbSang.Ripple = true;
            this.chbSang.Size = new System.Drawing.Size(99, 37);
            this.chbSang.TabIndex = 15;
            this.chbSang.Text = " Ca Sáng";
            this.chbSang.UseVisualStyleBackColor = true;
            // 
            // chChieu
            // 
            this.chChieu.AutoSize = true;
            this.chChieu.Depth = 0;
            this.chChieu.Location = new System.Drawing.Point(532, 26);
            this.chChieu.Margin = new System.Windows.Forms.Padding(0);
            this.chChieu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chChieu.MouseState = MaterialSkin.MouseState.HOVER;
            this.chChieu.Name = "chChieu";
            this.chChieu.ReadOnly = false;
            this.chChieu.Ripple = true;
            this.chChieu.Size = new System.Drawing.Size(98, 37);
            this.chChieu.TabIndex = 16;
            this.chChieu.Text = "Ca Chiều";
            this.chChieu.UseVisualStyleBackColor = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Text = "Trạng Thái";
            this.colTrangThai.Width = 142;
            // 
            // colChuThich
            // 
            this.colChuThich.Text = "Ghi Chú";
            this.colChuThich.Width = 119;
            // 
            // UserControlLichTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.chChieu);
            this.Controls.Add(this.chbSang);
            this.Controls.Add(this.lsvLichTruc);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "UserControlLichTruc";
            this.Size = new System.Drawing.Size(928, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tbTimKiem;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialListView lsvLichTruc;
        private System.Windows.Forms.ColumnHeader colMaLich;
        private System.Windows.Forms.ColumnHeader colNgay;
        private System.Windows.Forms.ColumnHeader colTenNV;
        private System.Windows.Forms.ColumnHeader colTenCV;
        private System.Windows.Forms.ColumnHeader colTenCa;
        private MaterialSkin.Controls.MaterialCheckbox chbSang;
        private MaterialSkin.Controls.MaterialCheckbox chChieu;
        private System.Windows.Forms.ColumnHeader colTrangThai;
        private System.Windows.Forms.ColumnHeader colChuThich;
    }
}
