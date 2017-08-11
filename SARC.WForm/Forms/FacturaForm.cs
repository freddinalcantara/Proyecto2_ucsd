using SARC.WForm.Domain.EFRepository;
using SARC.WForm.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARC.WForm
{
    public partial class FacturaForm : MetroFramework.Forms.MetroForm
    {

        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();

        // Declare a string to hold the entire document contents.
        private string documentContents;

        // Declare a variable to hold the portion of the document that
        // is not printed.
        private string stringToPrint;


        Order OrdenToFaturar;
        decimal _subTotal;
        decimal Total;
        public FacturaForm(Order orden, decimal subTotal,decimal total)
        {
            InitializeComponent();
            OrdenToFaturar = orden;
      
        }

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            txtSubTotal.Text = string.Format("{0:0.00}", OrdenToFaturar.SubTotal());
            txtTOTAL.Text = string.Format("{0:0.00}", OrdenToFaturar.Total());
            foreach (var detail in OrdenToFaturar.OrderDetails)
            {
                decimal itbis = Math.Round(detail.ItemPrice * 0.18m,2);
              dgvFactura.Rows.Add(detail.Item, string.Format("{0:1M}",itbis.ToString()), detail.ItemPrice);

            }
            dgvFactura.Refresh();

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ReadDocument();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void ReadDocument()
        {
            string docName = "testPage.txt";
            string docPath = @"C:\Users\fredd\Desktop\";
            printDocument1.DocumentName = docName;
            using (FileStream stream = new FileStream(docPath + docName, FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                documentContents = reader.ReadToEnd();
            }
            stringToPrint = documentContents;
        }

        void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
            e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

            // If there are no more pages, reset the string to be printed.
            if (!e.HasMorePages)
                stringToPrint = documentContents;
        }
    }
}
