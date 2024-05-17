namespace HOAWinApp.UserControls
{
    partial class GarbHistory
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
            this.dgvGarbHist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.garbHistTB = new System.Windows.Forms.TextBox();
            this.garbHistExpBut = new System.Windows.Forms.Button();
            this.garbHistRelBut = new System.Windows.Forms.Button();
            this.garbHistSearchBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGarbHist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGarbHist
            // 
            this.dgvGarbHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGarbHist.Location = new System.Drawing.Point(19, 70);
            this.dgvGarbHist.Name = "dgvGarbHist";
            this.dgvGarbHist.Size = new System.Drawing.Size(464, 179);
            this.dgvGarbHist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "GARBAGE COLLECTION PAYMENT HISTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // garbHistTB
            // 
            this.garbHistTB.Location = new System.Drawing.Point(262, 46);
            this.garbHistTB.Name = "garbHistTB";
            this.garbHistTB.Size = new System.Drawing.Size(221, 20);
            this.garbHistTB.TabIndex = 2;
            this.garbHistTB.Enter += new System.EventHandler(this.garbSearchTB_Enter);
            this.garbHistTB.Leave += new System.EventHandler(this.garbSearchTB_Leave);
            // 
            // garbHistExpBut
            // 
            this.garbHistExpBut.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garbHistExpBut.Location = new System.Drawing.Point(19, 44);
            this.garbHistExpBut.Name = "garbHistExpBut";
            this.garbHistExpBut.Size = new System.Drawing.Size(75, 23);
            this.garbHistExpBut.TabIndex = 3;
            this.garbHistExpBut.Text = "EXPORT";
            this.garbHistExpBut.UseVisualStyleBackColor = true;
            this.garbHistExpBut.Click += new System.EventHandler(this.garbHistExpBut_Click);
            // 
            // garbHistRelBut
            // 
            this.garbHistRelBut.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garbHistRelBut.Location = new System.Drawing.Point(100, 44);
            this.garbHistRelBut.Name = "garbHistRelBut";
            this.garbHistRelBut.Size = new System.Drawing.Size(75, 23);
            this.garbHistRelBut.TabIndex = 4;
            this.garbHistRelBut.Text = "REFRESH";
            this.garbHistRelBut.UseVisualStyleBackColor = true;
            this.garbHistRelBut.Click += new System.EventHandler(this.garbHistRelBut_Click);
            // 
            // garbHistSearchBut
            // 
            this.garbHistSearchBut.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garbHistSearchBut.Location = new System.Drawing.Point(181, 44);
            this.garbHistSearchBut.Name = "garbHistSearchBut";
            this.garbHistSearchBut.Size = new System.Drawing.Size(75, 23);
            this.garbHistSearchBut.TabIndex = 5;
            this.garbHistSearchBut.Text = "SEARCH";
            this.garbHistSearchBut.UseVisualStyleBackColor = true;
            this.garbHistSearchBut.Click += new System.EventHandler(this.garbHistSearchBut_Click);
            // 
            // GarbHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(85)))));
            this.Controls.Add(this.garbHistSearchBut);
            this.Controls.Add(this.garbHistRelBut);
            this.Controls.Add(this.garbHistExpBut);
            this.Controls.Add(this.garbHistTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGarbHist);
            this.Name = "GarbHistory";
            this.Size = new System.Drawing.Size(500, 265);
            this.Load += new System.EventHandler(this.GarbHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGarbHist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGarbHist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox garbHistTB;
        private System.Windows.Forms.Button garbHistExpBut;
        private System.Windows.Forms.Button garbHistRelBut;
        private System.Windows.Forms.Button garbHistSearchBut;
    }
}
