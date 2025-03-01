namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    partial class UserControlPhongBan
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
            this.lsvPhongBan = new MaterialSkin.Controls.MaterialListView();
            this.colMaPB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmQuanLyPhongBan = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolThem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSua = new System.Windows.Forms.ToolStripMenuItem();
            this.toolXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            this.cmQuanLyPhongBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm Kiếm";
            // 
            // lsvPhongBan
            // 
            this.lsvPhongBan.AutoSizeTable = false;
            this.lsvPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsvPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvPhongBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPB,
            this.colTenPB});
            this.lsvPhongBan.Depth = 0;
            this.lsvPhongBan.FullRowSelect = true;
            this.lsvPhongBan.HideSelection = false;
            this.lsvPhongBan.Location = new System.Drawing.Point(3, 97);
            this.lsvPhongBan.MinimumSize = new System.Drawing.Size(200, 100);
            this.lsvPhongBan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsvPhongBan.MouseState = MaterialSkin.MouseState.OUT;
            this.lsvPhongBan.Name = "lsvPhongBan";
            this.lsvPhongBan.OwnerDraw = true;
            this.lsvPhongBan.Size = new System.Drawing.Size(558, 284);
            this.lsvPhongBan.TabIndex = 7;
            this.lsvPhongBan.UseCompatibleStateImageBehavior = false;
            this.lsvPhongBan.View = System.Windows.Forms.View.Details;
            // 
            // colMaPB
            // 
            this.colMaPB.Text = "Mã Phòng Ban";
            this.colMaPB.Width = 161;
            // 
            // colTenPB
            // 
            this.colTenPB.Text = "Tên Phòng Ban";
            this.colTenPB.Width = 170;
            // 
            // cmQuanLyPhongBan
            // 
            this.cmQuanLyPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmQuanLyPhongBan.Depth = 0;
            this.cmQuanLyPhongBan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmQuanLyPhongBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThem,
            this.toolSua,
            this.toolXoa});
            this.cmQuanLyPhongBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmQuanLyPhongBan.Name = "contextMenuStrip1";
            this.cmQuanLyPhongBan.Size = new System.Drawing.Size(116, 76);
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
            this.tbTimKiem.Location = new System.Drawing.Point(100, 21);
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
            // UserControlPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ContextMenuStrip = this.cmQuanLyPhongBan;
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.lsvPhongBan);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "UserControlPhongBan";
            this.Size = new System.Drawing.Size(541, 270);
            this.Load += new System.EventHandler(this.UserControlPhongBan_Load);
            this.cmQuanLyPhongBan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialListView lsvPhongBan;
        private System.Windows.Forms.ColumnHeader colMaPB;
        private System.Windows.Forms.ColumnHeader colTenPB;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmQuanLyPhongBan;
        private System.Windows.Forms.ToolStripMenuItem toolThem;
        private System.Windows.Forms.ToolStripMenuItem toolSua;
        private System.Windows.Forms.ToolStripMenuItem toolXoa;
        private MaterialSkin.Controls.MaterialTextBox tbTimKiem;
    }
}
