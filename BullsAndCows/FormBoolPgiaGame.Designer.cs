﻿namespace BullsAndCows
{
    using System.Windows.Forms;
    using System.Drawing;

    public partial class BoolPgiaGame
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
            this.SuspendLayout();
            // 
            // BoolPgiaGame
            // 
            this.ClientSize = new System.Drawing.Size(348, 244);
            this.Name = "BoolPgiaGame";
            this.Text = "Bool Pgia";
            this.Load += new System.EventHandler(this.boolPgiaGame_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}