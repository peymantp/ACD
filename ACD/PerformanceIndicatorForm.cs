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

        private CheckBox[] boxArray;

        public string getName { get { return newName; } }

        public PerformanceIndicatorForm(string programName, string programLevelName)
        {
            InitializeComponent();
            TextFieldProgram.Text = programName;
            TextFieldProgramLevel.Text = programLevelName;
            openConnection();
            populateCourses();
        }

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

            criteria4TextField.Text = ds.Tables["Table"].Rows.Find(currName)["Level4Criteria"].ToString();
            criteria3TextField.Text = ds.Tables["Table"].Rows.Find(currName)["Level3Criteria"].ToString();
            criteria2TextField.Text = ds.Tables["Table"].Rows.Find(currName)["Level2Criteria"].ToString();
            criteria1TextField.Text = ds.Tables["Table"].Rows.Find(currName)["Level1Criteria"].ToString();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
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
                        ds.Tables["Table"].Rows.Find(currName)["Level3Criteria"] = criteria4TextField.Text ;
                        ds.Tables["Table"].Rows.Find(currName)["Level2Criteria"] = criteria3TextField.Text ;
                        ds.Tables["Table"].Rows.Find(currName)["Level4Criteria"] = criteria2TextField.Text ;
                        ds.Tables["Table"].Rows.Find(currName)["Level1Criteria"] = criteria1TextField.Text;
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
            queryCourse = "select Name FROM dbo.Course WHERE FacultyName = '" + TextFieldProgram.Text+ "'";
            connCourse = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
            connectionCourse = new SqlConnection(connCourse);
            dadapterCourse = new SqlDataAdapter(queryCourse, connectionCourse);
            connectionCourse.Open();
            dadapterCourse.Fill(dsCourse);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dsCourse.Tables["Table"].Columns["Name"];
            dsCourse.Tables["Table"].PrimaryKey = keyColumns;
            int maxSize = 0;
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
                boxArray = new CheckBox[dsCourse.Tables["Table"].Rows.Count * 3];
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
                foreach (DataRow row in dsCourse.Tables["Table"].Rows)
                {
                    indicatorBoxI = new CheckBox();
                    indicatorBoxI.AutoSize = true;
                    indicatorBoxI.Location = new Point(maxSize + 36, y);
                    indicatorBoxI.Name = (string)row["Name"] + "I"; 
                    indicatorBoxI.Size = new Size(18, 17);
                    indicatorBoxI.UseVisualStyleBackColor = true;
                    Controls.Add(indicatorBoxI);

                    indicatorBoxR = new CheckBox();
                    indicatorBoxR.AutoSize = true;
                    indicatorBoxR.Location = new Point(maxSize + 72, y);
                    indicatorBoxR.Name = (string)row["Name"] + "r";
                    indicatorBoxR.Size = new Size(18, 17);
                    indicatorBoxR.UseVisualStyleBackColor = true;
                    Controls.Add(indicatorBoxR);

                    indicatorBoxD = new CheckBox();
                    indicatorBoxD.AutoSize = true;
                    indicatorBoxD.Location = new Point(maxSize + 108, y);
                    indicatorBoxD.Name = (string)row["Name"] + "d";
                    indicatorBoxD.Size = new Size(18, 17);
                    indicatorBoxD.UseVisualStyleBackColor = true;
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

    }
}
