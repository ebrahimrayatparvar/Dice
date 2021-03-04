using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RandomDice()
        {
            Random rand = new Random();
            var dice = rand.Next(1, 7);

            ShowPicrandom();

            label1.Text = dice.ToString();
            switch (dice)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.dice_1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.dice_2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.dice_3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.dice_4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.dice_5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.dice_6;
                    break;
            }
        }

        private void ShowPicrandom()
        {
            for (int i = 0; i < 20; i++)
            {
                Random rand = new Random();
                var dice = rand.Next(1, 7);
                Thread.Sleep(100);
                switch (dice)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.dice_1;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.dice_2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.dice_3;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.dice_4;
                        break;
                    case 5:
                        pictureBox1.Image = Properties.Resources.dice_5;
                        break;
                    case 6:
                        pictureBox1.Image = Properties.Resources.dice_6;
                        break;
                }
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomDice();
        }
    }
}
