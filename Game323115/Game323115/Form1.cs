using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Game323115
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count >= 2)
            {
                button1.Enabled = false;
            }
            string name = this.textBox1.Text;
            string pass = this.textBox2.Text;
            if ((name == "" || pass == ""))
            {

                MessageBox.Show("用户名或密码不能为空");
                return;
            }
            string sql = "select * from stuinfo2 where 姓名='" + name + "' and 密码='" + pass + "'";
            MySqlDataReader dr = OperDB.QuerySQL(sql);
            if (dr.Read())
            {
                Session.Name = name;
                MainFrame mf = new MainFrame();
                mf.Show();
                this.Hide();
                return;

            }
            else
            {
                count++;
                MessageBox.Show("登录失败");
                return;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            register re = new register();
            re.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zhmm zm = new zhmm();

            zm.Show();
            this.Hide();
        }
    }
}
