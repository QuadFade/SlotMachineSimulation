namespace Slot_Machine_Simulation
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
            this.spinPictureBox1 = new System.Windows.Forms.PictureBox();
            this.spinPictureBox2 = new System.Windows.Forms.PictureBox();
            this.spinPictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spinPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // spinPictureBox1
            // 
            this.spinPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.spinPictureBox1.Name = "spinPictureBox1";
            this.spinPictureBox1.Size = new System.Drawing.Size(154, 176);
            this.spinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spinPictureBox1.TabIndex = 0;
            this.spinPictureBox1.TabStop = false;
            // 
            // spinPictureBox2
            // 
            this.spinPictureBox2.Location = new System.Drawing.Point(199, 12);
            this.spinPictureBox2.Name = "spinPictureBox2";
            this.spinPictureBox2.Size = new System.Drawing.Size(153, 176);
            this.spinPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spinPictureBox2.TabIndex = 1;
            this.spinPictureBox2.TabStop = false;
            // 
            // spinPictureBox3
            // 
            this.spinPictureBox3.Location = new System.Drawing.Point(381, 12);
            this.spinPictureBox3.Name = "spinPictureBox3";
            this.spinPictureBox3.Size = new System.Drawing.Size(154, 176);
            this.spinPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spinPictureBox3.TabIndex = 2;
            this.spinPictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount Inserted: $";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(278, 202);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(84, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(174, 239);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(75, 42);
            this.spinButton.TabIndex = 5;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(297, 239);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 287);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spinPictureBox3);
            this.Controls.Add(this.spinPictureBox2);
            this.Controls.Add(this.spinPictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spinPictureBox1;
        private System.Windows.Forms.PictureBox spinPictureBox2;
        private System.Windows.Forms.PictureBox spinPictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button exitButton;
    }
}

