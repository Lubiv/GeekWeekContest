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
    public partial class f2Q : Form
    {
        f3Q f3q = new f3Q();
        public f2Q()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbTrue1.Checked && cbTrue2.Checked && cbTrue3.Checked)
            {
                Test.score++;
            }
            f3q.ShowDialog();
        }

        private void f2Q_Activated(object sender, EventArgs e)
        {
            if (Test.toStart || Test.Exit) Close();
        }
    }
}
