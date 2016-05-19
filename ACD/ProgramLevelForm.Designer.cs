namespace ACD
{
    partial class ProgramLevelForm
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
            this.components = new System.ComponentModel.Container();
            this.programNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.outcomeNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.descriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.acceptButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.programNameField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.outcomeNameField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.cancelButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Depth = 0;
            this.programNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.programNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.programNameLabel.Location = new System.Drawing.Point(16, 96);
            this.programNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.programNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(83, 24);
            this.programNameLabel.TabIndex = 9;
            this.programNameLabel.Text = "Program";
            // 
            // outcomeNameLabel
            // 
            this.outcomeNameLabel.AutoSize = true;
            this.outcomeNameLabel.Depth = 0;
            this.outcomeNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.outcomeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outcomeNameLabel.Location = new System.Drawing.Point(16, 169);
            this.outcomeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outcomeNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.outcomeNameLabel.Name = "outcomeNameLabel";
            this.outcomeNameLabel.Size = new System.Drawing.Size(143, 24);
            this.outcomeNameLabel.TabIndex = 10;
            this.outcomeNameLabel.Text = "Outcome Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Depth = 0;
            this.descriptionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriptionLabel.Location = new System.Drawing.Point(16, 244);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(106, 24);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description";
            // 
            // acceptButton
            // 
            this.acceptButton.Depth = 0;
            this.acceptButton.Location = new System.Drawing.Point(118, 462);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Primary = true;
            this.acceptButton.Size = new System.Drawing.Size(100, 41);
            this.acceptButton.TabIndex = 13;
            this.acceptButton.Text = "Add";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // programNameField
            // 
            this.programNameField.Depth = 0;
            this.programNameField.Enabled = false;
            this.programNameField.Hint = "";
            this.programNameField.Location = new System.Drawing.Point(13, 124);
            this.programNameField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.programNameField.MaxLength = 32767;
            this.programNameField.MouseState = MaterialSkin.MouseState.HOVER;
            this.programNameField.Name = "programNameField";
            this.programNameField.PasswordChar = '\0';
            this.programNameField.SelectedText = "";
            this.programNameField.SelectionLength = 0;
            this.programNameField.SelectionStart = 0;
            this.programNameField.Size = new System.Drawing.Size(361, 28);
            this.programNameField.TabIndex = 14;
            this.programNameField.TabStop = false;
            this.programNameField.UseSystemPasswordChar = false;
            // 
            // outcomeNameField
            // 
            this.outcomeNameField.Depth = 0;
            this.outcomeNameField.Hint = "";
            this.outcomeNameField.Location = new System.Drawing.Point(13, 197);
            this.outcomeNameField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outcomeNameField.MaxLength = 32767;
            this.outcomeNameField.MouseState = MaterialSkin.MouseState.HOVER;
            this.outcomeNameField.Name = "outcomeNameField";
            this.outcomeNameField.PasswordChar = '\0';
            this.outcomeNameField.SelectedText = "";
            this.outcomeNameField.SelectionLength = 0;
            this.outcomeNameField.SelectionStart = 0;
            this.outcomeNameField.Size = new System.Drawing.Size(361, 28);
            this.outcomeNameField.TabIndex = 15;
            this.outcomeNameField.TabStop = false;
            this.outcomeNameField.UseSystemPasswordChar = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionTextBox.Location = new System.Drawing.Point(13, 272);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(361, 168);
            this.descriptionTextBox.TabIndex = 18;
            this.descriptionTextBox.Text = "";
            // 
            // cancelButton
            // 
            this.cancelButton.Depth = 0;
            this.cancelButton.Location = new System.Drawing.Point(276, 462);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Primary = true;
            this.cancelButton.Size = new System.Drawing.Size(100, 41);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProgramLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 518);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.outcomeNameField);
            this.Controls.Add(this.programNameField);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.outcomeNameLabel);
            this.Controls.Add(this.programNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 518);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(399, 518);
            this.Name = "ProgramLevelForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Program Level Outcome";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel programNameLabel;
        private MaterialSkin.Controls.MaterialLabel outcomeNameLabel;
        private MaterialSkin.Controls.MaterialLabel descriptionLabel;
        private MaterialSkin.Controls.MaterialRaisedButton acceptButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField programNameField;
        private MaterialSkin.Controls.MaterialSingleLineTextField outcomeNameField;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}