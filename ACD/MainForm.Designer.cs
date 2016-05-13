using MaterialSkin.Controls;

namespace ACD
{
    partial class MainForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.performanceIndicatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaxasDatabaseDataSet = new ACD.vaxasDatabaseDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new ACD.vaxasDatabaseDataSetTableAdapters.CourseTableAdapter();
            this.performanceIndicatorTableAdapter = new ACD.vaxasDatabaseDataSetTableAdapters.PerformanceIndicatorTableAdapter();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton9 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton10 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton11 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton12 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton13 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton14 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton15 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.performanceIndicatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaxasDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Program";
            // 
            // performanceIndicatorBindingSource
            // 
            this.performanceIndicatorBindingSource.DataMember = "PerformanceIndicator";
            this.performanceIndicatorBindingSource.DataSource = this.vaxasDatabaseDataSet;
            // 
            // vaxasDatabaseDataSet
            // 
            this.vaxasDatabaseDataSet.DataSetName = "vaxasDatabaseDataSet";
            this.vaxasDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.vaxasDatabaseDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // performanceIndicatorTableAdapter
            // 
            this.performanceIndicatorTableAdapter.ClearBeforeFill = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 127);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Outcomes";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 171);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Indicators";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 220);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(41, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Core";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 266);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(65, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Courses";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(93, 172);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(93, 221);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 10;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(93, 268);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 11;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(228, 75);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 12;
            this.materialRaisedButton1.Text = "Add";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(321, 74);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton2.TabIndex = 13;
            this.materialRaisedButton2.Text = "Delete";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(228, 124);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton3.TabIndex = 14;
            this.materialRaisedButton3.Text = "Add";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(321, 124);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton4.TabIndex = 15;
            this.materialRaisedButton4.Text = "delete";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(228, 173);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton5.TabIndex = 16;
            this.materialRaisedButton5.Text = "Add";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Location = new System.Drawing.Point(321, 173);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton6.TabIndex = 17;
            this.materialRaisedButton6.Text = "delete";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Location = new System.Drawing.Point(228, 219);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton7.TabIndex = 18;
            this.materialRaisedButton7.Text = "Add";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton8
            // 
            this.materialRaisedButton8.Depth = 0;
            this.materialRaisedButton8.Location = new System.Drawing.Point(321, 223);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton8.TabIndex = 19;
            this.materialRaisedButton8.Text = "Delete";
            this.materialRaisedButton8.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton9
            // 
            this.materialRaisedButton9.Depth = 0;
            this.materialRaisedButton9.Location = new System.Drawing.Point(228, 266);
            this.materialRaisedButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton9.Name = "materialRaisedButton9";
            this.materialRaisedButton9.Primary = true;
            this.materialRaisedButton9.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton9.TabIndex = 20;
            this.materialRaisedButton9.Text = "add";
            this.materialRaisedButton9.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton10
            // 
            this.materialRaisedButton10.Depth = 0;
            this.materialRaisedButton10.Location = new System.Drawing.Point(321, 268);
            this.materialRaisedButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton10.Name = "materialRaisedButton10";
            this.materialRaisedButton10.Primary = true;
            this.materialRaisedButton10.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton10.TabIndex = 21;
            this.materialRaisedButton10.Text = "delete";
            this.materialRaisedButton10.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton11
            // 
            this.materialRaisedButton11.Depth = 0;
            this.materialRaisedButton11.Location = new System.Drawing.Point(418, 75);
            this.materialRaisedButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton11.Name = "materialRaisedButton11";
            this.materialRaisedButton11.Primary = true;
            this.materialRaisedButton11.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton11.TabIndex = 22;
            this.materialRaisedButton11.Text = "Edit";
            this.materialRaisedButton11.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton12
            // 
            this.materialRaisedButton12.BackColor = System.Drawing.SystemColors.Control;
            this.materialRaisedButton12.Depth = 0;
            this.materialRaisedButton12.Location = new System.Drawing.Point(418, 125);
            this.materialRaisedButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton12.Name = "materialRaisedButton12";
            this.materialRaisedButton12.Primary = true;
            this.materialRaisedButton12.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton12.TabIndex = 23;
            this.materialRaisedButton12.Text = "Edit";
            this.materialRaisedButton12.UseVisualStyleBackColor = false;
            // 
            // materialRaisedButton13
            // 
            this.materialRaisedButton13.Depth = 0;
            this.materialRaisedButton13.Location = new System.Drawing.Point(418, 173);
            this.materialRaisedButton13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton13.Name = "materialRaisedButton13";
            this.materialRaisedButton13.Primary = true;
            this.materialRaisedButton13.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton13.TabIndex = 24;
            this.materialRaisedButton13.Text = "edit";
            this.materialRaisedButton13.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton14
            // 
            this.materialRaisedButton14.Depth = 0;
            this.materialRaisedButton14.Location = new System.Drawing.Point(418, 223);
            this.materialRaisedButton14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton14.Name = "materialRaisedButton14";
            this.materialRaisedButton14.Primary = true;
            this.materialRaisedButton14.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton14.TabIndex = 25;
            this.materialRaisedButton14.Text = "edit";
            this.materialRaisedButton14.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton15
            // 
            this.materialRaisedButton15.Depth = 0;
            this.materialRaisedButton15.Location = new System.Drawing.Point(418, 268);
            this.materialRaisedButton15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton15.Name = "materialRaisedButton15";
            this.materialRaisedButton15.Primary = true;
            this.materialRaisedButton15.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton15.TabIndex = 26;
            this.materialRaisedButton15.Text = "edit";
            this.materialRaisedButton15.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(10, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialRaisedButton15);
            this.Controls.Add(this.materialRaisedButton14);
            this.Controls.Add(this.materialRaisedButton13);
            this.Controls.Add(this.materialRaisedButton12);
            this.Controls.Add(this.materialRaisedButton11);
            this.Controls.Add(this.materialRaisedButton10);
            this.Controls.Add(this.materialRaisedButton9);
            this.Controls.Add(this.materialRaisedButton8);
            this.Controls.Add(this.materialRaisedButton7);
            this.Controls.Add(this.materialRaisedButton6);
            this.Controls.Add(this.materialRaisedButton5);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MainForm";
            this.Text = "Texas A&M Program Redesign Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceIndicatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaxasDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialLabel label1;
        private vaxasDatabaseDataSet vaxasDatabaseDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private vaxasDatabaseDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource performanceIndicatorBindingSource;
        private vaxasDatabaseDataSetTableAdapters.PerformanceIndicatorTableAdapter performanceIndicatorTableAdapter;
        private MaterialLabel materialLabel1;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private MaterialRaisedButton materialRaisedButton1;
        private MaterialRaisedButton materialRaisedButton2;
        private MaterialRaisedButton materialRaisedButton3;
        private MaterialRaisedButton materialRaisedButton4;
        private MaterialRaisedButton materialRaisedButton5;
        private MaterialRaisedButton materialRaisedButton6;
        private MaterialRaisedButton materialRaisedButton7;
        private MaterialRaisedButton materialRaisedButton8;
        private MaterialRaisedButton materialRaisedButton9;
        private MaterialRaisedButton materialRaisedButton10;
        private MaterialRaisedButton materialRaisedButton11;
        private MaterialRaisedButton materialRaisedButton12;
        private MaterialRaisedButton materialRaisedButton13;
        private MaterialRaisedButton materialRaisedButton14;
        private MaterialRaisedButton materialRaisedButton15;
        private System.Windows.Forms.Button button1;
    }
}

