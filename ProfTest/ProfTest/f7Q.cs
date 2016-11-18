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
    public partial class f7Q : Form
    {
        f8Q f8q = new f8Q();
        public f7Q()
        {
            InitializeComponent();
        }

        private void btnTo8Q_Click(object sender, EventArgs e)
        {
            if (tb7QPublic.Text == "public" && tb7QInt.Text == "int" && tb7QVal.Text == "val") Test.score++;
            f8q.ShowDialog();
        }

        private void f7Q_Activated(object sender, EventArgs e)
        {
            if (Test.toStart || Test.Exit) Close();
        }
    }
}
