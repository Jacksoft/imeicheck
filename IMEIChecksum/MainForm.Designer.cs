namespace IMEIChecksum {
    partial class MainForm {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.IMEIBox = new System.Windows.Forms.TextBox();
            this.IMEIButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IMEILabel = new System.Windows.Forms.Label();
            this.BlogLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IMEIBox
            // 
            this.IMEIBox.Location = new System.Drawing.Point(6, 19);
            this.IMEIBox.Name = "IMEIBox";
            this.IMEIBox.Size = new System.Drawing.Size(158, 20);
            this.IMEIBox.TabIndex = 0;
            // 
            // IMEIButton
            // 
            this.IMEIButton.Location = new System.Drawing.Point(170, 17);
            this.IMEIButton.Name = "IMEIButton";
            this.IMEIButton.Size = new System.Drawing.Size(75, 23);
            this.IMEIButton.TabIndex = 1;
            this.IMEIButton.Text = "Check + Fix";
            this.IMEIButton.UseVisualStyleBackColor = true;
            this.IMEIButton.Click += new System.EventHandler(this.IMEIButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IMEILabel);
            this.groupBox1.Controls.Add(this.IMEIBox);
            this.groupBox1.Controls.Add(this.IMEIButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IMEI";
            // 
            // IMEILabel
            // 
            this.IMEILabel.AutoSize = true;
            this.IMEILabel.Location = new System.Drawing.Point(6, 42);
            this.IMEILabel.Name = "IMEILabel";
            this.IMEILabel.Size = new System.Drawing.Size(0, 13);
            this.IMEILabel.TabIndex = 2;
            // 
            // BlogLinkLabel
            // 
            this.BlogLinkLabel.AutoSize = true;
            this.BlogLinkLabel.LinkColor = System.Drawing.Color.Silver;
            this.BlogLinkLabel.Location = new System.Drawing.Point(117, 81);
            this.BlogLinkLabel.Name = "BlogLinkLabel";
            this.BlogLinkLabel.Size = new System.Drawing.Size(145, 13);
            this.BlogLinkLabel.TabIndex = 3;
            this.BlogLinkLabel.TabStop = true;
            this.BlogLinkLabel.Text = "https://blog.jacksoftlabs.com";
            this.BlogLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BlogLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 99);
            this.Controls.Add(this.BlogLinkLabel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "IMEI Checksum Fix";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IMEIBox;
        private System.Windows.Forms.Button IMEIButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label IMEILabel;
        private System.Windows.Forms.LinkLabel BlogLinkLabel;
    }
}

