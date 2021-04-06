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

namespace forBlocks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Blocks b = new Blocks();

            textBox2.Text = b.EncryptText(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Blocks b = new Blocks();

            textBox2.Text = b.DecryptText(textBox1.Text);

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Текстовый документ (*.txt) | *.txt|Все файлы (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(open.FileName, Encoding.UTF8);

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Текстовый документ (*.txt) | *.txt|Все файлы (*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(save.FileName);

                streamWriter.WriteLine(textBox2.Text);
                streamWriter.Close();
            }
        }

       
    }
}
