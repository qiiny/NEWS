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
    public partial class Admin : Form
    {

        DbHelerMySQL db = new DbHelerMySQL();
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add a = new Add(1,null);
            DialogResult dialogResult = a.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
            {
                DataSet adapter = db.GetNewsList(0);
                dataGridView1.DataSource = adapter.Tables[0];
                dataGridView1.ClearSelection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dataselect = this.dataGridView1.SelectedRows;
            Newsarticle news = new Newsarticle();
            //判断是否选中数据
            if (dataselect.Count > 0)
            {
                //遍历选中的数据
                foreach (DataGridViewRow row in dataselect)
                {
                    ////colunm命名为name的值
                    //String name2 = Convert.ToString(row.Cells["name"].Value);
                    ////colunm命名为name的值
                    //String code2 = Convert.ToString(row.Cells["code"].Value);
                    ////第一列数据的值
                    //String value0 = Convert.ToString(row.Cells[0].Value);
                    ////第二列数据的值转为int类型
                    //int value1 = Convert.ToInt32(row.Cells[1].Value.ToString());
                    news.Newid = Convert.ToInt32(row.Cells[0].Value);
                    news.Title = row.Cells[2].Value.ToString();
                    news.Typename = row.Cells[1].Value.ToString();
                    news.Content = row.Cells[3].Value.ToString();
                    news.Author = row.Cells[4].Value.ToString();
                }
                Add a = new Add(2, news);
                DialogResult dialogResult = a.ShowDialog();
                if (dialogResult == DialogResult.Cancel)
                {
                    DataSet adapter = db.GetNewsList(0);
                    dataGridView1.DataSource = adapter.Tables[0];
                    dataGridView1.ClearSelection();
                }
                
                    
            }
            else
            {
                MessageBox.Show("请选择要修改的内容");
            }
            

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Application.StartupPath + @"/Skins/mp10.ssk";
            DataSet adapter = db.GetNewsList(0);
            dataGridView1.DataSource = adapter.Tables[0];
            dataGridView1.ClearSelection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new ListNews().Show();
        }
    }
}
