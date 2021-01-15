using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string s=new DbHelerMySQL().select();
            richTextBoxTM1.Text = s;
        }
    }
}
