﻿using System;
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


        public string getName { get { return newName; } }

        public PerformanceIndicatorForm(string programName, string programLevelName)
        {
            InitializeComponent();
            TextFieldProgram.Text = programName;
            TextFieldProgramLevel.Text = programLevelName;
            openConnection();
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
    }
}
