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
using QuanLyNhanSu.Forms.FormCaLamViec;
using System.Xml;

namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    public partial class UserControlCaLamViec : UserControl
    {
        
        private string constr;
        public UserControlCaLamViec()
        {
            InitializeComponent();
            
        }

        private void UserControlCaLamViec_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            constr = ConfigurationManager.ConnectionStrings["QLNhanSu"].ConnectionString;
        }

        private void toolThem_Click(object sender, EventArgs e)
        {
            new FormThemCaLamViec().ShowDialog();
        }

        private void toolSua_Click(object sender, EventArgs e)
        {
            new FormSuaCaLamViec().ShowDialog();
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string MaCa = lsvCaLamViec.SelectedItems[0].Text;
                    string updateSqlText = "UPDATE CaLamViec SET TrangThaiXoa = 1 WHERE MaCa = @MaCa";
                    using (SqlCommand updateCmd = new SqlCommand(updateSqlText, conn))
                    {
                        DialogResult dg = MessageBox.Show("Xác Nhận Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            updateCmd.Parameters.AddWithValue("@MaCa", MaCa);
                            updateCmd.ExecuteNonQuery();
                            LayDSCaLamViec();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LayDSCaLamViec()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string QLNhanSu = "SELECT MaCa, TenCa, GioBatDau, GioKetThuc" + 
                        "FROM CaLamViec CLV" +
                        "INNER JOIN NhanVien NV ON CLV.MaNV = NV.MaNV" +
                        "INNER JOIN ChucVu CV ON CLV.MaCV = CV.MaCV" +
                        " WHERE CLV.TrangThaiXoa = 0";
                    using (SqlCommand cmd = new SqlCommand(QLNhanSu, conn))
                    {
                        lsvCaLamViec.Items.Clear();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                lsvCaLamViec.Items.Add(reader["MaCa"].ToString());
                                lsvCaLamViec.Items[i].SubItems.Add(reader["TenCa"].ToString());
                                lsvCaLamViec.Items[i].SubItems.Add(reader["GioBatDau"].ToString());
                                lsvCaLamViec.Items[i].SubItems.Add(reader["GioKetThuc"].ToString());
                                
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

        public void TimCaLamViec()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                try
                {
                    string timKiem = tbTimKiem.Text;
                    string sqlText = "SELECT * FROM CaLAmViec WHERE (MaCa LIKE @TimKiem OR TenCa LIKE @TimKiem ) AND TrangThaiXoa = 0";
                    using (SqlCommand cmd = new SqlCommand(sqlText, conn))
                    {
                        cmd.Parameters.AddWithValue("@TimKiem", $"%{timKiem}%");
                        lsvCaLamViec.Items.Clear();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                lsvCaLamViec.Items.Add(reader["MaCa"].ToString());
                                lsvCaLamViec.Items[i].SubItems.Add(reader["TenCa"].ToString());
                                
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
