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
    public partial class CourseGroupForm : MaterialForm
    {
        private string currName;
        private string newName;
        private string query;
        private string conn;
        private SqlConnection connection;
        private SqlDataAdapter dadapter;
        private DataSet ds = new DataSet();

        public string getName { get { return newName; } }

        public CourseGroupForm(string programName)
        {
            InitializeComponent();
            programNameField.Text = programName;
            openConnection();
        }

        public CourseGroupForm(string programName, string courseGroupName)
        {
            InitializeComponent();
            acceptButton.Text = "Edit";
            programNameField.Text = programName;
            courseGroupNameField.Text = courseGroupName;
            currName = courseGroupName;
            openConnection();
            electiveField.Text = ds.Tables["Table"].Rows.Find(currName)["NumberOfElectives"].ToString();
        }

        private void openConnection()
        {
            query = "select * FROM CourseGroup WHERE FacultyName = '" + programNameField.Text + "'";
            conn = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(conn);
            dadapter = new SqlDataAdapter(query, connection);
            connection.Open();
            dadapter.Fill(ds);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = ds.Tables["Table"].Columns["Name"];
            ds.Tables["Table"].PrimaryKey = keyColumns;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (courseGroupNameField.Text.Equals(""))
            {
                errorProvider1.SetError(courseGroupNameField, "Please enter a name");
            }
            else if (courseGroupNameField.Text.Length > 100)
            {
                errorProvider1.SetError(courseGroupNameField, "Name too long");
            }
            else
            {
                int n;
                if (int.TryParse(electiveField.Text, out n) && n >= 0) {
                    if (!(ds.Tables["Table"].Rows.Contains(courseGroupNameField.Text)) || (acceptButton.Text.Equals("Edit") && currName.Equals(courseGroupNameField.Text)))
                    {
                        if (acceptButton.Text.Equals("Edit"))
                        {
                            ds.Tables["Table"].Rows.Find(currName)["Name"] = courseGroupNameField.Text;
                            ds.Tables["Table"].Rows.Find(currName)["NumberOfElectives"] = n;
                        }
                        else
                        {
                            var newRow = ds.Tables["Table"].NewRow();
                            newRow["Name"] = courseGroupNameField.Text;
                            newRow["NumberOfElectives"] = electiveField.Text;
                            newRow["FacultyName"] = programNameField.Text;
                            ds.Tables["Table"].Rows.Add(newRow);
                        }
                        new SqlCommandBuilder(dadapter);
                        dadapter.Update(ds);
                        connection.Close();
                        newName = courseGroupNameField.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(courseGroupNameField, courseGroupNameField.Text + " group already exists");
                    }
                    connection.Close();
                }else
                {
                    errorProvider1.SetError(electiveField, "Please enter a number above 0");
                }
            }
        }
    }
}
