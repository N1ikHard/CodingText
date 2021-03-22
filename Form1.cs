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
        byte[] array;
        private void BinCodeButton_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
           array = Coding.BinEncrypt(richTextBox1.Text,out SaveSize);
            string txt = "";
            foreach(byte b in array)
            {
                txt += b;
            }
            SaveSize = array.Length;
            richTextBox2.Text += txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = Coding.Translate(array, SaveSize);
            richTextBox2.Text = txt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
