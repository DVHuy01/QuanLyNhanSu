namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    partial class UserControlChucVu
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
            this.lsvChucVu = new MaterialSkin.Controls.MaterialListView();
            this.colMaCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenCV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmQuanLyChucVu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolThem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSua = new System.Windows.Forms.ToolStripMenuItem();
            this.toolXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            this.colHeSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmQuanLyChucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Kiếm";
            // 
            // lsvChucVu
            // 
            this.lsvChucVu.AutoSizeTable = false;
            this.lsvChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsvChucVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvChucVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaCV,
            this.colTenCV,
            this.colHeSoLuong});
            this.lsvChucVu.Depth = 0;
            this.lsvChucVu.FullRowSelect = true;
            this.lsvChucVu.HideSelection = false;
            this.lsvChucVu.Location = new System.Drawing.Point(3, 84);
            this.lsvChucVu.MinimumSize = new System.Drawing.Size(200, 100);
            this.lsvChucVu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsvChucVu.MouseState = MaterialSkin.MouseState.OUT;
            this.lsvChucVu.Name = "lsvChucVu";
            this.lsvChucVu.OwnerDraw = true;
            this.lsvChucVu.Size = new System.Drawing.Size(637, 218);
            this.lsvChucVu.TabIndex = 7;
            this.lsvChucVu.UseCompatibleStateImageBehavior = false;
            this.lsvChucVu.View = System.Windows.Forms.View.Details;
            // 
            // colMaCV
            // 
            this.colMaCV.Text = "Mã Chức Vụ";
            this.colMaCV.Width = 189;
            // 
            // colTenCV
            // 
            this.colTenCV.Text = "Tên Chức Vụ";
            this.colTenCV.Width = 159;
            // 
            // cmQuanLyChucVu
            // 
            this.cmQuanLyChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmQuanLyChucVu.Depth = 0;
            this.cmQuanLyChucVu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmQuanLyChucVu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThem,
            this.toolSua,
            this.toolXoa});
            this.cmQuanLyChucVu.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmQuanLyChucVu.Name = "contextMenuStrip1";
            this.cmQuanLyChucVu.Size = new System.Drawing.Size(116, 76);
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
            // txtTimKiem
            // 
            this.txtTimKiem.AnimateReadOnly = false;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimKiem.Hint = "Nhập thông tin cần tìm";
            this.txtTimKiem.LeadingIcon = null;
            this.txtTimKiem.Location = new System.Drawing.Point(101, 13);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.MaxLength = 50;
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(266, 50);
            this.txtTimKiem.TabIndex = 11;
            this.txtTimKiem.Text = "";
            this.txtTimKiem.TrailingIcon = null;
            // 
            // colHeSoLuong
            // 
            this.colHeSoLuong.Text = "Hệ Số Lương";
            // 
            // UserControlChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ContextMenuStrip = this.cmQuanLyChucVu;
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lsvChucVu);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "UserControlChucVu";
            this.Size = new System.Drawing.Size(643, 305);
            this.Load += new System.EventHandler(this.UserControlChucVu_Load);
            this.cmQuanLyChucVu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialListView lsvChucVu;
        private System.Windows.Forms.ColumnHeader colMaCV;
        private System.Windows.Forms.ColumnHeader colTenCV;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmQuanLyChucVu;
        private System.Windows.Forms.ToolStripMenuItem toolThem;
        private System.Windows.Forms.ToolStripMenuItem toolSua;
        private System.Windows.Forms.ToolStripMenuItem toolXoa;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private System.Windows.Forms.ColumnHeader colHeSoLuong;
    }
}
