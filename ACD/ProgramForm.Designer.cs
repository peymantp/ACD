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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.ButtonProgramAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Depth = 0;
            this.labelProgramName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelProgramName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProgramName.Location = new System.Drawing.Point(36, 97);
            this.labelProgramName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgramName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(139, 24);
            this.labelProgramName.TabIndex = 3;
            this.labelProgramName.Text = "Program Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(203, 98);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(192, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // ButtonProgramAdd
            // 
            this.ButtonProgramAdd.Depth = 0;
            this.ButtonProgramAdd.Location = new System.Drawing.Point(40, 154);
            this.ButtonProgramAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonProgramAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonProgramAdd.Name = "ButtonProgramAdd";
            this.ButtonProgramAdd.Primary = true;
            this.ButtonProgramAdd.Size = new System.Drawing.Size(135, 28);
            this.ButtonProgramAdd.TabIndex = 13;
            this.ButtonProgramAdd.Text = "Add Program";
            this.ButtonProgramAdd.UseVisualStyleBackColor = true;
            this.ButtonProgramAdd.Click += new System.EventHandler(this.ButtonProgramAdd_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(295, 154);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(100, 28);
            this.materialRaisedButton1.TabIndex = 14;
            this.materialRaisedButton1.Text = "Cancel";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 228);
            this.Controls.Add(this.materialRaisedButton1);
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

        private MaterialSkin.Controls.MaterialLabel labelProgramName;
        private System.Windows.Forms.TextBox textBoxName;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonProgramAdd;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}