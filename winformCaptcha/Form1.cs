using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformCaptcha
{
    public partial class winformCaptcha : Form
    {
        public winformCaptcha()
        {
            InitializeComponent();
        }

            /* 
             * AUTHOR BY : Semih YOLCU
             * mail : semihyolcu@protonmail.com
             * date : 05.12.2018 02:20
             */

        // have a simple set of characters and numbers
        String[] alphabet = { "a", "b", "c", "d", "e", "f", "c", "c", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        String[] numberArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        int a, b, c;
        String result;
        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            create();

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
            clear();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            honest(resultText.Text);
        }


        public void create()
        {

            // First Captcha Create

            for (a = 0; a < alphabet.Length; a++)
            {

                //Nested Loop

                for (int b = 0; b < numberArray.Length; b++)
                {

                    for (c = 0; c < 10; c++)
                    {
                        int r1 = r.Next(26);
                        // Alphabet size
                        int r2 = r.Next(8);
                        // Number size
                        int r3 = r.Next(26);
                        // Alphabet size
                        int r4 = r.Next(8);
                        // Number size
                        result = alphabet[r1] + numberArray[r2] + alphabet[r3] + numberArray[r4];
                    }


                }

            }

            charOne.Text = result;
        }



        public void honest(String result)
        {
            if (result.Equals(this.result))
            {
                MessageBox.Show("Entered Successful", "Successful");
            }
            else if (result.Equals(""))
            {
                MessageBox.Show("Please Entered Text", "Danger!");
            }
            else
            {
                MessageBox.Show("Entered Wrong", "Error");
                clear();
                Refresh();
            }
        }

        public void Refresh()
        {
            create();
        }

        public void clear()
        {
            resultText.Text = "";
        }
    }
}