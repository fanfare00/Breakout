﻿namespace Breakout_Game
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
            this.components = new System.ComponentModel.Container();
            this.timerGameClock = new System.Windows.Forms.Timer(this.components);
            this.labelDebug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerGameClock
            // 
            this.timerGameClock.Enabled = true;
            this.timerGameClock.Interval = 50;
            this.timerGameClock.Tick += new System.EventHandler(this.timerGameClock_Tick);
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(53, 35);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(35, 13);
            this.labelDebug.TabIndex = 0;
            this.labelDebug.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.labelDebug);
            this.Name = "Form1";
            this.Text = "James\' Breakout";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerGameClock;
        private System.Windows.Forms.Label labelDebug;
    }
}

