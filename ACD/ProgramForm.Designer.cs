namespace ACD
{
    partial class ProgramForm
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
            this.labelProgramName = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonProgramAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Depth = 0;
            this.labelProgramName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelProgramName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProgramName.Location = new System.Drawing.Point(12, 83);
            this.labelProgramName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(110, 19);
            this.labelProgramName.TabIndex = 3;
            this.labelProgramName.Text = "Program Name";
            // 
            // ButtonProgramAdd
            // 
            this.ButtonProgramAdd.Depth = 0;
            this.ButtonProgramAdd.Location = new System.Drawing.Point(214, 119);
            this.ButtonProgramAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonProgramAdd.Name = "ButtonProgramAdd";
            this.ButtonProgramAdd.Primary = true;
            this.ButtonProgramAdd.Size = new System.Drawing.Size(101, 29);
            this.ButtonProgramAdd.TabIndex = 13;
            this.ButtonProgramAdd.Text = "Add Program";
            this.ButtonProgramAdd.UseVisualStyleBackColor = true;
            this.ButtonProgramAdd.Click += new System.EventHandler(this.ButtonProgramAdd_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(335, 119);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 29);
            this.materialRaisedButton1.TabIndex = 14;
            this.materialRaisedButton1.Text = "Cancel";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(143, 79);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(268, 23);
            this.materialSingleLineTextField1.TabIndex = 15;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 162);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.ButtonProgramAdd);
            this.Controls.Add(this.labelProgramName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProgramForm";
            this.Text = "ProgramForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelProgramName;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonProgramAdd;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    }
}