using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACD
{
    public partial class CourseForm : MaterialForm
    {
        private string currName;
        private string newName;

        private CheckBox[,] boxArray;
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

        public string getName { get { return newName; } }

        public CourseForm(string programName, string courseGroupName)
        {
            InitializeComponent();
            textBoxProgramName.Text = programName;
            textBoxCourseGroup.Text = courseGroupName;
            openConnection();
            populateIndicators();
        }

        public CourseForm(string programName, string courseGroupName, string courseName)
        {
            InitializeComponent();
            buttonCreate.Text = "Edit";
            textBoxProgramName.Text = programName;
            textBoxCourseGroup.Text = courseGroupName;
            textBoxCourseName.Text = courseName;
            currName = courseName;
            openConnection();
            populateIndicators();
            fillIndicators();
            
            textBoxDescription.Text = ds.Tables["Table"].Rows.Find(currName)["Description"].ToString();
            textBoxCreditHours.Text = ds.Tables["Table"].Rows.Find(currName)["CreditHours"].ToString();
            textBoxFormat.Text = ds.Tables["Table"].Rows.Find(currName)["Format"].ToString();
            
            if (ds.Tables["Table"].Rows.Find(currName)["hasLAb"].ToString().Equals("1"))
            {
                checkBoxHasLab.Checked = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBoxCourseName.Text.Equals(""))
            {
                errorProvider1.SetError(textBoxCourseName, "Please enter a name");
            }
            else if (textBoxCourseName.Text.Length > 100)
            {
                errorProvider1.SetError(textBoxCourseName, "Name too long");
            }
            else
            {
                if (!(ds.Tables["Table"].Rows.Contains(textBoxCourseName.Text)) || (buttonCreate.Text.Equals("Edit") && currName.Equals(textBoxCourseName.Text)))
                {
                    if (buttonCreate.Text.Equals("Edit"))
                    {
                        ds.Tables["Table"].Rows.Find(currName)["Name"] = textBoxCourseName.Text;
                        currName = textBoxCourseName.Text;
                        ds.Tables["Table"].Rows.Find(currName)["Description"] = textBoxDescription.Text;
                        if (!textBoxCreditHours.Text.Equals(""))
                            ds.Tables["Table"].Rows.Find(currName)["CreditHours"] = double.Parse(textBoxCreditHours.Text);
                        else
                            ds.Tables["Table"].Rows.Find(currName)["CreditHours"] = DBNull.Value;
                        ds.Tables["Table"].Rows.Find(currName)["Format"] = textBoxFormat.Text;
                        if (checkBoxHasLab.Checked == true)
                        {
                            ds.Tables["Table"].Rows.Find(currName)["hasLab"] = 1;
                        }
                        else
                        {
                            ds.Tables["Table"].Rows.Find(currName)["hasLab"] = 0;
                        }
                        deleteIndicators();
                    }
                    else
                    {
                        var newRow = ds.Tables["Table"].NewRow();
                        newRow["Name"] = textBoxCourseName.Text;
                        newRow["FacultyName"] = textBoxProgramName.Text;
                        newRow["CourseGroupName"] = textBoxCourseGroup.Text;
                        newRow["Description"] = textBoxDescription.Text;
                        if(!textBoxCreditHours.Text.Equals(""))
                            newRow["CreditHours"] = double.Parse(textBoxCreditHours.Text);
                        else
                            newRow["CreditHours"] = DBNull.Value;
                        newRow["Format"] = textBoxFormat.Text;
                        if (checkBoxHasLab.Checked == true)
                        {
                            newRow["hasLab"] = 1;
                        }
                        else
                        {
                            newRow["hasLab"] = 0;
                        }

                        ds.Tables["Table"].Rows.Add(newRow);
                    }

                    new SqlCommandBuilder(dadapter);

                    dadapter.Update(ds);
                    saveLevelIndicators();
                    connection.Close();
                    newName = textBoxCourseName.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(textBoxCourseName, textBoxCourseName.Text + " indicator already exists");
                }
                connection.Close();
            }
        }

        private void openConnection()
        {
            query = "select * FROM dbo.Course";
            conn = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(conn);
            dadapter = new SqlDataAdapter(query, connection);

            connection.Open();
            dadapter.Fill(ds);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = ds.Tables["Table"].Columns["Name"];
            ds.Tables["Table"].PrimaryKey = keyColumns;
        }

        private void populateIndicators()
        {
            queryCourse = "select Name, ProgramLevelName FROM dbo.PerformanceIndicator WHERE FacultyName = '"+ textBoxProgramName.Text +"'";
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
                boxArray = new CheckBox[dsCourse.Tables["Table"].Rows.Count , 3];
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
                    indicatorBoxI.Name = (string)row["Name"] + "_" + (string)row["ProgramLevelName"] + "_I";
                    indicatorBoxI.Size = new Size(18, 17);
                    indicatorBoxI.UseVisualStyleBackColor = true;
                    boxArray[i,0] = indicatorBoxI;
                    Controls.Add(indicatorBoxI);

                    indicatorBoxR = new CheckBox();
                    indicatorBoxR.AutoSize = true;
                    indicatorBoxR.Location = new Point(maxSize + 72, y);
                    indicatorBoxR.Name = (string)row["Name"] + "_" + (string)row["ProgramLevelName"] + "_R";
                    indicatorBoxR.Size = new Size(18, 17);
                    indicatorBoxR.UseVisualStyleBackColor = true;
                    boxArray[i,1] = indicatorBoxR;
                    Controls.Add(indicatorBoxR);

                    indicatorBoxD = new CheckBox();
                    indicatorBoxD.AutoSize = true;
                    indicatorBoxD.Location = new Point(maxSize + 108, y);
                    indicatorBoxD.Name = (string)row["Name"] + "_" + (string)row["ProgramLevelName"] + "_D";
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
            queryIndicator = "select * FROM dbo.LearningLevel WHERE courseName = '" + textBoxCourseName.Text + "' AND FacultyNameCourse = '" + textBoxProgramName.Text + "' AND CourseGroupName = '" + textBoxCourseGroup.Text + "'";
            connIndicator = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
            connectionIndicator = new SqlConnection(connIndicator);
            dadapterIndicator = new SqlDataAdapter(queryIndicator, connectionIndicator);
            connectionIndicator.Open();
            dadapterIndicator.Fill(dsIndicator);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dsCourse.Tables["Table"].Columns["PerfornamceIndicatorName"];
            dsIndicator.Tables["Table"].PrimaryKey = keyColumns;

            for (int i = 0; i < dsCourse.Tables["Table"].Rows.Count; i++)
            {
                if (boxArray[i, 0].Checked || boxArray[i, 1].Checked || boxArray[i, 2].Checked)
                {
                    string indicatorValue = "";
                    if (boxArray[i, 0].Checked)
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
                    newRow["FacultyNameIndicator"] = textBoxProgramName.Text;
                    newRow["FacultyNameCourse"] = textBoxProgramName.Text;
                    
                    newRow["ProgramLevelName"] = boxArray[i, 0].Name.Split('_')[1];
                    newRow["PerformanceIndicatorName"] = boxArray[i, 0].Name.Split('_')[0];
                    newRow["CourseGroupName"] = textBoxCourseGroup.Text;
                    newRow["CourseName"] = textBoxCourseName.Text;
                    
                    dsIndicator.Tables["Table"].Rows.Add(newRow);

                    new SqlCommandBuilder(dadapterIndicator);

                    dadapterIndicator.Update(dsIndicator);
                }
            }
        }

        private void fillIndicators()
        {
            queryIndicator = "select * FROM dbo.LearningLevel WHERE courseName = '" + textBoxCourseName.Text + "' AND FacultyName = '" + textBoxProgramName.Text + "' AND CourseGroupName = '" + textBoxCourseGroup.Text + "'";
            connIndicator = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
            connectionIndicator = new SqlConnection(connIndicator);
            dadapterIndicator = new SqlDataAdapter(queryIndicator, connectionIndicator);
            connectionIndicator.Open();
            dadapterIndicator.Fill(dsIndicator);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dsCourse.Tables["Table"].Columns["CourseName"];
            dsIndicator.Tables["Table"].PrimaryKey = keyColumns;

            foreach (DataRow row in dsIndicator.Tables["Table"].Rows)
            {
                if (((string)row["Value"]).Contains('I'))
                {
                    ((CheckBox)Controls.Find(row["PerformanceIndicatorName"] + "_" + row["ProgramLevelName"] + "_I", true)[0]).Checked = true;
                }
                if (((string)row["Value"]).Contains('R'))
                {
                    ((CheckBox)Controls.Find(row["PerformanceIndicatorName"] + "_" + row["ProgramLevelName"] + "_R", true)[0]).Checked = true;
                }
                if (((string)row["Value"]).Contains('D'))
                {
                    ((CheckBox)Controls.Find(row["PerformanceIndicatorName"] + "_" + row["ProgramLevelName"] + "_D", true)[0]).Checked = true;
                }
            }
        }

        private void deleteIndicators()
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
