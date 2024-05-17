namespace HOAWinApp.Winforms
{
    partial class DisplayWaterHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayWaterHistory));
            this.histTopPanel = new System.Windows.Forms.Panel();
            this.histBotPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.histTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // histTopPanel
            // 
            this.histTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(157)))), ((int)(((byte)(42)))));
            this.histTopPanel.Controls.Add(this.pictureBox1);
            this.histTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.histTopPanel.Location = new System.Drawing.Point(0, 0);
            this.histTopPanel.Name = "histTopPanel";
            this.histTopPanel.Size = new System.Drawing.Size(500, 35);
            this.histTopPanel.TabIndex = 0;
            this.histTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.waterHistTopPanel_MouseDown);
            this.histTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.waterHistTopPanel_MouseMove);
            this.histTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.waterHistTopPanel_MouseUp);
            // 
            // histBotPanel
            // 
            this.histBotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histBotPanel.Location = new System.Drawing.Point(0, 35);
            this.histBotPanel.Name = "histBotPanel";
            this.histBotPanel.Size = new System.Drawing.Size(500, 265);
            this.histBotPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(468, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DisplayWaterHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.histBotPanel);
            this.Controls.Add(this.histTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayWaterHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water History";
            this.histTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel histTopPanel;
        private System.Windows.Forms.Panel histBotPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}