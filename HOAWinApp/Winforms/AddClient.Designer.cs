namespace HOAWinApp.Winforms
{
    partial class AddClient
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
            this.addClientTopPanel = new System.Windows.Forms.Panel();
            this.addClientBotPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addClientTopPanel
            // 
            this.addClientTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(157)))), ((int)(((byte)(42)))));
            this.addClientTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addClientTopPanel.Location = new System.Drawing.Point(0, 0);
            this.addClientTopPanel.Name = "addClientTopPanel";
            this.addClientTopPanel.Size = new System.Drawing.Size(500, 20);
            this.addClientTopPanel.TabIndex = 0;
            this.addClientTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addClientTopPanel_MouseDown);
            this.addClientTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addClientTopPanel_MouseMove);
            this.addClientTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addClientTopPanel_MouseUp);
            // 
            // addClientBotPanel
            // 
            this.addClientBotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addClientBotPanel.Location = new System.Drawing.Point(0, 20);
            this.addClientBotPanel.Name = "addClientBotPanel";
            this.addClientBotPanel.Size = new System.Drawing.Size(500, 280);
            this.addClientBotPanel.TabIndex = 1;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.addClientBotPanel);
            this.Controls.Add(this.addClientTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addClientTopPanel;
        private System.Windows.Forms.Panel addClientBotPanel;
    }
}