namespace HOAWinApp.UserControls
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.clientLeftPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addClientBut = new System.Windows.Forms.Button();
            this.deleteClientBut = new System.Windows.Forms.Button();
            this.editClientBut = new System.Windows.Forms.Button();
            this.clientRightPanel = new System.Windows.Forms.Panel();
            this.clientRelBut = new System.Windows.Forms.Button();
            this.clientSearchBut = new System.Windows.Forms.Button();
            this.clientSearchTB = new System.Windows.Forms.TextBox();
            this.clientTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.clientLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.clientRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientTable)).BeginInit();
            this.SuspendLayout();
            // 
            // clientLeftPanel
            // 
            this.clientLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(188)))), ((int)(((byte)(218)))));
            this.clientLeftPanel.Controls.Add(this.pictureBox1);
            this.clientLeftPanel.Controls.Add(this.addClientBut);
            this.clientLeftPanel.Controls.Add(this.deleteClientBut);
            this.clientLeftPanel.Controls.Add(this.editClientBut);
            this.clientLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.clientLeftPanel.Name = "clientLeftPanel";
            this.clientLeftPanel.Size = new System.Drawing.Size(170, 768);
            this.clientLeftPanel.TabIndex = 4;
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
            // addClientBut
            // 
            this.addClientBut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addClientBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClientBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientBut.Location = new System.Drawing.Point(21, 217);
            this.addClientBut.Name = "addClientBut";
            this.addClientBut.Size = new System.Drawing.Size(125, 63);
            this.addClientBut.TabIndex = 4;
            this.addClientBut.Text = "ADD CLIENT";
            this.addClientBut.UseVisualStyleBackColor = false;
            this.addClientBut.Click += new System.EventHandler(this.addClientBut_Click);
            // 
            // deleteClientBut
            // 
            this.deleteClientBut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteClientBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteClientBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteClientBut.Location = new System.Drawing.Point(21, 422);
            this.deleteClientBut.Name = "deleteClientBut";
            this.deleteClientBut.Size = new System.Drawing.Size(125, 63);
            this.deleteClientBut.TabIndex = 2;
            this.deleteClientBut.Text = "DELETE CLIENT";
            this.deleteClientBut.UseVisualStyleBackColor = false;
            this.deleteClientBut.Click += new System.EventHandler(this.deleteClientBut_Click);
            // 
            // editClientBut
            // 
            this.editClientBut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editClientBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editClientBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientBut.Location = new System.Drawing.Point(21, 326);
            this.editClientBut.Name = "editClientBut";
            this.editClientBut.Size = new System.Drawing.Size(125, 63);
            this.editClientBut.TabIndex = 1;
            this.editClientBut.Text = "EDIT CLIENT";
            this.editClientBut.UseVisualStyleBackColor = false;
            this.editClientBut.Click += new System.EventHandler(this.editClientBut_Click);
            // 
            // clientRightPanel
            // 
            this.clientRightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(85)))));
            this.clientRightPanel.Controls.Add(this.clientRelBut);
            this.clientRightPanel.Controls.Add(this.clientSearchBut);
            this.clientRightPanel.Controls.Add(this.clientSearchTB);
            this.clientRightPanel.Controls.Add(this.clientTable);
            this.clientRightPanel.Controls.Add(this.label1);
            this.clientRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientRightPanel.Location = new System.Drawing.Point(170, 0);
            this.clientRightPanel.Name = "clientRightPanel";
            this.clientRightPanel.Size = new System.Drawing.Size(1196, 768);
            this.clientRightPanel.TabIndex = 5;
            // 
            // clientRelBut
            // 
            this.clientRelBut.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientRelBut.Location = new System.Drawing.Point(1060, 84);
            this.clientRelBut.Name = "clientRelBut";
            this.clientRelBut.Size = new System.Drawing.Size(87, 35);
            this.clientRelBut.TabIndex = 6;
            this.clientRelBut.Text = "RELOAD";
            this.clientRelBut.UseVisualStyleBackColor = true;
            this.clientRelBut.Click += new System.EventHandler(this.clientRelBut_Click);
            // 
            // clientSearchBut
            // 
            this.clientSearchBut.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSearchBut.Location = new System.Drawing.Point(949, 84);
            this.clientSearchBut.Name = "clientSearchBut";
            this.clientSearchBut.Size = new System.Drawing.Size(91, 35);
            this.clientSearchBut.TabIndex = 5;
            this.clientSearchBut.Text = "SEARCH";
            this.clientSearchBut.UseVisualStyleBackColor = true;
            this.clientSearchBut.Click += new System.EventHandler(this.clientSearchBut_Click);
            // 
            // clientSearchTB
            // 
            this.clientSearchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.clientSearchTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.clientSearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSearchTB.Location = new System.Drawing.Point(458, 84);
            this.clientSearchTB.Multiline = true;
            this.clientSearchTB.Name = "clientSearchTB";
            this.clientSearchTB.Size = new System.Drawing.Size(475, 35);
            this.clientSearchTB.TabIndex = 4;
            this.clientSearchTB.Enter += new System.EventHandler(this.clientSearchTB_Enter);
            this.clientSearchTB.Leave += new System.EventHandler(this.clientSearchTB_Leave);
            // 
            // clientTable
            // 
            this.clientTable.AllowUserToOrderColumns = true;
            this.clientTable.AllowUserToResizeColumns = false;
            this.clientTable.AllowUserToResizeRows = false;
            this.clientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientTable.Location = new System.Drawing.Point(20, 135);
            this.clientTable.Name = "clientTable";
            this.clientTable.ReadOnly = true;
            this.clientTable.RowHeadersWidth = 30;
            this.clientTable.Size = new System.Drawing.Size(1127, 524);
            this.clientTable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1196, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENT LIST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientRightPanel);
            this.Controls.Add(this.clientLeftPanel);
            this.Name = "Clients";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.Clients_Load);
            this.clientLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.clientRightPanel.ResumeLayout(false);
            this.clientRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel clientLeftPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addClientBut;
        private System.Windows.Forms.Button deleteClientBut;
        private System.Windows.Forms.Button editClientBut;
        private System.Windows.Forms.Panel clientRightPanel;
        private System.Windows.Forms.Button clientRelBut;
        private System.Windows.Forms.Button clientSearchBut;
        private System.Windows.Forms.TextBox clientSearchTB;
        private System.Windows.Forms.DataGridView clientTable;
        private System.Windows.Forms.Label label1;
    }
}
