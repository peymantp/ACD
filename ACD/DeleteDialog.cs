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
/// <summary>
/// Author: Eric Lau, Manish Mallavarapu 
/// Last Updated: May/19/2016s
/// </summary>
namespace ACD
{
    public partial class DeleteDialog : MaterialForm
    {
        /// <summary>
        /// Constructor, creates delete dialog 
        /// with specified message
        /// </summary>
        /// <param name="name"></param>
        public DeleteDialog(string name)
        {
            InitializeComponent();
            labelWarning.Font = new Font("Tahoma", 15, FontStyle.Bold);
            warningBox.Font = new Font("Tahoma", 15, FontStyle.Bold);
            warningBox.Text += " Are you sure you want to delete " + name + "?";
        }
        /// <summary>
        /// when delete is clicked, deletes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// If cancel is clicked, closes form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
