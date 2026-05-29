using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt___Decrypt
{
    public partial class TextToText : Form
    {
        void EncryptText()
        {
            const short EncryptionKey = 2;
            char[] TEXT = textBox1.Text.ToCharArray();
            for (int i = 0; i < TEXT.Length; i++)
            {
                TEXT[i] = (char)(TEXT[i] + EncryptionKey);
            }
            textBox2.Text = new string(TEXT);
        }
        void DecryptText()
        {
            const short EncryptionKey = 2;
            char[] TEXT = textBox2.Text.ToCharArray();
            for (int i = 0; i < TEXT.Length; i++)
            {
                TEXT[i] = (char)(TEXT[i] - EncryptionKey);
            }
            textBox1.Text = new string(TEXT);

        }
        public TextToText()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnEN_Click(object sender, EventArgs e)
        {if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("No Text To Encrypt", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else 
            {
                EncryptText();
                textBox1.Clear();
                label2.Visible=true;
                textBox2.Visible=true;
                button3.Visible=true;
                btnDE.Visible=true;
                label1.Visible = false;
                textBox1.Visible = false;
                button2.Visible = false;
                btnEN.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox2.Text.Length == 0)
                {
                    MessageBox.Show("No Text To Decrypt", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DecryptText();
                    label1.Visible = true;
                    textBox1.Visible = true;
                    button2.Visible = true;
                    btnEN.Visible = true;
                }   
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
