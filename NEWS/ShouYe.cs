using System;
using System.Windows.Forms;

namespace NEWS
{
    public partial class ShouYe : Form
    {
        public ShouYe()
        {
            InitializeComponent();
        }
        private void ShouYe_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Application.StartupPath + @"/Skins/mp10.ssk";
            string s=new DbHelerMySQL().select();
            richTextBoxTM1.Text = s;
            pictureBox1.Load(Application.StartupPath + @"\images\55-1Q212145911R3.jpg");
        }
    }
}
