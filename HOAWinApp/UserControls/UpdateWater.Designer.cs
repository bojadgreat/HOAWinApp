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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.BillingDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
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
            this.curReadingTB.Size = new System.Drawing.Size(196, 20);
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
            this.cancelBut.Location = new System.Drawing.Point(27, 288);
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
            this.subBut.Location = new System.Drawing.Point(192, 288);
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
            this.clientNameTB.Size = new System.Drawing.Size(221, 20);
            this.clientNameTB.TabIndex = 3;
            this.clientNameTB.Enter += new System.EventHandler(this.clientNameTB_Enter);
            this.clientNameTB.Leave += new System.EventHandler(this.clientNameTB_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date To:";
            // 
            // DateFrom
            // 
            this.DateFrom.Location = new System.Drawing.Point(124, 96);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(200, 20);
            this.DateFrom.TabIndex = 7;
            // 
            // DateTo
            // 
            this.DateTo.Location = new System.Drawing.Point(124, 140);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(200, 20);
            this.DateTo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Billing Date:";
            // 
            // BillingDate
            // 
            this.BillingDate.Location = new System.Drawing.Point(124, 188);
            this.BillingDate.Name = "BillingDate";
            this.BillingDate.Size = new System.Drawing.Size(200, 20);
            this.BillingDate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Due Date:";
            // 
            // DueDate
            // 
            this.DueDate.Location = new System.Drawing.Point(124, 230);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(200, 20);
            this.DueDate.TabIndex = 12;
            // 
            // UpdateWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BillingDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientNameTB);
            this.Controls.Add(this.subBut);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.curReadingTB);
            this.Controls.Add(this.label2);
            this.Name = "UpdateWater";
            this.Size = new System.Drawing.Size(339, 352);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker BillingDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DueDate;
    }
}
