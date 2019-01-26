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
        string word;
        int false_hits = 0;

        public Form1()
        {
            InitializeComponent();
            draw_word();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string letter = textBox1.Text;
            bool hit = false;
            int where_hit = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (Convert.ToString(word[i]) == letter)
                {
                    hit = true;
                    where_hit = i;
                }

                if (where_hit == 1) { label2.Text = letter; }
                if (where_hit == 2) { label3.Text = letter; }
                if (where_hit == 3) { label4.Text = letter; }
                if (where_hit == 4) { label5.Text = letter; }
                if (where_hit == 5) { label6.Text = letter; }
            }

            if (hit == false)
            {
                false_hits += 1;
            }
        }

        private void draw_word()
        {
            
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
