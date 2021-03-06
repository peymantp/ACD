﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
/// <summary>
/// Author: Eric Lau 
/// Last Updated: May/16/2016
/// </summary>
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
            errorBox.Font = new Font("Tahoma", 15, FontStyle.Bold);
            errorBox.Text = msg;
        }
        /// <summary>
        /// CLoses Error dialog when OK is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
