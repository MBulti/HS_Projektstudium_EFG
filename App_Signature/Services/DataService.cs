using App_Signature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Signature.Services
{
    public class DataService : IDataService
    {
        #region Declaration
        IPDFService pdfService;
        #endregion

        #region Public
        public DataService(IPDFService iPdfService)
        {
            pdfService = iPdfService;
        }
        public async Task<List<TripModel>> GetTripData()
        {
            await Task.CompletedTask;
            return new List<TripModel>();
        }
        public async Task<bool> ExportSignature(TripModel tripModel, SignatureModel signatureModel)
        {
            var document = pdfService.GeneratePDF(tripModel, signatureModel);
            byte[] fileContents = null;
            using (MemoryStream stream = new MemoryStream())
            {
                document.Save(stream, true);
                fileContents = stream.ToArray();
            }
            await Task.CompletedTask;
            return true;
        }
        #endregion
    }
}
