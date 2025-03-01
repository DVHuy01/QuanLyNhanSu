namespace QuanLyNhanSu.Forms.FormNghiPhep
{
    partial class FormSuaNghiPhep
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenNhanVien = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTenNghiPhep = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNgayKetThuc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNgayBatDau = new MaterialSkin.Controls.MaterialTextBox();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnThemNV = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.txtNgayBatDau);
            this.groupBox1.Controls.Add(this.txtNgayKetThuc);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtTenNghiPhep);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 302);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nghỉ phép";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.AnimateReadOnly = false;
            this.txtTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNhanVien.Depth = 0;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenNhanVien.LeadingIcon = null;
            this.txtTenNhanVien.Location = new System.Drawing.Point(159, 124);
            this.txtTenNhanVien.MaxLength = 50;
            this.txtTenNhanVien.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenNhanVien.Multiline = false;
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(209, 50);
            this.txtTenNhanVien.TabIndex = 9;
            this.txtTenNhanVien.Text = "";
            this.txtTenNhanVien.TrailingIcon = null;
            // 
            // txtTenNghiPhep
            // 
            this.txtTenNghiPhep.AnimateReadOnly = false;
            this.txtTenNghiPhep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNghiPhep.Depth = 0;
            this.txtTenNghiPhep.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenNghiPhep.LeadingIcon = null;
            this.txtTenNghiPhep.Location = new System.Drawing.Point(159, 57);
            this.txtTenNghiPhep.MaxLength = 50;
            this.txtTenNghiPhep.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenNghiPhep.Multiline = false;
            this.txtTenNghiPhep.Name = "txtTenNghiPhep";
            this.txtTenNghiPhep.Size = new System.Drawing.Size(209, 50);
            this.txtTenNghiPhep.TabIndex = 8;
            this.txtTenNghiPhep.Text = "";
            this.txtTenNghiPhep.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(421, 135);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(102, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Ngày kết thúc:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(421, 68);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(101, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Ngày bắt đầu:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(29, 135);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Tên nhân viên:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(29, 68);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tên nghi phép:";
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.AnimateReadOnly = false;
            this.txtNgayKetThuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgayKetThuc.Depth = 0;
            this.txtNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNgayKetThuc.LeadingIcon = null;
            this.txtNgayKetThuc.Location = new System.Drawing.Point(549, 124);
            this.txtNgayKetThuc.MaxLength = 50;
            this.txtNgayKetThuc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNgayKetThuc.Multiline = false;
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(209, 50);
            this.txtNgayKetThuc.TabIndex = 18;
            this.txtNgayKetThuc.Text = "";
            this.txtNgayKetThuc.TrailingIcon = null;
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.AnimateReadOnly = false;
            this.txtNgayBatDau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgayBatDau.Depth = 0;
            this.txtNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNgayBatDau.LeadingIcon = null;
            this.txtNgayBatDau.Location = new System.Drawing.Point(549, 57);
            this.txtNgayBatDau.MaxLength = 50;
            this.txtNgayBatDau.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNgayBatDau.Multiline = false;
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(209, 50);
            this.txtNgayBatDau.TabIndex = 19;
            this.txtNgayBatDau.Text = "";
            this.txtNgayBatDau.TrailingIcon = null;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(464, 237);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(132, 36);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Xóa Chỉnh Sửa";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = true;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThemNV
            // 
            this.btnThemNV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemNV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemNV.Depth = 0;
            this.btnThemNV.HighEmphasis = true;
            this.btnThemNV.Icon = null;
            this.btnThemNV.Location = new System.Drawing.Point(627, 237);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThemNV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemNV.Size = new System.Drawing.Size(131, 36);
            this.btnThemNV.TabIndex = 25;
            this.btnThemNV.Text = "Lưu Chỉnh Sửa";
            this.btnThemNV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemNV.UseAccentColor = false;
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // FormSuaNghiPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(818, 378);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "FormSuaNghiPhep";
            this.Text = "Sửa Nghỉ Phép";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox txtTenNhanVien;
        private MaterialSkin.Controls.MaterialTextBox txtTenNghiPhep;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtNgayBatDau;
        private MaterialSkin.Controls.MaterialTextBox txtNgayKetThuc;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnThemNV;
    }
}