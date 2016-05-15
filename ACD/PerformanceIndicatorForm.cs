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
    public partial class PerformanceIndicatorForm : MaterialForm
    {
        public PerformanceIndicatorForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }


}
