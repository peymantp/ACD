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
    public partial class MainForm : MaterialForm
    {
        private MaterialSkinManager skinManager;
        private string conn = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
        private SqlConnection connection;
        private string programQuery = "select * FROM dbo.Faculty";
        private SqlDataAdapter programAdapter;
        private DataSet programDs;
        public MainForm()
        {
            
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

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

        private void button1_Click(object sender, EventArgs e) { new ProgramLevelForm().ShowDialog(); }

        private void courseButtonAdd_Click(object sender, EventArgs e) { new CourseForm().ShowDialog(); }

        private void coreButtonAdd_Click(object sender, EventArgs e) { new CourseGroupForm().ShowDialog(); }

        private void programOutcomesButtonAdd_Click(object sender, EventArgs e) { new ProgramOutcomeForm().ShowDialog(); }

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
    }
}
