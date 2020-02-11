using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox3.Text);
            string message = textBox2.Text;
            textBox1.Text = cesarcrypto.encrypt(message, x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox3.Text);
            string message = textBox1.Text;
            textBox4.Text = cesardecrypte.decrypt(message, x);
        }
    }
}
public class cesarcrypto
{
  
    public static string encrypt(string text, int key)
    { string result = "";
        for(int i=0;i<text.Length;i++)
        {
            if(char.IsUpper(text[i]))
            {
                result += Convert.ToChar(Convert.ToInt32(text[i] + key - 65) % 26 + 65);
            }
            else
            {
                result += Convert.ToChar(Convert.ToInt32(text[i] + key - 97) % 26 + 97);
        }
        }
        return result;
    }

}
public class cesardecrypte
{
    public static string decrypt(string text, int key)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                result += Convert.ToChar(Convert.ToInt32(text[i] - key - 65) % 26 + 65);
            }
            else
            {
                result += Convert.ToChar(Convert.ToInt32(text[i] - key - 97) % 26 + 97);
            }
        }
        return result;
    }

}