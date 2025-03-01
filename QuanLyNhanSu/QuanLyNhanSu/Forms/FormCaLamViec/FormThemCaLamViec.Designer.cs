namespace QuanLyNhanSu.Forms.FormCaLamViec
{
    partial class FormThemCaLamViec
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
            this.btnThemCa = new MaterialSkin.Controls.MaterialButton();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.txtGioBatDau = new MaterialSkin.Controls.MaterialTextBox();
            this.txtGioKetThuc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTenCa = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.materialComboBox1);
            this.groupBox1.Controls.Add(this.btnThemCa);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.txtGioBatDau);
            this.groupBox1.Controls.Add(this.txtGioKetThuc);
            this.groupBox1.Controls.Add(this.txtTenCa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ca làm việc";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(15, 136);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(101, 19);
            this.materialLabel4.TabIndex = 30;
            this.materialLabel4.Text = "Mã Nhân Viên";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(410, 72);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(86, 19);
            this.materialLabel3.TabIndex = 29;
            this.materialLabel3.Text = "Giờ Bắt Đầu";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(410, 136);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 19);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "Giờ Kết thúc";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(15, 72);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 27;
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
            this.materialComboBox1.Location = new System.Drawing.Point(145, 122);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(224, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 26;
            // 
            // btnThemCa
            // 
            this.btnThemCa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemCa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemCa.Depth = 0;
            this.btnThemCa.HighEmphasis = true;
            this.btnThemCa.Icon = null;
            this.btnThemCa.Location = new System.Drawing.Point(662, 217);
            this.btnThemCa.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThemCa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemCa.Name = "btnThemCa";
            this.btnThemCa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemCa.Size = new System.Drawing.Size(85, 36);
            this.btnThemCa.TabIndex = 25;
            this.btnThemCa.Text = "Thêm Ca";
            this.btnThemCa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemCa.UseAccentColor = false;
            this.btnThemCa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(516, 217);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(73, 36);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = true;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // txtGioBatDau
            // 
            this.txtGioBatDau.AnimateReadOnly = false;
            this.txtGioBatDau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGioBatDau.Depth = 0;
            this.txtGioBatDau.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGioBatDau.Hint = "Nhập giờ bắt đầu";
            this.txtGioBatDau.LeadingIcon = null;
            this.txtGioBatDau.Location = new System.Drawing.Point(523, 52);
            this.txtGioBatDau.MaxLength = 50;
            this.txtGioBatDau.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGioBatDau.Multiline = false;
            this.txtGioBatDau.Name = "txtGioBatDau";
            this.txtGioBatDau.Size = new System.Drawing.Size(224, 50);
            this.txtGioBatDau.TabIndex = 23;
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
            this.txtGioKetThuc.Location = new System.Drawing.Point(523, 122);
            this.txtGioKetThuc.MaxLength = 50;
            this.txtGioKetThuc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGioKetThuc.Multiline = false;
            this.txtGioKetThuc.Name = "txtGioKetThuc";
            this.txtGioKetThuc.Size = new System.Drawing.Size(224, 50);
            this.txtGioKetThuc.TabIndex = 22;
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
            this.txtTenCa.Location = new System.Drawing.Point(145, 53);
            this.txtTenCa.MaxLength = 50;
            this.txtTenCa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenCa.Multiline = false;
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.Size = new System.Drawing.Size(224, 50);
            this.txtTenCa.TabIndex = 21;
            this.txtTenCa.Text = "";
            this.txtTenCa.TrailingIcon = null;
            // 
            // FormThemCaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 376);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThemCaLamViec";
            this.Text = "Thêm Ca Làm Việc";
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
        private MaterialSkin.Controls.MaterialButton btnThemCa;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialTextBox txtGioBatDau;
        private MaterialSkin.Controls.MaterialTextBox txtGioKetThuc;
        private MaterialSkin.Controls.MaterialTextBox txtTenCa;
    }
}