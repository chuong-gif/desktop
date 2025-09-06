using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void tsbBai1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.ShowDialog();
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog();
        }

        private void tsbBai3_Click(object sender, EventArgs e)
        {
            var form = new Form3();
            form.ShowDialog();
        }
    }
    
}
