﻿using System;
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
    public partial class QuanLy : MaterialForm
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
        }
    }
}
