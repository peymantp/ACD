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
        private CheckBox[] boxArray;
        private string connCourse;
        private SqlConnection connectionCourse;
        private SqlDataAdapter dadapterCourse;
        private DataSet dsCourse = new DataSet();
        private string queryCourse;

        public CourseForm()
        {
            InitializeComponent();
            populateCourses();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void populateCourses()
        {
            //queryCourse = "select Name FROM dbo.PerformanceIndicator WHERE FacultyName = '" + textBoxName.Text + "'";
            queryCourse = "select Name FROM dbo.PerformanceIndicator WHERE FacultyName = 'Geos'";
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
                    indicatorBoxI.Name = (string)row["Name"] + "_I";
                    indicatorBoxI.Size = new Size(18, 17);
                    indicatorBoxI.UseVisualStyleBackColor = true;
                    boxArray[i++] = indicatorBoxI;
                    Controls.Add(indicatorBoxI);

                    indicatorBoxR = new CheckBox();
                    indicatorBoxR.AutoSize = true;
                    indicatorBoxR.Location = new Point(maxSize + 72, y);
                    indicatorBoxR.Name = (string)row["Name"] + "_R";
                    indicatorBoxR.Size = new Size(18, 17);
                    indicatorBoxR.UseVisualStyleBackColor = true;
                    boxArray[i++] = indicatorBoxR;
                    Controls.Add(indicatorBoxR);

                    indicatorBoxD = new CheckBox();
                    indicatorBoxD.AutoSize = true;
                    indicatorBoxD.Location = new Point(maxSize + 108, y);
                    indicatorBoxD.Name = (string)row["Name"] + "_D";
                    indicatorBoxD.Size = new Size(18, 17);
                    indicatorBoxD.UseVisualStyleBackColor = true;
                    boxArray[i++] = indicatorBoxD;
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
