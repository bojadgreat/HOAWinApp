namespace HOAWinApp.UserControls
{
    partial class Home
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
            this.homeRightPanel = new System.Windows.Forms.Panel();
            this.timeDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homeRightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeRightPanel
            // 
            this.homeRightPanel.BackColor = System.Drawing.Color.Transparent;
            this.homeRightPanel.BackgroundImage = global::HOAWinApp.Properties.Resources.db3__2_2;
            this.homeRightPanel.Controls.Add(this.label1);
            this.homeRightPanel.Controls.Add(this.timeDateLabel);
            this.homeRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeRightPanel.Location = new System.Drawing.Point(0, 0);
            this.homeRightPanel.Name = "homeRightPanel";
            this.homeRightPanel.Size = new System.Drawing.Size(984, 421);
            this.homeRightPanel.TabIndex = 1;
            // 
            // timeDateLabel
            // 
            this.timeDateLabel.AutoSize = true;
            this.timeDateLabel.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDateLabel.Location = new System.Drawing.Point(204, 229);
            this.timeDateLabel.Name = "timeDateLabel";
            this.timeDateLabel.Size = new System.Drawing.Size(0, 64);
            this.timeDateLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homeRightPanel);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(984, 421);
            this.homeRightPanel.ResumeLayout(false);
            this.homeRightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel homeRightPanel;
        private System.Windows.Forms.Label timeDateLabel;
        private System.Windows.Forms.Label label1;
    }
}
