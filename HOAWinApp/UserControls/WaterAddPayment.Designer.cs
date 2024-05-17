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
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.payAmTB = new System.Windows.Forms.TextBox();
            this.dtpGarbHist = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.canBut = new System.Windows.Forms.Button();
            this.subBut = new System.Windows.Forms.Button();
            this.clientNameTB = new System.Windows.Forms.TextBox();
            this.addPaymentErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addPaymentErrorProvider)).BeginInit();
            this.SuspendLayout();
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
            // payAmTB
            // 
            this.payAmTB.Location = new System.Drawing.Point(173, 37);
            this.payAmTB.Name = "payAmTB";
            this.payAmTB.Size = new System.Drawing.Size(200, 20);
            this.payAmTB.TabIndex = 4;
            this.payAmTB.TabStop = false;
            this.payAmTB.TextChanged += new System.EventHandler(this.payAmTB_TextChanged);
            // 
            // dtpGarbHist
            // 
            this.dtpGarbHist.CustomFormat = "yyyy-MM-dd";
            this.dtpGarbHist.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGarbHist.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGarbHist.Location = new System.Drawing.Point(173, 63);
            this.dtpGarbHist.Name = "dtpGarbHist";
            this.dtpGarbHist.Size = new System.Drawing.Size(200, 21);
            this.dtpGarbHist.TabIndex = 5;
            this.dtpGarbHist.TabStop = false;
            this.dtpGarbHist.Value = new System.DateTime(2024, 2, 24, 0, 0, 0, 0);
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
            // canBut
            // 
            this.canBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.canBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.canBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.canBut.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canBut.Location = new System.Drawing.Point(5, 156);
            this.canBut.Name = "canBut";
            this.canBut.Size = new System.Drawing.Size(180, 34);
            this.canBut.TabIndex = 1;
            this.canBut.Text = "CANCEL";
            this.canBut.UseVisualStyleBackColor = false;
            this.canBut.Click += new System.EventHandler(this.canBut_Click);
            // 
            // subBut
            // 
            this.subBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(115)))));
            this.subBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subBut.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBut.Location = new System.Drawing.Point(215, 156);
            this.subBut.Name = "subBut";
            this.subBut.Size = new System.Drawing.Size(180, 34);
            this.subBut.TabIndex = 2;
            this.subBut.Text = "SUBMIT";
            this.subBut.UseVisualStyleBackColor = false;
            this.subBut.Click += new System.EventHandler(this.subBut_Click);
            // 
            // clientNameTB
            // 
            this.clientNameTB.Location = new System.Drawing.Point(173, 10);
            this.clientNameTB.Name = "clientNameTB";
            this.clientNameTB.Size = new System.Drawing.Size(200, 20);
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
            // WaterAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(156)))), ((int)(((byte)(206)))));
            this.Controls.Add(this.clientNameTB);
            this.Controls.Add(this.subBut);
            this.Controls.Add(this.canBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpGarbHist);
            this.Controls.Add(this.payAmTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientNameLabel);
            this.Name = "WaterAddPayment";
            this.Size = new System.Drawing.Size(400, 200);
            this.Load += new System.EventHandler(this.garbAddPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPaymentErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payAmTB;
        private System.Windows.Forms.DateTimePicker dtpGarbHist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button canBut;
        private System.Windows.Forms.Button subBut;
        private System.Windows.Forms.TextBox clientNameTB;
        private System.Windows.Forms.ErrorProvider addPaymentErrorProvider;
    }
}
