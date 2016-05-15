using System;
using System.Collections.Generic;
using System.Configuration;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;

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
            pullData();
        }

        private void pullData()
        {
            /*
             * Course
            [CourseNumber]  VARCHAR (10)  NOT NULL,
            [Core]          VARCHAR (50)  NOT NULL,
            [CourseName]    VARCHAR (50)  NOT NULL,
            [Description]   VARCHAR (MAX) NOT NULL,
            [CreditHours]   FLOAT (53)    NOT NULL,
            [Format]        VARCHAR (50)  NULL,
            [Prerequisites] VARCHAR (250) NULL,
            [hasLab]        INT           NULL,
            CONSTRAINT [pk_Course] PRIMARY KEY CLUSTERED ([CourseNumber] ASC, [Core] ASC)
            
            using (SqlConnection myConnection = new SqlConnection("Server = tcp:vaxas.database.windows.net,1433; Database = vaxasDatabase; User ID = vaxasAdmin@vaxas; Password = Study1327; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30"))
            {
                myConnection.Open();
                string oString = "select * from dbo.Course";
                SqlCommand CourseCmd = new SqlCommand(oString, myConnection);
                using (SqlDataReader courseReader = CourseCmd.ExecuteReader())
                {
                    while (courseReader.Read())
                    {
                        string CourseNumber = (string)courseReader["CourseNumber"];
                        string Core = (string)courseReader["Core"];
                        string CourseName = (string)courseReader["CourseName"];
                        //string Description = (string)courseReader["Description"];
                        string Description = "descrption dowant work";
                        double CreditHours = (double)courseReader["CreditHours"];
                        //string Format= (string)courseReader["Format"];
                        //string Prerequisites= (string)courseReader["Prerequisites"];
                        //boll hasLab= (int)courseReader["hasLab"];
                        coursesList.Add(new Course(CourseNumber,Core,CourseName,Description,CreditHours));
                    }
                }
            }
            */
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vaxasDatabaseDataSet.PerformanceIndicator' table. You can move, or remove it, as needed.
            //this.performanceIndicatorTableAdapter.Fill(this.vaxasDatabaseDataSet.PerformanceIndicator);
            // TODO: This line of code loads data into the 'vaxasDatabaseDataSet.Course' table. You can move, or remove it, as needed.
            //this.courseTableAdapter.Fill(this.vaxasDatabaseDataSet.Course);
            connection = new SqlConnection(conn);
            programAdapter = new SqlDataAdapter(programQuery, connection);
            programDs = new DataSet();
            programAdapter.Fill(programDs);
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = programDs.Tables["Table"].Columns["Name"];
            programDs.Tables["Table"].PrimaryKey = keyColumns;
            comboBoxProgram.Items.Insert(0, "Select a Program");
            comboBoxProgram.SelectedIndex = 0;

            foreach(DataRow r in programDs.Tables["Table"].Rows)
            {
                comboBoxProgram.Items.Add(r["Name"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ProgramLevelForm().Show();
        }

        private void courseButtonAdd_Click(object sender, EventArgs e) => new CourseForm().ShowDialog();

        private void coreButtonAdd_Click(object sender, EventArgs e) => new CourseGroupForm().ShowDialog();

        private void programOutcomesButtonAdd_Click(object sender, EventArgs e) => new ProgramOutcomeForm().ShowDialog(); 

<<<<<<< HEAD
        private void ButtonProgramAdd_Click(object sender, EventArgs e) => new ProgramForm().ShowDialog();
=======
        private void ButtonProgramAdd_Click(object sender, EventArgs e)
        {
            var result = new ProgramForm().ShowDialog();
            if (System.Windows.Forms.DialogResult.OK == result)
            {
                comboBoxProgram.Items.Clear();
                comboBoxProgram.Items.Insert(0, "Select a Program");
                comboBoxProgram.SelectedIndex = 0;
                programDs.Clear();
                programAdapter.Fill(programDs);
                foreach (DataRow r in programDs.Tables["Table"].Rows)
                {
                    comboBoxProgram.Items.Add(r["Name"]);
                }
            }
        }
>>>>>>> 4922923facba1c0abb063fb3cc5821a64c1fb14a

        private void ButtonProgramDelete_Click(object sender, EventArgs e)
        {
            if(!comboBoxProgram.Text.Equals("Select a Program"))
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
                    comboBoxProgram.Items.Insert(0, "Select a Program");
                    comboBoxProgram.SelectedIndex = 0;

                    foreach (DataRow r in programDs.Tables["Table"].Rows)
                    {
                        comboBoxProgram.Items.Add(r["Name"]);
                    }
                }
            }
        }

        private void ButtonProgramEdit_Click(object sender, EventArgs e)
        {
            if (!comboBoxProgram.Text.Equals("Select a Program"))
            {
                var result = new ProgramForm((string)comboBoxProgram.SelectedItem).ShowDialog();
                if (System.Windows.Forms.DialogResult.OK == result)
                {
                    comboBoxProgram.Items.Clear();
                    comboBoxProgram.Items.Insert(0, "Select a Program");
                    comboBoxProgram.SelectedIndex = 0;
                    programDs.Clear();
                    programAdapter.Fill(programDs);
                    foreach (DataRow r in programDs.Tables["Table"].Rows)
                    {
                        comboBoxProgram.Items.Add(r["Name"]);
                    }
                }
            }
        }
    }
}
