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
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCore = new System.Windows.Forms.TextBox();
            this.labelCore = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.textBoxCredHr = new System.Windows.Forms.TextBox();
            this.labelCredHr = new System.Windows.Forms.Label();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelPrereq = new System.Windows.Forms.Label();
            this.panelPrereq = new System.Windows.Forms.Panel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelhasLab = new System.Windows.Forms.Label();
            this.checkBoxHasLab = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(58, 84);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Number";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxCore
            // 
            this.textBoxCore.Location = new System.Drawing.Point(108, 55);
            this.textBoxCore.Name = "textBoxCore";
            this.textBoxCore.Size = new System.Drawing.Size(270, 20);
            this.textBoxCore.TabIndex = 3;
            // 
            // labelCore
            // 
            this.labelCore.AutoSize = true;
            this.labelCore.Location = new System.Drawing.Point(73, 58);
            this.labelCore.Name = "labelCore";
            this.labelCore.Size = new System.Drawing.Size(29, 13);
            this.labelCore.TabIndex = 2;
            this.labelCore.Text = "Core";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(108, 81);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(270, 20);
            this.textBoxNumber.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(67, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(108, 107);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(270, 56);
            this.textBoxDesc.TabIndex = 7;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(42, 107);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(60, 13);
            this.labelDesc.TabIndex = 6;
            this.labelDesc.Text = "Description";
            // 
            // textBoxCredHr
            // 
            this.textBoxCredHr.Location = new System.Drawing.Point(108, 169);
            this.textBoxCredHr.Name = "textBoxCredHr";
            this.textBoxCredHr.Size = new System.Drawing.Size(270, 20);
            this.textBoxCredHr.TabIndex = 9;
            // 
            // labelCredHr
            // 
            this.labelCredHr.AutoSize = true;
            this.labelCredHr.Location = new System.Drawing.Point(42, 172);
            this.labelCredHr.Name = "labelCredHr";
            this.labelCredHr.Size = new System.Drawing.Size(63, 13);
            this.labelCredHr.TabIndex = 8;
            this.labelCredHr.Text = "Credit hours";
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(108, 195);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(270, 20);
            this.textBoxFormat.TabIndex = 11;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(63, 198);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(39, 13);
            this.labelFormat.TabIndex = 10;
            this.labelFormat.Text = "Format";
            // 
            // labelPrereq
            // 
            this.labelPrereq.AutoSize = true;
            this.labelPrereq.Location = new System.Drawing.Point(35, 250);
            this.labelPrereq.Name = "labelPrereq";
            this.labelPrereq.Size = new System.Drawing.Size(67, 13);
            this.labelPrereq.TabIndex = 12;
            this.labelPrereq.Text = "Prerequisites";
            // 
            // panelPrereq
            // 
            this.panelPrereq.AutoScroll = true;
            this.panelPrereq.Location = new System.Drawing.Point(108, 250);
            this.panelPrereq.Name = "panelPrereq";
            this.panelPrereq.Size = new System.Drawing.Size(270, 118);
            this.panelPrereq.TabIndex = 13;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(303, 382);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(108, 382);
            this.buttonCancel.Name = "buttonCancel";
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
            this.labelhasLab.Location = new System.Drawing.Point(59, 226);
            this.labelhasLab.Name = "labelhasLab";
            this.labelhasLab.Size = new System.Drawing.Size(43, 13);
            this.labelhasLab.TabIndex = 16;
            this.labelhasLab.Text = "Has lab";
            // 
            // checkBoxHasLab
            // 
            this.checkBoxHasLab.AutoSize = true;
            this.checkBoxHasLab.Location = new System.Drawing.Point(109, 226);
            this.checkBoxHasLab.Name = "checkBoxHasLab";
            this.checkBoxHasLab.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHasLab.TabIndex = 17;
            this.checkBoxHasLab.UseVisualStyleBackColor = true;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 417);
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

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCore;
        private System.Windows.Forms.Label labelCore;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.TextBox textBoxCredHr;
        private System.Windows.Forms.Label labelCredHr;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelPrereq;
        private System.Windows.Forms.Panel panelPrereq;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBoxHasLab;
        private System.Windows.Forms.Label labelhasLab;
    }
}