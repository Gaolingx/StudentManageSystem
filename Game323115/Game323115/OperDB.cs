using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Game323115
{
    class OperDB
    {
        static MySqlConnection conn = null;
        static MySqlCommand cmd = null;
        static MySqlDataReader dr = null;
        static string strConn = ConfigurationSettings.AppSettings["constring"];
        public static MySqlDataReader QuerySQL(string sql)
        {

            string strConn = "server=localhost;database=student;uid=root;password=Gao123456";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public static int EditSQL(string sql)
        {
            string strConn = "server=localhost;database=student;uid=root;password=Gao123456";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }
        public static void BindBata(string sql, DataGridView dg)
        {
            string strConn = "server=localhost;database=student;uid=root;password=Gao123456";
            conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlDataAdapter ada = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            // dg.AutoGenerateColumns = false;
            dg.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
