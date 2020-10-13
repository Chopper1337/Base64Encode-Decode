using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64Encode_Decode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        public static string Base64Encode(string plainText)
        {
            try
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainTextBytes);
            }
            catch 
            {
                string i = "Decoded text goes here!";
                return i;
            }
        }

        public static string Base64Decode(string base64EncodedData)
        {
            try { 
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch
            {
                string i = "Decoded text goes here!";
                return i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 0 ^ textBox2.TextLength > 0) {
                if (tripleBTN.Checked)
                {
                    if (textBox1.TextLength > 1)
                    {
                        String partOne;
                        String partTwo;
                        String partThree;
                        partOne = Base64Encode(textBox1.Text);
                        partTwo = Base64Encode(partOne);
                        partThree = Base64Encode(partTwo);
                        textBox2.Text = partThree;
                    }
                    else
                    {
                        String partOne1;
                        String partTwo1;
                        String partThree1;
                        partOne1 = Base64Decode(textBox2.Text);
                        partTwo1 = Base64Decode(partOne1);
                        partThree1 = Base64Decode(partTwo1);
                        textBox1.Text = partThree1;
                    }
                }
                else
                {
                    if (textBox1.TextLength > 1)
                    {
                        textBox2.Text = Base64Encode(textBox1.Text);
                    }
                    else
                    {
                        textBox1.Text = Base64Decode(textBox2.Text);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            { 
            Clipboard.SetText(textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            { 
            Clipboard.SetText(textBox2.Text);
            }
        }
    }
}
