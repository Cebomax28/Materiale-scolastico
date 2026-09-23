using _13_OpenXML.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_OpenXML.Views
{
    public partial class FrmOpenXMLBase : Form
    {
        private string docxFile;
        public FrmOpenXMLBase()
        {
            InitializeComponent();
        }
        private void FrmOpenXMLBase_Load(object sender, EventArgs e)
        {
            txtPath.Text = AppDomain.CurrentDomain.BaseDirectory;
        }
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            using (var folderBD = new FolderBrowserDialog())
            {
                DialogResult result = folderBD.ShowDialog();

                if (result == DialogResult.OK) 
                {
                    txtPath.Text = folderBD.SelectedPath + "\\";
                }
            }
        }

        private void btnCreaFile_Click(object sender, EventArgs e)
        {
            ClsOpenXml openXml = new ClsOpenXml();

            docxFile = txtPath.Text + ((txtName.Text.Length != 0) ? txtName.Text : "no_name") + ".docx";
            openXml.CreateWord(docxFile);
            MessageBox.Show("File creato correttamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnApriFile_Click(object sender, EventArgs e)
        {
            Process.Start(docxFile);
        }

        private void txtName_KeyPress(object sender, 
                            KeyPressEventArgs e)
        {
            int asciiA = (int)'a';
            int asciiZ = (int)'z';
            int asciiAm = (int)'A';
            int asciiZm = (int)'Z';
            int asciiDot = (int)'.';
            int asciiUnderscore = (int)'_';
            int asciiBackspace = 8;

            int asciiKey = (int)e.KeyChar;

            if ((asciiKey >= asciiA && asciiKey <= asciiZ) ||
                (asciiKey >= asciiAm && asciiKey <= asciiZm) ||
                (asciiKey == asciiDot || asciiKey == asciiUnderscore ||
                asciiKey == asciiBackspace))
            {
                // carattere è valido 
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void btnAddIntestazione_Click(object sender, EventArgs e)
        {
            ClsOpenXml openXml = new ClsOpenXml();
            openXml.AddHeader(docxFile, txtIntestazione.Text);
            btnAddIntestazione.Enabled = false;
        }
        private void btnAddPie_Click(object sender, EventArgs e)
        {
            ClsOpenXml openXml = new ClsOpenXml();
            openXml.AddFooter(docxFile, txtPie.Text);
            btnAddPie.Enabled = false;
        }
        private void btnAddTitolo_Click(object sender, EventArgs e)
        {
            ClsOpenXml openXml = new ClsOpenXml();
            openXml.AddTitleParagraph(docxFile, txtTitolo.Text, 28, "000000", "Arial");
            btnAddTitolo.Enabled = false;
        }
        private void btnAddParagrafo_Click(object sender, EventArgs e)
        {
            ClsOpenXml openXml = new ClsOpenXml();
            openXml.AddParagraph(docxFile, txtParText.Text, 24, "00F514", "Arial");
            txtParText.Text = "";
        }

        private void btnAddTabella_Click(object sender, EventArgs e)
        {
            ClsOpenXml openXml = new ClsOpenXml();
            openXml.AddTablePart(docxFile, (int)nudRighe.Value, (int)nudColonne.Value);
            btnAddTabella.Enabled = false;
        }
    }
}
