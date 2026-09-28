using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode,string description,double weight,decimal deliveryfee,DeliveryAddress destination) 
            :base(trackingCode, description, weight, deliveryfee, destination) 
        {
        }
        public override void PrintShipment()
        {
            base.PrintShipment();
        }
           
    }
}
