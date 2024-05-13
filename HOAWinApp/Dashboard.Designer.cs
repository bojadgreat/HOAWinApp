namespace HOAWinApp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeButt = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientButt = new MetroFramework.Controls.MetroButton();
            this.wcButt = new MetroFramework.Controls.MetroButton();
            this.gcButt = new MetroFramework.Controls.MetroButton();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(157)))), ((int)(((byte)(42)))));
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.topLabel);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(984, 70);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(925, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(88, 21);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(261, 29);
            this.topLabel.TabIndex = 1;
            this.topLabel.Text = "HANIYYAH HOMES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homeButt
            // 
            this.homeButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.homeButt.Location = new System.Drawing.Point(0, 0);
            this.homeButt.Name = "homeButt";
            this.homeButt.Size = new System.Drawing.Size(246, 70);
            this.homeButt.TabIndex = 0;
            this.homeButt.Text = "HOME";
            this.homeButt.UseSelectable = true;
            this.homeButt.Click += new System.EventHandler(this.homeButt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.clientButt);
            this.panel1.Controls.Add(this.wcButt);
            this.panel1.Controls.Add(this.gcButt);
            this.panel1.Controls.Add(this.homeButt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 70);
            this.panel1.TabIndex = 1;
            // 
            // clientButt
            // 
            this.clientButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clientButt.Location = new System.Drawing.Point(738, 0);
            this.clientButt.Name = "clientButt";
            this.clientButt.Size = new System.Drawing.Size(246, 70);
            this.clientButt.TabIndex = 3;
            this.clientButt.Text = "CLIENTS";
            this.clientButt.UseSelectable = true;
            this.clientButt.Click += new System.EventHandler(this.clientButt_Click);
            // 
            // wcButt
            // 
            this.wcButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wcButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.wcButt.Location = new System.Drawing.Point(492, 0);
            this.wcButt.Name = "wcButt";
            this.wcButt.Size = new System.Drawing.Size(246, 70);
            this.wcButt.TabIndex = 2;
            this.wcButt.Text = "WATER COLLECTION";
            this.wcButt.UseSelectable = true;
            this.wcButt.Click += new System.EventHandler(this.wcButt_Click);
            // 
            // gcButt
            // 
            this.gcButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gcButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.gcButt.Location = new System.Drawing.Point(246, 0);
            this.gcButt.Name = "gcButt";
            this.gcButt.Size = new System.Drawing.Size(246, 70);
            this.gcButt.TabIndex = 1;
            this.gcButt.Text = "GARBAGE COLLECTION";
            this.gcButt.UseSelectable = true;
            this.gcButt.Click += new System.EventHandler(this.gcButt_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 140);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(984, 421);
            this.mainContainer.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton homeButt;
        private MetroFramework.Controls.MetroButton wcButt;
        private MetroFramework.Controls.MetroButton gcButt;
        private MetroFramework.Controls.MetroButton clientButt;
    }
}

