namespace QuanLyNhanSu.Forms.FormChucVu
{
    partial class FormSuaChucVu
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenCV = new MaterialSkin.Controls.MaterialTextBox();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnThemNV = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtTenCV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 58);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(88, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Tên chức vụ";
            // 
            // txtTenCV
            // 
            this.txtTenCV.AnimateReadOnly = false;
            this.txtTenCV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenCV.Depth = 0;
            this.txtTenCV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenCV.Hint = "Nhập tên chức vụ";
            this.txtTenCV.LeadingIcon = null;
            this.txtTenCV.Location = new System.Drawing.Point(114, 42);
            this.txtTenCV.MaxLength = 50;
            this.txtTenCV.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenCV.Multiline = false;
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(249, 50);
            this.txtTenCV.TabIndex = 0;
            this.txtTenCV.Text = "";
            this.txtTenCV.TrailingIcon = null;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(85, 159);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(132, 36);
            this.btnHuy.TabIndex = 20;
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
            this.btnThemNV.Location = new System.Drawing.Point(248, 159);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThemNV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemNV.Size = new System.Drawing.Size(131, 36);
            this.btnThemNV.TabIndex = 21;
            this.btnThemNV.Text = "Lưu Chỉnh Sửa";
            this.btnThemNV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemNV.UseAccentColor = false;
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // FormSuaChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 347);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSuaChucVu";
            this.Text = "Sửa Chức Vụ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtTenCV;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnThemNV;
    }
}