using System;
using System.Collections.Generic;
using System.Text;

namespace oop3
{
    internal class ExpressShipment : Shipment
    {
        private decimal ExtraFee;

        public decimal extraFee
        {
            set
            {
                ExtraFee = value >= 0 ? value : ExtraFee;
            }
            get
            {
                return ExtraFee;
            }
        }
        public override decimal EstimatedCost
        {
            get => base.deliveryfee + (base.weight * 5) + extraFee;
        }
        public ExpressShipment() : base()
        {
            extraFee = default;
        }

        public override string ToString()
        {
            Console.WriteLine();
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            Console.WriteLine($"Extra Fee is : {extraFee}");
            return base.ToString();
        }
    }
}
