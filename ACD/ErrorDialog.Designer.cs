namespace ACD
{
    partial class ErrorDialog
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
            this.warningBox = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.errorBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // warningBox
            // 
            this.warningBox.BackColor = System.Drawing.SystemColors.Control;
            this.warningBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warningBox.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningBox.Location = new System.Drawing.Point(1, 65);
            this.warningBox.Name = "warningBox";
            this.warningBox.ReadOnly = true;
            this.warningBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.warningBox.Size = new System.Drawing.Size(416, 162);
            this.warningBox.TabIndex = 18;
            this.warningBox.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.Red;
            this.materialLabel1.Location = new System.Drawing.Point(12, 80);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(99, 25);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "ERROR:";
            // 
            // errorBox
            // 
            this.errorBox.BackColor = System.Drawing.SystemColors.Control;
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorBox.Location = new System.Drawing.Point(17, 108);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(388, 96);
            this.errorBox.TabIndex = 20;
            this.errorBox.Text = "";
            // 
            // ErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 227);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.warningBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 227);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(417, 227);
            this.Name = "ErrorDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Error";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox warningBox;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.RichTextBox errorBox;
    }
}