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

namespace ACD
{
    public partial class CourseGroupForm : MaterialForm
    {
        public CourseGroupForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}
