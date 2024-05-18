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
            this.clientRightPanel = new System.Windows.Forms.Panel();
            this.clientRelBut = new System.Windows.Forms.Button();
            this.clientSearchBut = new System.Windows.Forms.Button();
            this.clientSearchTB = new System.Windows.Forms.TextBox();
            this.clientTable = new System.Windows.Forms.DataGridView();
            this.clientLeftPanel = new System.Windows.Forms.Panel();
            this.addClientBut = new System.Windows.Forms.Button();
            this.deleteClientBut = new System.Windows.Forms.Button();
            this.editClientBut = new System.Windows.Forms.Button();
            this.clientRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientTable)).BeginInit();
            this.clientLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientRightPanel
            // 
            this.clientRightPanel.BackColor = System.Drawing.Color.Transparent;
            this.clientRightPanel.BackgroundImage = global::HOAWinApp.Properties.Resources.mainboardRightbg;
            this.clientRightPanel.Controls.Add(this.clientRelBut);
            this.clientRightPanel.Controls.Add(this.clientSearchBut);
            this.clientRightPanel.Controls.Add(this.clientSearchTB);
            this.clientRightPanel.Controls.Add(this.clientTable);
            this.clientRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientRightPanel.Location = new System.Drawing.Point(169, 0);
            this.clientRightPanel.Name = "clientRightPanel";
            this.clientRightPanel.Size = new System.Drawing.Size(1028, 698);
            this.clientRightPanel.TabIndex = 5;
            // 
            // clientRelBut
            // 
            this.clientRelBut.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientRelBut.Location = new System.Drawing.Point(916, 101);
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
            this.clientSearchBut.Location = new System.Drawing.Point(819, 101);
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
            this.clientSearchTB.Location = new System.Drawing.Point(425, 101);
            this.clientSearchTB.Multiline = true;
            this.clientSearchTB.Name = "clientSearchTB";
            this.clientSearchTB.Size = new System.Drawing.Size(388, 36);
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
            this.clientTable.Location = new System.Drawing.Point(24, 142);
            this.clientTable.Name = "clientTable";
            this.clientTable.ReadOnly = true;
            this.clientTable.RowHeadersWidth = 30;
            this.clientTable.Size = new System.Drawing.Size(979, 527);
            this.clientTable.TabIndex = 2;
            // 
            // clientLeftPanel
            // 
            this.clientLeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.clientLeftPanel.BackgroundImage = global::HOAWinApp.Properties.Resources.kilid3;
            this.clientLeftPanel.Controls.Add(this.addClientBut);
            this.clientLeftPanel.Controls.Add(this.deleteClientBut);
            this.clientLeftPanel.Controls.Add(this.editClientBut);
            this.clientLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.clientLeftPanel.Name = "clientLeftPanel";
            this.clientLeftPanel.Size = new System.Drawing.Size(169, 698);
            this.clientLeftPanel.TabIndex = 4;
            // 
            // addClientBut
            // 
            this.addClientBut.BackColor = System.Drawing.Color.Transparent;
            this.addClientBut.BackgroundImage = global::HOAWinApp.Properties.Resources.addclient;
            this.addClientBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClientBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientBut.Location = new System.Drawing.Point(18, 229);
            this.addClientBut.Name = "addClientBut";
            this.addClientBut.Size = new System.Drawing.Size(131, 65);
            this.addClientBut.TabIndex = 4;
            this.addClientBut.UseVisualStyleBackColor = false;
            this.addClientBut.Click += new System.EventHandler(this.addClientBut_Click);
            // 
            // deleteClientBut
            // 
            this.deleteClientBut.BackColor = System.Drawing.Color.Transparent;
            this.deleteClientBut.BackgroundImage = global::HOAWinApp.Properties.Resources.editclient;
            this.deleteClientBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteClientBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteClientBut.Location = new System.Drawing.Point(18, 466);
            this.deleteClientBut.Name = "deleteClientBut";
            this.deleteClientBut.Size = new System.Drawing.Size(131, 65);
            this.deleteClientBut.TabIndex = 2;
            this.deleteClientBut.UseVisualStyleBackColor = false;
            this.deleteClientBut.Click += new System.EventHandler(this.deleteClientBut_Click);
            // 
            // editClientBut
            // 
            this.editClientBut.BackColor = System.Drawing.Color.Transparent;
            this.editClientBut.BackgroundImage = global::HOAWinApp.Properties.Resources.editclient1;
            this.editClientBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editClientBut.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientBut.Location = new System.Drawing.Point(18, 351);
            this.editClientBut.Name = "editClientBut";
            this.editClientBut.Size = new System.Drawing.Size(131, 65);
            this.editClientBut.TabIndex = 1;
            this.editClientBut.Text = "EDIT CLIENT";
            this.editClientBut.UseVisualStyleBackColor = false;
            this.editClientBut.Click += new System.EventHandler(this.editClientBut_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientRightPanel);
            this.Controls.Add(this.clientLeftPanel);
            this.Name = "Clients";
            this.Size = new System.Drawing.Size(1197, 698);
            this.Load += new System.EventHandler(this.Clients_Load);
            this.clientRightPanel.ResumeLayout(false);
            this.clientRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientTable)).EndInit();
            this.clientLeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel clientLeftPanel;
        private System.Windows.Forms.Button addClientBut;
        private System.Windows.Forms.Button deleteClientBut;
        private System.Windows.Forms.Button editClientBut;
        private System.Windows.Forms.Panel clientRightPanel;
        private System.Windows.Forms.Button clientRelBut;
        private System.Windows.Forms.Button clientSearchBut;
        private System.Windows.Forms.TextBox clientSearchTB;
        private System.Windows.Forms.DataGridView clientTable;
    }
}
