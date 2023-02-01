using PdfSharpCore.Pdf;

namespace App_Signature.Services
{
    public interface IPDFService
    {
        public PdfDocument GeneratePDF(TripModel tripModel, SignatureModel signatureModel);
    }
}
