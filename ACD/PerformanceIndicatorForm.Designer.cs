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
            this.ButtonSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TextFieldLearningLevel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextFieldProgram = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextFieldPerformanceIndicator = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Depth = 0;
            this.ButtonSave.Location = new System.Drawing.Point(84, 227);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Primary = true;
            this.ButtonSave.Size = new System.Drawing.Size(130, 35);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Depth = 0;
            this.ButtonCancel.Location = new System.Drawing.Point(257, 227);
            this.ButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Primary = true;
            this.ButtonCancel.Size = new System.Drawing.Size(130, 35);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TextFieldLearningLevel
            // 
            this.TextFieldLearningLevel.Depth = 0;
            this.TextFieldLearningLevel.Hint = "  Learning level";
            this.TextFieldLearningLevel.Location = new System.Drawing.Point(16, 123);
            this.TextFieldLearningLevel.MaxLength = 32767;
            this.TextFieldLearningLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldLearningLevel.Name = "TextFieldLearningLevel";
            this.TextFieldLearningLevel.PasswordChar = '\0';
            this.TextFieldLearningLevel.SelectedText = "";
            this.TextFieldLearningLevel.SelectionLength = 0;
            this.TextFieldLearningLevel.SelectionStart = 0;
            this.TextFieldLearningLevel.Size = new System.Drawing.Size(364, 23);
            this.TextFieldLearningLevel.TabIndex = 9;
            this.TextFieldLearningLevel.TabStop = false;
            this.TextFieldLearningLevel.UseSystemPasswordChar = false;
            // 
            // TextFieldProgram
            // 
            this.TextFieldProgram.Depth = 0;
            this.TextFieldProgram.Hint = "  Program";
            this.TextFieldProgram.Location = new System.Drawing.Point(16, 83);
            this.TextFieldProgram.MaxLength = 32767;
            this.TextFieldProgram.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldProgram.Name = "TextFieldProgram";
            this.TextFieldProgram.PasswordChar = '\0';
            this.TextFieldProgram.SelectedText = "";
            this.TextFieldProgram.SelectionLength = 0;
            this.TextFieldProgram.SelectionStart = 0;
            this.TextFieldProgram.Size = new System.Drawing.Size(364, 23);
            this.TextFieldProgram.TabIndex = 8;
            this.TextFieldProgram.TabStop = false;
            this.TextFieldProgram.UseSystemPasswordChar = false;
            // 
            // TextFieldPerformanceIndicator
            // 
            this.TextFieldPerformanceIndicator.Depth = 0;
            this.TextFieldPerformanceIndicator.Hint = "  Performance Indicator";
            this.TextFieldPerformanceIndicator.Location = new System.Drawing.Point(16, 169);
            this.TextFieldPerformanceIndicator.MaxLength = 32767;
            this.TextFieldPerformanceIndicator.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldPerformanceIndicator.Name = "TextFieldPerformanceIndicator";
            this.TextFieldPerformanceIndicator.PasswordChar = '\0';
            this.TextFieldPerformanceIndicator.SelectedText = "";
            this.TextFieldPerformanceIndicator.SelectionLength = 0;
            this.TextFieldPerformanceIndicator.SelectionStart = 0;
            this.TextFieldPerformanceIndicator.Size = new System.Drawing.Size(364, 23);
            this.TextFieldPerformanceIndicator.TabIndex = 12;
            this.TextFieldPerformanceIndicator.TabStop = false;
            this.TextFieldPerformanceIndicator.UseSystemPasswordChar = false;
            // 
            // PerformanceIndicatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 302);
            this.Controls.Add(this.TextFieldPerformanceIndicator);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextFieldLearningLevel);
            this.Controls.Add(this.TextFieldProgram);
            this.Name = "PerformanceIndicatorForm";
            this.Text = "PerformanceIndicatorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton ButtonSave;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldLearningLevel;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldProgram;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldPerformanceIndicator;
    }
}