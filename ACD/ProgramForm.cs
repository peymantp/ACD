using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ACD
{
    public partial class ProgramForm : MaterialForm
    {
        private string currName;
        public ProgramForm()
        {
            InitializeComponent();
        }
        public ProgramForm(string name)
        {
            InitializeComponent();
            ButtonProgramAdd.Text = "Edit";
            textBoxName.Text = name;
            currName = name;
        }

        private void ButtonProgramAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals(""))
            {
                errorProvider1.SetError(textBoxName, "Please enter a name");
            }
            else if (textBoxName.Text.Length > 100)
            {
                errorProvider1.SetError(textBoxName, "Name too long");
            }
            else
            {
                string query = "select * FROM dbo.Faculty";
                string conn = ConfigurationManager.ConnectionStrings["ACD.Properties.Settings.vaxasDatabaseConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(conn);
                SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dadapter.Fill(ds);
                DataColumn[] keyColumns = new DataColumn[1];
                keyColumns[0] = ds.Tables["Table"].Columns["Name"];
                ds.Tables["Table"].PrimaryKey = keyColumns;
                if (!(ds.Tables["Table"].Rows.Contains(textBoxName.Text)))
                {
                    if (ButtonProgramAdd.Text.Equals("Edit"))
                    {
                        ds.Tables["Table"].Rows.Find(currName)["Name"] = textBoxName.Text;
                    }
                    else
                    {
                        var newRow = ds.Tables["Table"].NewRow();
                        newRow["Name"] = textBoxName.Text;
                        ds.Tables["Table"].Rows.Add(newRow);
                    }
                    new SqlCommandBuilder(dadapter);
                    dadapter.Update(ds);
                    connection.Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {     
                    errorProvider1.SetError(textBoxName, textBoxName.Text + " program already exists");
                }
                connection.Close();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
