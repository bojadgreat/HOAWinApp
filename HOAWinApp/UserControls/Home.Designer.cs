﻿namespace HOAWinApp.UserControls
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeRightPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // homeRightPanel
            // 
            this.homeRightPanel.BackColor = System.Drawing.Color.Transparent;
            this.homeRightPanel.BackgroundImage = global::HOAWinApp.Properties.Resources.bgBoadv2;
            this.homeRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeRightPanel.Location = new System.Drawing.Point(0, 0);
            this.homeRightPanel.Name = "homeRightPanel";
            this.homeRightPanel.Size = new System.Drawing.Size(1366, 597);
            this.homeRightPanel.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homeRightPanel);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1366, 597);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel homeRightPanel;
    }
}
