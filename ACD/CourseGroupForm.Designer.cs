namespace ACD
{
    partial class CourseGroupForm
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
            this.labelProgram = new MaterialSkin.Controls.MaterialLabel();
            this.labelGroup = new MaterialSkin.Controls.MaterialLabel();
            this.programNameField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.courseGroupNameField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ButtonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.acceptButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelElectives = new MaterialSkin.Controls.MaterialLabel();
            this.electiveField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Depth = 0;
            this.labelProgram.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProgram.Location = new System.Drawing.Point(16, 102);
            this.labelProgram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgram.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(83, 24);
            this.labelProgram.TabIndex = 0;
            this.labelProgram.Text = "Program";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Depth = 0;
            this.labelGroup.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelGroup.Location = new System.Drawing.Point(13, 179);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(125, 24);
            this.labelGroup.TabIndex = 1;
            this.labelGroup.Text = "Course Group";
            // 
            // programNameField
            // 
            this.programNameField.Depth = 0;
            this.programNameField.Enabled = false;
            this.programNameField.Hint = "";
            this.programNameField.Location = new System.Drawing.Point(13, 130);
            this.programNameField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.programNameField.MaxLength = 32767;
            this.programNameField.MouseState = MaterialSkin.MouseState.HOVER;
            this.programNameField.Name = "programNameField";
            this.programNameField.PasswordChar = '\0';
            this.programNameField.SelectedText = "";
            this.programNameField.SelectionLength = 0;
            this.programNameField.SelectionStart = 0;
            this.programNameField.Size = new System.Drawing.Size(395, 28);
            this.programNameField.TabIndex = 2;
            this.programNameField.TabStop = false;
            this.programNameField.UseSystemPasswordChar = false;
            // 
            // courseGroupNameField
            // 
            this.courseGroupNameField.Depth = 0;
            this.courseGroupNameField.Hint = "";
            this.courseGroupNameField.Location = new System.Drawing.Point(13, 207);
            this.courseGroupNameField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseGroupNameField.MaxLength = 32767;
            this.courseGroupNameField.MouseState = MaterialSkin.MouseState.HOVER;
            this.courseGroupNameField.Name = "courseGroupNameField";
            this.courseGroupNameField.PasswordChar = '\0';
            this.courseGroupNameField.SelectedText = "";
            this.courseGroupNameField.SelectionLength = 0;
            this.courseGroupNameField.SelectionStart = 0;
            this.courseGroupNameField.Size = new System.Drawing.Size(395, 28);
            this.courseGroupNameField.TabIndex = 3;
            this.courseGroupNameField.TabStop = false;
            this.courseGroupNameField.UseSystemPasswordChar = false;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Depth = 0;
            this.ButtonCancel.Location = new System.Drawing.Point(242, 338);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Primary = true;
            this.ButtonCancel.Size = new System.Drawing.Size(173, 43);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Depth = 0;
            this.acceptButton.Location = new System.Drawing.Point(20, 338);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Primary = true;
            this.acceptButton.Size = new System.Drawing.Size(173, 43);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Add";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // labelElectives
            // 
            this.labelElectives.AutoSize = true;
            this.labelElectives.Depth = 0;
            this.labelElectives.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelElectives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelElectives.Location = new System.Drawing.Point(16, 254);
            this.labelElectives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelElectives.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelElectives.Name = "labelElectives";
            this.labelElectives.Size = new System.Drawing.Size(182, 24);
            this.labelElectives.TabIndex = 6;
            this.labelElectives.Text = "Number of Electives";
            // 
            // electiveField
            // 
            this.electiveField.Depth = 0;
            this.electiveField.Hint = "";
            this.electiveField.Location = new System.Drawing.Point(17, 282);
            this.electiveField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.electiveField.MaxLength = 32767;
            this.electiveField.MouseState = MaterialSkin.MouseState.HOVER;
            this.electiveField.Name = "electiveField";
            this.electiveField.PasswordChar = '\0';
            this.electiveField.SelectedText = "";
            this.electiveField.SelectionLength = 0;
            this.electiveField.SelectionStart = 0;
            this.electiveField.Size = new System.Drawing.Size(395, 28);
            this.electiveField.TabIndex = 7;
            this.electiveField.TabStop = false;
            this.electiveField.Text = "0";
            this.electiveField.UseSystemPasswordChar = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CourseGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 412);
            this.Controls.Add(this.electiveField);
            this.Controls.Add(this.labelElectives);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.courseGroupNameField);
            this.Controls.Add(this.programNameField);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelProgram);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 412);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(448, 412);
            this.Name = "CourseGroupForm";
            this.ShowInTaskbar = false;
            this.Text = "Course Group";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelProgram;
        private MaterialSkin.Controls.MaterialLabel labelGroup;
        private MaterialSkin.Controls.MaterialSingleLineTextField programNameField;
        private MaterialSkin.Controls.MaterialSingleLineTextField courseGroupNameField;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonCancel;
        private MaterialSkin.Controls.MaterialRaisedButton acceptButton;
        private MaterialSkin.Controls.MaterialLabel labelElectives;
        private MaterialSkin.Controls.MaterialSingleLineTextField electiveField;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}