using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace App_Signature.Services
{
    public class PDFService : IPDFService
    {
        public PdfDocument GeneratePDF(TripModel tripModel, SignatureModel signatureModel)
        {
            try
            {
                var document = new PdfDocument();
                var page = document.AddPage();
                var gfx = XGraphics.FromPdfPage(page);
                var font = new XFont("Montserrat-Regular", 20, XFontStyle.Regular);
                gfx.DrawString("Driver: " + signatureModel.Name, font, XBrushes.Black, new XRect(20, 20, 60, 20), XStringFormats.CenterLeft);
                gfx.DrawImage(XImage.FromStream(() => signatureModel.Signature), new XRect(20, 40, 300, 100));

                return document;
            }
            catch (Exception ex)
            {
                throw new Exception("Beim Erstellen des PDFs ist ein Fehler aufgetreten. Fehler: " + ex.ToString());
            }
        }
    }
}
