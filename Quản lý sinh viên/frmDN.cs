using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_sinh_viên
{
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }
    }
}
