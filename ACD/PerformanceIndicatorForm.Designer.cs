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
            this.courseLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Depth = 0;
            this.ButtonSave.Location = new System.Drawing.Point(411, 677);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Primary = true;
            this.ButtonSave.Size = new System.Drawing.Size(130, 35);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Depth = 0;
            this.ButtonCancel.Location = new System.Drawing.Point(559, 677);
            this.ButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Primary = true;
            this.ButtonCancel.Size = new System.Drawing.Size(130, 35);
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
            this.TextFieldProgramLevel.Location = new System.Drawing.Point(13, 167);
            this.TextFieldProgramLevel.MaxLength = 32767;
            this.TextFieldProgramLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldProgramLevel.Name = "TextFieldProgramLevel";
            this.TextFieldProgramLevel.PasswordChar = '\0';
            this.TextFieldProgramLevel.SelectedText = "";
            this.TextFieldProgramLevel.SelectionLength = 0;
            this.TextFieldProgramLevel.SelectionStart = 0;
            this.TextFieldProgramLevel.Size = new System.Drawing.Size(368, 23);
            this.TextFieldProgramLevel.TabIndex = 9;
            this.TextFieldProgramLevel.TabStop = false;
            this.TextFieldProgramLevel.UseSystemPasswordChar = false;
            // 
            // TextFieldProgram
            // 
            this.TextFieldProgram.Depth = 0;
            this.TextFieldProgram.Enabled = false;
            this.TextFieldProgram.Hint = "";
            this.TextFieldProgram.Location = new System.Drawing.Point(13, 107);
            this.TextFieldProgram.MaxLength = 32767;
            this.TextFieldProgram.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldProgram.Name = "TextFieldProgram";
            this.TextFieldProgram.PasswordChar = '\0';
            this.TextFieldProgram.SelectedText = "";
            this.TextFieldProgram.SelectionLength = 0;
            this.TextFieldProgram.SelectionStart = 0;
            this.TextFieldProgram.Size = new System.Drawing.Size(368, 23);
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
            this.labelProgram.Location = new System.Drawing.Point(6, 85);
            this.labelProgram.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(66, 19);
            this.labelProgram.TabIndex = 13;
            this.labelProgram.Text = "Program";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 145);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(178, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Program Level Outcomes";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 264);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(109, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Level 1 Criteria";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 376);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(109, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Level 2 Criteria";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 487);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(109, 19);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "Level 3 Criteria";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 610);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(109, 19);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Level 4 Criteria";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 207);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Indicator name";
            // 
            // indicatorNameField
            // 
            this.indicatorNameField.Depth = 0;
            this.indicatorNameField.Hint = "";
            this.indicatorNameField.Location = new System.Drawing.Point(13, 229);
            this.indicatorNameField.MaxLength = 32767;
            this.indicatorNameField.MouseState = MaterialSkin.MouseState.HOVER;
            this.indicatorNameField.Name = "indicatorNameField";
            this.indicatorNameField.PasswordChar = '\0';
            this.indicatorNameField.SelectedText = "";
            this.indicatorNameField.SelectionLength = 0;
            this.indicatorNameField.SelectionStart = 0;
            this.indicatorNameField.Size = new System.Drawing.Size(368, 23);
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
            this.criteria1TextField.Location = new System.Drawing.Point(12, 286);
            this.criteria1TextField.Name = "criteria1TextField";
            this.criteria1TextField.Size = new System.Drawing.Size(369, 71);
            this.criteria1TextField.TabIndex = 26;
            this.criteria1TextField.Text = "";
            // 
            // criteria2TextField
            // 
            this.criteria2TextField.BackColor = System.Drawing.SystemColors.Control;
            this.criteria2TextField.Location = new System.Drawing.Point(12, 398);
            this.criteria2TextField.Name = "criteria2TextField";
            this.criteria2TextField.Size = new System.Drawing.Size(369, 71);
            this.criteria2TextField.TabIndex = 27;
            this.criteria2TextField.Text = "";
            // 
            // criteria3TextField
            // 
            this.criteria3TextField.BackColor = System.Drawing.SystemColors.Control;
            this.criteria3TextField.Location = new System.Drawing.Point(13, 520);
            this.criteria3TextField.Name = "criteria3TextField";
            this.criteria3TextField.Size = new System.Drawing.Size(369, 71);
            this.criteria3TextField.TabIndex = 28;
            this.criteria3TextField.Text = "";
            // 
            // criteria4TextField
            // 
            this.criteria4TextField.BackColor = System.Drawing.SystemColors.Control;
            this.criteria4TextField.Location = new System.Drawing.Point(13, 641);
            this.criteria4TextField.Name = "criteria4TextField";
            this.criteria4TextField.Size = new System.Drawing.Size(369, 71);
            this.criteria4TextField.TabIndex = 29;
            this.criteria4TextField.Text = "";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Depth = 0;
            this.courseLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.courseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.courseLabel.Location = new System.Drawing.Point(451, 85);
            this.courseLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(65, 19);
            this.courseLabel.TabIndex = 30;
            this.courseLabel.Text = "Courses";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(673, 85);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(13, 19);
            this.materialLabel8.TabIndex = 31;
            this.materialLabel8.Text = "I";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(692, 85);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(18, 19);
            this.materialLabel9.TabIndex = 32;
            this.materialLabel9.Text = "R";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(716, 85);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(19, 19);
            this.materialLabel10.TabIndex = 33;
            this.materialLabel10.Text = "D";
            // 
            // PerformanceIndicatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 727);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.courseLabel);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(399, 275);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel courseLabel;
    }
}