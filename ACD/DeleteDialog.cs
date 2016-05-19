using MaterialSkin;
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
    public partial class DeleteDialog : MaterialForm
    {
        public DeleteDialog(string name)
        {
            InitializeComponent();
            labelWarning.ForeColor = Color.Red;
            labelWarning.Font = new Font("Tahoma", 15, FontStyle.Bold);
            warningBox.Font = new Font("Tahoma", 15, FontStyle.Bold);
            warningBox.Text += " Are you sure you want to delete " + name + "?";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
