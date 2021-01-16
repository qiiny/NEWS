using MySql.Data.MySqlClient;
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
    public partial class ListNews : Form
    {
        public DbHelerMySQL db = new DbHelerMySQL();
        public ListNews()
        {
            InitializeComponent();
        }

        private void ListNews_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Application.StartupPath + @"/Skins/mp10.ssk";
            DataSet adapter = db.GetNewsList(0);
            dataGridView1.DataSource = adapter.Tables[0];
        }

        private void ListNews_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(new Pen(Color.Black),156, 0, 156, 630);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet adapter = db.GetNewsList(2);
            dataGridView1.DataSource = adapter.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet adapter = db.GetNewsList(3);
            dataGridView1.DataSource = adapter.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new ShouYe().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet adapter = db.GetNewsList(4);
            dataGridView1.DataSource = adapter.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet adapter = db.GetNewsList(5);
            dataGridView1.DataSource = adapter.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet adapter = db.GetNewsList(6);
            dataGridView1.DataSource = adapter.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataSet adapter = db.GetNewsList(7);
            dataGridView1.DataSource = adapter.Tables[0];
        }
    }
}
