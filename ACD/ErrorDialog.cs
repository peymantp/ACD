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
    /// <summary>
    /// This form is used to diplay errors in a way
    /// that match the design of the rest of the program
    /// </summary>
    public partial class ErrorDialog : MaterialForm
    {
        /// <summary>
        /// ctor for form
        /// </summary>
        /// <param name="msg">The error that will be displayed</param>
        public ErrorDialog(string msg)
        {
            InitializeComponent();
            warningBox.Text = msg;
        }
    }
}
