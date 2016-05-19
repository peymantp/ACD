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
            if (!sender_.Text.Equals("Edit", StringComparison.InvariantCultureIgnoreCase))
            {
                
            }
            else
            {

            }
        }
    }


}
