using System;
using System.Windows.Forms;

namespace Game323115
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
            timer1.Enabled = true;
            this.label1.Text = "欢迎您," + Session.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            string sql = "select * from stuinfo2";
            OperDB.BindBata(sql, this.dataGridView1);
            ReFlash();
        }
        void ReFlash()
        {
            string sql = "select * from stuinfo2";
            OperDB.BindBata(sql, this.dataGridView1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string year = dt.Year + "年";
            string month = dt.Month + "月";
            string day = dt.Day + "日";
            string hour = dt.Hour + "：";
            string minute = dt.Minute + "：";
            string second = dt.Second.ToString();
            this.label2.Text = year + month + day + "" + hour + minute + second;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE stuinfo2 AS s1  JOIN (     SELECT 姓名, SUM(`语文` + `数学` + `英语`) AS sum_score  FROM stuinfo2    GROUP BY 姓名 ) AS s2 ON s1.姓名 = s2.姓名 SET s1.总分 = s2.sum_score; ";
            OperDB.EditSQL(sql);
            ReFlash();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE stuinfo2 AS s1  JOIN (     SELECT 姓名, SUM(`语文` + `数学` + `英语`)/3 AS sum_score  FROM stuinfo2    GROUP BY 姓名 ) AS s2 ON s1.姓名 = s2.姓名 SET s1.平均分 = s2.sum_score; ";
            OperDB.EditSQL(sql);
            ReFlash();
        }
    }
}
