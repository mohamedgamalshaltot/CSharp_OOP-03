using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class ExpressShipment : Shipment
    {
      
        private decimal extraFee;
        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryfee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryfee, destination)
        {
            ExtraFee = extraFee;
        }
        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Extra Fee: {ExtraFee:C}");
        }
        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + ExtraFee;
            }
        }



    }
}
