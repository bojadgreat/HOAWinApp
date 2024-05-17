namespace HOAWinApp.UserControls
{
    partial class WaterHistory
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
            this.dgvWaterHist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.waterHistTB = new System.Windows.Forms.TextBox();
            this.waterHistRelBut = new System.Windows.Forms.Button();
            this.waterHistSearchBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaterHist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWaterHist
            // 
            this.dgvWaterHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWaterHist.Location = new System.Drawing.Point(19, 70);
            this.dgvWaterHist.Name = "dgvWaterHist";
            this.dgvWaterHist.Size = new System.Drawing.Size(464, 179);
            this.dgvWaterHist.TabIndex = 0;
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
            this.label1.Text = "WATER COLLECTION PAYMENT HISTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaterHistTB
            // 
            this.waterHistTB.Location = new System.Drawing.Point(181, 46);
            this.waterHistTB.Name = "waterHistTB";
            this.waterHistTB.Size = new System.Drawing.Size(302, 20);
            this.waterHistTB.TabIndex = 2;
            this.waterHistTB.Enter += new System.EventHandler(this.waterSearchTB_Enter);
            this.waterHistTB.Leave += new System.EventHandler(this.waterSearchTB_Leave);
            // 
            // WaterHistRelBut
            // 
            this.waterHistRelBut.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterHistRelBut.Location = new System.Drawing.Point(19, 44);
            this.waterHistRelBut.Name = "waterHistRelBut";
            this.waterHistRelBut.Size = new System.Drawing.Size(75, 23);
            this.waterHistRelBut.TabIndex = 3;
            this.waterHistRelBut.Text = "REFRESH";
            this.waterHistRelBut.UseVisualStyleBackColor = true;
            this.waterHistRelBut.Click += new System.EventHandler(this.waterHistRelBut_Click);
            // 
            // WaterHistSearchBut
            // 
            this.waterHistSearchBut.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterHistSearchBut.Location = new System.Drawing.Point(100, 44);
            this.waterHistSearchBut.Name = "waterHistSearchBut";
            this.waterHistSearchBut.Size = new System.Drawing.Size(75, 23);
            this.waterHistSearchBut.TabIndex = 4;
            this.waterHistSearchBut.Text = "SEARCH";
            this.waterHistSearchBut.UseVisualStyleBackColor = true;
            this.waterHistSearchBut.Click += new System.EventHandler(this.waterHistSearchBut_Click);
            // 
            // WaterHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(85)))));
            this.Controls.Add(this.waterHistSearchBut);
            this.Controls.Add(this.waterHistRelBut);
            this.Controls.Add(this.waterHistTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWaterHist);
            this.Name = "WaterHistory";
            this.Size = new System.Drawing.Size(500, 265);
            this.Load += new System.EventHandler(this.WaterHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaterHist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWaterHist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox waterHistTB;
        private System.Windows.Forms.Button waterHistRelBut;
        private System.Windows.Forms.Button waterHistSearchBut;
    }
}
