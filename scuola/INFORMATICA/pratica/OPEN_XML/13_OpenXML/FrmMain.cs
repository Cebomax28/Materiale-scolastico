using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _13_OpenXML.Views;

namespace _13_OpenXML
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOpenXmlBase_Click(object sender, EventArgs e)
        {
            FrmOpenXMLBase frm = new FrmOpenXMLBase();
            frm.ShowDialog();
        }

        private void btnOpenXmlSegnalibri_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenXmlSegnalibriNoCls_Click(object sender, EventArgs e)
        {
            FrmOpenXMLSegnalibriNoClass frm = new FrmOpenXMLSegnalibriNoClass();
            frm.ShowDialog();
        }
    }
}
