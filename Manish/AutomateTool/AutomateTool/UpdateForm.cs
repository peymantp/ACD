using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomateTool
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        public void addList()
        {
            listBox1.Items.Add("FSM");
            listBox1.Items.Add("PHY");
            listBox1.Items.Add("HIS");
            listBox1.Items.Add("MIN");
        }
    }
}
