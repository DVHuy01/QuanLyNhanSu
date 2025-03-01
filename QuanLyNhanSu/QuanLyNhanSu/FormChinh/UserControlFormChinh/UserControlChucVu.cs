using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using QuanLyNhanSu.Forms.FormChucVu;


namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    public partial class UserControlChucVu : UserControl
    {
        private string constr;
        public UserControlChucVu()
        {
            InitializeComponent();
        }

        private void UserControlChucVu_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            constr = ConfigurationManager.ConnectionStrings["QLNhanSu"].ConnectionString;
        }

        private void toolThem_Click(object sender, EventArgs e)
        {
            new FormThemChucVu().ShowDialog();
        }

        private void toolSua_Click(object sender, EventArgs e)
        {
            new FormSuaChucVu().ShowDialog();
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string MaCV = lsvChucVu.SelectedItems[0].Text;
                    string updateSqlText = "UPDATE ChucVu SET TrangThaiXoa = 'True' WHERE MaCV = @MaCV";
                    using (SqlCommand updateCmd = new SqlCommand(updateSqlText, conn))
                    {
                        DialogResult dg = MessageBox.Show("Xác Nhận Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            updateCmd.Parameters.AddWithValue("@MaPP", MaCV);
                            updateCmd.ExecuteNonQuery();
                            LayDSChucVu();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LayDSChucVu()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string QLNhanSu = "SELECT * FROM ChucVu WHERE TrangThaiXoa = 0";
                    using (SqlCommand cmd = new SqlCommand(QLNhanSu, conn))
                    {
                        lsvChucVu.Items.Clear();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                lsvChucVu.Items.Add(reader["MaCV"].ToString());
                                lsvChucVu.Items[i].SubItems.Add(reader["TenCV"].ToString());
                                i++;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void TimChucVu()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string timKiem = txtTimKiem.Text.Trim();
                    string QLNhanSu = "SELECT * FROM ChucVu WHERE (MaCV LIKE @TimKiem OR TenCV LIKE @TimKiem) AND TrangThaiXoa = 'False'";
                    using (SqlCommand cmd = new SqlCommand(QLNhanSu, conn))
                    {
                        cmd.Parameters.AddWithValue("@TimKiem", $"%{timKiem}%");
                        lsvChucVu.Items.Clear();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                lsvChucVu.Items.Add(reader["MaCV"].ToString());
                                lsvChucVu.Items[i].SubItems.Add(reader["TenCV"].ToString());
                                i++;
                            }
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
