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
    public partial class f9Q : Form
    {
        f10Q f10q = new f10Q();
        public f9Q()
        {
            InitializeComponent();
        }

        private void btnTo10Q_Click(object sender, EventArgs e)
        {
            if (tb9QInterface.Text == "interface" && tb9QTwoDots.Text == ":" && tb9QComma.Text == ",") Test.score++;
            f10q.ShowDialog();
        }
    }
}
