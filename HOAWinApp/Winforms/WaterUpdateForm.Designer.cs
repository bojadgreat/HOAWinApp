namespace HOAWinApp.Winforms
{
    partial class WaterUpdateForm
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
            this.updateTopPanel = new System.Windows.Forms.Panel();
            this.updateBotPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // updateTopPanel
            // 
            this.updateTopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateTopPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.updateTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateTopPanel.Location = new System.Drawing.Point(0, 0);
            this.updateTopPanel.Name = "updateTopPanel";
            this.updateTopPanel.Size = new System.Drawing.Size(300, 25);
            this.updateTopPanel.TabIndex = 0;
            this.updateTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.updateTopPanel_MouseDown);
            this.updateTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.updateTopPanel_MouseMove);
            this.updateTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateTopPanel_MouseUp);
            // 
            // updateBotPanel
            // 
            this.updateBotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateBotPanel.Location = new System.Drawing.Point(0, 25);
            this.updateBotPanel.Name = "updateBotPanel";
            this.updateBotPanel.Size = new System.Drawing.Size(300, 140);
            this.updateBotPanel.TabIndex = 1;
            // 
            // WaterUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 165);
            this.Controls.Add(this.updateBotPanel);
            this.Controls.Add(this.updateTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaterUpdateForm";
            this.Text = "WaterUpdateForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updateTopPanel;
        private System.Windows.Forms.Panel updateBotPanel;
    }
}