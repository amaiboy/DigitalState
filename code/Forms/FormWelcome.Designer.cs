﻿namespace code.Forms
{
    partial class FormWelcome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWelcomeMessage = new System.Windows.Forms.Label();
            this.labelRandomTip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::code.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(311, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelWelcomeMessage
            // 
            this.labelWelcomeMessage.AutoSize = true;
            this.labelWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeMessage.Location = new System.Drawing.Point(258, 283);
            this.labelWelcomeMessage.Name = "labelWelcomeMessage";
            this.labelWelcomeMessage.Size = new System.Drawing.Size(297, 37);
            this.labelWelcomeMessage.TabIndex = 1;
            this.labelWelcomeMessage.Text = "Ласкаво просимо!";
            // 
            // labelRandomTip
            // 
            this.labelRandomTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandomTip.Location = new System.Drawing.Point(265, 351);
            this.labelRandomTip.Name = "labelRandomTip";
            this.labelRandomTip.Size = new System.Drawing.Size(290, 182);
            this.labelRandomTip.TabIndex = 2;
            this.labelRandomTip.Text = "Чи знали ви що шось там шось є та?";
            this.labelRandomTip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormWelcome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(768, 551);
            this.Controls.Add(this.labelRandomTip);
            this.Controls.Add(this.labelWelcomeMessage);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(784, 590);
            this.MinimumSize = new System.Drawing.Size(784, 590);
            this.Name = "FormWelcome";
            this.Text = "FormWelcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelWelcomeMessage;
        private System.Windows.Forms.Label labelRandomTip;
    }
}