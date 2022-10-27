namespace ChooseYourOwnDeath
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
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.OutputStoryLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.Location = new System.Drawing.Point(12, 320);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(101, 43);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.Location = new System.Drawing.Point(12, 369);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(101, 44);
            this.buttonB.TabIndex = 1;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(12, 419);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(101, 50);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // labelA
            // 
            this.labelA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelA.Location = new System.Drawing.Point(137, 320);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(327, 49);
            this.labelA.TabIndex = 3;
            // 
            // labelB
            // 
            this.labelB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelB.Location = new System.Drawing.Point(137, 369);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(327, 50);
            this.labelB.TabIndex = 4;
            // 
            // labelC
            // 
            this.labelC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelC.Location = new System.Drawing.Point(137, 419);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(327, 53);
            this.labelC.TabIndex = 5;
            // 
            // OutputStoryLabel
            // 
            this.OutputStoryLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.OutputStoryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputStoryLabel.Location = new System.Drawing.Point(12, 8);
            this.OutputStoryLabel.Name = "OutputStoryLabel";
            this.OutputStoryLabel.Size = new System.Drawing.Size(452, 93);
            this.OutputStoryLabel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(476, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OutputStoryLabel);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label OutputStoryLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

