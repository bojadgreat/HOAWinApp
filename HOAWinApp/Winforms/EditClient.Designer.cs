namespace HOAWinApp.Winforms
{
    partial class EditClient
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
            this.editClientTopPanel = new System.Windows.Forms.Panel();
            this.editClientBotPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // editClientTopPanel
            // 
            this.editClientTopPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editClientTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editClientTopPanel.Location = new System.Drawing.Point(0, 0);
            this.editClientTopPanel.Name = "editClientTopPanel";
            this.editClientTopPanel.Size = new System.Drawing.Size(500, 30);
            this.editClientTopPanel.TabIndex = 0;
            this.editClientTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.editClientTopPanel_MouseDown);
            this.editClientTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.editClientTopPanel_MouseMove);
            this.editClientTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.editClientTopPanel_MouseUp);
            // 
            // editClientBotPanel
            // 
            this.editClientBotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editClientBotPanel.Location = new System.Drawing.Point(0, 30);
            this.editClientBotPanel.Name = "editClientBotPanel";
            this.editClientBotPanel.Size = new System.Drawing.Size(500, 270);
            this.editClientBotPanel.TabIndex = 1;
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.editClientBotPanel);
            this.Controls.Add(this.editClientTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditClient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel editClientTopPanel;
        private System.Windows.Forms.Panel editClientBotPanel;
    }
}