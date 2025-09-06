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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rdChuyenKhoan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ccbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = ccbTenHang.SelectedIndex;
            switch (stt)
            {
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "2000000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            double thanhTien = donGia * soLuong;

            if (rdChuyenKhoan.Checked)
                thanhTien = donGia * soLuong * 0.95;

            lblSoTien.Text = thanhTien.ToString();
        }
    }
}
