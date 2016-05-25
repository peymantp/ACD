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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelProgramName = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ButtonProgramAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.level1DescBox = new System.Windows.Forms.RichTextBox();
            this.level2DescBox = new System.Windows.Forms.RichTextBox();
            this.level3DescBox = new System.Windows.Forms.RichTextBox();
            this.level4DescBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Depth = 0;
            this.labelProgramName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelProgramName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProgramName.Location = new System.Drawing.Point(12, 94);
            this.labelProgramName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(110, 19);
            this.labelProgramName.TabIndex = 0;
            this.labelProgramName.Text = "Program Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Depth = 0;
            this.textBoxName.Hint = "";
            this.textBoxName.Location = new System.Drawing.Point(155, 94);
            this.textBoxName.MaxLength = 32767;
            this.textBoxName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.SelectedText = "";
            this.textBoxName.SelectionLength = 0;
            this.textBoxName.SelectionStart = 0;
            this.textBoxName.Size = new System.Drawing.Size(322, 23);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TabStop = false;
            this.textBoxName.UseSystemPasswordChar = false;
            // 
            // ButtonProgramAdd
            // 
            this.ButtonProgramAdd.Depth = 0;
            this.ButtonProgramAdd.Location = new System.Drawing.Point(256, 461);
            this.ButtonProgramAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonProgramAdd.Name = "ButtonProgramAdd";
            this.ButtonProgramAdd.Primary = true;
            this.ButtonProgramAdd.Size = new System.Drawing.Size(107, 34);
            this.ButtonProgramAdd.TabIndex = 2;
            this.ButtonProgramAdd.Text = "Add Program";
            this.ButtonProgramAdd.UseVisualStyleBackColor = true;
            this.ButtonProgramAdd.Click += new System.EventHandler(this.ButtonProgramAdd_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Depth = 0;
            this.ButtonCancel.Location = new System.Drawing.Point(383, 461);
            this.ButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Primary = true;
            this.ButtonCancel.Size = new System.Drawing.Size(94, 34);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 151);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(137, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Level 1 Description";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 231);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(137, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Level 2 Description";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 307);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(137, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Level 3 Description";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 390);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(137, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Level 4 Description";
            // 
            // level1DescBox
            // 
            this.level1DescBox.Location = new System.Drawing.Point(155, 138);
            this.level1DescBox.Name = "level1DescBox";
            this.level1DescBox.Size = new System.Drawing.Size(322, 49);
            this.level1DescBox.TabIndex = 8;
            this.level1DescBox.Text = "";
            // 
            // level2DescBox
            // 
            this.level2DescBox.Location = new System.Drawing.Point(155, 215);
            this.level2DescBox.Name = "level2DescBox";
            this.level2DescBox.Size = new System.Drawing.Size(322, 53);
            this.level2DescBox.TabIndex = 9;
            this.level2DescBox.Text = "";
            // 
            // level3DescBox
            // 
            this.level3DescBox.Location = new System.Drawing.Point(155, 294);
            this.level3DescBox.Name = "level3DescBox";
            this.level3DescBox.Size = new System.Drawing.Size(322, 55);
            this.level3DescBox.TabIndex = 10;
            this.level3DescBox.Text = "";
            // 
            // level4DescBox
            // 
            this.level4DescBox.Location = new System.Drawing.Point(155, 379);
            this.level4DescBox.Name = "level4DescBox";
            this.level4DescBox.Size = new System.Drawing.Size(322, 58);
            this.level4DescBox.TabIndex = 11;
            this.level4DescBox.Text = "";
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 507);
            this.Controls.Add(this.level4DescBox);
            this.Controls.Add(this.level3DescBox);
            this.Controls.Add(this.level2DescBox);
            this.Controls.Add(this.level1DescBox);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonProgramAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelProgramName);
            this.Name = "ProgramForm";
            this.Text = "ProgramForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxName;
        private MaterialSkin.Controls.MaterialLabel labelProgramName;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonCancel;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonProgramAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.RichTextBox level4DescBox;
        private System.Windows.Forms.RichTextBox level3DescBox;
        private System.Windows.Forms.RichTextBox level2DescBox;
        private System.Windows.Forms.RichTextBox level1DescBox;
    }
}