using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string[] dt = { "Kinh", "Hoa", "K'Me", "H'Mông", "Khac" };
            foreach (string s in dt)
            {
                comboBox1.Items.Add(s);
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc được chọn: ";
            if (comboBox1.SelectedIndex >= 0)
                label2.Text = s + comboBox1.SelectedItem.ToString();
            else
                label2.Text = "Bạn chưa chọn dân tộc";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Dân tộc được chọn:" + comboBox1.SelectedItem.ToString());
        }

    }
}
