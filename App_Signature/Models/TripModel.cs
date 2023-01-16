using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Signature.Models
{
    public class TripModel
    {
        public int TourNo { get; set; }
        public string Carrier { get; set; }
        public DateTime TourStart { get; set; }
        public DateTime TourEndDate { get; set; }
        public string SenderName { get; set; }
        public string TransportType { get; set; }
        public string SenderAdress { get; set; }
        public string SenderCountry { get; set; }
        public int SenderPostCode { get; set; }
        public string SenderCity { get; set; }
        public string StartCity { get; set; }
        public string EndCity { get; set; }
        public string PalletSpaces { get; set; }
        public decimal WeigthTotal { get; set; }
        public List<TripEventModel> Orders { get; set; }
        public TripModel()
        {
            Orders = new List<TripEventModel>();
        }
    }

    public class TripEventModel
    {
        public int OrdercodeNav { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverCountry { get; set; }
        public string ReceiverPostCode { get; set; }
        public string ReceiverCity { get; set; }
        public string CarrierInformation { get; set; }
        public string WeightOrder { get; set; }
        public List<TripEventDetailModel> Items { get; set; }
        public TripEventModel()
        {
            Items = new List<TripEventDetailModel>();
        }
    }
    public class TripEventDetailModel
    {
        public int ItemCode { get; set; }
        public string Description { get; set; }
        public int Cartons { get; set; }
        public decimal PalletSpaces { get; set; }
        public decimal Weight { get; set; }
        public string Returnables { get; set; }
        public decimal ReturnablesCount { get; set; }
    }
}
