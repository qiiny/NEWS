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
    public partial class Login : Form
    {
        DbHelerMySQL db = new DbHelerMySQL();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "" && password == "")
            {
                MessageBox.Show("请输入用户名或密码");
            }
            else
            {
                int i=db.Login(username, password);
                if (i == 1)
                {
                    MessageBox.Show("登录成功"+i);
                }
                else
                {
                    MessageBox.Show("jhkjh");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
