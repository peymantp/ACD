using System.Windows.Forms;

namespace AutomateTool
{
    public partial class ProgramDetails : Form
    {
        public ProgramDetails()
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

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
