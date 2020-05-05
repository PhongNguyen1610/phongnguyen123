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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void chàoMừngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chaomung c1 = new Chaomung();
            c1.Show();
        }

        private void tínhTổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tinhtong c2 = new Tinhtong();
            c2.Show();
        }

        private void chươngTrìnhTínhTổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chuongtrinhtinhtong c3 = new chuongtrinhtinhtong();
            c3.Show();
        }
    }
}
