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
    public partial class f8Q : Form
    {
        f9Q f9q = new f9Q();
        public f8Q()
        {
            InitializeComponent();
        }

        private void btnTo9Q_Click(object sender, EventArgs e)
        {
            if (tb8QAnswer.Text == "16") Test.score++;
            f9q.ShowDialog();
        }

        private void f8Q_Activated(object sender, EventArgs e)
        {
            if (Test.toStart || Test.Exit) Close();
        }
    }
}
