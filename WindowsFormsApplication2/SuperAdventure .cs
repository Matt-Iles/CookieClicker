using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int playerPoints = 0;

        //Addons
        int _addon1_50p = 0;
        int _addon1_100p = 0;
        int _addon1_250p = 0;
        int _addon1_500p = 0;
        int _addon1_1000p = 0;
        int _addon1_2000p = 0;
        int _addon1_3000p = 0;
        int _addon1_4000p = 0;
        int _addon1_5000p = 0;
        int _addon1_10000p = 0;

        //Timer count
        int timerCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click_Click(object sender, EventArgs e)
        {
            playerPoints += 1;
            label_points.Text = playerPoints.ToString() + " Points" ;
        }

        private void button_addon_1_Click_1(object sender, EventArgs e)
        {
            if (playerPoints >= 50)
            {
                _addon1_50p += 1;
                playerPoints -= 50;
            }
            else
            {
                MessageBox.Show("oof, not enough");
            }
        }

        private void button_addon_2_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 100)
            {
                _addon1_100p += 1;
                playerPoints -= 100;
            }
            else
            {
                MessageBox.Show("oof, not enough");
            }
        }

        private void button_addon_3_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 250)
            {
                _addon1_250p += 1;
                playerPoints -= 250;
            }
            else
            {
                MessageBox.Show("oof, not enough");
            }
        }

        private void button_addon_4_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 500)
            {
                _addon1_500p += 1;
                playerPoints -= 500;
            }
            else
            {
                MessageBox.Show("oof, not enough");
            }
        }
        private void button_addon_5_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 1000)
            {
                _addon1_1000p += 1;
                playerPoints -= 1000;
            }
            else
            {
                MessageBox.Show("oof, not enough");
            }
        }
        private void button_addon_6_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 2000)
            {
                _addon1_2000p += 1;
                playerPoints -= 2000;
            }
            else
            {
                MessageBox.Show("oof, not enough");
            }
        }
        private void button_addon_7_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 3000)
            {
                _addon1_3000p += 1;
                playerPoints -= 3000;
            }
            else
            {
                MessageBox.Show("oof, not enough");
            }
        }
        private void button_addon_8_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 4000)
            {
                _addon1_4000p += 1;
                playerPoints -= 4000;
            }
            else
            {
                MessageBox.Show("oof, not enough");
            }
        }
        private void button_addon_9_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 5000)
            {
                _addon1_5000p += 1;
                playerPoints -= 5000;
            }
            else
            {
                MessageBox.Show("oof, not enough");
            }
        }
        private void button_addon_10_Click(object sender, EventArgs e)
        {
            if (playerPoints >= 10000)
            {
                _addon1_10000p += 1;
                playerPoints -= 10000;
            }
            else
            {
                MessageBox.Show("oof, not enough");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //button_Check();
            timerCount += 1;

            playerPoints += _addon1_1000p;

            case points
            {}

            if (timerCount % 2 == 0)
            {
                playerPoints += _addon1_500p;
            }
            if (timerCount % 4 == 0)
            {
                playerPoints += _addon1_250p;
            }
            if (timerCount % 10 == 0)
            {
                playerPoints += _addon1_100p;
            }
            if (timerCount % 20 == 0)
            {
                playerPoints += _addon1_50p;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label_points.Text = playerPoints.ToString() + " Points";
        }

        private void button_Check(object sender, EventArgs e)
        {
            if (playerPoints < 50)
            {
                button_addon_1.Enabled = false;
            }
        }

        

        

    }
}
