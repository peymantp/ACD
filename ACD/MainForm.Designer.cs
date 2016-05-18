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
            this.comboBoxProgram = new System.Windows.Forms.ComboBox();
            this.labelProgram = new MaterialSkin.Controls.MaterialLabel();
            this.vaxasDatabaseDataSet = new ACD.vaxasDatabaseDataSet();
            this.performanceIndicatorTableAdapter = new ACD.vaxasDatabaseDataSetTableAdapters.PerformanceIndicatorTableAdapter();
            this.labelOutcomes = new MaterialSkin.Controls.MaterialLabel();
            this.labelIndicators = new MaterialSkin.Controls.MaterialLabel();
            this.labelCourseGroup = new MaterialSkin.Controls.MaterialLabel();
            this.labelCourses = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxOutcome = new System.Windows.Forms.ComboBox();
            this.comboBoxIndicator = new System.Windows.Forms.ComboBox();
            this.comboBoxCourseGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.ButtonProgramAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonProgramDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.outcomeButtonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.outcomeButtonDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.indicatorButtonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.indicatorButtonDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.coreButtonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.coreButtonDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.courseButtonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.courseButtonDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonProgramEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.outcomeButtonEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.indicatorButtonEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.coreButtonEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.courseButtonEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonExport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.vaxasDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProgram
            // 
            this.comboBoxProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProgram.FormattingEnabled = true;
            this.comboBoxProgram.Location = new System.Drawing.Point(10, 99);
            this.comboBoxProgram.Name = "comboBoxProgram";
            this.comboBoxProgram.Size = new System.Drawing.Size(350, 21);
            this.comboBoxProgram.TabIndex = 1;
            this.comboBoxProgram.SelectedIndexChanged += new System.EventHandler(this.comboBoxProgram_SelectedIndexChanged);
            // 
            // labelProgram
            // 
            this.labelProgram.AutoSize = true;
            this.labelProgram.Depth = 0;
            this.labelProgram.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProgram.Location = new System.Drawing.Point(8, 76);
            this.labelProgram.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProgram.Name = "labelProgram";
            this.labelProgram.Size = new System.Drawing.Size(74, 19);
            this.labelProgram.TabIndex = 2;
            this.labelProgram.Text = "Programs";
            // 
            // vaxasDatabaseDataSet
            // 
            this.vaxasDatabaseDataSet.DataSetName = "vaxasDatabaseDataSet";
            this.vaxasDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // performanceIndicatorTableAdapter
            // 
            this.performanceIndicatorTableAdapter.ClearBeforeFill = true;
            // 
            // labelOutcomes
            // 
            this.labelOutcomes.AutoSize = true;
            this.labelOutcomes.Depth = 0;
            this.labelOutcomes.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelOutcomes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOutcomes.Location = new System.Drawing.Point(8, 136);
            this.labelOutcomes.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelOutcomes.Name = "labelOutcomes";
            this.labelOutcomes.Size = new System.Drawing.Size(178, 19);
            this.labelOutcomes.TabIndex = 4;
            this.labelOutcomes.Text = "Program Level Outcomes";
            // 
            // labelIndicators
            // 
            this.labelIndicators.AutoSize = true;
            this.labelIndicators.Depth = 0;
            this.labelIndicators.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelIndicators.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelIndicators.Location = new System.Drawing.Point(10, 199);
            this.labelIndicators.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelIndicators.Name = "labelIndicators";
            this.labelIndicators.Size = new System.Drawing.Size(76, 19);
            this.labelIndicators.TabIndex = 5;
            this.labelIndicators.Text = "Indicators";
            // 
            // labelCourseGroup
            // 
            this.labelCourseGroup.AutoSize = true;
            this.labelCourseGroup.Depth = 0;
            this.labelCourseGroup.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCourseGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCourseGroup.Location = new System.Drawing.Point(10, 261);
            this.labelCourseGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCourseGroup.Name = "labelCourseGroup";
            this.labelCourseGroup.Size = new System.Drawing.Size(101, 19);
            this.labelCourseGroup.TabIndex = 6;
            this.labelCourseGroup.Text = "Course Group";
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.Depth = 0;
            this.labelCourses.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCourses.Location = new System.Drawing.Point(10, 314);
            this.labelCourses.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(65, 19);
            this.labelCourses.TabIndex = 7;
            this.labelCourses.Text = "Courses";
            // 
            // comboBoxOutcome
            // 
            this.comboBoxOutcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOutcome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutcome.FormattingEnabled = true;
            this.comboBoxOutcome.Location = new System.Drawing.Point(10, 159);
            this.comboBoxOutcome.Name = "comboBoxOutcome";
            this.comboBoxOutcome.Size = new System.Drawing.Size(350, 21);
            this.comboBoxOutcome.TabIndex = 8;
            // 
            // comboBoxIndicator
            // 
            this.comboBoxIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxIndicator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIndicator.FormattingEnabled = true;
            this.comboBoxIndicator.Location = new System.Drawing.Point(10, 222);
            this.comboBoxIndicator.Name = "comboBoxIndicator";
            this.comboBoxIndicator.Size = new System.Drawing.Size(350, 21);
            this.comboBoxIndicator.TabIndex = 9;
            // 
            // comboBoxCourseGroup
            // 
            this.comboBoxCourseGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCourseGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourseGroup.FormattingEnabled = true;
            this.comboBoxCourseGroup.Location = new System.Drawing.Point(10, 284);
            this.comboBoxCourseGroup.Name = "comboBoxCourseGroup";
            this.comboBoxCourseGroup.Size = new System.Drawing.Size(350, 21);
            this.comboBoxCourseGroup.TabIndex = 10;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(10, 336);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(350, 21);
            this.comboBoxCourse.TabIndex = 11;
            // 
            // ButtonProgramAdd
            // 
            this.ButtonProgramAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonProgramAdd.Depth = 0;
            this.ButtonProgramAdd.Location = new System.Drawing.Point(387, 99);
            this.ButtonProgramAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonProgramAdd.Name = "ButtonProgramAdd";
            this.ButtonProgramAdd.Primary = true;
            this.ButtonProgramAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonProgramAdd.TabIndex = 12;
            this.ButtonProgramAdd.Text = "Add";
            this.ButtonProgramAdd.UseVisualStyleBackColor = true;
            this.ButtonProgramAdd.Click += new System.EventHandler(this.ButtonProgramAdd_Click);
            // 
            // ButtonProgramDelete
            // 
            this.ButtonProgramDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonProgramDelete.Depth = 0;
            this.ButtonProgramDelete.Location = new System.Drawing.Point(582, 99);
            this.ButtonProgramDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonProgramDelete.Name = "ButtonProgramDelete";
            this.ButtonProgramDelete.Primary = true;
            this.ButtonProgramDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonProgramDelete.TabIndex = 13;
            this.ButtonProgramDelete.Text = "Delete";
            this.ButtonProgramDelete.UseVisualStyleBackColor = true;
            this.ButtonProgramDelete.Click += new System.EventHandler(this.ButtonProgramDelete_Click);
            // 
            // outcomeButtonAdd
            // 
            this.outcomeButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outcomeButtonAdd.Depth = 0;
            this.outcomeButtonAdd.Location = new System.Drawing.Point(387, 158);
            this.outcomeButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.outcomeButtonAdd.Name = "outcomeButtonAdd";
            this.outcomeButtonAdd.Primary = true;
            this.outcomeButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.outcomeButtonAdd.TabIndex = 14;
            this.outcomeButtonAdd.Text = "Add";
            this.outcomeButtonAdd.UseVisualStyleBackColor = true;
            this.outcomeButtonAdd.Click += new System.EventHandler(this.programOutcomesButtonAdd_Click);
            // 
            // outcomeButtonDelete
            // 
            this.outcomeButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outcomeButtonDelete.Depth = 0;
            this.outcomeButtonDelete.Location = new System.Drawing.Point(582, 158);
            this.outcomeButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.outcomeButtonDelete.Name = "outcomeButtonDelete";
            this.outcomeButtonDelete.Primary = true;
            this.outcomeButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.outcomeButtonDelete.TabIndex = 15;
            this.outcomeButtonDelete.Text = "delete";
            this.outcomeButtonDelete.UseVisualStyleBackColor = true;
            this.outcomeButtonDelete.Click += new System.EventHandler(this.outcomeButtonDelete_Click);
            // 
            // indicatorButtonAdd
            // 
            this.indicatorButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.indicatorButtonAdd.Depth = 0;
            this.indicatorButtonAdd.Location = new System.Drawing.Point(387, 223);
            this.indicatorButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.indicatorButtonAdd.Name = "indicatorButtonAdd";
            this.indicatorButtonAdd.Primary = true;
            this.indicatorButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.indicatorButtonAdd.TabIndex = 16;
            this.indicatorButtonAdd.Text = "Add";
            this.indicatorButtonAdd.UseVisualStyleBackColor = true;
            // 
            // indicatorButtonDelete
            // 
            this.indicatorButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.indicatorButtonDelete.Depth = 0;
            this.indicatorButtonDelete.Location = new System.Drawing.Point(582, 223);
            this.indicatorButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.indicatorButtonDelete.Name = "indicatorButtonDelete";
            this.indicatorButtonDelete.Primary = true;
            this.indicatorButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.indicatorButtonDelete.TabIndex = 17;
            this.indicatorButtonDelete.Text = "delete";
            this.indicatorButtonDelete.UseVisualStyleBackColor = true;
            // 
            // coreButtonAdd
            // 
            this.coreButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coreButtonAdd.Depth = 0;
            this.coreButtonAdd.Location = new System.Drawing.Point(387, 284);
            this.coreButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.coreButtonAdd.Name = "coreButtonAdd";
            this.coreButtonAdd.Primary = true;
            this.coreButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.coreButtonAdd.TabIndex = 18;
            this.coreButtonAdd.Text = "Add";
            this.coreButtonAdd.UseVisualStyleBackColor = true;
            this.coreButtonAdd.Click += new System.EventHandler(this.coreButtonAdd_Click);
            // 
            // coreButtonDelete
            // 
            this.coreButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coreButtonDelete.Depth = 0;
            this.coreButtonDelete.Location = new System.Drawing.Point(582, 285);
            this.coreButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.coreButtonDelete.Name = "coreButtonDelete";
            this.coreButtonDelete.Primary = true;
            this.coreButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.coreButtonDelete.TabIndex = 19;
            this.coreButtonDelete.Text = "Delete";
            this.coreButtonDelete.UseVisualStyleBackColor = true;
            this.coreButtonDelete.Click += new System.EventHandler(this.coreButtonDelete_Click);
            // 
            // courseButtonAdd
            // 
            this.courseButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.courseButtonAdd.Depth = 0;
            this.courseButtonAdd.Location = new System.Drawing.Point(387, 336);
            this.courseButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.courseButtonAdd.Name = "courseButtonAdd";
            this.courseButtonAdd.Primary = true;
            this.courseButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.courseButtonAdd.TabIndex = 20;
            this.courseButtonAdd.Text = "add";
            this.courseButtonAdd.UseVisualStyleBackColor = true;
            this.courseButtonAdd.Click += new System.EventHandler(this.courseButtonAdd_Click);
            // 
            // courseButtonDelete
            // 
            this.courseButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.courseButtonDelete.Depth = 0;
            this.courseButtonDelete.Location = new System.Drawing.Point(582, 337);
            this.courseButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.courseButtonDelete.Name = "courseButtonDelete";
            this.courseButtonDelete.Primary = true;
            this.courseButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.courseButtonDelete.TabIndex = 21;
            this.courseButtonDelete.Text = "delete";
            this.courseButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonProgramEdit
            // 
            this.ButtonProgramEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonProgramEdit.Depth = 0;
            this.ButtonProgramEdit.Location = new System.Drawing.Point(486, 99);
            this.ButtonProgramEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonProgramEdit.Name = "ButtonProgramEdit";
            this.ButtonProgramEdit.Primary = true;
            this.ButtonProgramEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonProgramEdit.TabIndex = 22;
            this.ButtonProgramEdit.Text = "Edit";
            this.ButtonProgramEdit.UseVisualStyleBackColor = true;
            this.ButtonProgramEdit.Click += new System.EventHandler(this.ButtonProgramEdit_Click);
            // 
            // outcomeButtonEdit
            // 
            this.outcomeButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outcomeButtonEdit.BackColor = System.Drawing.SystemColors.Control;
            this.outcomeButtonEdit.Depth = 0;
            this.outcomeButtonEdit.Location = new System.Drawing.Point(486, 158);
            this.outcomeButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.outcomeButtonEdit.Name = "outcomeButtonEdit";
            this.outcomeButtonEdit.Primary = true;
            this.outcomeButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.outcomeButtonEdit.TabIndex = 23;
            this.outcomeButtonEdit.Text = "Edit";
            this.outcomeButtonEdit.UseVisualStyleBackColor = false;
            this.outcomeButtonEdit.Click += new System.EventHandler(this.outcomeButtonEdit_Click);
            // 
            // indicatorButtonEdit
            // 
            this.indicatorButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.indicatorButtonEdit.Depth = 0;
            this.indicatorButtonEdit.Location = new System.Drawing.Point(486, 223);
            this.indicatorButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.indicatorButtonEdit.Name = "indicatorButtonEdit";
            this.indicatorButtonEdit.Primary = true;
            this.indicatorButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.indicatorButtonEdit.TabIndex = 24;
            this.indicatorButtonEdit.Text = "edit";
            this.indicatorButtonEdit.UseVisualStyleBackColor = true;
            // 
            // coreButtonEdit
            // 
            this.coreButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coreButtonEdit.Depth = 0;
            this.coreButtonEdit.Location = new System.Drawing.Point(486, 284);
            this.coreButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.coreButtonEdit.Name = "coreButtonEdit";
            this.coreButtonEdit.Primary = true;
            this.coreButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.coreButtonEdit.TabIndex = 25;
            this.coreButtonEdit.Text = "edit";
            this.coreButtonEdit.UseVisualStyleBackColor = true;
            this.coreButtonEdit.Click += new System.EventHandler(this.coreButtonEdit_Click);
            // 
            // courseButtonEdit
            // 
            this.courseButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.courseButtonEdit.Depth = 0;
            this.courseButtonEdit.Location = new System.Drawing.Point(486, 336);
            this.courseButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.courseButtonEdit.Name = "courseButtonEdit";
            this.courseButtonEdit.Primary = true;
            this.courseButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.courseButtonEdit.TabIndex = 26;
            this.courseButtonEdit.Text = "edit";
            this.courseButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonExport
            // 
            this.ButtonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExport.Depth = 0;
            this.ButtonExport.Location = new System.Drawing.Point(387, 382);
            this.ButtonExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Primary = true;
            this.ButtonExport.Size = new System.Drawing.Size(270, 23);
            this.ButtonExport.TabIndex = 27;
            this.ButtonExport.Text = "Create matrix";
            this.ButtonExport.UseVisualStyleBackColor = true;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(387, 422);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(270, 23);
            this.materialRaisedButton1.TabIndex = 28;
            this.materialRaisedButton1.Text = "materialRaisedButton1";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 457);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.ButtonExport);
            this.Controls.Add(this.courseButtonEdit);
            this.Controls.Add(this.coreButtonEdit);
            this.Controls.Add(this.indicatorButtonEdit);
            this.Controls.Add(this.outcomeButtonEdit);
            this.Controls.Add(this.ButtonProgramEdit);
            this.Controls.Add(this.courseButtonDelete);
            this.Controls.Add(this.courseButtonAdd);
            this.Controls.Add(this.coreButtonDelete);
            this.Controls.Add(this.coreButtonAdd);
            this.Controls.Add(this.indicatorButtonDelete);
            this.Controls.Add(this.indicatorButtonAdd);
            this.Controls.Add(this.outcomeButtonDelete);
            this.Controls.Add(this.outcomeButtonAdd);
            this.Controls.Add(this.ButtonProgramDelete);
            this.Controls.Add(this.ButtonProgramAdd);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.comboBoxCourseGroup);
            this.Controls.Add(this.comboBoxIndicator);
            this.Controls.Add(this.comboBoxOutcome);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.labelCourseGroup);
            this.Controls.Add(this.labelIndicators);
            this.Controls.Add(this.labelOutcomes);
            this.Controls.Add(this.labelProgram);
            this.Controls.Add(this.comboBoxProgram);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 488);
            this.MinimumSize = new System.Drawing.Size(675, 447);
            this.Name = "MainForm";
            this.Text = "Texas A&M Program Redesign Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vaxasDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxProgram;
        private MaterialLabel labelProgram;
        private vaxasDatabaseDataSet vaxasDatabaseDataSet;
        private vaxasDatabaseDataSetTableAdapters.PerformanceIndicatorTableAdapter performanceIndicatorTableAdapter;
        private MaterialLabel labelOutcomes;
        private MaterialLabel labelIndicators;
        private MaterialLabel labelCourseGroup;
        private MaterialLabel labelCourses;
        private System.Windows.Forms.ComboBox comboBoxOutcome;
        private System.Windows.Forms.ComboBox comboBoxIndicator;
        private System.Windows.Forms.ComboBox comboBoxCourseGroup;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private MaterialRaisedButton ButtonProgramAdd;
        private MaterialRaisedButton ButtonProgramDelete;
        private MaterialRaisedButton outcomeButtonAdd;
        private MaterialRaisedButton outcomeButtonDelete;
        private MaterialRaisedButton indicatorButtonAdd;
        private MaterialRaisedButton indicatorButtonDelete;
        private MaterialRaisedButton coreButtonAdd;
        private MaterialRaisedButton coreButtonDelete;
        private MaterialRaisedButton courseButtonAdd;
        private MaterialRaisedButton courseButtonDelete;
        private MaterialRaisedButton ButtonProgramEdit;
        private MaterialRaisedButton outcomeButtonEdit;
        private MaterialRaisedButton indicatorButtonEdit;
        private MaterialRaisedButton coreButtonEdit;
        private MaterialRaisedButton courseButtonEdit;
        private MaterialRaisedButton ButtonExport;
        private MaterialRaisedButton materialRaisedButton1;
    }
}

