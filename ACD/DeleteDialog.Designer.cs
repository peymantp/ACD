namespace ACD
{
    partial class DeleteDialog
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
            this.warningLabel = new MaterialSkin.Controls.MaterialLabel();
            this.deleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cancelButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.warningBox = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Depth = 0;
            this.warningLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.warningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warningLabel.Location = new System.Drawing.Point(20, 124);
            this.warningLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 19);
            this.warningLabel.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.Depth = 0;
            this.deleteButton.Location = new System.Drawing.Point(170, 191);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Primary = true;
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Depth = 0;
            this.cancelButton.Location = new System.Drawing.Point(281, 191);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Primary = true;
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // warningBox
            // 
            this.warningBox.BackColor = System.Drawing.SystemColors.Control;
            this.warningBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warningBox.Location = new System.Drawing.Point(12, 114);
            this.warningBox.Name = "warningBox";
            this.warningBox.ReadOnly = true;
            this.warningBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.warningBox.Size = new System.Drawing.Size(344, 71);
            this.warningBox.TabIndex = 17;
            this.warningBox.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.Red;
            this.materialLabel1.Location = new System.Drawing.Point(12, 73);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 25);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "WARNING:";
            // 
            // DeleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 231);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.warningBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.warningLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeleteDialog";
            this.Sizable = false;
            this.Text = "DeleteDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel warningLabel;
        private MaterialSkin.Controls.MaterialRaisedButton deleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton cancelButton;
        private System.Windows.Forms.RichTextBox warningBox;
        private System.Windows.Forms.Label materialLabel1;
    }
}