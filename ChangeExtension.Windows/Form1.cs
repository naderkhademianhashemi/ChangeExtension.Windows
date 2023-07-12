using ChangeExtension.Windows.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeExtension.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNewFileExt.Enabled = false;
        }

        public string GetPath()
        {
            var fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
                return fdlg.FileName;
            return "";
        }

        private void btnNewFileExt_Click(object sender, EventArgs e)
        {
            string suffix = txtExt.Text;
            Extens.NewExtCopy(txtPath.Text,suffix);
            MessageBox.Show("success");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            btnNewFileExt.Enabled = true;
            txtPath.Text = GetPath();
        }
    }
}
