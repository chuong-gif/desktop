using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.ShowDialog();
        }
        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog();
        }
        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            var form = new Form3();
            form.ShowDialog();
        }

        private void tsmiBai4_Click(object sender, EventArgs e)
        {
            var form = new Form4();
            form.ShowDialog();
        }

        private void NgôVanChuongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
