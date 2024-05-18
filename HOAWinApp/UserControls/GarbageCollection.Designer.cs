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
            this.garbSearchBut = new System.Windows.Forms.Button();
            this.garbSearchTB = new System.Windows.Forms.TextBox();
            this.garbagecoltable = new System.Windows.Forms.DataGridView();
            this.homeLabel = new System.Windows.Forms.Label();
            this.homeLeftPanel.SuspendLayout();
            this.homeRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garbagecoltable)).BeginInit();
            this.SuspendLayout();
            // 
            // homeLeftPanel
            // 
            this.homeLeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.homeLeftPanel.BackgroundImage = global::HOAWinApp.Properties.Resources.kilid;
            this.homeLeftPanel.Controls.Add(this.histGBut);
            this.homeLeftPanel.Controls.Add(this.generateExGBut);
            this.homeLeftPanel.Controls.Add(this.postPaymentGBut);
            this.homeLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.homeLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.homeLeftPanel.Name = "homeLeftPanel";
            this.homeLeftPanel.Size = new System.Drawing.Size(169, 698);
            this.homeLeftPanel.TabIndex = 3;
            // 
            // histGBut
            // 
            this.histGBut.BackColor = System.Drawing.Color.Transparent;
            this.histGBut.BackgroundImage = global::HOAWinApp.Properties.Resources.Generate_Excel_Report__3_2;
            this.histGBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.histGBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histGBut.ForeColor = System.Drawing.Color.Transparent;
            this.histGBut.Location = new System.Drawing.Point(17, 439);
            this.histGBut.Name = "histGBut";
            this.histGBut.Size = new System.Drawing.Size(125, 63);
            this.histGBut.TabIndex = 8;
            this.histGBut.UseVisualStyleBackColor = false;
            this.histGBut.Click += new System.EventHandler(this.histGBut_Click_1);
            // 
            // generateExGBut
            // 
            this.generateExGBut.BackColor = System.Drawing.Color.Transparent;
            this.generateExGBut.BackgroundImage = global::HOAWinApp.Properties.Resources.Generate_Excel_Report__2_2;
            this.generateExGBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateExGBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateExGBut.ForeColor = System.Drawing.Color.Transparent;
            this.generateExGBut.Location = new System.Drawing.Point(17, 309);
            this.generateExGBut.Name = "generateExGBut";
            this.generateExGBut.Size = new System.Drawing.Size(125, 63);
            this.generateExGBut.TabIndex = 7;
            this.generateExGBut.UseVisualStyleBackColor = false;
            this.generateExGBut.Click += new System.EventHandler(this.generateExGBut_Click_1);
            // 
            // postPaymentGBut
            // 
            this.postPaymentGBut.BackColor = System.Drawing.Color.Transparent;
            this.postPaymentGBut.BackgroundImage = global::HOAWinApp.Properties.Resources.Generate_Excel_Report1;
            this.postPaymentGBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postPaymentGBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPaymentGBut.ForeColor = System.Drawing.Color.Transparent;
            this.postPaymentGBut.Location = new System.Drawing.Point(17, 206);
            this.postPaymentGBut.Name = "postPaymentGBut";
            this.postPaymentGBut.Size = new System.Drawing.Size(125, 63);
            this.postPaymentGBut.TabIndex = 6;
            this.postPaymentGBut.UseVisualStyleBackColor = false;
            this.postPaymentGBut.Click += new System.EventHandler(this.postPaymentGBut_Click);
            // 
            // homeRightPanel
            // 
            this.homeRightPanel.BackColor = System.Drawing.Color.Transparent;
            this.homeRightPanel.BackgroundImage = global::HOAWinApp.Properties.Resources.garbcoll4;
            this.homeRightPanel.Controls.Add(this.garbRelBut);
            this.homeRightPanel.Controls.Add(this.garbSearchBut);
            this.homeRightPanel.Controls.Add(this.garbSearchTB);
            this.homeRightPanel.Controls.Add(this.garbagecoltable);
            this.homeRightPanel.Controls.Add(this.homeLabel);
            this.homeRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.homeRightPanel.Location = new System.Drawing.Point(169, 0);
            this.homeRightPanel.Name = "homeRightPanel";
            this.homeRightPanel.Size = new System.Drawing.Size(1197, 698);
            this.homeRightPanel.TabIndex = 2;
            // 
            // garbRelBut
            // 
            this.garbRelBut.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garbRelBut.Location = new System.Drawing.Point(1098, 58);
            this.garbRelBut.Name = "garbRelBut";
            this.garbRelBut.Size = new System.Drawing.Size(79, 27);
            this.garbRelBut.TabIndex = 6;
            this.garbRelBut.Text = "RELOAD";
            this.garbRelBut.UseVisualStyleBackColor = true;
            this.garbRelBut.Click += new System.EventHandler(this.garbRelBut_Click);
            // 
            // garbSearchBut
            // 
            this.garbSearchBut.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garbSearchBut.Location = new System.Drawing.Point(1013, 58);
            this.garbSearchBut.Name = "garbSearchBut";
            this.garbSearchBut.Size = new System.Drawing.Size(79, 27);
            this.garbSearchBut.TabIndex = 5;
            this.garbSearchBut.Text = "SEARCH";
            this.garbSearchBut.UseVisualStyleBackColor = true;
            this.garbSearchBut.Click += new System.EventHandler(this.garbSearchBut_Click);
            // 
            // garbSearchTB
            // 
            this.garbSearchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.garbSearchTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.garbSearchTB.Location = new System.Drawing.Point(644, 58);
            this.garbSearchTB.Multiline = true;
            this.garbSearchTB.Name = "garbSearchTB";
            this.garbSearchTB.Size = new System.Drawing.Size(363, 27);
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
            this.garbagecoltable.Location = new System.Drawing.Point(20, 91);
            this.garbagecoltable.Name = "garbagecoltable";
            this.garbagecoltable.ReadOnly = true;
            this.garbagecoltable.RowHeadersWidth = 30;
            this.garbagecoltable.Size = new System.Drawing.Size(1157, 587);
            this.garbagecoltable.TabIndex = 2;
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeLabel.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(123, 73);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(949, 48);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GarbageCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homeLeftPanel);
            this.Controls.Add(this.homeRightPanel);
            this.Name = "GarbageCollection";
            this.Size = new System.Drawing.Size(1366, 698);
            this.Load += new System.EventHandler(this.GarbageCollection_Load);
            this.homeLeftPanel.ResumeLayout(false);
            this.homeRightPanel.ResumeLayout(false);
            this.homeRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garbagecoltable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homeRightPanel;
        private System.Windows.Forms.Button garbSearchBut;
        private System.Windows.Forms.DataGridView garbagecoltable;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Panel homeLeftPanel;
        private System.Windows.Forms.Button garbRelBut;
        private System.Windows.Forms.TextBox garbSearchTB;
        private System.Windows.Forms.Button postPaymentGBut;
        private System.Windows.Forms.Button generateExGBut;
        private System.Windows.Forms.Button histGBut;
    }
}
