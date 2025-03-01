namespace QuanLyNhanSu.Forms.FormPhuCap
{
    partial class FormThemPhuCap
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
            this.btXoaPhuCap = new MaterialSkin.Controls.MaterialButton();
            this.tbTenPhuCap = new MaterialSkin.Controls.MaterialTextBox();
            this.btThemPhuCap = new MaterialSkin.Controls.MaterialButton();
            this.tbGiaPhuCap = new MaterialSkin.Controls.MaterialTextBox();
            this.lvPhuPhi = new MaterialSkin.Controls.MaterialListView();
            this.colMaPhuCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPhuCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaPhuCấp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btXoaPhuCap);
            this.groupBox1.Controls.Add(this.tbTenPhuCap);
            this.groupBox1.Controls.Add(this.btThemPhuCap);
            this.groupBox1.Controls.Add(this.tbGiaPhuCap);
            this.groupBox1.Controls.Add(this.lvPhuPhi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phụ cấp";
            // 
            // btXoaPhuCap
            // 
            this.btXoaPhuCap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btXoaPhuCap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btXoaPhuCap.Depth = 0;
            this.btXoaPhuCap.HighEmphasis = true;
            this.btXoaPhuCap.Icon = null;
            this.btXoaPhuCap.Location = new System.Drawing.Point(504, 126);
            this.btXoaPhuCap.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btXoaPhuCap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btXoaPhuCap.Name = "btXoaPhuCap";
            this.btXoaPhuCap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btXoaPhuCap.Size = new System.Drawing.Size(116, 36);
            this.btXoaPhuCap.TabIndex = 17;
            this.btXoaPhuCap.Text = "Xoá Phụ Cấp";
            this.btXoaPhuCap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btXoaPhuCap.UseAccentColor = true;
            this.btXoaPhuCap.UseVisualStyleBackColor = true;
            // 
            // tbTenPhuCap
            // 
            this.tbTenPhuCap.AnimateReadOnly = false;
            this.tbTenPhuCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTenPhuCap.Depth = 0;
            this.tbTenPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTenPhuCap.LeadingIcon = null;
            this.tbTenPhuCap.Location = new System.Drawing.Point(153, 43);
            this.tbTenPhuCap.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenPhuCap.MaxLength = 50;
            this.tbTenPhuCap.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTenPhuCap.Multiline = false;
            this.tbTenPhuCap.Name = "tbTenPhuCap";
            this.tbTenPhuCap.Size = new System.Drawing.Size(293, 50);
            this.tbTenPhuCap.TabIndex = 16;
            this.tbTenPhuCap.Text = "";
            this.tbTenPhuCap.TrailingIcon = null;
            // 
            // btThemPhuCap
            // 
            this.btThemPhuCap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btThemPhuCap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btThemPhuCap.Depth = 0;
            this.btThemPhuCap.HighEmphasis = true;
            this.btThemPhuCap.Icon = null;
            this.btThemPhuCap.Location = new System.Drawing.Point(651, 126);
            this.btThemPhuCap.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btThemPhuCap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThemPhuCap.Name = "btThemPhuCap";
            this.btThemPhuCap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btThemPhuCap.Size = new System.Drawing.Size(127, 36);
            this.btThemPhuCap.TabIndex = 13;
            this.btThemPhuCap.Text = "Thêm Phụ Cấp";
            this.btThemPhuCap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btThemPhuCap.UseAccentColor = false;
            this.btThemPhuCap.UseVisualStyleBackColor = true;
            // 
            // tbGiaPhuCap
            // 
            this.tbGiaPhuCap.AnimateReadOnly = false;
            this.tbGiaPhuCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGiaPhuCap.Depth = 0;
            this.tbGiaPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGiaPhuCap.LeadingIcon = null;
            this.tbGiaPhuCap.Location = new System.Drawing.Point(153, 112);
            this.tbGiaPhuCap.Margin = new System.Windows.Forms.Padding(4);
            this.tbGiaPhuCap.MaxLength = 50;
            this.tbGiaPhuCap.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGiaPhuCap.Multiline = false;
            this.tbGiaPhuCap.Name = "tbGiaPhuCap";
            this.tbGiaPhuCap.Size = new System.Drawing.Size(293, 50);
            this.tbGiaPhuCap.TabIndex = 14;
            this.tbGiaPhuCap.Text = "";
            this.tbGiaPhuCap.TrailingIcon = null;
            // 
            // lvPhuPhi
            // 
            this.lvPhuPhi.AutoSizeTable = false;
            this.lvPhuPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvPhuPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPhuPhi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhuCap,
            this.colTenPhuCap,
            this.colGiaPhuCấp});
            this.lvPhuPhi.Depth = 0;
            this.lvPhuPhi.FullRowSelect = true;
            this.lvPhuPhi.HideSelection = false;
            this.lvPhuPhi.Location = new System.Drawing.Point(7, 184);
            this.lvPhuPhi.Margin = new System.Windows.Forms.Padding(4);
            this.lvPhuPhi.MinimumSize = new System.Drawing.Size(267, 123);
            this.lvPhuPhi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvPhuPhi.MouseState = MaterialSkin.MouseState.OUT;
            this.lvPhuPhi.Name = "lvPhuPhi";
            this.lvPhuPhi.OwnerDraw = true;
            this.lvPhuPhi.Size = new System.Drawing.Size(772, 305);
            this.lvPhuPhi.TabIndex = 15;
            this.lvPhuPhi.UseCompatibleStateImageBehavior = false;
            this.lvPhuPhi.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhuCap
            // 
            this.colMaPhuCap.Text = "Mã Phụ Cấp";
            this.colMaPhuCap.Width = 127;
            // 
            // colTenPhuCap
            // 
            this.colTenPhuCap.Text = "Tên Phụ Cấp";
            this.colTenPhuCap.Width = 133;
            // 
            // colGiaPhuCấp
            // 
            this.colGiaPhuCấp.Text = "Giá";
            this.colGiaPhuCấp.Width = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên phụ cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Giá phụ cấp:";
            // 
            // FormThemPhuCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 583);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "FormThemPhuCap";
            this.Text = "Thêm Phụ Cấp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btXoaPhuCap;
        private MaterialSkin.Controls.MaterialTextBox tbTenPhuCap;
        private MaterialSkin.Controls.MaterialButton btThemPhuCap;
        private MaterialSkin.Controls.MaterialTextBox tbGiaPhuCap;
        private MaterialSkin.Controls.MaterialListView lvPhuPhi;
        private System.Windows.Forms.ColumnHeader colMaPhuCap;
        private System.Windows.Forms.ColumnHeader colTenPhuCap;
        private System.Windows.Forms.ColumnHeader colGiaPhuCấp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}