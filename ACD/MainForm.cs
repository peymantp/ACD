﻿using System;
using System.Collections.Generic;
using MaterialSkin.Controls;
using MaterialSkin;

namespace ACD
{
    public partial class MainForm : MaterialForm
    {
        //#510104
        List<Course> coursesList = new List<Course>();
        private MaterialSkinManager skinManager; 
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

        private void button5_Click(object sender, EventArgs e) => new CourseForm().Show();

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vaxasDatabaseDataSet.PerformanceIndicator' table. You can move, or remove it, as needed.
            this.performanceIndicatorTableAdapter.Fill(this.vaxasDatabaseDataSet.PerformanceIndicator);
            // TODO: This line of code loads data into the 'vaxasDatabaseDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.vaxasDatabaseDataSet.Course);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ProgramLevelForm().Show();
        }
    }
}
