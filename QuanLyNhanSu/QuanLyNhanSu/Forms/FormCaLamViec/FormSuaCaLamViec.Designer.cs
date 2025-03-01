namespace QuanLyNhanSu.Forms.FormCaLamViec
{
    partial class FormSuaCaLamViec
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
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.txtGioBatDau = new MaterialSkin.Controls.MaterialTextBox();
            this.txtGioKetThuc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTenCa = new MaterialSkin.Controls.MaterialTextBox();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnThemNV = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.materialComboBox1);
            this.groupBox1.Controls.Add(this.txtGioBatDau);
            this.groupBox1.Controls.Add(this.txtGioKetThuc);
            this.groupBox1.Controls.Add(this.txtTenCa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ca làm việc";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(11, 128);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(101, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Mã Nhân Viên";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(406, 59);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(86, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Giờ Bắt Đầu";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(406, 128);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "Giờ Kết thúc";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(11, 59);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Tên Ca";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Chọn mã nhân viên";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(141, 114);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(224, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 16;
            // 
            // txtGioBatDau
            // 
            this.txtGioBatDau.AnimateReadOnly = false;
            this.txtGioBatDau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGioBatDau.Depth = 0;
            this.txtGioBatDau.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGioBatDau.Hint = "Nhập giờ bắt đầu";
            this.txtGioBatDau.LeadingIcon = null;
            this.txtGioBatDau.Location = new System.Drawing.Point(519, 39);
            this.txtGioBatDau.MaxLength = 50;
            this.txtGioBatDau.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGioBatDau.Multiline = false;
            this.txtGioBatDau.Name = "txtGioBatDau";
            this.txtGioBatDau.Size = new System.Drawing.Size(224, 50);
            this.txtGioBatDau.TabIndex = 2;
            this.txtGioBatDau.Text = "";
            this.txtGioBatDau.TrailingIcon = null;
            // 
            // txtGioKetThuc
            // 
            this.txtGioKetThuc.AnimateReadOnly = false;
            this.txtGioKetThuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGioKetThuc.Depth = 0;
            this.txtGioKetThuc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGioKetThuc.Hint = "Nhập giờ kết thúc";
            this.txtGioKetThuc.LeadingIcon = null;
            this.txtGioKetThuc.Location = new System.Drawing.Point(519, 114);
            this.txtGioKetThuc.MaxLength = 50;
            this.txtGioKetThuc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGioKetThuc.Multiline = false;
            this.txtGioKetThuc.Name = "txtGioKetThuc";
            this.txtGioKetThuc.Size = new System.Drawing.Size(224, 50);
            this.txtGioKetThuc.TabIndex = 1;
            this.txtGioKetThuc.Text = "";
            this.txtGioKetThuc.TrailingIcon = null;
            // 
            // txtTenCa
            // 
            this.txtTenCa.AnimateReadOnly = false;
            this.txtTenCa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenCa.Depth = 0;
            this.txtTenCa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenCa.Hint = "Nhập tên ca";
            this.txtTenCa.LeadingIcon = null;
            this.txtTenCa.Location = new System.Drawing.Point(141, 40);
            this.txtTenCa.MaxLength = 50;
            this.txtTenCa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenCa.Multiline = false;
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.Size = new System.Drawing.Size(224, 50);
            this.txtTenCa.TabIndex = 0;
            this.txtTenCa.Text = "";
            this.txtTenCa.TrailingIcon = null;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(449, 227);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(132, 36);
            this.btnHuy.TabIndex = 22;
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
            this.btnThemNV.Location = new System.Drawing.Point(612, 227);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThemNV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemNV.Size = new System.Drawing.Size(131, 36);
            this.btnThemNV.TabIndex = 23;
            this.btnThemNV.Text = "Lưu Chỉnh Sửa";
            this.btnThemNV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemNV.UseAccentColor = false;
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // FormSuaCaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(795, 373);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "FormSuaCaLamViec";
            this.Text = "Sửa Ca Làm Việc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialTextBox txtGioBatDau;
        private MaterialSkin.Controls.MaterialTextBox txtGioKetThuc;
        private MaterialSkin.Controls.MaterialTextBox txtTenCa;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnThemNV;
    }
}