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
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.blockNumTB = new System.Windows.Forms.TextBox();
            this.lotNumTB = new System.Windows.Forms.TextBox();
            this.clientAddErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.canBut = new MetroFramework.Controls.MetroButton();
            this.subBut = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.clientAddErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // fNameTB
            // 
            this.fNameTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTB.Location = new System.Drawing.Point(23, 103);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(208, 27);
            this.fNameTB.TabIndex = 2;
            this.fNameTB.Enter += new System.EventHandler(this.fNameTB_Enter);
            this.fNameTB.Leave += new System.EventHandler(this.fNameTB_Leave);
            // 
            // lNameTB
            // 
            this.lNameTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTB.Location = new System.Drawing.Point(260, 103);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(208, 27);
            this.lNameTB.TabIndex = 3;
            this.lNameTB.Enter += new System.EventHandler(this.lNameTB_Enter);
            this.lNameTB.Leave += new System.EventHandler(this.lNameTB_Leave);
            // 
            // blockNumTB
            // 
            this.blockNumTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockNumTB.Location = new System.Drawing.Point(23, 183);
            this.blockNumTB.Name = "blockNumTB";
            this.blockNumTB.Size = new System.Drawing.Size(208, 27);
            this.blockNumTB.TabIndex = 4;
            this.blockNumTB.TextChanged += new System.EventHandler(this.blockNumTB_TextChanged);
            // 
            // lotNumTB
            // 
            this.lotNumTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotNumTB.Location = new System.Drawing.Point(260, 183);
            this.lotNumTB.Name = "lotNumTB";
            this.lotNumTB.Size = new System.Drawing.Size(208, 27);
            this.lotNumTB.TabIndex = 5;
            this.lotNumTB.TextChanged += new System.EventHandler(this.lotNumTB_TextChanged);
            // 
            // clientAddErrorProvider
            // 
            this.clientAddErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.clientAddErrorProvider.ContainerControl = this;
            // 
            // canBut
            // 
            this.canBut.BackColor = System.Drawing.Color.Transparent;
            this.canBut.BackgroundImage = global::HOAWinApp.Properties.Resources.CANCEL;
            this.canBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.canBut.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.canBut.Location = new System.Drawing.Point(46, 225);
            this.canBut.Name = "canBut";
            this.canBut.Size = new System.Drawing.Size(176, 40);
            this.canBut.TabIndex = 9;
            this.canBut.UseSelectable = true;
            this.canBut.Click += new System.EventHandler(this.canBut_Click);
            // 
            // subBut
            // 
            this.subBut.BackColor = System.Drawing.Color.Transparent;
            this.subBut.BackgroundImage = global::HOAWinApp.Properties.Resources.subBut;
            this.subBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subBut.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.subBut.Location = new System.Drawing.Point(281, 225);
            this.subBut.Name = "subBut";
            this.subBut.Size = new System.Drawing.Size(176, 40);
            this.subBut.TabIndex = 10;
            this.subBut.UseSelectable = true;
            this.subBut.Click += new System.EventHandler(this.subBut_Click);
            // 
            // ClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::HOAWinApp.Properties.Resources.addclient1;
            this.Controls.Add(this.subBut);
            this.Controls.Add(this.canBut);
            this.Controls.Add(this.lotNumTB);
            this.Controls.Add(this.blockNumTB);
            this.Controls.Add(this.lNameTB);
            this.Controls.Add(this.fNameTB);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ClientAdd";
            this.Size = new System.Drawing.Size(500, 280);
            this.Load += new System.EventHandler(this.ClientAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientAddErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox blockNumTB;
        private System.Windows.Forms.TextBox lotNumTB;
        private System.Windows.Forms.ErrorProvider clientAddErrorProvider;
        private MetroFramework.Controls.MetroButton canBut;
        private MetroFramework.Controls.MetroButton subBut;
    }
}
