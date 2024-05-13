namespace HOAWinApp.UserControls
{
    partial class ClientAdd
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
            this.components = new System.ComponentModel.Container();
            this.canBut = new System.Windows.Forms.Button();
            this.subBut = new System.Windows.Forms.Button();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.blockNumTB = new System.Windows.Forms.TextBox();
            this.lotNumTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientAddErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientAddErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // canBut
            // 
            this.canBut.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canBut.Location = new System.Drawing.Point(23, 205);
            this.canBut.Name = "canBut";
            this.canBut.Size = new System.Drawing.Size(153, 53);
            this.canBut.TabIndex = 0;
            this.canBut.Text = "CANCEL";
            this.canBut.UseVisualStyleBackColor = true;
            this.canBut.Click += new System.EventHandler(this.canBut_Click);
            // 
            // subBut
            // 
            this.subBut.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBut.Location = new System.Drawing.Point(323, 205);
            this.subBut.Name = "subBut";
            this.subBut.Size = new System.Drawing.Size(153, 53);
            this.subBut.TabIndex = 1;
            this.subBut.Text = "SUBMIT";
            this.subBut.UseVisualStyleBackColor = true;
            this.subBut.Click += new System.EventHandler(this.subBut_Click);
            // 
            // fNameTB
            // 
            this.fNameTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTB.Location = new System.Drawing.Point(23, 41);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(208, 27);
            this.fNameTB.TabIndex = 2;
            this.fNameTB.Enter += new System.EventHandler(this.fNameTB_Enter);
            this.fNameTB.Leave += new System.EventHandler(this.fNameTB_Leave);
            // 
            // lNameTB
            // 
            this.lNameTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTB.Location = new System.Drawing.Point(268, 41);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(208, 27);
            this.lNameTB.TabIndex = 3;
            this.lNameTB.Enter += new System.EventHandler(this.lNameTB_Enter);
            this.lNameTB.Leave += new System.EventHandler(this.lNameTB_Leave);
            // 
            // blockNumTB
            // 
            this.blockNumTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockNumTB.Location = new System.Drawing.Point(23, 137);
            this.blockNumTB.Name = "blockNumTB";
            this.blockNumTB.Size = new System.Drawing.Size(208, 27);
            this.blockNumTB.TabIndex = 4;
            this.blockNumTB.TextChanged += new System.EventHandler(this.blockNumTB_TextChanged);
            // 
            // lotNumTB
            // 
            this.lotNumTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotNumTB.Location = new System.Drawing.Point(268, 137);
            this.lotNumTB.Name = "lotNumTB";
            this.lotNumTB.Size = new System.Drawing.Size(208, 27);
            this.lotNumTB.TabIndex = 5;
            this.lotNumTB.TextChanged += new System.EventHandler(this.lotNumTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Block Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lot Number:";
            // 
            // clientAddErrorProvider
            // 
            this.clientAddErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.clientAddErrorProvider.ContainerControl = this;
            // 
            // ClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lotNumTB);
            this.Controls.Add(this.blockNumTB);
            this.Controls.Add(this.lNameTB);
            this.Controls.Add(this.fNameTB);
            this.Controls.Add(this.subBut);
            this.Controls.Add(this.canBut);
            this.Name = "ClientAdd";
            this.Size = new System.Drawing.Size(500, 280);
            this.Load += new System.EventHandler(this.ClientAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientAddErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button canBut;
        private System.Windows.Forms.Button subBut;
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox blockNumTB;
        private System.Windows.Forms.TextBox lotNumTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider clientAddErrorProvider;
    }
}
