namespace HOAWinApp.UserControls
{
    partial class UpdateWater
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
            this.label2 = new System.Windows.Forms.Label();
            this.curReadingTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBut = new System.Windows.Forms.Button();
            this.subBut = new System.Windows.Forms.Button();
            this.clientNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Reading:";
            // 
            // curReadingTB
            // 
            this.curReadingTB.Location = new System.Drawing.Point(128, 48);
            this.curReadingTB.Name = "curReadingTB";
            this.curReadingTB.Size = new System.Drawing.Size(169, 20);
            this.curReadingTB.TabIndex = 4;
            this.curReadingTB.TextChanged += new System.EventHandler(this.curReadingTB_TextChanged);
            this.curReadingTB.Enter += new System.EventHandler(this.curReadingTB_Enter);
            this.curReadingTB.Leave += new System.EventHandler(this.curReadingTB_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client Name:";
            // 
            // cancelBut
            // 
            this.cancelBut.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBut.Location = new System.Drawing.Point(9, 94);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(115, 36);
            this.cancelBut.TabIndex = 1;
            this.cancelBut.Text = "CANCEL";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // subBut
            // 
            this.subBut.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBut.Location = new System.Drawing.Point(173, 94);
            this.subBut.Name = "subBut";
            this.subBut.Size = new System.Drawing.Size(115, 36);
            this.subBut.TabIndex = 2;
            this.subBut.Text = "SUBMIT";
            this.subBut.UseVisualStyleBackColor = true;
            this.subBut.Click += new System.EventHandler(this.subBut_Click);
            // 
            // clientNameTB
            // 
            this.clientNameTB.Location = new System.Drawing.Point(103, 9);
            this.clientNameTB.Name = "clientNameTB";
            this.clientNameTB.Size = new System.Drawing.Size(194, 20);
            this.clientNameTB.TabIndex = 3;
            this.clientNameTB.Enter += new System.EventHandler(this.clientNameTB_Enter);
            this.clientNameTB.Leave += new System.EventHandler(this.clientNameTB_Leave);
            // 
            // UpdateWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.clientNameTB);
            this.Controls.Add(this.subBut);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.curReadingTB);
            this.Controls.Add(this.label2);
            this.Name = "UpdateWater";
            this.Size = new System.Drawing.Size(300, 140);
            this.Load += new System.EventHandler(this.UpdateWater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox curReadingTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button subBut;
        private System.Windows.Forms.TextBox clientNameTB;
    }
}
