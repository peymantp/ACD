namespace ACD
{
    partial class PerformanceIndicatorForm
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
            this.ButtonSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TextFieldProgramLevel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextFieldProgram = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelProgram = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.indicatorNameField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.criteria1TextField = new System.Windows.Forms.RichTextBox();
            this.criteria2TextField = new System.Windows.Forms.RichTextBox();
            this.criteria3TextField = new System.Windows.Forms.RichTextBox();
            this.criteria4TextField = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Depth = 0;
            this.ButtonSave.Location = new System.Drawing.Point(118, 802);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Primary = true;
            this.ButtonSave.Size = new System.Drawing.Size(173, 43);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Depth = 0;
            this.ButtonCancel.Location = new System.Drawing.Point(327, 802);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Primary = true;
            this.ButtonCancel.Size = new System.Drawing.Size(173, 43);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TextFieldProgramLevel
            // 
            this.TextFieldProgramLevel.Depth = 0;
            this.TextFieldProgramLevel.Enabled = false;
            this.TextFieldProgramLevel.Hint = "";
            this.TextFieldProgramLevel.Location = new System.Drawing.Point(7, 176);
            this.TextFieldProgramLevel.Margin = new System.Windows.Forms.Padding(4);
            this.TextFieldProgramLevel.MaxLength = 32767;
            this.TextFieldProgramLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldProgramLevel.Name = "TextFieldProgramLevel";
            this.TextFieldProgramLevel.PasswordChar = '\0';
            this.TextFieldProgramLevel.SelectedText = "";
            this.TextFieldProgramLevel.SelectionLength = 0;
            this.TextFieldProgramLevel.SelectionStart = 0;
            this.TextFieldProgramLevel.Size = new System.Drawing.Size(491, 28);
            this.TextFieldProgramLevel.TabIndex = 9;
            this.TextFieldProgramLevel.TabStop = false;
            this.TextFieldProgramLevel.UseSystemPasswordChar = false;
            // 
            // TextFieldProgram
            // 
            this.TextFieldProgram.Depth = 0;
            this.TextFieldProgram.Enabled = false;
            this.TextFieldProgram.Hint = "";
            this.TextFieldProgram.Location = new System.Drawing.Point(7, 105);
            this.TextFieldProgram.Margin = new System.Windows.Forms.Padding(4);
            this.TextFieldProgram.MaxLength = 32767;
            this.TextFieldProgram.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldProgram.Name = "TextFieldProgram";
            this.TextFieldProgram.PasswordChar = '\0';
            this.TextFieldProgram.SelectedText = "";
            this.TextFieldProgram.SelectionLength = 0;
            this.TextFieldProgram.SelectionStart = 0;
            this.TextFieldProgram.Size = new System.Drawing.Size(491, 28);
            this.TextFieldProgram.TabIndex = 8;
            this.TextFieldProgram.TabStop = false;
            this.TextFieldProgram.UseSystemPasswordChar = false;
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Depth = 0;
            this.labelProgram.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProgram.Location = new System.Drawing.Point(8, 77);
            this.labelProgram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgram.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(83, 24);
            this.labelProgram.TabIndex = 13;
            this.labelProgram.Text = "Program";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 148);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(224, 24);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Program Level Outcomes";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 294);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(135, 24);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Level 1 Criteria";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 421);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(135, 24);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Level 2 Criteria";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(8, 549);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(135, 24);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "Level 3 Criteria";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(8, 667);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(135, 24);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Level 4 Criteria";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 221);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 24);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Indicator name";
            // 
            // indicatorNameField
            // 
            this.indicatorNameField.Depth = 0;
            this.indicatorNameField.Hint = "";
            this.indicatorNameField.Location = new System.Drawing.Point(7, 249);
            this.indicatorNameField.Margin = new System.Windows.Forms.Padding(4);
            this.indicatorNameField.MaxLength = 32767;
            this.indicatorNameField.MouseState = MaterialSkin.MouseState.HOVER;
            this.indicatorNameField.Name = "indicatorNameField";
            this.indicatorNameField.PasswordChar = '\0';
            this.indicatorNameField.SelectedText = "";
            this.indicatorNameField.SelectionLength = 0;
            this.indicatorNameField.SelectionStart = 0;
            this.indicatorNameField.Size = new System.Drawing.Size(491, 28);
            this.indicatorNameField.TabIndex = 25;
            this.indicatorNameField.TabStop = false;
            this.indicatorNameField.UseSystemPasswordChar = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // criteria1TextField
            // 
            this.criteria1TextField.BackColor = System.Drawing.SystemColors.Control;
            this.criteria1TextField.Location = new System.Drawing.Point(7, 322);
            this.criteria1TextField.Margin = new System.Windows.Forms.Padding(4);
            this.criteria1TextField.Name = "criteria1TextField";
            this.criteria1TextField.Size = new System.Drawing.Size(491, 86);
            this.criteria1TextField.TabIndex = 26;
            this.criteria1TextField.Text = "";
            // 
            // criteria2TextField
            // 
            this.criteria2TextField.BackColor = System.Drawing.SystemColors.Control;
            this.criteria2TextField.Location = new System.Drawing.Point(7, 449);
            this.criteria2TextField.Margin = new System.Windows.Forms.Padding(4);
            this.criteria2TextField.Name = "criteria2TextField";
            this.criteria2TextField.Size = new System.Drawing.Size(491, 86);
            this.criteria2TextField.TabIndex = 27;
            this.criteria2TextField.Text = "";
            // 
            // criteria3TextField
            // 
            this.criteria3TextField.BackColor = System.Drawing.SystemColors.Control;
            this.criteria3TextField.Location = new System.Drawing.Point(7, 577);
            this.criteria3TextField.Margin = new System.Windows.Forms.Padding(4);
            this.criteria3TextField.Name = "criteria3TextField";
            this.criteria3TextField.Size = new System.Drawing.Size(491, 86);
            this.criteria3TextField.TabIndex = 28;
            this.criteria3TextField.Text = "";
            // 
            // criteria4TextField
            // 
            this.criteria4TextField.BackColor = System.Drawing.SystemColors.Control;
            this.criteria4TextField.Location = new System.Drawing.Point(7, 695);
            this.criteria4TextField.Margin = new System.Windows.Forms.Padding(4);
            this.criteria4TextField.Name = "criteria4TextField";
            this.criteria4TextField.Size = new System.Drawing.Size(491, 86);
            this.criteria4TextField.TabIndex = 29;
            this.criteria4TextField.Text = "";
            // 
            // PerformanceIndicatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 858);
            this.Controls.Add(this.criteria4TextField);
            this.Controls.Add(this.criteria3TextField);
            this.Controls.Add(this.criteria2TextField);
            this.Controls.Add(this.criteria1TextField);
            this.Controls.Add(this.indicatorNameField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.labelProgram);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextFieldProgramLevel);
            this.Controls.Add(this.TextFieldProgram);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(532, 338);
            this.Name = "PerformanceIndicatorForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PerformanceIndicatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton ButtonSave;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldProgramLevel;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldProgram;
        private MaterialSkin.Controls.MaterialLabel labelProgram;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField indicatorNameField;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RichTextBox criteria1TextField;
        private System.Windows.Forms.RichTextBox criteria2TextField;
        private System.Windows.Forms.RichTextBox criteria3TextField;
        private System.Windows.Forms.RichTextBox criteria4TextField;
    }
}