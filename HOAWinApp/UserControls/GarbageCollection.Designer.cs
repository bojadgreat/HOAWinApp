namespace HOAWinApp.UserControls
{
    partial class GarbageCollection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeLeftPanel = new System.Windows.Forms.Panel();
            this.histGBut = new System.Windows.Forms.Button();
            this.generateExGBut = new System.Windows.Forms.Button();
            this.postPaymentGBut = new System.Windows.Forms.Button();
            this.homeRightPanel = new System.Windows.Forms.Panel();
            this.garbRelBut = new System.Windows.Forms.Button();
            this.garbSearchTB = new System.Windows.Forms.TextBox();
            this.garbagecoltable = new System.Windows.Forms.DataGridView();
            this.garbSearchBut = new MetroFramework.Controls.MetroButton();
            this.homeLeftPanel.SuspendLayout();
            this.homeRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garbagecoltable)).BeginInit();
            this.SuspendLayout();
            // 
            // homeLeftPanel
            // 
            this.homeLeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.homeLeftPanel.BackgroundImage = global::HOAWinApp.Properties.Resources.garbagecol15;
            this.homeLeftPanel.Controls.Add(this.histGBut);
            this.homeLeftPanel.Controls.Add(this.generateExGBut);
            this.homeLeftPanel.Controls.Add(this.postPaymentGBut);
            this.homeLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.homeLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.homeLeftPanel.Name = "homeLeftPanel";
            this.homeLeftPanel.Size = new System.Drawing.Size(169, 597);
            this.homeLeftPanel.TabIndex = 3;
            // 
            // histGBut
            // 
            this.histGBut.BackColor = System.Drawing.Color.Transparent;
            this.histGBut.BackgroundImage = global::HOAWinApp.Properties.Resources.garbHIST;
            this.histGBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.histGBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histGBut.ForeColor = System.Drawing.Color.Transparent;
            this.histGBut.Location = new System.Drawing.Point(23, 415);
            this.histGBut.Name = "histGBut";
            this.histGBut.Size = new System.Drawing.Size(131, 65);
            this.histGBut.TabIndex = 8;
            this.histGBut.UseVisualStyleBackColor = false;
            this.histGBut.Click += new System.EventHandler(this.histGBut_Click_1);
            // 
            // generateExGBut
            // 
            this.generateExGBut.BackColor = System.Drawing.Color.Transparent;
            this.generateExGBut.BackgroundImage = global::HOAWinApp.Properties.Resources.garbGER;
            this.generateExGBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateExGBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateExGBut.ForeColor = System.Drawing.Color.Transparent;
            this.generateExGBut.Location = new System.Drawing.Point(23, 263);
            this.generateExGBut.Name = "generateExGBut";
            this.generateExGBut.Size = new System.Drawing.Size(131, 65);
            this.generateExGBut.TabIndex = 7;
            this.generateExGBut.UseVisualStyleBackColor = false;
            this.generateExGBut.Click += new System.EventHandler(this.generateExGBut_Click_1);
            // 
            // postPaymentGBut
            // 
            this.postPaymentGBut.BackColor = System.Drawing.Color.Transparent;
            this.postPaymentGBut.BackgroundImage = global::HOAWinApp.Properties.Resources.garbPP;
            this.postPaymentGBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postPaymentGBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPaymentGBut.ForeColor = System.Drawing.Color.Transparent;
            this.postPaymentGBut.Location = new System.Drawing.Point(23, 130);
            this.postPaymentGBut.Name = "postPaymentGBut";
            this.postPaymentGBut.Size = new System.Drawing.Size(131, 65);
            this.postPaymentGBut.TabIndex = 6;
            this.postPaymentGBut.UseVisualStyleBackColor = false;
            this.postPaymentGBut.Click += new System.EventHandler(this.postPaymentGBut_Click);
            // 
            // homeRightPanel
            // 
            this.homeRightPanel.BackColor = System.Drawing.Color.Transparent;
            this.homeRightPanel.BackgroundImage = global::HOAWinApp.Properties.Resources.garbagecol14;
            this.homeRightPanel.Controls.Add(this.garbSearchBut);
            this.homeRightPanel.Controls.Add(this.garbRelBut);
            this.homeRightPanel.Controls.Add(this.garbSearchTB);
            this.homeRightPanel.Controls.Add(this.garbagecoltable);
            this.homeRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.homeRightPanel.Location = new System.Drawing.Point(169, 0);
            this.homeRightPanel.Name = "homeRightPanel";
            this.homeRightPanel.Size = new System.Drawing.Size(1197, 597);
            this.homeRightPanel.TabIndex = 2;
            this.homeRightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homeRightPanel_Paint);
            // 
            // garbRelBut
            // 
            this.garbRelBut.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garbRelBut.Location = new System.Drawing.Point(1063, 24);
            this.garbRelBut.Name = "garbRelBut";
            this.garbRelBut.Size = new System.Drawing.Size(85, 36);
            this.garbRelBut.TabIndex = 6;
            this.garbRelBut.Text = "RELOAD";
            this.garbRelBut.UseVisualStyleBackColor = true;
            this.garbRelBut.Click += new System.EventHandler(this.garbRelBut_Click);
            // 
            // garbSearchTB
            // 
            this.garbSearchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.garbSearchTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.garbSearchTB.BackColor = System.Drawing.Color.White;
            this.garbSearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garbSearchTB.Location = new System.Drawing.Point(571, 24);
            this.garbSearchTB.Multiline = true;
            this.garbSearchTB.Name = "garbSearchTB";
            this.garbSearchTB.Size = new System.Drawing.Size(388, 36);
            this.garbSearchTB.TabIndex = 4;
            this.garbSearchTB.TextChanged += new System.EventHandler(this.garbSearchTB_TextChanged);
            this.garbSearchTB.Enter += new System.EventHandler(this.garbSearchTB_Enter);
            this.garbSearchTB.Leave += new System.EventHandler(this.garbSearchTB_Leave);
            // 
            // garbagecoltable
            // 
            this.garbagecoltable.AllowUserToOrderColumns = true;
            this.garbagecoltable.AllowUserToResizeColumns = false;
            this.garbagecoltable.AllowUserToResizeRows = false;
            this.garbagecoltable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.garbagecoltable.Location = new System.Drawing.Point(24, 83);
            this.garbagecoltable.Name = "garbagecoltable";
            this.garbagecoltable.ReadOnly = true;
            this.garbagecoltable.RowHeadersWidth = 30;
            this.garbagecoltable.Size = new System.Drawing.Size(1150, 500);
            this.garbagecoltable.TabIndex = 2;
            // 
            // garbSearchBut
            // 
            this.garbSearchBut.BackColor = System.Drawing.Color.Transparent;
            this.garbSearchBut.BackgroundImage = global::HOAWinApp.Properties.Resources.search4;
            this.garbSearchBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.garbSearchBut.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.garbSearchBut.Location = new System.Drawing.Point(965, 24);
            this.garbSearchBut.Name = "garbSearchBut";
            this.garbSearchBut.Size = new System.Drawing.Size(98, 36);
            this.garbSearchBut.TabIndex = 11;
            this.garbSearchBut.UseSelectable = true;
            this.garbSearchBut.Click += new System.EventHandler(this.garbSearchBut_Click);
            // 
            // GarbageCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homeLeftPanel);
            this.Controls.Add(this.homeRightPanel);
            this.Name = "GarbageCollection";
            this.Size = new System.Drawing.Size(1366, 597);
            this.Load += new System.EventHandler(this.GarbageCollection_Load);
            this.homeLeftPanel.ResumeLayout(false);
            this.homeRightPanel.ResumeLayout(false);
            this.homeRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garbagecoltable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel homeLeftPanel;
        private System.Windows.Forms.Button postPaymentGBut;
        private System.Windows.Forms.Button histGBut;
        private System.Windows.Forms.Button generateExGBut;
        private System.Windows.Forms.DataGridView garbagecoltable;
        private System.Windows.Forms.TextBox garbSearchTB;
        private System.Windows.Forms.Button garbRelBut;
        private System.Windows.Forms.Panel homeRightPanel;
        private MetroFramework.Controls.MetroButton garbSearchBut;
    }
}
