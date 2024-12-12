using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Game323115
{
    public partial class zhmm : Form
    {
        public zhmm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            string birthday = this.dateTimePicker1.Text;

            DateTime date = DateTime.Parse(birthday);
            string formattedDate = date.ToString("yyyy-MM-dd");

            if (name == "" || birthday == "")
            {
                MessageBox.Show("空的！重来！");
                return;
            }
            string sql = "select * from stuinfo2 where 姓名='" + name + "' and 出生日期='" + date + "'";
            MySqlDataReader dr = OperDB.QuerySQL(sql);
            if (dr.Read())
            {
                MessageBox.Show(dr["密码"].ToString());
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 lg = new Form1();
            lg.Show();
            this.Hide();
        }
    }
}
