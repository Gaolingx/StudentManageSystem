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
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
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
    }
}
