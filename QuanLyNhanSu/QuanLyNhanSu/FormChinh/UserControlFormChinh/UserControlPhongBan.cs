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
using QuanLyNhanSu.Forms.FormPhongBan;
using QuanLyNhanSu.Forms.FormNhanVien;


namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    public partial class UserControlPhongBan : UserControl
    {
        private string constr;
        public UserControlPhongBan()
        {
            InitializeComponent();
        }

        private void UserControlPhongBan_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            constr = ConfigurationManager.ConnectionStrings["QLNhanSu"].ConnectionString;
        }

        private void toolThem_Click(object sender, EventArgs e)
        {
            new FormThemPhongBan().ShowDialog();
        }

        private void toolSua_Click(object sender, EventArgs e)
        {
            new FormSuaPhongBan().ShowDialog();
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string MaPB = lsvPhongBan.SelectedItems[0].Text;
                    string updateSqlText = "UPDATE PhongBan SET TrangThaiXoa = 'True' WHERE MaPB = @MaPB";
                    using (SqlCommand updateCmd = new SqlCommand(updateSqlText, conn))
                    {
                        DialogResult dg = MessageBox.Show("Xác Nhận Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            updateCmd.Parameters.AddWithValue("@MaPB", MaPB);
                            updateCmd.ExecuteNonQuery();
                            LayDSPhongBan();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LayDSPhongBan()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string QLNhanSu = "SELECT * FROM PhongBan WHERE TrangThaiXoa = 'False'";
                    using (SqlCommand cmd = new SqlCommand(QLNhanSu, conn))
                    {
                        lsvPhongBan.Items.Clear();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                lsvPhongBan.Items.Add(reader["MaPB"].ToString());
                                lsvPhongBan.Items[i].SubItems.Add(reader["TenPB"].ToString());
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

        public void TimPhongBan()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string timKiem = tbTimKiem.Text.Trim();
                    string QLNhanSu = "SELECT * FROM PhongBan WHERE (MaPB LIKE @TimKiem OR TenPB LIKE @TimKiem) AND TrangThaiXoa = 0";
                    using (SqlCommand cmd = new SqlCommand(QLNhanSu, conn))
                    {
                        cmd.Parameters.AddWithValue("@TimKiem", $"%{timKiem}%");
                        lsvPhongBan.Items.Clear();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                lsvPhongBan.Items.Add(reader["MaPB"].ToString());
                                lsvPhongBan.Items[i].SubItems.Add(reader["TenPB"].ToString());
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
