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
    public partial class Tinhtong : Form
    {
        public Tinhtong()
        {
            InitializeComponent();
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
            (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
            || (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
            (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
            || (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void btnTinhtong_Click(object sender, EventArgs e)
        {
            double tong;
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);
            tong = a + b;
            lbTong.Text = tong.ToString();
        }
    }
}
