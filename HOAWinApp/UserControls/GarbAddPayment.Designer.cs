namespace HOAWinApp.UserControls
{
    partial class GarbAddPayment
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
            this.remCBox = new System.Windows.Forms.ComboBox();
            this.promCBox = new System.Windows.Forms.CheckBox();
            this.addPaymentErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.canBut = new MetroFramework.Controls.MetroButton();
            this.subBut = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.addPaymentErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // payAmTB
            // 
            this.payAmTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payAmTB.Location = new System.Drawing.Point(331, 161);
            this.payAmTB.Name = "payAmTB";
            this.payAmTB.Size = new System.Drawing.Size(320, 22);
            this.payAmTB.TabIndex = 4;
            this.payAmTB.TabStop = false;
            this.payAmTB.TextChanged += new System.EventHandler(this.payAmTB_TextChanged);
            // 
            // dtpGarbHist
            // 
            this.dtpGarbHist.CustomFormat = "yyyy-MM-dd";
            this.dtpGarbHist.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGarbHist.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGarbHist.Location = new System.Drawing.Point(331, 232);
            this.dtpGarbHist.Name = "dtpGarbHist";
            this.dtpGarbHist.Size = new System.Drawing.Size(94, 21);
            this.dtpGarbHist.TabIndex = 5;
            this.dtpGarbHist.TabStop = false;
            this.dtpGarbHist.Value = new System.DateTime(2024, 2, 24, 0, 0, 0, 0);
            // 
            // clientNameTB
            // 
            this.clientNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameTB.Location = new System.Drawing.Point(331, 104);
            this.clientNameTB.Name = "clientNameTB";
            this.clientNameTB.Size = new System.Drawing.Size(320, 22);
            this.clientNameTB.TabIndex = 3;
            this.clientNameTB.TabStop = false;
            this.clientNameTB.TextChanged += new System.EventHandler(this.clientNameTB_TextChanged);
            this.clientNameTB.Enter += new System.EventHandler(this.garbAddPTB_Enter);
            this.clientNameTB.Leave += new System.EventHandler(this.garbAddPTB_Leave);
            // 
            // remCBox
            // 
            this.remCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remCBox.FormattingEnabled = true;
            this.remCBox.Location = new System.Drawing.Point(584, 234);
            this.remCBox.Name = "remCBox";
            this.remCBox.Size = new System.Drawing.Size(67, 21);
            this.remCBox.TabIndex = 6;
            // 
            // promCBox
            // 
            this.promCBox.AutoSize = true;
            this.promCBox.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promCBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.promCBox.Location = new System.Drawing.Point(488, 261);
            this.promCBox.Name = "promCBox";
            this.promCBox.Size = new System.Drawing.Size(163, 24);
            this.promCBox.TabIndex = 7;
            this.promCBox.Text = "Apply For Promissory Note";
            this.promCBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.promCBox.UseVisualStyleBackColor = true;
            this.promCBox.CheckedChanged += new System.EventHandler(this.promCBox_CheckedChanged);
            // 
            // addPaymentErrorProvider
            // 
            this.addPaymentErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.addPaymentErrorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Payment Remarks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount:";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLabel.Location = new System.Drawing.Point(1, 11);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(99, 20);
            this.clientNameLabel.TabIndex = 1;
            this.clientNameLabel.Text = "Client Name:";
            this.clientNameLabel.Click += new System.EventHandler(this.clientNameLabel_Click);
            // 
            // canBut
            // 
            this.canBut.BackColor = System.Drawing.Color.Transparent;
            this.canBut.BackgroundImage = global::HOAWinApp.Properties.Resources.CANCEL;
            this.canBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.canBut.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.canBut.Location = new System.Drawing.Point(214, 290);
            this.canBut.Name = "canBut";
            this.canBut.Size = new System.Drawing.Size(176, 40);
            this.canBut.TabIndex = 8;
            this.canBut.UseSelectable = true;
            this.canBut.Click += new System.EventHandler(this.canBut_Click);
            // 
            // subBut
            // 
            this.subBut.BackColor = System.Drawing.Color.Transparent;
            this.subBut.BackgroundImage = global::HOAWinApp.Properties.Resources.subBut;
            this.subBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subBut.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.subBut.Location = new System.Drawing.Point(443, 290);
            this.subBut.Name = "subBut";
            this.subBut.Size = new System.Drawing.Size(176, 40);
            this.subBut.TabIndex = 9;
            this.subBut.UseSelectable = true;
            this.subBut.Click += new System.EventHandler(this.subBut_Click);
            // 
            // GarbAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::HOAWinApp.Properties.Resources.grabaddpayments4;
            this.Controls.Add(this.subBut);
            this.Controls.Add(this.canBut);
            this.Controls.Add(this.promCBox);
            this.Controls.Add(this.remCBox);
            this.Controls.Add(this.clientNameTB);
            this.Controls.Add(this.dtpGarbHist);
            this.Controls.Add(this.payAmTB);
            this.Name = "GarbAddPayment";
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
        private System.Windows.Forms.ComboBox remCBox;
        private System.Windows.Forms.CheckBox promCBox;
        private System.Windows.Forms.ErrorProvider addPaymentErrorProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clientNameLabel;
        private MetroFramework.Controls.MetroButton canBut;
        private MetroFramework.Controls.MetroButton subBut;
    }
}
