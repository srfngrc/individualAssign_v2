namespace Indiv_AssignSRFN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_MACHINESGUESS = new System.Windows.Forms.Button();
            this.Btn_ROCK = new System.Windows.Forms.Button();
            this.Btn_PAPER = new System.Windows.Forms.Button();
            this.Btn_SCISSORS = new System.Windows.Forms.Button();
            this.txt_RESULT = new System.Windows.Forms.TextBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_CALCULATERESULT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_MACHINESGUESS
            // 
            this.Btn_MACHINESGUESS.Location = new System.Drawing.Point(277, 22);
            this.Btn_MACHINESGUESS.Name = "Btn_MACHINESGUESS";
            this.Btn_MACHINESGUESS.Size = new System.Drawing.Size(237, 114);
            this.Btn_MACHINESGUESS.TabIndex = 0;
            this.Btn_MACHINESGUESS.Text = "MACHINE\'S GUESS";
            this.Btn_MACHINESGUESS.UseVisualStyleBackColor = true;
            this.Btn_MACHINESGUESS.Click += new System.EventHandler(this.Btn_MACHINESGUESS_Click);
            // 
            // Btn_ROCK
            // 
            this.Btn_ROCK.Location = new System.Drawing.Point(22, 191);
            this.Btn_ROCK.Name = "Btn_ROCK";
            this.Btn_ROCK.Size = new System.Drawing.Size(237, 114);
            this.Btn_ROCK.TabIndex = 1;
            this.Btn_ROCK.Text = "ROCK";
            this.Btn_ROCK.UseVisualStyleBackColor = true;
            this.Btn_ROCK.Click += new System.EventHandler(this.Btn_ROCK_Click);
            // 
            // Btn_PAPER
            // 
            this.Btn_PAPER.Location = new System.Drawing.Point(277, 191);
            this.Btn_PAPER.Name = "Btn_PAPER";
            this.Btn_PAPER.Size = new System.Drawing.Size(237, 114);
            this.Btn_PAPER.TabIndex = 2;
            this.Btn_PAPER.Text = "PAPER";
            this.Btn_PAPER.UseVisualStyleBackColor = true;
            this.Btn_PAPER.Click += new System.EventHandler(this.Btn_PAPER_Click);
            // 
            // Btn_SCISSORS
            // 
            this.Btn_SCISSORS.Location = new System.Drawing.Point(539, 191);
            this.Btn_SCISSORS.Name = "Btn_SCISSORS";
            this.Btn_SCISSORS.Size = new System.Drawing.Size(237, 114);
            this.Btn_SCISSORS.TabIndex = 3;
            this.Btn_SCISSORS.Text = "SCISSORS";
            this.Btn_SCISSORS.UseVisualStyleBackColor = true;
            this.Btn_SCISSORS.Click += new System.EventHandler(this.Btn_SCISSORS_Click);
            // 
            // txt_RESULT
            // 
            this.txt_RESULT.Location = new System.Drawing.Point(366, 378);
            this.txt_RESULT.Name = "txt_RESULT";
            this.txt_RESULT.Size = new System.Drawing.Size(200, 20);
            this.txt_RESULT.TabIndex = 4;
 
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(667, 369);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(109, 50);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "EXIT ";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_CALCULATERESULT
            // 
            this.Btn_CALCULATERESULT.Location = new System.Drawing.Point(156, 356);
            this.Btn_CALCULATERESULT.Name = "Btn_CALCULATERESULT";
            this.Btn_CALCULATERESULT.Size = new System.Drawing.Size(161, 63);
            this.Btn_CALCULATERESULT.TabIndex = 7;
            this.Btn_CALCULATERESULT.Text = "CALCULATE RESULT";
            this.Btn_CALCULATERESULT.UseVisualStyleBackColor = true;
            this.Btn_CALCULATERESULT.Click += new System.EventHandler(this.Btn_CALCULATERESULT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 442);
            this.Controls.Add(this.Btn_CALCULATERESULT);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.txt_RESULT);
            this.Controls.Add(this.Btn_SCISSORS);
            this.Controls.Add(this.Btn_PAPER);
            this.Controls.Add(this.Btn_ROCK);
            this.Controls.Add(this.Btn_MACHINESGUESS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_MACHINESGUESS;
        private System.Windows.Forms.Button Btn_ROCK;
        private System.Windows.Forms.Button Btn_PAPER;
        private System.Windows.Forms.Button Btn_SCISSORS;
        private System.Windows.Forms.TextBox txt_RESULT;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_CALCULATERESULT;
    }
}

