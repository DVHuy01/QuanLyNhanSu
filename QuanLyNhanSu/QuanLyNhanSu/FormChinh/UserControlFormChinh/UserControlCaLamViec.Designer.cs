namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    partial class UserControlCaLamViec
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
            this.lsvCaLamViec = new MaterialSkin.Controls.MaterialListView();
            this.colMaCa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenCa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioBatDau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioKetThuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmQuanLyCaLamViec = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolThem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSua = new System.Windows.Forms.ToolStripMenuItem();
            this.toolXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            this.cmQuanLyCaLamViec.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Kiếm";
            // 
            // lsvCaLamViec
            // 
            this.lsvCaLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvCaLamViec.AutoSizeTable = false;
            this.lsvCaLamViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsvCaLamViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvCaLamViec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaCa,
            this.colTenCa,
            this.colGioBatDau,
            this.colGioKetThuc});
            this.lsvCaLamViec.Depth = 0;
            this.lsvCaLamViec.FullRowSelect = true;
            this.lsvCaLamViec.HideSelection = false;
            this.lsvCaLamViec.Location = new System.Drawing.Point(3, 85);
            this.lsvCaLamViec.MinimumSize = new System.Drawing.Size(200, 100);
            this.lsvCaLamViec.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsvCaLamViec.MouseState = MaterialSkin.MouseState.OUT;
            this.lsvCaLamViec.Name = "lsvCaLamViec";
            this.lsvCaLamViec.OwnerDraw = true;
            this.lsvCaLamViec.Size = new System.Drawing.Size(783, 251);
            this.lsvCaLamViec.TabIndex = 7;
            this.lsvCaLamViec.UseCompatibleStateImageBehavior = false;
            this.lsvCaLamViec.View = System.Windows.Forms.View.Details;
            // 
            // colMaCa
            // 
            this.colMaCa.Text = "Mã Ca";
            this.colMaCa.Width = 118;
            // 
            // colTenCa
            // 
            this.colTenCa.Text = "Tên Ca";
            this.colTenCa.Width = 121;
            // 
            // colGioBatDau
            // 
            this.colGioBatDau.Text = "Giờ Bắt Đầu";
            this.colGioBatDau.Width = 133;
            // 
            // colGioKetThuc
            // 
            this.colGioKetThuc.Text = "Giờ Kết Thúc";
            this.colGioKetThuc.Width = 139;
            // 
            // cmQuanLyCaLamViec
            // 
            this.cmQuanLyCaLamViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmQuanLyCaLamViec.Depth = 0;
            this.cmQuanLyCaLamViec.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmQuanLyCaLamViec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThem,
            this.toolSua,
            this.toolXoa});
            this.cmQuanLyCaLamViec.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmQuanLyCaLamViec.Name = "contextMenuStrip1";
            this.cmQuanLyCaLamViec.Size = new System.Drawing.Size(116, 76);
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
            this.tbTimKiem.Location = new System.Drawing.Point(99, 15);
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
            // UserControlCaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ContextMenuStrip = this.cmQuanLyCaLamViec;
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.lsvCaLamViec);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "UserControlCaLamViec";
            this.Size = new System.Drawing.Size(798, 339);
            this.Load += new System.EventHandler(this.UserControlCaLamViec_Load);
            this.cmQuanLyCaLamViec.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialListView lsvCaLamViec;
        private System.Windows.Forms.ColumnHeader colMaCa;
        private System.Windows.Forms.ColumnHeader colTenCa;
        private System.Windows.Forms.ColumnHeader colGioBatDau;
        private System.Windows.Forms.ColumnHeader colGioKetThuc;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmQuanLyCaLamViec;
        private System.Windows.Forms.ToolStripMenuItem toolThem;
        private System.Windows.Forms.ToolStripMenuItem toolSua;
        private System.Windows.Forms.ToolStripMenuItem toolXoa;
        private MaterialSkin.Controls.MaterialTextBox tbTimKiem;
    }
}
