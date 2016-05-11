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
            this.textBoxCore = new System.Windows.Forms.TextBox();
            this.labelCore = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDesc = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxCredHr = new System.Windows.Forms.TextBox();
            this.labelCredHr = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.labelFormat = new MaterialSkin.Controls.MaterialLabel();
            this.labelPrereq = new MaterialSkin.Controls.MaterialLabel();
            this.panelPrereq = new System.Windows.Forms.Panel();
            this.buttonCreate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelhasLab = new MaterialSkin.Controls.MaterialLabel();
            this.checkBoxHasLab = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Depth = 0;
            this.labelNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNumber.Location = new System.Drawing.Point(37, 131);
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
            this.textBoxName.Location = new System.Drawing.Point(107, 68);
            this.textBoxName.MaxLength = 32767;
            this.textBoxName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.SelectedText = "";
            this.textBoxName.SelectionLength = 0;
            this.textBoxName.SelectionStart = 0;
            this.textBoxName.Size = new System.Drawing.Size(269, 23);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TabStop = false;
            this.textBoxName.UseSystemPasswordChar = false;
            // 
            // textBoxCore
            // 
            this.textBoxCore.Location = new System.Drawing.Point(107, 104);
            this.textBoxCore.Name = "textBoxCore";
            this.textBoxCore.Size = new System.Drawing.Size(270, 20);
            this.textBoxCore.TabIndex = 3;
            // 
            // labelCore
            // 
            this.labelCore.AutoSize = true;
            this.labelCore.Depth = 0;
            this.labelCore.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCore.Location = new System.Drawing.Point(58, 103);
            this.labelCore.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCore.Name = "labelCore";
            this.labelCore.Size = new System.Drawing.Size(41, 19);
            this.labelCore.TabIndex = 2;
            this.labelCore.Text = "Core";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(107, 130);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(270, 20);
            this.textBoxNumber.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Depth = 0;
            this.labelName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(50, 72);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 19);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(107, 156);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(270, 56);
            this.textBoxDesc.TabIndex = 7;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Depth = 0;
            this.labelDesc.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDesc.Location = new System.Drawing.Point(15, 173);
            this.labelDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(86, 19);
            this.labelDesc.TabIndex = 6;
            this.labelDesc.Text = "Description";
            // 
            // textBoxCredHr
            // 
            this.textBoxCredHr.Location = new System.Drawing.Point(109, 218);
            this.textBoxCredHr.Name = "textBoxCredHr";
            this.textBoxCredHr.Size = new System.Drawing.Size(270, 20);
            this.textBoxCredHr.TabIndex = 9;
            // 
            // labelCredHr
            // 
            this.labelCredHr.AutoSize = true;
            this.labelCredHr.Depth = 0;
            this.labelCredHr.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCredHr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCredHr.Location = new System.Drawing.Point(12, 219);
            this.labelCredHr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCredHr.Name = "labelCredHr";
            this.labelCredHr.Size = new System.Drawing.Size(91, 19);
            this.labelCredHr.TabIndex = 8;
            this.labelCredHr.Text = "Credit hours";
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(108, 255);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(270, 20);
            this.textBoxFormat.TabIndex = 11;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Depth = 0;
            this.labelFormat.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFormat.Location = new System.Drawing.Point(44, 254);
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
            this.labelPrereq.Location = new System.Drawing.Point(5, 370);
            this.labelPrereq.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPrereq.Name = "labelPrereq";
            this.labelPrereq.Size = new System.Drawing.Size(98, 19);
            this.labelPrereq.TabIndex = 12;
            this.labelPrereq.Text = "Prerequisites";
            // 
            // panelPrereq
            // 
            this.panelPrereq.AutoScroll = true;
            this.panelPrereq.Location = new System.Drawing.Point(108, 326);
            this.panelPrereq.Name = "panelPrereq";
            this.panelPrereq.Size = new System.Drawing.Size(270, 118);
            this.panelPrereq.TabIndex = 13;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Depth = 0;
            this.buttonCreate.Location = new System.Drawing.Point(108, 450);
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
            this.buttonCancel.Location = new System.Drawing.Point(303, 450);
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
            this.labelhasLab.Location = new System.Drawing.Point(39, 291);
            this.labelhasLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelhasLab.Name = "labelhasLab";
            this.labelhasLab.Size = new System.Drawing.Size(60, 19);
            this.labelhasLab.TabIndex = 16;
            this.labelhasLab.Text = "Has lab";
            // 
            // checkBoxHasLab
            // 
            this.checkBoxHasLab.AutoSize = true;
            this.checkBoxHasLab.Location = new System.Drawing.Point(108, 296);
            this.checkBoxHasLab.Name = "checkBoxHasLab";
            this.checkBoxHasLab.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHasLab.TabIndex = 17;
            this.checkBoxHasLab.UseVisualStyleBackColor = true;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 501);
            this.Controls.Add(this.checkBoxHasLab);
            this.Controls.Add(this.labelhasLab);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.panelPrereq);
            this.Controls.Add(this.labelPrereq);
            this.Controls.Add(this.textBoxFormat);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.textBoxCredHr);
            this.Controls.Add(this.labelCredHr);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxCore);
            this.Controls.Add(this.labelCore);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNumber);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialLabel labelNumber;
        private MaterialSingleLineTextField textBoxName;
        private System.Windows.Forms.TextBox textBoxCore;
        private MaterialLabel labelCore;
        private System.Windows.Forms.TextBox textBoxNumber;
        private MaterialLabel labelName;
        private System.Windows.Forms.TextBox textBoxDesc;
        private MaterialLabel labelDesc;
        private System.Windows.Forms.TextBox textBoxCredHr;
        private MaterialLabel labelCredHr;
        private System.Windows.Forms.TextBox textBoxFormat;
        private MaterialLabel labelFormat;
        private MaterialLabel labelPrereq;
        private System.Windows.Forms.Panel panelPrereq;
        private MaterialRaisedButton buttonCreate;
        private MaterialRaisedButton buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBoxHasLab;
        private MaterialLabel labelhasLab;
    }
}