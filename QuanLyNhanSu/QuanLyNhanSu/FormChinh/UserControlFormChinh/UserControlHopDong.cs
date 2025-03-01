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
using QuanLyNhanSu.Forms.FormHopDong;
using QuanLyNhanSu.Forms.FormCaLamViec;

namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    public partial class UserControlHopDong : UserControl
    {
        private string constr;
        public UserControlHopDong()
        {
            InitializeComponent();
        }

        private void UserControlHopDong_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            constr = ConfigurationManager.ConnectionStrings["QLNhanSu"].ConnectionString;
        }


        private void toolSua_Click(object sender, EventArgs e)
        {
            new FormThemHopDong().ShowDialog();
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string MaHopDong = lsvHopDong.SelectedItems[0].Text;
                    string updateSqlText = "UPDATE HopDong SET TrangThaiXoa = 1 WHERE MaHopDong = @MaHopDong";
                    using (SqlCommand updateCmd = new SqlCommand(updateSqlText, conn))
                    {
                        DialogResult dg = MessageBox.Show("Xác Nhận Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            updateCmd.Parameters.AddWithValue("@MaHopDong", MaHopDong);
                            updateCmd.ExecuteNonQuery();
                            LayDSHopDong();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolThem_Click(object sender, EventArgs e)
        {
            new FormThemHopDong().ShowDialog();
        }

        public void LayDSHopDong()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string QLNhanSu = "SELECT MaHopDong, LoaiHopDong, NgayKi, ThoiHan, Luong, HeSoLuong, TenNV, TenCV, TenPB" +
                        "FROM HopDong HD" +
                        "INNER JOIN NhanVien NV ON HD.MaNV = NV.MaNV" +
                        "INNER JOIN ChucVu CV ON HD.MaCV = CV.MaCV" +
                        "INNER JOIN PhongBan PB ON HD.MaPB = CV.MaPB" +
                        " WHERE HD.TrangThaiXoa = 0";
                    using (SqlCommand cmd = new SqlCommand(QLNhanSu, conn))
                    {
                        lsvHopDong.Items.Clear();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                lsvHopDong.Items.Add(reader["MaHopDong"].ToString());
                                lsvHopDong.Items[i].SubItems.Add(reader["LoaiHopDong"].ToString());
                                lsvHopDong.Items[i].SubItems.Add(reader["NgayKi"].ToString());
                                lsvHopDong.Items[i].SubItems.Add(reader["ThoiHan"].ToString());
                                lsvHopDong.Items[i].SubItems.Add(reader["Luong"].ToString());
                                lsvHopDong.Items[i].SubItems.Add(reader["TenNV"].ToString());
                                lsvHopDong.Items[i].SubItems.Add(reader["TenPB"].ToString());
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

        public void TimKiemHopDong()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string timKiem = tbTimKiem.Text;
                    string sqlText = "SELECT MaHopDong, LoaiHopDong, NgayKi, ThoiHan, Luong, HeSoLuong, TenNV, TenCV, TenPB" +
                        "FROM HopDong HD" +
                        "INNER JOIN NhanVien NV ON HD.MaNV = NV.MaNV" +
                        "INNER JOIN ChucVu CV ON HD.MaCV = CV.MaCV" +
                        "INNER JOIN PhongBan PB ON HD.MaPB = CV.MaPB" +
                        " WHERE HD.TrangThaiXoa = 0";
                    using (SqlCommand cmd = new SqlCommand(sqlText, conn))
                    {
                        cmd.Parameters.AddWithValue("@TimKiem", $"%{timKiem}%");
                        lsvHopDong.Items.Clear();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                lsvHopDong.Items.Add(reader["MaHopDong"].ToString());
                                lsvHopDong.Items[i].SubItems.Add(reader["LoaiHopDong"].ToString());
                                lsvHopDong.Items[i].SubItems.Add(reader["NgayKi"].ToString());
                                lsvHopDong.Items[i].SubItems.Add(reader["TenNV"].ToString());
                                lsvHopDong.Items[i].SubItems.Add(reader["TenCV"].ToString());
                                lsvHopDong.Items[i].SubItems.Add(reader["TenPB"].ToString());
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
