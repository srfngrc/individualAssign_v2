namespace Indiv_AssignSRFN
{
    partial class Form2
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
            this.labelAreYouSure = new System.Windows.Forms.Label();
            this.Btn_imsure = new System.Windows.Forms.Button();
            this.Btn_notsure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAreYouSure
            // 
            this.labelAreYouSure.AutoSize = true;
            this.labelAreYouSure.Location = new System.Drawing.Point(58, 68);
            this.labelAreYouSure.Name = "labelAreYouSure";
            this.labelAreYouSure.Size = new System.Drawing.Size(200, 13);
            this.labelAreYouSure.TabIndex = 0;
            this.labelAreYouSure.Text = "Are you sure you wanna quite the game?";
            this.labelAreYouSure.Click += new System.EventHandler(this.LabelAreYouSure_Click);
            // 
            // Btn_imsure
            // 
            this.Btn_imsure.Location = new System.Drawing.Point(35, 128);
            this.Btn_imsure.Name = "Btn_imsure";
            this.Btn_imsure.Size = new System.Drawing.Size(98, 45);
            this.Btn_imsure.TabIndex = 1;
            this.Btn_imsure.Text = "Yes";
            this.Btn_imsure.UseVisualStyleBackColor = true;
            this.Btn_imsure.Click += new System.EventHandler(this.Btn_imsure_Click);
            // 
            // Btn_notsure
            // 
            this.Btn_notsure.Location = new System.Drawing.Point(163, 128);
            this.Btn_notsure.Name = "Btn_notsure";
            this.Btn_notsure.Size = new System.Drawing.Size(98, 45);
            this.Btn_notsure.TabIndex = 2;
            this.Btn_notsure.Text = "No";
            this.Btn_notsure.UseVisualStyleBackColor = true;
            this.Btn_notsure.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 237);
            this.Controls.Add(this.Btn_notsure);
            this.Controls.Add(this.Btn_imsure);
            this.Controls.Add(this.labelAreYouSure);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAreYouSure;
        private System.Windows.Forms.Button Btn_imsure;
        private System.Windows.Forms.Button Btn_notsure;
    }
}