using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game323115
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = this.textBox6.Text;
            string pass = this.textBox2.Text;
            string yu = this.textBox4.Text;
            string shu = this.textBox1.Text;
            string home = this.textBox5.Text;
            if (name == "" || pass == "")
            {
                MessageBox.Show("空的！重来！");
                return;
            }
            string sql = "insert into stuinfo2(姓名,密码)  values('" + name + "','" + pass + "')";
            int i = OperDB.EditSQL(sql);
            if (i > 0)
            {
                MessageBox.Show("注册成功");
                return;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 lg = new Form1();
            lg.Show();
            this.Hide();
        }
    }
}
