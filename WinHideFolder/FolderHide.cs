using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinHideFolder
{
    public partial class FolderHide : Form
    {
        DirectoryInfo ch;
        public FolderHide()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ch = new DirectoryInfo(txtFilePath.Text);
                ch.Attributes = FileAttributes.Hidden;
                MessageBox.Show("Hidden");
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ch = new DirectoryInfo(txtFilePath.Text);
                ch.Attributes = FileAttributes.Normal;
                MessageBox.Show("Visible");
            }
            catch { }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
