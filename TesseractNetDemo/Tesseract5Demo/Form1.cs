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

namespace Tesseract5Demo
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
                textBox1.Text = path;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                var images = Directory.EnumerateFiles(textBox1.Text).Where(f => f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) || f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase));
                //foreach (var image in images)
                //{
                //    TesseractHelp.OCR(image, "tha");
                //}
                var task = new Task(() =>
                {
                    TesseractHelp.OCR(images.ToList(), "tha");

                });
                task.Start();
            }
        }
    }
}
