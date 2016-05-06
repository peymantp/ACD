using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACD
{
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            CreateCourse();
        }

        private void CreateCourse()
        {
            try
            {
                new Course(textBoxNumber.Text, textBoxCore.Text, textBoxName.Text, textBoxDesc.Text,
                    Double.Parse(textBoxCredHr.Text));
            }
            catch (Exception e)
            {
                if(e is System.FormatException)
                    errorProvider1.SetError(textBoxCredHr, "please enter a number");
                if (string.IsNullOrWhiteSpace(textBoxNumber.Text))
                    errorProvider1.SetError(textBoxNumber, "Please enter a value");
                if (string.IsNullOrWhiteSpace(textBoxCore.Text))
                    errorProvider1.SetError(textBoxCore, "Please enter a value");
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                    errorProvider1.SetError(textBoxName, "Please enter a value");
                if (string.IsNullOrWhiteSpace(textBoxDesc.Text))
                    errorProvider1.SetError(textBoxDesc, "Please enter a value");
                return;
            }
            Close();
        }
    }
}
