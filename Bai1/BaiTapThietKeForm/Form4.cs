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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int so;

            for (int i = 0; i <= 10; i++)
            {
                so = random.Next(1, 100);
                listBox1.Items.Add(so);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtSo.Text);
            lblKetQua.Text = "Không tìm thấy";
            foreach (int so in listBox1.Items)
            {
                if (so == soCanTim)
                {
                    lblKetQua.Text = "Tìm thấy";
                    break;
                }
            }
        }
    }
}
