using System;
using System.Collections.Generic;
using System.Configuration;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ACD
{
    /// <summary>
    /// The main form displays the information of every program in the database
    /// and allows adding, deleting and, editing of information related to 
    /// every program
    /// </summary>
    public partial class MainForm : MaterialForm
    {
        private MaterialSkinManager skinManager;
        private string conn = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
        private SqlConnection connection;
        private string programQuery = "select * FROM dbo.Faculty";
        private string outcomeQuery;
        private string courseGroupQuery;

        private SqlDataAdapter programAdapter;
        private SqlDataAdapter outcomeAdapter;
        private SqlDataAdapter courseGroupAdapter;

        private DataSet programDs;
        private DataSet outcomeDs;
        private DataSet courseGroupDs;

        public MainForm()
        {
            
            InitializeComponent();

            //color design off app
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(conn);
            programAdapter = new SqlDataAdapter(programQuery, connection);
            programDs = new DataSet();
            programAdapter.Fill(programDs);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = programDs.Tables["Table"].Columns["Name"];
            programDs.Tables["Table"].PrimaryKey = keyColumns;

            foreach(DataRow r in programDs.Tables["Table"].Rows)
            {
                comboBoxProgram.Items.Add(r["Name"]);
            }
            if (comboBoxProgram.Items.Count == 0)
                comboBoxProgram.Items.Add("No Programs in Database");

            comboBoxProgram.SelectedIndex = 0;
        }

        private void courseButtonAdd_Click(object sender, EventArgs e) { new CourseForm().ShowDialog(); }

        private void ButtonProgramAdd_Click(object sender, EventArgs e)
        {
            using (var form = new ProgramForm())
            {
                var result = form.ShowDialog();
                if (System.Windows.Forms.DialogResult.OK == result)
                {
                    comboBoxProgram.Items.Clear();
                    programDs.Clear();
                    programAdapter.Fill(programDs);
                    foreach (DataRow r in programDs.Tables["Table"].Rows)
                    {
                        comboBoxProgram.Items.Add(r["Name"]);
                    }

                    comboBoxProgram.SelectedIndex = comboBoxProgram.Items.IndexOf(form.getName);
                }
            }
        }
        private void ButtonProgramDelete_Click(object sender, EventArgs e)
        {
            var result = new DeleteDialog(comboBoxProgram.Text).ShowDialog();
            if (System.Windows.Forms.DialogResult.OK == result && programDs.Tables["Table"].Rows.Contains(comboBoxProgram.Text))
            {
                try {
                    programDs.Tables["Table"].Rows[programDs.Tables["Table"].Rows.IndexOf(programDs.Tables["Table"].Rows.Find(comboBoxProgram.Text))].Delete();

                    new SqlCommandBuilder(programAdapter);
                    programAdapter.Update(programDs);
                    programDs.Clear();
                    programAdapter.Fill(programDs);

                    comboBoxProgram.Items.Clear();

                    foreach (DataRow r in programDs.Tables["Table"].Rows)
                    {
                        comboBoxProgram.Items.Add(r["Name"]);
                    }
                    if (comboBoxProgram.Items.Count == 0)
                        comboBoxProgram.Items.Add("No Programs in Database");

                    comboBoxProgram.SelectedIndex = 0;
                }
                catch (System.Data.SqlClient.SqlException sqlexception)
                {
                    new ErrorDialog("You must delete all related level outcomes, indicators, course groups and, courses to the program first").ShowDialog();
                }
            }
        }

        private void ButtonProgramEdit_Click(object sender, EventArgs e)
        {
            using (var form = new ProgramForm((string)comboBoxProgram.SelectedItem)) { 
                var result = form.ShowDialog();

                if (System.Windows.Forms.DialogResult.OK == result)
                {
                    comboBoxProgram.Items.Clear();
                    programDs.Clear();
                    programAdapter.Fill(programDs);
                    foreach (DataRow r in programDs.Tables["Table"].Rows)
                    {
                        comboBoxProgram.Items.Add(r["Name"]);
                    }

                    comboBoxProgram.SelectedIndex = comboBoxProgram.Items.IndexOf(form.getName);
                }
            }
            
        }

        private void comboBoxProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            outcomeQuery = "select* FROM dbo.ProgramLevel WHERE FacultyName = '" + comboBoxProgram.Text + "'";
            outcomeAdapter = new SqlDataAdapter(outcomeQuery, connection);
            outcomeDs = new DataSet();
            outcomeAdapter.Fill(outcomeDs);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = outcomeDs.Tables["Table"].Columns["Name"];
            outcomeDs.Tables["Table"].PrimaryKey = keyColumns;

            comboBoxOutcome.Items.Clear();
            foreach (DataRow r in outcomeDs.Tables["Table"].Rows)
            {
                comboBoxOutcome.Items.Add(r["Name"]);
            }
            if (comboBoxOutcome.Items.Count == 0)
                comboBoxOutcome.Items.Add("No outcomes in Database");

            comboBoxOutcome.SelectedIndex = 0;

            courseGroupQuery = "select* FROM dbo.CourseGroup WHERE FacultyName = '" + comboBoxProgram.Text + "'";
            courseGroupAdapter = new SqlDataAdapter(courseGroupQuery, connection);
            courseGroupDs = new DataSet();
            courseGroupAdapter.Fill(courseGroupDs);
            keyColumns[0] = courseGroupDs.Tables["Table"].Columns["Name"];
            courseGroupDs.Tables["Table"].PrimaryKey = keyColumns;

            comboBoxCourseGroup.Items.Clear();
            foreach (DataRow r in courseGroupDs.Tables["Table"].Rows)
            {
                comboBoxCourseGroup.Items.Add(r["Name"]);
            }
            if (comboBoxCourseGroup.Items.Count == 0)
                comboBoxCourseGroup.Items.Add("No course groups in Database");

            comboBoxCourseGroup.SelectedIndex = 0;
        }

        private void programOutcomesButtonAdd_Click(object sender, EventArgs e)
        {
            using (var form = new ProgramLevelForm(comboBoxProgram.Text))
            {
                var result = form.ShowDialog();
                if (System.Windows.Forms.DialogResult.OK == result)
                {
                    comboBoxOutcome.Items.Clear();
                    outcomeDs.Clear();
                    outcomeAdapter.Fill(outcomeDs);
                    foreach (DataRow r in outcomeDs.Tables["Table"].Rows)
                    {
                        comboBoxOutcome.Items.Add(r["Name"]);
                    }

                    comboBoxOutcome.SelectedIndex = comboBoxOutcome.Items.IndexOf(form.getName);
                }
            }

        }

        private void outcomeButtonDelete_Click(object sender, EventArgs e)
        {
            var result = new DeleteDialog(comboBoxOutcome.Text).ShowDialog();
            if (System.Windows.Forms.DialogResult.OK == result && outcomeDs.Tables["Table"].Rows.Contains(comboBoxOutcome.Text))
            {
                outcomeDs.Tables["Table"].Rows[outcomeDs.Tables["Table"].Rows.IndexOf(outcomeDs.Tables["Table"].Rows.Find(comboBoxOutcome.Text))].Delete();

                new SqlCommandBuilder(outcomeAdapter);
                outcomeAdapter.Update(outcomeDs);
                outcomeDs.Clear();
                outcomeAdapter.Fill(outcomeDs);

                comboBoxOutcome.Items.Clear();

                foreach (DataRow r in outcomeDs.Tables["Table"].Rows)
                {
                    comboBoxOutcome.Items.Add(r["Name"]);
                }
                if (comboBoxOutcome.Items.Count == 0)
                    comboBoxOutcome.Items.Add("No Outcomes in Database");

                comboBoxOutcome.SelectedIndex = 0;
            }
        }

        private void outcomeButtonEdit_Click(object sender, EventArgs e)
        {
            using (var form = new ProgramLevelForm((string)comboBoxProgram.SelectedItem, (string)comboBoxOutcome.SelectedItem))
            {
                var result = form.ShowDialog();

                if (System.Windows.Forms.DialogResult.OK == result)
                {
                    comboBoxOutcome.Items.Clear();
                    outcomeDs.Clear();
                    outcomeAdapter.Fill(outcomeDs);
                    foreach (DataRow r in outcomeDs.Tables["Table"].Rows)
                    {
                        comboBoxOutcome.Items.Add(r["Name"]);
                    }

                    comboBoxOutcome.SelectedIndex = comboBoxOutcome.Items.IndexOf(form.getName);
                }
            }
        }

        private void coreButtonAdd_Click(object sender, EventArgs e)
        {
            using (var form = new CourseGroupForm(comboBoxProgram.Text))
            {
                var result = form.ShowDialog();
                if (System.Windows.Forms.DialogResult.OK == result)
                {
                    comboBoxCourseGroup.Items.Clear();
                    courseGroupDs.Clear();
                    courseGroupAdapter.Fill(courseGroupDs);
                    foreach (DataRow r in courseGroupDs.Tables["Table"].Rows)
                    {
                        comboBoxCourseGroup.Items.Add(r["Name"]);
                    }

                    comboBoxCourseGroup.SelectedIndex = comboBoxCourseGroup.Items.IndexOf(form.getName);
                }
            }
        }

        private void coreButtonDelete_Click(object sender, EventArgs e)
        {
            var result = new DeleteDialog(comboBoxCourseGroup.Text).ShowDialog();
            if (System.Windows.Forms.DialogResult.OK == result && courseGroupDs.Tables["Table"].Rows.Contains(comboBoxCourseGroup.Text))
            {
                courseGroupDs.Tables["Table"].Rows[courseGroupDs.Tables["Table"].Rows.IndexOf(courseGroupDs.Tables["Table"].Rows.Find(comboBoxCourseGroup.Text))].Delete();

                new SqlCommandBuilder(courseGroupAdapter);
                courseGroupAdapter.Update(courseGroupDs);
                courseGroupDs.Clear();
                courseGroupAdapter.Fill(courseGroupDs);

                comboBoxCourseGroup.Items.Clear();

                foreach (DataRow r in courseGroupDs.Tables["Table"].Rows)
                {
                    comboBoxCourseGroup.Items.Add(r["Name"]);
                }
                if (comboBoxCourseGroup.Items.Count == 0)
                    comboBoxCourseGroup.Items.Add("No Outcomes in Database");

                comboBoxCourseGroup.SelectedIndex = 0;
            }
        }

        private void coreButtonEdit_Click(object sender, EventArgs e)
        {
            using (var form = new CourseGroupForm((string)comboBoxProgram.SelectedItem, (string)comboBoxCourseGroup.SelectedItem))
            {
                var result = form.ShowDialog();

                if (System.Windows.Forms.DialogResult.OK == result)
                {
                    comboBoxCourseGroup.Items.Clear();
                    courseGroupDs.Clear();
                    courseGroupAdapter.Fill(courseGroupDs);
                    foreach (DataRow r in courseGroupDs.Tables["Table"].Rows)
                    {
                        comboBoxCourseGroup.Items.Add(r["Name"]);
                    }

                    comboBoxCourseGroup.SelectedIndex = comboBoxCourseGroup.Items.IndexOf(form.getName);
                }
            }
        }
    }
}
