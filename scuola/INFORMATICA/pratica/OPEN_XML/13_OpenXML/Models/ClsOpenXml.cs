using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace _13_OpenXML.Models
{
    internal class ClsOpenXml
    {
        // Creazione file word 
        //C:\Users\marco.paschetta\Desktop\4B\nome.docx
        public void CreateWord(string filePath)
        {
            using(WordprocessingDocument wordDocument = 
                        WordprocessingDocument.Create(filePath, 
                                WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document(); // creo il corpo del documento
                Body body = mainPart.Document.AppendChild(new Body());
                // Aggiungo un paragrafo con testo di esempio
                Paragraph paragraph = body.AppendChild(new Paragraph());
                Run run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text("Prova inserimento paragrafo durante la creazione"));
                wordDocument.Save();
            }
        }

        public void AddTitleParagraph(string filePath, string text, int fontSize, string fontColor, string fontFamily)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                Body body = wordDocument.MainDocumentPart.Document.Body;// Sezione del corpo principale del documento
                Paragraph titleParagraph = new Paragraph();// Creazione del nuovo paragrafo
                Run titleRun = new Run(new Text(text));// Creazione del nuovo run per contenere il testo del titolo
                RunProperties titleRunProperties = new RunProperties();// Creazione delle proprietà di formattazione per il run
                FontSize fontSizeValue = new FontSize() { Val = fontSize.ToString() };// Dimensione del carattere
                titleRunProperties.Append(fontSizeValue);
                Color colorValue = new Color() { Val = fontColor };// Colore del carattere
                titleRunProperties.Append(colorValue);
                RunFonts fontType = new RunFonts() { Ascii = fontFamily };// Tipo di carattere
                titleRunProperties.Append(fontType);
                ParagraphProperties titleParagraphProperties = new ParagraphProperties();// Allineamento del testo al centro
                Justification centerAlignment = new Justification() { Val = JustificationValues.Center };
                titleParagraphProperties.Append(centerAlignment);
                titleRun.RunProperties = titleRunProperties;// Collegamento delle proprietà di formattazione al run
                titleParagraph.Append(titleRun);// Aggiunta del run al paragrafo
                titleParagraph.ParagraphProperties = titleParagraphProperties;// Collegamento delle proprietà di formattazione al paragrafo
                body.Append(titleParagraph);// Aggiunta del paragrafo alla sezione del corpo del documento
            }
        }
        public void AddHeader(string filePath, string title)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {

                HeaderPart headerPart = wordDocument.MainDocumentPart.GetPartsOfType<HeaderPart>().FirstOrDefault();// Aggiungi la parte dell'intestazione
                if (headerPart == null)// Se la parte dell'intestazione non esiste, crea una nuova parte dell'intestazione
                {
                    headerPart = wordDocument.MainDocumentPart.AddNewPart<HeaderPart>();
                }
                Header header = new Header();// Crea l'elemento di intestazione
                Paragraph paragraph = new Paragraph(new Run(new Text(title)));// Crea un paragrafo con il testo desiderato
                header.Append(paragraph);// Aggiungi il paragrafo all'intestazione
                                         // Collega l'intestazione alla parte principale del documento
                wordDocument.MainDocumentPart.Document.Body.Append(new HeaderReference() { Id = wordDocument.MainDocumentPart.GetIdOfPart(headerPart) });
                headerPart.Header = header;
                // Salva le modifiche
                headerPart.Header.Save();
            }
        }
        public void AddFooter(string filePath, string title)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = wordDocument.MainDocumentPart; // Ottieni la parte del documento principale
                FooterPart footerPart = mainPart.AddNewPart<FooterPart>(); // Aggiungi la parte del piè di pagina
                string footerPartId = mainPart.GetIdOfPart(footerPart);
                Footer footer = new Footer(); // Crea l'elemento del piè di pagina
                Paragraph paragraph = new Paragraph(new Run(new Text(title))); // Crea un paragrafo con il testo desiderato
                footer.Append(paragraph); // Aggiungi il paragrafo al piè di pagina
                mainPart.Document.Body.Append(new FooterReference() { Id = footerPartId }); // Collega il piè di pagina alla parte principale del documento
                                                                                            // Salva le modifiche
                footerPart.Footer = footer;
                footerPart.Footer.Save();
            }
        }
        public void AddParagraph(string filePath, string text, int fontSize, string fontColor, string fontFamily)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                Body body = wordDocument.MainDocumentPart.Document.Body; // Sezione del corpo principale del documento
                Paragraph titleParagraph = new Paragraph(); // Creazione del nuovo paragrafo
                Run titleRun = new Run(new Text(text));// Creazione del nuovo run per contenere il testo del titolo
                RunProperties titleRunProperties = new RunProperties();// Creazione delle proprietà di formattazione per il run
                FontSize fontSizeValue = new FontSize() { Val = fontSize.ToString() };// Dimensione del carattere
                titleRunProperties.Append(fontSizeValue);
                Color colorValue = new Color() { Val = fontColor };// Colore del carattere
                titleRunProperties.Append(colorValue);
                RunFonts fontType = new RunFonts() { Ascii = fontFamily };// Tipo di carattere
                titleRunProperties.Append(fontType);
                titleRun.RunProperties = titleRunProperties;// Collegamento delle proprietà di formattazione al run
                titleParagraph.Append(titleRun);// Aggiunta del run al paragrafo
                                                // Aggiunta del paragrafo alla sezione del corpo del documento
                body.Append(titleParagraph);
            }
        }

        public void AddTablePart(string filePath, int rows, int cols)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = wordDocument.MainDocumentPart;// Ottieni la parte del documento principale
                Body body = mainPart.Document.AppendChild(new Body());// Aggiungi una sezione al documento
                SectionProperties sectionProps = body.AppendChild(new SectionProperties());
                Table table = new Table();// Aggiungi una tabella con le dimensioni specificate
                TableProperties tableProps = new TableProperties(
                    new TableWidth { Type = TableWidthUnitValues.Pct, Width = "100%" }, // Adatta alla larghezza della pagina
                    new TableLayout { Type = TableLayoutValues.Fixed },
                    new TableBorders(
                        new TopBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                        new BottomBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                        new LeftBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                        new RightBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                        new InsideHorizontalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                        new InsideVerticalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 }
                    )
                );
                table.AppendChild(tableProps);
                for (int row = 0; row <= rows; row++)// Aggiungi righe e colonne con coordinate
                {
                    TableRow tableRow = new TableRow();
                    for (int col = 0; col <= cols; col++)
                    {
                        TableCell tableCell = new TableCell();
                        Paragraph paragraph = new Paragraph();// Aggiungi testo con coordinate nella cella
                        Run run = paragraph.AppendChild(new Run());
                        Text text = run.AppendChild(new Text());

                        if (row == 0 && col == 0)
                        {
                            paragraph.ParagraphProperties = new ParagraphProperties(new Bold());// Grassetto per la cella in alto a sinistra
                        }
                        else if (row == 0 || col == 0)
                        {
                            text.Text = (row == 0) ? $"{col}" : $"{row}";// Grassetto per le intestazioni di riga e colonna
                            paragraph.ParagraphProperties = new ParagraphProperties(new Bold());
                        }
                        else
                        {
                            int result = row * col;// Aggiungi il risultato della moltiplicazione
                            text.Text = result.ToString();
                        }
                        tableCell.Append(paragraph);// Aggiungi il paragrafo alla cella
                        tableRow.Append(tableCell);// Aggiungi la cella alla riga
                    }
                    table.Append(tableRow);// Aggiungi la riga alla tabella
                }
                body.Append(table);// Aggiungi la tabella al corpo del documento
            }
        }

        #region GESTIONE SEGNALIBRI
        public void ChangeBookmark(string filePath, string bookmarkName, string newValue, string colore = "000000")
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                IEnumerable<BookmarkStart> bookmarkStarts = wordDocument.MainDocumentPart.RootElement.Descendants<BookmarkStart>();
                foreach (BookmarkStart bookmarkStart in bookmarkStarts)
                {
                    if (bookmarkStart.Name == bookmarkName)
                    {
                        Run run = bookmarkStart.NextSibling<Run>();
                        if (run.RunProperties == null)// Verifica se RunProperties è null e crealo se necessario
                        {
                            run.RunProperties = new RunProperties();
                        }
                        if (colore != "000000")
                        {
                            run.RunProperties.Append(new Color() { Val = colore });
                        }
                        Text text = run.GetFirstChild<Text>();
                        text.Text = newValue;
                    }
                }
                wordDocument.Save();
            }
        }
        internal void ChangeBookMarkTable(string filePath, int[] voti)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = wordDocument.MainDocumentPart;// Ottieni la parte del documento principale
                Table existingTable = mainPart.Document.Body.Descendants<Table>().FirstOrDefault();// Ottieni la tabella esistente
                if (existingTable != null)
                {
                    TableRow newRow = new TableRow();// Crea una nuova riga
                    // ALTERNATIVA SCORRIMENTO CELLE 
                    //for (int i = 0; i < existingTable.Elements<TableRow>().First().Elements<TableCell>().Count(); i++)
                    for (int j = 0; j < voti.Length; j++)
                    {
                        TableCell newCell = new TableCell(new Paragraph(new Run(new Text(voti[j].ToString()))));
                        newRow.Append(newCell);// Aggiungi la cella alla nuova riga
                    }
                    existingTable.Append(newRow);// Aggiungi la nuova riga alla tabella esistente
                }
                mainPart.Document.Save();// Salva le modifiche al documento
            }
        }
        #endregion
    }
}
