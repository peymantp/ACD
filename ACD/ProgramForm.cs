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
    /// <summary>
    /// Program form provides the functionality to edit and add
    /// programs to the database
    /// </summary>
    public partial class ProgramForm : MaterialForm
    {
        private string currName;
        private string newName;

        private string query;
        private string conn;
        private SqlConnection connection;
        private SqlDataAdapter dadapter;
        private DataSet ds = new DataSet();

        public string getName { get { return newName; } }

        public ProgramForm()
        {
            InitializeComponent();
            openConnection();
        }
        public ProgramForm(string name)
        {
            InitializeComponent();
            ButtonProgramAdd.Text = "Edit";
            textBoxName.Text = name;
            currName = name;
            openConnection();
        }

        private void ButtonProgramAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
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
                if (!(ds.Tables["Table"].Rows.Contains(textBoxName.Text)) || (ButtonProgramAdd.Text.Equals("Edit") && currName.Equals(textBoxName.Text)))
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
                    newName = textBoxName.Text;
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
        /// <summary>
        /// Exits the Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
