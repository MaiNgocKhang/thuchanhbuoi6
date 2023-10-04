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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
        public bool kiemtra(string s)
        {
            if (string.Compare(s, treeView1.SelectedNode.Text, true) == 0)
                return true;
            return false;
        }

        private void btnThempB_Click(object sender, EventArgs e)
        {
            
            if (kiemtra(txtPhongban.Text)== false)
            {
                treeView1.Nodes.Add(txtPhongban.Text);
                cbxPhongban.Items.Add(txtPhongban.Text);
            }
            else
                MessageBox.Show("Phòng ban đã tồn tại!");
            txtPhongban.Text = "";
            txtPhongban.Focus();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám Đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" };
            foreach (string s in pb)
            {
                treeView1.Nodes.Add(s);
                cbxPhongban.Items.Add(s);
            }
            cbxPhongban.SelectedIndex = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa?","thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                if(treeView1.SelectedNode != null)
                {
                    cbxPhongban.Items.Remove(treeView1.SelectedNode.Text);
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach(TreeNode node in treeView1.Nodes)
                if(node.Text == cbxPhongban.Text)
                {
                    index = node.Index;
                    break;
                }
            treeView1.Nodes[index].Nodes.Add(txtten.Text + "(" + txtMa.Text + ")");
            treeView1.ExpandAll();
        }

        
    }
}
