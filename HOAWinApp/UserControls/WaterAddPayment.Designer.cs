namespace HOAWinApp.UserControls
{
    partial class WaterAddPayment
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
            this.payAmTB = new System.Windows.Forms.TextBox();
            this.dtpGarbHist = new System.Windows.Forms.DateTimePicker();
            this.clientNameTB = new System.Windows.Forms.TextBox();
            this.addPaymentErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.canBut = new MetroFramework.Controls.MetroButton();
            this.subBut = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.addPaymentErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // payAmTB
            // 
            this.payAmTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payAmTB.Location = new System.Drawing.Point(347, 161);
            this.payAmTB.Name = "payAmTB";
            this.payAmTB.Size = new System.Drawing.Size(284, 22);
            this.payAmTB.TabIndex = 4;
            this.payAmTB.TabStop = false;
            this.payAmTB.TextChanged += new System.EventHandler(this.payAmTB_TextChanged);
            // 
            // dtpGarbHist
            // 
            this.dtpGarbHist.CustomFormat = "yyyy-MM-dd";
            this.dtpGarbHist.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGarbHist.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGarbHist.Location = new System.Drawing.Point(347, 229);
            this.dtpGarbHist.Margin = new System.Windows.Forms.Padding(5);
            this.dtpGarbHist.Name = "dtpGarbHist";
            this.dtpGarbHist.Size = new System.Drawing.Size(284, 21);
            this.dtpGarbHist.TabIndex = 5;
            this.dtpGarbHist.TabStop = false;
            this.dtpGarbHist.Value = new System.DateTime(2024, 2, 24, 0, 0, 0, 0);
            // 
            // clientNameTB
            // 
            this.clientNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameTB.Location = new System.Drawing.Point(347, 103);
            this.clientNameTB.Name = "clientNameTB";
            this.clientNameTB.Size = new System.Drawing.Size(284, 22);
            this.clientNameTB.TabIndex = 3;
            this.clientNameTB.TabStop = false;
            this.clientNameTB.Enter += new System.EventHandler(this.garbAddPTB_Enter);
            this.clientNameTB.Leave += new System.EventHandler(this.garbAddPTB_Leave);
            // 
            // addPaymentErrorProvider
            // 
            this.addPaymentErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.addPaymentErrorProvider.ContainerControl = this;
            // 
            // canBut
            // 
            this.canBut.BackColor = System.Drawing.Color.Transparent;
            this.canBut.BackgroundImage = global::HOAWinApp.Properties.Resources.CANCEL;
            this.canBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.canBut.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.canBut.Location = new System.Drawing.Point(155, 298);
            this.canBut.Name = "canBut";
            this.canBut.Size = new System.Drawing.Size(176, 40);
            this.canBut.TabIndex = 19;
            this.canBut.UseSelectable = true;
            this.canBut.Click += new System.EventHandler(this.canBut_Click);
            // 
            // subBut
            // 
            this.subBut.BackColor = System.Drawing.Color.Transparent;
            this.subBut.BackgroundImage = global::HOAWinApp.Properties.Resources.subBut;
            this.subBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subBut.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.subBut.Location = new System.Drawing.Point(438, 298);
            this.subBut.Name = "subBut";
            this.subBut.Size = new System.Drawing.Size(176, 40);
            this.subBut.TabIndex = 20;
            this.subBut.UseSelectable = true;
            this.subBut.Click += new System.EventHandler(this.subBut_Click);
            // 
            // WaterAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::HOAWinApp.Properties.Resources.waterPbg2;
            this.Controls.Add(this.subBut);
            this.Controls.Add(this.canBut);
            this.Controls.Add(this.clientNameTB);
            this.Controls.Add(this.dtpGarbHist);
            this.Controls.Add(this.payAmTB);
            this.Name = "WaterAddPayment";
            this.Size = new System.Drawing.Size(714, 360);
            this.Load += new System.EventHandler(this.garbAddPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPaymentErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox payAmTB;
        private System.Windows.Forms.DateTimePicker dtpGarbHist;
        private System.Windows.Forms.TextBox clientNameTB;
        private System.Windows.Forms.ErrorProvider addPaymentErrorProvider;
        private MetroFramework.Controls.MetroButton canBut;
        private MetroFramework.Controls.MetroButton subBut;
    }
}
