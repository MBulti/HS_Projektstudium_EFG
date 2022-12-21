using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Signature.Models
{
    public class TourModel
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
        public List<TourOrderModel> Orders { get; set; }
        public TourModel()
        {
            Orders = new List<TourOrderModel>();
        }
    }

    public class TourOrderModel
    {
        public int OrdercodeNav { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverCountry { get; set; }
        public string ReceiverPostCode { get; set; }
        public string ReceiverCity { get; set; }
        public string CarrierInformation { get; set; }
        public string WeightOrder { get; set; }
        public List<OrderItemModel> Items { get; set; }
        public TourOrderModel()
        {
            Items = new List<OrderItemModel>();
        }
    }
    public class OrderItemModel
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
