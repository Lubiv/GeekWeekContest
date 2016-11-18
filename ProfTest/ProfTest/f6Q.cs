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
    public partial class f6Q : Form
    {
        f7Q f7q = new f7Q();
        public f6Q()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbTrue.Checked) Test.score++;
            f7q.ShowDialog();
        }
    }
}
