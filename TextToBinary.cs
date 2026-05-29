using System;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Encrypt___Decrypt
{
    public partial class TextToBinary : Form
    {
        public TextToBinary()
        {
            InitializeComponent();
        }
       

        string EncryptText()
        {
            const short EncryptionKey = 2;
            char[] TEXT = textBox1.Text.ToCharArray();
            for (int i = 0; i < TEXT.Length; i++)
            {
                TEXT[i] = (char)(TEXT[i] + EncryptionKey);
            }
            return new string(TEXT);  
        }

        
        string CharToBinary(char c)
        {
            return Convert.ToString(c, 2).PadLeft(8, '0');
        }


        private void btnEN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("No Text To Encrypt", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                char[] ETB = EncryptText().ToCharArray();
                StringBuilder binaryText = new StringBuilder();
                for (int i = 0; i < ETB.Length; i++)
                {
                    binaryText.Append(CharToBinary(ETB[i])).Append("   ");
                }
                textBox2.Text = binaryText.ToString().Trim();

                
                label2.Visible = true;
                textBox2.Visible = true;
                button3.Visible = true;
                button1.Visible = true;
                label1.Visible = false;
                textBox1.Visible = false;
                button2.Visible = false;
                btnEN.Visible = false;


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

        private void button1_Click(object sender, EventArgs e)
        { if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("No Text To Decrypt", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            label1.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;
            btnEN.Visible = true;
        }
    }
}
