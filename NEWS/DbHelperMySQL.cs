using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace NEWS
{
    public class DbHelerMySQL
    {
        public static MySqlCommand cmd;
        public static MySqlConnection con;

        public DbHelerMySQL()
        {
            con = new MySqlConnection("server=101.37.77.246;port=3306;user=root;password=root; database=News;");
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

        //public void addData(SqlData data)
        //{
        //    _sqlConnection.Open();
        //    _command = _sqlConnection.CreateCommand();
        //    _command.CommandText = "INSERT INTO [User] (name,pwd) VALUES (@name,@code)";
        //    _command.Parameters.Add("@name", data.Name);
        //    _command.Parameters.Add("@code", data.Pwd);
        //    _command.ExecuteNonQuery();
        //    _sqlConnection.Close();
        //}

        //public List<SqlData> select()
        //{
        //    List<SqlData> list = new List<SqlData>();
        //    _command = _sqlConnection.CreateCommand();
        //    _sqlConnection.Open();
        //    _command.CommandText = "select * from [user]";
        //    SqlDataReader dataReader = _command.ExecuteReader();
        //    while (dataReader.Read())
        //    {
        //        SqlData data = new SqlData();
        //        data.Id = dataReader["id"].ToString();
        //        data.Name = dataReader["name"].ToString();
        //        data.Pwd = dataReader["pwd"].ToString();
        //        list.Add(data);
        //    }
        //    _sqlConnection.Close();
        //    return list;
        //}

        //public List<SqlData> select(string uname)
        //{
        //    List<SqlData> list = new List<SqlData>();
        //    _command = _sqlConnection.CreateCommand();
        //    _sqlConnection.Open();
        //    _command.CommandText = "select * from dbo.[User] where name like '%" + uname + "%'";
        //    SqlDataReader dataReader = _command.ExecuteReader();
        //    while (dataReader.Read())
        //    {
        //        SqlData data = new SqlData();
        //        data.Id = dataReader["id"].ToString();
        //        data.Name = dataReader["name"].ToString();
        //        data.Pwd = dataReader["pwd"].ToString();
        //        list.Add(data);
        //    }
        //    _sqlConnection.Close();
        //    return list;
        //}

        //public void update(SqlData data)
        //{
        //    _sqlConnection.Open();
        //    _command = _sqlConnection.CreateCommand();
        //    _command.CommandText = "update [user] set name=@name,pwd=@pwd where id=@id";
        //    _command.Parameters.Add("@name", data.Name);
        //    _command.Parameters.Add("@pwd", data.Pwd);
        //    _command.Parameters.Add("@id", data.Id);
        //    _command.ExecuteNonQuery();
        //    _sqlConnection.Close();
        //}

        //public void delete(SqlData data)
        //{
        //    _sqlConnection.Open();
        //    _command = _sqlConnection.CreateCommand();
        //    _command.CommandText = "delete from [user] where id=@id";
        //    _command.Parameters.Add("@id", data.Id);
        //    _command.ExecuteNonQuery();
        //    _sqlConnection.Close();
        //}
    }
}
