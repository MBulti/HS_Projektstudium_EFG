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
        public async Task<List<TripModel>> GetTripData()
        {
            await Task.CompletedTask;
            return new List<TripModel>();
        }
    }
}
