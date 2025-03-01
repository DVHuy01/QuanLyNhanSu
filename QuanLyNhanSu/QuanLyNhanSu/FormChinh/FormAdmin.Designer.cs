namespace QuanLyNhanSu.FormChinh
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.TabControlAdmin = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPhongBan = new System.Windows.Forms.TabPage();
            this.tabChucVu = new System.Windows.Forms.TabPage();
            this.tabPhuCap = new System.Windows.Forms.TabPage();
            this.tabControlIconList = new System.Windows.Forms.ImageList(this.components);
            this.tabTaiKhoang = new System.Windows.Forms.TabPage();
            this.userControlPhongBan1 = new QuanLyNhanSu.FormChinh.UserControlFormChinh.UserControlPhongBan();
            this.userControlChucVu1 = new QuanLyNhanSu.FormChinh.UserControlFormChinh.UserControlChucVu();
            this.userControlPhuCap1 = new QuanLyNhanSu.FormChinh.UserControlFormChinh.UserControlPhuCap();
            this.userControlTaiKhoang1 = new QuanLyNhanSu.FormChinh.UserControlFormChinh.UserControlTaiKhoang();
            this.TabControlAdmin.SuspendLayout();
            this.tabPhongBan.SuspendLayout();
            this.tabChucVu.SuspendLayout();
            this.tabPhuCap.SuspendLayout();
            this.tabTaiKhoang.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlAdmin
            // 
            this.TabControlAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlAdmin.Controls.Add(this.tabPhongBan);
            this.TabControlAdmin.Controls.Add(this.tabChucVu);
            this.TabControlAdmin.Controls.Add(this.tabPhuCap);
            this.TabControlAdmin.Controls.Add(this.tabTaiKhoang);
            this.TabControlAdmin.Depth = 0;
            this.TabControlAdmin.ImageList = this.tabControlIconList;
            this.TabControlAdmin.Location = new System.Drawing.Point(6, 67);
            this.TabControlAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlAdmin.Multiline = true;
            this.TabControlAdmin.Name = "TabControlAdmin";
            this.TabControlAdmin.SelectedIndex = 0;
            this.TabControlAdmin.Size = new System.Drawing.Size(788, 364);
            this.TabControlAdmin.TabIndex = 0;
            // 
            // tabPhongBan
            // 
            this.tabPhongBan.Controls.Add(this.userControlPhongBan1);
            this.tabPhongBan.ImageKey = "cua.png";
            this.tabPhongBan.Location = new System.Drawing.Point(4, 25);
            this.tabPhongBan.Name = "tabPhongBan";
            this.tabPhongBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhongBan.Size = new System.Drawing.Size(780, 335);
            this.tabPhongBan.TabIndex = 0;
            this.tabPhongBan.Text = "Quản Lý Phòng Ban";
            this.tabPhongBan.UseVisualStyleBackColor = true;
            // 
            // tabChucVu
            // 
            this.tabChucVu.Controls.Add(this.userControlChucVu1);
            this.tabChucVu.ImageKey = "khanghang.png";
            this.tabChucVu.Location = new System.Drawing.Point(4, 25);
            this.tabChucVu.Name = "tabChucVu";
            this.tabChucVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabChucVu.Size = new System.Drawing.Size(780, 335);
            this.tabChucVu.TabIndex = 1;
            this.tabChucVu.Text = "Quản Lý Chức Vụ";
            this.tabChucVu.UseVisualStyleBackColor = true;
            // 
            // tabPhuCap
            // 
            this.tabPhuCap.Controls.Add(this.userControlPhuCap1);
            this.tabPhuCap.ImageKey = "thanhtoan.png";
            this.tabPhuCap.Location = new System.Drawing.Point(4, 25);
            this.tabPhuCap.Name = "tabPhuCap";
            this.tabPhuCap.Size = new System.Drawing.Size(780, 335);
            this.tabPhuCap.TabIndex = 2;
            this.tabPhuCap.Text = "Quản Lý Phụ Cấp";
            this.tabPhuCap.UseVisualStyleBackColor = true;
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
            // tabTaiKhoang
            // 
            this.tabTaiKhoang.Controls.Add(this.userControlTaiKhoang1);
            this.tabTaiKhoang.ImageKey = "cauhinh.png";
            this.tabTaiKhoang.Location = new System.Drawing.Point(4, 25);
            this.tabTaiKhoang.Name = "tabTaiKhoang";
            this.tabTaiKhoang.Size = new System.Drawing.Size(780, 335);
            this.tabTaiKhoang.TabIndex = 3;
            this.tabTaiKhoang.Text = "Quản Lý Tài Khoản";
            this.tabTaiKhoang.UseVisualStyleBackColor = true;
            // 
            // userControlPhongBan1
            // 
            this.userControlPhongBan1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlPhongBan1.BackColor = System.Drawing.SystemColors.Window;
            this.userControlPhongBan1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControlPhongBan1.Location = new System.Drawing.Point(3, 3);
            this.userControlPhongBan1.Name = "userControlPhongBan1";
            this.userControlPhongBan1.Size = new System.Drawing.Size(771, 329);
            this.userControlPhongBan1.TabIndex = 0;
            // 
            // userControlChucVu1
            // 
            this.userControlChucVu1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlChucVu1.BackColor = System.Drawing.SystemColors.Window;
            this.userControlChucVu1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControlChucVu1.Location = new System.Drawing.Point(3, 3);
            this.userControlChucVu1.Name = "userControlChucVu1";
            this.userControlChucVu1.Size = new System.Drawing.Size(771, 329);
            this.userControlChucVu1.TabIndex = 0;
            // 
            // userControlPhuCap1
            // 
            this.userControlPhuCap1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlPhuCap1.BackColor = System.Drawing.SystemColors.Window;
            this.userControlPhuCap1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControlPhuCap1.Location = new System.Drawing.Point(3, 3);
            this.userControlPhuCap1.Name = "userControlPhuCap1";
            this.userControlPhuCap1.Size = new System.Drawing.Size(774, 329);
            this.userControlPhuCap1.TabIndex = 0;
            // 
            // userControlTaiKhoang1
            // 
            this.userControlTaiKhoang1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlTaiKhoang1.BackColor = System.Drawing.SystemColors.Window;
            this.userControlTaiKhoang1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userControlTaiKhoang1.Location = new System.Drawing.Point(3, 3);
            this.userControlTaiKhoang1.Name = "userControlTaiKhoang1";
            this.userControlTaiKhoang1.Size = new System.Drawing.Size(774, 325);
            this.userControlTaiKhoang1.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.TabControlAdmin);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControlAdmin;
            this.Name = "FormAdmin";
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.TabControlAdmin.ResumeLayout(false);
            this.tabPhongBan.ResumeLayout(false);
            this.tabChucVu.ResumeLayout(false);
            this.tabPhuCap.ResumeLayout(false);
            this.tabTaiKhoang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControlAdmin;
        private System.Windows.Forms.TabPage tabPhongBan;
        private System.Windows.Forms.TabPage tabChucVu;
        private System.Windows.Forms.TabPage tabPhuCap;
        private UserControlFormChinh.UserControlPhongBan userControlPhongBan1;
        private UserControlFormChinh.UserControlChucVu userControlChucVu1;
        private UserControlFormChinh.UserControlPhuCap userControlPhuCap1;
        private System.Windows.Forms.ImageList tabControlIconList;
        private System.Windows.Forms.TabPage tabTaiKhoang;
        private UserControlFormChinh.UserControlTaiKhoang userControlTaiKhoang1;
    }
}