using MaterialSkin.Controls;

namespace ACD
{
    partial class CourseForm
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
            this.textBoxProgramName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelCourseGroup = new MaterialSkin.Controls.MaterialLabel();
            this.labelProgram = new MaterialSkin.Controls.MaterialLabel();
            this.labelDesc = new MaterialSkin.Controls.MaterialLabel();
            this.labelCredHr = new MaterialSkin.Controls.MaterialLabel();
            this.labelFormat = new MaterialSkin.Controls.MaterialLabel();
            this.buttonCreate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelhasLab = new MaterialSkin.Controls.MaterialLabel();
            this.checkBoxHasLab = new System.Windows.Forms.CheckBox();
            this.textBoxCourseGroup = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxFormat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxCreditHours = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxCourseName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.courseLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelD = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelR = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelI = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProgramName
            // 
            this.textBoxProgramName.Depth = 0;
            this.textBoxProgramName.Hint = "";
            this.textBoxProgramName.Location = new System.Drawing.Point(28, 116);
            this.textBoxProgramName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProgramName.MaxLength = 32767;
            this.textBoxProgramName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxProgramName.Name = "textBoxProgramName";
            this.textBoxProgramName.PasswordChar = '\0';
            this.textBoxProgramName.SelectedText = "";
            this.textBoxProgramName.SelectionLength = 0;
            this.textBoxProgramName.SelectionStart = 0;
            this.textBoxProgramName.Size = new System.Drawing.Size(365, 28);
            this.textBoxProgramName.TabIndex = 1;
            this.textBoxProgramName.TabStop = false;
            this.textBoxProgramName.UseSystemPasswordChar = false;
            // 
            // labelCourseGroup
            // 
            this.labelCourseGroup.AutoSize = true;
            this.labelCourseGroup.Depth = 0;
            this.labelCourseGroup.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCourseGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCourseGroup.Location = new System.Drawing.Point(28, 161);
            this.labelCourseGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCourseGroup.Name = "labelCourseGroup";
            this.labelCourseGroup.Size = new System.Drawing.Size(125, 24);
            this.labelCourseGroup.TabIndex = 2;
            this.labelCourseGroup.Text = "Course Group";
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Depth = 0;
            this.labelProgram.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProgram.Location = new System.Drawing.Point(23, 89);
            this.labelProgram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgram.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(83, 24);
            this.labelProgram.TabIndex = 4;
            this.labelProgram.Text = "Program";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Depth = 0;
            this.labelDesc.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDesc.Location = new System.Drawing.Point(28, 311);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(106, 24);
            this.labelDesc.TabIndex = 6;
            this.labelDesc.Text = "Description";
            // 
            // labelCredHr
            // 
            this.labelCredHr.AutoSize = true;
            this.labelCredHr.Depth = 0;
            this.labelCredHr.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCredHr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCredHr.Location = new System.Drawing.Point(28, 410);
            this.labelCredHr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCredHr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCredHr.Name = "labelCredHr";
            this.labelCredHr.Size = new System.Drawing.Size(112, 24);
            this.labelCredHr.TabIndex = 8;
            this.labelCredHr.Text = "Credit hours";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Depth = 0;
            this.labelFormat.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFormat.Location = new System.Drawing.Point(28, 484);
            this.labelFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(71, 24);
            this.labelFormat.TabIndex = 10;
            this.labelFormat.Text = "Format";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Depth = 0;
            this.buttonCreate.Location = new System.Drawing.Point(157, 633);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Primary = true;
            this.buttonCreate.Size = new System.Drawing.Size(100, 28);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Depth = 0;
            this.buttonCancel.Location = new System.Drawing.Point(289, 633);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Primary = true;
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // labelhasLab
            // 
            this.labelhasLab.AutoSize = true;
            this.labelhasLab.Depth = 0;
            this.labelhasLab.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelhasLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelhasLab.Location = new System.Drawing.Point(28, 566);
            this.labelhasLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelhasLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelhasLab.Name = "labelhasLab";
            this.labelhasLab.Size = new System.Drawing.Size(75, 24);
            this.labelhasLab.TabIndex = 16;
            this.labelhasLab.Text = "Has lab";
            // 
            // checkBoxHasLab
            // 
            this.checkBoxHasLab.AutoSize = true;
            this.checkBoxHasLab.Location = new System.Drawing.Point(157, 572);
            this.checkBoxHasLab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxHasLab.Name = "checkBoxHasLab";
            this.checkBoxHasLab.Size = new System.Drawing.Size(18, 17);
            this.checkBoxHasLab.TabIndex = 17;
            this.checkBoxHasLab.UseVisualStyleBackColor = true;
            // 
            // textBoxCourseGroup
            // 
            this.textBoxCourseGroup.Depth = 0;
            this.textBoxCourseGroup.Hint = "";
            this.textBoxCourseGroup.Location = new System.Drawing.Point(28, 188);
            this.textBoxCourseGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCourseGroup.MaxLength = 32767;
            this.textBoxCourseGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxCourseGroup.Name = "textBoxCourseGroup";
            this.textBoxCourseGroup.PasswordChar = '\0';
            this.textBoxCourseGroup.SelectedText = "";
            this.textBoxCourseGroup.SelectionLength = 0;
            this.textBoxCourseGroup.SelectionStart = 0;
            this.textBoxCourseGroup.Size = new System.Drawing.Size(369, 28);
            this.textBoxCourseGroup.TabIndex = 18;
            this.textBoxCourseGroup.TabStop = false;
            this.textBoxCourseGroup.UseSystemPasswordChar = false;
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Depth = 0;
            this.textBoxFormat.Hint = "";
            this.textBoxFormat.Location = new System.Drawing.Point(28, 511);
            this.textBoxFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFormat.MaxLength = 32767;
            this.textBoxFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.PasswordChar = '\0';
            this.textBoxFormat.SelectedText = "";
            this.textBoxFormat.SelectionLength = 0;
            this.textBoxFormat.SelectionStart = 0;
            this.textBoxFormat.Size = new System.Drawing.Size(361, 28);
            this.textBoxFormat.TabIndex = 20;
            this.textBoxFormat.TabStop = false;
            this.textBoxFormat.UseSystemPasswordChar = false;
            // 
            // textBoxCreditHours
            // 
            this.textBoxCreditHours.Depth = 0;
            this.textBoxCreditHours.Hint = "";
            this.textBoxCreditHours.Location = new System.Drawing.Point(29, 438);
            this.textBoxCreditHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCreditHours.MaxLength = 32767;
            this.textBoxCreditHours.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxCreditHours.Name = "textBoxCreditHours";
            this.textBoxCreditHours.PasswordChar = '\0';
            this.textBoxCreditHours.SelectedText = "";
            this.textBoxCreditHours.SelectionLength = 0;
            this.textBoxCreditHours.SelectionStart = 0;
            this.textBoxCreditHours.Size = new System.Drawing.Size(360, 28);
            this.textBoxCreditHours.TabIndex = 21;
            this.textBoxCreditHours.TabStop = false;
            this.textBoxCreditHours.UseSystemPasswordChar = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Location = new System.Drawing.Point(29, 338);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(360, 53);
            this.textBoxDescription.TabIndex = 22;
            this.textBoxDescription.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 238);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 24);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Course Name";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Depth = 0;
            this.textBoxCourseName.Hint = "";
            this.textBoxCourseName.Location = new System.Drawing.Point(28, 263);
            this.textBoxCourseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCourseName.MaxLength = 32767;
            this.textBoxCourseName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.PasswordChar = '\0';
            this.textBoxCourseName.SelectedText = "";
            this.textBoxCourseName.SelectionLength = 0;
            this.textBoxCourseName.SelectionStart = 0;
            this.textBoxCourseName.Size = new System.Drawing.Size(365, 28);
            this.textBoxCourseName.TabIndex = 23;
            this.textBoxCourseName.TabStop = false;
            this.textBoxCourseName.UseSystemPasswordChar = false;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Depth = 0;
            this.courseLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.courseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.courseLabel.Location = new System.Drawing.Point(419, 89);
            this.courseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(158, 24);
            this.courseLabel.TabIndex = 25;
            this.courseLabel.Text = "Course Indicators";
            // 
            // materialLabelD
            // 
            this.materialLabelD.AutoSize = true;
            this.materialLabelD.Depth = 0;
            this.materialLabelD.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelD.Location = new System.Drawing.Point(774, 89);
            this.materialLabelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabelD.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelD.Name = "materialLabelD";
            this.materialLabelD.Size = new System.Drawing.Size(22, 24);
            this.materialLabelD.TabIndex = 26;
            this.materialLabelD.Text = "D";
            // 
            // materialLabelR
            // 
            this.materialLabelR.AutoSize = true;
            this.materialLabelR.Depth = 0;
            this.materialLabelR.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelR.Location = new System.Drawing.Point(744, 89);
            this.materialLabelR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabelR.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelR.Name = "materialLabelR";
            this.materialLabelR.Size = new System.Drawing.Size(22, 24);
            this.materialLabelR.TabIndex = 27;
            this.materialLabelR.Text = "R";
            // 
            // materialLabelI
            // 
            this.materialLabelI.AutoSize = true;
            this.materialLabelI.Depth = 0;
            this.materialLabelI.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelI.Location = new System.Drawing.Point(711, 89);
            this.materialLabelI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabelI.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelI.Name = "materialLabelI";
            this.materialLabelI.Size = new System.Drawing.Size(15, 24);
            this.materialLabelI.TabIndex = 28;
            this.materialLabelI.Text = "I";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(834, 688);
            this.Controls.Add(this.materialLabelI);
            this.Controls.Add(this.materialLabelR);
            this.Controls.Add(this.materialLabelD);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCreditHours);
            this.Controls.Add(this.textBoxFormat);
            this.Controls.Add(this.textBoxCourseGroup);
            this.Controls.Add(this.checkBoxHasLab);
            this.Controls.Add(this.labelhasLab);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.labelCredHr);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelProgram);
            this.Controls.Add(this.labelCourseGroup);
            this.Controls.Add(this.textBoxProgramName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CourseForm";
            this.Text = "Course";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSingleLineTextField textBoxProgramName;
        private MaterialLabel labelCourseGroup;
        private MaterialLabel labelProgram;
        private MaterialLabel labelDesc;
        private MaterialLabel labelCredHr;
        private MaterialLabel labelFormat;
        private MaterialRaisedButton buttonCreate;
        private MaterialRaisedButton buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBoxHasLab;
        private MaterialLabel labelhasLab;
        private MaterialSingleLineTextField textBoxCreditHours;
        private MaterialSingleLineTextField textBoxFormat;
        private MaterialSingleLineTextField textBoxCourseGroup;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private MaterialLabel courseLabel;
        private MaterialLabel materialLabel1;
        private MaterialSingleLineTextField textBoxCourseName;
        private MaterialLabel materialLabelI;
        private MaterialLabel materialLabelR;
        private MaterialLabel materialLabelD;
    }
}