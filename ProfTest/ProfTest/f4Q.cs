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
    public partial class f4Q : Form
    {
        f5Q f5q = new f5Q();
        public f4Q()
        {
            InitializeComponent();
        }

        private void btnTo5Q_Click(object sender, EventArgs e)
        {
            if(nud4QAnswer.Value == 4)
            {
                Test.score++;
            }
            f5q.ShowDialog();
        }
    }
}
