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
            this.labelNumber = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelCore = new MaterialSkin.Controls.MaterialLabel();
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.labelDesc = new MaterialSkin.Controls.MaterialLabel();
            this.labelCredHr = new MaterialSkin.Controls.MaterialLabel();
            this.labelFormat = new MaterialSkin.Controls.MaterialLabel();
            this.labelPrereq = new MaterialSkin.Controls.MaterialLabel();
            this.panelPrereq = new System.Windows.Forms.Panel();
            this.buttonCreate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelhasLab = new MaterialSkin.Controls.MaterialLabel();
            this.checkBoxHasLab = new System.Windows.Forms.CheckBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Depth = 0;
            this.labelNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNumber.Location = new System.Drawing.Point(35, 156);
            this.labelNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(62, 19);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Number";
            // 
            // textBoxName
            // 
            this.textBoxName.Depth = 0;
            this.textBoxName.Hint = "";
            this.textBoxName.Location = new System.Drawing.Point(116, 72);
            this.textBoxName.MaxLength = 32767;
            this.textBoxName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.SelectedText = "";
            this.textBoxName.SelectionLength = 0;
            this.textBoxName.SelectionStart = 0;
            this.textBoxName.Size = new System.Drawing.Size(273, 23);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TabStop = false;
            this.textBoxName.UseSystemPasswordChar = false;
            // 
            // labelCore
            // 
            this.labelCore.AutoSize = true;
            this.labelCore.Depth = 0;
            this.labelCore.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCore.Location = new System.Drawing.Point(50, 117);
            this.labelCore.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCore.Name = "labelCore";
            this.labelCore.Size = new System.Drawing.Size(41, 19);
            this.labelCore.TabIndex = 2;
            this.labelCore.Text = "Core";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Depth = 0;
            this.labelName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(42, 72);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 19);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Depth = 0;
            this.labelDesc.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDesc.Location = new System.Drawing.Point(12, 204);
            this.labelDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(86, 19);
            this.labelDesc.TabIndex = 6;
            this.labelDesc.Text = "Description";
            // 
            // labelCredHr
            // 
            this.labelCredHr.AutoSize = true;
            this.labelCredHr.Depth = 0;
            this.labelCredHr.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCredHr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCredHr.Location = new System.Drawing.Point(6, 265);
            this.labelCredHr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCredHr.Name = "labelCredHr";
            this.labelCredHr.Size = new System.Drawing.Size(91, 19);
            this.labelCredHr.TabIndex = 8;
            this.labelCredHr.Text = "Credit hours";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Depth = 0;
            this.labelFormat.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFormat.Location = new System.Drawing.Point(40, 309);
            this.labelFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(57, 19);
            this.labelFormat.TabIndex = 10;
            this.labelFormat.Text = "Format";
            // 
            // labelPrereq
            // 
            this.labelPrereq.AutoSize = true;
            this.labelPrereq.Depth = 0;
            this.labelPrereq.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPrereq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPrereq.Location = new System.Drawing.Point(5, 422);
            this.labelPrereq.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPrereq.Name = "labelPrereq";
            this.labelPrereq.Size = new System.Drawing.Size(98, 19);
            this.labelPrereq.TabIndex = 12;
            this.labelPrereq.Text = "Prerequisites";
            // 
            // panelPrereq
            // 
            this.panelPrereq.AutoScroll = true;
            this.panelPrereq.Location = new System.Drawing.Point(119, 385);
            this.panelPrereq.Name = "panelPrereq";
            this.panelPrereq.Size = new System.Drawing.Size(270, 118);
            this.panelPrereq.TabIndex = 13;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Depth = 0;
            this.buttonCreate.Location = new System.Drawing.Point(119, 519);
            this.buttonCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Primary = true;
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Depth = 0;
            this.buttonCancel.Location = new System.Drawing.Point(314, 519);
            this.buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Primary = true;
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
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
            this.labelhasLab.Location = new System.Drawing.Point(37, 348);
            this.labelhasLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelhasLab.Name = "labelhasLab";
            this.labelhasLab.Size = new System.Drawing.Size(60, 19);
            this.labelhasLab.TabIndex = 16;
            this.labelhasLab.Text = "Has lab";
            // 
            // checkBoxHasLab
            // 
            this.checkBoxHasLab.AutoSize = true;
            this.checkBoxHasLab.Location = new System.Drawing.Point(119, 353);
            this.checkBoxHasLab.Name = "checkBoxHasLab";
            this.checkBoxHasLab.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHasLab.TabIndex = 17;
            this.checkBoxHasLab.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(116, 113);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(273, 23);
            this.materialSingleLineTextField1.TabIndex = 18;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(116, 152);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(273, 23);
            this.materialSingleLineTextField2.TabIndex = 19;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(118, 309);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(271, 23);
            this.materialSingleLineTextField3.TabIndex = 20;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(119, 265);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(270, 23);
            this.materialSingleLineTextField4.TabIndex = 21;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(116, 204);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 43);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 554);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.materialSingleLineTextField4);
            this.Controls.Add(this.materialSingleLineTextField3);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.checkBoxHasLab);
            this.Controls.Add(this.labelhasLab);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.panelPrereq);
            this.Controls.Add(this.labelPrereq);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.labelCredHr);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCore);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNumber);
            this.Name = "CourseForm";
            this.Text = "Course";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialLabel labelNumber;
        private MaterialSingleLineTextField textBoxName;
        private MaterialLabel labelCore;
        private MaterialLabel labelName;
        private MaterialLabel labelDesc;
        private MaterialLabel labelCredHr;
        private MaterialLabel labelFormat;
        private MaterialLabel labelPrereq;
        private System.Windows.Forms.Panel panelPrereq;
        private MaterialRaisedButton buttonCreate;
        private MaterialRaisedButton buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBoxHasLab;
        private MaterialLabel labelhasLab;
        private MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}