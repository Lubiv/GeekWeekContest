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
    public partial class Main : Form
    {
        f1Q f1q = new f1Q();
        public Main()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            f1q.ShowDialog();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            Test.toStart = false;
            if (Test.Exit)
            {
                Test.Exit = false;
                Close();
            }
        }
    }
}
