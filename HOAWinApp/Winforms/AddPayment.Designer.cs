namespace HOAWinApp.Winforms
{
    partial class AddPayment
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
            this.addPaymentTopPanel = new System.Windows.Forms.Panel();
            this.addPaymentBotPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addPaymentTopPanel
            // 
            this.addPaymentTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(157)))), ((int)(((byte)(42)))));
            this.addPaymentTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPaymentTopPanel.Location = new System.Drawing.Point(0, 0);
            this.addPaymentTopPanel.Name = "addPaymentTopPanel";
            this.addPaymentTopPanel.Size = new System.Drawing.Size(400, 20);
            this.addPaymentTopPanel.TabIndex = 0;
            this.addPaymentTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addPaymentTopPanel_MouseDown);
            this.addPaymentTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addPaymentTopPanel_MouseMove);
            this.addPaymentTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addPaymentTopPanel_MouseUp);
            // 
            // addPaymentBotPanel
            // 
            this.addPaymentBotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPaymentBotPanel.Location = new System.Drawing.Point(0, 20);
            this.addPaymentBotPanel.Name = "addPaymentBotPanel";
            this.addPaymentBotPanel.Size = new System.Drawing.Size(400, 246);
            this.addPaymentBotPanel.TabIndex = 1;
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 266);
            this.Controls.Add(this.addPaymentBotPanel);
            this.Controls.Add(this.addPaymentTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Payment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPaymentTopPanel;
        private System.Windows.Forms.Panel addPaymentBotPanel;
    }
}