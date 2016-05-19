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
        private Button sender_; 
        private SqlConnection connection;
        private SqlDataAdapter dadapter;
        private DataSet ds = new DataSet();

        public PerformanceIndicatorForm(Button sender)
        {
            InitializeComponent();
            sender_ = sender;
            FormCollection fc = Application.OpenForms;
            MainForm mf = (MainForm)fc[0];
            TextFieldProgram.Text = mf.programText;
            TextFieldLearningLevel.Text = mf.programLevelOutcome;
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!(ds.Tables["Table"].Rows.Contains(indicatorName.Text)) || (sender_.Text.Equals("Edit") && currName.Equals(indicatorName.Text)))
            {
                if (sender_.Text.Equals("Edit"))
                {
                    ds.Tables["Table"].Rows.Find(currName)["Name"] = indicatorName.Text;
                }
                else
                {
                    var newRow = ds.Tables["Table"].NewRow();
                    newRow["Name"] = indicatorName.Text;
                    ds.Tables["Table"].Rows.Add(newRow);
                }
                new SqlCommandBuilder(dadapter);
                dadapter.Update(ds);
                connection.Close();
                newName = indicatorName.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                errorProvider1.SetError(indicatorName, indicatorName.Text + " indicator already exists");
            }
            connection.Close();
        }
        private void openConnection()
        {
            query = "select * FROM dbo.Faculty";
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
