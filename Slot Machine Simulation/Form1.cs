//I worked alone on this assingment
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine_Simulation
{
    public partial class Form1 : Form
    {

        double totalAmtBid = 0;
        double totalAmtWon= 0;
        public Form1()
        {
            InitializeComponent();
        }
       
        Random rand = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            spinPictureBox1.Image = Image.FromFile("1.png");
            spinPictureBox2.Image = Image.FromFile("2.png");
            spinPictureBox3.Image = Image.FromFile("3.png");
        }
        //spin picture method
        private int spinPicture()
        {
            int number1;
            int number2;
            int number3;
            number1 = rand.Next(1, 6);
            number2 = rand.Next(1, 6);
            number3 = rand.Next(1, 6);
            if (spinPictureBox1.Image != null)
            {
                spinPictureBox1.Image.Dispose();
                spinPictureBox1.Image = Image.FromFile(number1.ToString() + ".png");
            }
            if (spinPictureBox2.Image != null)
            {
                spinPictureBox2.Image.Dispose();
                spinPictureBox2.Image = Image.FromFile(number2.ToString() + ".png");
            }
            if (spinPictureBox3.Image != null)
            {
                spinPictureBox3.Image.Dispose();
                spinPictureBox3.Image = Image.FromFile(number3.ToString() + ".png");
            }
            int numMatches = 0;
            if (number1 == number2)
            {
                numMatches++;
            }
            if (number1==number3)
            {
                numMatches++;
            }
            if (number2==number3)
            {
                numMatches++;
            }


            return numMatches; //returns the number of successful matches
        

        }
        private double calculate(int numMatches, string amount)
        {
            int amt = 0;

            int.TryParse(amount, out amt);
            double amtWon = 0.00;
            switch (numMatches)
            {
                case 0:
                    amtWon = 0.00;
                    break;
                case 1:
                    amtWon = amt * 2;
                    break;

                default:
                    amtWon = amt * 3;
                    break;

            }

            return amtWon;
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            
          
            int wagerAmount = 0;
            int.TryParse(amountTextBox.Text, out wagerAmount);

            if (wagerAmount <= 0)
            {
                MessageBox.Show(" Wager amount must be greater than 0 ");

                return;
            }
            int numMatches = spinPicture();
            totalAmtBid = totalAmtBid + wagerAmount;
            


            double amtWon = calculate(numMatches, amountTextBox.Text);
            totalAmtWon = totalAmtWon + amtWon;
            MessageBox.Show(amtWon.ToString());


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You wagered " + totalAmtBid + " and you won " + totalAmtWon);
            this.Close();

        }

      
    }
}
