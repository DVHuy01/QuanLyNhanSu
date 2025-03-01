namespace QuanLyNhanSu.FormChinh
{
    partial class QuanLy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.TabControlQuanLy = new MaterialSkin.Controls.MaterialTabControl();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.userControlNhanVien1 = new QuanLyNhanSu.FormChinh.UserControlFormChinh.UserControlNhanVien();
            this.tabCaLamViec = new System.Windows.Forms.TabPage();
            this.userControlCaLamViec1 = new QuanLyNhanSu.FormChinh.UserControlFormChinh.UserControlCaLamViec();
            this.tabLichTruc = new System.Windows.Forms.TabPage();
            this.userControlLichTruc1 = new QuanLyNhanSu.FormChinh.UserControlFormChinh.UserControlLichTruc();
            this.tabHopDong = new System.Windows.Forms.TabPage();
            this.userControlHopDong1 = new QuanLyNhanSu.FormChinh.UserControlFormChinh.UserControlHopDong();
            this.tabControlIconList = new System.Windows.Forms.ImageList(this.components);
            this.TabControlQuanLy.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            this.tabCaLamViec.SuspendLayout();
            this.tabLichTruc.SuspendLayout();
            this.tabHopDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlQuanLy
            // 
            this.TabControlQuanLy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlQuanLy.Controls.Add(this.tabNhanVien);
            this.TabControlQuanLy.Controls.Add(this.tabCaLamViec);
            this.TabControlQuanLy.Controls.Add(this.tabLichTruc);
            this.TabControlQuanLy.Controls.Add(this.tabHopDong);
            this.TabControlQuanLy.Depth = 0;
            this.TabControlQuanLy.ImageList = this.tabControlIconList;
            this.TabControlQuanLy.Location = new System.Drawing.Point(6, 67);
            this.TabControlQuanLy.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlQuanLy.Multiline = true;
            this.TabControlQuanLy.Name = "TabControlQuanLy";
            this.TabControlQuanLy.SelectedIndex = 0;
            this.TabControlQuanLy.Size = new System.Drawing.Size(913, 337);
            this.TabControlQuanLy.TabIndex = 0;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.userControlNhanVien1);
            this.tabNhanVien.ImageKey = "khanghang.png";
            this.tabNhanVien.Location = new System.Drawing.Point(4, 25);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(905, 308);
            this.tabNhanVien.TabIndex = 0;
            this.tabNhanVien.Text = "Quản lý nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // userControlNhanVien1
            // 
            this.userControlNhanVien1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlNhanVien1.BackColor = System.Drawing.SystemColors.Window;
            this.userControlNhanVien1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControlNhanVien1.Location = new System.Drawing.Point(3, 6);
            this.userControlNhanVien1.Name = "userControlNhanVien1";
            this.userControlNhanVien1.Size = new System.Drawing.Size(896, 302);
            this.userControlNhanVien1.TabIndex = 0;
            // 
            // tabCaLamViec
            // 
            this.tabCaLamViec.Controls.Add(this.userControlCaLamViec1);
            this.tabCaLamViec.ImageKey = "thanhtoan.png";
            this.tabCaLamViec.Location = new System.Drawing.Point(4, 25);
            this.tabCaLamViec.Name = "tabCaLamViec";
            this.tabCaLamViec.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaLamViec.Size = new System.Drawing.Size(905, 308);
            this.tabCaLamViec.TabIndex = 1;
            this.tabCaLamViec.Text = "Ca Làm Việc";
            this.tabCaLamViec.UseVisualStyleBackColor = true;
            // 
            // userControlCaLamViec1
            // 
            this.userControlCaLamViec1.BackColor = System.Drawing.SystemColors.Window;
            this.userControlCaLamViec1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControlCaLamViec1.Location = new System.Drawing.Point(3, 6);
            this.userControlCaLamViec1.Name = "userControlCaLamViec1";
            this.userControlCaLamViec1.Size = new System.Drawing.Size(896, 287);
            this.userControlCaLamViec1.TabIndex = 0;
            // 
            // tabLichTruc
            // 
            this.tabLichTruc.Controls.Add(this.userControlLichTruc1);
            this.tabLichTruc.ImageKey = "cua.png";
            this.tabLichTruc.Location = new System.Drawing.Point(4, 25);
            this.tabLichTruc.Name = "tabLichTruc";
            this.tabLichTruc.Size = new System.Drawing.Size(905, 308);
            this.tabLichTruc.TabIndex = 2;
            this.tabLichTruc.Text = "Quản lý lịch trực";
            this.tabLichTruc.UseVisualStyleBackColor = true;
            // 
            // userControlLichTruc1
            // 
            this.userControlLichTruc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlLichTruc1.BackColor = System.Drawing.SystemColors.Window;
            this.userControlLichTruc1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControlLichTruc1.Location = new System.Drawing.Point(3, 3);
            this.userControlLichTruc1.Name = "userControlLichTruc1";
            this.userControlLichTruc1.Size = new System.Drawing.Size(899, 302);
            this.userControlLichTruc1.TabIndex = 0;
            // 
            // tabHopDong
            // 
            this.tabHopDong.Controls.Add(this.userControlHopDong1);
            this.tabHopDong.ImageKey = "hopdong.png";
            this.tabHopDong.Location = new System.Drawing.Point(4, 25);
            this.tabHopDong.Name = "tabHopDong";
            this.tabHopDong.Size = new System.Drawing.Size(905, 308);
            this.tabHopDong.TabIndex = 3;
            this.tabHopDong.Text = "Quản lý hợp đồng";
            this.tabHopDong.UseVisualStyleBackColor = true;
            // 
            // userControlHopDong1
            // 
            this.userControlHopDong1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlHopDong1.BackColor = System.Drawing.SystemColors.Window;
            this.userControlHopDong1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControlHopDong1.Location = new System.Drawing.Point(3, 3);
            this.userControlHopDong1.Name = "userControlHopDong1";
            this.userControlHopDong1.Size = new System.Drawing.Size(899, 302);
            this.userControlHopDong1.TabIndex = 0;
            // 
            // tabControlIconList
            // 
            this.tabControlIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabControlIconList.ImageStream")));
            this.tabControlIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabControlIconList.Images.SetKeyName(0, "cua.png");
            this.tabControlIconList.Images.SetKeyName(1, "khanghang.png");
            this.tabControlIconList.Images.SetKeyName(2, "nha.png");
            this.tabControlIconList.Images.SetKeyName(3, "trangchu.png");
            this.tabControlIconList.Images.SetKeyName(4, "cauhinh.png");
            this.tabControlIconList.Images.SetKeyName(5, "hopdong.png");
            this.tabControlIconList.Images.SetKeyName(6, "thanhtoan.png");
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 429);
            this.Controls.Add(this.TabControlQuanLy);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControlQuanLy;
            this.Name = "QuanLy";
            this.Text = "Quản Lý Nhân Sự";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.TabControlQuanLy.ResumeLayout(false);
            this.tabNhanVien.ResumeLayout(false);
            this.tabCaLamViec.ResumeLayout(false);
            this.tabLichTruc.ResumeLayout(false);
            this.tabHopDong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControlQuanLy;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabCaLamViec;
        private System.Windows.Forms.TabPage tabLichTruc;
        private System.Windows.Forms.TabPage tabHopDong;
        private System.Windows.Forms.ImageList tabControlIconList;
        private UserControlFormChinh.UserControlNhanVien userControlNhanVien1;
        private UserControlFormChinh.UserControlCaLamViec userControlCaLamViec1;
        private UserControlFormChinh.UserControlLichTruc userControlLichTruc1;
        private UserControlFormChinh.UserControlHopDong userControlHopDong1;
    }
}