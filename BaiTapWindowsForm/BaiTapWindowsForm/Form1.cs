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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MaHang = "HH01";
            hh.TenHang = "Mèo";
            hh.DVT = "cái";
            hh.SoLuong = 5;
            hh.DonGia = 200000;

            lblThongBao.Text = hh.HienThi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblThongBao_Click(object sender, EventArgs e)
        {

        }
    }
}
