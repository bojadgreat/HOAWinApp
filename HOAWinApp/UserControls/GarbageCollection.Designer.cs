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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GarbageCollection));
            this.homeRightPanel = new System.Windows.Forms.Panel();
            this.garbRelBut = new System.Windows.Forms.Button();
            this.garbSearchBut = new System.Windows.Forms.Button();
            this.garbSearchTB = new System.Windows.Forms.TextBox();
            this.garbagecoltable = new System.Windows.Forms.DataGridView();
            this.homeLabel = new System.Windows.Forms.Label();
            this.homeLeftPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.postPaymentGBut = new System.Windows.Forms.Button();
            this.histGBut = new System.Windows.Forms.Button();
            this.generateExGBut = new System.Windows.Forms.Button();
            this.homeRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garbagecoltable)).BeginInit();
            this.homeLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // homeRightPanel
            // 
            this.homeRightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(85)))));
            this.homeRightPanel.Controls.Add(this.garbRelBut);
            this.homeRightPanel.Controls.Add(this.garbSearchBut);
            this.homeRightPanel.Controls.Add(this.garbSearchTB);
            this.homeRightPanel.Controls.Add(this.garbagecoltable);
            this.homeRightPanel.Controls.Add(this.homeLabel);
            this.homeRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.homeRightPanel.Location = new System.Drawing.Point(169, 0);
            this.homeRightPanel.Name = "homeRightPanel";
            this.homeRightPanel.Size = new System.Drawing.Size(815, 421);
            this.homeRightPanel.TabIndex = 2;
            // 
            // garbRelBut
            // 
            this.garbRelBut.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garbRelBut.Location = new System.Drawing.Point(20, 71);
            this.garbRelBut.Name = "garbRelBut";
            this.garbRelBut.Size = new System.Drawing.Size(79, 23);
            this.garbRelBut.TabIndex = 6;
            this.garbRelBut.Text = "RELOAD";
            this.garbRelBut.UseVisualStyleBackColor = true;
            this.garbRelBut.Click += new System.EventHandler(this.garbRelBut_Click);
            // 
            // garbSearchBut
            // 
            this.garbSearchBut.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garbSearchBut.Location = new System.Drawing.Point(105, 71);
            this.garbSearchBut.Name = "garbSearchBut";
            this.garbSearchBut.Size = new System.Drawing.Size(79, 23);
            this.garbSearchBut.TabIndex = 5;
            this.garbSearchBut.Text = "SEARCH";
            this.garbSearchBut.UseVisualStyleBackColor = true;
            this.garbSearchBut.Click += new System.EventHandler(this.garbSearchBut_Click);
            // 
            // garbSearchTB
            // 
            this.garbSearchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.garbSearchTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.garbSearchTB.Location = new System.Drawing.Point(190, 73);
            this.garbSearchTB.Name = "garbSearchTB";
            this.garbSearchTB.Size = new System.Drawing.Size(606, 20);
            this.garbSearchTB.TabIndex = 4;
            this.garbSearchTB.Enter += new System.EventHandler(this.garbSearchTB_Enter);
            this.garbSearchTB.Leave += new System.EventHandler(this.garbSearchTB_Leave);
            // 
            // garbagecoltable
            // 
            this.garbagecoltable.AllowUserToOrderColumns = true;
            this.garbagecoltable.AllowUserToResizeColumns = false;
            this.garbagecoltable.AllowUserToResizeRows = false;
            this.garbagecoltable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.garbagecoltable.Location = new System.Drawing.Point(20, 97);
            this.garbagecoltable.Name = "garbagecoltable";
            this.garbagecoltable.ReadOnly = true;
            this.garbagecoltable.RowHeadersWidth = 30;
            this.garbagecoltable.Size = new System.Drawing.Size(777, 305);
            this.garbagecoltable.TabIndex = 2;
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeLabel.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(124, 18);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(567, 48);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "GARBAGE COLLECTION DATA";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeLeftPanel
            // 
            this.homeLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(188)))), ((int)(((byte)(218)))));
            this.homeLeftPanel.Controls.Add(this.pictureBox1);
            this.homeLeftPanel.Controls.Add(this.postPaymentGBut);
            this.homeLeftPanel.Controls.Add(this.histGBut);
            this.homeLeftPanel.Controls.Add(this.generateExGBut);
            this.homeLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.homeLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.homeLeftPanel.Name = "homeLeftPanel";
            this.homeLeftPanel.Size = new System.Drawing.Size(170, 421);
            this.homeLeftPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // postPaymentGBut
            // 
            this.postPaymentGBut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.postPaymentGBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postPaymentGBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPaymentGBut.Location = new System.Drawing.Point(21, 150);
            this.postPaymentGBut.Name = "postPaymentGBut";
            this.postPaymentGBut.Size = new System.Drawing.Size(125, 63);
            this.postPaymentGBut.TabIndex = 4;
            this.postPaymentGBut.Text = "POST PAYMENT";
            this.postPaymentGBut.UseVisualStyleBackColor = false;
            this.postPaymentGBut.Click += new System.EventHandler(this.postPaymentGBut_Click);
            // 
            // histGBut
            // 
            this.histGBut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.histGBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.histGBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histGBut.Location = new System.Drawing.Point(21, 307);
            this.histGBut.Name = "histGBut";
            this.histGBut.Size = new System.Drawing.Size(125, 63);
            this.histGBut.TabIndex = 2;
            this.histGBut.Text = "HISTORY";
            this.histGBut.UseVisualStyleBackColor = false;
            this.histGBut.Click += new System.EventHandler(this.histGBut_Click);
            // 
            // generateExGBut
            // 
            this.generateExGBut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.generateExGBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateExGBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateExGBut.Location = new System.Drawing.Point(21, 228);
            this.generateExGBut.Name = "generateExGBut";
            this.generateExGBut.Size = new System.Drawing.Size(125, 63);
            this.generateExGBut.TabIndex = 1;
            this.generateExGBut.Text = "GENERATE EXCEL REPORT";
            this.generateExGBut.UseVisualStyleBackColor = false;
            this.generateExGBut.Click += new System.EventHandler(this.generateExGBut_Click);
            // 
            // GarbageCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homeLeftPanel);
            this.Controls.Add(this.homeRightPanel);
            this.Name = "GarbageCollection";
            this.Size = new System.Drawing.Size(984, 421);
            this.Load += new System.EventHandler(this.GarbageCollection_Load);
            this.homeRightPanel.ResumeLayout(false);
            this.homeRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garbagecoltable)).EndInit();
            this.homeLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homeRightPanel;
        private System.Windows.Forms.Button garbSearchBut;
        private System.Windows.Forms.TextBox garbSearchTB;
        private System.Windows.Forms.DataGridView garbagecoltable;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Panel homeLeftPanel;
        private System.Windows.Forms.Button postPaymentGBut;
        private System.Windows.Forms.Button histGBut;
        private System.Windows.Forms.Button generateExGBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button garbRelBut;
    }
}
