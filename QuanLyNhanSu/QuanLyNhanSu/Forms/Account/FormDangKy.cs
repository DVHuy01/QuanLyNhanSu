using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MaterialSkin.Controls;
using QuanLyNhanSu.Forms.Account;

namespace QuanLyNhanSu.Forms.Account
{
    public partial class FormDangKy : MaterialForm
    {
        private string constr;
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            constr = ConfigurationManager.ConnectionStrings["QLNhanSu"].ConnectionString;

        }

        

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormDangNhap().Show();
        }



        private void tbSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)(8)))
                e.Handled = true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTaiKhoan.Text) || string.IsNullOrEmpty(tbMatKhau.Text) || string.IsNullOrEmpty(tbMatKhau.Text) || string.IsNullOrEmpty(cbVaiTro.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {

                    string QLNhanSu = "INSERT INTO UserAccounts (Username , Password, SoDienThoai, VaiTro) VALUES( @Username, @Password, @SDT, @VaiTro )";
                    using (SqlCommand cmd = new SqlCommand(QLNhanSu, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        cmd.Parameters.AddWithValue("@Username", tbTaiKhoan);
                        cmd.Parameters.AddWithValue("@Password", tbMatKhau);
                        cmd.Parameters.AddWithValue("@SDT", tbMatKhau);
                        cmd.Parameters.AddWithValue("@VaiTro", cbVaiTro);

                        int result = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (result > 0)
                        {
                            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Đóng form sau khi đăng ký thành công
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
