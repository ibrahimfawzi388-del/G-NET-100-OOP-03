using System;
using System.Collections.Generic;
using System.Text;

namespace oop3
{
    public class InternationalShipment : Shipment
    {
        string DestinationCountry;
        decimal CustomsFee;

        public string destinationcountry
        {
            set
            {
                DestinationCountry = !string.IsNullOrWhiteSpace(value) ? value : DestinationCountry;
            }
            get => DestinationCountry;
        }
        public decimal customsfee
        {
            set
            {
                CustomsFee = value >= 0 ? value : CustomsFee;
            }
            get => CustomsFee;
        }
        public override decimal EstimatedCost
        {
            get => base.deliveryfee + (base.weight * 5) + customsfee;
        }

        public InternationalShipment() : base()
        {
            destinationcountry = default;
            customsfee = default;
        }
        public override string ToString()
        {
            Console.WriteLine();
            Console.WriteLine("International Shipment");
            Console.WriteLine();
            Console.WriteLine($"Destion Country : {destinationcountry}");
            Console.WriteLine($"Customs Fee : {customsfee}");
            return base.ToString();
        }
    }
}
