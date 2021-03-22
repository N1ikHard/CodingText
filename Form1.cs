using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int SaveSize;

        private void BinCodeButton_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
           byte []array = Coding.BinEncrypt(richTextBox1.Text,out SaveSize);
            string txt = "";
            foreach(byte b in array)
            {
                txt += b;
            }
            richTextBox2.Text += txt;
        }
    }
}
