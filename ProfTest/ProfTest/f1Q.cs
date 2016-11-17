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
    public partial class f1Q : Form
    {
        f2Q f2q = new f2Q();
        public f1Q()
        {
            InitializeComponent();
        }

        private void btnTo2Q_Click(object sender, EventArgs e)
        {
            if (rb1QTrue.Checked)
            {
                Test.score++;
            }           
            f2q.ShowDialog();
        }
    }
}
