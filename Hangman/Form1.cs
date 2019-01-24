using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void draw_word()
        {
            string word;
            string[] words = { "krokusy", "liliput", "krakers" };
            int howManyWords = words.Length;

            Random gen = new Random();
            int IndexOfWord = gen.Next(0, howManyWords);

            word = words[IndexOfWord];
            label1.Text = Convert.ToString(word[0]);
            label7.Text = Convert.ToString(word[6]);
        }
    }
}
