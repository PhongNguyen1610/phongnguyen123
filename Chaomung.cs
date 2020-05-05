using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1chuong4
{
    public partial class Chaomung : Form
    {
        public Chaomung()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên");
                txtTen.Focus();
                return;
            }
            if (txtLop.Text == "")
            {
                MessageBox.Show("bạn chưa  nhập lớp");
                txtLop.Focus();
                return;
            }
            MessageBox.Show("chào mừng bạn " + txtTen.Text + "học lớp " + txtLop.Text);
        }

        private void Chaomung_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã bật form Chaomung");
        }
    }
}
