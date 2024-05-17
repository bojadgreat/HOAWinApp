namespace HOAWinApp.UserControls
{
    partial class WaterCollection
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
            this.waterColRightPanel = new System.Windows.Forms.Panel();
            this.watSearchTB = new System.Windows.Forms.TextBox();
            this.watSearchBut = new System.Windows.Forms.Button();
            this.watRelBut = new System.Windows.Forms.Button();
            this.watercoltable = new System.Windows.Forms.DataGridView();
            this.waterColLeftPanel = new System.Windows.Forms.Panel();
            this.updateBut = new System.Windows.Forms.Button();
            this.histWBut = new System.Windows.Forms.Button();
            this.excelWBut = new System.Windows.Forms.Button();
            this.postPaymentWBut = new System.Windows.Forms.Button();
            this.waterColRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watercoltable)).BeginInit();
            this.waterColLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // waterColRightPanel
            // 
            this.waterColRightPanel.BackColor = System.Drawing.Color.Transparent;
            this.waterColRightPanel.BackgroundImage = global::HOAWinApp.Properties.Resources.WATER_COLLECTION_DATA2;
            this.waterColRightPanel.Controls.Add(this.watSearchTB);
            this.waterColRightPanel.Controls.Add(this.watSearchBut);
            this.waterColRightPanel.Controls.Add(this.watRelBut);
            this.waterColRightPanel.Controls.Add(this.watercoltable);
            this.waterColRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.waterColRightPanel.Location = new System.Drawing.Point(169, 0);
            this.waterColRightPanel.Name = "waterColRightPanel";
            this.waterColRightPanel.Size = new System.Drawing.Size(815, 421);
            this.waterColRightPanel.TabIndex = 0;
            // 
            // watSearchTB
            // 
            this.watSearchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.watSearchTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.watSearchTB.Location = new System.Drawing.Point(20, 58);
            this.watSearchTB.Multiline = true;
            this.watSearchTB.Name = "watSearchTB";
            this.watSearchTB.Size = new System.Drawing.Size(606, 30);
            this.watSearchTB.TabIndex = 9;
            this.watSearchTB.Enter += new System.EventHandler(this.watSearchTB_Enter);
            this.watSearchTB.Leave += new System.EventHandler(this.watSearchTB_Leave);
            // 
            // watSearchBut
            // 
            this.watSearchBut.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watSearchBut.Location = new System.Drawing.Point(632, 58);
            this.watSearchBut.Name = "watSearchBut";
            this.watSearchBut.Size = new System.Drawing.Size(81, 30);
            this.watSearchBut.TabIndex = 8;
            this.watSearchBut.Text = "SEARCH";
            this.watSearchBut.UseVisualStyleBackColor = true;
            this.watSearchBut.Click += new System.EventHandler(this.watSearchBut_Click);
            // 
            // watRelBut
            // 
            this.watRelBut.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watRelBut.Location = new System.Drawing.Point(718, 58);
            this.watRelBut.Name = "watRelBut";
            this.watRelBut.Size = new System.Drawing.Size(79, 30);
            this.watRelBut.TabIndex = 7;
            this.watRelBut.Text = "RELOAD";
            this.watRelBut.UseVisualStyleBackColor = true;
            this.watRelBut.Click += new System.EventHandler(this.watRelBut_Click);
            // 
            // watercoltable
            // 
            this.watercoltable.AllowUserToOrderColumns = true;
            this.watercoltable.AllowUserToResizeColumns = false;
            this.watercoltable.AllowUserToResizeRows = false;
            this.watercoltable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watercoltable.Location = new System.Drawing.Point(20, 97);
            this.watercoltable.Name = "watercoltable";
            this.watercoltable.ReadOnly = true;
            this.watercoltable.RowHeadersWidth = 30;
            this.watercoltable.Size = new System.Drawing.Size(777, 305);
            this.watercoltable.TabIndex = 3;
            // 
            // waterColLeftPanel
            // 
            this.waterColLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(188)))), ((int)(((byte)(218)))));
            this.waterColLeftPanel.BackgroundImage = global::HOAWinApp.Properties.Resources.Untitled_design__7_6;
            this.waterColLeftPanel.Controls.Add(this.updateBut);
            this.waterColLeftPanel.Controls.Add(this.histWBut);
            this.waterColLeftPanel.Controls.Add(this.excelWBut);
            this.waterColLeftPanel.Controls.Add(this.postPaymentWBut);
            this.waterColLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterColLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.waterColLeftPanel.Name = "waterColLeftPanel";
            this.waterColLeftPanel.Size = new System.Drawing.Size(169, 421);
            this.waterColLeftPanel.TabIndex = 1;
            // 
            // updateBut
            // 
            this.updateBut.BackgroundImage = global::HOAWinApp.Properties.Resources.Generate_Excel_Report__4_1;
            this.updateBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBut.Location = new System.Drawing.Point(21, 130);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(125, 63);
            this.updateBut.TabIndex = 4;
            this.updateBut.UseVisualStyleBackColor = true;
            this.updateBut.Click += new System.EventHandler(this.updateBut_Click);
            // 
            // histWBut
            // 
            this.histWBut.BackgroundImage = global::HOAWinApp.Properties.Resources.Generate_Excel_Report__3_3;
            this.histWBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histWBut.Location = new System.Drawing.Point(21, 337);
            this.histWBut.Name = "histWBut";
            this.histWBut.Size = new System.Drawing.Size(125, 63);
            this.histWBut.TabIndex = 3;
            this.histWBut.UseVisualStyleBackColor = true;
            this.histWBut.Click += new System.EventHandler(this.histWBut_Click);
            // 
            // excelWBut
            // 
            this.excelWBut.BackgroundImage = global::HOAWinApp.Properties.Resources.Generate_Excel_Report__2_3;
            this.excelWBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelWBut.Location = new System.Drawing.Point(21, 268);
            this.excelWBut.Name = "excelWBut";
            this.excelWBut.Size = new System.Drawing.Size(125, 63);
            this.excelWBut.TabIndex = 2;
            this.excelWBut.UseVisualStyleBackColor = true;
            this.excelWBut.Click += new System.EventHandler(this.excelWBut_Click);
            // 
            // postPaymentWBut
            // 
            this.postPaymentWBut.BackgroundImage = global::HOAWinApp.Properties.Resources.Generate_Excel_Report3;
            this.postPaymentWBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPaymentWBut.Location = new System.Drawing.Point(21, 199);
            this.postPaymentWBut.Name = "postPaymentWBut";
            this.postPaymentWBut.Size = new System.Drawing.Size(125, 63);
            this.postPaymentWBut.TabIndex = 1;
            this.postPaymentWBut.UseVisualStyleBackColor = true;
            this.postPaymentWBut.Click += new System.EventHandler(this.postPaymentWBut_Click);
            // 
            // WaterCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.waterColLeftPanel);
            this.Controls.Add(this.waterColRightPanel);
            this.Name = "WaterCollection";
            this.Size = new System.Drawing.Size(984, 421);
            this.Load += new System.EventHandler(this.WaterCollection_Load);
            this.waterColRightPanel.ResumeLayout(false);
            this.waterColRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watercoltable)).EndInit();
            this.waterColLeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel waterColRightPanel;
        private System.Windows.Forms.Panel waterColLeftPanel;
        private System.Windows.Forms.Button postPaymentWBut;
        private System.Windows.Forms.Button excelWBut;
        private System.Windows.Forms.Button histWBut;
        private System.Windows.Forms.DataGridView watercoltable;
        private System.Windows.Forms.Button watRelBut;
        private System.Windows.Forms.Button watSearchBut;
        private System.Windows.Forms.TextBox watSearchTB;
        private System.Windows.Forms.Button updateBut;
    }
}
