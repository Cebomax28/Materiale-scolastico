using _14_VideogiochiSQLServer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_VideogiochiSQLServer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnShowGiocatori_Click(object sender, EventArgs e)
        {
            new FrmGiocatori().ShowDialog();
        }

        private void btnShowGiochi_Click(object sender, EventArgs e)
        {
            new FrmGiochi().ShowDialog();
        }

        private void btnShowPartite_Click(object sender, EventArgs e)
        {
            new FrmPartite().ShowDialog();
        }
    }
}
