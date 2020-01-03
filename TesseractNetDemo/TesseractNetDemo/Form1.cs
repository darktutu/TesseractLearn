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

namespace TesseractNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = folderBrowserDialog1.SelectedPath;
                var images = Directory.EnumerateFiles(path).Where(f => f.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) || f.EndsWith("png", StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}
