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
            OptionSelected_MACHINE = RN_rockpaperscissors.Next(1, 3);
        }
        private void Btn_ROCK_Click(object sender, EventArgs e)
        {
            OptionSelected_USER = 1;
        }

        private void Btn_PAPER_Click(object sender, EventArgs e)
        {
            OptionSelected_USER = 2;
        }

        private void Btn_SCISSORS_Click(object sender, EventArgs e)
        {
            OptionSelected_USER = 3;
        }

        private void Btn_CALCULATERESULT_Click(object sender, EventArgs e)
        {

            if (
                ((OptionSelected_MACHINE == 1) && (OptionSelected_USER == 1)) ||
                ((OptionSelected_MACHINE == 2) && (OptionSelected_USER == 2)) ||
                ((OptionSelected_MACHINE == 3) && (OptionSelected_USER == 3))
                )
            {
                Final_Result = "DEUCE. Play again! :)";
            }

            if (OptionSelected_MACHINE == 1 && OptionSelected_USER == 2)
            {
                Final_Result = "USER";
            }
            if (OptionSelected_MACHINE == 1 && OptionSelected_USER == 3)
            {
                Final_Result = "MACHINE";
            }
            if (OptionSelected_MACHINE == 2 && OptionSelected_USER == 1)
            {
                Final_Result = "MACHINE";
            }
            if (OptionSelected_MACHINE == 2 && OptionSelected_USER == 3)
            {
                Final_Result = "USER";
            }
            if (OptionSelected_MACHINE == 3 && OptionSelected_USER == 1)
            {
                Final_Result = "USER";
            }
            if (OptionSelected_MACHINE == 3 && OptionSelected_USER == 2)
            {
                Final_Result = "MACHINE";
            }

            txt_RESULT.Text = Final_Result;

        }

        //public string Label1_Click(object sender, EventArgs e)
        //{
            
        //}




        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
