using System;
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

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
