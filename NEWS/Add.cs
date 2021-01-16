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
    public partial class Add : Form
    {
        public int i;
        Newsarticle news;
        DbHelerMySQL db = new DbHelerMySQL();
        public Add(int i)
        {
            this.i = i;
            InitializeComponent();
        }
        public Add(int i,Newsarticle news)
        {
            this.news = news;
            this.i = i;
            InitializeComponent();
        }
        private void Add_Load(object sender, EventArgs e)
        {
            List<string> list = db.GetTypeName();
            foreach(var value in list)
            {
                comboBox1.Items.Add(value);
            }
            if (i == 2)
            {
                button1.Text = "修改";
                textBox1.Text = news.Title;
                MessageBox.Show(news.Author);
                textBox2.Text = news.Author;
                comboBox1.SelectedItem = news.Typename;
                richTextBox1.Text = news.Content;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Newsarticle newsarticle = new Newsarticle();
            newsarticle.Title = textBox1.Text;
            //MessageBox.Show(comboBox1.SelectedIndex.ToString());
            //switch (comboBox1.SelectedIndex.ToString())
            //{
            //    case "1":
            //        newsarticle.Typename = "1";
            //        break;
            //    case "体育":
            //        newsarticle.Typename = "2";
            //        break;
            //    case "财经":
            //        newsarticle.Typename = "3";
            //        break;
            //    case "社会":
            //        newsarticle.Typename = "4";
            //        break;
            //    case "教育":
            //        newsarticle.Typename = "5";
            //        break;
            //    case "娱乐":
            //        newsarticle.Typename = "6";
            //        break;
            //    case "军事":
            //        newsarticle.Typename = "7";
            //        break;
            //    default:
            //        MessageBox.Show("请选择分类");
            //        break;
            //}
            newsarticle.Typename = comboBox1.SelectedIndex.ToString();
            newsarticle.Author = textBox2.Text;
            newsarticle.Content = richTextBox1.Text;

            if (i == 2)
            {
                newsarticle.Newid = news.Newid;
                db.UpdateNews(newsarticle);
                
            }
            else
            {
                db.AddNews(newsarticle);
            }
            this.Close();
        }
    }
}
