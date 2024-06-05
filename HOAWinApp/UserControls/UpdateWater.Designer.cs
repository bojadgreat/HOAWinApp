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
            this.curReadingTB = new System.Windows.Forms.TextBox();
            this.clientNameTB = new System.Windows.Forms.TextBox();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.BillingDate = new System.Windows.Forms.DateTimePicker();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.cancelBut = new MetroFramework.Controls.MetroButton();
            this.subBut = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // curReadingTB
            // 
            this.curReadingTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curReadingTB.Location = new System.Drawing.Point(380, 129);
            this.curReadingTB.Name = "curReadingTB";
            this.curReadingTB.Size = new System.Drawing.Size(298, 22);
            this.curReadingTB.TabIndex = 4;
            this.curReadingTB.TextChanged += new System.EventHandler(this.curReadingTB_TextChanged);
            this.curReadingTB.Enter += new System.EventHandler(this.curReadingTB_Enter);
            this.curReadingTB.Leave += new System.EventHandler(this.curReadingTB_Leave);
            // 
            // clientNameTB
            // 
            this.clientNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameTB.Location = new System.Drawing.Point(380, 71);
            this.clientNameTB.Name = "clientNameTB";
            this.clientNameTB.Size = new System.Drawing.Size(298, 22);
            this.clientNameTB.TabIndex = 3;
            this.clientNameTB.Enter += new System.EventHandler(this.clientNameTB_Enter);
            this.clientNameTB.Leave += new System.EventHandler(this.clientNameTB_Leave);
            // 
            // DateFrom
            // 
            this.DateFrom.Location = new System.Drawing.Point(168, 192);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(200, 20);
            this.DateFrom.TabIndex = 7;
            // 
            // DateTo
            // 
            this.DateTo.Location = new System.Drawing.Point(487, 192);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(200, 20);
            this.DateTo.TabIndex = 8;
            // 
            // BillingDate
            // 
            this.BillingDate.Location = new System.Drawing.Point(168, 229);
            this.BillingDate.Name = "BillingDate";
            this.BillingDate.Size = new System.Drawing.Size(200, 20);
            this.BillingDate.TabIndex = 10;
            // 
            // DueDate
            // 
            this.DueDate.Location = new System.Drawing.Point(487, 229);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(200, 20);
            this.DueDate.TabIndex = 12;
            // 
            // cancelBut
            // 
            this.cancelBut.BackColor = System.Drawing.Color.Transparent;
            this.cancelBut.BackgroundImage = global::HOAWinApp.Properties.Resources.CANCEL;
            this.cancelBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBut.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cancelBut.Location = new System.Drawing.Point(156, 279);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(176, 40);
            this.cancelBut.TabIndex = 13;
            this.cancelBut.UseSelectable = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // subBut
            // 
            this.subBut.BackColor = System.Drawing.Color.Transparent;
            this.subBut.BackgroundImage = global::HOAWinApp.Properties.Resources.subBut;
            this.subBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subBut.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.subBut.Location = new System.Drawing.Point(436, 279);
            this.subBut.Name = "subBut";
            this.subBut.Size = new System.Drawing.Size(176, 40);
            this.subBut.TabIndex = 14;
            this.subBut.UseSelectable = true;
            this.subBut.Click += new System.EventHandler(this.subBut_Click);
            // 
            // UpdateWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::HOAWinApp.Properties.Resources.UPsreading41;
            this.Controls.Add(this.subBut);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.BillingDate);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.clientNameTB);
            this.Controls.Add(this.curReadingTB);
            this.Name = "UpdateWater";
            this.Size = new System.Drawing.Size(732, 325);
            this.Load += new System.EventHandler(this.UpdateWater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox curReadingTB;
        private System.Windows.Forms.TextBox clientNameTB;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.DateTimePicker BillingDate;
        private System.Windows.Forms.DateTimePicker DueDate;
        private MetroFramework.Controls.MetroButton cancelBut;
        private MetroFramework.Controls.MetroButton subBut;
    }
}
