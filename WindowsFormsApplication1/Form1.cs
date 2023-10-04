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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            listphai.Items.Add(listtrai.SelectedItems);
            listtrai.Items.Remove(listtrai.SelectedItems);
        }

        private void btntatcaPhai_Click(object sender, EventArgs e)
        {
            listphai.Items.AddRange(listtrai.Items);
            listtrai.Items.Clear();
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            listtrai.Items.Add(listphai.SelectedItems);
            listphai.Items.Remove(listphai.SelectedItems);
        }

        private void btntatcaTrai_Click(object sender, EventArgs e)
        {
            listtrai.Items.AddRange(listphai.Items);
            listphai.Items.Clear();
        }

    }
}
