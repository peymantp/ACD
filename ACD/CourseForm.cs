using MaterialSkin.Controls;
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
    public partial class CourseForm : MaterialForm
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
           
        }
    }
}
