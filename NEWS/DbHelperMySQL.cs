using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace NEWS
{
    public class DbHelerMySQL
    {
        public static MySqlCommand cmd;
        public static MySqlConnection con;

        public DbHelerMySQL()
        {
            con = new MySqlConnection("server=101.37.77.246;port=3306;user=root;password=root; database=News;Charset=utf8");
        }

        public string select()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from tb_admin";
            MySqlDataReader dataReader = cmd.ExecuteReader();
            string r="";
            while (dataReader.Read())
            {
                
                string q = dataReader[0].ToString();
                string w = dataReader[1].ToString();
                string e = dataReader[2].ToString();
                r =  q + w + e;
            }
            con.Close();
            return r;
        }

        public List<string> GetTypeName()
        {
            List<string> list = new List<string>();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT TypeName FROM newstype;";
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                list.Add(dataReader[0].ToString());
            }
            con.Close();
            return list;
        }

        public int Login(string username, string password)
        {
            con.Open();
            string sql = "SELECT COUNT(*) FROM tb_admin where name='"+username+"' and pass='"+password+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int count = Convert.ToInt32(dt.Rows[0][0]);
            con.Close();
            return count;
        }

        public DataSet GetNewsList(int v)
        {
            string sql;
            if (v == 0)
            {
                 sql= "SELECT newsid,newstype.TypeName,title,content,author,addtime,temp FROM tb_newsarticle,newstype WHERE tb_newsarticle.type=newstype.TypeId";
            }
            else
            {
                sql = "SELECT newsid,newstype.TypeName,title,content,author,addtime,temp FROM tb_newsarticle,newstype WHERE tb_newsarticle.type=newstype.TypeId and newstype.TypeId="+v;
            }
            
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            con.Close();
            return dataSet;
        }

        public void AddNews(Newsarticle newsarticle)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into tb_newsarticle(type,title,content,author,addtime) values(@type,@title,@content,@author,now())";
            cmd.Parameters.AddWithValue("@type", newsarticle.Typename);
            cmd.Parameters.AddWithValue("@title", newsarticle.Title);
            cmd.Parameters.AddWithValue("@content", newsarticle.Content);
            cmd.Parameters.AddWithValue("@author", newsarticle.Author);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateNews(Newsarticle newsarticle)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update tb_newsarticle set type=@typename,title=@title,content=@content,author=@author,addtime=now() where newsid=@newsid";
            cmd.Parameters.AddWithValue("@typename", newsarticle.Typename);
            cmd.Parameters.AddWithValue("@title", newsarticle.Title);
            cmd.Parameters.AddWithValue("@content", newsarticle.Content);
            cmd.Parameters.AddWithValue("@author", newsarticle.Author);
            cmd.Parameters.AddWithValue("@newsid", newsarticle.Newid);
            cmd.ExecuteNonQuery();
            con.Close();
        }

  
    }
}
