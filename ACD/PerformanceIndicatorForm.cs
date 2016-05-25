using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Author: Manish Mallavarapu, Eric Lau 
/// Last Updated: May/19/2016
/// </summary>
namespace ACD
{
    public partial class PerformanceIndicatorForm : MaterialForm
    {
        private string currName;
        private string newName;

        private string query;
        private string conn;
        private SqlConnection connection;
        private SqlDataAdapter dadapter;
        private DataSet ds = new DataSet();

        private string queryCourse;
        private string connCourse;
        private SqlConnection connectionCourse;
        private SqlDataAdapter dadapterCourse;
        private DataSet dsCourse = new DataSet();

        private string queryIndicator;
        private string connIndicator;
        private SqlConnection connectionIndicator;
        private SqlDataAdapter dadapterIndicator;
        private DataSet dsIndicator = new DataSet();

        private CheckBox[,] boxArray;

        public string getName { get { return newName; } }
        /// <summary>
        /// Constructor, creates form and opens connection to database.
        /// </summary>
        /// <param name="programName"></param>
        /// <param name="programLevelName"></param>
        public PerformanceIndicatorForm(string programName, string programLevelName)
        {
            InitializeComponent();
            TextFieldProgram.Text = programName;
            TextFieldProgramLevel.Text = programLevelName;
            openConnection();
            populateCourses();
        }
        /// <summary>
        /// Second Constructor, creates form with specified parameters 
        /// </summary>
        /// <param name="programName"></param>
        /// <param name="programLevelName"></param>
        /// <param name="indicatorName"></param>
        public PerformanceIndicatorForm(string programName, string programLevelName, string indicatorName)
        {
            InitializeComponent();
            ButtonSave.Text = "Edit";
            TextFieldProgram.Text = programName;
            TextFieldProgramLevel.Text = programLevelName;
            indicatorNameField.Text = indicatorName;
            currName = indicatorName;
            openConnection();
            populateCourses();
            fillLevelIndicators();

            criteria4TextField.Text = ds.Tables["Table"].Rows.Find(currName)["Level4Criteria"].ToString();
            criteria3TextField.Text = ds.Tables["Table"].Rows.Find(currName)["Level3Criteria"].ToString();
            criteria2TextField.Text = ds.Tables["Table"].Rows.Find(currName)["Level2Criteria"].ToString();
            criteria1TextField.Text = ds.Tables["Table"].Rows.Find(currName)["Level1Criteria"].ToString();
        }
        /// <summary>
        /// When cancel button is clicked, closes the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        /// <summary>
        /// When save is clicked, we update the database. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (indicatorNameField.Text.Equals(""))
            {
                errorProvider1.SetError(indicatorNameField, "Please enter a name");
            }
            else if (indicatorNameField.Text.Length > 100)
            {
                errorProvider1.SetError(indicatorNameField, "Name too long");
            }
            else
            {
                if (!(ds.Tables["Table"].Rows.Contains(indicatorNameField.Text)) || (ButtonSave.Text.Equals("Edit") && currName.Equals(indicatorNameField.Text)))
                {
                    if (ButtonSave.Text.Equals("Edit"))
                    {
                        ds.Tables["Table"].Rows.Find(currName)["Name"] = indicatorNameField.Text;
                        currName = indicatorNameField.Text;
                        ds.Tables["Table"].Rows.Find(currName)["Level3Criteria"] = criteria4TextField.Text ;
                        ds.Tables["Table"].Rows.Find(currName)["Level2Criteria"] = criteria3TextField.Text ;
                        ds.Tables["Table"].Rows.Find(currName)["Level4Criteria"] = criteria2TextField.Text ;
                        ds.Tables["Table"].Rows.Find(currName)["Level1Criteria"] = criteria1TextField.Text;
                        deleteLevelIndicators();
                    }
                    else
                    {
                        var newRow = ds.Tables["Table"].NewRow();
                        newRow["Name"] = indicatorNameField.Text;
                        newRow["FacultyName"] = TextFieldProgram.Text;
                        newRow["ProgramLevelName"] = TextFieldProgramLevel.Text;
                        newRow["Level4Criteria"] = criteria4TextField.Text;
                        newRow["Level3Criteria"] = criteria3TextField.Text;
                        newRow["Level2Criteria"] = criteria2TextField.Text;
                        newRow["Level1Criteria"] = criteria1TextField.Text;

                        ds.Tables["Table"].Rows.Add(newRow);
                    }

                    new SqlCommandBuilder(dadapter);

                    dadapter.Update(ds);
                    saveLevelIndicators();
                    connection.Close();
                    newName = indicatorNameField.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(indicatorNameField, indicatorNameField.Text + " indicator already exists");
                }
                connection.Close();
            }
        }

        private void openConnection()
        {
            query = "select * FROM dbo.PerformanceIndicator";
            conn = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(conn);
            dadapter = new SqlDataAdapter(query, connection);

            connection.Open();
            dadapter.Fill(ds);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = ds.Tables["Table"].Columns["Name"];
            ds.Tables["Table"].PrimaryKey = keyColumns;
        }

        private void populateCourses()
        {
            queryCourse = "select Name, CourseGroupName FROM dbo.Course WHERE FacultyName = '" + TextFieldProgram.Text+ "'";
            connCourse = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
            connectionCourse = new SqlConnection(connCourse);
            dadapterCourse = new SqlDataAdapter(queryCourse, connectionCourse);
            connectionCourse.Open();
            dadapterCourse.Fill(dsCourse);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dsCourse.Tables["Table"].Columns["Name"];
            dsCourse.Tables["Table"].PrimaryKey = keyColumns;
            int maxSize = courseLabel.Location.X + courseLabel.Size.Width + 50;
            if (dsCourse.Tables["Table"].Rows.Count == 0)
            {
                MaterialLabel emptyCourse = new MaterialLabel();
                emptyCourse.AutoSize = true;
                emptyCourse.Depth = 0;
                emptyCourse.Font = new Font("Roboto", 11F);
                emptyCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                emptyCourse.Margin = new Padding(4, 0, 4, 0);
                emptyCourse.MouseState = MaterialSkin.MouseState.HOVER;
                emptyCourse.Text = "There are currently no courses in the database";
                emptyCourse.Location = new Point(courseLabel.Location.X, courseLabel.Location.Y + courseLabel.Size.Height + 10);
                Controls.Add(emptyCourse);
                maxSize = emptyCourse.Location.X + emptyCourse.Size.Width + 100;
            }
            else
            {
                int y = courseLabel.Location.Y + courseLabel.Size.Height + 10;
                boxArray = new CheckBox[dsCourse.Tables["Table"].Rows.Count, 3];
                System.Diagnostics.Debug.WriteLine(boxArray.Length);
                MaterialLabel courseName;
                CheckBox indicatorBoxI;
                CheckBox indicatorBoxR;
                CheckBox indicatorBoxD;
                foreach (DataRow row in dsCourse.Tables["Table"].Rows)
                {
                    courseName = new MaterialLabel();
                    courseName.AutoSize = true;
                    courseName.Depth = 0;
                    courseName.Font = new Font("Roboto", 11F);
                    courseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    courseName.Margin = new Padding(4, 0, 4, 0);
                    courseName.MouseState = MaterialSkin.MouseState.HOVER;
                    courseName.Text = (string)row["Name"];
                    courseName.Location = new Point(courseLabel.Location.X, y);
                    Controls.Add(courseName);
                    if ((courseName.Location.X + courseName.Size.Width) > maxSize)
                    {
                        maxSize = courseName.Location.X + courseName.Size.Width + 30;
                    }
                    y += courseLabel.Size.Height + 10;
                }
                y = courseLabel.Location.Y + courseLabel.Size.Height + 10;
                int i = 0;
                foreach (DataRow row in dsCourse.Tables["Table"].Rows)
                {
                    indicatorBoxI = new CheckBox();
                    indicatorBoxI.AutoSize = true;
                    indicatorBoxI.Location = new Point(maxSize + 36, y);
                    indicatorBoxI.Name = (string)row["Name"] +"_" + (string)row["CourseGroupName"]+ "_I"; 
                    indicatorBoxI.Size = new Size(18, 17);
                    indicatorBoxI.UseVisualStyleBackColor = true;
                    boxArray[i,0] = indicatorBoxI;
                    Controls.Add(indicatorBoxI);

                    indicatorBoxR = new CheckBox();
                    indicatorBoxR.AutoSize = true;
                    indicatorBoxR.Location = new Point(maxSize + 72, y);
                    indicatorBoxR.Name = (string)row["Name"] + "_" + (string)row["CourseGroupName"] + "_R";
                    indicatorBoxR.Size = new Size(18, 17);
                    indicatorBoxR.UseVisualStyleBackColor = true;
                    boxArray[i,1] = indicatorBoxR;
                    Controls.Add(indicatorBoxR);

                    indicatorBoxD = new CheckBox();
                    indicatorBoxD.AutoSize = true;
                    indicatorBoxD.Location = new Point(maxSize + 108, y);
                    indicatorBoxD.Name = (string)row["Name"] + "_" + (string)row["CourseGroupName"] + "_D";
                    indicatorBoxD.Size = new Size(18, 17);
                    indicatorBoxD.UseVisualStyleBackColor = true;
                    boxArray[i++,2] = indicatorBoxD;
                    Controls.Add(indicatorBoxD);

                    y += courseLabel.Size.Height + 10;
                }
                materialLabelI.Location = new Point(maxSize + 36, courseLabel.Location.Y);
                materialLabelR.Location = new Point(maxSize + 72, courseLabel.Location.Y);
                materialLabelD.Location = new Point(maxSize + 108, courseLabel.Location.Y);
                maxSize += 150;
            }
            Size = new Size(maxSize, Size.Width);
        }

        private void saveLevelIndicators()
        {
            queryIndicator = "select * FROM dbo.LearningLevel WHERE PerformanceIndicatorName = '" + indicatorNameField.Text + "' AND FacultyName = '"+ TextFieldProgram.Text + "' AND ProgramLevelName = '" +TextFieldProgramLevel.Text+ "'";
            connIndicator = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
            connectionIndicator = new SqlConnection(connIndicator);
            dadapterIndicator = new SqlDataAdapter(queryIndicator, connectionIndicator);
            connectionIndicator.Open();
            dadapterIndicator.Fill(dsIndicator);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dsCourse.Tables["Table"].Columns["CourseName"];
            dsIndicator.Tables["Table"].PrimaryKey = keyColumns;

            for (int i =0; i< dsCourse.Tables["Table"].Rows.Count; i++)
            {
                if(boxArray[i,0].Checked || boxArray[i, 1].Checked || boxArray[i, 2].Checked)
                {
                    string indicatorValue = "";
                    if(boxArray[i, 0].Checked)
                    {
                        indicatorValue += "I";
                    }
                    if (boxArray[i, 1].Checked)
                    {
                        if (indicatorValue.Equals(""))
                        {
                            indicatorValue += "R";
                        }
                        else
                        {
                            indicatorValue += "/R";
                        }
                    }
                    if (boxArray[i, 2].Checked)
                    {
                        if (indicatorValue.Equals(""))
                        {
                            indicatorValue += "D";
                        }
                        else
                        {
                            indicatorValue += "/D";
                        }
                    }
                    var newRow = dsIndicator.Tables["Table"].NewRow();
                    newRow["Value"] = indicatorValue;
                    newRow["FacultyName"] = TextFieldProgram.Text;
                    newRow["ProgramLevelName"] = TextFieldProgramLevel.Text;
                    newRow["PerformanceIndicatorName"] = indicatorNameField.Text;
                    newRow["CourseGroupName"] = boxArray[i, 0].Name.Split('_')[1];
                    newRow["CourseName"] = boxArray[i, 0].Name.Split('_')[0];

                    dsIndicator.Tables["Table"].Rows.Add(newRow);

                    new SqlCommandBuilder(dadapterIndicator);

                    dadapterIndicator.Update(dsIndicator);
                }
            }
            
        }

        private void fillLevelIndicators()
        {
            queryIndicator = "select * FROM dbo.LearningLevel WHERE PerformanceIndicatorName = '" + indicatorNameField.Text + "' AND FacultyName = '" + TextFieldProgram.Text + "' AND ProgramLevelName = '" + TextFieldProgramLevel.Text + "'";
            connIndicator = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
            connectionIndicator = new SqlConnection(connIndicator);
            dadapterIndicator = new SqlDataAdapter(queryIndicator, connectionIndicator);
            connectionIndicator.Open();
            dadapterIndicator.Fill(dsIndicator);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dsCourse.Tables["Table"].Columns["CourseName"];
            dsIndicator.Tables["Table"].PrimaryKey = keyColumns;

            foreach(DataRow row in dsIndicator.Tables["Table"].Rows)
            {
                if (((string)row["Value"]).Contains('I'))
                {
                    ((CheckBox)Controls.Find(row["CourseName"] + "_" + row["CourseGroupName"] + "_I", true)[0]).Checked = true;
                }
                if (((string)row["Value"]).Contains('R'))
                {
                    ((CheckBox)Controls.Find(row["CourseName"] + "_" + row["CourseGroupName"] + "_R", true)[0]).Checked = true;
                }
                if (((string)row["Value"]).Contains('D'))
                {
                    ((CheckBox)Controls.Find(row["CourseName"] + "_" + row["CourseGroupName"] + "_D", true)[0]).Checked = true;
                }
            }
        }

        private void deleteLevelIndicators()
        {
            foreach (DataRow row in dsIndicator.Tables["Table"].Rows)
            {
                row.Delete();
            }
            new SqlCommandBuilder(dadapterIndicator);
            dadapterIndicator.Update(dsIndicator);
        }

    }
}
