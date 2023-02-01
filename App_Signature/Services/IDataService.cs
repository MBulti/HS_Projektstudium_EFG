using App_Signature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Signature.Services
{
    public interface IDataService
    {
        Task<List<TripModel>> GetTripData();

        Task<bool> ExportSignature(TripModel model);
    }
}
