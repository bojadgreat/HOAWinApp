namespace HOAWinApp.UserControls
{
    partial class ClientEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientEdit));
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.blockNumTB = new System.Windows.Forms.TextBox();
            this.lotNumTB = new System.Windows.Forms.TextBox();
            this.canBut = new System.Windows.Forms.Button();
            this.subBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientLBox = new System.Windows.Forms.ListBox();
            this.searchClientTB = new System.Windows.Forms.TextBox();
            this.searchBut = new System.Windows.Forms.Button();
            this.listGBox = new System.Windows.Forms.GroupBox();
            this.listGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fNameTB
            // 
            this.fNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTB.Location = new System.Drawing.Point(209, 42);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(130, 26);
            this.fNameTB.TabIndex = 1;
            // 
            // lNameTB
            // 
            this.lNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTB.Location = new System.Drawing.Point(367, 42);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(130, 26);
            this.lNameTB.TabIndex = 5;
            // 
            // blockNumTB
            // 
            this.blockNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockNumTB.Location = new System.Drawing.Point(209, 117);
            this.blockNumTB.Name = "blockNumTB";
            this.blockNumTB.Size = new System.Drawing.Size(130, 26);
            this.blockNumTB.TabIndex = 6;
            this.blockNumTB.TextChanged += new System.EventHandler(this.blockNumTB_TextChanged);
            // 
            // lotNumTB
            // 
            this.lotNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotNumTB.Location = new System.Drawing.Point(367, 117);
            this.lotNumTB.Name = "lotNumTB";
            this.lotNumTB.Size = new System.Drawing.Size(130, 26);
            this.lotNumTB.TabIndex = 7;
            this.lotNumTB.TextChanged += new System.EventHandler(this.lotNumTB_TextChanged);
            // 
            // canBut
            // 
            this.canBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canBut.Location = new System.Drawing.Point(209, 199);
            this.canBut.Name = "canBut";
            this.canBut.Size = new System.Drawing.Size(130, 55);
            this.canBut.TabIndex = 8;
            this.canBut.Text = "CANCEL";
            this.canBut.UseVisualStyleBackColor = true;
            this.canBut.Click += new System.EventHandler(this.canBut_Click);
            // 
            // subBut
            // 
            this.subBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBut.Location = new System.Drawing.Point(367, 199);
            this.subBut.Name = "subBut";
            this.subBut.Size = new System.Drawing.Size(130, 55);
            this.subBut.TabIndex = 9;
            this.subBut.Text = "SUBMIT";
            this.subBut.UseVisualStyleBackColor = true;
            this.subBut.Click += new System.EventHandler(this.subBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Block Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lot Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Last Name";
            // 
            // clientLBox
            // 
            this.clientLBox.FormattingEnabled = true;
            this.clientLBox.Location = new System.Drawing.Point(6, 48);
            this.clientLBox.Name = "clientLBox";
            this.clientLBox.Size = new System.Drawing.Size(188, 212);
            this.clientLBox.TabIndex = 14;
            this.clientLBox.SelectedIndexChanged += new System.EventHandler(this.clientLBox_SelectedIndexChanged);
            // 
            // searchClientTB
            // 
            this.searchClientTB.Location = new System.Drawing.Point(38, 21);
            this.searchClientTB.Name = "searchClientTB";
            this.searchClientTB.Size = new System.Drawing.Size(156, 20);
            this.searchClientTB.TabIndex = 15;
            this.searchClientTB.Enter += new System.EventHandler(this.searchClientTB_Enter);
            this.searchClientTB.Leave += new System.EventHandler(this.searchClientTB_Leave);
            // 
            // searchBut
            // 
            this.searchBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBut.BackgroundImage")));
            this.searchBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchBut.Location = new System.Drawing.Point(6, 19);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(27, 23);
            this.searchBut.TabIndex = 16;
            this.searchBut.UseVisualStyleBackColor = true;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // listGBox
            // 
            this.listGBox.Controls.Add(this.clientLBox);
            this.listGBox.Controls.Add(this.searchClientTB);
            this.listGBox.Controls.Add(this.searchBut);
            this.listGBox.Location = new System.Drawing.Point(3, 5);
            this.listGBox.Name = "listGBox";
            this.listGBox.Size = new System.Drawing.Size(200, 262);
            this.listGBox.TabIndex = 17;
            this.listGBox.TabStop = false;
            this.listGBox.Text = "Client Names";
            // 
            // ClientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.listGBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subBut);
            this.Controls.Add(this.canBut);
            this.Controls.Add(this.lotNumTB);
            this.Controls.Add(this.blockNumTB);
            this.Controls.Add(this.lNameTB);
            this.Controls.Add(this.fNameTB);
            this.Name = "ClientEdit";
            this.Size = new System.Drawing.Size(500, 270);
            this.Load += new System.EventHandler(this.ClientEdit_Load);
            this.listGBox.ResumeLayout(false);
            this.listGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox blockNumTB;
        private System.Windows.Forms.TextBox lotNumTB;
        private System.Windows.Forms.Button canBut;
        private System.Windows.Forms.Button subBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox clientLBox;
        private System.Windows.Forms.TextBox searchClientTB;
        private System.Windows.Forms.Button searchBut;
        private System.Windows.Forms.GroupBox listGBox;
    }
}
