﻿namespace HOAWinApp.Winforms
{
    partial class AddWaterPayment
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
            this.addWaterPaymentTopPanel = new System.Windows.Forms.Panel();
            this.addWaterPaymentBotPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addPaymentTopPanel
            // 
            this.addWaterPaymentTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(157)))), ((int)(((byte)(42)))));
            this.addWaterPaymentTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addWaterPaymentTopPanel.Location = new System.Drawing.Point(0, 0);
            this.addWaterPaymentTopPanel.Name = "addPaymentTopPanel";
            this.addWaterPaymentTopPanel.Size = new System.Drawing.Size(400, 20);
            this.addWaterPaymentTopPanel.TabIndex = 0;
            this.addWaterPaymentTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addWaterPaymentTopPanel_MouseDown);
            this.addWaterPaymentTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addWaterPaymentTopPanel_MouseMove);
            this.addWaterPaymentTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addWaterPaymentTopPanel_MouseUp);
            // 
            // addPaymentBotPanel
            // 
            this.addWaterPaymentBotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addWaterPaymentBotPanel.Location = new System.Drawing.Point(0, 20);
            this.addWaterPaymentBotPanel.Name = "addPaymentBotPanel";
            this.addWaterPaymentBotPanel.Size = new System.Drawing.Size(400, 200);
            this.addWaterPaymentBotPanel.TabIndex = 1;
            this.addWaterPaymentBotPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.addWaterPaymentBotPanel_Paint);
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.addWaterPaymentBotPanel);
            this.Controls.Add(this.addWaterPaymentTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Payment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addWaterPaymentTopPanel;
        private System.Windows.Forms.Panel addWaterPaymentBotPanel;
    }
}