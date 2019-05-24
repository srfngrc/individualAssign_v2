using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indiv_AssignSRFN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int OptionSelected_MACHINE = 0;
        int OptionSelected_USER = 0;
        string Final_Result;

        //0.- no option selected
        //1.- ROCK option selected
        //2.- PAPER option selected
        //3.- SCISSORS option selected

        public Random RN_rockpaperscissors = new Random();


        private void Btn_MACHINESGUESS_Click(object sender, EventArgs e)
        {
            OptionSelected_USER = 0;
            OptionSelected_MACHINE = 0;
            OptionSelected_MACHINE = RN_rockpaperscissors.Next(1, 3);
            pictureBox1.Image = global::Indiv_AssignSRFN.Properties.Resources.QUESTIONMARK;
        }

        public void PictureBox2_Click(object sender, EventArgs e)
        {
            OptionSelected_USER = 1;
            if (OptionSelected_MACHINE == 1) pictureBox1.Image = global::Indiv_AssignSRFN.Properties.Resources.ROCK;
            if (OptionSelected_MACHINE == 2) pictureBox1.Image = global::Indiv_AssignSRFN.Properties.Resources.PAPER;
            if (OptionSelected_MACHINE == 3) pictureBox1.Image = global::Indiv_AssignSRFN.Properties.Resources.SCISSORS;
            Calculations();
        }

        public void PictureBox2_Click_1(object sender, EventArgs e)
        {
            OptionSelected_USER = 2;
            if (OptionSelected_MACHINE == 1) pictureBox1.Image = global::Indiv_AssignSRFN.Properties.Resources.ROCK;
            if (OptionSelected_MACHINE == 2) pictureBox1.Image = global::Indiv_AssignSRFN.Properties.Resources.PAPER;
            if (OptionSelected_MACHINE == 3) pictureBox1.Image = global::Indiv_AssignSRFN.Properties.Resources.SCISSORS;
            Calculations();
        }

        public void PictureBox3_Click(object sender, EventArgs e)
        {
            OptionSelected_USER = 3;
            if (OptionSelected_MACHINE == 1) pictureBox1.Image = global::Indiv_AssignSRFN.Properties.Resources.ROCK;
            if (OptionSelected_MACHINE == 2) pictureBox1.Image = global::Indiv_AssignSRFN.Properties.Resources.PAPER;
            if (OptionSelected_MACHINE == 3) pictureBox1.Image = global::Indiv_AssignSRFN.Properties.Resources.SCISSORS;
            Calculations();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }

        public void Calculations()
        {
            if (
                ((OptionSelected_MACHINE == 1) && (OptionSelected_USER == 1)) ||
                ((OptionSelected_MACHINE == 2) && (OptionSelected_USER == 2)) ||
                ((OptionSelected_MACHINE == 3) && (OptionSelected_USER == 3))
                )
            {
                Final_Result = "DRAW. Play again! :)";
                picSmurf_RESULT.Image = global::Indiv_AssignSRFN.Properties.Resources.SMURFdraw;
            }

            if (OptionSelected_MACHINE == 1 && OptionSelected_USER == 2)
            {
                Final_Result = "USER WON!";
                picSmurf_RESULT.Image = global::Indiv_AssignSRFN.Properties.Resources.SMURFWon;
            }
            if (OptionSelected_MACHINE == 1 && OptionSelected_USER == 3)
            {
                Final_Result = "MACHINE WON!";
                picSmurf_RESULT.Image = global::Indiv_AssignSRFN.Properties.Resources.SMURFlost1;
            }
            if (OptionSelected_MACHINE == 2 && OptionSelected_USER == 1)
            {
                Final_Result = "MACHINE WON!";
                picSmurf_RESULT.Image = global::Indiv_AssignSRFN.Properties.Resources.SMURFlost1;
            }
            if (OptionSelected_MACHINE == 2 && OptionSelected_USER == 3)
            {
                Final_Result = "USER WON!";
                picSmurf_RESULT.Image = global::Indiv_AssignSRFN.Properties.Resources.SMURFWon;
            }
            if (OptionSelected_MACHINE == 3 && OptionSelected_USER == 1)
            {
                Final_Result = "USER WON!";
                picSmurf_RESULT.Image = global::Indiv_AssignSRFN.Properties.Resources.SMURFWon;
            }
            if (OptionSelected_MACHINE == 3 && OptionSelected_USER == 2)
            {
                Final_Result = "MACHINE WON!";
                picSmurf_RESULT.Image = global::Indiv_AssignSRFN.Properties.Resources.SMURFlost1;
            }

            txt_RESULT.Text = Final_Result;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PicSmurf_Click(object sender, EventArgs e)
        {
            Console.WriteLine("DO NOT TOUCH THE SMURF!!!!  :(");
        }

    }
}
