using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
                MessageBox.Show("Bạn đã chọn giới tính nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
                MessageBox.Show("Bạn đã chọn giới tính nữ", "Thông báo");
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (rdRed.Checked) 
            {
                txtHopMau.BackColor = Color.Red;
            }
            else
            {
                txtHopMau.BackColor = Color.Blue;   
            }
        }
    }
}
