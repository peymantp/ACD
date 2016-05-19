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
    public partial class ProgramLevelForm : MaterialForm
    {
        private string currName;
        private string newName;
        private string query;
        private string conn;
        private SqlConnection connection;
        private SqlDataAdapter dadapter;
        private DataSet ds = new DataSet();

        public string getName { get { return newName; } }

        public ProgramLevelForm(string programName)
        {
            InitializeComponent();
            programNameField.Text = programName;
            openConnection();
        }

        public ProgramLevelForm(string programName, string outcomeName)
        {
            InitializeComponent();
            acceptButton.Text = "Edit";
            programNameField.Text = programName;
            outcomeNameField.Text = outcomeName;
            currName = outcomeName;
            openConnection();
            descriptionTextBox.Text = (string)ds.Tables["Table"].Rows.Find(currName)["Description"];
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (outcomeNameField.Text.Equals(""))
            {
                errorProvider1.SetError(outcomeNameField, "Please enter a name");
            }
            else if (outcomeNameField.Text.Length >100) 
            {
                errorProvider1.SetError(outcomeNameField, "Name too long");
            }
            else
            {
                
                if (!(ds.Tables["Table"].Rows.Contains(outcomeNameField.Text)) || (acceptButton.Text.Equals("Edit") && currName.Equals(outcomeNameField.Text)))
                {
                    if (acceptButton.Text.Equals("Edit"))
                    {
                        ds.Tables["Table"].Rows.Find(currName)["Name"] = outcomeNameField.Text;
                        ds.Tables["Table"].Rows.Find(currName)["Description"] = descriptionTextBox.Text;
                    }
                    else
                    {
                        var newRow = ds.Tables["Table"].NewRow();
                        newRow["Name"] = outcomeNameField.Text;
                        newRow["Description"] = descriptionTextBox.Text;
                        newRow["FacultyName"] = programNameField.Text;
                        ds.Tables["Table"].Rows.Add(newRow);
                    }
                    new SqlCommandBuilder(dadapter);
                    dadapter.Update(ds);
                    connection.Close();
                    newName = outcomeNameField.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(outcomeNameField, outcomeNameField.Text + " outcome already exists");
                }
                connection.Close();
            }
        }

        private void openConnection()
        {
            query = "select * FROM ProgramLevel WHERE FacultyName = '" + programNameField.Text + "'";
            conn = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(conn);
            dadapter = new SqlDataAdapter(query, connection);
            connection.Open();
            dadapter.Fill(ds);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = ds.Tables["Table"].Columns["Name"];
            ds.Tables["Table"].PrimaryKey = keyColumns;
        }
    }
}
