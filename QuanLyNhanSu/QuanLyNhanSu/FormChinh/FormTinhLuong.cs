using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace QuanLyNhanSu.FormChinh
{
    public partial class FormTinhLuong : MaterialForm
    {
        public FormTinhLuong()
        {
            InitializeComponent();
        }

        private void FormTinhLuong_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
        }
    }
}
