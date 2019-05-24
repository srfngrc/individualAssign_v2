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
            this.txt_RESULT = new System.Windows.Forms.TextBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.picSCISSORSuser = new System.Windows.Forms.PictureBox();
            this.picPAPERuser = new System.Windows.Forms.PictureBox();
            this.picROCKuser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picSmurf_RESULT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSCISSORSuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPAPERuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picROCKuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmurf_RESULT)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_MACHINESGUESS
            // 
            this.Btn_MACHINESGUESS.Location = new System.Drawing.Point(104, 22);
            this.Btn_MACHINESGUESS.Name = "Btn_MACHINESGUESS";
            this.Btn_MACHINESGUESS.Size = new System.Drawing.Size(225, 97);
            this.Btn_MACHINESGUESS.TabIndex = 0;
            this.Btn_MACHINESGUESS.Text = "          MACHINE\'S GUESS \r\n\r\n\r\n   [HIDDEN UNTIL YOU PRESS ONE\r\n OF THE THREE HAN" +
    "D OPTIONS]";
            this.Btn_MACHINESGUESS.UseVisualStyleBackColor = true;
            this.Btn_MACHINESGUESS.Click += new System.EventHandler(this.Btn_MACHINESGUESS_Click);
            // 
            // txt_RESULT
            // 
            this.txt_RESULT.Location = new System.Drawing.Point(145, 373);
            this.txt_RESULT.Name = "txt_RESULT";
            this.txt_RESULT.Size = new System.Drawing.Size(127, 20);
            this.txt_RESULT.TabIndex = 4;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(689, 357);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(109, 50);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "EXIT ";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // picSCISSORSuser
            // 
            this.picSCISSORSuser.Image = global::Indiv_AssignSRFN.Properties.Resources.SCISSORS;
            this.picSCISSORSuser.Location = new System.Drawing.Point(528, 147);
            this.picSCISSORSuser.Name = "picSCISSORSuser";
            this.picSCISSORSuser.Size = new System.Drawing.Size(200, 150);
            this.picSCISSORSuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSCISSORSuser.TabIndex = 12;
            this.picSCISSORSuser.TabStop = false;
            this.picSCISSORSuser.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // picPAPERuser
            // 
            this.picPAPERuser.Image = global::Indiv_AssignSRFN.Properties.Resources.PAPER;
            this.picPAPERuser.Location = new System.Drawing.Point(296, 147);
            this.picPAPERuser.Name = "picPAPERuser";
            this.picPAPERuser.Size = new System.Drawing.Size(200, 150);
            this.picPAPERuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPAPERuser.TabIndex = 11;
            this.picPAPERuser.TabStop = false;
            this.picPAPERuser.Click += new System.EventHandler(this.PictureBox2_Click_1);
            // 
            // picROCKuser
            // 
            this.picROCKuser.Image = global::Indiv_AssignSRFN.Properties.Resources.ROCK;
            this.picROCKuser.Location = new System.Drawing.Point(49, 147);
            this.picROCKuser.Name = "picROCKuser";
            this.picROCKuser.Size = new System.Drawing.Size(200, 150);
            this.picROCKuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picROCKuser.TabIndex = 10;
            this.picROCKuser.TabStop = false;
            this.picROCKuser.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Indiv_AssignSRFN.Properties.Resources.QUESTIONMARK;
            this.pictureBox1.Location = new System.Drawing.Point(473, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // picSmurf_RESULT
            // 
            this.picSmurf_RESULT.Image = global::Indiv_AssignSRFN.Properties.Resources.SMURFwaiting;
            this.picSmurf_RESULT.Location = new System.Drawing.Point(352, 319);
            this.picSmurf_RESULT.Name = "picSmurf_RESULT";
            this.picSmurf_RESULT.Size = new System.Drawing.Size(168, 111);
            this.picSmurf_RESULT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSmurf_RESULT.TabIndex = 8;
            this.picSmurf_RESULT.TabStop = false;
            this.picSmurf_RESULT.Click += new System.EventHandler(this.PicSmurf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 442);
            this.Controls.Add(this.picSCISSORSuser);
            this.Controls.Add(this.picPAPERuser);
            this.Controls.Add(this.picROCKuser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picSmurf_RESULT);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.txt_RESULT);
            this.Controls.Add(this.Btn_MACHINESGUESS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSCISSORSuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPAPERuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picROCKuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmurf_RESULT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_MACHINESGUESS;
        private System.Windows.Forms.TextBox txt_RESULT;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.PictureBox picSmurf_RESULT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picROCKuser;
        private System.Windows.Forms.PictureBox picPAPERuser;
        private System.Windows.Forms.PictureBox picSCISSORSuser;
    }
}

