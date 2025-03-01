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
using QuanLyNhanSu.FormChinh;

namespace QuanLyNhanSu.Forms.Account
{
    public partial class FormDangNhap : MaterialForm
    {
        private string constr = ConfigurationManager.ConnectionStrings["QLNhanSu"].ConnectionString;
        //private string selectedPrefix = "";
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDangKy().ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string selectedRole = cbVaiTro.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tbTaiKhoan.Text) || string.IsNullOrEmpty(tbMatKhau.Text) || string.IsNullOrEmpty(tbMatKhau.Text) || string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và vai trò  !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {

                    string QLNhanSu = "SELECT * FROM UserAccounts WHERE TrangThaiXoa = 0";
                    using (SqlCommand cmd = new SqlCommand(QLNhanSu, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        cmd.Parameters.AddWithValue("@Username", tbTaiKhoan);
                        cmd.Parameters.AddWithValue("@Password", tbMatKhau);
                        cmd.Parameters.AddWithValue("@SDT", tbMatKhau);
                        cmd.Parameters.AddWithValue("@VaiTro", selectedRole);

                        object result = cmd.ExecuteScalar();
                        conn.Close();

                        if (result != null)
                        {
                            MessageBox.Show($"Đăng nhập thành công với vai trò {cbVaiTro}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      //      OpenFormBasedOnRole(selectedRole);
                        }
                        else
                        {
                            MessageBox.Show("Sai số điện thoại, mật khẩu hoặc vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private void OpenFormBasedOnRole(string role)
        //{
        //    Form nextForm = null;

        //    switch (role)
        //    {
        //        case "Admin":
        //            nextForm = new FormAdmin();
        //            break;
        //        case "QuanLy":
        //            nextForm = new FormQuanLy();
        //            break;
        //        case "NhanVien":
        //            nextForm = new NhanVien();
        //            break;
        //    }

        //    if (nextForm != null)
        //    {
        //        this.Hide();
        //        nextForm.ShowDialog();
        //        this.Show();
        //    }
        //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
