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
    public partial class f10Q : Form
    {
        public f10Q()
        {
            InitializeComponent();
        }

        private void btnToResult_Click(object sender, EventArgs e)
        {
            if (rb10QTrue.Checked) Test.score++;

        }
    }
}
