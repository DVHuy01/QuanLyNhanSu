namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    partial class UserControlTaiKhoang
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
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.colAccountID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVaiTro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AnimateReadOnly = false;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimKiem.Hint = "Nhập thông tin cần tìm";
            this.txtTimKiem.LeadingIcon = null;
            this.txtTimKiem.Location = new System.Drawing.Point(112, 20);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.MaxLength = 50;
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(266, 50);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.Text = "";
            this.txtTimKiem.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tìm Kiếm";
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAccountID,
            this.colUsername,
            this.colPassword,
            this.colVaiTro,
            this.colSoDienThoai});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(3, 92);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(854, 226);
            this.materialListView1.TabIndex = 14;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // colAccountID
            // 
            this.colAccountID.Text = "AccountID";
            this.colAccountID.Width = 140;
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 137;
            // 
            // colPassword
            // 
            this.colPassword.Text = "Password";
            this.colPassword.Width = 152;
            // 
            // colVaiTro
            // 
            this.colVaiTro.Text = "Vai Trò";
            this.colVaiTro.Width = 130;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.Text = "Số Điện Thoại";
            this.colSoDienThoai.Width = 160;
            // 
            // UserControlTaiKhoang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "UserControlTaiKhoang";
            this.Size = new System.Drawing.Size(860, 321);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader colAccountID;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colPassword;
        private System.Windows.Forms.ColumnHeader colVaiTro;
        private System.Windows.Forms.ColumnHeader colSoDienThoai;
    }
}
