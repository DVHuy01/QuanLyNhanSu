namespace QuanLyNhanSu.Forms.Account
{
    partial class FormDangNhap
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnDangKy = new MaterialSkin.Controls.MaterialButton();
            this.btnDangNhap = new MaterialSkin.Controls.MaterialButton();
            this.tbMatKhau = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTaiKhoan = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labAccount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVaiTro = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "* : Bắt buộc nhập";
            // 
            // btnDangKy
            // 
            this.btnDangKy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDangKy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDangKy.Depth = 0;
            this.btnDangKy.HighEmphasis = true;
            this.btnDangKy.Icon = null;
            this.btnDangKy.Location = new System.Drawing.Point(154, 311);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDangKy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDangKy.Size = new System.Drawing.Size(83, 36);
            this.btnDangKy.TabIndex = 54;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDangKy.UseAccentColor = true;
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDangNhap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDangNhap.Depth = 0;
            this.btnDangNhap.HighEmphasis = true;
            this.btnDangNhap.Icon = null;
            this.btnDangNhap.Location = new System.Drawing.Point(280, 311);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDangNhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDangNhap.Size = new System.Drawing.Size(105, 36);
            this.btnDangNhap.TabIndex = 55;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDangNhap.UseAccentColor = false;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.AnimateReadOnly = false;
            this.tbMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMatKhau.Depth = 0;
            this.tbMatKhau.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMatKhau.LeadingIcon = null;
            this.tbMatKhau.Location = new System.Drawing.Point(137, 102);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.tbMatKhau.MaxLength = 50;
            this.tbMatKhau.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMatKhau.Multiline = false;
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(248, 50);
            this.tbMatKhau.TabIndex = 53;
            this.tbMatKhau.Text = "";
            this.tbMatKhau.TrailingIcon = null;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.AnimateReadOnly = false;
            this.tbTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTaiKhoan.Depth = 0;
            this.tbTaiKhoan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTaiKhoan.LeadingIcon = null;
            this.tbTaiKhoan.Location = new System.Drawing.Point(137, 37);
            this.tbTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.tbTaiKhoan.MaxLength = 50;
            this.tbTaiKhoan.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTaiKhoan.Multiline = false;
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(248, 50);
            this.tbTaiKhoan.TabIndex = 52;
            this.tbTaiKhoan.Text = "";
            this.tbTaiKhoan.TrailingIcon = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(392, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(392, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Mật Khẩu:";
            // 
            // labAccount
            // 
            this.labAccount.AutoSize = true;
            this.labAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAccount.Location = new System.Drawing.Point(17, 54);
            this.labAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAccount.Name = "labAccount";
            this.labAccount.Size = new System.Drawing.Size(109, 25);
            this.labAccount.TabIndex = 47;
            this.labAccount.Text = "Tài Khoản:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbVaiTro);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbMatKhau);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labAccount);
            this.groupBox2.Controls.Add(this.btnDangKy);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDangNhap);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbTaiKhoan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 389);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoảng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(392, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "*";
            // 
            // cbVaiTro
            // 
            this.cbVaiTro.AutoResize = false;
            this.cbVaiTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbVaiTro.Depth = 0;
            this.cbVaiTro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbVaiTro.DropDownHeight = 174;
            this.cbVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVaiTro.DropDownWidth = 121;
            this.cbVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbVaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbVaiTro.FormattingEnabled = true;
            this.cbVaiTro.IntegralHeight = false;
            this.cbVaiTro.ItemHeight = 43;
            this.cbVaiTro.Items.AddRange(new object[] {
            "Admin",
            "Quản lý",
            "Nhân viên"});
            this.cbVaiTro.Location = new System.Drawing.Point(137, 173);
            this.cbVaiTro.MaxDropDownItems = 4;
            this.cbVaiTro.MouseState = MaterialSkin.MouseState.OUT;
            this.cbVaiTro.Name = "cbVaiTro";
            this.cbVaiTro.Size = new System.Drawing.Size(248, 49);
            this.cbVaiTro.StartIndex = 0;
            this.cbVaiTro.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(44, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Vai Trò:";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThoat.Depth = 0;
            this.btnThoat.HighEmphasis = true;
            this.btnThoat.Icon = null;
            this.btnThoat.Location = new System.Drawing.Point(22, 311);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(83, 36);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoat.UseAccentColor = true;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(454, 492);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialButton btnDangKy;
        private MaterialSkin.Controls.MaterialButton btnDangNhap;
        private MaterialSkin.Controls.MaterialTextBox tbMatKhau;
        private MaterialSkin.Controls.MaterialTextBox tbTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialComboBox cbVaiTro;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnThoat;
    }
}