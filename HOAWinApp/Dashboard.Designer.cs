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
            this.mainContainer = new System.Windows.Forms.Panel();
            this.gcButt = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeButt = new MetroFramework.Controls.MetroButton();
            this.clientButt = new MetroFramework.Controls.MetroButton();
            this.wcButt = new MetroFramework.Controls.MetroButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackgroundImage = global::HOAWinApp.Properties.Resources.db3__2_;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 140);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(984, 421);
            this.mainContainer.TabIndex = 2;
            this.mainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContainer_Paint);
            // 
            // gcButt
            // 
            this.gcButt.BackColor = System.Drawing.Color.Transparent;
            this.gcButt.BackgroundImage = global::HOAWinApp.Properties.Resources.WATER_COLLECTION__2_3;
            this.gcButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gcButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.gcButt.Location = new System.Drawing.Point(243, 0);
            this.gcButt.Name = "gcButt";
            this.gcButt.Size = new System.Drawing.Size(246, 70);
            this.gcButt.TabIndex = 5;
            this.gcButt.UseSelectable = true;
            this.gcButt.Click += new System.EventHandler(this.gcButt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::HOAWinApp.Properties.Resources.dash15;
            this.panel1.Controls.Add(this.gcButt);
            this.panel1.Controls.Add(this.homeButt);
            this.panel1.Controls.Add(this.clientButt);
            this.panel1.Controls.Add(this.wcButt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 70);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // homeButt
            // 
            this.homeButt.BackColor = System.Drawing.Color.Transparent;
            this.homeButt.BackgroundImage = global::HOAWinApp.Properties.Resources.WATER_COLLECTION__3_1;
            this.homeButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.homeButt.Location = new System.Drawing.Point(0, 0);
            this.homeButt.Name = "homeButt";
            this.homeButt.Size = new System.Drawing.Size(246, 70);
            this.homeButt.TabIndex = 4;
            this.homeButt.UseSelectable = true;
            this.homeButt.Click += new System.EventHandler(this.homeButt_Click);
            // 
            // clientButt
            // 
            this.clientButt.BackgroundImage = global::HOAWinApp.Properties.Resources.WATER_COLLECTION__5_;
            this.clientButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clientButt.Location = new System.Drawing.Point(735, 0);
            this.clientButt.Name = "clientButt";
            this.clientButt.Size = new System.Drawing.Size(246, 70);
            this.clientButt.TabIndex = 3;
            this.clientButt.UseSelectable = true;
            this.clientButt.Click += new System.EventHandler(this.clientButt_Click);
            // 
            // wcButt
            // 
            this.wcButt.BackColor = System.Drawing.Color.Transparent;
            this.wcButt.BackgroundImage = global::HOAWinApp.Properties.Resources.WATER_COLLECTION__6_1;
            this.wcButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wcButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.wcButt.Location = new System.Drawing.Point(486, 0);
            this.wcButt.Name = "wcButt";
            this.wcButt.Size = new System.Drawing.Size(246, 70);
            this.wcButt.TabIndex = 2;
            this.wcButt.UseSelectable = true;
            this.wcButt.Click += new System.EventHandler(this.wcButt_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.BackgroundImage = global::HOAWinApp.Properties.Resources.dashboard_header;
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.topLabel);
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
            this.pictureBox2.Size = new System.Drawing.Size(47, 40);
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
            this.topLabel.Size = new System.Drawing.Size(0, 29);
            this.topLabel.TabIndex = 1;
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
            this.panel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton wcButt;
        private MetroFramework.Controls.MetroButton clientButt;
        private MetroFramework.Controls.MetroButton homeButt;
        private MetroFramework.Controls.MetroButton gcButt;
    }
}

