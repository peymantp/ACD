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
            this.textBoxName = new System.Windows.Forms.TextBox();
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
            this.buttonCreate = new MaterialRaisedButton();
            this.buttonCancel = new MaterialRaisedButton();
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
            this.labelNumber.Location = new System.Drawing.Point(59, 160);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(90, 27);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Number";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(162, 80);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(403, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxCore
            // 
            this.textBoxCore.Location = new System.Drawing.Point(162, 120);
            this.textBoxCore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCore.Name = "textBoxCore";
            this.textBoxCore.Size = new System.Drawing.Size(403, 26);
            this.textBoxCore.TabIndex = 3;
            // 
            // labelCore
            // 
            this.labelCore.AutoSize = true;
            this.labelCore.Depth = 0;
            this.labelCore.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCore.Location = new System.Drawing.Point(91, 120);
            this.labelCore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCore.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCore.Name = "labelCore";
            this.labelCore.Size = new System.Drawing.Size(58, 27);
            this.labelCore.TabIndex = 2;
            this.labelCore.Text = "Core";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(162, 160);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(403, 26);
            this.textBoxNumber.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Depth = 0;
            this.labelName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(78, 80);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 27);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(162, 200);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(403, 84);
            this.textBoxDesc.TabIndex = 7;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Depth = 0;
            this.labelDesc.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDesc.Location = new System.Drawing.Point(34, 198);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(122, 27);
            this.labelDesc.TabIndex = 6;
            this.labelDesc.Text = "Description";
            // 
            // textBoxCredHr
            // 
            this.textBoxCredHr.Location = new System.Drawing.Point(162, 295);
            this.textBoxCredHr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCredHr.Name = "textBoxCredHr";
            this.textBoxCredHr.Size = new System.Drawing.Size(403, 26);
            this.textBoxCredHr.TabIndex = 9;
            // 
            // labelCredHr
            // 
            this.labelCredHr.AutoSize = true;
            this.labelCredHr.Depth = 0;
            this.labelCredHr.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCredHr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCredHr.Location = new System.Drawing.Point(27, 293);
            this.labelCredHr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCredHr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCredHr.Name = "labelCredHr";
            this.labelCredHr.Size = new System.Drawing.Size(129, 27);
            this.labelCredHr.TabIndex = 8;
            this.labelCredHr.Text = "Credit hours";
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(162, 335);
            this.textBoxFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(403, 26);
            this.textBoxFormat.TabIndex = 11;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Depth = 0;
            this.labelFormat.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFormat.Location = new System.Drawing.Point(67, 335);
            this.labelFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(82, 27);
            this.labelFormat.TabIndex = 10;
            this.labelFormat.Text = "Format";
            // 
            // labelPrereq
            // 
            this.labelPrereq.AutoSize = true;
            this.labelPrereq.Depth = 0;
            this.labelPrereq.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPrereq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPrereq.Location = new System.Drawing.Point(16, 416);
            this.labelPrereq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrereq.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPrereq.Name = "labelPrereq";
            this.labelPrereq.Size = new System.Drawing.Size(140, 27);
            this.labelPrereq.TabIndex = 12;
            this.labelPrereq.Text = "Prerequisites";
            // 
            // panelPrereq
            // 
            this.panelPrereq.AutoScroll = true;
            this.panelPrereq.Location = new System.Drawing.Point(162, 420);
            this.panelPrereq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPrereq.Name = "panelPrereq";
            this.panelPrereq.Size = new System.Drawing.Size(405, 182);
            this.panelPrereq.TabIndex = 13;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(454, 623);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(112, 35);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(162, 623);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 35);
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
            this.labelhasLab.Location = new System.Drawing.Point(64, 377);
            this.labelhasLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelhasLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelhasLab.Name = "labelhasLab";
            this.labelhasLab.Size = new System.Drawing.Size(85, 27);
            this.labelhasLab.TabIndex = 16;
            this.labelhasLab.Text = "Has lab";
            // 
            // checkBoxHasLab
            // 
            this.checkBoxHasLab.AutoSize = true;
            this.checkBoxHasLab.Location = new System.Drawing.Point(164, 383);
            this.checkBoxHasLab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxHasLab.Name = "checkBoxHasLab";
            this.checkBoxHasLab.Size = new System.Drawing.Size(22, 21);
            this.checkBoxHasLab.TabIndex = 17;
            this.checkBoxHasLab.UseVisualStyleBackColor = true;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 703);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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