namespace ID_Verification_3
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblIDNo = new System.Windows.Forms.Label();
            this.txtIDNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(432, 224);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(184, 40);
            this.btnVerify.TabIndex = 0;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblIDNo
            // 
            this.lblIDNo.AutoSize = true;
            this.lblIDNo.Location = new System.Drawing.Point(213, 122);
            this.lblIDNo.Name = "lblIDNo";
            this.lblIDNo.Size = new System.Drawing.Size(125, 20);
            this.lblIDNo.TabIndex = 1;
            this.lblIDNo.Text = "Identity Number:";
            // 
            // txtIDNo
            // 
            this.txtIDNo.Location = new System.Drawing.Point(420, 119);
            this.txtIDNo.Name = "txtIDNo";
            this.txtIDNo.Size = new System.Drawing.Size(284, 26);
            this.txtIDNo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDNo);
            this.Controls.Add(this.lblIDNo);
            this.Controls.Add(this.btnVerify);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblIDNo;
        private System.Windows.Forms.TextBox txtIDNo;
    }
}

