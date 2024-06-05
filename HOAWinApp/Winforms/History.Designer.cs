namespace HOAWinApp.Winforms
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.histTopPanel = new System.Windows.Forms.Panel();
            this.histBotPanel = new System.Windows.Forms.Panel();
            this.histPicBoxX = new System.Windows.Forms.PictureBox();
            this.histTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histPicBoxX)).BeginInit();
            this.SuspendLayout();
            // 
            // histTopPanel
            // 
            this.histTopPanel.BackColor = System.Drawing.Color.Black;
            this.histTopPanel.Controls.Add(this.histPicBoxX);
            this.histTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.histTopPanel.Location = new System.Drawing.Point(0, 0);
            this.histTopPanel.Name = "histTopPanel";
            this.histTopPanel.Size = new System.Drawing.Size(714, 35);
            this.histTopPanel.TabIndex = 0;
            this.histTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.garbHistTopPanel_MouseDown);
            this.histTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.garbHistTopPanel_MouseMove);
            this.histTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.garbHistTopPanel_MouseUp);
            // 
            // histBotPanel
            // 
            this.histBotPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.histBotPanel.Location = new System.Drawing.Point(0, 35);
            this.histBotPanel.Name = "histBotPanel";
            this.histBotPanel.Size = new System.Drawing.Size(714, 325);
            this.histBotPanel.TabIndex = 1;
            this.histBotPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.histBotPanel_Paint);
            // 
            // histPicBoxX
            // 
            this.histPicBoxX.BackColor = System.Drawing.Color.Transparent;
            this.histPicBoxX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.histPicBoxX.Image = ((System.Drawing.Image)(resources.GetObject("histPicBoxX.Image")));
            this.histPicBoxX.Location = new System.Drawing.Point(670, 0);
            this.histPicBoxX.Name = "histPicBoxX";
            this.histPicBoxX.Size = new System.Drawing.Size(49, 35);
            this.histPicBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.histPicBoxX.TabIndex = 0;
            this.histPicBoxX.TabStop = false;
            this.histPicBoxX.Click += new System.EventHandler(this.histPicBoxX_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 360);
            this.Controls.Add(this.histBotPanel);
            this.Controls.Add(this.histTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.histTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histPicBoxX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel histTopPanel;
        private System.Windows.Forms.Panel histBotPanel;
        private System.Windows.Forms.PictureBox histPicBoxX;
    }
}