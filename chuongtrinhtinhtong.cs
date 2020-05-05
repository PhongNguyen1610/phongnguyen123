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
    public partial class chuongtrinhtinhtong : Form
    {
        public chuongtrinhtinhtong()
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

        private void btnTong_Click(object sender, EventArgs e)
        {
            int j, sum = 0;
            int a = Convert.ToInt32(txta.Text);
            int b = Convert.ToInt32(txtb.Text);
            if (a > b)
            {
                MessageBox.Show("Vui lòng nhập a nhỏ hơn b");

                return;
            }
           label6 .Text = a.ToString();
            label7.Text = b.ToString();
            for (j = a; j <= b; j++)
            {
                sum = sum + j;
            }
            lbTong.Text = sum.ToString();
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txta.ResetText();
            txtb.ResetText();
            label6.ResetText();
            label7.ResetText();
            lbTong.ResetText();
        }

        private void chuongtrinhtinhtong_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
