using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfTest
{
    public partial class f5Q : Form
    {
        f6Q f6q = new f6Q();
        public f5Q()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb5QPublic.Text == "public" && tb5QA.Text == "a") Test.score++;
            f6q.ShowDialog();
        }

        private void f5Q_Activated(object sender, EventArgs e)
        {
            if (Test.toStart || Test.Exit) Close();
        }
    }
}
