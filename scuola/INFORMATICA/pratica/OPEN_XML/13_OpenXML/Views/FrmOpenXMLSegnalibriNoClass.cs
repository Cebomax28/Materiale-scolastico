using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_OpenXML.Views
{
    public partial class FrmOpenXMLSegnalibriNoClass : Form
    {
        StudenteControllerNoCls stuContr = new StudenteControllerNoCls();
        public FrmOpenXMLSegnalibriNoClass()
        {
            InitializeComponent();
            popolaComboClasse();
            txtMatr.Text = stuContr.GetMatricolaRnd();
            dtpDataN.MinDate = new DateTime(2008, 1, 1);
            dtpDataN.MaxDate = new DateTime(2008, 12, 31);
            preparaDgv();
            caricaDgv();
        }

        private void preparaDgv()
        {
            string[] intestazione = {"ID", "CLASSE", "COGNOME", "NOME", 
                                    "DATA NASCITA", "CITTA' NASCITA", 
                                    "RESIDENZA", "INDIRIZZO"};
            dgv.ColumnCount = intestazione.Length;
            
            for(int i = 0; i < intestazione.Length; i++)
                dgv.Columns[i].HeaderText = intestazione[i];

            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true; 
        }

        private void caricaDgv()
        {
            dgv.Rows.Clear();
            for(int i=0; i < stuContr._lstStudenti.Count; i++)
            {
                dgv.Rows.Add(
                    stuContr._lstStudenti[i].Matricola,
                    stuContr.GetClassByCod(stuContr._lstStudenti[i].CodClasse),
                    stuContr._lstStudenti[i].Cognome,
                    stuContr._lstStudenti[i].Nome,
                    stuContr._lstStudenti[i].DataN.ToString("dd/MM/yyyy"),
                    stuContr._lstStudenti[i].CittaN,
                    stuContr._lstStudenti[i].CittaR,
                    stuContr._lstStudenti[i].IndirizzoR
                    );
            }
        }

        private void popolaComboClasse()
        {
            cmbClasse.DisplayMember = "valore";
            cmbClasse.ValueMember = "id";
            cmbClasse.DataSource = stuContr.GetClassi();
        }

        private void btnAddStudente_Click(object sender, EventArgs e)
        {

            Studente stu = new Studente();
            stu.Matricola = txtMatr.Text;
            stu.Cognome = txtCogn.Text; txtCogn.Text = "";
            stu.Nome = txtNome.Text; txtNome.Text = "";
            stu.DataN = dtpDataN.Value;
            stu.CittaN = txtCittaN.Text; txtCittaN.Text = "";
            stu.CittaR = txtCittaR.Text; txtCittaR.Text = "";
            stu.IndirizzoR = txtIndirizzoR.Text; txtIndirizzoR.Text = "";
            stu.CodClasse = (int)cmbClasse.SelectedValue;

            stuContr.addStudente(stu);

            caricaDgv();
            MessageBox.Show("Studente inserito con successo!");
            txtMatr.Text = stuContr.GetMatricolaRnd();
        }

        private void btnCreaPagelle_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fBD = new FolderBrowserDialog();
            string folderPath;
            fBD.Description = "Seleziona cartella di destinazione";

            if(fBD.ShowDialog() == DialogResult.OK)
            {
                folderPath = fBD.SelectedPath + "\\Pagelle";
                if (Directory.Exists(folderPath))
                {
                    Directory.Delete(folderPath, true);
                }
                Directory.CreateDirectory(folderPath);

                File.Copy(
                AppDomain.CurrentDomain.BaseDirectory + "\\template\\template_pagella.docx",
                folderPath + "\\template.docx");

                stuContr.stampaPagelle(folderPath);
                
                File.Delete(folderPath + "\\template.docx");
                MessageBox.Show("Procedura di creazione pagelle terminata!", "Terminato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("explorer.exe", $"/select,\"{folderPath}\"");
            }

        }

        private void btnEliminaAlunni_Click(object sender, EventArgs e)
        {

        }
    }
}
