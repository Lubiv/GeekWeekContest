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
    public partial class f3Q : Form
    {
        f4Q f4q = new f4Q();
        public f3Q()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb3QAnswer.Text == "10")
            {
                Test.score++;
            }
            f4q.ShowDialog();
        }
    }
}
