using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj08
{
    public partial class FrmMain : Form
    {
        //declare class Dice
        Dice
            dice = null;


        public FrmMain()
        {
            InitializeComponent();

            //Initialize class Dice
            dice = new Dice();
        }

        //Declare some strings
        string
            one = System.Environment.NewLine + " l ",
            two = "l  " + System.Environment.NewLine + System.Environment.NewLine + "  l",
            three = "l  " + System.Environment.NewLine + " l " + System.Environment.NewLine + "  l",
            four = "l l" + System.Environment.NewLine + System.Environment.NewLine + "l l",
            five = "l l" + System.Environment.NewLine + " l " + System.Environment.NewLine + "l l",
            six = "l l" + System.Environment.NewLine + "l l" + System.Environment.NewLine + "l l";
            
        //Declare some ints
        int
            leftDie = 0,
            rightDie = 0;

        /// <summary>
        /// Button handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoll_Click(object sender, EventArgs e)
        {
            //call the Roll dice method from out class
            dice.RollDice(ref rightDie, ref leftDie);

            //Display appropraite message in text box according to the roll
            if (rightDie == 1 && leftDie == 1)
            {
                txtBoxEyes.Text = "You rolled Snake Eyes!";
            }

            else if (rightDie == 6 && leftDie == 6)
            {
                txtBoxEyes.Text = "You rolled Box Cars!";
            }

            else
            {
                txtBoxEyes.Text = "";
            }

            //Display the proper dice in Multiline right die text box
            switch (rightDie)
            {
                case 1:
                    txtRightDie.Text = one;
                    break;

                case 2:
                    txtRightDie.Text = two;
                    break;

                case 3:
                    txtRightDie.Text = three;
                    break;

                case 4:
                    txtRightDie.Text = four;
                    break;

                case 5:
                    txtRightDie.Text = five;
                    break;

                case 6:
                    txtRightDie.Text = six;
                    break;
            }

            //Display the proper dice in multiline left die text box
            switch (leftDie)
            {
                case 1:
                    txtLeftDie.Text = one;
                    break;

                case 2:
                    txtLeftDie.Text = two;
                    break;

                case 3:
                    txtLeftDie.Text = three;
                    break;

                case 4:
                    txtLeftDie.Text = four;
                    break;

                case 5:
                    txtLeftDie.Text = five;
                    break;

                case 6:
                    txtLeftDie.Text = six;
                    break;
            }
        }

        /// <summary>
        /// About handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display message box showing programmer and class
            MessageBox.Show("Matthew Vaughan\nCS1400 Sec 003");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the application
            this.Close();
        }
    }
}
