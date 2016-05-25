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
/// <summary>
/// Author: Eric Lau, Manish Mallavarapu, Peyman Parsa
/// Last Updated: May/20/2016
/// </summary>
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
        /// <summary>
        /// Creates the course form with specified parameteres for adding
        /// </summary>
        /// <param name="programName"></param>
        /// <param name="courseGroupName"></param>
        public CourseForm(string programName, string courseGroupName)
        {
            InitializeComponent();
            textBoxProgramName.Text = programName;
            textBoxCourseGroup.Text = courseGroupName;
            openConnection();
            populateIndicators();
        }
        /// <summary>
        /// Creates the course form with specified parameters for editing
        /// </summary>
        /// <param name="programName"></param>
        /// <param name="courseGroupName"></param>
        /// <param name="courseName"></param>
        public CourseForm(string programName, string courseGroupName, string courseName)
        {
            InitializeComponent();
            buttonCreate.Text = "Edit";
            //Fills in a portion of the form
            textBoxProgramName.Text = programName;
            textBoxCourseGroup.Text = courseGroupName;
            textBoxCourseName.Text = courseName;
            currName = courseName;
            openConnection();
            //Populates the form dynamically with indicators
            populateIndicators();
            //Fills in the corresponding indicators
            fillIndicators();
            //Fills in the remainder of the form
            textBoxDescription.Text = ds.Tables["Table"].Rows.Find(currName)["Description"].ToString();
            textBoxCreditHours.Text = ds.Tables["Table"].Rows.Find(currName)["CreditHours"].ToString();
            textBoxFormat.Text = ds.Tables["Table"].Rows.Find(currName)["Format"].ToString();
            
            if (ds.Tables["Table"].Rows.Find(currName)["hasLAb"].ToString().Equals("1"))
            {
                checkBoxHasLab.Checked = true;
            }
        }
        /// <summary>
        /// closes form when cancel is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        /// <summary>
        /// Trigger for when create is clicked on course, 
        /// creates a course in database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        //Saves the edited fields
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
                        //Adds a new row to the database with the new course information
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
                    //Updates database
                    dadapter.Update(ds);
                    //Saves checked indicators
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
        /// <summary>
        /// opens a connection to the database 
        /// </summary>
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
        /// <summary>
        /// gets info from database and populates the indicators 
        /// </summary>
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
            int maxSize = indicatorLabel.Location.X + indicatorLabel.Size.Width + 50;
            //Notifies there are no indicators if indicator table is empty
            if (dsCourse.Tables["Table"].Rows.Count == 0)
            {
                MaterialLabel emptyIndictor = new MaterialLabel();
                emptyIndictor.AutoSize = true;
                emptyIndictor.Depth = 0;
                emptyIndictor.Font = new Font("Roboto", 11F);
                emptyIndictor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                emptyIndictor.Margin = new Padding(4, 0, 4, 0);
                emptyIndictor.MouseState = MaterialSkin.MouseState.HOVER;
                emptyIndictor.Text = "There are currently no indicators in the database";
                emptyIndictor.Location = new Point(indicatorLabel.Location.X, indicatorLabel.Location.Y + indicatorLabel.Size.Height + 10);
                Controls.Add(emptyIndictor);
                maxSize = emptyIndictor.Location.X + emptyIndictor.Size.Width + 100;
            }
            else
            {
                int y = indicatorLabel.Location.Y + indicatorLabel.Size.Height + 10;
                boxArray = new CheckBox[dsCourse.Tables["Table"].Rows.Count , 3];
                System.Diagnostics.Debug.WriteLine(boxArray.Length);
                MaterialLabel indicatorName;
                CheckBox indicatorBoxI;
                CheckBox indicatorBoxR;
                CheckBox indicatorBoxD;
                //Adds in course names
                foreach (DataRow row in dsCourse.Tables["Table"].Rows)
                {
                    indicatorName = new MaterialLabel();
                    indicatorName.AutoSize = true;
                    indicatorName.Depth = 0;
                    indicatorName.Font = new Font("Roboto", 11F);
                    indicatorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    indicatorName.Margin = new Padding(4, 0, 4, 0);
                    indicatorName.MouseState = MaterialSkin.MouseState.HOVER;
                    indicatorName.Text = (string)row["Name"];
                    indicatorName.Location = new Point(indicatorLabel.Location.X, y);
                    Controls.Add(indicatorName);
                    if ((indicatorName.Location.X + indicatorName.Size.Width) > maxSize)
                    {
                        maxSize = indicatorName.Location.X + indicatorName.Size.Width + 30;
                    }
                    y += indicatorLabel.Size.Height + 10;
                }
                y = indicatorLabel.Location.Y + indicatorLabel.Size.Height + 10;
                int i = 0;
                //Adds check boxes for each indicator/course pair for Learning level indicators
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

                    y += indicatorLabel.Size.Height + 10;
                }
                //Sets where the I, R and D Labals are located
                materialLabelI.Location = new Point(maxSize + 36, indicatorLabel.Location.Y);
                materialLabelR.Location = new Point(maxSize + 72, indicatorLabel.Location.Y);
                materialLabelD.Location = new Point(maxSize + 108, indicatorLabel.Location.Y);
                maxSize += 150;
            }
            Size = new Size(maxSize, Size.Width);
        }
        /// <summary>
        /// Creates indicator in database from info on form 
        /// </summary>
        private void saveLevelIndicators()
        {
            //Opens a connection to the LearningLevel tables
            queryIndicator = "select * FROM dbo.LearningLevel WHERE courseName = '" + textBoxCourseName.Text + "' AND FacultyName = '" + textBoxProgramName.Text + "' AND CourseGroupName = '" + textBoxCourseGroup.Text + "'";
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
                //Creates a string for the Learning Level Indicator checkbox results
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
                    //Creates new rows for Learning Level Indicators
                    var newRow = dsIndicator.Tables["Table"].NewRow();
                    newRow["Value"] = indicatorValue;
                    newRow["FacultyName"] = textBoxProgramName.Text;
                    
                    newRow["ProgramLevelName"] = boxArray[i, 0].Name.Split('_')[1];
                    newRow["PerformanceIndicatorName"] = boxArray[i, 0].Name.Split('_')[0];
                    newRow["CourseGroupName"] = textBoxCourseGroup.Text;
                    newRow["CourseName"] = textBoxCourseName.Text;
                    
                    dsIndicator.Tables["Table"].Rows.Add(newRow);

                    new SqlCommandBuilder(dadapterIndicator);
                    //Updates database
                    dadapterIndicator.Update(dsIndicator);
                }
            }
        }
        /// <summary>
        /// Connects to the database and fills the form 
        /// </summary>
        private void fillIndicators()
        {
            //Opens a connection to the Learning Levels table
            queryIndicator = "select * FROM dbo.LearningLevel WHERE courseName = '" + textBoxCourseName.Text + "' AND FacultyName = '" + textBoxProgramName.Text + "' AND CourseGroupName = '" + textBoxCourseGroup.Text + "'";
            connIndicator = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
            connectionIndicator = new SqlConnection(connIndicator);
            dadapterIndicator = new SqlDataAdapter(queryIndicator, connectionIndicator);
            connectionIndicator.Open();
            try
            {
                dadapterIndicator.Fill(dsIndicator);
            }
            catch(Exception e)
            {
                new ErrorDialog("The database encountered an error, please try again later").ShowDialog(); 
            }
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dsCourse.Tables["Table"].Columns["CourseName"];
            dsIndicator.Tables["Table"].PrimaryKey = keyColumns;

            //Sets check boxes to checked for the corresponding indicator and course pair
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
        /// <summary>
        /// deletes indicator from database 
        /// </summary>
        private void deleteIndicators()
        {
            //Deletes Each Row
            foreach (DataRow row in dsIndicator.Tables["Table"].Rows)
            {
                row.Delete();
            }
            new SqlCommandBuilder(dadapterIndicator);
            //Updates changes onto database
            dadapterIndicator.Update(dsIndicator);
        }
    }
}
