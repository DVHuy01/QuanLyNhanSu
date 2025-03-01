namespace QuanLyNhanSu.Forms.FormChucVu
{
    partial class FormThemChucVu
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
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnThemCV = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenCV = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThemCV);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtTenCV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(136, 151);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(73, 36);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = true;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThemCV
            // 
            this.btnThemCV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemCV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemCV.Depth = 0;
            this.btnThemCV.HighEmphasis = true;
            this.btnThemCV.Icon = null;
            this.btnThemCV.Location = new System.Drawing.Point(244, 151);
            this.btnThemCV.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThemCV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemCV.Size = new System.Drawing.Size(128, 36);
            this.btnThemCV.TabIndex = 20;
            this.btnThemCV.Text = "Thêm Chức Vụ";
            this.btnThemCV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemCV.UseAccentColor = false;
            this.btnThemCV.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(15, 54);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(88, 19);
            this.materialLabel1.TabIndex = 18;
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
            this.txtTenCV.Location = new System.Drawing.Point(123, 38);
            this.txtTenCV.MaxLength = 50;
            this.txtTenCV.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenCV.Multiline = false;
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(249, 50);
            this.txtTenCV.TabIndex = 17;
            this.txtTenCV.Text = "";
            this.txtTenCV.TrailingIcon = null;
            // 
            // FormThemChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(429, 309);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "FormThemChucVu";
            this.Text = "Thêm chức vụ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnThemCV;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtTenCV;
    }
}