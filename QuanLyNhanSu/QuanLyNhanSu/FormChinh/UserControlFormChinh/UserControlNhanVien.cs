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
using QuanLyNhanSu.Forms.FormNhanVien;
using QuanLyNhanSu.Forms.FormNghiPhep;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanSu.FormChinh.UserControlFormChinh
{
    public partial class UserControlNhanVien : UserControl
    {
 
        public UserControlNhanVien()
        {
            InitializeComponent();
            
        }

        private void UserControlNhanVien_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
        }

        private void toolThem_Click(object sender, EventArgs e)
        {
            new FormThemNhanVien().ShowDialog();
        }

        private void toolSua_Click(object sender, EventArgs e)
        {
            new FormThemNhanVien().ShowDialog();
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {

        }

        
    }
}
