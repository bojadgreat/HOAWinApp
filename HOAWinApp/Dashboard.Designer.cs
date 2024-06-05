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
            this.panel1 = new System.Windows.Forms.Panel();
            this.histPicBoxX1 = new System.Windows.Forms.PictureBox();
            this.clientButt = new MetroFramework.Controls.MetroButton();
            this.homeButt = new MetroFramework.Controls.MetroButton();
            this.wcButt = new MetroFramework.Controls.MetroButton();
            this.gcButt = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histPicBoxX1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackgroundImage = global::HOAWinApp.Properties.Resources.bgBoadv2;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 171);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1366, 597);
            this.mainContainer.TabIndex = 2;
            this.mainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::HOAWinApp.Properties.Resources.bgDashBoardv2;
            this.panel1.Controls.Add(this.histPicBoxX1);
            this.panel1.Controls.Add(this.clientButt);
            this.panel1.Controls.Add(this.homeButt);
            this.panel1.Controls.Add(this.wcButt);
            this.panel1.Controls.Add(this.gcButt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 171);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // histPicBoxX1
            // 
            this.histPicBoxX1.BackColor = System.Drawing.Color.Transparent;
            this.histPicBoxX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.histPicBoxX1.Image = ((System.Drawing.Image)(resources.GetObject("histPicBoxX1.Image")));
            this.histPicBoxX1.Location = new System.Drawing.Point(1313, 0);
            this.histPicBoxX1.Name = "histPicBoxX1";
            this.histPicBoxX1.Size = new System.Drawing.Size(66, 41);
            this.histPicBoxX1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.histPicBoxX1.TabIndex = 1;
            this.histPicBoxX1.TabStop = false;
            this.histPicBoxX1.Click += new System.EventHandler(this.histPicBoxX1_Click);
            // 
            // clientButt
            // 
            this.clientButt.BackgroundImage = global::HOAWinApp.Properties.Resources.dashClients;
            this.clientButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clientButt.Location = new System.Drawing.Point(1106, 77);
            this.clientButt.Name = "clientButt";
            this.clientButt.Size = new System.Drawing.Size(252, 71);
            this.clientButt.TabIndex = 3;
            this.clientButt.UseSelectable = true;
            this.clientButt.Click += new System.EventHandler(this.clientButt_Click);
            // 
            // homeButt
            // 
            this.homeButt.BackColor = System.Drawing.Color.Transparent;
            this.homeButt.BackgroundImage = global::HOAWinApp.Properties.Resources.dashHome2;
            this.homeButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.homeButt.Location = new System.Drawing.Point(319, 76);
            this.homeButt.Name = "homeButt";
            this.homeButt.Size = new System.Drawing.Size(252, 71);
            this.homeButt.TabIndex = 4;
            this.homeButt.UseSelectable = true;
            this.homeButt.Click += new System.EventHandler(this.homeButt_Click);
            // 
            // wcButt
            // 
            this.wcButt.BackColor = System.Drawing.Color.Transparent;
            this.wcButt.BackgroundImage = global::HOAWinApp.Properties.Resources.dashWaterCol;
            this.wcButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wcButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.wcButt.Location = new System.Drawing.Point(840, 76);
            this.wcButt.Name = "wcButt";
            this.wcButt.Size = new System.Drawing.Size(252, 71);
            this.wcButt.TabIndex = 2;
            this.wcButt.UseSelectable = true;
            this.wcButt.Click += new System.EventHandler(this.wcButt_Click);
            // 
            // gcButt
            // 
            this.gcButt.BackColor = System.Drawing.Color.Transparent;
            this.gcButt.BackgroundImage = global::HOAWinApp.Properties.Resources.dashGarbCol;
            this.gcButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gcButt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.gcButt.Location = new System.Drawing.Point(577, 76);
            this.gcButt.Name = "gcButt";
            this.gcButt.Size = new System.Drawing.Size(252, 71);
            this.gcButt.TabIndex = 5;
            this.gcButt.UseSelectable = true;
            this.gcButt.Click += new System.EventHandler(this.gcButt_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histPicBoxX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainContainer;
        private MetroFramework.Controls.MetroButton homeButt;
        private MetroFramework.Controls.MetroButton clientButt;
        private MetroFramework.Controls.MetroButton gcButt;
        private MetroFramework.Controls.MetroButton wcButt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox histPicBoxX1;
    }
}

